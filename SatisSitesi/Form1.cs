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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        DataTable tablo = new DataTable();
        SqlDataReader dr;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=S0AP-SERHAT;Initial Catalog=kayit;Integrated Security=True");
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM giris WHERE kul_adi='" + txtKul.Text + "' AND parola='" + txtPass.Text + "'";
            dr = com.ExecuteReader();
            
            if (dr.Read())
            {
                MessageBox.Show("Giriş Yaptınız:");
                AnaMenu main = new AnaMenu();

                this.Hide();
                main.Show();

            }
            else
            {
                txtKul.BackColor = Color.Red;
                txtPass.BackColor = Color.Red;
                lbl12.Text = "Kullanıcı adı veya Şifre Yanlış";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lbl12.BackColor = Color.Transparent;
        }

        private void txtKul_MouseHover(object sender, EventArgs e)
        {
            txtKul.Clear();
            
        }

        private void txtPass_MouseHover(object sender, EventArgs e)
        {
            txtPass.Clear();
        }
    }
}
