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
    public partial class Form6 : Form
    {
        int[] arr;
        Random rand = new Random();
        public Form6()
        {
            InitializeComponent();
        }

        private void btTaoMang_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoPT.Text);
            arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = rand.Next(100);

            txtMangKhoiTao.Text = string.Join(" ", arr);
        }

        private void btSapXep_Click(object sender, EventArgs e)
        {
            //Sap xep tang dan
            int[] tang = (int[])arr.Clone();
            Array.Sort(tang);

            //Sap xep giam dan
            int[] giam = (int[])arr.Clone();
            Array.Sort(giam);
            Array.Reverse(giam);

            
            txtMangTang.Text = string.Join(" ", tang);
            txtMangGiam.Text = string.Join(" ", giam);

            // đảo mảng
            int[] dao = (int[])arr.Clone();
            Array.Reverse(dao);
            txtMangDao.Text = string.Join(" ", dao);

            // chẵn tăng - lẻ giảm
            var chan = arr.Where(x => x % 2 == 0).OrderBy(x => x);
            var le = arr.Where(x => x % 2 != 0).OrderByDescending(x => x);

            txtMangChanLe.Text = string.Join(" ", chan.Concat(le));
        }
    }
}
