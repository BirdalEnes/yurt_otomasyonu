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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        public string id, ad, soyad, TC, telefon, dogum, bolum;

        private void btnSıl_Click(object sender, EventArgs e)
        {
            // Öğrenci Silme
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where ogrid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", txtOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

            //Odanın Aktif Öğrenci Sayısını Azaltma

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public string mail, odano, veliad, velitel, adres;

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtOgrid.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskTC.Text = TC;
            mskTelefon.Text = telefon;
            mskDogumTarihi.Text = dogum;
            cmbBolum.Text = bolum;
            txtMaıl.Text = mail;
            cmbOdaNo.Text = odano;
            txtVeliAdSoyad.Text = veliad;
            mskVeliTelefon.Text = velitel;
            richAdres.Text = adres;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskTC.Text);
                komut.Parameters.AddWithValue("@p5", mskTelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskDogumTarihi.Text);
                komut.Parameters.AddWithValue("@p7", cmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", txtMaıl.Text);
                komut.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", richAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata, Yeniden Deneyiniz ");
            }
        }


    }
}
