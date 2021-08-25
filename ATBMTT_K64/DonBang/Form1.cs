using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DonBang
{
    public partial class Form1 : Form
    {
        String khoa = "";
        DonBangHelper dbh = new DonBangHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khoa = dbh.TaoKhoa();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            if(tbDuLieuCanMaHoa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần mã hóa!");
                tbDuLieuCanMaHoa.Focus();
                return;
            }

            String duLieuCanMaHoa = tbDuLieuCanMaHoa.Text;
            tbDuLieuMaHoaDuoc.Text = dbh.MaHoa(duLieuCanMaHoa, khoa);
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            if(tbDuLieuMaHoaDuoc.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần giải mã!");
                tbDuLieuMaHoaDuoc.Focus();
                return;
            }

            String duLieuCanGiaiMa = tbDuLieuMaHoaDuoc.Text;
            tbKetQuaGiaiMa.Text = dbh.GiaiMa(duLieuCanGiaiMa, khoa);
        }
    }
}
