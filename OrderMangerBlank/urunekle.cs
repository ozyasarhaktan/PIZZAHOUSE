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
    public partial class urunekle : Form
    {
        public urunekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=MSI;Initial Catalog=Pizza;Integrated Security=True");
        
        private void Reset()
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || comboBox1.SelectedIndex == -1 || textBox4.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Missing İnformation");
            }
            else
            {
                try
                {




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




                    baglan.Open();
                    SqlCommand komut = new SqlCommand("Insert into Product2(PName,PCat,PWe,PPr,PQu) Values(@PN,@PC,@PW,@PP,@PQ)", baglan);
                    komut.Parameters.AddWithValue("@PN", b);
                    komut.Parameters.AddWithValue("@PC", comboBox1.SelectedItem.ToString());
                    komut.Parameters.AddWithValue("@Pw", d);
                    komut.Parameters.AddWithValue("@PP", c);
                    komut.Parameters.AddWithValue("@PQ", a) ;
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Product Saved");
                    baglan.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}

