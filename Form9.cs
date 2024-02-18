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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace WindowsFormsApp1
{
    public partial class Form9 : Form
    {
        public Form9()
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
            da = new SqlDataAdapter("Select * From salon", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglan.Close();

        }
        public void verisil(int id)
        {
            string sil = "delete from salon where id =@id";
            SqlCommand komut = new SqlCommand(sil, baglan);
            baglan.Open();
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "insert into salon (salonadi)values(@salonadi)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@salonadi", textBox2.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Eklendi");

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Var" + hata.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil(id);
                kayitgetir();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 giris = new Form8();
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 giris = new Form7();
            giris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 giris = new Form10();
            giris.Show();
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
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
            button7.BackColor = Color.Black;
            button7.ForeColor = Color.White;
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
            button9.BackColor = Color.Black;
            button9.ForeColor = Color.White;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
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
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
        }
    }
}
