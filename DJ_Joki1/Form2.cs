using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace DJ_Joki1
{
    public partial class Form2 : Form
    {
        SQLiteConnection conn;
        Timer timer;

        public Form2()
        {
            InitializeComponent();
            conn = new SQLiteConnection(@"Data Source=DB_Joki.db;Version=3;");

            // Pievienojiet notikuma apstrādātāju FormClosed notikumam
            this.FormClosed += Form2_FormClosed;

            // Inicializējiet timer kontroli
            timer = new Timer();
            timer.Interval = 60000; // intervāls milisekundēs (piemēram, 60000ms = 1 minūte)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public class TimeResponse
        {
            public string datetime { get; set; }
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            // Iegūst jauno laiku un atjauno formu
            await UpdateTime();
        }

        private async Task<string> GetLatvianTime()
        {
            using (var client = new HttpClient())
            {
                // Iestatiet API adresi, lai iegūtu Latvijas laiku
                string apiUrl = "http://worldtimeapi.org/api/timezone/Europe/Riga";

                // Veiciet GET pieprasījumu uz API
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Pārbaudiet, vai atbildē ir veiksmīgs atbildes kods
                if (response.IsSuccessStatusCode)
                {
                    // Izgūstam atbildes saturu kā JSON
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    // Deserializēt JSON atbildi uz klasi
                    var timeResponse = JsonConvert.DeserializeObject<TimeResponse>(jsonContent);

                    // Iegūstam laiku no atbildes
                    string dateTimeString = timeResponse.datetime;

                    return dateTimeString;
                }
                else
                {
                    return null;
                }
            }
        }

        private async Task UpdateTime()
        {
            // Izgūstam Latvijas laiku un atjaunojam formu
            string responseContent = await GetLatvianTime();
            if (responseContent != null)
            {
                // Parādiet laiku lietotājam
                label_laiks.Text = $"Pašreizējais laiks Latvijā: {responseContent}";
            }
            else
            {
                MessageBox.Show("Nevarēja iegūt laika informāciju.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            // Izgūstam un parādām laiku, kad forma tiek ielādēta
            await UpdateTime();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Slēdz un atbrīvo datubāzes savienojumu
            CloseConnection();
        }

        private void CloseConnection()
        {
            try
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // Varat apstrādāt izņēmumu šeit, ja nepieciešams
            }
            finally
            {
                conn.Dispose();
            }
        }

        private void button_iziet_Click(object sender, EventArgs e)
        {
            // Aizveram pašreizējo formu (Form2)
            this.Close();

            // Atveram Form1
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button_pieslegties_Click(object sender, EventArgs e)
        {
            string Lietotājs, Parole;

            Lietotājs = txt_vards.Text;
            Parole = txt_parole.Text;

            try
            {
                conn.Open();
                string query = "SELECT * FROM Lietotājs WHERE Lietotājs = @Lietotājs AND Parole = @Parole";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Lietotājs", Lietotājs);
                cmd.Parameters.AddWithValue("@Parole", Parole);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Lietotājs autentificēts!", "Pieslēgšanās veiksmīga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Autentifikācija neizdevās. Nepareizs lietotājvārds vai parole.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kļūda: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_registreties_Click(object sender, EventArgs e)
        {
            string Lietotājs, Parole;

            Lietotājs = txt_vards.Text;
            Parole = txt_parole.Text;

            try
            {
                conn.Open();
                string query = "INSERT INTO Lietotājs (Lietotājs, Parole) VALUES (@Lietotājs, @Parole)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Lietotājs", Lietotājs);
                cmd.Parameters.AddWithValue("@Parole", Parole);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lietotājs veiksmīgi reģistrēts!", "Reģistrācija veiksmīga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kļūda: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_dzest_Click(object sender, EventArgs e)
        {
            // Izdzēš ievades laukus
            txt_vards.Text = "";
            txt_parole.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Jūsu kods šeit...
        }
    }
}