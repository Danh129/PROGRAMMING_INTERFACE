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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThemDau_Click(object sender, EventArgs e)
        {
            string item = txtNhap.Text;
            if (string.IsNullOrEmpty(item)) return;

            if (rdListBox.Checked)
                listColor.Items.Insert(0, item);
            else
                cbDanhSach.Items.Insert(0, item);

            txtNhap.Clear();
        }

        private void btThemCuoi_Click(object sender, EventArgs e)
        {
            string item = txtNhap.Text;
            if (string.IsNullOrEmpty(item)) return;

            if (rdListBox.Checked)
                listColor.Items.Add(item);
            else
                cbDanhSach.Items.Add(item);

            txtNhap.Clear();
        }

        private void btChen_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(txtViTri.Text, out index))
            {
                string item = txtNhap.Text;
                if (rdListBox.Checked && index <= listColor.Items.Count)
                    listColor.Items.Insert(index, item);
                else if (rdComboBox.Checked && index <= cbDanhSach.Items.Count)
                    cbDanhSach.Items.Insert(index, item);
                else
                    MessageBox.Show("Vị trí chèn không hợp lệ!");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (rdListBox.Checked)
            {
                while (listColor.SelectedItems.Count > 0)
                {
                    listColor.Items.Remove(listColor.SelectedItems[0]);
                }
            }
            else
            {
                if (cbDanhSach.SelectedIndex != -1)
                    cbDanhSach.Items.RemoveAt(cbDanhSach.SelectedIndex);
            }
        }
    }
}
