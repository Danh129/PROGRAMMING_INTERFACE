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
    public partial class Bai1_C7 : Form
    {
        public Bai1_C7()
        {
            InitializeComponent();
        }

        private void menuDrawImg_Click(object sender, EventArgs e)
        {
            DrawImg f = new DrawImg();
            f.MdiParent = this;
            f.Show();
        }

        private void menuDrawText_Click(object sender, EventArgs e)
        {
            FrmDrawText f = new FrmDrawText();
            f.MdiParent = this;
            f.Show();
        }

        private void menuDrawMouse_Click(object sender, EventArgs e)
        {
            FrmDrawMouse f = new FrmDrawMouse();
            f.MdiParent = this;
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
