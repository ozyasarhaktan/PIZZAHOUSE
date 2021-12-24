using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMangerBlank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();
                AdminControlPanel ad = new AdminControlPanel();
                ad.Show();
            }
            else
            {
                MessageBox.Show("Yanlış giriş yaptınız.Tekrar deneyiniz.");
                textBox1.Clear();
                textBox2.Clear();



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerlogin customerlogin = new customerlogin();
            customerlogin.Show();
        }
    }
    }

