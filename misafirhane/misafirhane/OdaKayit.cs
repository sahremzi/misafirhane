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
    public partial class OdaKayit : Form
    {
        public OdaKayit()
        {
            InitializeComponent();
        }

        public void baglanti()
        {
           
  
            try
            {
                //baglanti kurulumu
                SqlConnection baglanti = new SqlConnection();
                string baglantiadres = "Server=EBIM-STAJYER;Initial Catalog=misafirhane;Integrated Security=True;";
                // SqlConnection baglanti = new SqlConnection(baglantiadres);
                baglanti.ConnectionString = baglantiadres;
                baglanti.Open();

                //eğer database bağlandıysa odaları gösteren forma git

                Form Odalar = new Form();
                this.Close();
                Odalar.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

         
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                //baglanti kurulumu
                SqlConnection baglanti = new SqlConnection();
                string baglantiadres = "Server=EBIM-STAJYER;Initial Catalog=misafirhane;Integrated Security=True;";
                // SqlConnection baglanti = new SqlConnection(baglantiadres);
                baglanti.ConnectionString = baglantiadres;
                baglanti.Open();

               // odada kalacak kişinin bilgileri database e kaydedeliyor
                    SqlCommand cmd = new SqlCommand("insert into KisiKayit(Adi,Soyadi,Telefon,TC,Adres) values (@adi,@soyadi,@telefon,@tc,@adres)", baglanti);
                    cmd.Parameters.AddWithValue("@adi", textBox12.Text);
                    cmd.Parameters.AddWithValue("@soyadi", textBox11.Text);
                    cmd.Parameters.AddWithValue("@telefon", textBox10.Text);
                    cmd.Parameters.AddWithValue("@tc", textBox9.Text);
                    cmd.Parameters.AddWithValue("@adres", textBox8.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        




        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void OdaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
