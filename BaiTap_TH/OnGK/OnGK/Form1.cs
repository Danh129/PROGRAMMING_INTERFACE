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

namespace OnGK
{
    public partial class Form1 : Form
    {
        Image img;
        int xLeft = 20;
        int xRight;
        int w = 120;
        int h = 80;
        public Form1()
        {
            InitializeComponent();
            img = Image.FromFile(Application.StartupPath + @"\MayTinh.jpg");
            xRight = this.ClientSize.Width - w - 20;
            timer1.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xLeft += 5;
            xRight -= 5;

            this.Invalidate();

            Rectangle r1 = new Rectangle(xLeft, 130, w, h);
            Rectangle r2 = new Rectangle(xRight, 130, w, h);

            if (r1.IntersectsWith(r2))
            {
                timer1.Stop();
                this.Hide();

                FrmMain f = new FrmMain();
                f.Show();
            }

            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //To nen tuyen tinh
            Rectangle r = this.ClientRectangle;

            LinearGradientBrush lb = new LinearGradientBrush(r, Color.Yellow, Color.Red, 90);
            g.FillRectangle(lb, r);

            //Ve chu
            Font f = new Font("Arial", 30, FontStyle.Bold);
            SolidBrush br = new SolidBrush(Color.Blue);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Center;
            g.DrawString("2451050005_LeThanhDanh", f, br, this.Width / 2, 10, fm);

            //Ve hinh ben trai
            g.DrawImage(img, xLeft, 130, w, h);

            //Ve hinh ben phai
            g.DrawImage(img, xRight, 130, w, h);
        }
    }
}
