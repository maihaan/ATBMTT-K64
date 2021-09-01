using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSAText
{
    public partial class Form1 : Form
    {
        RSAHelper rsa = new RSAHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbPublicKey.Text = rsa.XuatKhoaChung();
            tbPrivateKey.Text = rsa.XuatKhoaRieng();            
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            tbDuLieuMaHoaDuoc.Text = rsa.MaHoa(tbDuLieuCanMaHoa.Text, tbPublicKey.Text);
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            tbKetQuaGiaiMa.Text = rsa.GiaiMa(tbDuLieuMaHoaDuoc.Text, tbPrivateKey.Text);
        }
    }
}
