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
    public partial class frmDiscounts : Form
    {
        PDukDbContext db= new PDukDbContext();
        public frmDiscounts()
        {
            InitializeComponent();
            AlbumleriYenile();
        }

        private void frmDiscounts_Load(object sender, EventArgs e)
        {
            AlbumleriYenile();
        }
        public void AlbumleriYenile()
        {

            List<Album> indirimliAlbumler = db.Albums.Where(x => x.IndirimliMi == true).OrderByDescending(x => x.IndirimOrani).ToList();


            dgvDiscounts.Rows.Clear();
            foreach (Album item in indirimliAlbumler)
            {
                dgvDiscounts.Rows.Add(item.AlbumAdi, item.SanatciGrup);
            }
        }
    }
}
