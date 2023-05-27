using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yurt_otomasyonu
{
    public partial class FrmOdemler : Form
    {
        public FrmOdemler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmOdemler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtKalanBorc.Text = kalan;
            txtOgrıd.Text = id;
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            //ödenen tutarı kalan borçtan düşme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(txtOdenen.Text);
            kalan = Convert.ToInt16(txtKalanBorc.Text);
            yeniborc = kalan - odenen;
            txtKalanBorc.Text = yeniborc.ToString();

            //yeni tutarı veritabanına kayıt etme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where OgrID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtOgrıd.Text);
            komut.Parameters.AddWithValue("@p1", txtKalanBorc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Borclar);

            //Kasa Tablosunu Ekleme Yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values(@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", txtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", txtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
    }
}
