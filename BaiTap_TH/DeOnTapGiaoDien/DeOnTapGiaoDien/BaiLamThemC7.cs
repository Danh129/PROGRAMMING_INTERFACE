using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeOnTapGiaoDien
{
    public partial class BaiLamThemC7 : Form
    {
        int mon, tue, wed, thu, fri;

        private void btGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                mon = int.Parse(txtMon.Text);
                tue = int.Parse(txtTue.Text);
                wed = int.Parse(txtWed.Text);
                thu = int.Parse(txtThurs.Text);
                fri = int.Parse(txtFri.Text);

                pnVe.Invalidate(); // vẽ lại
            }
            catch
            {
                MessageBox.Show("Nhập số hợp lệ!");
            }
        }

        public BaiLamThemC7()
        {
            InitializeComponent();
        }

        private void pnVe_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int[] data = { mon, tue, wed, thu, fri };
            Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Cyan };

            int x = 50;
            int width = 50;

            for (int i = 0; i < data.Length; i++)
            {
                int height = data[i] / 100; // scale cho vừa

                g.FillRectangle(new SolidBrush(colors[i]),
                    x, pnVe.Height - height - 20,
                    width, height);

                x += 80;
            }
        }
    }
}
