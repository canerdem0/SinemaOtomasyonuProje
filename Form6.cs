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

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form6()
        {
            InitializeComponent();
        }


        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
            con = new SqlConnection("\r\nData Source=DESKTOP-755BHPJ;Initial Catalog=yonetici;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From yoneticigiris where yadi='" + textBox1.Text +
            "'And ysoyadi='" + textBox2.Text + "'And sifre='" + textBox3.Text + "'And email='" + textBox4.Text + "'";
            com.CommandText = "Select * From yekle where yadi='" + textBox1.Text +
            "'And ysoyadi='" + textBox2.Text + "'And sifre='" + textBox3.Text + "'And email='" + textBox4.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Hoş Geldiniz");
                Form7 gecis = new Form7();
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
            Form1 giris1 = new Form1();
            giris1.Show();
            this.Hide();
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
