
namespace MD5Helper
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbKetQuaGiaiMa = new System.Windows.Forms.TextBox();
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDuLieuMaHoaDuoc = new System.Windows.Forms.TextBox();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDuLieuCanMaHoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Kết quả giải mã";
            // 
            // tbKetQuaGiaiMa
            // 
            this.tbKetQuaGiaiMa.Location = new System.Drawing.Point(17, 448);
            this.tbKetQuaGiaiMa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbKetQuaGiaiMa.Multiline = true;
            this.tbKetQuaGiaiMa.Name = "tbKetQuaGiaiMa";
            this.tbKetQuaGiaiMa.Size = new System.Drawing.Size(492, 72);
            this.tbKetQuaGiaiMa.TabIndex = 30;
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(16, 359);
            this.btGiaiMa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(133, 34);
            this.btGiaiMa.TabIndex = 29;
            this.btGiaiMa.Text = "Giải mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Dữ liệu mã hóa được";
            // 
            // tbDuLieuMaHoaDuoc
            // 
            this.tbDuLieuMaHoaDuoc.Location = new System.Drawing.Point(17, 277);
            this.tbDuLieuMaHoaDuoc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbDuLieuMaHoaDuoc.Multiline = true;
            this.tbDuLieuMaHoaDuoc.Name = "tbDuLieuMaHoaDuoc";
            this.tbDuLieuMaHoaDuoc.Size = new System.Drawing.Size(492, 72);
            this.tbDuLieuMaHoaDuoc.TabIndex = 27;
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(17, 190);
            this.btMaHoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(133, 34);
            this.btMaHoa.TabIndex = 26;
            this.btMaHoa.Text = "Mã hóa";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dữ liệu cần mã hóa";
            // 
            // tbDuLieuCanMaHoa
            // 
            this.tbDuLieuCanMaHoa.Location = new System.Drawing.Point(17, 107);
            this.tbDuLieuCanMaHoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbDuLieuCanMaHoa.Multiline = true;
            this.tbDuLieuCanMaHoa.Name = "tbDuLieuCanMaHoa";
            this.tbDuLieuCanMaHoa.Size = new System.Drawing.Size(492, 72);
            this.tbDuLieuCanMaHoa.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mật khẩu";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(16, 32);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(493, 23);
            this.tbMatKhau.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 542);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKetQuaGiaiMa);
            this.Controls.Add(this.btGiaiMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDuLieuMaHoaDuoc);
            this.Controls.Add(this.btMaHoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDuLieuCanMaHoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKetQuaGiaiMa;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDuLieuMaHoaDuoc;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDuLieuCanMaHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatKhau;
    }
}

