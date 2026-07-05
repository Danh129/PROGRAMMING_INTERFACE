namespace DeOnTapGiaoDien
{
    partial class FrmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.picAn = new System.Windows.Forms.PictureBox();
            this.btAn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten dang nhap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mat Khau:";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(294, 90);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(224, 34);
            this.txtTen.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(294, 161);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(224, 34);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dang nhap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDong.Location = new System.Drawing.Point(393, 237);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(153, 45);
            this.btDong.TabIndex = 5;
            this.btDong.Text = "Dong";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // picAn
            // 
            this.picAn.Location = new System.Drawing.Point(576, 173);
            this.picAn.Name = "picAn";
            this.picAn.Size = new System.Drawing.Size(35, 16);
            this.picAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAn.TabIndex = 6;
            this.picAn.TabStop = false;
            this.picAn.Click += new System.EventHandler(this.picAn_Click);
            // 
            // btAn
            // 
            this.btAn.AutoSize = true;
            this.btAn.Location = new System.Drawing.Point(642, 171);
            this.btAn.Name = "btAn";
            this.btAn.Size = new System.Drawing.Size(60, 26);
            this.btAn.TabIndex = 7;
            this.btAn.UseVisualStyleBackColor = true;
            this.btAn.Click += new System.EventHandler(this.btAn_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 352);
            this.Controls.Add(this.btAn);
            this.Controls.Add(this.picAn);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.picAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.PictureBox picAn;
        private System.Windows.Forms.Button btAn;
    }
}