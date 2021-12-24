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
    public partial class guncelle : Form
    {
        public guncelle()
        {
            InitializeComponent();
        }

        private void guncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pizzaDataSet1.Product2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.product2TableAdapter.Fill(this.pizzaDataSet1.Product2);

        }
        SqlConnection baglan = new SqlConnection("Data Source=MSI;Initial Catalog=Pizza;Integrated Security=True");
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
        public void URUN()
        {
            ORDER_DETAIL URUN = new ORDER_DETAIL();
            URUN.ITEM.pname = textBox1.Text;
            textBox2.Text = URUN.ITEM.Price.ToString();
            comboBox1.Text = URUN.ITEM.description.ToString();
            textBox4.Text = URUN.ITEM.ShippingWeight.ToString();
            textBox3.Text = URUN.Quantity.ToString();
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
            MessageBox.Show("Product  Deleted");
            kayitlari_getir();
        }
        public void miktar()
        {
            decimal toplam = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value);
            decimal girilenmiktar = Convert.ToInt32(textBox3.Text);
            if (girilenmiktar < 0 || toplam < girilenmiktar)
            {
                MessageBox.Show("Geçersiz işlem yaptınız!!!Lütfen en fazla stoktaki mevcut mikatar kadar sayı giriniz...");
            }

            else if (girilenmiktar == 0)
            {
                
                
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("Delete From Product2 where PQu=0 ", baglan) ;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    kayitlari_getir();
                MessageBox.Show("DELETED THİS PRODUCT");
                   
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
           
            string kayitGuncelle = "UPDATE Product2 SET PName=@p1, PCat=@p2, PWe=@p3, PPr=@p4, PQu=@p5 Where PId=@p0";

            SqlCommand komut = new SqlCommand(kayitGuncelle, baglan);

            ORDER_DETAIL u = new ORDER_DETAIL();
            int a = Convert.ToInt32(textBox3.Text);
            u.Quantity = a;
            string b = textBox1.Text;
            int c = Convert.ToInt32(textBox2.Text);
            int d = Convert.ToInt32(textBox4.Text);
            ITEM t = new ITEM();
            t.pname = b;
            t.Price = c;
            t.ShippingWeight = d;

            komut.Parameters.AddWithValue("@p1", b);
            komut.Parameters.AddWithValue("@p2", comboBox1.Text);
            komut.Parameters.AddWithValue("@p3", d);
            komut.Parameters.AddWithValue("@p4", c);
            komut.Parameters.AddWithValue("@p5", a);
            komut.Parameters.AddWithValue("@p0", dataGridView1.CurrentRow.Cells[0].Value);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Edited");
            kayitlari_getir();

            
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

        private void button2_Click(object sender, EventArgs e)
        {
           
            miktar();

        }
    }
}
