using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Cacpheptinh
{
    public partial class Form4 : Form
    {
        Random rand = new Random();
        string[] toantu = { "+", "-", "x", ":" };
        int vitri = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            int so1, so2;
            do
            {
                so1 = rand.Next(10);
                so2 = rand.Next(10);
                vitri = rand.Next(4);
            } while (so2 == 0 && vitri == 3);

            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbToanTu.Text = toantu[vitri];

            txtDoan.Text = "";
            lbKetQua.Text = "";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            int ketqua = 0;
            switch (vitri)
            {
                case 0:
                    ketqua = int.Parse(lbSo1.Text) + int.Parse(lbSo2.Text);
                    break;
                case 1:
                    ketqua = int.Parse(lbSo1.Text) - int.Parse(lbSo2.Text);
                    break;
                case 2:
                    ketqua = int.Parse(lbSo1.Text) * int.Parse(lbSo2.Text);
                    break;
                case 3:
                    ketqua = int.Parse(lbSo1.Text) / int.Parse(lbSo2.Text);
                    break;
            }
            try
            {
                int doan = int.Parse(txtDoan.Text);
                if (doan == ketqua)
                    lbKetQua.Text = "Đúng rồi!";
                else
                    lbKetQua.Text =
                    "Sai rồi! Kết quả là " + ketqua.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập số!");
            }
        }

        private void btDau_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text != "") return;
            txtDoan.Text = "-";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text == "") return;
            txtDoan.Text =
            txtDoan.Text.Substring(0, txtDoan.Text.Length - 1);
        }
    }
}
