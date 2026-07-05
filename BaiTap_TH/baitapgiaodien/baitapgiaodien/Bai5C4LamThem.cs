using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapgiaodien
{
    public partial class Bai5C4LamThem : Form
    {
        public Bai5C4LamThem()
        {
            InitializeComponent();
            // Đảm bảo Form này là Form cha (MDI)
            this.IsMdiContainer = true;
            this.Text = "Chương trình xem ảnh - Vẽ bằng GDI+";
        }

        private void Bai5C4LamThem_Load(object sender, EventArgs e)
        {

        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            // Khởi tạo Form con (Form này đã được viết code vẽ tay OnPaint)
            ChildBai5Themcs f = new ChildBai5Themcs();

            // Chỉ định Form hiện tại là cha của Form f
            f.MdiParent = this;

            // Đặt tiêu đề để phân biệt các cửa sổ
            f.Text = "Cửa sổ " + (MdiChildren.Length);

            // GỌI DÒNG NÀY: Để nạp ảnh vào biến _currentImage trước khi hiện Form
            f.LoadDefaultImage();

            // Hiển thị
            f.Show();
        }
        //-----MENU------
        //CHUC NĂNG CODE HOAN TOAN GIONG NHAU CẢ PICTURE BOX VÀ VẼ TAY

        private void menuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close(); // Khi Form con đóng, bộ nhớ ảnh trong nó sẽ được giải phóng
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
