namespace PlakDukkaniYoneticiModulu
{
    partial class frmOnSales
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
            this.dgvOnSales = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AlbumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanatciGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOnSales
            // 
            this.dgvOnSales.AllowUserToAddRows = false;
            this.dgvOnSales.AllowUserToDeleteRows = false;
            this.dgvOnSales.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvOnSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumAdi,
            this.SanatciGrup});
            this.dgvOnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOnSales.Location = new System.Drawing.Point(0, 0);
            this.dgvOnSales.Name = "dgvOnSales";
            this.dgvOnSales.ReadOnly = true;
            this.dgvOnSales.Size = new System.Drawing.Size(800, 450);
            this.dgvOnSales.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.dgvOnSales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // AlbumAdi
            // 
            this.AlbumAdi.HeaderText = "Album Adı";
            this.AlbumAdi.Name = "AlbumAdi";
            this.AlbumAdi.ReadOnly = true;
            // 
            // SanatciGrup
            // 
            this.SanatciGrup.HeaderText = "Sanatci/Grup";
            this.SanatciGrup.Name = "SanatciGrup";
            this.SanatciGrup.ReadOnly = true;
            // 
            // frmOnSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmOnSales";
            this.Text = "frmOnSales";
            this.Load += new System.EventHandler(this.frmOnSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOnSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanatciGrup;
        private System.Windows.Forms.Panel panel1;
    }
}