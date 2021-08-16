using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CeasarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbMaHoa.Checked = true;
            rbGiaiMa.Checked = false;
            tbDuongDan.Focus();
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMaHoa.Checked)
            {
                rbGiaiMa.Checked = false;
                tbDuongDan.Text = "";
            }    
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked)
            {
                rbMaHoa.Checked = false;
                tbDuongDan.Text = "";
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if(rbMaHoa.Checked)
            {
                od.Filter = "Text file (*.txt) | *.txt";
            }    
            else
            {
                od.Filter = "Text file (*.ceasar) | *.ceasar";
            }    

            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;
            }    
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            if(tbDuongDan.Text.Length == 0 || !File.Exists(tbDuongDan.Text))
            {
                MessageBox.Show("Không tìm thấy tệp tin bạn yêu cầu mã hóa hoặc giải mã!");
                return;
            }   
            
            // Doc noi dung tep tin
            String noiDung = "";
            try
            {
                StreamReader sr = new StreamReader(tbDuongDan.Text);
                noiDung = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
            }
            catch
            {
                MessageBox.Show("Tệp tin đang được sử dụng bởi ứng dụng khác. Hãy đóng ứng dụng đang mở tệp tin và thử lại!");
                return;
            }

            // Ma hoa hoac giai ma noi dung
            CeasarHelper ch = new CeasarHelper(4);
            String ketQua = "";
            if (rbMaHoa.Checked)
                ketQua = ch.MaHoa(noiDung);
            else
                ketQua = ch.GiaiMa(noiDung);

            // Luu ket qua vao tep tin moi
            SaveFileDialog sd = new SaveFileDialog();
            if (rbMaHoa.Checked)
            {
                sd.Filter = "Text file (*.ceasar) | *.ceasar";
            }
            else
            {
                sd.Filter = "Text file (*.txt) | *.txt";
            }
            if(sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sd.FileName, ketQua);
            }

            MessageBox.Show("Hoàn thành!");
        }
    }
}
