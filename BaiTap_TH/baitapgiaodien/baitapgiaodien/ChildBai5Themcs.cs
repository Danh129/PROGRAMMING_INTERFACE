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

//Bai kh dung picture box
namespace baitapgiaodien
{
    public partial class ChildBai5Themcs : Form
    {
        // Biến lưu trữ ảnh trong bộ nhớ (thay thế cho PictureBox.Image)
        private Image _currentImage;
        public ChildBai5Themcs()
        {
            InitializeComponent();
            // Bật DoubleBuffered để khi vẽ hoặc co giãn Form ảnh không bị nháy trắng
            this.DoubleBuffered = true;
        }

        // Thêm hàm này vào FrmChild
        public void LoadDefaultImage()
        {
            // Đường dẫn đến file ảnh bạn muốn hiện mặc định
            string path = Application.StartupPath + @"\nai.png";

            if (System.IO.File.Exists(path))
            {
                _currentImage = Image.FromFile(path);
                this.Invalidate(); // Ép Form con phải chạy OnPaint để vẽ hình này lên
            }
        }

        // --- PHẦN QUAN TRỌNG: VẼ TAY GDI+ ---
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); // Gọi hàm vẽ nền của hệ thống

            if (_currentImage != null)
            {
                Graphics g = e.Graphics;

                // Vẽ ảnh phủ kín diện tích bên trong Form (ClientSize)
                // Lệnh này thay thế hoàn toàn cho PictureBox
                g.DrawImage(_currentImage, new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            }
            else
            {
                // Nếu chưa có ảnh, vẽ dòng chữ hướng dẫn
                e.Graphics.DrawString("Vui lòng chọn Menu Open để nạp ảnh", this.Font, Brushes.Gray, 10, 10);
            }
        }

        // Khi người dùng dùng chuột kéo giãn Form, ảnh phải được vẽ lại cho vừa kích thước mới
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Kích hoạt chạy lại OnPaint
        }


        // --- CÁC SỰ KIỆN MENU ---
        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.png;*.bmp";

            if (op.ShowDialog() == DialogResult.OK)
            {
                // Giải phóng bộ nhớ ảnh cũ nếu có
                if (_currentImage != null) _currentImage.Dispose();

                // Nạp ảnh mới và yêu cầu vẽ lại Form
                _currentImage = Image.FromFile(op.FileName);
                this.Invalidate();
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (_currentImage == null)
            {
                MessageBox.Show("Không có hình ảnh để lưu!");
                return;
            }

            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "JPEG|*.jpg|PNG|*.png|BMP|*.bmp";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                _currentImage.Save(sv.FileName);
                MessageBox.Show("Lưu thành công!");
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            if (_currentImage != null)
            {
                _currentImage.Dispose();
                _currentImage = null;
                this.Invalidate(); // Vẽ lại Form trắng
            }
        }
    }
}
