using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MD5Helper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMaHoa.Checked)
            {
                rbGiaiMa.Checked = false;
                tbNoiDung.Focus();
            }    
        }


        String duongDan = "";
        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbGiaiMa.Checked)
            {
                rbMaHoa.Checked = false;
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "MD5 files (*.mymd5) | *.mymd5";
                if(od.ShowDialog() == DialogResult.OK)
                {
                    duongDan = od.FileName;
                }    
            }    
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            MD5Lib md5 = new MD5Lib(tbMatKhau.Text);

            if (rbMaHoa.Checked)
            {
                byte[] ketQua = md5.MaHoa(Encoding.UTF8.GetBytes(tbNoiDung.Text));
                SaveFileDialog od = new SaveFileDialog();
                od.Filter = "MD5 files (*.mymd5) | *.mymd5";
                if (od.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(od.FileName, ketQua);
                }
                tbNoiDung.Text = "";
            } 
            else
            {
                byte[] noiDungTep = File.ReadAllBytes(duongDan);
                byte[] ketQua = md5.GiaiMa(noiDungTep);
                tbNoiDung.Text = Encoding.UTF8.GetString(ketQua);
            }    

        }
    }
}
