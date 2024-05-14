using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;


namespace DJ_Joki1
{
    

    public partial class Form1 : Form
    {
        // SQLite savienojuma virkne
        string connectionString = @"Data Source=DB_Joki.db;Version=3;";

        // Atbalsta vektoru mašīnas modelis joku novērtēšanai
        SupportVectorMachine<Gaussian> svm;
        Label lblJoke;
        NumericUpDown numRating;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            Initialize();
            InitializeDatabase();
            InitializeSVM();

            // Izveidojam UI
            buttonGenerateJoke.Click += buttonGenerateJoke_Click;
            buttonRateJoke.Click += buttonRateJoke_Click;
        }

        

        private void Initialize()
        {
            lblJoke = new Label();
            lblJoke.Location = new Point(20, 20);
            lblJoke.Size = new Size(300, 100);
            this.Controls.Add(lblJoke);

            numRating = new NumericUpDown();
            numRating.Location = new Point(20, 140);
            numRating.Size = new Size(100, 20);
            numRating.Minimum = 0;
            numRating.Maximum = 10;
            this.Controls.Add(numRating);
        }

        private void InitializeDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Jokes (ID INTEGER PRIMARY KEY AUTOINCREMENT, Joke TEXT, Rating INTEGER)";
                SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
                command.ExecuteNonQuery();
            }
        }

        private void InitializeSVM()
        {
            // SVM inicializācija šajā piemērā nav nepieciešama
        }

        private void buttonGenerateJoke_Click(object sender, EventArgs e)
        {
            int randomIndex = random.Next(chuckNorrisJokes.Length + otherJokes.Length);
            string joke;

            if (randomIndex < chuckNorrisJokes.Length)
            {
                joke = chuckNorrisJokes[randomIndex];
            }
            else
            {
                joke = otherJokes[randomIndex - chuckNorrisJokes.Length];
            }

            lblJoke.Text = joke;
        }

        private void buttonRateJoke_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblJoke.Text))
            {
                MessageBox.Show("Lūdzu, vispirms ģenerējiet joku.", "Nav ģenerēts joks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Saglabājiet joku un vērtējumu datu bāzē
            SaveJokeToDatabase(lblJoke.Text, (int)numRating.Value);
        }

        private void SaveJokeToDatabase(string joke, int rating)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Jokes (Joke, Rating) VALUES (@Joke, @Rating)";
                SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Joke", joke);
                command.Parameters.AddWithValue("@Rating", rating);
                command.ExecuteNonQuery();
            }
        }

        string[] chuckNorrisJokes = { "Čaks Noriss var dalīt ar nulli.", "Kad Čaks Noriss ienāk telpā, viņš neieslēdz gaismu. Viņš izslēdz tumsu.", "Čaks Noriss var dzirdēt zīmju valodu.", "Kad Čaks Noriss palecās, viņš neceļas , viņš nospiež Zemi uz leju." };
        string[] otherJokes = { "Kāpēc zinātnieki netic atomiem? Jo tie veido visu!", "Kāpēc baiļu putns ieguva balvu? Jo viņš bija izcilā stāvoklī savā laukā!", "Es pateicu savai sievai, ka viņa zīmē uzacis pārāk augstu. Viņa izskatījās pārsteigta." };
    }
}
