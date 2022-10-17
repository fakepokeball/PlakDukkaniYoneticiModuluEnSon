using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows;
using System.Security.Cryptography;

namespace PlakDukkaniYoneticiModulu
{
    internal class Admin
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int YoneticiId { get; set; }

        [Key]
        [Column(Order = 2), MaxLength(32)]
        public string KullaniciAdi { get; set; }

        [Required, MinLength(8)]
        public string Sifre { get; set; }

        [Required, MaxLength(64)]
        public string AdSoyad { get; set; }
        public DateTime KayitTarihi { get; set; }=DateTime.Now;

        //public static void KayitKontrol(string username, string password, string password2, string nameSurname )
        //{
        //    PDukDbContext db = new PDukDbContext();
        //    try
        //    {
        //        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password2) || string.IsNullOrEmpty(nameSurname))
        //        {
        //            MessageBox.Show("Eksik veya yanlış bilgi girdiniz.");
        //        }
        //        else
        //        {

        //            if (db.Admins.Any(x => x.KullaniciAdi == username))
        //            {
        //                MessageBox.Show("Kullanıcı zaten mevcut!");
        //            }
        //            else
        //            {
        //                if (password != password2)
        //                {
        //                    MessageBox.Show("Şifreler uyuşmuyor!!!");
        //                }
        //                else
        //                {
        //                    char[] pass = password.ToCharArray();
        //                    int kucukHarf = 0;
        //                    int buyukHarf = 0;
        //                    int unlem = 0;
        //                    int ikiNokta = 0;
        //                    int arti = 0;
        //                    int yildiz = 0;

        //                    foreach (char c in pass)
        //                    {
        //                        if (char.IsLetter(c))
        //                        {
        //                            if (char.IsLower(c))
        //                            {
        //                                kucukHarf++;
        //                            }
        //                            else
        //                            {
        //                                buyukHarf++;
        //                            }
        //                        }
        //                        else if (c == '!')
        //                        {
        //                            unlem++;
        //                        }
        //                        else if (c == ':')
        //                        {
        //                            ikiNokta++;
        //                        }
        //                        else if (c == '+')
        //                        {
        //                            arti++;
        //                        }
        //                        else if (c == '*')
        //                        {
        //                            yildiz++;
        //                        }
        //                    }
        //                    int toplamOzelKarakter = yildiz + unlem + ikiNokta + arti;
        //                    if (buyukHarf >= 2 && kucukHarf >= 3 && pass.Length >= 8 && toplamOzelKarakter >= 2)
        //                    {
        //                        if ((unlem > 0 && ikiNokta > 0) || (unlem > 0 && arti > 0) || (unlem > 0 && yildiz > 0) || (ikiNokta > 0 && yildiz > 0) || (ikiNokta > 0 && arti > 0) || (arti > 0 && yildiz > 0))
        //                        {
        //                            Admin admin = new Admin();

        //                            admin.Sifre = sha256_hash(password);
        //                            admin.AdSoyad = nameSurname;
        //                            admin.KullaniciAdi = username;
        //                            admin.KayitTarihi = DateTime.Now;

        //                            db.Admins.Add(admin);
        //                            db.SaveChanges();
        //                            MessageBox.Show("Kayıt Başarılı");

                                    
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Olmadı");
        //                        }
        //                    }


        //                }

        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Bir Hata Oluştu.");
        //    }
        //}
        //public static string sha256_hash(string sifre)
        //{
        //    using (SHA256 hash = SHA256Managed.Create())
        //    {
        //        return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
        //    }
        //}
    }
}


//1990-07-12 08:45:10.000