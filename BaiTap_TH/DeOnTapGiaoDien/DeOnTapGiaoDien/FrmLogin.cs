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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTen.Text == "admin" && txtMatKhau.Text == "12345")
            {
                MessageBox.Show("Dang nhap thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Hide();
                TestForm f = new TestForm();
                f.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picAn_Click(object sender, EventArgs e)
        {
            //    // Nếu mật khẩu đang bị ẩn (đang dùng ký tự hệ thống)
            //    if (txtMatKhau.UseSystemPasswordChar == true)
            //    {
            //        txtMatKhau.UseSystemPasswordChar = false; // Hiện mật khẩu ra chữ thường
            //        picAn.Text = "Ẩn"; // Đổi chữ trên nút thành "Ẩn" (hoặc đổi sang icon mắt nhắm)
            //    }
            //    else
            //    {
            //        txtMatKhau.UseSystemPasswordChar = true;  // Ẩn mật khẩu lại thành dấu chấm
            //        picAn.Text = "Xem"; // Đổi chữ trên nút thành "Xem" (hoặc đổi sang icon mắt mở)
            //    }
        }

        private void btAn_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                txtMatKhau.UseSystemPasswordChar = false; // Hiện mật khẩu ra chữ thường
                btAn.Text = "Ẩn"; // Đổi chữ trên nút thành "Ẩn" (hoặc đổi sang icon mắt nhắm)
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;  // Ẩn mật khẩu lại thành dấu chấm
                btAn.Text = "Xem"; // Đổi chữ trên nút thành "Xem" (hoặc đổi sang icon mắt mở)
            }
        }
    }
}
