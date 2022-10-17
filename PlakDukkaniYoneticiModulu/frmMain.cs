using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniYoneticiModulu
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }
        public void FormAc(Form form)
        {
            panelDesktop.Controls.Clear();
            form.MdiParent = this;
            panelDesktop.Controls.Add(form);
            form.BringToFront();
            form.FormBorderStyle = FormBorderStyle.None;
            form.Height = panelDesktop.Height;
            form.Width = panelDesktop.Width;
            form.Show();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmUpdate());
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmSignIn());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(pictureBox2);
            pictureBox2.Parent = panelDesktop;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmFinished());
        }

        
        private void btnOnSales_Click_1(object sender, EventArgs e)
        {
            this.FormAc(new frmOnSales());
        }

        private void btnNewAlbums_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmNewAlbums());
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmDiscounts());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmLogin(this.panelMenu,this.panelDashboard));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr=MessageBox.Show("UYARI","Çıkış yapmak istiyor musunuz?", MessageBoxButtons.YesNo ,MessageBoxIcon.Warning );
                if (dr==DialogResult.Yes)
                {
                    foreach (Control item in panelMenu.Controls)
                    {

                        if (item.Name.Contains("btn"))
                        {
                            if (item.Name.Contains("btnLogin"))
                            {
                                item.Visible = true;
                            }
                            else if (item.Name.Contains("btnHome"))
                            {
                                item.Visible = true;
                            }
                            else
                            {
                                item.Visible = false;
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata oluştu.");
            }
        }

     

        private void lblUserNameMain_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lblUserNameMain_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void lblUserNameMain_Click(object sender, EventArgs e)
        {

        }
    }
}
