using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
            con = new SqlConnection("\r\nData Source=DESKTOP-755BHPJ;Initial Catalog=kullanicigiris;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From kullanicigiris where kullaniciadi='" + textBox1.Text +
            "'And kullanicisoyadi='" + textBox2.Text + "'And sifre='" + textBox3.Text + "'And email='" + textBox4.Text +"'";
            com.CommandText = "Select * From ekle where kadi='" + textBox1.Text +
"'And ksoyadi='" + textBox2.Text + "'And sifre='" + textBox3.Text + "'And email='" + textBox4.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Başarılı");
                Form3 gecis = new Form3();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
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
