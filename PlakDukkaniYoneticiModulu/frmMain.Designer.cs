namespace PlakDukkaniYoneticiModulu
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnDiscounts = new FontAwesome.Sharp.IconButton();
            this.btnNewAlbums = new FontAwesome.Sharp.IconButton();
            this.btnOnSales = new FontAwesome.Sharp.IconButton();
            this.btnPast = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnSignIn = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblUserNameMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelBottom = new System.Windows.Forms.Panel();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Controls.Add(this.btnDiscounts);
            this.panelMenu.Controls.Add(this.btnNewAlbums);
            this.panelMenu.Controls.Add(this.btnOnSales);
            this.panelMenu.Controls.Add(this.btnPast);
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.btnSignIn);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 629);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 30;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 509);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(200, 40);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = " LOGIN";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnDiscounts
            // 
            this.btnDiscounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscounts.FlatAppearance.BorderSize = 0;
            this.btnDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscounts.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiscounts.ForeColor = System.Drawing.Color.White;
            this.btnDiscounts.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnDiscounts.IconColor = System.Drawing.Color.White;
            this.btnDiscounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscounts.IconSize = 30;
            this.btnDiscounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscounts.Location = new System.Drawing.Point(0, 340);
            this.btnDiscounts.Name = "btnDiscounts";
            this.btnDiscounts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDiscounts.Size = new System.Drawing.Size(200, 40);
            this.btnDiscounts.TabIndex = 10;
            this.btnDiscounts.Text = " DISCOUNTS";
            this.btnDiscounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscounts.UseVisualStyleBackColor = true;
            this.btnDiscounts.Visible = false;
            this.btnDiscounts.Click += new System.EventHandler(this.btnDiscounts_Click);
            // 
            // btnNewAlbums
            // 
            this.btnNewAlbums.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewAlbums.FlatAppearance.BorderSize = 0;
            this.btnNewAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAlbums.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewAlbums.ForeColor = System.Drawing.Color.White;
            this.btnNewAlbums.IconChar = FontAwesome.Sharp.IconChar.SortAmountDesc;
            this.btnNewAlbums.IconColor = System.Drawing.Color.White;
            this.btnNewAlbums.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewAlbums.IconSize = 30;
            this.btnNewAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAlbums.Location = new System.Drawing.Point(0, 300);
            this.btnNewAlbums.Name = "btnNewAlbums";
            this.btnNewAlbums.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNewAlbums.Size = new System.Drawing.Size(200, 40);
            this.btnNewAlbums.TabIndex = 9;
            this.btnNewAlbums.Text = " NEW ALBUMS";
            this.btnNewAlbums.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewAlbums.UseVisualStyleBackColor = true;
            this.btnNewAlbums.Visible = false;
            this.btnNewAlbums.Click += new System.EventHandler(this.btnNewAlbums_Click);
            // 
            // btnOnSales
            // 
            this.btnOnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOnSales.FlatAppearance.BorderSize = 0;
            this.btnOnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnSales.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnSales.ForeColor = System.Drawing.Color.White;
            this.btnOnSales.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnOnSales.IconColor = System.Drawing.Color.White;
            this.btnOnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOnSales.IconSize = 30;
            this.btnOnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnSales.Location = new System.Drawing.Point(0, 260);
            this.btnOnSales.Name = "btnOnSales";
            this.btnOnSales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOnSales.Size = new System.Drawing.Size(200, 40);
            this.btnOnSales.TabIndex = 8;
            this.btnOnSales.Text = " ON SALES";
            this.btnOnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOnSales.UseVisualStyleBackColor = true;
            this.btnOnSales.Visible = false;
            this.btnOnSales.Click += new System.EventHandler(this.btnOnSales_Click_1);
            // 
            // btnPast
            // 
            this.btnPast.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPast.FlatAppearance.BorderSize = 0;
            this.btnPast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPast.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPast.ForeColor = System.Drawing.Color.White;
            this.btnPast.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnPast.IconColor = System.Drawing.Color.White;
            this.btnPast.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPast.IconSize = 30;
            this.btnPast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPast.Location = new System.Drawing.Point(0, 220);
            this.btnPast.Name = "btnPast";
            this.btnPast.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPast.Size = new System.Drawing.Size(200, 40);
            this.btnPast.TabIndex = 7;
            this.btnPast.Text = " FINISHED WORKS";
            this.btnPast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPast.UseVisualStyleBackColor = true;
            this.btnPast.Visible = false;
            this.btnPast.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 30;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(0, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(200, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "  UPDATE ALBUMES";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.btnSignIn.IconColor = System.Drawing.Color.White;
            this.btnSignIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignIn.IconSize = 30;
            this.btnSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignIn.Location = new System.Drawing.Point(0, 549);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSignIn.Size = new System.Drawing.Size(200, 40);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "  SIGN IN";
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Visible = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 40);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "  HOME";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            this.btnLogOut.IconColor = System.Drawing.Color.White;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 30;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 589);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(200, 40);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "  LOG OUT";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 140);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.SlateGray;
            this.panelDashboard.Controls.Add(this.label2);
            this.panelDashboard.Controls.Add(this.lblUserNameMain);
            this.panelDashboard.Controls.Add(this.label1);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboard.Location = new System.Drawing.Point(200, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(756, 69);
            this.panelDashboard.TabIndex = 1;
            // 
            // lblUserNameMain
            // 
            this.lblUserNameMain.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserNameMain.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUserNameMain.Location = new System.Drawing.Point(525, 37);
            this.lblUserNameMain.Name = "lblUserNameMain";
            this.lblUserNameMain.Size = new System.Drawing.Size(231, 32);
            this.lblUserNameMain.TabIndex = 1;
            this.lblUserNameMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserNameMain.MouseEnter += new System.EventHandler(this.lblUserNameMain_MouseEnter);
            this.lblUserNameMain.MouseLeave += new System.EventHandler(this.lblUserNameMain_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.SlateGray;
            this.panelBottom.Controls.Add(this.ıconButton3);
            this.panelBottom.Controls.Add(this.ıconButton2);
            this.panelBottom.Controls.Add(this.ıconButton1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(200, 601);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(756, 28);
            this.panelBottom.TabIndex = 4;
            // 
            // ıconButton3
            // 
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.ıconButton3.IconColor = System.Drawing.Color.Black;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.IconSize = 29;
            this.ıconButton3.Location = new System.Drawing.Point(723, 0);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(30, 28);
            this.ıconButton3.TabIndex = 2;
            this.ıconButton3.UseVisualStyleBackColor = true;
            // 
            // ıconButton2
            // 
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.ıconButton2.IconColor = System.Drawing.Color.Black;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.IconSize = 30;
            this.ıconButton2.Location = new System.Drawing.Point(687, 0);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(30, 28);
            this.ıconButton2.TabIndex = 1;
            this.ıconButton2.UseVisualStyleBackColor = true;
            // 
            // ıconButton1
            // 
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.ıconButton1.IconColor = System.Drawing.Color.Black;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.IconSize = 30;
            this.ıconButton1.Location = new System.Drawing.Point(651, 0);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(30, 28);
            this.ıconButton1.TabIndex = 0;
            this.ıconButton1.UseVisualStyleBackColor = true;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Sienna;
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 69);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(756, 532);
            this.panelDesktop.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(756, 532);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(609, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoşgeldin";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 629);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Record Shop";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton btnPast;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnSignIn;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserNameMain;
        private System.Windows.Forms.Panel panelBottom;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnDiscounts;
        private FontAwesome.Sharp.IconButton btnNewAlbums;
        private FontAwesome.Sharp.IconButton btnOnSales;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.Label label2;
    }
}

