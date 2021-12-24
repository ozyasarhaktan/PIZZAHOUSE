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
    public partial class Authorized : Form
    {
        public Authorized()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MSI;Initial Catalog=Pizza;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }
        Random rastgele = new Random();

        private void Authorized_Load(object sender, EventArgs e)
        {
            string karakter1;
            string[] dizi1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", };
            int sembol1 = rastgele.Next(0, dizi1.Length);
            karakter1 = (dizi1[sembol1]);


            string karakter2;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int sembol2 = rastgele.Next(0, dizi2.Length);
            karakter2 = (dizi2[sembol2]);

            string karakter3;
            string[] dizi3 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            int sembol3 = rastgele.Next(0, dizi3.Length);
            karakter3 = (dizi3[sembol3]);

            string karakter4;
            string[] dizi4 = { "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z", };
            int sembol4 = rastgele.Next(0, dizi4.Length);
            karakter4 = (dizi4[sembol4]);
            label3.Text = karakter1 + karakter2 + karakter3 + karakter4;
        }
       
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label3.Text)
            {
                
             

                MessageBox.Show("PAY COMPLETED ");
                this.Hide();
                Form1 a = new Form1();
                a.Show();

                

            }

            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ.TEKRAR DENEYİNİZ.");
                textBox1.Clear();
            }
        }
    }
}
