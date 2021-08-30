
namespace MD5Helper
{
    partial class Form2
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
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbMaHoa = new System.Windows.Forms.RadioButton();
            this.rbGiaiMa = new System.Windows.Forms.RadioButton();
            this.tbNoiDung = new System.Windows.Forms.TextBox();
            this.btThucHien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(89, 6);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(271, 23);
            this.tbMatKhau.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mật khẩu";
            // 
            // rbMaHoa
            // 
            this.rbMaHoa.AutoSize = true;
            this.rbMaHoa.Location = new System.Drawing.Point(17, 36);
            this.rbMaHoa.Name = "rbMaHoa";
            this.rbMaHoa.Size = new System.Drawing.Size(73, 21);
            this.rbMaHoa.TabIndex = 36;
            this.rbMaHoa.TabStop = true;
            this.rbMaHoa.Text = "Mã hóa";
            this.rbMaHoa.UseVisualStyleBackColor = true;
            this.rbMaHoa.CheckedChanged += new System.EventHandler(this.rbMaHoa_CheckedChanged);
            // 
            // rbGiaiMa
            // 
            this.rbGiaiMa.AutoSize = true;
            this.rbGiaiMa.Location = new System.Drawing.Point(17, 63);
            this.rbGiaiMa.Name = "rbGiaiMa";
            this.rbGiaiMa.Size = new System.Drawing.Size(74, 21);
            this.rbGiaiMa.TabIndex = 37;
            this.rbGiaiMa.TabStop = true;
            this.rbGiaiMa.Text = "Giải mã";
            this.rbGiaiMa.UseVisualStyleBackColor = true;
            this.rbGiaiMa.CheckedChanged += new System.EventHandler(this.rbGiaiMa_CheckedChanged);
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Location = new System.Drawing.Point(11, 90);
            this.tbNoiDung.Multiline = true;
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.Size = new System.Drawing.Size(625, 105);
            this.tbNoiDung.TabIndex = 38;
            // 
            // btThucHien
            // 
            this.btThucHien.Location = new System.Drawing.Point(11, 201);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(103, 28);
            this.btThucHien.TabIndex = 39;
            this.btThucHien.Text = "Thực hiện";
            this.btThucHien.UseVisualStyleBackColor = true;
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 241);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.rbGiaiMa);
            this.Controls.Add(this.rbMaHoa);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbMaHoa;
        private System.Windows.Forms.RadioButton rbGiaiMa;
        private System.Windows.Forms.TextBox tbNoiDung;
        private System.Windows.Forms.Button btThucHien;
    }
}