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
    public partial class Form5 : Form
    {
        string original = " Khoa công nghệ thông tin, Đại Học Mở Tp.HCM ";
        public Form5()
        {
            InitializeComponent();
        }

        private void btChen_Click(object sender, EventArgs e)
        {
            txtSo1.Text = txtSo1.Text.Insert(int.Parse(txtViTri.Text), txtSo2.Text);
        }

        private void btThayThe_Click(object sender, EventArgs e)
        {
            txtSo1.Text = txtSo1.Text.Replace(txtSo2.Text, txtSo3.Text);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int pos = txtSo1.Text.IndexOf(txtSo2.Text);
            if (pos >= 0)
                txtSo1.Text = txtSo1.Text.Remove(pos, txtSo2.Text.Length);
        }

        private void btDao_Click(object sender, EventArgs e)
        {
            string[] words = txtSo1.Text.Split(' ');
            Array.Reverse(words);
            txtSo1.Text = string.Join(" ", words);
        }

        private void btChuanHoa_Click(object sender, EventArgs e)
        {
            string[] words = txtSo1.Text.Trim().ToLower().Split(' ');
            string result = "";

            foreach (string w in words)
            {
                if (w != "")
                    result += char.ToUpper(w[0]) + w.Substring(1) + " ";
            }

            txtSo1.Text = result.Trim();
        }

        private void btKhoiPhuc_Click(object sender, EventArgs e)
        {
            txtSo1.Text = original;
        }

        private void btLayChuoi_Click(object sender, EventArgs e)
        {
            try
            {
                int start = int.Parse(txtFrom.Text);
                int length = int.Parse(txtLength.Text);

                txtSo1.Text = txtSo1.Text.Substring(start, length);
            }
            catch
            {
                MessageBox.Show("Lỗi vị trí!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            string s = lbTitle.Text;
            //Lay tu vi tri 1 den het + vi tri 0
            s = s.Substring(1) + s[0];
            lbTitle.Text = s;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
