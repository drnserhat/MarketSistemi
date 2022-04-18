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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=market;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataReader dr;

       void listeleKategori()
        {
            da = new SqlDataAdapter("SELECT * FROM kategoriler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kategoriler");
            dataKategoriView.DataSource = ds.Tables["kategoriler"];
            con.Close();
        }
        void CbKatID()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM kategoriler";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbKatID.Items.Add(dr["kategori_id"]);
            }
            con.Close();
        }
        void DelKatAd()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM kategoriler";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbDelAd.Items.Add(dr["kategori_adi"]);
            }
            con.Close();
        }
        private void btnADDkat_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "INSERT INTO kategoriler VALUES ('" + txtKatID.Text + "','" + txtKatAd.Text + "','" + txtKDV.Text + "')";
            com.ExecuteNonQuery();
            if (txtKatID.Text=="" && txtKatAd.Text=="" && txtKDV.Text=="")
            {
                MessageBox.Show("Boş Alanları Doldurunuz.");
            }
            else
            {
                MessageBox.Show(txtKatAd.Text + " İsimli Yeni Kategori Eklendi.");
            }
            
            con.Close();
            
            listeleKategori();

        }

        private void btnUPPkat_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "UPDATE kategoriler SET kategori_adi='"+txtKatAd1.Text+"',kdv_orani='"+txtKDV1.Text+"' WHERE kategori_id='"+cbKatID.Text+"'";
            com.ExecuteNonQuery();
            if (cbKatID.Text == "" && txtKatAd1.Text == "" && txtKDV1.Text == "")
            {
                
                MessageBox.Show("Boş Alanları Doldurunuz.");
            }
            else
            {
                MessageBox.Show(cbKatID.Text + " ID'li kategori güncellendi.");
            }
            
            con.Close();
            
            listeleKategori();
        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            CbKatID();
            DelKatAd();
            listeleKategori();
        }
        
        private void btnDelKat_Click(object sender, EventArgs e)
        {

            con.Open();
            com.Connection = con;
            com.CommandText = "DELETE FROM kategoriler WHERE kategori_adi='" + cbDelAd.Text + "'";
            com.ExecuteNonQuery();
            if (cbDelAd.Text=="")
            {
                MessageBox.Show("BoşLuğu Doldurunuz.");

            }
            else
            {
                MessageBox.Show(cbDelAd.Text+" isimli kategori silindi.");
            }

            con.Close();
           
            listeleKategori();
        }
    }
}
