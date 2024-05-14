namespace DJ_Joki1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_vards = new System.Windows.Forms.TextBox();
            this.txt_parole = new System.Windows.Forms.TextBox();
            this.button_pieslegties = new System.Windows.Forms.Button();
            this.button_dzest = new System.Windows.Forms.Button();
            this.button_iziet = new System.Windows.Forms.Button();
            this.button_registreties = new System.Windows.Forms.Button();
            this.label_laiks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vārds Uzvārds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parole";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(309, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sveicināti!";
            // 
            // txt_vards
            // 
            this.txt_vards.Location = new System.Drawing.Point(75, 113);
            this.txt_vards.Name = "txt_vards";
            this.txt_vards.Size = new System.Drawing.Size(195, 20);
            this.txt_vards.TabIndex = 3;
            // 
            // txt_parole
            // 
            this.txt_parole.Location = new System.Drawing.Point(75, 195);
            this.txt_parole.Name = "txt_parole";
            this.txt_parole.Size = new System.Drawing.Size(195, 20);
            this.txt_parole.TabIndex = 4;
            // 
            // button_pieslegties
            // 
            this.button_pieslegties.Location = new System.Drawing.Point(319, 251);
            this.button_pieslegties.Name = "button_pieslegties";
            this.button_pieslegties.Size = new System.Drawing.Size(112, 34);
            this.button_pieslegties.TabIndex = 5;
            this.button_pieslegties.Text = "Pieslēgties";
            this.button_pieslegties.UseVisualStyleBackColor = true;
            this.button_pieslegties.Click += new System.EventHandler(this.button_pieslegties_Click);
            // 
            // button_dzest
            // 
            this.button_dzest.Location = new System.Drawing.Point(158, 251);
            this.button_dzest.Name = "button_dzest";
            this.button_dzest.Size = new System.Drawing.Size(112, 34);
            this.button_dzest.TabIndex = 6;
            this.button_dzest.Text = "Dzēst";
            this.button_dzest.UseVisualStyleBackColor = true;
            // 
            // button_iziet
            // 
            this.button_iziet.Location = new System.Drawing.Point(158, 326);
            this.button_iziet.Name = "button_iziet";
            this.button_iziet.Size = new System.Drawing.Size(112, 34);
            this.button_iziet.TabIndex = 7;
            this.button_iziet.Text = "Iziet";
            this.button_iziet.UseVisualStyleBackColor = true;
            // 
            // button_registreties
            // 
            this.button_registreties.Location = new System.Drawing.Point(331, 326);
            this.button_registreties.Name = "button_registreties";
            this.button_registreties.Size = new System.Drawing.Size(100, 34);
            this.button_registreties.TabIndex = 8;
            this.button_registreties.Text = "Reģistrēties";
            this.button_registreties.UseVisualStyleBackColor = true;
            // 
            // label_laiks
            // 
            this.label_laiks.AutoSize = true;
            this.label_laiks.Location = new System.Drawing.Point(227, 378);
            this.label_laiks.Name = "label_laiks";
            this.label_laiks.Size = new System.Drawing.Size(43, 13);
            this.label_laiks.TabIndex = 9;
            this.label_laiks.Text = "Laiks ir:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_laiks);
            this.Controls.Add(this.button_registreties);
            this.Controls.Add(this.button_iziet);
            this.Controls.Add(this.button_dzest);
            this.Controls.Add(this.button_pieslegties);
            this.Controls.Add(this.txt_parole);
            this.Controls.Add(this.txt_vards);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_vards;
        private System.Windows.Forms.TextBox txt_parole;
        private System.Windows.Forms.Button button_pieslegties;
        private System.Windows.Forms.Button button_dzest;
        private System.Windows.Forms.Button button_iziet;
        private System.Windows.Forms.Button button_registreties;
        private System.Windows.Forms.Label label_laiks;
    }
}