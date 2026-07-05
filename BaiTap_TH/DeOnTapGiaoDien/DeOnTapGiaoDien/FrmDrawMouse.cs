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
    public partial class FrmDrawMouse : Form
    {
        Color color;
        int pentWidth;
        Point pOld;
        Bitmap bmp;
        public FrmDrawMouse()
        {
            InitializeComponent();
        }

        private void FrmDrawMouse_Load(object sender, EventArgs e)
        {

            color = Color.Red;
            pentWidth = 1;
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void FrmDrawMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(color, pentWidth);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate();
            }
        }

        private void FrmDrawMouse_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void FrmDrawMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.R: color = Color.Red; break;
                case Keys.G: color = Color.Green; break;
                case Keys.B: color = Color.Blue; break;
                case Keys.Up: pentWidth++; break;
                case Keys.Down: pentWidth--; break;
            }
            return false;
        }
    }
}
