

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniYoneticiModulu
{
    public partial class frmLogin : Form
    {
        private Panel pnl;
        private Panel dashboard;
        public frmLogin(Panel panel,Panel dash)
        {
            InitializeComponent();
            pnl = panel;
            dashboard = dash;
        }
        PDukDbContext db = new PDukDbContext();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPassword1.Text) && !string.IsNullOrEmpty(txtUsername.Text))
                {
                    if (db.Admins.Any(x => x.KullaniciAdi == txtUsername.Text && x.Sifre == txtPassword1.Text))
                    {
                        foreach (Control item in pnl.Controls)
                        {
                            
                            if (item.Name.Contains("btn"))
                            {
                                if (item.Name.Contains("btnLogin"))
                                {
                                    item.Visible = false;
                                }
                                else
                                {
                                    item.Visible = true;
                                }                                
                            }
                        }
                        foreach (Control item in dashboard.Controls)
                        {
                            if (item.Name.Contains("lbl"))
                            {
                                item.Text =  txtUsername.Text;
                            }
                        }
                        //albumler sayfasına yönlendirebiliriz
                        this.Close();                        
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş yaptınız.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya şifre yanlış!!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata oluştu.");
            } 
            
        }
        
    }
    
}

// ?ADminn:
