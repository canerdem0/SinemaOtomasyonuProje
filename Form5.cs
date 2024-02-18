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

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=DESKTOP-755BHPJ;Initial Catalog=kullanicigiris;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);
        public void getir()
        {
            
            string liste = "Select * From ekle WHERE id > 1011";
            SqlCommand komut = new SqlCommand(liste,baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "insert into ekle (kadi,ksoyadi,sifre,email) values(@kadi," +
                        "@ksoyadi,@sifre,@email)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@kadi", textBox1.Text);
                    komut.Parameters.AddWithValue("@ksoyadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox3.Text);
                    komut.Parameters.AddWithValue("@email", textBox4.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Eklendi");

                }
            }
            catch(Exception hata)
            {
                MessageBox.Show("Hata Var"+hata.Message);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Black;
        }
    }
}
