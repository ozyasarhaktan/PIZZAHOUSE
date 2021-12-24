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
    public partial class payform : Form
    {
        public payform()
        {
            InitializeComponent();
        }
        sepetform sepet = new sepetform();
        
            

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel_kart.Visible = true;
            panel_nkt.Visible = false;
            panel_chk.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            panel_nkt.Visible = true;
            panel_kart.Visible = false;
            panel_chk.Visible = false;
            panel_nkt.Visible = true;
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            panel_nkt.Visible = false;
            panel_chk.Visible = true;
            panel_kart.Visible = false;
            panel2.Visible = false;
            panel1.Visible = false;
            panel3.Visible = true;
        }

        private void payform_Load(object sender, EventArgs e)
        {
          
            panel_chk.Hide();
            panel_nkt.Hide();
            panel_kart.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_kart.Visible = true;
            panel_nkt.Visible = true;
            panel_chk.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CREDIT k = new CREDIT();
            textBox1.Text = k.number.ToString();
            k.type= (radioButton1.Text == "") ? radioButton2.Text : radioButton1.Text;

            textBox2.Text = k.expDate.ToString();

            this.Hide();
            Authorized a = new Authorized();
            a.Show();

               
               
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CASH n = new CASH();
            label6.Text = label14.Text;
            this.Hide();
            Authorized a = new Authorized();
            a.Show();

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CHECK c = new CHECK();
            textBox4.Text=c.name;
            textBox3.Text = c.bankID.ToString(); ;
            this.Hide();
            Authorized a = new Authorized();
            a.Show();

        }
    }
}
