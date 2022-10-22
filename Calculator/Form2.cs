using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculation c = new Calculation(a,b);
            int kq = c.Execute("+");
            txtKQ.Text = kq.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculation c = new Calculation(a, b);
            int kq = c.Execute("-");
            txtKQ.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculation c = new Calculation(a, b);
            int kq = c.Execute("*");
            txtKQ.Text = kq.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculation c = new Calculation(a, b);
            int kq = c.Execute("/");
            txtKQ.Text = kq.ToString();
        }
    }
}
