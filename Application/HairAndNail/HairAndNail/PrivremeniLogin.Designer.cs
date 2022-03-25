namespace HairAndNail
{
    partial class PrivremeniLogin
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
            this.cmbKorisnickoIme = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime *simulirana funkcionalnost*";
            // 
            // cmbKorisnickoIme
            // 
            this.cmbKorisnickoIme.FormattingEnabled = true;
            this.cmbKorisnickoIme.Location = new System.Drawing.Point(53, 82);
            this.cmbKorisnickoIme.Name = "cmbKorisnickoIme";
            this.cmbKorisnickoIme.Size = new System.Drawing.Size(121, 21);
            this.cmbKorisnickoIme.TabIndex = 1;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(53, 139);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Login";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // PrivremeniLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 636);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbKorisnickoIme);
            this.Controls.Add(this.label1);
            this.Name = "PrivremeniLogin";
            this.Text = "PrivremeniLogin";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PrivremeniLogin_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKorisnickoIme;
        private System.Windows.Forms.Button btnSpremi;
    }
}