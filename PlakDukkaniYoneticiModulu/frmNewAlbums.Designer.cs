namespace PlakDukkaniYoneticiModulu
{
    partial class frmNewAlbums
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNewAlbums = new System.Windows.Forms.DataGridView();
            this.AlbumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanatciGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.dgvNewAlbums);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // dgvNewAlbums
            // 
            this.dgvNewAlbums.AllowUserToAddRows = false;
            this.dgvNewAlbums.AllowUserToDeleteRows = false;
            this.dgvNewAlbums.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvNewAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumAdi,
            this.SanatciGrup});
            this.dgvNewAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNewAlbums.Location = new System.Drawing.Point(0, 0);
            this.dgvNewAlbums.Name = "dgvNewAlbums";
            this.dgvNewAlbums.ReadOnly = true;
            this.dgvNewAlbums.Size = new System.Drawing.Size(800, 450);
            this.dgvNewAlbums.TabIndex = 0;
            // 
            // AlbumAdi
            // 
            this.AlbumAdi.HeaderText = "Album Adı";
            this.AlbumAdi.Name = "AlbumAdi";
            this.AlbumAdi.ReadOnly = true;
            // 
            // SanatciGrup
            // 
            this.SanatciGrup.HeaderText = "Sanatçı/Grup";
            this.SanatciGrup.Name = "SanatciGrup";
            this.SanatciGrup.ReadOnly = true;
            // 
            // frmNewAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmNewAlbums";
            this.Text = "frmNewAlbums";
            this.Load += new System.EventHandler(this.frmNewAlbums_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAlbums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNewAlbums;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanatciGrup;
    }
}