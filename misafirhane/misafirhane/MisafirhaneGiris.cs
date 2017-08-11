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

namespace misafirhane
{
    public partial class MisafirhaneGiris : Form
    {
        public MisafirhaneGiris()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //baglanti kurulumu
                SqlConnection baglanti = new SqlConnection();
                string baglantiadres = "Server=EBIM-STAJYER;Initial Catalog=misafirhane;Integrated Security=True;";
                // SqlConnection baglanti = new SqlConnection(baglantiadres);
                baglanti.ConnectionString = baglantiadres;
                baglanti.Open();
                if(baglanti != null)
                {
                    MessageBox.Show("Basarili baglanti");

                    SqlCommand cmd = new SqlCommand("SELECT username,password from giris", baglanti);

                    SqlDataReader dr = cmd.ExecuteReader();
                    //verileri database dan oku

                    string username = null;
                    string password = null;
                    while (dr.Read())
                    {
                        username = dr["username"].ToString();
                        password = dr["password"].ToString();

                       
                    }
                    if (username == textBox1.Text && password == textBox2.Text)
                    {
                        MessageBox.Show("Hosgeldiniz: " + username);
                        Odalar Odalar = new Odalar();
                        Odalar.Show();
                        baglanti.Close();
                    }


                    //eğer database bağlandıysa odaları gösteren forma git
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
