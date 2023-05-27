﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurt_otomasyonu
{
    public partial class FrmOgrListe : Form
    {
        public FrmOgrListe()
        {
            InitializeComponent();
        }

        private void FrmOgrListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet3.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Ogrenci);

        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle frm = new FrmOgrDuzenle();
            frm.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frm.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            frm.veliad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            frm.velitel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            frm.adres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            frm.Show();
        }
    }
}
