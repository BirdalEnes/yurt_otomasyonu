namespace yurt_otomasyonu
{
    partial class frmBolumler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pcBolumSil = new System.Windows.Forms.PictureBox();
            this.pcBolumDuzenle = new System.Windows.Forms.PictureBox();
            this.pcBolumEkle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBolumID = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet = new yurt_otomasyonu.YurtOtomasyonuDataSet();
            this.bolumlerTableAdapter = new yurt_otomasyonu.YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBolumSil
            // 
            this.pcBolumSil.Image = global::yurt_otomasyonu.Properties.Resources.çarpı;
            this.pcBolumSil.Location = new System.Drawing.Point(275, 9);
            this.pcBolumSil.Name = "pcBolumSil";
            this.pcBolumSil.Size = new System.Drawing.Size(53, 49);
            this.pcBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBolumSil.TabIndex = 2;
            this.pcBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcBolumSil, "Bölüm Sil");
            this.pcBolumSil.Click += new System.EventHandler(this.pcBolumSil_Click);
            // 
            // pcBolumDuzenle
            // 
            this.pcBolumDuzenle.Image = global::yurt_otomasyonu.Properties.Resources.kalem;
            this.pcBolumDuzenle.Location = new System.Drawing.Point(334, 9);
            this.pcBolumDuzenle.Name = "pcBolumDuzenle";
            this.pcBolumDuzenle.Size = new System.Drawing.Size(53, 49);
            this.pcBolumDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBolumDuzenle.TabIndex = 1;
            this.pcBolumDuzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcBolumDuzenle, "Bölüm Güncelle");
            this.pcBolumDuzenle.Click += new System.EventHandler(this.pcBolumDuzenle_Click);
            // 
            // pcBolumEkle
            // 
            this.pcBolumEkle.Image = global::yurt_otomasyonu.Properties.Resources.artı;
            this.pcBolumEkle.Location = new System.Drawing.Point(216, 9);
            this.pcBolumEkle.Name = "pcBolumEkle";
            this.pcBolumEkle.Size = new System.Drawing.Size(53, 49);
            this.pcBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBolumEkle.TabIndex = 0;
            this.pcBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcBolumEkle, "Bölüm Ekle");
            this.pcBolumEkle.Click += new System.EventHandler(this.pcBolumEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bölüm Ad";
            // 
            // txtBolumID
            // 
            this.txtBolumID.Enabled = false;
            this.txtBolumID.Location = new System.Drawing.Point(68, 9);
            this.txtBolumID.Name = "txtBolumID";
            this.txtBolumID.Size = new System.Drawing.Size(136, 20);
            this.txtBolumID.TabIndex = 5;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Location = new System.Drawing.Point(68, 35);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(136, 20);
            this.txtBolumAd.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 279);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonuDataSet;
            // 
            // yurtOtomasyonuDataSet
            // 
            this.yurtOtomasyonuDataSet.DataSetName = "YurtOtomasyonuDataSet";
            this.yurtOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(396, 343);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.txtBolumID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcBolumSil);
            this.Controls.Add(this.pcBolumDuzenle);
            this.Controls.Add(this.pcBolumEkle);
            this.Name = "frmBolumler";
            this.Text = "Bölüm Ekleme";
            this.Load += new System.EventHandler(this.frmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBolumEkle;
        private System.Windows.Forms.PictureBox pcBolumDuzenle;
        private System.Windows.Forms.PictureBox pcBolumSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBolumID;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet yurtOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}