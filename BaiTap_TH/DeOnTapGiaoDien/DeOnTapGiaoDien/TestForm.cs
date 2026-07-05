using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeOnTapGiaoDien
{
    public partial class TestForm : Form
    {
        // Ảnh
        Image img;

        // Tọa độ hình bên trái
        int xLeft = 20;

        // Tọa độ hình bên phải
        int xRight;

        // Kích thước hình
        int w = 120;
        int h = 80;
        public TestForm()
        {
            InitializeComponent();

            img = Image.FromFile(Application.StartupPath + @"\nai.png");
            xRight = this.ClientSize.Width - w - 20;

            timer1.Start();
            this.Paint += TestForm_Paint;
        }

        private void TestForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle rc = this.ClientRectangle;

            LinearGradientBrush lbr =
                new LinearGradientBrush(
                    rc,
                    Color.Yellow,
                    Color.Red,
                    90);

            g.FillRectangle(lbr, rc);
            Font f = new Font("Arial", 28, FontStyle.Bold);
            SolidBrush br = new SolidBrush(Color.Blue);

            StringFormat fm = new StringFormat();

            // Canh giữa ngang
            fm.Alignment = StringAlignment.Center;

            // Vẽ chữ
            g.DrawString( "12345 - Nguyễn Văn A", f, br, this.Width / 2, 10, fm);
            g.DrawImage(img, xLeft, 130, w, h);

            g.DrawImage(img, xRight, 130, w, h);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Hình trái sang phải
            xLeft += 5;

            // Hình phải sang trái
            xRight -= 5;

            this.Invalidate();

            Rectangle r1 = new Rectangle(xLeft, 130, w, h);
            Rectangle r2 = new Rectangle(xRight, 130, w, h);

            if (r1.IntersectsWith(r2))
            {
                // Dừng timer
                timer1.Stop();

                // Ẩn form hiện tại
                this.Hide();

                // Mở form chính
                Bai1_C7 f = new Bai1_C7();
                f.Show();
            }
        }
    }
}
