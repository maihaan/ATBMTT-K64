using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MD5Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            MD5Lib md5 = new MD5Lib(tbMatKhau.Text.Trim());
            tbDuLieuMaHoaDuoc.Text = md5.MaHoa(tbDuLieuCanMaHoa.Text.Trim());
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            MD5Lib md5 = new MD5Lib(tbMatKhau.Text.Trim());
            tbKetQuaGiaiMa.Text = md5.GiaiMa(tbDuLieuMaHoaDuoc.Text);
        }
    }
}
