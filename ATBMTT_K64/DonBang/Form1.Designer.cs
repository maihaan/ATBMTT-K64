﻿
namespace DonBang
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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kết quả giải mã";
            // 
            // tbKetQuaGiaiMa
            // 
            this.tbKetQuaGiaiMa.Location = new System.Drawing.Point(13, 445);
            this.tbKetQuaGiaiMa.Margin = new System.Windows.Forms.Padding(4);
            this.tbKetQuaGiaiMa.Multiline = true;
            this.tbKetQuaGiaiMa.Name = "tbKetQuaGiaiMa";
            this.tbKetQuaGiaiMa.Size = new System.Drawing.Size(564, 121);
            this.tbKetQuaGiaiMa.TabIndex = 14;
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(13, 372);
            this.btGiaiMa.Margin = new System.Windows.Forms.Padding(4);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(100, 28);
            this.btGiaiMa.TabIndex = 13;
            this.btGiaiMa.Text = "Giải mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dữ liệu mã hóa được";
            // 
            // tbDuLieuMaHoaDuoc
            // 
            this.tbDuLieuMaHoaDuoc.Location = new System.Drawing.Point(13, 242);
            this.tbDuLieuMaHoaDuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbDuLieuMaHoaDuoc.Multiline = true;
            this.tbDuLieuMaHoaDuoc.Name = "tbDuLieuMaHoaDuoc";
            this.tbDuLieuMaHoaDuoc.Size = new System.Drawing.Size(564, 121);
            this.tbDuLieuMaHoaDuoc.TabIndex = 11;
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(13, 167);
            this.btMaHoa.Margin = new System.Windows.Forms.Padding(4);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(100, 28);
            this.btMaHoa.TabIndex = 10;
            this.btMaHoa.Text = "Mã hóa";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dữ liệu cần mã hóa";
            // 
            // tbDuLieuCanMaHoa
            // 
            this.tbDuLieuCanMaHoa.Location = new System.Drawing.Point(13, 36);
            this.tbDuLieuCanMaHoa.Margin = new System.Windows.Forms.Padding(4);
            this.tbDuLieuCanMaHoa.Multiline = true;
            this.tbDuLieuCanMaHoa.Name = "tbDuLieuCanMaHoa";
            this.tbDuLieuCanMaHoa.Size = new System.Drawing.Size(564, 121);
            this.tbDuLieuCanMaHoa.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 581);
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
    }
}

