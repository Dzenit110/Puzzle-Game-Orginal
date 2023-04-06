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
using System.IO;

namespace Login_And_Register_Form
{
    public partial class dashboard : Form
    {

        int clickCount = 0;
        int puan;
        int sn, dk;
        public dashboard()
        {
            InitializeComponent();
        }
        public bool ResimEsitMi(Image resim1, Image resim2)
        {

            if (resim1 == null || resim2 == null)
            {
                return false;
            }

            Bitmap bitmap1 = new Bitmap(resim1);
            Bitmap bitmap2 = new Bitmap(resim2);

            if (bitmap1.Size != bitmap2.Size)
            {
                return false;
            }

            for (int i = 0; i < bitmap1.Width; i++)
            {
                for (int j = 0; j < bitmap1.Height; j++)
                {
                    if (bitmap1.GetPixel(i, j) != bitmap2.GetPixel(i, j))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public string kullanici;
        private void dashboard_Load(object sender, EventArgs e)
        {
            guna2Button1.Enabled = false; guna2Button2.Enabled = false; guna2Button3.Enabled = false;
            label10.Text = kullanici;

            
            string sqlSorgusu = "SELECT * FROM tbl_users WHERE username='" + kullanici + "'";

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-F59JTTH\\SQLEXPRESS;Initial Catalog=puzzleoyunu;Integrated Security=True");
            con.Open();
            SqlCommand komut = new SqlCommand(sqlSorgusu,con);


            label10.Text = kullanici;
            SqlDataReader dr = komut.ExecuteReader();
           
            while (dr.Read())
            {
                label10.Text = dr[0].ToString();
              

            }
            con.Close();


            pictureBox100.Visible = false;
            pictureBox101.Visible = false;
            pictureBox102.Visible = false;
            pictureBox103.Visible = false;
            pictureBox104.Visible = false;
            pictureBox105.Visible = false;
            pictureBox106.Visible = false;
            pictureBox107.Visible = false;
            pictureBox108.Visible = false;
            pictureBox109.Visible = false;
            pictureBox110.Visible = false;
            pictureBox111.Visible = false;
            pictureBox115.Visible = false;
            pictureBox114.Visible = false;
            pictureBox113.Visible = false;
            pictureBox112.Visible = false;

            pictureBox200.Visible = false;
            pictureBox201.Visible = false;
            pictureBox202.Visible = false;
            pictureBox203.Visible = false;
            pictureBox204.Visible = false;
            pictureBox205.Visible = false;
            pictureBox206.Visible = false;
            pictureBox207.Visible = false;
            pictureBox208.Visible = false;
            pictureBox209.Visible = false;
            pictureBox210.Visible = false;
            pictureBox211.Visible = false;
            pictureBox215.Visible = false;
            pictureBox214.Visible = false;
            pictureBox213.Visible = false;
            pictureBox212.Visible = false;


            pictureBox100.Enabled = false;
            pictureBox101.Enabled = false;
            pictureBox102.Enabled = false;
            pictureBox103.Enabled = false;
            pictureBox104.Enabled = false;
            pictureBox105.Enabled = false;
            pictureBox106.Enabled = false;
            pictureBox107.Enabled = false;
            pictureBox108.Enabled = false;
            pictureBox109.Enabled = false;
            pictureBox110.Enabled = false;
            pictureBox111.Enabled = false;
            pictureBox115.Enabled = false;
            pictureBox114.Enabled = false;
            pictureBox113.Enabled = false;
            pictureBox112.Enabled = false;


            timer1.Enabled = false;
            timer1.Interval = 1000;
            sn = 0;
            dk = 0;



            string query2 = "SELECT TOP 5 username,puan FROM tbl_users ORDER BY puan DESC";
            SqlCommand cmd2 = new SqlCommand(query2, con);

            // Verileri okuyun
            con.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();

            // DataTable oluşturun ve verileri saklayın
            DataTable dt = new DataTable();
            dt.Load(reader2);

            // DataView kullanarak sıralayın
            DataView dv = dt.DefaultView;
            dv.Sort = "puan DESC";

            // DataGridView kontrolünü kullanarak verileri formda gösterin
            dataGridView1.DataSource = dv;
            dataGridView1.Refresh();

            // Veritabanı bağlantısını kapatın
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString(puan);
            label13.Text = (clickCount/2).ToString();

            bool x1 = ResimEsitMi(pictureBox100.Image, pictureBox200.Image);

            if (x1)
            {

                pictureBox100.Enabled = false;



            }


            bool x2 = ResimEsitMi(pictureBox101.Image, pictureBox204.Image);

            if (x2)
            {
                pictureBox101.Enabled = false;
            }
            bool x3 = ResimEsitMi(pictureBox102.Image, pictureBox208.Image);

            if (x3)
            {
                pictureBox102.Enabled = false;
            }

            bool x4 = ResimEsitMi(pictureBox103.Image, pictureBox212.Image);

            if (x4)
            {
                pictureBox103.Enabled = false;
            }

            bool x5 = ResimEsitMi(pictureBox104.Image, pictureBox201.Image);

            if (x5)
            {
                pictureBox104.Enabled = false;
            }

            bool x6 = ResimEsitMi(pictureBox105.Image, pictureBox205.Image);

            if (x6)
            {
                pictureBox105.Enabled = false;
            }

            bool x7 = ResimEsitMi(pictureBox106.Image, pictureBox209.Image);

            if (x7)
            {
                pictureBox106.Enabled = false;
            }

            bool x8 = ResimEsitMi(pictureBox107.Image, pictureBox213.Image);

            if (x8)
            {
                pictureBox107.Enabled = false;
            }

            bool x9 = ResimEsitMi(pictureBox108.Image, pictureBox202.Image);

            if (x9)
            {
                pictureBox108.Enabled = false;
            }

            bool x10 = ResimEsitMi(pictureBox109.Image, pictureBox206.Image);

            if (x10)
            {
                pictureBox109.Enabled = false;
            }

            bool x11 = ResimEsitMi(pictureBox110.Image, pictureBox210.Image);

            if (x11)
            {
                pictureBox110.Enabled = false;
            }

            bool x12 = ResimEsitMi(pictureBox111.Image, pictureBox214.Image);

            if (x12)
            {
                pictureBox111.Enabled = false;
            }

            bool x13 = ResimEsitMi(pictureBox112.Image, pictureBox203.Image);

            if (x13)
            {
                pictureBox112.Enabled = false;
            }

            bool x14 = ResimEsitMi(pictureBox113.Image, pictureBox207.Image);

            if (x14)
            {
                pictureBox113.Enabled = false;
            }

            bool x15 = ResimEsitMi(pictureBox114.Image, pictureBox211.Image);

            if (x15)
            {
                pictureBox114.Enabled = false;
            }

            bool x16 = ResimEsitMi(pictureBox115.Image, pictureBox215.Image);

            if (x16)
            {
                pictureBox115.Enabled = false;
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-F59JTTH\\SQLEXPRESS;Initial Catalog=puzzleoyunu;Integrated Security=True");
            con.Open();

         
            SqlCommand komutguncelle = new SqlCommand("update tbl_users set puan=@a1, hamle=@a2 where username=@a3", con);
            komutguncelle.Parameters.AddWithValue("@a1", ( label8.Text));
            komutguncelle.Parameters.AddWithValue("@a2", ( label13.Text));
            komutguncelle.Parameters.AddWithValue("@a3", (label10.Text));

            komutguncelle.ExecuteNonQuery();
            con.Close();
            if (x1 && x2 && x3 && x4 && x5 && x6 && x7 && x8 && x9 && x10 && x11 && x12 && x13 && x14 && x15 && x16)
            {






               
                label13.Text = (clickCount/2).ToString();
                timer1.Enabled = false;
                if (timer1.Enabled == false)
                {
                    MessageBox.Show("Tebrikler oyunu bitirdiniz puanınız:" + puan);

                    clickCount = 0;
                    puan = 0;
                    con.Open();


                    SqlCommand komutguncelle2 = new SqlCommand("update tbl_users set puan=@a1, hamle=@a2 where username=@a3", con);
                    komutguncelle2.Parameters.AddWithValue("@a1", (label8.Text));
                    komutguncelle2.Parameters.AddWithValue("@a2", (label13.Text));
                    komutguncelle2.Parameters.AddWithValue("@a3", (label10.Text));
                    komutguncelle2.ExecuteNonQuery();
                    con.Close();

                    // Veritabanı bağlantısı
                    

                    // Verileri seçin
                    string query = "SELECT * FROM tbl_users";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Verileri okuyun
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Dosyayı yazma modunda açın
                    StreamWriter writer = new StreamWriter(@"C:\Users\\harun\Desktop\Login-and-Register-form-orjinal\veriler.txt");

                    // Verileri yazdırın
                    while (reader.Read())
                    {
                        writer.WriteLine("kullacı adı: "+reader["username"].ToString() + "|| hamle sayısı:" + reader["hamle"].ToString() + "|| puan:" + reader["puan"].ToString());
                    }

                    // Dosyayı kapatın
                    writer.Close();
                    reader.Close();
                    con.Close();


                   

                    
                   
                


            }





            }
            
            if (x1 || x2 || x3 ||x4 || x5 || x6 || x7 || x8 || x9 || x10 || x11 || x12 || x13 || x14 || x15 ||x16)
            {
                guna2Button3.Enabled = false;
            }



                sn++;
            label6.Text = sn.ToString();
            if (sn == 5)
            {
                dk = dk + 1;
                label4.Text = dk.ToString();
                sn = 0;
                label6.Text = sn.ToString();
            }

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox100.Enabled = true;
            pictureBox101.Enabled = true;
            pictureBox102.Enabled = true;
            pictureBox103.Enabled = true;
            pictureBox104.Enabled = true;
            pictureBox105.Enabled = true;
            pictureBox106.Enabled = true;
            pictureBox107.Enabled = true;
            pictureBox108.Enabled = true;
            pictureBox109.Enabled = true;
            pictureBox110.Enabled = true;
            pictureBox111.Enabled = true;
            pictureBox115.Enabled = true;
            pictureBox114.Enabled = true;
            pictureBox113.Enabled = true;
            pictureBox112.Enabled = true;
        }
        private PictureBox selectedPictureBox = null; // Kullanıcının tıkladığı kutucuğu kaydeden değişken

        private void pictureBox101_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;


            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x2 = ResimEsitMi(pictureBox101.Image, pictureBox204.Image);

                if (x2)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }
                selectedPictureBox = null;
            }
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x3 = ResimEsitMi(pictureBox102.Image, pictureBox208.Image);

                if (x3)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }
                selectedPictureBox = null;
            }
        }

        private void pictureBox103_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;


            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x4 = ResimEsitMi(pictureBox103.Image, pictureBox212.Image);

                if (x4)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }
                selectedPictureBox = null;
            }

        }

        private void pictureBox104_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x5 = ResimEsitMi(pictureBox104.Image, pictureBox201.Image);

                if (x5)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }
                selectedPictureBox = null;
            }

        }

        private void pictureBox105_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;


            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x6 = ResimEsitMi(pictureBox105.Image, pictureBox205.Image);

                if (x6)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }
                selectedPictureBox = null;
            }
        }

        private void pictureBox106_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x7 = ResimEsitMi(pictureBox106.Image, pictureBox209.Image);

                if (x7)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }
                selectedPictureBox = null;
            }
        }

        private void pictureBox107_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x8 = ResimEsitMi(pictureBox107.Image, pictureBox213.Image);

                if (x8)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }
                selectedPictureBox = null;
            }
        }

        private void pictureBox108_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x9 = ResimEsitMi(pictureBox108.Image, pictureBox202.Image);

                if (x9)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }
                selectedPictureBox = null;
            }

        }

        private void pictureBox109_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x10 = ResimEsitMi(pictureBox109.Image, pictureBox206.Image);

                if (x10)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }
                selectedPictureBox = null;
            }
        }

        private void pictureBox110_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;


            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x11 = ResimEsitMi(pictureBox110.Image, pictureBox210.Image);

                if (x11)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }
                selectedPictureBox = null;
            }

        }

        private void pictureBox111_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x12 = ResimEsitMi(pictureBox111.Image, pictureBox214.Image);

                if (x12)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }

                selectedPictureBox = null;
            }

        }

        private void pictureBox112_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x13 = ResimEsitMi(pictureBox112.Image, pictureBox203.Image);

                if (x13)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }

                selectedPictureBox = null;
            }
        }

        private void pictureBox113_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x14 = ResimEsitMi(pictureBox113.Image, pictureBox207.Image);

                if (x14)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }

                selectedPictureBox = null;
            }
        }

        private void pictureBox114_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x15 = ResimEsitMi(pictureBox114.Image, pictureBox211.Image);

                if (x15)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }

                selectedPictureBox = null;
            }

        }

        private void pictureBox115_Click(object sender, EventArgs e)
        {
            clickCount++;
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {
                selectedPictureBox = clickedPictureBox;

            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x16 = ResimEsitMi(pictureBox115.Image, pictureBox215.Image);

                if (x16)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }

                selectedPictureBox = null;
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox100.Enabled = false;
            pictureBox101.Enabled = false;
            pictureBox102.Enabled = false;
            pictureBox103.Enabled = false;
            pictureBox104.Enabled = false;
            pictureBox105.Enabled = false;
            pictureBox106.Enabled = false;
            pictureBox107.Enabled = false;
            pictureBox108.Enabled = false;
            pictureBox109.Enabled = false;
            pictureBox110.Enabled = false;
            pictureBox111.Enabled = false;
            pictureBox115.Enabled = false;
            pictureBox114.Enabled = false;
            pictureBox113.Enabled = false;
            pictureBox112.Enabled = false;
        }
        
        private void guna2Button4_Click(object sender, EventArgs e)
        {
             OpenFileDialog openFileDialog1 = new OpenFileDialog();
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 textBox1.Text = openFileDialog1.FileName;

             }
            
            guna2Button1.Enabled = true;
            guna2Button2.Enabled = true;
            guna2Button3.Enabled = true;
            pictureBox200.Visible = true;
            pictureBox201.Visible =true;
            pictureBox202.Visible = true;
            pictureBox203.Visible = true;
            pictureBox204.Visible = true;
            pictureBox205.Visible = true;
            pictureBox206.Visible = true;
            pictureBox207.Visible = true;
            pictureBox208.Visible = true;
            pictureBox209.Visible = true;
            pictureBox210.Visible = true;
            pictureBox211.Visible = true;
            pictureBox215.Visible = true;
            pictureBox214.Visible = true;
            pictureBox213.Visible = true;
            pictureBox212.Visible = true;


           string url =textBox1.Text;
            
            var imgarray = new Image[16];
            var img = Image.FromFile(url);
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var index = i * 4 + j;
                    imgarray[index] = new Bitmap(104, 104);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, 104, 104), new Rectangle(i * 104, j * 104, 104, 104), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            pictureBox200.Image = imgarray[0];
            pictureBox201.Image = imgarray[1];
            pictureBox202.Image = imgarray[2];
            pictureBox203.Image = imgarray[3];
            pictureBox204.Image = imgarray[4];
            pictureBox205.Image = imgarray[5];
            pictureBox206.Image = imgarray[6];
            pictureBox207.Image = imgarray[7];
            pictureBox208.Image = imgarray[8];
            pictureBox209.Image = imgarray[9];
            pictureBox210.Image = imgarray[10];
            pictureBox211.Image = imgarray[11];
            pictureBox212.Image = imgarray[12];
            pictureBox213.Image = imgarray[13];
            pictureBox214.Image = imgarray[14];
            pictureBox215.Image = imgarray[15];
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pictureBox100.Visible = true;
            pictureBox101.Visible = true;
            pictureBox102.Visible = true;
            pictureBox103.Visible = true;
            pictureBox104.Visible = true;
            pictureBox105.Visible = true;
            pictureBox106.Visible = true;
            pictureBox107.Visible = true;
            pictureBox108.Visible = true;
            pictureBox109.Visible = true;
            pictureBox110.Visible = true;
            pictureBox111.Visible = true;
            pictureBox115.Visible = true;
            pictureBox114.Visible = true;
            pictureBox113.Visible = true;
            pictureBox112.Visible = true;

            string url = textBox1.Text;
            var imgarray = new Image[16];
            var img = Image.FromFile(url);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var index = i * 4 + j;
                    imgarray[index] = new Bitmap(104, 104);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, 104, 104), new Rectangle(i * 104, j * 104, 104, 104), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }; // Örnek bir dizi

            // Dizinin elemanlarının yerlerini rastgele değiştirelim
            Random rnd = new Random();
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            pictureBox100.Image = imgarray[arr[0]];
            pictureBox101.Image = imgarray[arr[1]];
            pictureBox102.Image = imgarray[arr[2]];
            pictureBox103.Image = imgarray[arr[3]];
            pictureBox104.Image = imgarray[arr[4]];
            pictureBox105.Image = imgarray[arr[5]];
            pictureBox106.Image = imgarray[arr[6]];
            pictureBox107.Image = imgarray[arr[7]];
            pictureBox108.Image = imgarray[arr[8]];
            pictureBox109.Image = imgarray[arr[9]];
            pictureBox110.Image = imgarray[arr[10]];
            pictureBox111.Image = imgarray[arr[11]];
            pictureBox112.Image = imgarray[arr[12]];
            pictureBox113.Image = imgarray[arr[13]];
            pictureBox114.Image = imgarray[arr[14]];
            pictureBox115.Image = imgarray[arr[15]];
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (selectedPictureBox == null) // İlk kutucuğa tıklandığında
            {

                selectedPictureBox = clickedPictureBox;



            }
            else // İkinci kutucuğa tıklandığında
            {
                // İki kutucuğun resimlerini ve pozisyonlarını değiştir
                Image tempImage = selectedPictureBox.Image;
                selectedPictureBox.Image = clickedPictureBox.Image;
                clickedPictureBox.Image = tempImage;
                bool x1 = ResimEsitMi(pictureBox100.Image, pictureBox200.Image);
                if (x1)
                {
                    puan += 5;
                }
                else
                {
                    puan -= 10;
                }



                selectedPictureBox = null;
            }

        }



       
    }
}
