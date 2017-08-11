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
    public partial class odalar2 : Form
    {
        public odalar2()
        {
            InitializeComponent();
        }

        private void odalar2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'misafirhaneDataSet1.odalar' table. You can move, or remove it, as needed.
            this.odalarTableAdapter1.Fill(this.misafirhaneDataSet1.odalar);
            // TODO: This line of code loads data into the 'misafirhaneDataSet.odalar' table. You can move, or remove it, as needed.
            this.odalarTableAdapter.Fill(this.misafirhaneDataSet.odalar);
            //         (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
            //string.Format("Name LIKE '{0}%' OR Name LIKE '% {0}%'", "s");


          

            BindingSource bs = new BindingSource();
            //boş olan odalar
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = " maxkisi-ddrum <>'0' ";
            dataGridView1.DataSource = bs;

            BindingSource bs1 = new BindingSource();
            //boş olmayan odalar
            bs1.DataSource = dataGridView2.DataSource;
            bs1.Filter = " maxkisi-ddrum ='0' ";
            dataGridView2.DataSource = bs1;
            /*  try
              {
                  //baglanti kurulumu
                  SqlConnection baglanti = new SqlConnection();
                  string baglantiadres = "Server=EBIM-STAJYER;Initial Catalog=misafirhane;Integrated Security=True;";
                  // SqlConnection baglanti = new SqlConnection(baglantiadres);
                  baglanti.ConnectionString = baglantiadres;
                  baglanti.Open();

                  //odaların durumu
                  // odalar tablosundan ilgili id ile gösterilen odanın maximum kişi sayısı ve dolu durumu= ddurum 
                  SqlCommand cmd = new SqlCommand("SELECT odaNum,maxkisi,ddrum,odatipi FROM odalar", baglanti);

                  SqlDataReader dr = cmd.ExecuteReader();
                  //verileri database dan oku

                  string odanu; // odalar tablosundan oda numaraları

                  while (dr.Read())
                  {
                      // odanu = dr["odaNum"].ToString().ToUpper();

                      // Oda numarası s ile başlayan süit odadır


                  }

                  baglanti.Close();
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());
              }*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var dataIndexNo = dataGridView1.Rows[e.RowIndex].Index.ToString();
            int  cellValue =Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());

            label3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                //baglanti kurulumu
                SqlConnection baglanti = new SqlConnection();
                string baglantiadres = "Server=EBIM-STAJYER;Initial Catalog=misafirhane;Integrated Security=True;";
                // SqlConnection baglanti = new SqlConnection(baglantiadres);
                baglanti.ConnectionString = baglantiadres;
                baglanti.Open();

                //odaların durumu
                // odalar tablosundan ilgili id ile gösterilen odanın maximum kişi sayısı ve dolu durumu= ddurum 
                SqlCommand cmd = new SqlCommand("SELECT kisikayit.ID,kisikayit.ad,kisikayit.soyad,kisikayit.TC,kisikayit.adres,kisikayit.telefon FROM odalar INNER JOIN kisikayit ON odalar.ID=kisikayit.odaID ", baglanti);

                SqlDataReader dr = cmd.ExecuteReader();
                //verileri database dan oku

                string odanu; // odalar tablosundan oda numaraları

                while (dr.Read())
                {
                    // odanu = dr["odaNum"].ToString().ToUpper();

                    // Oda numarası s ile başlayan süit odadır


                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //MessageBox.Show("The row index = " + dataIndexNo.ToString() + " and the row data in second column is: "
            //    + cellValue.ToString());
        }
    }
}
