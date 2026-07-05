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
    public partial class FrmLoad : Form
    {
        Random rand = new Random();
        public FrmLoad()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TangToc = rand.Next(1, 6);

            if(progressBar1.Value + TangToc < 100)
            {
                progressBar1.Value += TangToc;
                lblPercent.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                progressBar1.Value = 100;
                lblPercent.Text = "100% _ Dang khoi dong";
                timer1.Stop();

                FrmThiThu f = new FrmThiThu();
                f.Show();
                this.Hide();
            }
        }
    }
}
