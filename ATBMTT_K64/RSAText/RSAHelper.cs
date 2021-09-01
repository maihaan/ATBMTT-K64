using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace RSAText
{
    public class RSAHelper
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

        public String XuatKhoaRieng()
        {
            return rsa.ToXmlString(true);
        }

        public String XuatKhoaChung()
        {
            return rsa.ToXmlString(false);
        }

        public byte[] MaHoa(byte[] duLieuCanMa, String khoaChung)
        {
            rsa.FromXmlString(khoaChung);
            byte[] ketQua = rsa.Encrypt(duLieuCanMa, false);
            return ketQua;
        }

        public byte[] GiaiMa(byte[] duLieuCanGiaiMa, String khoaRieng)
        {
            rsa.FromXmlString(khoaRieng);
            byte[] ketQua = rsa.Decrypt(duLieuCanGiaiMa, false);
            return ketQua;
        }

        public String MaHoa(String duLieuCanMa, String khoaChung)
        {
            byte[] duLieuCanMaByte = Encoding.UTF8.GetBytes(duLieuCanMa);
            byte[] ketQua = MaHoa(duLieuCanMaByte, khoaChung);
            return Convert.ToBase64String(ketQua);
        }

        public String GiaiMa(String duLieuCanGiaiMa, String khoaRieng)
        {
            byte[] duLieuCanGiaiMaByte = Convert.FromBase64String(duLieuCanGiaiMa);
            byte[] ketQua = GiaiMa(duLieuCanGiaiMaByte, khoaRieng);
            return Encoding.UTF8.GetString(ketQua);
        }

    }
}
