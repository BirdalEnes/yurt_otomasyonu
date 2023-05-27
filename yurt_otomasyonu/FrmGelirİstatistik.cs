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
    public partial class FrmGelirİstatistik : Form
    {
        public FrmGelirİstatistik()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmGelirİstatistik_Load(object sender, EventArgs e)
        {
            //Kasada ki Toplam Para
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar) from Kasa ", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                lblPara.Text = read[0].ToString() + " TL ";
            }
            bgl.baglanti().Close();

            //Tekrarsız Olarak Ayları Ekleme
            SqlCommand komut2 = new SqlCommand("select distinct(OdemeAy) from Kasa", bgl.baglanti());
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                cmbAySecim.Items.Add(read2[0].ToString());
            }
            bgl.baglanti().Close();

            //Grafiklere veri Tabanından veri çekme

            SqlCommand komut3 = new SqlCommand("select OdemeAy,sum(OdemeMiktar) from Kasa group by OdemeAy", bgl.baglanti());
            SqlDataReader read3 = komut3.ExecuteReader();
            while (read3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(read3[0], read3[1]);
            }
            bgl.baglanti().Close();

        }

        private void cmbAySecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar) from Kasa where OdemeAy=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAySecim.Text);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                lblSecilenAy.Text = read[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
