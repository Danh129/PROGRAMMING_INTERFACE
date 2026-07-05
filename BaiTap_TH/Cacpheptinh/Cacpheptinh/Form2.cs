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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtSo1.Text);
                double b = double.Parse(txtSo2.Text);
                double kq = 0;

                if (rdCong.Checked)
                    kq = a + b;

                else if (rdTru.Checked)
                    kq = a - b;

                else if (rdNhan.Checked)
                    kq = a * b;

                else if (rdChia.Checked)
                    kq = a / b;

                else if (rdChiaDu.Checked)
                    kq = a % b;

                txtkq.Text = kq.ToString();
            }
            catch(FormatException)
            {
                txtkq.Text = "ban phai nhap 2 so";
            }
            catch(DivideByZeroException ex)
            {
                txtkq.Text = ex.Message;
            }
            catch (OverflowException)
            {
                txtkq.Text = "khong the xu li";
            }
        }
    }
}
