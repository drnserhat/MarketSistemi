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
    public partial class Firma : Form
    {
        public Firma()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=market;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataReader dr;
        void FirmaListele()
        {
            
            da = new SqlDataAdapter("SELECT * FROM firmalar", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds,"firmalar");
            dataFirmalarView.DataSource = ds.Tables["firmalar"];
            con.Close();
        }
        void CBfirmaID()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM firmalar";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbFirmaID.Items.Add(dr["firma_id"]);

            }
            con.Close();
        }

        void CBfirmaAD()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM firmalar";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbFirmaAD.Items.Add(dr["firma_adi"]);

            }
            con.Close();
        }
        private void Firma_Load(object sender, EventArgs e)
        {
            CBfirmaAD();
            CBfirmaID();
            FirmaListele();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "INSERT INTO firmalar(firma_id,firma_adi,adres,tel,e_posta) VALUES ('"+txtID.Text+ "','" + txtAD.Text + "','" + txtAdres.Text + "','" + txtTel.Text + "','" + txtPosta.Text + "')";
            com.ExecuteNonQuery();
            if (txtID.Text=="" && txtAD.Text=="" && txtAdres.Text=="" && txtTel.Text=="" && txtPosta.Text=="")
            {
                MessageBox.Show("Boş alanları doldurunuz");
            }
            else
            {
                MessageBox.Show(txtAD.Text + " isimli Firma Kaydedildi.");
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "UPDATE firmalar SET firma_adi='"+txtAD.Text+"',adres='"+txtAdres.Text+"',tel='"+txtTel.Text+"',e_posta='"+txtPosta.Text+"' where firma_id='"+cbFirmaID.Text+"'";
            com.ExecuteNonQuery();
            if (cbFirmaID.Text == "" && txtAD.Text == "" && txtAdres.Text == "" && txtTel.Text == "" && txtPosta.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz");
            }
            else
            {
                MessageBox.Show(cbFirmaID.Text + " ID'li Firma Güncellendi.");
            }
            con.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "DELETE FROM firmalar where firma_adi='" + cbFirmaAD.Text + "'";
            com.ExecuteNonQuery();
            if (cbFirmaAD.Text=="")
            {
                MessageBox.Show("Boş alanları doldurunuz.");

            }
            else
            {
                MessageBox.Show(cbFirmaAD.Text +" adli firma silindi.");
            }
        }
    }
}
