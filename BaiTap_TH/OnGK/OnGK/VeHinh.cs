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
    public partial class VeHinh : Form
    {
        public VeHinh()
        {
            InitializeComponent();
        }
        public void DrawPolygon(Point[] arr, Graphics g)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(arr);

            SolidBrush sl = new SolidBrush(Color.Aqua);
            g.FillPolygon(sl, arr);
        }
        private void VeHinh_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point middle = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2);

            Point[] arrPoly1 = {new Point(middle.X, middle.Y - 140), new Point(middle.X - 40, middle.Y -70),
            middle, new Point(middle.X + 40, middle.Y - 70)};

            DrawPolygon(arrPoly1, g);

            Point[] arrPoly2 = {middle, new Point(middle.X - 81, middle.Y), new Point(middle.X - 121, middle.Y +71),
            new Point(middle.X - 40, middle.Y + 70)};
            DrawPolygon(arrPoly2, g);

            Point[] arrPoly3 = {middle, new Point(middle.X + 81, middle.Y), new Point(middle.X + 121, middle.Y +71),
            new Point(middle.X + 40, middle.Y + 70)};
            DrawPolygon(arrPoly3, g);

            Font f = new Font("Arial", 30, FontStyle.Bold);
            g.DrawString("MITSUBISH", f, Brushes.Black, middle.X - 125, middle.Y + 90);

        }

        private void VeHinh_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
