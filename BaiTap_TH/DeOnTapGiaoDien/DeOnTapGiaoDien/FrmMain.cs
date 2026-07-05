using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeOnTapGiaoDien
{
    public partial class FrmMain : Form
    {
        //khai bao 
        int tien = 1000;
        Random rd = new Random();
        //anh nen dat trung voi file luu trong bin/debug/img
        string[] hinh = { "bau", "cua", "tom", "ca", "ga", "nai" };
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cbChon.Items.AddRange(hinh);
            cbChon.SelectedIndex = 0;

            lbTienConLai.Text = tien.ToString();
        }

        //Random anh
        private string RandomHinh()
        {
            return hinh[rd.Next(hinh.Length)];
        }

        //Nut quay
        private void btQuay_Click(object sender, EventArgs e)
        {
            int cuoc;

            if(!int.TryParse(txtTienCuoc.Text, out cuoc))
            {
                MessageBox.Show("Nhap tien hop le");
                return;
            }

            if (cuoc % 100 != 0)
            {
                MessageBox.Show("Tien cuoc phai la boi so cua 100");
                return;
            }

            if (cuoc > tien)
            {
                MessageBox.Show("Khong hop le");
                return;
            }

            //Random 3 anh de quyet dinh thang cuoc/ thua cuoc
            string chon = cbChon.Text.ToLower();
            string kq1 = RandomHinh();
            string kq2 = RandomHinh();
            string kq3 = RandomHinh();

            //hien thi hinh anh
            picKQ1.Image = Image.FromFile("img/" + kq1 + ".png");
            picKQ2.Image = Image.FromFile("img/" + kq2 + ".png");
            picKQ3.Image = Image.FromFile("img/" + kq3 + ".png");

            //Dem so lan trung
            int dem = 0;
            if (kq1 == chon) dem++;
            if (kq2 == chon) dem++;
            if (kq3 == chon) dem++;

            //Tinh tien
            if(dem > 0)
            {
                tien += cuoc * dem;
            }
            else
            {
                tien -= cuoc;
            }
            //tien con lai
            lbTienConLai.Text = tien.ToString();


            //Het tien
            if (tien <= 0)
            {
                btQuay.Enabled = false;
                MessageBox.Show("Ban da het tien");
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
