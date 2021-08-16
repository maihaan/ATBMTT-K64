using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ceasar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            if(tbDuLieuCanMaHoa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần mã hóa!");
                tbDuLieuCanMaHoa.Focus();
                return;
            }

            CeasarHelper ch = new CeasarHelper(4);
            tbDuLieuMaHoaDuoc.Text = ch.MaHoa(tbDuLieuCanMaHoa.Text.Trim());
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            if (tbDuLieuMaHoaDuoc.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần giải mã!");
                tbDuLieuMaHoaDuoc.Focus();
                return;
            }

            CeasarHelper ch = new CeasarHelper(4);
            tbKetQuaGiaiMa.Text = ch.GiaiMa(tbDuLieuMaHoaDuoc.Text.Trim());
        }
    }
}
