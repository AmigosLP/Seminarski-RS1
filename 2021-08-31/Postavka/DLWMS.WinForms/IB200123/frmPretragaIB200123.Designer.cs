namespace DLWMS.WinForms.IB200123
{
    partial class frmPretragaIB200123
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.gbSumiraj = new System.Windows.Forms.GroupBox();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.txtOd = new System.Windows.Forms.TextBox();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.btnTeorija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.gbSumiraj.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv Predmeta:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(119, 27);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(649, 20);
            this.txtPretraga.TabIndex = 1;
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Location = new System.Drawing.Point(31, 67);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.Size = new System.Drawing.Size(737, 270);
            this.dgvPretraga.TabIndex = 2;
            // 
            // gbSumiraj
            // 
            this.gbSumiraj.Controls.Add(this.lblSuma);
            this.gbSumiraj.Controls.Add(this.txtSuma);
            this.gbSumiraj.Controls.Add(this.btnSumiraj);
            this.gbSumiraj.Controls.Add(this.txtDo);
            this.gbSumiraj.Controls.Add(this.txtOd);
            this.gbSumiraj.Controls.Add(this.lblDo);
            this.gbSumiraj.Controls.Add(this.lblOd);
            this.gbSumiraj.Location = new System.Drawing.Point(31, 357);
            this.gbSumiraj.Name = "gbSumiraj";
            this.gbSumiraj.Size = new System.Drawing.Size(475, 134);
            this.gbSumiraj.TabIndex = 3;
            this.gbSumiraj.TabStop = false;
            this.gbSumiraj.Text = "Sumiraj brojeve";
            this.gbSumiraj.Enter += new System.EventHandler(this.gbSumiraj_Enter);
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(21, 31);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(24, 13);
            this.lblOd.TabIndex = 0;
            this.lblOd.Text = "Od:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(124, 31);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(24, 13);
            this.lblDo.TabIndex = 1;
            this.lblDo.Text = "Do:";
            // 
            // txtOd
            // 
            this.txtOd.Location = new System.Drawing.Point(6, 57);
            this.txtOd.Name = "txtOd";
            this.txtOd.Size = new System.Drawing.Size(62, 20);
            this.txtOd.TabIndex = 2;
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(106, 57);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(62, 20);
            this.txtDo.TabIndex = 3;
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(199, 57);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSumiraj.TabIndex = 4;
            this.btnSumiraj.Text = "Sumiraj =>";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(294, 56);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(62, 20);
            this.txtSuma.TabIndex = 5;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(304, 31);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(34, 13);
            this.lblSuma.TabIndex = 6;
            this.lblSuma.Text = "Suma";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(693, 357);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // btnTeorija
            // 
            this.btnTeorija.Location = new System.Drawing.Point(693, 468);
            this.btnTeorija.Name = "btnTeorija";
            this.btnTeorija.Size = new System.Drawing.Size(75, 23);
            this.btnTeorija.TabIndex = 5;
            this.btnTeorija.Text = "Teorija";
            this.btnTeorija.UseVisualStyleBackColor = true;
            // 
            // frmPretragaIB200123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.btnTeorija);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.gbSumiraj);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB200123";
            this.Text = "frmPretragaIB200123";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.gbSumiraj.ResumeLayout(false);
            this.gbSumiraj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.GroupBox gbSumiraj;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.TextBox txtOd;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Button btnTeorija;
    }
}