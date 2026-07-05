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
    public partial class FrmKhoiDong : Form
    {
        public FrmKhoiDong()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //di chuyen
            picBau.Left += 3;
            picCua.Left -= 3;

            //ktra cham nhau
            if(picBau.Right >= picCua.Left)
            {
                //khi cham no dung va qua form 2
                timer1.Stop();

                FrmMain f = new FrmMain();
                f.Show();
                this.Hide();
                
            }
        }

        //phai co nay no moi chay de giao nhau
        private void FrmKhoiDong_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
