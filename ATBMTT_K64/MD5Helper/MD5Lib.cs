using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Security;

namespace MD5Helper
{
    public class MD5Lib
    {
        public String MatKhau { get; set; }

        public MD5Lib(String matKhau)
        {
            MatKhau = matKhau;
        }

        public String MaHoa(String duLieuCanMaHoa)
        {
            byte[] input = Encoding.UTF8.GetBytes(duLieuCanMaHoa);
            byte[] output = MaHoa(input);
            return Convert.ToBase64String(output, 0, output.Length);
        }

        public String GiaiMa(String duLieuCanGiaiMa)
        {
            byte[] input = Convert.FromBase64String(duLieuCanGiaiMa);
            byte[] output = GiaiMa(input);
            return Encoding.UTF8.GetString(output);
        }


        public byte[] MaHoa(byte[] duLieuCanMaHoa)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
                {
                    des.Key = md5.ComputeHash(Encoding.UTF8.GetBytes(MatKhau));
                    des.Mode = CipherMode.ECB;
                    des.Padding = PaddingMode.PKCS7;
                    using (ICryptoTransform tran = des.CreateEncryptor())
                    {
                        byte[] output = tran.TransformFinalBlock(duLieuCanMaHoa, 0, duLieuCanMaHoa.Length);
                        return output;
                    }
                }
            }
        }

        public byte[] GiaiMa(byte[] duLieuCanGiaiMa)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
                {
                    des.Key = md5.ComputeHash(Encoding.UTF8.GetBytes(MatKhau));
                    des.Mode = CipherMode.ECB;
                    des.Padding = PaddingMode.PKCS7;
                    using (ICryptoTransform tran = des.CreateDecryptor())
                    {
                        byte[] output = tran.TransformFinalBlock(duLieuCanGiaiMa, 0, duLieuCanGiaiMa.Length);
                        return output;
                    }
                }
            }
        }
    }
}
