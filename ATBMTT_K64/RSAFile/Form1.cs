using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RSAFile
{
    public partial class Form1 : Form
    {
        RSAHelper rsa = new RSAHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Luu khoa cong khai
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "Lưu khóa RSA công khai";
            sd.Filter = "RSA Public Key (*.rsac) | *.rsac";
            if(sd.ShowDialog() == DialogResult.OK)
            {
                String duongDan = sd.FileName;
                String khoaCongKhai = rsa.XuatKhoaChung();
                File.WriteAllText(duongDan, khoaCongKhai);
            }

            // Luu khoa rieng
            SaveFileDialog sd1 = new SaveFileDialog();
            sd1.Title = "Lưu khóa RSA riêng";
            sd1.Filter = "RSA Private Key (*.rsar) | *.rsar";
            if (sd1.ShowDialog() == DialogResult.OK)
            {
                String duongDan = sd1.FileName;
                String khoaRieng = rsa.XuatKhoaRieng();
                File.WriteAllText(duongDan, khoaRieng);
            }


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
            if(rbGiaiMa.Checked)
            {
                rbMaHoa.Checked = false;
            }    
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            // Ma hoa tep tin
            if(rbMaHoa.Checked)
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Title = "Chọn tệp tin cần mã hóa";
                od.Multiselect = false;
                od.Filter = "All files (*.*) | *.*";
                if(od.ShowDialog() == DialogResult.OK)
                {
                    tbDuongDan.Text = od.FileName;

                    // Nhap tep tin khoa cong khai
                    OpenFileDialog od1 = new OpenFileDialog();
                    od1.Title = "Chọn tệp tin khóa RSA công khai";
                    od1.Filter = "RSA Public Key (*.rsac) | *.rsac";
                    if(od1.ShowDialog() == DialogResult.OK)
                    {
                        String khoaChung = File.ReadAllText(od1.FileName);

                        // Doc tep tin can ma hoa vao mang byte
                        byte[] noiDungTep = File.ReadAllBytes(tbDuongDan.Text);

                        String dinhDangTep = Path.GetExtension(tbDuongDan.Text);
                        byte[] dinhDangTepByte = Encoding.UTF8.GetBytes(dinhDangTep);
                        byte doDaiDinhDangTep = (byte)dinhDangTepByte.Length;

                        byte[] duLieuCanMaHoa = new byte[1 + dinhDangTepByte.Length + noiDungTep.Length];
                        duLieuCanMaHoa[0] = doDaiDinhDangTep;
                        for (int i = 0; i < dinhDangTepByte.Length; i++)
                            duLieuCanMaHoa[1 + i] = dinhDangTepByte[i];
                        for (int i = 0; i < noiDungTep.Length; i++)
                            duLieuCanMaHoa[1 + dinhDangTepByte.Length + i] = noiDungTep[i];

                        byte[] ketQua = rsa.MaHoa(duLieuCanMaHoa, khoaChung);

                        // Luu tep tin da ma hoa
                        SaveFileDialog sd = new SaveFileDialog();
                        sd.Title = "Lưu têp tin đã mã hóa";
                        sd.Filter = "RSA file (*.mrsa) | *.mrsa";
                        if(sd.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(sd.FileName, ketQua);
                        }    
                    }    
                }    
            }
            else
            {
                // Chon tep tin can giai ma
                OpenFileDialog od = new OpenFileDialog();
                od.Title = "Chọn tệp tin cần giải mã";
                od.Multiselect = false;
                od.Filter = "RSA file (*.mrsa) | *.mrsa";
                if(od.ShowDialog() == DialogResult.OK)
                {
                    tbDuongDan.Text = od.FileName;

                    // Chon tep tin khoa rsa rieng dung de giai ma
                    OpenFileDialog od1 = new OpenFileDialog();
                    od1.Title = "Chọn tệp tin khóa RSA riêng";
                    od1.Multiselect = false;
                    od1.Filter = "RSA private key (*.rsar) | *.rsar";
                    if(od1.ShowDialog() == DialogResult.OK)
                    {
                        String khoaRieng = File.ReadAllText(od1.FileName);

                        // Doc noi dung tep can giai ma
                        byte[] noiDungTep = File.ReadAllBytes(tbDuongDan.Text);

                        // Giai ma
                        byte[] ketQua = rsa.GiaiMa(noiDungTep, khoaRieng);

                        // Boc tach du lieu
                        byte doDaiDinhDangTep = ketQua[0];
                        byte[] dinhDangTepByte = new byte[doDaiDinhDangTep];
                        for (int i = 0; i < dinhDangTepByte.Length; i++)
                            dinhDangTepByte[i] = ketQua[1 + i];
                        String dinhDangTep = Encoding.UTF8.GetString(dinhDangTepByte);

                        byte[] noiDungTepGoc = new byte[ketQua.Length - 1 - doDaiDinhDangTep];
                        for (int i = 0; i < noiDungTepGoc.Length; i++)
                            noiDungTepGoc[i] = ketQua[1 + doDaiDinhDangTep + i];

                        // Luu tep tin da giai ma
                        SaveFileDialog sd = new SaveFileDialog();
                        sd.Title = "Lưu têp tin giải mã được";
                        sd.Filter = "(*" + dinhDangTep + ") | *" + dinhDangTep;
                        if(sd.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(sd.FileName, noiDungTepGoc);
                        }    
                    }    
                }    
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbMaHoa.Checked = true;
        }
    }
}
