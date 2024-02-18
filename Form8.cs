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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;

        static string constring = "Data Source=DESKTOP-755BHPJ;Initial Catalog=sinema;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);
        public void kayitgetir()
        {
            baglan = new SqlConnection("Data Source=DESKTOP-755BHPJ;Initial Catalog=sinema;Integrated Security=True");
            baglan.Open();
            da = new SqlDataAdapter("Select * From sinema", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();

        }

        public void verisil(int id)
        {
            string sil = "delete from sinema where id =@id";
            SqlCommand komut = new SqlCommand(sil, baglan);
            baglan.Open();
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglan.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "insert into sinema (sadi)values(@sadi)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@sadi", textBox1.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Eklendi");

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Var" + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 giris = new Form7();
            giris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil(id);
                kayitgetir();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 giris = new Form9();
            giris.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 giris = new Form10();
            giris.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
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
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
            button7.BackColor = Color.Black;
            button7.ForeColor = Color.White;
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
            button9.BackColor = Color.Black;
            button9.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
        }

        private void button8_Click(object sender, EventArgs e)
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
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Black;
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Black;
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Black;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
        }
    }
}
