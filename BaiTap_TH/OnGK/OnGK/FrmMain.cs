using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnGK
{
    public partial class FrmMain : Form
    {
        bool chay = false;
        int x = 100;
        int y = 100;
        int dx = 5, dy = 5;

        Image AnhHienTai = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void insertImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Image Files(*.jpg, *.png, *.jpeg, *.bmp)|*.jpg;*.png;*.jpeg;*.bmp";
            ofd.Title = "Chon cac hinh anh";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string ThuMuc = Path.Combine(Application.StartupPath, "Hinh");

                if (!Directory.Exists(ThuMuc))
                {
                    Directory.CreateDirectory(ThuMuc);
                }

                foreach(string file in ofd.FileNames)
                {
                    string tenFile = Path.GetFileName(file);

                    string fileDich = Path.Combine(ThuMuc, tenFile);

                    try
                    {
                        File.Copy(file, fileDich, true);

                        if (!listBox1.Items.Contains(tenFile))
                        {
                            listBox1.Items.Add(tenFile);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Loi", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Thanh Cong!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.S:
                    chay = !chay;
                    timer1.Enabled = chay;
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void deleteImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một file ảnh để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult m = MessageBox.Show($"Ban co muon xoa file {listBox1.SelectedItems.Count} khong?", "Xac Nhan xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(m == DialogResult.Yes)
            {
                if (AnhHienTai != null)
                {
                    AnhHienTai.Dispose();
                    AnhHienTai = null;
                }
                panel1.Invalidate();

                List<string> dsXoa = new List<string>();
                foreach (var item in listBox1.SelectedItems)
                {
                    dsXoa.Add(item.ToString());
                }

                foreach (string file in dsXoa)
                {
                    string duongDanAnh = Path.Combine(Application.StartupPath, "Hinh", file);

                    try
                    {
                        if (File.Exists(duongDanAnh))
                        {
                            File.Delete(duongDanAnh);
                        }
                        listBox1.Items.Remove(file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Khong the xoa {file}", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                MessageBox.Show("Xoa thanh cong!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Exit?", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(AnhHienTai != null)
            {
                e.Graphics.DrawImage(AnhHienTai, x, y, 100, 100);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string tenFile = listBox1.SelectedItem.ToString();
                String duongDan = Path.Combine(Application.StartupPath, "Hinh",tenFile);

                if (File.Exists(duongDan))
                {
                    if (AnhHienTai != null)
                    {
                        AnhHienTai.Dispose();
                    }

                    AnhHienTai = Image.FromFile(duongDan);
                    panel1.Invalidate();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += dx;
            y += dy;
            //Ra khoi form la huong doi xung
            if (x > this.ClientSize.Width)
                x = -100;
            if (x < -100)
                x = this.ClientSize.Width;
            if (y > this.ClientSize.Height)
                y = -100;
            if (y < -100)
                y = this.ClientSize.Height;

            //Anh muot
            panel1.Invalidate();
        }
    }
}
