namespace HairAndNail
{
    partial class UpravljanjePopustima
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
            this.dgvPopust = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAzurirajPopust = new System.Windows.Forms.Button();
            this.btnObrisiPopust = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopust)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopust
            // 
            this.dgvPopust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopust.Location = new System.Drawing.Point(24, 58);
            this.dgvPopust.Name = "dgvPopust";
            this.dgvPopust.Size = new System.Drawing.Size(627, 210);
            this.dgvPopust.TabIndex = 0;
            this.dgvPopust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopust_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregled popusta";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(100, 333);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(95, 38);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj Popust";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAzurirajPopust
            // 
            this.btnAzurirajPopust.Location = new System.Drawing.Point(294, 333);
            this.btnAzurirajPopust.Name = "btnAzurirajPopust";
            this.btnAzurirajPopust.Size = new System.Drawing.Size(92, 38);
            this.btnAzurirajPopust.TabIndex = 3;
            this.btnAzurirajPopust.Text = "Azuriraj Popust";
            this.btnAzurirajPopust.UseVisualStyleBackColor = true;
            this.btnAzurirajPopust.Click += new System.EventHandler(this.btnAzurirajPopust_Click);
            // 
            // btnObrisiPopust
            // 
            this.btnObrisiPopust.Location = new System.Drawing.Point(491, 333);
            this.btnObrisiPopust.Name = "btnObrisiPopust";
            this.btnObrisiPopust.Size = new System.Drawing.Size(93, 38);
            this.btnObrisiPopust.TabIndex = 4;
            this.btnObrisiPopust.Text = "Obrisi Popust";
            this.btnObrisiPopust.UseVisualStyleBackColor = true;
            this.btnObrisiPopust.Click += new System.EventHandler(this.btnObrisiPopust_Click);
            // 
            // UpravljanjePopustima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiPopust);
            this.Controls.Add(this.btnAzurirajPopust);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopust);
            this.Name = "UpravljanjePopustima";
            this.Text = "UpravljanjePopustima";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.UpravljanjePopustima_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAzurirajPopust;
        private System.Windows.Forms.Button btnObrisiPopust;
    }
}