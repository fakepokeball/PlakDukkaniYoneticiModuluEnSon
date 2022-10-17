using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu
{
    internal class Album
    {
        [Key]
        //id gözükmesin istersek private yapcaz
        public int AlbumId { get; set; }

        [Required, MaxLength(32)]
        public string AlbumAdi { get; set; }

        [Required, MaxLength(64)]
        public string SanatciGrup { get; set; }

        [Required]
        public DateTime CikisTarihi { get; set; }

        [Required]
        public decimal Fiyati { get; set; }
        public decimal IndirimOrani { get; set; }
        public bool IndirimliMi { get; set; }


        [Required]
        public bool SatistaMi { get; set; }
    }
}
