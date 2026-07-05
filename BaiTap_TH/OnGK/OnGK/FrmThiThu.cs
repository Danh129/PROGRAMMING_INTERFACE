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
    public partial class FrmThiThu : Form
    {
        private Image _currentImage;
        public FrmThiThu()
        {
            InitializeComponent();
        }

        public void LoadImage()
        {
            string path = Application.StartupPath + @"\MayTinh.jpg";
            if (System.IO.File.Exists(path))
            {
                _currentImage = Image.FromFile(path);
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            if (_currentImage != null)
            {    
                g.DrawImage(_currentImage, new Rectangle(50, 50, 300, 200));

                g.DrawString("Anh da duoc nap thanh cong!", this.Font, Brushes.White, 10, 10);
            }
            else
            {
                g.Clear(this.BackColor);
                g.DrawString("Vui long chon menu Open de nap anh", this.Font, Brushes.Gray, 10, 10);
            }
        }

        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg; *.png;*.bmp";
            if(op.ShowDialog() == DialogResult.OK)
            {
                if (_currentImage != null)
                    _currentImage.Dispose();
                _currentImage = Image.FromFile(op.FileName);
                this.Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_currentImage == null)
            {
                MessageBox.Show("Khong co anh de luu");
                return;
            }

            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "JPEG|*.jpg|PNG|*.png|BMP|*.bmp";

            if(sv.ShowDialog() == DialogResult.OK)
            {
                _currentImage.Save(sv.FileName);
                MessageBox.Show("Luu thanh cong");
            }
        }

        private void changeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = c.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban co muon thoat?", "Thong Bao",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
            if(kq == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
