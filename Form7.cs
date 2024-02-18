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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=DESKTOP-755BHPJ;Initial Catalog=yonetici;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);
        public void getir()
        {

            string liste = "select * from yekle";
            SqlCommand komut = new SqlCommand(liste, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
        public void getir2()
        {

            string liste2 = "select * from yoneticigiris";
            SqlCommand komut = new SqlCommand(liste2, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
            baglan.Close();
        }
        public void verisil(int id)
        {
            string sil = "delete from yekle where id =@id";
            SqlCommand komut = new SqlCommand(sil,baglan);
            baglan.Open();
            komut.Parameters.AddWithValue("@id",id);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        public void verisil2(int id)
        {
            string sil2 = "delete from yoneticigiris where id =@id";
            SqlCommand komut = new SqlCommand(sil2, baglan);
            baglan.Open();
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "insert into yekle (yadi,ysoyadi,sifre,email) values(@yadi," +
                        "@ysoyadi,@sifre,@email)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@yadi", textBox1.Text);
                    komut.Parameters.AddWithValue("@ysoyadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox3.Text);
                    komut.Parameters.AddWithValue("@email", textBox4.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Eklendi");

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Var" + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getir();
            getir2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kayit = "Select * from yekle where yadi=@yadi";
            SqlCommand komut = new SqlCommand(kayit,baglan);
            komut.Parameters.AddWithValue("@yadi",textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil(id);
                getir();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil2(id);
                getir2();
            }
        }
        int i = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string guncelle = ("update yekle set yadi=@yadi,ysoyadi=@ysoyadi,"+
                "sifre=@sifre,email=@email where id=@id");
            SqlCommand komut = new SqlCommand(guncelle, baglan);
            komut.Parameters.AddWithValue("@yadi",textBox1.Text);
            komut.Parameters.AddWithValue("@ysoyadi",textBox2.Text);
            komut.Parameters.AddWithValue("@sifre",textBox3.Text);
            komut.Parameters.AddWithValue("@email",textBox4.Text);
            komut.Parameters.AddWithValue("id",dataGridView1.Rows[i].Cells[0].Value);
            komut.ExecuteNonQuery();
            baglan.Close();
            getir();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 giris8 = new Form8();
            giris8.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 giris = new Form9();
            giris.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 giris10 = new Form10();
            giris10.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 giris1 = new Form1();
            giris1.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
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
            button10.BackColor = Color.Black;
            button10.ForeColor = Color.White;
            button11.BackColor = Color.Black;
            button11.ForeColor = Color.White;
            button12.BackColor = Color.Black;
            button12.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
        }

        private void button12_Click(object sender, EventArgs e)
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
            button10.BackColor = Color.White;
            button10.ForeColor = Color.Black;
            button11.BackColor = Color.White;
            button11.ForeColor = Color.Black;
            button12.BackColor = Color.White;
            button12.ForeColor = Color.Black;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Black;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
        }
    }
}
