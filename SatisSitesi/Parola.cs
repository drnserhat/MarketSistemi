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
    public partial class Parola : Form
    {
        public Parola()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        DataTable tablo = new DataTable();
        SqlDataReader dr;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=kayit;Integrated Security=True");
            ds = new DataSet();
            da = new SqlDataAdapter("UPDATE giris SET parola='" + txtPass1.Text + "'", con);
            con.Open();
            da.Fill(ds, "giris");
            com.Connection = con;
            com.CommandText = "SELECT * FROM giris WHERE kul_adi='" + txtKul.Text + "' AND parola='" + txtPass1.Text + "' AND parola='"+txtPass2.Text+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Yeni Şifre Kaydedildi");
                
            }
            else
            {
                lblKontrol.Text = "Kullanıcı adı veya Şifreler Uyuşmuyor.";
            }
        }
    }
}
