namespace DeOnTapGiaoDien
{
    partial class FrmKhoiDong
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picCua = new System.Windows.Forms.PictureBox();
            this.picBau = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBau)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picCua
            // 
            this.picCua.Image = global::DeOnTapGiaoDien.Properties.Resources.cua;
            this.picCua.Location = new System.Drawing.Point(695, 114);
            this.picCua.Name = "picCua";
            this.picCua.Size = new System.Drawing.Size(149, 148);
            this.picCua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCua.TabIndex = 1;
            this.picCua.TabStop = false;
            // 
            // picBau
            // 
            this.picBau.Image = global::DeOnTapGiaoDien.Properties.Resources.bau;
            this.picBau.Location = new System.Drawing.Point(93, 113);
            this.picBau.Name = "picBau";
            this.picBau.Size = new System.Drawing.Size(151, 149);
            this.picBau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBau.TabIndex = 0;
            this.picBau.TabStop = false;
            // 
            // FrmKhoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 613);
            this.Controls.Add(this.picCua);
            this.Controls.Add(this.picBau);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKhoiDong";
            this.Text = "FrmKhoiDong";
            this.Load += new System.EventHandler(this.FrmKhoiDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBau;
        private System.Windows.Forms.PictureBox picCua;
        private System.Windows.Forms.Timer timer1;
    }
}

