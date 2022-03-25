namespace HairAndNail
{
    partial class PregledPopusta
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
            this.dgvPopust = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopust)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ponuđeni popusti";
            // 
            // dgvPopust
            // 
            this.dgvPopust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopust.Location = new System.Drawing.Point(31, 197);
            this.dgvPopust.Name = "dgvPopust";
            this.dgvPopust.Size = new System.Drawing.Size(541, 171);
            this.dgvPopust.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odaberi salon";
            // 
            // cmbSalon
            // 
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(31, 62);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(121, 21);
            this.cmbSalon.TabIndex = 3;
            this.cmbSalon.SelectedIndexChanged += new System.EventHandler(this.cmbSalon_SelectedIndexChanged);
            this.cmbSalon.ValueMemberChanged += new System.EventHandler(this.cmbSalon_ValueMemberChanged);
            this.cmbSalon.SelectedValueChanged += new System.EventHandler(this.cmbSalon_SelectedValueChanged);
            this.cmbSalon.MouseLeave += new System.EventHandler(this.cmbSalon_MouseLeave);
            // 
            // PregledPopusta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSalon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPopust);
            this.Controls.Add(this.label1);
            this.Name = "PregledPopusta";
            this.Text = "PregledPopusta";
            this.Load += new System.EventHandler(this.PregledPopusta_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PregledPopusta_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPopust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSalon;
    }
}