namespace HairAndNail
{
    partial class DodajSmjenu
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
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPocetakSmjeneSati = new System.Windows.Forms.TextBox();
            this.txtPocetakSmjeneMinute = new System.Windows.Forms.TextBox();
            this.txtKrajSmjeneSati = new System.Windows.Forms.TextBox();
            this.txtKrajSmjeneMinute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum smjene";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pocetak smjene";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kraj smjene";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtPocetakSmjeneSati
            // 
            this.txtPocetakSmjeneSati.Location = new System.Drawing.Point(133, 120);
            this.txtPocetakSmjeneSati.Name = "txtPocetakSmjeneSati";
            this.txtPocetakSmjeneSati.Size = new System.Drawing.Size(31, 20);
            this.txtPocetakSmjeneSati.TabIndex = 5;
            // 
            // txtPocetakSmjeneMinute
            // 
            this.txtPocetakSmjeneMinute.Location = new System.Drawing.Point(186, 120);
            this.txtPocetakSmjeneMinute.Name = "txtPocetakSmjeneMinute";
            this.txtPocetakSmjeneMinute.Size = new System.Drawing.Size(31, 20);
            this.txtPocetakSmjeneMinute.TabIndex = 6;
            // 
            // txtKrajSmjeneSati
            // 
            this.txtKrajSmjeneSati.Location = new System.Drawing.Point(133, 177);
            this.txtKrajSmjeneSati.Name = "txtKrajSmjeneSati";
            this.txtKrajSmjeneSati.Size = new System.Drawing.Size(31, 20);
            this.txtKrajSmjeneSati.TabIndex = 7;
            // 
            // txtKrajSmjeneMinute
            // 
            this.txtKrajSmjeneMinute.Location = new System.Drawing.Point(186, 177);
            this.txtKrajSmjeneMinute.Name = "txtKrajSmjeneMinute";
            this.txtKrajSmjeneMinute.Size = new System.Drawing.Size(31, 20);
            this.txtKrajSmjeneMinute.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = ":";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(133, 237);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 11;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // DodajSmjenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKrajSmjeneMinute);
            this.Controls.Add(this.txtKrajSmjeneSati);
            this.Controls.Add(this.txtPocetakSmjeneMinute);
            this.Controls.Add(this.txtPocetakSmjeneSati);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajSmjenu";
            this.Text = "DodajSmjenu";
            this.Load += new System.EventHandler(this.DodajSmjenu_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DodajSmjenu_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPocetakSmjeneSati;
        private System.Windows.Forms.TextBox txtPocetakSmjeneMinute;
        private System.Windows.Forms.TextBox txtKrajSmjeneSati;
        private System.Windows.Forms.TextBox txtKrajSmjeneMinute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpremi;
    }
}