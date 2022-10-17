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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }
        PDukDbContext db = new PDukDbContext();
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword1.Text) || string.IsNullOrEmpty(txtPassword2.Text) || string.IsNullOrEmpty(txtAdSoyad.Text))
                {
                    MessageBox.Show("Eksik veya yanlış bilgi girdiniz.");
                }
                else
                {
                    
                    if (db.Admins.Any(x => x.KullaniciAdi == txtUsername.Text))
                    {
                        MessageBox.Show("Kullanıcı zaten mevcut!");
                    }
                    else
                    {
                        if (txtPassword1.Text != txtPassword2.Text)
                        {
                            MessageBox.Show("Şifreler uyuşmuyor!!!");
                        }
                        else
                        {
                            char[] pass = txtPassword1.Text.ToCharArray();
                            int kucukHarf = 0;
                            int buyukHarf = 0;
                            int unlem = 0;
                            int ikiNokta = 0;
                            int arti = 0;
                            int yildiz = 0;
                            
                            foreach (char c in pass)
                            {
                                if (char.IsLetter(c))
                                {
                                    if (char.IsLower(c))
                                    {
                                        kucukHarf++;
                                    }
                                    else
                                    {
                                        buyukHarf++;
                                    }
                                }
                                else if (c == '!')
                                {
                                    unlem++;
                                }
                                else if (c == ':')
                                {
                                    ikiNokta++;
                                }
                                else if (c == '+')
                                {
                                    arti++;
                                }
                                else if (c == '*')
                                {
                                    yildiz++;
                                }
                            }
                            int toplamOzelKarakter = yildiz + unlem + ikiNokta + arti;
                            if (buyukHarf >= 2 && kucukHarf>=3 && pass.Length>=8 && toplamOzelKarakter>=2 )
                            {
                                if ((unlem>0&&ikiNokta>0)|| (unlem > 0 && arti > 0) || (unlem > 0 && yildiz > 0) || (ikiNokta > 0 && yildiz > 0) || (ikiNokta > 0 && arti > 0) || (arti > 0 && yildiz > 0))
                                {  
                                    Admin admin = new Admin();

                                    admin.Sifre = sha256_hash(txtPassword1.Text);
                                    admin.AdSoyad = txtAdSoyad.Text;
                                    admin.KullaniciAdi = txtUsername.Text;
                                    admin.KayitTarihi = DateTime.Now;

                                    db.Admins.Add(admin);
                                    db.SaveChanges();
                                    MessageBox.Show("Kayıt Başarılı");

                                    txtAdSoyad.Clear();
                                    txtPassword1.Clear();
                                    txtPassword2.Clear();
                                    txtUsername.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Olmadı");
                                }
                            }
                            

                        }

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu.");
            }


        }
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
    }
}
