
namespace MD5File
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
            this.rbGiaiMa = new System.Windows.Forms.RadioButton();
            this.rbMaHoa = new System.Windows.Forms.RadioButton();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btThucHien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbGiaiMa
            // 
            this.rbGiaiMa.AutoSize = true;
            this.rbGiaiMa.Location = new System.Drawing.Point(118, 65);
            this.rbGiaiMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGiaiMa.Name = "rbGiaiMa";
            this.rbGiaiMa.Size = new System.Drawing.Size(74, 21);
            this.rbGiaiMa.TabIndex = 41;
            this.rbGiaiMa.TabStop = true;
            this.rbGiaiMa.Text = "Giải mã";
            this.rbGiaiMa.UseVisualStyleBackColor = true;
            this.rbGiaiMa.CheckedChanged += new System.EventHandler(this.rbGiaiMa_CheckedChanged);
            // 
            // rbMaHoa
            // 
            this.rbMaHoa.AutoSize = true;
            this.rbMaHoa.Location = new System.Drawing.Point(22, 65);
            this.rbMaHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMaHoa.Name = "rbMaHoa";
            this.rbMaHoa.Size = new System.Drawing.Size(73, 21);
            this.rbMaHoa.TabIndex = 40;
            this.rbMaHoa.TabStop = true;
            this.rbMaHoa.Text = "Mã hóa";
            this.rbMaHoa.UseVisualStyleBackColor = true;
            this.rbMaHoa.CheckedChanged += new System.EventHandler(this.rbMaHoa_CheckedChanged);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(22, 33);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(360, 23);
            this.tbMatKhau.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Chọn tệp tin";
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(22, 115);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.Size = new System.Drawing.Size(302, 23);
            this.tbDuongDan.TabIndex = 43;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(330, 115);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(52, 23);
            this.btTim.TabIndex = 44;
            this.btTim.Text = "TÌm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btThucHien
            // 
            this.btThucHien.Location = new System.Drawing.Point(118, 154);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(165, 55);
            this.btThucHien.TabIndex = 45;
            this.btThucHien.Text = "Thực hiện";
            this.btThucHien.UseVisualStyleBackColor = true;
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 233);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbGiaiMa);
            this.Controls.Add(this.rbMaHoa);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbGiaiMa;
        private System.Windows.Forms.RadioButton rbMaHoa;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btThucHien;
    }
}

