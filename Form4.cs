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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        static string constring = ("\r\nData Source=DESKTOP-755BHPJ;Initial Catalog=kullanicigiris;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);

        public void kayitgetir()
        {

            string getir = "select * from kullaniciekle";
            SqlCommand komut = new SqlCommand(getir,baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (baglan.State == ConnectionState.Closed)
                {

                    baglan.Open();
                    string kayit = "insert into kullaniciekle (kullaniciadi,kullanicisoyadi,sifre,email)values('@kullaniciadi','@kullanicisoyadi','@sifre','@email');";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
                    komut.Parameters.AddWithValue("@kullanicisoyadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox3.Text);
                    komut.Parameters.AddWithValue("@email", textBox4.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Ekleme Başarılı");
                }
            

                


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
