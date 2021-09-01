
namespace RSAText
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
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Kết quả giải mã";
            // 
            // tbKetQuaGiaiMa
            // 
            this.tbKetQuaGiaiMa.Location = new System.Drawing.Point(14, 338);
            this.tbKetQuaGiaiMa.Margin = new System.Windows.Forms.Padding(5);
            this.tbKetQuaGiaiMa.Multiline = true;
            this.tbKetQuaGiaiMa.Name = "tbKetQuaGiaiMa";
            this.tbKetQuaGiaiMa.Size = new System.Drawing.Size(372, 72);
            this.tbKetQuaGiaiMa.TabIndex = 38;
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(13, 264);
            this.btGiaiMa.Margin = new System.Windows.Forms.Padding(5);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(133, 34);
            this.btGiaiMa.TabIndex = 37;
            this.btGiaiMa.Text = "Giải mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Dữ liệu mã hóa được";
            // 
            // tbDuLieuMaHoaDuoc
            // 
            this.tbDuLieuMaHoaDuoc.Location = new System.Drawing.Point(14, 182);
            this.tbDuLieuMaHoaDuoc.Margin = new System.Windows.Forms.Padding(5);
            this.tbDuLieuMaHoaDuoc.Multiline = true;
            this.tbDuLieuMaHoaDuoc.Name = "tbDuLieuMaHoaDuoc";
            this.tbDuLieuMaHoaDuoc.Size = new System.Drawing.Size(372, 72);
            this.tbDuLieuMaHoaDuoc.TabIndex = 35;
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(14, 110);
            this.btMaHoa.Margin = new System.Windows.Forms.Padding(5);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(133, 34);
            this.btMaHoa.TabIndex = 34;
            this.btMaHoa.Text = "Mã hóa";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Dữ liệu cần mã hóa";
            // 
            // tbDuLieuCanMaHoa
            // 
            this.tbDuLieuCanMaHoa.Location = new System.Drawing.Point(14, 27);
            this.tbDuLieuCanMaHoa.Margin = new System.Windows.Forms.Padding(5);
            this.tbDuLieuCanMaHoa.Multiline = true;
            this.tbDuLieuCanMaHoa.Name = "tbDuLieuCanMaHoa";
            this.tbDuLieuCanMaHoa.Size = new System.Drawing.Size(372, 72);
            this.tbDuLieuCanMaHoa.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Khóa công khai (Public Key)";
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPublicKey.Location = new System.Drawing.Point(13, 441);
            this.tbPublicKey.Margin = new System.Windows.Forms.Padding(5);
            this.tbPublicKey.Multiline = true;
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.Size = new System.Drawing.Size(372, 78);
            this.tbPublicKey.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 524);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Khóa bí mật (Private Key)";
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPrivateKey.Location = new System.Drawing.Point(13, 542);
            this.tbPrivateKey.Margin = new System.Windows.Forms.Padding(5);
            this.tbPrivateKey.Multiline = true;
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.Size = new System.Drawing.Size(372, 80);
            this.tbPrivateKey.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 639);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrivateKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPublicKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKetQuaGiaiMa);
            this.Controls.Add(this.btGiaiMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDuLieuMaHoaDuoc);
            this.Controls.Add(this.btMaHoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDuLieuCanMaHoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrivateKey;
    }
}

