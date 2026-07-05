using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace baitapgiaodien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();

            //dlg.Filter = "Text file (*.txt)|*.txt|All file (*.*)|*.*";

            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    textBox1.Text = File.ReadAllText(dlg.FileName);
            //}


            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Image Files|*.jpg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "Text file (*.txt)|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, textBox1.Text);
            }
        }

        private void exitFile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontFormat_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = dlg.Font;
            }
        }

        private void colorFormat_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = dlg.Color;
            }
        }
    }
}
