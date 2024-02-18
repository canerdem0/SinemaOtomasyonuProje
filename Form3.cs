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
using System.Resources;
using System.Reflection.Emit;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=DESKTOP-755BHPJ;Initial Catalog=bilet;Integrated Security=True");
        SqlConnection baglan4 = new SqlConnection(constring);
        SqlConnection baglan;
        SqlConnection baglan2;
        SqlConnection baglan3;
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        void Sinemaekle()
        {
            baglan = new SqlConnection("Data Source=DESKTOP-755BHPJ;Initial Catalog=sinema;Integrated Security=True");
            baglan.Open();
            da = new SqlDataAdapter("Select * From sinema WHERE id > 6", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        public void kayitgetir()
        {

            baglan = new SqlConnection("Data Source=DESKTOP-755BHPJ;Initial Catalog=sinema;Integrated Security=True");
            baglan.Open();
            da = new SqlDataAdapter("Select * From sinema WHERE id < 7", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        public void kayitgetir2()
        {

            baglan2 = new SqlConnection("Data Source=DESKTOP-755BHPJ;Initial Catalog=sinema;Integrated Security=True");
            baglan2.Open();
            da2 = new SqlDataAdapter("Select * From salon", baglan2);
            DataTable tablo2 = new DataTable();
            da2.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglan2.Close();

        }
        public void kayitgetir3()
        {
            baglan3 = new SqlConnection("Data Source=DESKTOP-755BHPJ;Initial Catalog=sinema;Integrated Security=True");
            baglan3.Open();
            da3 = new SqlDataAdapter("Select * From seans", baglan3);
            DataTable tablo3 = new DataTable();
            da3.Fill(tablo3);
            dataGridView3.DataSource = tablo3;
            baglan3.Close();
        }
        public void kayitgetir4()
        {

            string getir = "select * from biletdetay";
            SqlCommand komut = new SqlCommand(getir, baglan4);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView4.DataSource = dt;
            baglan4.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Sinemaekle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kayitgetir2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="John Wick 4")
            {
                textBox3.Text = "8,2";
            }
            else if(textBox1.Text == "Super Mario")
            {
                textBox3.Text = "7,3";
            }
            else if (textBox1.Text == "Ejderhalar ve Zindanlar")
            {
                textBox3.Text = "7,4";
            }
            else if (textBox1.Text == "65")
            {
                textBox3.Text = "5,4";
            }
            else if (textBox1.Text == "Recep İvedik 7")
            {
                textBox3.Text = "5,2";
            }
            else if (textBox1.Text == "Black Adam")
            {
                textBox3.Text = "6,3";
            }
            else if (textBox1.Text == "Sonic 2")
            {
                textBox3.Text = "6,5";
            }
            else if (textBox1.Text == "Morbius")
            {
                textBox3.Text = "5,2";
            }
            else
            {
                MessageBox.Show("Sadece Kayıtlı Olan Filmlerin IMDB'sini görebilirsiniz");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kayitgetir3();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button9.Text;
            if (textBox5.Text == button9.Text && textBox2.Text == "Salon 1")
            {
                button9.BackColor = Color.Green;
            }
            else
            {
                button9.BackColor = Color.Red;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button13.Text;
            if (textBox5.Text == button13.Text && textBox2.Text == "Salon 1")
            {
                button13.BackColor = Color.Green;
            }
            else
            {
                button13.BackColor = Color.Red;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button17.Text;
            if (textBox5.Text == button17.Text && textBox2.Text == "Salon 1")
            {
                button17.BackColor = Color.Green;
            }
            else
            {
                button17.BackColor = Color.Red;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button21.Text;
            if (textBox5.Text == button21.Text && textBox2.Text == "Salon 1")
            {
                button21.BackColor = Color.Green;
            }
            else
            {
                button21.BackColor = Color.Red;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button10.Text;
            if (textBox5.Text == button10.Text && textBox2.Text == "Salon 1")
            {
                button10.BackColor = Color.Green;
            }
            else
            {
                button10.BackColor = Color.Red;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button14.Text;
            if (textBox5.Text == button14.Text && textBox2.Text == "Salon 1")
            {
                button14.BackColor = Color.Green;
            }
            else
            {
                button14.BackColor = Color.Red;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button18.Text;
            if (textBox5.Text == button18.Text && textBox2.Text == "Salon 1")
            {
                button18.BackColor = Color.Green;
            }
            else
            {
                button18.BackColor = Color.Red;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button22.Text;
            if (textBox5.Text == button22.Text && textBox2.Text == "Salon 1")
            {
                button22.BackColor = Color.Green;
            }
            else
            {
                button22.BackColor = Color.Red;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button11.Text;
            if (textBox5.Text == button11.Text && textBox2.Text == "Salon 1")
            {
                button11.BackColor = Color.Green;
            }
            else
            {
                button11.BackColor = Color.Red;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button15.Text;
            if (textBox5.Text == button15.Text && textBox2.Text == "Salon 1")
            {
                button15.BackColor = Color.Green;
            }
            else
            {
                button15.BackColor = Color.Red;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button19.Text;
            if (textBox5.Text == button19.Text && textBox2.Text == "Salon 1")
            {
                button19.BackColor = Color.Green;
            }
            else
            {
                button19.BackColor = Color.Red;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button23.Text;
            if (textBox5.Text == button23.Text && textBox2.Text == "Salon 1")
            {
                button23.BackColor = Color.Green;
            }
            else
            {
                button23.BackColor = Color.Red;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button12.Text;
            if (textBox5.Text == button12.Text && textBox2.Text == "Salon 1")
            {
                button12.BackColor = Color.Green;
            }
            else
            {
                button12.BackColor = Color.Red;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button16.Text;
            if (textBox5.Text == button16.Text && textBox2.Text == "Salon 1")
            {
                button16.BackColor = Color.Green;
            }
            else
            {
                button16.BackColor = Color.Red;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button20.Text;
            if (textBox5.Text == button20.Text && textBox2.Text == "Salon 1")
            {
                button20.BackColor = Color.Green;
            }
            else
            {
                button20.BackColor = Color.Red;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button24.Text;
            if (textBox5.Text == button24.Text && textBox2.Text == "Salon 1")
            {
                button24.BackColor = Color.Green;
            }
            else
            {
                button24.BackColor = Color.Red;
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="Salon 1")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
            else if (textBox2.Text=="Salon 2")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
            else if(textBox2.Text == "Salon 3")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
            else
            {
                MessageBox.Show("Böyle bir salonumuz yok ya da salon yeni eklendi");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button36.Text;
            if (textBox5.Text == button36.Text && textBox2.Text == "Salon 2")
            {
                button36.BackColor = Color.Green;
            }
            else
            {
                button36.BackColor = Color.Red;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button32.Text;
            if (textBox5.Text == button32.Text && textBox2.Text == "Salon 2")
            {
                button32.BackColor = Color.Green;
            }
            else
            {
                button32.BackColor = Color.Red;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button28.Text;
            if (textBox5.Text == button28.Text && textBox2.Text == "Salon 2")
            {
                button28.BackColor = Color.Green;
            }
            else
            {
                button28.BackColor = Color.Red;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button35.Text;
            if (textBox5.Text == button35.Text && textBox2.Text == "Salon 2")
            {
                button35.BackColor = Color.Green;
            }
            else
            {
                button35.BackColor = Color.Red;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button31.Text;
            if (textBox5.Text == button31.Text && textBox2.Text == "Salon 2")
            {
                button31.BackColor = Color.Green;
            }
            else
            {
                button31.BackColor = Color.Red;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button27.Text;
            if (textBox5.Text == button27.Text && textBox2.Text == "Salon 2")
            {
                button27.BackColor = Color.Green;
            }
            else
            {
                button27.BackColor = Color.Red;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button34.Text;
            if (textBox5.Text == button34.Text && textBox2.Text == "Salon 2")
            {
                button34.BackColor = Color.Green;
            }
            else
            {
                button34.BackColor = Color.Red;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button30.Text;
            if (textBox5.Text == button30.Text && textBox2.Text == "Salon 2")
            {
                button30.BackColor = Color.Green;
            }
            else
            {
                button30.BackColor = Color.Red;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button26.Text;
            if (textBox5.Text == button26.Text && textBox2.Text == "Salon 2")
            {
                button26.BackColor = Color.Green;
            }
            else
            {
                button26.BackColor = Color.Red;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button33.Text;
            if (textBox5.Text == button33.Text && textBox2.Text == "Salon 2")
            {
                button33.BackColor = Color.Green;
            }
            else
            {
                button33.BackColor = Color.Red;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button29.Text;
            if (textBox5.Text == button29.Text && textBox2.Text == "Salon 2")
            {
                button29.BackColor = Color.Green;
            }
            else
            {
                button29.BackColor = Color.Red;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button25.Text;
            if (textBox5.Text == button25.Text && textBox2.Text == "Salon 2")
            {
                button25.BackColor = Color.Green;
            }
            else
            {
                button25.BackColor = Color.Red;
            }
        }
        //-----------------------------------------------------------------
        private void button48_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button48.Text;
            if (textBox5.Text == button48.Text && textBox2.Text == "Salon 3")
            {
                button48.BackColor = Color.Green;
            }
            else
            {
                button48.BackColor = Color.Red;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button44.Text;
            if (textBox5.Text == button44.Text && textBox2.Text == "Salon 3")
            {
                button44.BackColor = Color.Green;
            }
            else
            {
                button44.BackColor = Color.Red;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button40.Text;
            if (textBox5.Text == button40.Text && textBox2.Text == "Salon 3")
            {
                button40.BackColor = Color.Green;
            }
            else
            {
                button40.BackColor = Color.Red;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button47.Text;
            if (textBox5.Text == button47.Text && textBox2.Text == "Salon 3")
            {
                button47.BackColor = Color.Green;
            }
            else
            {
                button47.BackColor = Color.Red;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button43.Text;
            if (textBox5.Text == button43.Text && textBox2.Text == "Salon 3")
            {
                button43.BackColor = Color.Green;
            }
            else
            {
                button43.BackColor = Color.Red;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button39.Text;
            if (textBox5.Text == button39.Text && textBox2.Text == "Salon 3")
            {
                button39.BackColor = Color.Green;
            }
            else
            {
                button39.BackColor = Color.Red;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button46.Text;
            if (textBox5.Text == button46.Text && textBox2.Text == "Salon 3")
            {
                button46.BackColor = Color.Green;
            }
            else
            {
                button46.BackColor = Color.Red;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button42.Text;
            if (textBox5.Text == button42.Text && textBox2.Text == "Salon 3")
            {
                button42.BackColor = Color.Green;
            }
            else
            {
                button42.BackColor = Color.Red;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button38.Text;
            if (textBox5.Text == button38.Text && textBox2.Text == "Salon 3")
            {
                button38.BackColor = Color.Green;
            }
            else
            {
                button38.BackColor = Color.Red;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button45.Text;
            if (textBox5.Text == button45.Text && textBox2.Text == "Salon 3")
            {
                button45.BackColor = Color.Green;
            }
            else
            {
                button45.BackColor = Color.Red;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button41.Text;
            if (textBox5.Text == button41.Text && textBox2.Text == "Salon 3")
            {
                button41.BackColor = Color.Green;
            }
            else
            {
                button41.BackColor = Color.Red;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //textBox5.Text = button37.Text;
            if (textBox5.Text == button37.Text && textBox2.Text=="Salon 3")
            {
                button37.BackColor = Color.Green;
            }
            else
            {
                button37.BackColor = Color.Red;
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (textBox1.Text== "John Wick 4" && textBox1.Text == "Sonic 2" && textBox1.Text == "Super Mario")
            {
                MessageBox.Show("Film-"+textBox1.Text+" Salon-"+textBox2.Text+" Seans-"+textBox4.Text+" IMDB-"+ textBox3.Text+" Koltuk No-"+textBox5.Text+" Fiyat = 80");
            }
            else
            {
                MessageBox.Show("Film-" + textBox1.Text + " Salon-" + textBox2.Text + " Seans-" + textBox4.Text + " IMDB-" + textBox3.Text + " Koltuk No-" + textBox5.Text + " Fiyat = 75");
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "John Wick 4")
            {
                pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._11;
            }
            else if (textBox1.Text == "Super Mario")
            {
                pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._21;
            }
            else if (textBox1.Text == "Ejderhalar ve Zindanlar")
            {
                pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._31;
            }
            else if (textBox1.Text == "65")
            {
                pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._41;
            }
            else if (textBox1.Text == "Recep İvedik 7")
            {
                pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._51;
            }
            else if (textBox1.Text == "Black Adam")
            {
                pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._61;
            }
            else if (textBox1.Text == "Sonic 2")
            {
                pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._71;
            }
            else if (textBox1.Text == "Morbius")
            {
                pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._81;
            }
            else
            {
                pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._9;
                label3.Text = "Bu film yönetici tarafından yeni eklendi veye böyle bir film yok";
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan4.State == ConnectionState.Closed)
                {
                    baglan4.Open();
                    string kayit = "insert into biletdetay (film,salon,seans,koltuk,imdb) values(@film," +
                        "@salon,@seans,@koltuk,@imdb)";
                    SqlCommand komut = new SqlCommand(kayit, baglan4);
                    komut.Parameters.AddWithValue("@film", textBox1.Text);
                    komut.Parameters.AddWithValue("@salon", textBox2.Text);
                    komut.Parameters.AddWithValue("@seans", textBox4.Text);
                    komut.Parameters.AddWithValue("@koltuk", textBox5.Text);
                    komut.Parameters.AddWithValue("@imdb", textBox3.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Eklendi");

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Var" + hata.Message);
            }

        }

        private void button54_Click(object sender, EventArgs e)
        {
            kayitgetir4();
        }

        private void button54_Click_1(object sender, EventArgs e)
        {
            kayitgetir4();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
            button49.BackColor = Color.Black;
            button49.ForeColor = Color.White;
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
            button50.BackColor = Color.Black;
            button50.ForeColor = Color.White;
            button51.BackColor = Color.Black;
            button51.ForeColor = Color.White;
            button52.BackColor = Color.Black;
            button52.ForeColor = Color.White;
            button53.BackColor = Color.Black;
            button53.ForeColor = Color.White;
            button55.BackColor = Color.Black;
            button55.ForeColor = Color.White;
            button54.BackColor = Color.Black;
            button54.ForeColor = Color.White;
            button56.BackColor = Color.Black;
            button56.ForeColor = Color.White;
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
            button7.BackColor = Color.Black;
            button7.ForeColor = Color.White;
            button57.BackColor = Color.Black;
            button57.ForeColor = Color.White;
            groupBox1.BackColor = Color.Black;
            groupBox1.ForeColor = Color.White;
            groupBox2.BackColor = Color.Black;
            groupBox2.ForeColor = Color.White;
            groupBox3.BackColor = Color.Black;
            groupBox3.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            button9.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            button11.ForeColor = Color.Black;
            button12.ForeColor = Color.Black;
            button13.ForeColor = Color.Black;
            button14.ForeColor = Color.Black;
            button15.ForeColor = Color.Black;
            button16.ForeColor = Color.Black;
            button17.ForeColor = Color.Black;
            button18.ForeColor = Color.Black;
            button19.ForeColor = Color.Black;
            button20.ForeColor = Color.Black;
            button21.ForeColor = Color.Black;
            button22.ForeColor = Color.Black;
            button23.ForeColor = Color.Black;
            button24.ForeColor = Color.Black;
            button25.ForeColor = Color.Black;
            button26.ForeColor = Color.Black;
            button27.ForeColor = Color.Black;
            button28.ForeColor = Color.Black;
            button29.ForeColor = Color.Black;
            button30.ForeColor = Color.Black;
            button31.ForeColor = Color.Black;
            button32.ForeColor = Color.Black;
            button33.ForeColor = Color.Black;
            button34.ForeColor = Color.Black;
            button35.ForeColor = Color.Black;
            button36.ForeColor = Color.Black;
            button37.ForeColor = Color.Black;
            button38.ForeColor = Color.Black;
            button39.ForeColor = Color.Black;
            button40.ForeColor = Color.Black;
            button41.ForeColor = Color.Black;
            button42.ForeColor = Color.Black;
            button43.ForeColor = Color.Black;
            button44.ForeColor = Color.Black;
            button45.ForeColor = Color.Black;
            button46.ForeColor = Color.Black;
            button47.ForeColor = Color.Black;
            button48.ForeColor = Color.Black;


        }

        private void button57_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Black;
            button49.BackColor = Color.White;
            button49.ForeColor = Color.Black;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
            button50.BackColor = Color.White;
            button50.ForeColor = Color.Black;
            button51.BackColor = Color.White;
            button51.ForeColor = Color.Black;
            button52.BackColor = Color.White;
            button52.ForeColor = Color.Black;
            button53.BackColor = Color.White;
            button53.ForeColor = Color.Black;
            button55.BackColor = Color.White;
            button55.ForeColor = Color.Black;
            button54.BackColor = Color.White;
            button54.ForeColor = Color.Black;
            button56.BackColor = Color.White;
            button56.ForeColor = Color.Black;
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Black;
            button57.BackColor = Color.White;
            button57.ForeColor = Color.Black;
            groupBox1.BackColor = Color.White;
            groupBox1.ForeColor = Color.Black;
            groupBox2.BackColor = Color.White;
            groupBox2.ForeColor = Color.Black;
            groupBox3.BackColor = Color.White;
            groupBox3.ForeColor = Color.Black;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
        }
    }
}
