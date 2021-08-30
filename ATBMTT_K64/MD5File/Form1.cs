using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MD5File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbMaHoa.Checked = true;
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMaHoa.Checked)
            {
                rbGiaiMa.Checked = false;
            }    
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked)
                rbMaHoa.Checked = false;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (rbMaHoa.Checked)
                od.Filter = "Tất cả các loại tệp tin (*.*) | *.*";
            else
                od.Filter = "Tệp tin mã hóa MD5 (*.mymd5) | *.mymd5";
            if (od.ShowDialog() == DialogResult.OK)
                tbDuongDan.Text = od.FileName;
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            MD5Lib md5 = new MD5Lib(tbMatKhau.Text);

            if(rbMaHoa.Checked)
            {
                byte[] noiDungTep = File.ReadAllBytes(tbDuongDan.Text);
                
                String dinhDangTep = Path.GetExtension(tbDuongDan.Text);
                byte chieuDaiDinhDang = (byte)dinhDangTep.Length;
                byte[] dinhDangTepByte = Encoding.UTF8.GetBytes(dinhDangTep);
                byte[] duLieu = new byte[1 + dinhDangTepByte.Length + noiDungTep.Length];
                duLieu[0] = chieuDaiDinhDang;
                for (int i = 0; i < dinhDangTepByte.Length; i++)
                    duLieu[i + 1] = dinhDangTepByte[i];
                for (int i = 0; i < noiDungTep.Length; i++)
                    duLieu[i + 1 + dinhDangTepByte.Length] = noiDungTep[i];

                byte[] ketQua = md5.MaHoa(duLieu);

                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Tệp tin mã hóa MD5 (*.mymd5) | *.mymd5";
                if(sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, ketQua);
                }    
            }
            else
            {
                byte[] duLieu1 = File.ReadAllBytes(tbDuongDan.Text);
                byte[] duLieu = md5.GiaiMa(duLieu1);

                int chieuDaiPhanDinhDang = duLieu[0];
                byte[] dinhDangTepByte = new byte[chieuDaiPhanDinhDang];
                for (int i = 0; i < dinhDangTepByte.Length; i++)
                    dinhDangTepByte[i] = duLieu[i + 1];
                String dinhDangTep = Encoding.UTF8.GetString(dinhDangTepByte);
                byte[] noiDungTep = new byte[duLieu.Length - 1 - dinhDangTepByte.Length];
                for (int i = 0; i < noiDungTep.Length; i++)
                    noiDungTep[i] = duLieu[i + 1 + dinhDangTepByte.Length];
                
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Tệp tin (*" + dinhDangTep + ") | *" + dinhDangTep;
                if(sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, noiDungTep);
                }    
            }    
        }
    }
}
