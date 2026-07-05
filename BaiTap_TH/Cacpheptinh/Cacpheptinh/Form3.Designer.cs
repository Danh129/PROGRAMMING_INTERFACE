namespace Cacpheptinh
{
    partial class Form3
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
            this.lbSo1 = new System.Windows.Forms.Label();
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbSo3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd11 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.btQuay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSo1
            // 
            this.lbSo1.AutoSize = true;
            this.lbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo1.Location = new System.Drawing.Point(127, 76);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(124, 135);
            this.lbSo1.TabIndex = 0;
            this.lbSo1.Text = "0";
            this.lbSo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo2
            // 
            this.lbSo2.AutoSize = true;
            this.lbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo2.Location = new System.Drawing.Point(337, 76);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(124, 135);
            this.lbSo2.TabIndex = 1;
            this.lbSo2.Text = "0";
            this.lbSo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo3
            // 
            this.lbSo3.AutoSize = true;
            this.lbSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo3.Location = new System.Drawing.Point(565, 76);
            this.lbSo3.Name = "lbSo3";
            this.lbSo3.Size = new System.Drawing.Size(124, 135);
            this.lbSo3.TabIndex = 2;
            this.lbSo3.Text = "0";
            this.lbSo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd11);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(150, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rd11
            // 
            this.rd11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd11.AutoSize = true;
            this.rd11.Location = new System.Drawing.Point(314, 90);
            this.rd11.Name = "rd11";
            this.rd11.Size = new System.Drawing.Size(103, 46);
            this.rd11.TabIndex = 1;
            this.rd11.Text = "11-18";
            this.rd11.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd3.AutoSize = true;
            this.rd3.Checked = true;
            this.rd3.Location = new System.Drawing.Point(98, 90);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(86, 46);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.Text = "3-10";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // btQuay
            // 
            this.btQuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btQuay.Location = new System.Drawing.Point(75, 433);
            this.btQuay.Name = "btQuay";
            this.btQuay.Size = new System.Drawing.Size(164, 52);
            this.btQuay.TabIndex = 4;
            this.btQuay.Text = "Quay Số";
            this.btQuay.UseVisualStyleBackColor = true;
            this.btQuay.Click += new System.EventHandler(this.btQuay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Điểm:";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.Red;
            this.lbDiem.Location = new System.Drawing.Point(553, 449);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(32, 36);
            this.lbDiem.TabIndex = 6;
            this.lbDiem.Text = "0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(831, 530);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btQuay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbSo3);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbSo1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbSo3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd11;
        private System.Windows.Forms.Button btQuay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDiem;
    }
}