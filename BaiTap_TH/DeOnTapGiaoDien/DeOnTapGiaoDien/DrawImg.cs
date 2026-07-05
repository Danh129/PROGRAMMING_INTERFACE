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
    public partial class DrawImg : Form
    {
        public DrawImg()
        {
            InitializeComponent();
        }

        private void DrawImg_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc1 = new Rectangle(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc2 = new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc3 = new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height);

            DrawImage(rc1, e.Graphics);
            DrawText(rc2, e.Graphics);
            DrawPolygon(rc3, e.Graphics);
        }

        private void DrawText(Rectangle rc, Graphics g)
        {
            Font f = new Font("Arial", 48, FontStyle.Bold | FontStyle.Italic);
            LinearGradientBrush br = new LinearGradientBrush(rc, Color.Black, Color.White, 45);
            g.FillRectangle(br, rc);
            LinearGradientBrush lbr = new LinearGradientBrush(new Rectangle(0, 0, 40, 40), Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Center;
            fm.LineAlignment = StringAlignment.Center;
            g.DrawString("HELLO", f, lbr, rc, fm);
        }

        private void DrawImage(Rectangle rc, Graphics g)
        {
            Image img = Image.FromFile(Application.StartupPath + @"\nai.png");
            g.DrawImage(img, rc);

            Font f = new Font("Arial", 36, FontStyle.Bold);
            SolidBrush br = new SolidBrush(Color.FromArgb(50, 255, 255, 0));
            StringFormat fm = new StringFormat();
            fm.LineAlignment = StringAlignment.Far;
            g.DrawString("Anita", f, br, rc, fm);

        }

        private void DrawPolygon(Rectangle rc, Graphics g)
        {
            Point[] arrP = { new Point(rc.Left, rc.Height/4),
            new Point(rc.Left+rc.Width/2,0),
            new Point(rc.Left+rc.Width,rc.Height/4),
            new Point (rc.Left+rc.Width/2,rc.Height)};
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(arrP);
            PathGradientBrush br = new PathGradientBrush(path);
            br.CenterColor = Color.White;
            Color[] arrC = { Color.Red, Color.Yellow, Color.Cyan };
            br.SurroundColors = arrC;
            g.FillPolygon(br, arrP);
        }

        private void DrawImg_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
