using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}


//1990-07-12 08:45:10.000