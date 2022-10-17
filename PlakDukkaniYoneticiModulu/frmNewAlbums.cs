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
    public partial class frmNewAlbums : Form
    {
        PDukDbContext db = new PDukDbContext();
        public frmNewAlbums()
        {
            InitializeComponent();
            AlbumleriYenile();
        }

        private void frmNewAlbums_Load(object sender, EventArgs e)
        {
            AlbumleriYenile();
        }
        public void AlbumleriYenile()
        {

            List<Album> indirimliAlbumler = db.Albums.OrderByDescending(x => x.AlbumId).Take(10).ToList();


            dgvNewAlbums.Rows.Clear();
            foreach (Album item in indirimliAlbumler)
            {
                dgvNewAlbums.Rows.Add(item.AlbumAdi, item.SanatciGrup);
            }
        }
    }
}
