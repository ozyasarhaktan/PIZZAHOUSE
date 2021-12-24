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
    public partial class sepetform : Form
    {
        public sepetform()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MSI;Initial Catalog=Pizza;Integrated Security=True");
        ORDER_DETAIL o = new ORDER_DETAIL();
        public void kayıtsil()
        {
          
                baglan.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Sepet1 ",baglan);
                komut.ExecuteNonQuery();
                baglan.Close();

                    

            
                
        }
        public void kayitlari_getir()
        {
            baglan.Open();
            string getir = "Select *From Sepet1 Order By PId";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
            baglan.Close();


        }

        int j;
        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            ORDER tax = new ORDER();
            tax.calcTax();
            r = tax.calcTax();

            baglan.Open();
            SqlDataAdapter rdr = new SqlDataAdapter("select *from Sepet1", baglan);
           
            int satirSayisi = dataGridView2.Rows.Count;
            int sepetToplam = 0, sepeteEklenecekTutar;
            for (int i = 0; i < satirSayisi; i++)
            {
                int a = Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value);
                int b = Convert.ToInt32(dataGridView2.Rows[i].Cells[5].Value);
                sepeteEklenecekTutar = (a+r) * (b);
                sepetToplam += sepeteEklenecekTutar;
            }
            j = sepetToplam;
        

            baglan.Close();
            label2.Text = j.ToString();
            MessageBox.Show("sepet:"+j.ToString());
            kayıtsil();
            kayitlari_getir();
                


            payform p = new payform();
            p.label14.Text = label2.Text;
            p.label14.Text = label2.Text;
            p.ShowDialog();
                

        }
        
        private void sepetform_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pizzaDataSet10.Sepet1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepet1TableAdapter.Fill(this.pizzaDataSet10.Sepet1);

        }
    }
}
