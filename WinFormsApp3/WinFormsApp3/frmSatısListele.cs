using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class frmSatısListele : Form
    {
        public frmSatısListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FURKANKILICPC\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True; TrustServerCertificate=true;");
        DataSet daset = new DataSet();
        private void SatısListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }
        private void frmSatısListele_Load(object sender, EventArgs e)
        {
            SatısListele();
        }
    }
}
