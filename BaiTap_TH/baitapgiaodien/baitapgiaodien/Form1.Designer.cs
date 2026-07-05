namespace baitapgiaodien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btThemDau = new System.Windows.Forms.Button();
            this.btThemCuoi = new System.Windows.Forms.Button();
            this.btChen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdListBox = new System.Windows.Forms.RadioButton();
            this.rdComboBox = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listColor = new System.Windows.Forms.ListBox();
            this.cbDanhSach = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chuỗi:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(270, 66);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(118, 34);
            this.txtNhap.TabIndex = 1;
            // 
            // btThemDau
            // 
            this.btThemDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemDau.Location = new System.Drawing.Point(50, 155);
            this.btThemDau.Name = "btThemDau";
            this.btThemDau.Size = new System.Drawing.Size(171, 43);
            this.btThemDau.TabIndex = 2;
            this.btThemDau.Text = "thêm vào đầu";
            this.btThemDau.UseVisualStyleBackColor = true;
            this.btThemDau.Click += new System.EventHandler(this.btThemDau_Click);
            // 
            // btThemCuoi
            // 
            this.btThemCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemCuoi.Location = new System.Drawing.Point(270, 158);
            this.btThemCuoi.Name = "btThemCuoi";
            this.btThemCuoi.Size = new System.Drawing.Size(178, 36);
            this.btThemCuoi.TabIndex = 3;
            this.btThemCuoi.Text = "thêm vào cuối";
            this.btThemCuoi.UseVisualStyleBackColor = true;
            this.btThemCuoi.Click += new System.EventHandler(this.btThemCuoi_Click);
            // 
            // btChen
            // 
            this.btChen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChen.Location = new System.Drawing.Point(485, 158);
            this.btChen.Name = "btChen";
            this.btChen.Size = new System.Drawing.Size(136, 40);
            this.btChen.TabIndex = 4;
            this.btChen.Text = "Chèn";
            this.btChen.UseVisualStyleBackColor = true;
            this.btChen.Click += new System.EventHandler(this.btChen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vị Trí:";
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(755, 164);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(100, 34);
            this.txtViTri.TabIndex = 6;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(50, 252);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 39);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.rdComboBox);
            this.groupBox1.Controls.Add(this.rdListBox);
            this.groupBox1.Location = new System.Drawing.Point(296, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn danh sách";
            // 
            // rdListBox
            // 
            this.rdListBox.AutoSize = true;
            this.rdListBox.Location = new System.Drawing.Point(83, 56);
            this.rdListBox.Name = "rdListBox";
            this.rdListBox.Size = new System.Drawing.Size(112, 33);
            this.rdListBox.TabIndex = 0;
            this.rdListBox.TabStop = true;
            this.rdListBox.Text = "ListBox";
            this.rdListBox.UseVisualStyleBackColor = true;
            // 
            // rdComboBox
            // 
            this.rdComboBox.AutoSize = true;
            this.rdComboBox.Location = new System.Drawing.Point(282, 56);
            this.rdComboBox.Name = "rdComboBox";
            this.rdComboBox.Size = new System.Drawing.Size(154, 33);
            this.rdComboBox.TabIndex = 1;
            this.rdComboBox.TabStop = true;
            this.rdComboBox.Text = "ComboBox";
            this.rdComboBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "ListBox cho phép chọn nhiều";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "ComboBox";
            // 
            // listColor
            // 
            this.listColor.FormattingEnabled = true;
            this.listColor.ItemHeight = 29;
            this.listColor.Location = new System.Drawing.Point(124, 460);
            this.listColor.Name = "listColor";
            this.listColor.Size = new System.Drawing.Size(243, 149);
            this.listColor.TabIndex = 11;
            // 
            // cbDanhSach
            // 
            this.cbDanhSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbDanhSach.FormattingEnabled = true;
            this.cbDanhSach.Location = new System.Drawing.Point(517, 460);
            this.cbDanhSach.Name = "cbDanhSach";
            this.cbDanhSach.Size = new System.Drawing.Size(189, 24);
            this.cbDanhSach.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(919, 625);
            this.Controls.Add(this.cbDanhSach);
            this.Controls.Add(this.listColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btChen);
            this.Controls.Add(this.btThemCuoi);
            this.Controls.Add(this.btThemDau);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btThemDau;
        private System.Windows.Forms.Button btThemCuoi;
        private System.Windows.Forms.Button btChen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdComboBox;
        private System.Windows.Forms.RadioButton rdListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listColor;
        private System.Windows.Forms.ComboBox cbDanhSach;
    }
}

