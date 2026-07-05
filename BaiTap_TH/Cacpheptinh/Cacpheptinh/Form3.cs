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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Random Rand = new Random();
        int Diem = 0;
        private void btQuay_Click(object sender, EventArgs e)
        {
            int so1 = Rand.Next(1, 7);
            int so2 = Rand.Next(1, 7);
            int so3 = Rand.Next(1, 7);       
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();
            int tong = so1 + so2 + so3;
            if (rd3.Checked) 
            {
                if (tong <= 10)
                    Diem += 10;
                else
                    Diem -= 10;
            }
            else 
            {
                if (tong <= 10)
                    Diem -= 10;
                else
                    Diem += 10;
            }
            lbDiem.Text = Diem.ToString();

        }
    }
}
