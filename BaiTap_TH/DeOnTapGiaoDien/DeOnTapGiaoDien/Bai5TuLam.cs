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
    public partial class Bai5TuLam : Form
    {
        public Bai5TuLam()
        {
            InitializeComponent();
        }

        private void Bai5TuLam_Load(object sender, EventArgs e)
        {

        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            FrmChild f = new FrmChild();
            f.MdiParent = this;
            f.Show();

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuCasCade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
        }
    }
}
