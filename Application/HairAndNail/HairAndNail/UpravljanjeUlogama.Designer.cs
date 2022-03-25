namespace HairAndNail
{
    partial class UpravljanjeUlogama
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
            this.dgvTipKorisnika = new System.Windows.Forms.DataGridView();
            this.cmbUloge = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodajUloguTipu = new System.Windows.Forms.Button();
            this.btnObrisiUloguTipu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipKorisnika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uloge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip korisnika";
            // 
            // dgvTipKorisnika
            // 
            this.dgvTipKorisnika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipKorisnika.Location = new System.Drawing.Point(35, 53);
            this.dgvTipKorisnika.Name = "dgvTipKorisnika";
            this.dgvTipKorisnika.Size = new System.Drawing.Size(337, 150);
            this.dgvTipKorisnika.TabIndex = 3;
            // 
            // cmbUloge
            // 
            this.cmbUloge.FormattingEnabled = true;
            this.cmbUloge.Location = new System.Drawing.Point(35, 272);
            this.cmbUloge.Name = "cmbUloge";
            this.cmbUloge.Size = new System.Drawing.Size(149, 21);
            this.cmbUloge.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(465, 145);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(103, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj tip";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(588, 145);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(86, 23);
            this.btnAzuriraj.TabIndex = 6;
            this.btnAzuriraj.Text = "Azuriraj tip";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(694, 145);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(80, 23);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obriši tip";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(598, 53);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(127, 20);
            this.txtNaziv.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Naziv uloge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Opis uloge";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(598, 98);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(127, 20);
            this.txtOpis.TabIndex = 12;
            // 
            // btnDodajUloguTipu
            // 
            this.btnDodajUloguTipu.Location = new System.Drawing.Point(63, 331);
            this.btnDodajUloguTipu.Name = "btnDodajUloguTipu";
            this.btnDodajUloguTipu.Size = new System.Drawing.Size(75, 40);
            this.btnDodajUloguTipu.TabIndex = 13;
            this.btnDodajUloguTipu.Text = "Dodaj ulogu tipu";
            this.btnDodajUloguTipu.UseVisualStyleBackColor = true;
            this.btnDodajUloguTipu.Click += new System.EventHandler(this.btnDodajUloguTipu_Click);
            // 
            // btnObrisiUloguTipu
            // 
            this.btnObrisiUloguTipu.Location = new System.Drawing.Point(227, 331);
            this.btnObrisiUloguTipu.Name = "btnObrisiUloguTipu";
            this.btnObrisiUloguTipu.Size = new System.Drawing.Size(75, 40);
            this.btnObrisiUloguTipu.TabIndex = 15;
            this.btnObrisiUloguTipu.Text = "Obrisi ulogu tipu";
            this.btnObrisiUloguTipu.UseVisualStyleBackColor = true;
            this.btnObrisiUloguTipu.Click += new System.EventHandler(this.btnObrisiUloguTipu_Click);
            // 
            // UpravljanjeUlogama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.btnObrisiUloguTipu);
            this.Controls.Add(this.btnDodajUloguTipu);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbUloge);
            this.Controls.Add(this.dgvTipKorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpravljanjeUlogama";
            this.Text = "UpravljanjeUlogama";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.UpravljanjeUlogama_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipKorisnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTipKorisnika;
        private System.Windows.Forms.ComboBox cmbUloge;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDodajUloguTipu;
        private System.Windows.Forms.Button btnObrisiUloguTipu;
    }
}