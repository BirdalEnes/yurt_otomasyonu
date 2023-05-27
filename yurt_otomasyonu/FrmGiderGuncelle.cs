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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        public string elektrik, su, dogalgaz, gida, diger, internet, personel, id;

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtElektrık.Text = elektrik;
            txtSu.Text = su;
            txtDogalGaz.Text = dogalgaz;
            txtGıda.Text = gida;
            txtDıger.Text = diger;
            txtInternet.Text = internet;
            txtPersonel.Text = personel;
            txtGıderıd.Text = id;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p2,Su=@p3,Dogalgaz=@p4,İnternet=@p5,Gıda=@p6,Personel=@p7,Diger=@p8 where Odemeid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtGıderıd.Text);
                komut.Parameters.AddWithValue("@p2", txtElektrık.Text);
                komut.Parameters.AddWithValue("@p3", txtSu.Text);
                komut.Parameters.AddWithValue("@p4", txtDogalGaz.Text);
                komut.Parameters.AddWithValue("@p5", txtInternet.Text);
                komut.Parameters.AddWithValue("@p6", txtGıda.Text);
                komut.Parameters.AddWithValue("@p7", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p8", txtDıger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Yapıldı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyiniz");
            }
        }
    }
}
