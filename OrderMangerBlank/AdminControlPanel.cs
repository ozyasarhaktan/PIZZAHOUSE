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
    public partial class AdminControlPanel : Form
    {
        public AdminControlPanel()
        {
            InitializeComponent();
        }
        private void FormGetir(Form form)
        {
            panel2.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form);
            form.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunekle urunekle = new urunekle();
            FormGetir(urunekle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guncelle g = new guncelle();
            FormGetir(g);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musteritakip m = new musteritakip();
            FormGetir(m);
        }
    }
}
