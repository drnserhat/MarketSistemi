using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisSitesi
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=market;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();

        public void listeleUrun()
        {
            da = new SqlDataAdapter("SELECT * FROM urunler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "urunler");
            dataGridUrun.DataSource = ds.Tables["urunler"];
            con.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewPass_Click(object sender, EventArgs e)
        {
            Parola parola = new Parola();
            parola.Show();
            listeleUrun();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            UrunEkle urunekle = new UrunEkle();
            urunekle.Show();
            listeleUrun();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

            listeleUrun();
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            
            listeleUrun();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.Show();
            listeleUrun();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM urunler where urun_adi like '" + txtAra.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "urunler");
            dataGridUrun.DataSource = ds.Tables["urunler"];
            
            con.Close();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            Firma firma = new Firma();
            firma.Show();
            listeleUrun();
        }
    }
}
