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
using System.Xml.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace yoneticiSayfasiDeneme
{
    public partial class Form1 : Form
    {

        string conString = "Data Source=DESKTOP-E1J91J1\\SQLEXPRESS;Initial Catalog=fastburger;Integrated Security=True";
        public Form1()
        {
            
            InitializeComponent();
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            cmbRaporTuru.SelectedIndex = 0;
        }
        private void getCalisanData()
        {
            using (SqlConnection Connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT*FROM calisanlar", Connection);

                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = table;

                calisanGridView.DataSource = bindingSource;
            }
        }
        private void getKullaniiciData()
        {
            using (SqlConnection Connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT*FROM kullanicilar", Connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bindingSource = new BindingSource(); 
                bindingSource.DataSource = table;
                
                kullaniciGridView.DataSource = bindingSource;
            }
        }
        private void getMenuData()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT*FROM urunler", connection);
                
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = table;

                menuGridView.DataSource = bindingSource;

            }
        }
        private void getKategoriData()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT*FROM kategoriler", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = table;

                kategoriGridView.DataSource = bindingSource;
            }
        }
        private void getMusteriSatinAlmaBilgi()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "SELECT kullanicilar.ad, kullanicilar.soyad, urunler.urun_adi, SUM(satis_detaylari.adet) AS toplam_adet " +
               "FROM satislar " +
               "JOIN satis_detaylari ON satislar.satis_id = satis_detaylari.satis_id " +
               "JOIN urunler ON satis_detaylari.urun_id = urunler.urun_id " +
               "JOIN kullanicilar ON satislar.kullanici_id = kullanicilar.kullanici_id " +
               "GROUP BY kullanicilar.ad, kullanicilar.soyad, urunler.urun_adi " +
               "ORDER BY toplam_adet DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = table;

                musteriSatinAlmaBilgiGridView.DataSource = bindingSource;
            }
        }
        private void getMaxGelirUrunler()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "SELECT urunler.urun_adi, SUM(satis_detaylari.adet) AS toplam_gelir" +
                    " FROM   satis_detaylari" +
                    " JOIN urunler ON satis_detaylari.urun_id = urunler.urun_id " +
                    "GROUP BY    urunler.urun_adi " +
                    "ORDER BY    toplam_gelir DESC";
                SqlDataAdapter adapter = new SqlDataAdapter( query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = table;
                
                maxGelirUrunlerGridView.DataSource = bindingSource;
            }
        }
        private void getEnAzSatılanUrunler()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                String query = "SELECT urunler.urun_adi,  SUM(satis_detaylari.adet) AS toplam_adet " +
                    "FROM     satis_detaylari " +
                    "JOIN   urunler ON satis_detaylari.urun_id = urunler.urun_id " +
                    "GROUP BY   urunler.urun_adi " +
                    "ORDER BY    toplam_adet ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = table;

                enAzSatılanUrunlerGridView.DataSource= bindingSource;
                

            }
        }
        private void getFazlaSatisYapanCalisanlar()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Sütun alias adı olarak "Satis_Sayisi" kullanmak daha güvenli
                string query = "SELECT calisanlar.calisan_id, " +
                    "CONCAT(kullanicilar.ad, ' ', kullanicilar.soyad) AS ad_soyad, " + // Ad ve Soyad'ı birleştiriyoruz
                    "SUM(satis_detaylari.adet) AS Satis_Sayisi " +
                    "FROM satislar " +
                    "JOIN satis_detaylari ON satislar.satis_id = satis_detaylari.satis_id " +
                    "JOIN calisanlar ON satislar.kullanici_id = calisanlar.kullanici_id " +
                    "JOIN kullanicilar ON calisanlar.kullanici_id = kullanicilar.kullanici_id " +
                    "GROUP BY calisanlar.calisan_id, kullanicilar.ad, kullanicilar.soyad " + // GROUP BY kısmında her iki sütun yer almalı
                    "ORDER BY Satis_Sayisi DESC"; // Burada alias ismi ile sıralama yapıyoruz

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                connection.Open(); // Bağlantıyı açıyoruz
                adapter.Fill(table);
                connection.Close(); // Bağlantıyı kapatıyoruz

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = table;

                fazlaSatisYapanCalisanlarGridView.DataSource = bindingSource;
            }
        }







        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // İlk sekme seçildiyse
            {
                getCalisanData();
                getKullaniiciData();
            }
            else if (tabControl1.SelectedIndex == 1) 
            {
                getMenuData();
                getKategoriData();
            }
            else if(tabControl1.SelectedIndex == 2) 
            {
                getMusteriSatinAlmaBilgi();
                getMaxGelirUrunler();
                getEnAzSatılanUrunler();
                getFazlaSatisYapanCalisanlar();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getCalisanData();
            getKullaniiciData();
            
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkullanici_id.Text))
            {
                MessageBox.Show("Lütfen Geçerli bir kullanici_id girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
            }

            using (SqlConnection connection = new SqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    // Kullanıcı ID'nin mevcut olup olmadığını kontrol et
                    string checkQuery = "SELECT COUNT(1) FROM calisanlar WHERE kullanici_id = @kullanici_id";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@kullanici_id", int.Parse(txtkullanici_id.Text));

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Bu kullanıcı zaten çalışan olarak kayıtlı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Eğer kullanıcı daha önce eklenmemişse, ekleme işlemi yapılır
                    string query = "INSERT INTO calisanlar (kullanici_id, yetki, tc_no, ise_giris_tarihi) " +
                                   "VALUES (@kullanici_id, 1, @tc_no, GETDATE())";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullanici_id", int.Parse(txtkullanici_id.Text));
                    command.Parameters.AddWithValue("@tc_no", txtTcNo.Text);
                    

                    command.ExecuteNonQuery();

                    MessageBox.Show("Çalışan başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Verileri yeniden yüklemek için
                    getCalisanData();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Geçersiz giriş türü " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (calisanGridView.SelectedRows.Count > 0)
                {
                    int kullanici_id = Convert.ToInt32(calisanGridView.SelectedCells[1].Value);

                    using (SqlConnection connection = new SqlConnection(conString))
                    {
                        string query = "DELETE FROM calisanlar WHERE kullanici_id=@kullanici_id";
                        string query1 = "DELETE FROM kullanicilar WHERE kullanici_id=@kullanici_id";

                        SqlCommand command1 = new SqlCommand(query1, connection);
                        command1.Parameters.AddWithValue("@kullanici_id", kullanici_id);

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@kullanici_id", kullanici_id);

                        connection.Open();

                        // Execute the DELETE commands
                        command.ExecuteNonQuery();
                        command1.ExecuteNonQuery();

                        connection.Close();

                        // Refresh data
                        getKullaniiciData();
                        getCalisanData();

                        MessageBox.Show("Çalışan Silindi");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçiniz.");
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL exceptions
                MessageBox.Show($"SQL Hatası: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other type of exception
                MessageBox.Show($"Beklenmedik bir hata oluştu: {ex.Message}");
            }
        }




        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected
                if (menuGridView.SelectedRows.Count > 0)
                {
                    // Get the selected product ID from the grid view
                    int urunID = Convert.ToInt32(menuGridView.SelectedCells[0].Value);

                    // Define the SQL connection
                    using (SqlConnection connection = new SqlConnection(conString))
                    {
                        // Update query to modify product details
                        string query = "UPDATE urunler SET kategori_id=@kategori_id, urunAdi=@urunAdi, urunFiyati=@urunFiyati, urun_img=@urun_img, urunAciklamasi=@urunAciklamasi WHERE urunID=@urunID";

                        // Create the SQL command and add parameters
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@kategori_id", int.Parse(txtKategori_idGuncelle.Text));
                        command.Parameters.AddWithValue("@urunAdi", txtUrunAdiGuncelle.Text);
                        command.Parameters.AddWithValue("@urunFiyati", decimal.Parse(txtUrunFiyatiGuncelle.Text)); // Use decimal for prices
                        command.Parameters.AddWithValue("@urun_img", txtUrunResmiGuncelle.Text);
                        command.Parameters.AddWithValue("@urunAciklamasi", txtUrunAciklamaGuncelle.Text);
                        command.Parameters.AddWithValue("@urunID", urunID);

                        // Open the connection, execute the query, and close the connection
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        // Reload the data and show a success message
                        getMenuData();
                        MessageBox.Show("Ürün Güncellendi.");
                    }
                }
                else
                {
                    // Inform the user if no row is selected
                    MessageBox.Show("Lütfen bir satır seçiniz.");
                }
            }
            catch (FormatException fe)
            {
                // Handle format exceptions (e.g., parsing text as number)
                MessageBox.Show("Veri formatında bir hata oluştu. Lütfen tüm alanları doğru formatta girin.");
                // Optionally log the exception (fe.Message)
            }
            catch (SqlException se)
            {
                // Handle SQL exceptions (e.g., connection or query errors)
                MessageBox.Show("Veritabanı hatası oluştu. Lütfen tekrar deneyin.");
                // Optionally log the exception (se.Message)
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show("Bilinmeyen bir hata oluştu. Lütfen tekrar deneyin.");
                // Optionally log the exception (ex.Message)
            }
        }


        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    // SQL query for inserting a new product into the database
                    string query = "INSERT INTO urunler(kategori_id, urun_adi, urun_fiyat, urun_img, urun_aciklama) " +
                                   "VALUES (@kategori_id, @urun_adi, @urun_fiyat, @urun_img, @urun_aciklama)";

                    // Create the command object and add parameters to it
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kategori_id", int.Parse(txtKategori_idEkle.Text));
                    command.Parameters.AddWithValue("@urun_Adi", txtUrunAdiEkle.Text);
                    command.Parameters.AddWithValue("@urun_fiyat", double.Parse(txtUrunFiyatiEkle.Text));
                    command.Parameters.AddWithValue("@urun_img", txtUrunResmiEkleme.Text);
                    command.Parameters.AddWithValue("@urun_aciklama", txtUrunAciklamaEkle.Text);

                    // Open the connection, execute the query, and close the connection
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    // Reload the data in the menu
                    getMenuData();
                    MessageBox.Show("Ürün Eklendi.");
                }
            }
            catch (FormatException fe)
            {
                // Handle format exceptions (e.g., invalid data types entered by the user)
                MessageBox.Show("Veri formatında bir hata oluştu. Lütfen tüm alanları doğru formatta girin.");
                // Optionally log the exception (fe.Message)
            }
            catch (SqlException se)
            {
                // Handle SQL exceptions (e.g., database issues or SQL query errors)
                MessageBox.Show("Veritabanı hatası oluştu. Lütfen tekrar deneyin.");
                // Optionally log the exception (se.Message)
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show("Bilinmeyen bir hata oluştu. Lütfen tekrar deneyin.");
                // Optionally log the exception (ex.Message)
            }
        }



        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (menuGridView.SelectedRows.Count > 0)
            {
                int urun_id = Convert.ToInt32(menuGridView.SelectedCells[0].Value);
                using (SqlConnection connection = new SqlConnection(conString))
                {

                    string query = "DELETE FROM urunler WHERE urun_id=@urun_id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@urun_id", urun_id);


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    getMenuData();
                    MessageBox.Show("Urun Silindi");

                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Satır Seçiniz");
            }
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriEkle.Text))
            {
                MessageBox.Show("Lütfen Geçerli Kategori Adı Giriniz");
                return;
            }
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "INSERT INTO kategoriler VALUES(@kategori_adi)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kategori_adi", txtKategoriEkle.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                getKategoriData();

                MessageBox.Show("Kategori EKlendi");




            }
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (kategoriGridView.SelectedRows.Count > 0)
            {
                int kategori_id = Convert.ToInt32(kategoriGridView.SelectedCells[0].Value);
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string query = "DELETE FROM kategoriler WHERE kategori_id=@kategori_id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kategori_id", kategori_id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    getKategoriData();
                    MessageBox.Show("Kategori Silindi");

                }

            }
            else 
            {
                MessageBox.Show("Silmek İstediğiniz Kategori Satırını Seçiniz");
            }
        }
        private void UpdateChart(DataTable dataTable)
        {
            // Chart'ı temizle
            chart1.Series.Clear();

            // Yeni bir seri ekle
            Series series = new Series("Satışlar");
            series.ChartType = SeriesChartType.Bar;  // Çubuç grafik
            series.XValueMember = "urun_adi";        // X eksenine ürün adını al
            series.YValueMembers = "ToplamAdet";    // Y eksenine toplam adet al
            chart1.Series.Add(series);

            // Verileri chart'a bağla
            chart1.DataSource = dataTable;
            chart1.DataBind();  // Verileri bağla ve chart'ı güncelle
        }

        private void GetSatisRapor(DateTime startDate, DateTime endDate)
        {
            string query = @"
        SELECT urunler.urun_adi, SUM(satis_detaylari.adet) AS ToplamAdet, 
               SUM(satis_detaylari.adet) AS ToplamGelir
        FROM satislar
        JOIN satis_detaylari ON satislar.satis_id = satis_detaylari.satis_id
        JOIN urunler ON satis_detaylari.urun_id = urunler.urun_id
        WHERE satislar.satis_tarihi BETWEEN @startDate AND @endDate
        GROUP BY urunler.urun_adi
        ORDER BY ToplamAdet DESC";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                // Parametreleri ekliyoruz
                adapter.SelectCommand.Parameters.AddWithValue("@startDate", startDate);
                adapter.SelectCommand.Parameters.AddWithValue("@endDate", endDate);

                // Verileri DataTable'a çekiyoruz
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // DataGridView'e veri bağla
                dataGridView1.DataSource = dataTable;

                // Chart'ı güncelle
                UpdateChart(dataTable);
            }
        }


        private void btnGetReport_Click(object sender, EventArgs e)
        {
            string raporTuru = cmbRaporTuru.SelectedItem.ToString();

            // DateTimePicker'tan başlangıç tarihini alıyoruz
            DateTime baslangicTarihi = dtpBaslangicTarihi.Value;

            // Bitiş tarihi hesaplama
            DateTime bitisTarihi;

            if (raporTuru == "Günlük")
            {
                bitisTarihi = baslangicTarihi; // Günlük rapor için o gün
            }
            else if (raporTuru == "Haftalık")
            {
                // Haftalık rapor için 7 gün sonrası
                bitisTarihi = baslangicTarihi.AddDays(6);
            }
            else if (raporTuru == "Aylık")
            {
                // Aylık rapor için 1 ay sonrası
                bitisTarihi = baslangicTarihi.AddMonths(1).AddDays(-1); // Aynı ayın son günü
            }
            else
            {
                bitisTarihi = baslangicTarihi; // Varsayılan olarak günlük rapor
            }

            // Raporu al ve DataGridView & Chart ile göster
            GetSatisRapor(baslangicTarihi, bitisTarihi);
        }
       

       
    }
}
