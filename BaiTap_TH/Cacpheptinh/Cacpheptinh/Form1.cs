using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacpheptinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            int kq = a + b;
            lbketqua.Text = kq.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            int kq = a - b;
            lbketqua.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            double kq = a * b;

            lbketqua.Text = kq.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            if (b != 0)
                lbketqua.Text = String.Format("{0:0.##}", (double)a / b);
            else
                lbketqua.Text = "khong hop le";
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
