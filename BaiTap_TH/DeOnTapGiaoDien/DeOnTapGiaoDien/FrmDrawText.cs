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
    public partial class FrmDrawText : Form
    {
        public FrmDrawText()
        {
            InitializeComponent();
        }

        private void FrmDrawText_Paint(object sender, PaintEventArgs e)
        {
            Font f = new Font("Arial", 36, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far;
            format.LineAlignment = StringAlignment.Near;
            e.Graphics.DrawString("HELLO", f, Brushes.Green, ClientRectangle, format);

            TextureBrush tbr = new TextureBrush(Image.FromFile(Application.StartupPath + @"\nai.png"));
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("HELLO", f, tbr, ClientRectangle, format);

            HatchBrush hbr = new HatchBrush(HatchStyle.DarkHorizontal, Color.Orange, Color.Yellow);
            format.FormatFlags = StringFormatFlags.DirectionVertical;
            format.LineAlignment = StringAlignment.Near;
            format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("HELLO", f, hbr, ClientRectangle, format);

            LinearGradientBrush lbr = new LinearGradientBrush(new Rectangle(50, 50, 10, 10), Color.Blue, Color.White, 45);
            format.FormatFlags = StringFormatFlags.DirectionVertical;
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("HELLO", f, lbr, ClientRectangle, format);

        }

        private void FrmDrawText_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
