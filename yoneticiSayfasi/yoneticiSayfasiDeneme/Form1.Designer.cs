using System.Windows.Forms;

namespace yoneticiSayfasiDeneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Kullanıcılar = new System.Windows.Forms.GroupBox();
            this.kullaniciGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.calisanGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalisanSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkullanici_id = new System.Windows.Forms.TextBox();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.txtKategoriEkle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Kategoriler = new System.Windows.Forms.GroupBox();
            this.kategoriGridView = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.grpBoxUrunEkleme = new System.Windows.Forms.GroupBox();
            this.txtKategori_idEkle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUrunResmiEkleme = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunFiyatiEkle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrunAciklamaEkle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrunAdiEkle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpBoxUrunGuncelleme = new System.Windows.Forms.GroupBox();
            this.txtKategori_idGuncelle = new System.Windows.Forms.TextBox();
            this.txtUrunResmiGuncelle = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.txtUrunFiyatiGuncelle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunAciklamaGuncelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunAdiGuncelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.fazlaSatisYapanCalisanlarGridView = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.enAzSatılanUrunlerGridView = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.maxGelirUrunlerGridView = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.musteriSatinAlmaBilgiGridView = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.cmbRaporTuru = new System.Windows.Forms.ComboBox();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Kullanıcılar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calisanGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.Kategoriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpBoxUrunEkleme.SuspendLayout();
            this.grpBoxUrunGuncelleme.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fazlaSatisYapanCalisanlarGridView)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enAzSatılanUrunlerGridView)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxGelirUrunlerGridView)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriSatinAlmaBilgiGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 679);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Kullanıcılar);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Çalışan Yönetimi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Kullanıcılar
            // 
            this.Kullanıcılar.Controls.Add(this.kullaniciGridView);
            this.Kullanıcılar.Location = new System.Drawing.Point(8, 6);
            this.Kullanıcılar.Name = "Kullanıcılar";
            this.Kullanıcılar.Size = new System.Drawing.Size(621, 282);
            this.Kullanıcılar.TabIndex = 10;
            this.Kullanıcılar.TabStop = false;
            this.Kullanıcılar.Text = "Kullanıcılar";
            // 
            // kullaniciGridView
            // 
            this.kullaniciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullaniciGridView.Location = new System.Drawing.Point(-3, 23);
            this.kullaniciGridView.Name = "kullaniciGridView";
            this.kullaniciGridView.ReadOnly = true;
            this.kullaniciGridView.Size = new System.Drawing.Size(625, 253);
            this.kullaniciGridView.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.calisanGridView);
            this.groupBox4.Location = new System.Drawing.Point(8, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(621, 333);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Çalışanlar";
            // 
            // calisanGridView
            // 
            this.calisanGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calisanGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.calisanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calisanGridView.Location = new System.Drawing.Point(6, 23);
            this.calisanGridView.Name = "calisanGridView";
            this.calisanGridView.ReadOnly = true;
            this.calisanGridView.Size = new System.Drawing.Size(609, 304);
            this.calisanGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalisanSil);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(640, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 327);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çalışan Silme";
            // 
            // btnCalisanSil
            // 
            this.btnCalisanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanSil.Location = new System.Drawing.Point(209, 140);
            this.btnCalisanSil.Name = "btnCalisanSil";
            this.btnCalisanSil.Size = new System.Drawing.Size(169, 29);
            this.btnCalisanSil.TabIndex = 4;
            this.btnCalisanSil.Text = "Sil";
            this.btnCalisanSil.UseVisualStyleBackColor = true;
            this.btnCalisanSil.Click += new System.EventHandler(this.btnCalisanSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Silmek İstediğiniz Çalışan Satırını Seçip Sil Butonuna tıklayınız";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTcNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtkullanici_id);
            this.groupBox1.Controls.Add(this.btnCalisanEkle);
            this.groupBox1.Location = new System.Drawing.Point(635, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 285);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çallışan Ekleme";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(0, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(272, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Çalışanın TC Kimlik Numarasını Giriniz";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(280, 111);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(137, 24);
            this.txtTcNo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çalışan olarak eklemek istediğiniz kullanicinin ID sini giriniz";
            // 
            // txtkullanici_id
            // 
            this.txtkullanici_id.Location = new System.Drawing.Point(438, 46);
            this.txtkullanici_id.Name = "txtkullanici_id";
            this.txtkullanici_id.Size = new System.Drawing.Size(56, 24);
            this.txtkullanici_id.TabIndex = 2;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanEkle.Location = new System.Drawing.Point(225, 175);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(137, 58);
            this.btnCalisanEkle.TabIndex = 3;
            this.btnCalisanEkle.Text = "Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.Kategoriler);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.grpBoxUrunEkleme);
            this.tabPage2.Controls.Add(this.grpBoxUrunGuncelleme);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Menü Yönetimi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnKategoriSil);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.btnKategoriEkle);
            this.groupBox6.Controls.Add(this.txtKategoriEkle);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(476, 382);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(390, 252);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kategori İşlemleri";
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(21, 189);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(75, 23);
            this.btnKategoriSil.TabIndex = 4;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(242, 18);
            this.label18.TabIndex = 3;
            this.label18.Text = "Silmek İstediğiniz Kategoriyi Seçiniz";
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(20, 111);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(95, 23);
            this.btnKategoriEkle.TabIndex = 2;
            this.btnKategoriEkle.Text = "Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // txtKategoriEkle
            // 
            this.txtKategoriEkle.Location = new System.Drawing.Point(6, 74);
            this.txtKategoriEkle.Name = "txtKategoriEkle";
            this.txtKategoriEkle.Size = new System.Drawing.Size(287, 24);
            this.txtKategoriEkle.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(293, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Eklemek İstediğiniz Kategorinin Adını Giriniz";
            // 
            // Kategoriler
            // 
            this.Kategoriler.Controls.Add(this.kategoriGridView);
            this.Kategoriler.Location = new System.Drawing.Point(3, 382);
            this.Kategoriler.Name = "Kategoriler";
            this.Kategoriler.Size = new System.Drawing.Size(473, 258);
            this.Kategoriler.TabIndex = 8;
            this.Kategoriler.TabStop = false;
            this.Kategoriler.Text = "Kategoriler";
            // 
            // kategoriGridView
            // 
            this.kategoriGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kategoriGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategoriGridView.Location = new System.Drawing.Point(-1, 23);
            this.kategoriGridView.Name = "kategoriGridView";
            this.kategoriGridView.ReadOnly = true;
            this.kategoriGridView.Size = new System.Drawing.Size(468, 229);
            this.kategoriGridView.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.menuGridView);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(467, 373);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Urunler";
            // 
            // menuGridView
            // 
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGridView.Location = new System.Drawing.Point(-3, 23);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            this.menuGridView.Size = new System.Drawing.Size(468, 350);
            this.menuGridView.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnUrunSil);
            this.groupBox3.Location = new System.Drawing.Point(866, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 123);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Urun Silme";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(11, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(367, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Silmek İstediğiniz Ürünü Seçtiğinizden Emin Olun !!";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(149, 72);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(82, 29);
            this.btnUrunSil.TabIndex = 4;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // grpBoxUrunEkleme
            // 
            this.grpBoxUrunEkleme.AutoSize = true;
            this.grpBoxUrunEkleme.Controls.Add(this.txtKategori_idEkle);
            this.grpBoxUrunEkleme.Controls.Add(this.label19);
            this.grpBoxUrunEkleme.Controls.Add(this.txtUrunResmiEkleme);
            this.grpBoxUrunEkleme.Controls.Add(this.label16);
            this.grpBoxUrunEkleme.Controls.Add(this.btnUrunEkle);
            this.grpBoxUrunEkleme.Controls.Add(this.txtUrunFiyatiEkle);
            this.grpBoxUrunEkleme.Controls.Add(this.label7);
            this.grpBoxUrunEkleme.Controls.Add(this.txtUrunAciklamaEkle);
            this.grpBoxUrunEkleme.Controls.Add(this.label8);
            this.grpBoxUrunEkleme.Controls.Add(this.txtUrunAdiEkle);
            this.grpBoxUrunEkleme.Controls.Add(this.label9);
            this.grpBoxUrunEkleme.Controls.Add(this.label10);
            this.grpBoxUrunEkleme.Location = new System.Drawing.Point(479, 13);
            this.grpBoxUrunEkleme.Name = "grpBoxUrunEkleme";
            this.grpBoxUrunEkleme.Size = new System.Drawing.Size(372, 381);
            this.grpBoxUrunEkleme.TabIndex = 2;
            this.grpBoxUrunEkleme.TabStop = false;
            this.grpBoxUrunEkleme.Text = "Ürün Ekleme";
            // 
            // txtKategori_idEkle
            // 
            this.txtKategori_idEkle.Location = new System.Drawing.Point(96, 43);
            this.txtKategori_idEkle.Name = "txtKategori_idEkle";
            this.txtKategori_idEkle.Size = new System.Drawing.Size(49, 24);
            this.txtKategori_idEkle.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 18);
            this.label19.TabIndex = 12;
            this.label19.Text = "Kategori ID";
            // 
            // txtUrunResmiEkleme
            // 
            this.txtUrunResmiEkleme.Location = new System.Drawing.Point(228, 128);
            this.txtUrunResmiEkleme.Name = "txtUrunResmiEkleme";
            this.txtUrunResmiEkleme.Size = new System.Drawing.Size(135, 24);
            this.txtUrunResmiEkleme.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(213, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "Urun Resminin Dosya Konumu";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(141, 314);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(90, 34);
            this.btnUrunEkle.TabIndex = 7;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrunFiyatiEkle
            // 
            this.txtUrunFiyatiEkle.Location = new System.Drawing.Point(96, 101);
            this.txtUrunFiyatiEkle.Name = "txtUrunFiyatiEkle";
            this.txtUrunFiyatiEkle.Size = new System.Drawing.Size(46, 24);
            this.txtUrunFiyatiEkle.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ürün Fiyatı";
            // 
            // txtUrunAciklamaEkle
            // 
            this.txtUrunAciklamaEkle.Location = new System.Drawing.Point(12, 197);
            this.txtUrunAciklamaEkle.Multiline = true;
            this.txtUrunAciklamaEkle.Name = "txtUrunAciklamaEkle";
            this.txtUrunAciklamaEkle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUrunAciklamaEkle.Size = new System.Drawing.Size(354, 104);
            this.txtUrunAciklamaEkle.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ürün Açıklaması";
            // 
            // txtUrunAdiEkle
            // 
            this.txtUrunAdiEkle.Location = new System.Drawing.Point(96, 71);
            this.txtUrunAdiEkle.Name = "txtUrunAdiEkle";
            this.txtUrunAdiEkle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUrunAdiEkle.Size = new System.Drawing.Size(85, 24);
            this.txtUrunAdiEkle.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ürün Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(318, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ürün Eklemek için Aşşağıdaki Alanları Doldurun";
            // 
            // grpBoxUrunGuncelleme
            // 
            this.grpBoxUrunGuncelleme.AutoSize = true;
            this.grpBoxUrunGuncelleme.Controls.Add(this.txtKategori_idGuncelle);
            this.grpBoxUrunGuncelleme.Controls.Add(this.txtUrunResmiGuncelle);
            this.grpBoxUrunGuncelleme.Controls.Add(this.label17);
            this.grpBoxUrunGuncelleme.Controls.Add(this.label15);
            this.grpBoxUrunGuncelleme.Controls.Add(this.btnUrunGuncelle);
            this.grpBoxUrunGuncelleme.Controls.Add(this.txtUrunFiyatiGuncelle);
            this.grpBoxUrunGuncelleme.Controls.Add(this.label6);
            this.grpBoxUrunGuncelleme.Controls.Add(this.txtUrunAciklamaGuncelle);
            this.grpBoxUrunGuncelleme.Controls.Add(this.label5);
            this.grpBoxUrunGuncelleme.Controls.Add(this.txtUrunAdiGuncelle);
            this.grpBoxUrunGuncelleme.Controls.Add(this.label4);
            this.grpBoxUrunGuncelleme.Controls.Add(this.label3);
            this.grpBoxUrunGuncelleme.Location = new System.Drawing.Point(866, 3);
            this.grpBoxUrunGuncelleme.Name = "grpBoxUrunGuncelleme";
            this.grpBoxUrunGuncelleme.Size = new System.Drawing.Size(384, 387);
            this.grpBoxUrunGuncelleme.TabIndex = 1;
            this.grpBoxUrunGuncelleme.TabStop = false;
            this.grpBoxUrunGuncelleme.Text = "Ürün Güncelleme";
            // 
            // txtKategori_idGuncelle
            // 
            this.txtKategori_idGuncelle.Location = new System.Drawing.Point(87, 47);
            this.txtKategori_idGuncelle.Name = "txtKategori_idGuncelle";
            this.txtKategori_idGuncelle.Size = new System.Drawing.Size(49, 24);
            this.txtKategori_idGuncelle.TabIndex = 13;
            // 
            // txtUrunResmiGuncelle
            // 
            this.txtUrunResmiGuncelle.Location = new System.Drawing.Point(228, 141);
            this.txtUrunResmiGuncelle.Name = "txtUrunResmiGuncelle";
            this.txtUrunResmiGuncelle.Size = new System.Drawing.Size(135, 24);
            this.txtUrunResmiGuncelle.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 18);
            this.label17.TabIndex = 12;
            this.label17.Text = "Kategori ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(213, 18);
            this.label15.TabIndex = 8;
            this.label15.Text = "Urun Resminin Dosya Konumu";
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(149, 324);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(88, 34);
            this.btnUrunGuncelle.TabIndex = 7;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // txtUrunFiyatiGuncelle
            // 
            this.txtUrunFiyatiGuncelle.Location = new System.Drawing.Point(87, 117);
            this.txtUrunFiyatiGuncelle.Name = "txtUrunFiyatiGuncelle";
            this.txtUrunFiyatiGuncelle.Size = new System.Drawing.Size(49, 24);
            this.txtUrunFiyatiGuncelle.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ürün Fiyatı";
            // 
            // txtUrunAciklamaGuncelle
            // 
            this.txtUrunAciklamaGuncelle.Location = new System.Drawing.Point(6, 196);
            this.txtUrunAciklamaGuncelle.Multiline = true;
            this.txtUrunAciklamaGuncelle.Name = "txtUrunAciklamaGuncelle";
            this.txtUrunAciklamaGuncelle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUrunAciklamaGuncelle.Size = new System.Drawing.Size(363, 105);
            this.txtUrunAciklamaGuncelle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Açıklaması";
            // 
            // txtUrunAdiGuncelle
            // 
            this.txtUrunAdiGuncelle.Location = new System.Drawing.Point(87, 84);
            this.txtUrunAdiGuncelle.Name = "txtUrunAdiGuncelle";
            this.txtUrunAdiGuncelle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUrunAdiGuncelle.Size = new System.Drawing.Size(111, 24);
            this.txtUrunAdiGuncelle.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güncellemek İstediğiniz Ürünü Seçtiğinizden Emin Olun";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.btnGetReport);
            this.tabPage3.Controls.Add(this.cmbRaporTuru);
            this.tabPage3.Controls.Add(this.dtpBaslangicTarihi);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1235, 648);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sipariş Ve İşlem Raporları";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.fazlaSatisYapanCalisanlarGridView);
            this.groupBox10.Location = new System.Drawing.Point(920, 367);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(307, 230);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "En Fazla Satış Yapan Çalışanlar";
            // 
            // fazlaSatisYapanCalisanlarGridView
            // 
            this.fazlaSatisYapanCalisanlarGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fazlaSatisYapanCalisanlarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fazlaSatisYapanCalisanlarGridView.Location = new System.Drawing.Point(0, 23);
            this.fazlaSatisYapanCalisanlarGridView.Name = "fazlaSatisYapanCalisanlarGridView";
            this.fazlaSatisYapanCalisanlarGridView.Size = new System.Drawing.Size(301, 207);
            this.fazlaSatisYapanCalisanlarGridView.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.enAzSatılanUrunlerGridView);
            this.groupBox9.Location = new System.Drawing.Point(693, 367);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(221, 230);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "En Az Satılan Urunler";
            // 
            // enAzSatılanUrunlerGridView
            // 
            this.enAzSatılanUrunlerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enAzSatılanUrunlerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enAzSatılanUrunlerGridView.Location = new System.Drawing.Point(0, 23);
            this.enAzSatılanUrunlerGridView.Name = "enAzSatılanUrunlerGridView";
            this.enAzSatılanUrunlerGridView.Size = new System.Drawing.Size(221, 209);
            this.enAzSatılanUrunlerGridView.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.maxGelirUrunlerGridView);
            this.groupBox8.Location = new System.Drawing.Point(382, 367);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(305, 230);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "En fazla Gelir Getiren Urunler";
            // 
            // maxGelirUrunlerGridView
            // 
            this.maxGelirUrunlerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.maxGelirUrunlerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maxGelirUrunlerGridView.Location = new System.Drawing.Point(0, 23);
            this.maxGelirUrunlerGridView.Name = "maxGelirUrunlerGridView";
            this.maxGelirUrunlerGridView.Size = new System.Drawing.Size(305, 207);
            this.maxGelirUrunlerGridView.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.musteriSatinAlmaBilgiGridView);
            this.groupBox7.Location = new System.Drawing.Point(8, 367);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(368, 232);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Musteri Urun Satın Alma Alışkanlıkları";
            // 
            // musteriSatinAlmaBilgiGridView
            // 
            this.musteriSatinAlmaBilgiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.musteriSatinAlmaBilgiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriSatinAlmaBilgiGridView.Location = new System.Drawing.Point(6, 23);
            this.musteriSatinAlmaBilgiGridView.Name = "musteriSatinAlmaBilgiGridView";
            this.musteriSatinAlmaBilgiGridView.Size = new System.Drawing.Size(362, 219);
            this.musteriSatinAlmaBilgiGridView.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(455, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(341, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(818, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 270);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(243, 213);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(124, 23);
            this.btnGetReport.TabIndex = 2;
            this.btnGetReport.Text = "Raporları Getir";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // cmbRaporTuru
            // 
            this.cmbRaporTuru.FormattingEnabled = true;
            this.cmbRaporTuru.Items.AddRange(new object[] {
            "Günlük",
            "Aylık",
            "Yıllık"});
            this.cmbRaporTuru.Location = new System.Drawing.Point(42, 27);
            this.cmbRaporTuru.Name = "cmbRaporTuru";
            this.cmbRaporTuru.Size = new System.Drawing.Size(121, 26);
            this.cmbRaporTuru.TabIndex = 1;
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(200, 27);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(214, 24);
            this.dtpBaslangicTarihi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 679);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Kullanıcılar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calisanGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.Kategoriler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpBoxUrunEkleme.ResumeLayout(false);
            this.grpBoxUrunEkleme.PerformLayout();
            this.grpBoxUrunGuncelleme.ResumeLayout(false);
            this.grpBoxUrunGuncelleme.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fazlaSatisYapanCalisanlarGridView)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enAzSatılanUrunlerGridView)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxGelirUrunlerGridView)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musteriSatinAlmaBilgiGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView calisanGridView;
        private System.Windows.Forms.TextBox txtkullanici_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.Button btnCalisanSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBoxUrunGuncelleme;
        private System.Windows.Forms.TextBox txtUrunAdiGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.TextBox txtUrunAciklamaGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunFiyatiGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.GroupBox grpBoxUrunEkleme;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunFiyatiEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUrunAciklamaEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrunAdiEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Label label11;
        private GroupBox groupBox1;
        private DataGridView kullaniciGridView;
        private Label label12;
        private TextBox txtTcNo;
        private GroupBox groupBox2;
        private DataGridView kategoriGridView;
        private GroupBox groupBox3;
        private GroupBox Kullanıcılar;
        private GroupBox groupBox4;
        private GroupBox Kategoriler;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button btnKategoriEkle;
        private TextBox txtKategoriEkle;
        private Label label14;
        private TextBox txtUrunResmiEkleme;
        private Label label16;
        private TextBox txtUrunResmiGuncelle;
        private Label label15;
        private TextBox txtKategori_idGuncelle;
        private Label label17;
        private Button btnKategoriSil;
        private Label label18;
        private TextBox txtKategori_idEkle;
        private Label label19;
        private ComboBox cmbRaporTuru;
        private DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private Button btnGetReport;
        private DataGridView musteriSatinAlmaBilgiGridView;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private DataGridView maxGelirUrunlerGridView;
        private GroupBox groupBox9;
        private DataGridView enAzSatılanUrunlerGridView;
        private GroupBox groupBox10;
        private DataGridView fazlaSatisYapanCalisanlarGridView;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}

