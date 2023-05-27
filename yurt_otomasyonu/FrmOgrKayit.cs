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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bölümleri Listeleme

            SqlCommand komut = new SqlCommand("select BolumAd from Bolumler ", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbBolum.Items.Add(read[0].ToString());
            }
            bgl.baglanti().Close();

            //Odaları Listeleme

            SqlCommand komut2 = new SqlCommand("select Odano from Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                cmbOdaNo.Items.Add(read2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerinin Kayıt Edilme Komutları
            try
            {

                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTc,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdano,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", mskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskDogumTarihi.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtMaıl.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", mskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", richAdres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi");


                //Öğrenci İD'yi labele çekme
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    label12.Text = read[0].ToString();
                }
                bgl.baglanti().Close();

                //Öğrenci Borç Alanı Öluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values(@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Lütfen Yeniden Deneyiniz ");
            }

            //Öğrenci Oda Kontejanı Arttırma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1 ", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
    }
}
