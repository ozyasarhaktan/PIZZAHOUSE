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
    public partial class ordermenu : Form
    {
        public ordermenu()
        {
            InitializeComponent();
        }
        private void FormGetir(Form form)
        {
            panel3.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(form);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            payform pf = new payform();
            FormGetir(pf);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sepetform sf = new sepetform();
            FormGetir(sf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderform of = new orderform();
            FormGetir(of);
        }
    }
}
