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

namespace OrderMangerBlank
{
    public partial class orderform : Form
    {
        public orderform()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MSI;Initial Catalog=Pizza;Integrated Security=True");
        private void orderform_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pizzaDataSet4.Product2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.product2TableAdapter2.Fill(this.pizzaDataSet4.Product2);
            // TODO: Bu kod satırı 'pizzaDataSet3.Product2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.product2TableAdapter1.Fill(this.pizzaDataSet3.Product2);
            // TODO: Bu kod satırı 'pizzaDataSet2.Product2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.product2TableAdapter.Fill(this.pizzaDataSet2.Product2);

        }
        private void Reset()
        {
            textBox5.Text = "";
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }

        public void kayitlari_getir()
        {
            baglan.Open();
            string getir = "Select *From Product2 Order By PId";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();


        }
        public void kayitsil()
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand("Delete From Product2 Where PId =@p0", baglan);
            sil.Parameters.AddWithValue("@p0", textBox5.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Deleted");
            kayitlari_getir();
        }
        public void kayitguncelle(decimal xyz)
        {
            string kayitGuncelle = "UPDATE Product2 SET PName=@p1, PCat=@p2, PWe=@p3, PPr=@p4, PQu=@p5 Where PId=@p0";

            SqlCommand komut = new SqlCommand(kayitGuncelle, baglan);

            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", comboBox1.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox4.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox2.Text));
            komut.Parameters.AddWithValue("@p5", xyz);
            komut.Parameters.AddWithValue("@p0", dataGridView1.CurrentRow.Cells[0].Value);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Siparişiniz alınmıştır.");
            kayitlari_getir();
        }
         public void miktar()
        {
            decimal toplam = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value);
            decimal girilenmiktar = Convert.ToInt32(textBox3.Text);
           if(girilenmiktar<=0 || toplam<girilenmiktar)
            {
                MessageBox.Show("Geçersiz işlem yaptınız!!!Lütfen en fazla stoktaki mevcut mikatar kadar sayı giriniz...");
            }
           else
            {
                decimal sonuc = toplam - girilenmiktar;
                kayitguncelle(sonuc);
                try
                 {


                }
                 catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miktar();
            try
            {

                baglan.Open();
                SqlCommand komut = new SqlCommand("Insert into Sepet1(PName,PCat,PWe,PPr,PQu) Values(@PN,@PC,@PW,@PP,@PQ)", baglan);
                komut.Parameters.AddWithValue("@PN", textBox1.Text);
                komut.Parameters.AddWithValue("@PC", comboBox1.Text);
                komut.Parameters.AddWithValue("@Pw", textBox4.Text);
                komut.Parameters.AddWithValue("@PP", textBox2.Text);
                komut.Parameters.AddWithValue("@PQ", textBox3.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Reset();

            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
