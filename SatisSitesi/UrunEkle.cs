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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=market;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataReader dr;
        
        void cbUrunSirala()
        {
  
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM urunler";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbUrunAd.Items.Add(dr["urun_adi"]);
            }
            
            con.Close();
        }
        void cbFirmaSirala()
        {

            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM firmalar";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbFirmaAd.Items.Add(dr["firma_id"]);
                cbFirma1.Items.Add(dr["firma_id"]);
            }
            
            con.Close();
        }
        void cbKategoriSirala()
        {

            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM kategoriler";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbKategori.Items.Add(dr["kategori_id"]);
                cbKategori1.Items.Add(dr["kategori_id"]);
                
            }
            
            con.Close();
        }
        void cbADSirala()
        {
      
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM urunler";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbUrunAdGuncelle.Items.Add(dr["urun_adi"]);
            }

            con.Close();
        }
        private void UrunEkle_Load(object sender, EventArgs e)
        {
            cbUrunSirala();
            cbFirmaSirala();
            cbKategoriSirala();
            cbADSirala();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
   
            con.Open();
            com.Connection = con;
            com.CommandText = "INSERT INTO urunler VALUES ('" + txtID.Text + "','" + txtAd.Text + "','" + cbKategori.Text + "','" + cbFirmaAd.Text + "','" + txtAlis.Text + "','" + txtSatis.Text + "','" + txtAdet.Text + "','" + txtBarkod.Text + "')";
            com.ExecuteNonQuery();
            if (txtID.Text=="" && txtAd.Text=="" && txtAlis.Text=="" && txtSatis.Text=="" && txtAdet.Text=="" && txtBarkod.Text=="")
            {
                MessageBox.Show("Boş Yerleri Doldurunuz");
            }
            else
            {
                MessageBox.Show("Urun Eklendi");
            }
            con.Close();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
      
            con.Open();
            com.Connection = con;
            com.CommandText = "UPDATE urunler SET urun_adi='" + txtAd1.Text + "',firma_id='" + cbFirma1.Text + "',kategori_id='" + cbKategori1.Text + "',alis_fiyat='" + txtAlis1.Text + "',satis_fiyat='" + txtSatis1.Text + "',stok_adedi='" + txtAdet1.Text + "',barkod_no='" + txtBarkod1.Text + "' where urun_adi='"+cbUrunAdGuncelle.Text+"'";
            com.ExecuteNonQuery();
            if (cbUrunAdGuncelle.Text=="" && txtAd1.Text == "" && txtAlis1.Text == "" && txtSatis1.Text == "" && txtAdet1.Text == "" && txtBarkod1.Text == "")
            {
                MessageBox.Show("Boş Yerleri Doldurunuz");
            }
            else
            {
                MessageBox.Show(cbUrunAdGuncelle.Text +" isimli Urun Güncellendi.\nYeni isimi: " + txtAd1.Text);
            }
            con.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
   
            con.Open();
            com.Connection = con;
            com.CommandText = "DELETE FROM urunler where urun_adi='" +cbUrunAd.Text +"'";
            com.ExecuteNonQuery();
            MessageBox.Show("Urun Silindi.");
            con.Close();
        }

        private void cbFirmaAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM firmalar where firma_id='" + cbFirmaAd.Text + "'";
            dr = com.ExecuteReader();
          
            if (dr.Read())
            {
                lblFirma.Text = "Firma: " + dr["firma_adi"].ToString();

            }
            con.Close();
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM kategoriler where kategori_id='" + cbKategori.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                lblKategori.Text = "Kategori: " + dr["kategori_adi"].ToString();

            }
            con.Close();
        }

        private void cbFirma1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM firmalar where firma_id='" + cbFirma1.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                lblFirmaAd1.Text = "Firma: " + dr["firma_adi"].ToString();

            }
            con.Close();
        }

        private void cbKategori1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM kategoriler where kategori_id='" + cbKategori1.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                lblKatAdi1.Text = "Kategori: " + dr["kategori_adi"].ToString();

            }
            con.Close();
        }
    }
}
