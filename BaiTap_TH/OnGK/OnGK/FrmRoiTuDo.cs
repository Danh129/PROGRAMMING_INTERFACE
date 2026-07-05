using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnGK
{
    public partial class FrmRoiTuDo : Form
    {
        int vantoc = 0;
        int giatoc = 2;
        public FrmRoiTuDo()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vantoc += giatoc;
            pictureBox1.Top += vantoc;

            int matdat = this.Height - 150;
            if(pictureBox1.Top > matdat)
            {
                pictureBox1.Top = matdat;
                timer1.Stop();

                FrmMain f = new FrmMain();
                f.Show();
                this.Hide();
            }
        }
    }
}
