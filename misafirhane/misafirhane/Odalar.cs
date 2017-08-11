using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace misafirhane
{
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void Odalar_Load(object sender, EventArgs e)
        {
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
                SqlCommand cmd = new SqlCommand("SELECT odaNum,maxkisi,ddrum FROM odalar", baglanti);

                SqlDataReader dr = cmd.ExecuteReader();
                //verileri database dan oku

                string odanu; // odalar tablosundan oda numaraları
               
                while (dr.Read())
                {
                    odanu = dr["odaNum"].ToString().ToUpper();

                    if (odanu.StartsWith("S"))  // Oda numarası s ile başlayan süit odadır
                    {
                        // oda max kişi
                        // yeni oluşacak butona text değerlerini gönderme
                        //buton üretirken referans olarak ve visible gizli olacak buton x ve y location değerleri çekilip gönderiliyor
                    //    buton_uret(" " + dr["maxkisi"].ToString() + "| " + dr["ddrum"].ToString(), dr["odaNum"].ToString(),button1.Location.X, button1.Location.Y);

                  //      label_uret(dr["odaNum"].ToString(),label2.Location.X,label2.Location.Y);
                     //  i= i>3 ? 0 : i++;
                        
                //        j=j>3 ? 0 :j++;

                        for (int x=1;x<3;x++) {
                            for (int y = 1; y < 3; y++)
                            {

                                uret(x,y);
                            }
                        }
                       
                        sayac++;
                    }
                  /*  
                  else if (odanu.StartsWith("1"))  // Oda numarası 1 ile başlayan üst kat odalardır
                    { 

                        // oda max kişi
                        // yeni oluşacak butona text değerlerini gönderme
                        //buton üretirken referans olarak ve visible gizli olacak buton x ve y location değerleri çekilip gönderiliyor
                        buton_uret(" " + dr["maxkisi"].ToString() + "| " + dr["ddrum"].ToString(), odanu, button5.Location.X, button5.Location.Y);

                        label_uret(dr["odaNum"].ToString(), label6.Location.X, label6.Location.Y);

                        i = i > 5 ? 0 : i++;

                        j = j > 5 ? 0 : j++;
                    }

                  else  if (odanu.StartsWith("2"))  // Oda numarası 1 ile başlayan üst kat odalardır
                    {

                        // oda max kişi
                        // yeni oluşacak butona text değerlerini gönderme
                        //buton üretirken referans olarak ve visible gizli olacak buton x ve y location değerleri çekilip gönderiliyor
                        buton_uret(" " + dr["maxkisi"].ToString() + "| " + dr["ddrum"].ToString(), dr["odaNum"].ToString(), button23.Location.X, button23.Location.Y);

                        label_uret(dr["odaNum"].ToString(), label16.Location.X, label16.Location.Y);

                        i = i > 5 ? 0 : i++;

                        j = j > 5 ? 0 : j++;
                    }

                    else if (odanu.StartsWith("E"))  // Oda numarası 1 ile başlayan üst kat odalardır
                    {

                        // oda max kişi
                        // yeni oluşacak butona text değerlerini gönderme
                        //buton üretirken referans olarak ve visible gizli olacak buton x ve y location değerleri çekilip gönderiliyor
                        buton_uret(" " + dr["maxkisi"].ToString() + "| " + dr["ddrum"].ToString(), dr["odaNum"].ToString(), button27.Location.X, button27.Location.Y);

                        label_uret(dr["odaNum"].ToString(), label28.Location.X, label28.Location.Y);

                        i = i > 0 ? 0 : i++;

                        j = j > 0 ? 0 : j++;
                    }
                    */
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    
            //buton üretme
            int i=1,j = 0;// buton ve label konumları için sayac
        public void buton_uret(string buton_text, string buton_adi,int x,int y)
        {
            Button dugme = new Button();
            //buton konumu
           

            dugme.Location = new System.Drawing.Point(x+ (i / 2 == 0 ? i=0 : i) * 101, (j / 2 == 0 ? j : j=0) * 29 + y);
            dugme.Top = 3;
            dugme.Left = 3;
            dugme.Width = 75;
            dugme.Height = 23;
            dugme.Name = buton_adi;
            dugme.Text = buton_text;

            this.Controls.Add(dugme);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //odaların güncel durumunu excel dosyası halindeki verileri e-mail ile gönderme
            //verileri excel dosyasını haline gitirip yolu belirliyoruz
            string DosyaYolu="";


            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            string kime = "alici@mail.com";
            string konu = "odalar güncel durum";
            string icerik = "excel dokuman";

            //göndericinin adresi ve şifresi
            sc.Credentials = new NetworkCredential("mailadresiniz@gmail.com", "şifre");
            MailMessage mail = new MailMessage();
            //gönderici mail adresi
            mail.From = new MailAddress("posta@gmail.com", "tüvasaş misafirhane");
            mail.To.Add(kime);
            //mail.To.Add("alici@mail.com");
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            mail.Attachments.Add(new Attachment(@DosyaYolu));
            sc.Send(mail);

        }

        public void label_uret(string text,int x, int y)
        {
            Label lb = new Label();
            //buton konumu
            lb.Location = new System.Drawing.Point(x - (i / 2 == 0 ? i = 0 : i) * 136, (j / 2 == 0 ? j : j = 0) * 28- y);
            lb.Top = 3;
            lb.Left = 3;
            lb.Width = 75; 
            lb.Height = 23;
            lb.Text = text;

            this.Controls.Add(lb);
            i++;
            j++;
        }

Button btn = new Button();
        public void uret(int x,int y)
        {

                

                btn.Location = new System.Drawing.Point(button1.Location.X,y*10+ button1.Location.Y);
                btn.Name = "btn_" + x.ToString();
                btn.Size = new System.Drawing.Size(30, 20);
                btn.Text = x.ToString();
                groupBox2.Controls.Add(btn);
            

        }
    }
}
