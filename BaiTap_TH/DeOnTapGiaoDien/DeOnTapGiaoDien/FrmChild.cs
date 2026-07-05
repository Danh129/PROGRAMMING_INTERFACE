using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeOnTapGiaoDien
{
    public partial class FrmChild : Form
    {
        //khai bao anh
        Image image;
        public FrmChild()
        {
            InitializeComponent();
        }

        private void FrmChild_Load(object sender, EventArgs e)
        {
            //LoadImage(Application.StartupPath + @"\mai.png");

            // Đường dẫn đầy đủ đến file ảnh
            string path = Application.StartupPath + @"\nai.png";

            // Kiểm tra xem file có tồn tại thật không trước khi load
            if (System.IO.File.Exists(path))
            {
                LoadImage(path);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file ảnh tại: " + path);
            }
        }

        private void LoadImage(string filename)
        {
            //image = Image.FromFile(filename);
            //picImage.Image = image;

            try
            {
                // Giải phóng ảnh cũ nếu có để tiết kiệm RAM
                if (picImage.Image != null) picImage.Image.Dispose();

                // Load ảnh mới
                picImage.Image = Image.FromFile(filename);

                // Chỉnh ảnh vừa vặn với PictureBox (quan trọng)
                picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load ảnh: " + ex.Message);
            }
        }

        private void menuLoad_Click(object sender, EventArgs e)
        {
            LoadImage(Application.StartupPath + @"\nai.png");
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            picImage.Image = null;
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog op = new SaveFileDialog();
            op.Filter = "JPEG|*.jpg|PNG|*.png|BMP|*.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                if (picImage.Image != null)
                {
                    if (op.FileName.ToLower().EndsWith(".jpg"))
                    {
                        picImage.Image.Save(op.FileName, ImageFormat.Jpeg);
                    }
                    else if (op.FileName.ToLower().EndsWith(".png"))
                    {
                        picImage.Image.Save(op.FileName, ImageFormat.Png);
                    }
                    else
                    {
                        picImage.Image.Save(op.FileName, ImageFormat.Bmp);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có ảnh để lưu!");
                }
            }
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPEG file (*.jpg)|*.jpg|PNG file (*.png)|*.png|BMP file (*.bmp)|*.bmp";

            if (op.ShowDialog() == DialogResult.OK)
            {

                LoadImage(op.FileName);
            }
        }
    }
}
