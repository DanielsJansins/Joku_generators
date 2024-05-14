using System;

namespace DJ_Joki1
{
    partial class Form1
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
            this.buttonGenerateJoke = new System.Windows.Forms.Button();
            this.buttonRateJoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerateJoke
            // 
            this.buttonGenerateJoke.Location = new System.Drawing.Point(292, 306);
            this.buttonGenerateJoke.Name = "buttonGenerateJoke";
            this.buttonGenerateJoke.Size = new System.Drawing.Size(155, 33);
            this.buttonGenerateJoke.TabIndex = 0;
            this.buttonGenerateJoke.Text = "Ģenerēt joku";
            this.buttonGenerateJoke.UseVisualStyleBackColor = true;
            this.buttonGenerateJoke.Click += new System.EventHandler(this.buttonGenerateJoke_Click);
            // 
            // buttonRateJoke
            // 
            this.buttonRateJoke.Location = new System.Drawing.Point(42, 306);
            this.buttonRateJoke.Name = "buttonRateJoke";
            this.buttonRateJoke.Size = new System.Drawing.Size(158, 32);
            this.buttonRateJoke.TabIndex = 1;
            this.buttonRateJoke.Text = "Novērtēt";
            this.buttonRateJoke.UseVisualStyleBackColor = true;
            this.buttonRateJoke.Click += new System.EventHandler(this.buttonRateJoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRateJoke);
            this.Controls.Add(this.buttonGenerateJoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateJoke;
        private System.Windows.Forms.Button buttonRateJoke;
    }
}

