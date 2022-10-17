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
    public partial class frmFinished : Form
    {
        PDukDbContext db = new PDukDbContext();
        
        public frmFinished()
        {
            InitializeComponent();
            AlbumleriYenile();

        }

        private void AlbumleriYenile()
        {
            dgvFinishedWork.Rows.Clear();
            foreach (Album item in db.Albums.ToList())
            {
                if (!item.SatistaMi)
                {

                    dgvFinishedWork.Rows.Add(item.AlbumAdi, item.SanatciGrup);
                }

            }
        }

        private void frmFinished_Load(object sender, EventArgs e)
        {
            AlbumleriYenile();
        }
    }
}
