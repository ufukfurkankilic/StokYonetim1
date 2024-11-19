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
using Microsoft.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FURKANKILICPC\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True; TrustServerCertificate=true;");
        DataSet daset = new DataSet();
        private void SepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            baglanti.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.ShowDialog();
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ürünEkle = new frmÜrünEkle();
            ürünEkle.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.ShowDialog();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            // TC kimlik numarası boşsa, metin kutularını temizle
            if (txtTc.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
                return; // Boşsa, fonksiyonu sonlandır
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM müşteri WHERE tc LIKE @tc", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text); // Parametre ekle
                SqlDataReader read = komut.ExecuteReader();

                // Sonuçları oku
                if (read.Read()) // Eğer sonuç varsa
                {
                    txtAdSoyad.Text = read["adsoyad"].ToString();
                    txtTelefon.Text = read["telefon"].ToString();
                }
                else
                {
                    // Eğer sonuç yoksa metin kutularını temizle
                    txtAdSoyad.Text = "";
                    txtTelefon.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        public void Temizle()
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox && item != txtMiktar) // txtMiktar dışındaki tüm TextBox'lar
                {
                    item.Text = ""; // Metin kutusunu temizle
                }
            }

            // İsteğe bağlı olarak diğer kontrolleri de temizleyebilirsiniz
            txtBarkodNo.Text = ""; // Eğer barkod numarasını da temizlemek isterseniz
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            // Barkod numarası boşsa, metin kutularını temizle
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox && item != txtMiktar)
                    {
                        item.Text = "";
                    }
                }
                return; // Boşsa, fonksiyonu sonlandır
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno LIKE @barkod", baglanti);
                komut.Parameters.AddWithValue("@barkod", txtBarkodNo.Text); // Parametre ekle
                SqlDataReader read = komut.ExecuteReader();

                // Sonuçları oku
                if (read.Read()) // Eğer sonuç varsa
                {
                    txtÜrünAdı.Text = read["urunadi"].ToString();
                    txtSatışFiyatı.Text = read["satisfiyati"].ToString();
                }
                else
                {
                    // Eğer sonuç yoksa metin kutularını temizle
                    txtÜrünAdı.Text = "";
                    txtSatışFiyatı.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        bool durum;
        public void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyati, tarih) values(@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyati, @tarih) ", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                try
                {
                    baglanti.Open();

                    // Miktarı güncelle
                    SqlCommand komut1 = new SqlCommand("UPDATE sepet SET miktari = miktari + @miktar WHERE barkodno = @barkod", baglanti);
                    komut1.Parameters.AddWithValue("@miktar", int.Parse(txtMiktar.Text));
                    komut1.Parameters.AddWithValue("@barkod", txtBarkodNo.Text);
                    komut1.ExecuteNonQuery();

                    // Toplam fiyatı güncelle
                    SqlCommand komut2 = new SqlCommand("UPDATE sepet SET toplamfiyati = miktari * satisfiyati WHERE barkodno = @barkod", baglanti);
                    komut2.Parameters.AddWithValue("@barkod", txtBarkodNo.Text);
                    komut2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }


            }

            txtMiktar.Text = "1";
            daset.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
            Temizle();
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatışFiyatı.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatışFiyatı.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün sepetten çıkarıldı");
            daset.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler sepetten çıkarıldı");
            daset.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSatısListele listele = new frmSatısListele();
            listele.ShowDialog();
        }
        private void hesapla()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet", baglanti);
            lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
            baglanti.Close();

        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyati, tarih) values(@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyati, @tarih) ", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari+'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();

            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet ", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
        }
    }
}
