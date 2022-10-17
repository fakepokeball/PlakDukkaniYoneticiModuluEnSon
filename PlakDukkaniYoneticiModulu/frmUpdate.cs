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
    public partial class frmUpdate : Form
    {
        PDukDbContext db = new PDukDbContext();
        private readonly int id;
        public frmUpdate()
        {
            InitializeComponent();
            AlbumleriYukle();
        }
        private void AlbumleriYukle()
        {
            db.SaveChanges();
            dgvAlbumler.DataSource = null;
            dgvAlbumler.DataSource = db.Albums.ToList();
            dgvAlbumler.ClearSelection();
        }

        private decimal indirimOrani;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDiscountRate.Text))
            {
                indirimOrani = 0m;
            }
            else
            {
                if(!string.IsNullOrEmpty(txtDiscountRate.Text))
                indirimOrani = Convert.ToDecimal(txtDiscountRate.Text);
                else
                {
                    MessageBox.Show("İndirim oranını boş bıraktınız.");
                }
            }
            if(string.IsNullOrEmpty(txtAlbumName.Text) || string.IsNullOrEmpty(txtArtistName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Bilgileri eksik girdiniz.");
            }
            else
            {
                bool albumVarMi = false;
                foreach (Album item in db.Albums)
                {
                    if(item.AlbumAdi == txtAlbumName.Text)
                        albumVarMi = true;                    
                }
                if (albumVarMi == false) 
                {
                    db.Albums.Add(new Album()
                    {
                        AlbumAdi = txtAlbumName.Text,
                        Fiyati = Convert.ToDecimal(txtPrice.Text),
                        SanatciGrup = txtArtistName.Text,
                        CikisTarihi = dateTimePicker1.Value,
                        IndirimliMi = chkIndirim.Checked,
                        SatistaMi = chkSatis.Checked,
                        IndirimOrani = indirimOrani
                    });
                    AlbumleriYukle();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Album zaten mevcut, Update edebilirsiniz.");
                } 
            }
        }
        public void ClearTextBoxes()
        {
            txtAlbumName.Clear();
            txtArtistName.Clear();
            txtDiscountRate.Clear();
            txtPrice.Clear();
            chkIndirim.Checked = false;
            txtDiscountRate.Visible=false;
            chkSatis.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void dgvAlbumler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlbumler.SelectedRows.Count > 0)
            {
                int id = (int)dgvAlbumler.SelectedRows[0].Cells[0].Value;
                Album goruntulenecekAlbum = db.Albums.FirstOrDefault(x => x.AlbumId == id);
                txtAlbumName.Text = goruntulenecekAlbum.AlbumAdi;
                txtArtistName.Text = goruntulenecekAlbum.SanatciGrup;
                txtPrice.Text = goruntulenecekAlbum.Fiyati.ToString();
                chkIndirim.Checked = goruntulenecekAlbum.IndirimliMi;
                txtDiscountRate.Text = goruntulenecekAlbum.IndirimOrani.ToString();
                dateTimePicker1.Value = goruntulenecekAlbum.CikisTarihi;
                chkSatis.Checked = goruntulenecekAlbum.SatistaMi;
            }
        }
        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                txtDiscountRate.Visible = true;
            }
            else
            {
                txtDiscountRate.Visible = false;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscountRate.Text))
            {
                indirimOrani = 0m;
            }
            else
            {
                if (!string.IsNullOrEmpty(txtDiscountRate.Text))
                    indirimOrani = Convert.ToDecimal(txtDiscountRate.Text);
                else
                {
                    MessageBox.Show("İndirim oranını boş bıraktınız.");
                }
            }
            if (string.IsNullOrEmpty(txtAlbumName.Text) || string.IsNullOrEmpty(txtArtistName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Bilgileri eksik girdiniz.");
            }
            else
            {
                int id = (int)dgvAlbumler.SelectedRows[0].Cells[0].Value;
                Album guncellenecekAlbum = db.Albums.FirstOrDefault(x => x.AlbumId == id);
                guncellenecekAlbum.AlbumAdi = txtAlbumName.Text;
                guncellenecekAlbum.SanatciGrup = txtArtistName.Text;
                guncellenecekAlbum.Fiyati = Convert.ToDecimal(txtPrice.Text);
                guncellenecekAlbum.IndirimliMi = chkIndirim.Checked;
                if (string.IsNullOrEmpty(txtDiscountRate.Text))
                {
                    guncellenecekAlbum.IndirimOrani = 0;
                }
                guncellenecekAlbum.IndirimOrani = Convert.ToDecimal(txtDiscountRate.Text);
                guncellenecekAlbum.CikisTarihi = dateTimePicker1.Value;
                guncellenecekAlbum.SatistaMi = chkSatis.Checked;

                AlbumleriYukle();
                ClearTextBoxes();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr==DialogResult.Yes)
            {
                int id = (int)dgvAlbumler.SelectedRows[0].Cells[0].Value;
                Album silinecekAlbum = db.Albums.FirstOrDefault(x => x.AlbumId == id);
                db.Albums.Remove(silinecekAlbum);
                AlbumleriYukle();
                ClearTextBoxes();
            }

        }
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
            dgvAlbumler.ClearSelection();
        }
    }
}
