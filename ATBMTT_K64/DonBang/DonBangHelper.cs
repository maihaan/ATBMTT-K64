using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonBang
{
    public class DonBangHelper
    {
        char[] BCC = new char[]
        {
            'a', 'b', 'g','h','j','m','u', 'i', 'o', 'p', '0', ' ', '3', '4', '6', '1', 'q', 'w', 'r'
        };

        // Tao khoa la mot hoan vi ngau nhien cua bang chu cai BCC
        public String TaoKhoa()
        {
            String khoa = "";
            List<char> bcc1 = BCC.ToList();
            Random rd = new Random();
            for(int i = 0; i < BCC.Length; i++)
            {
                int viTri = rd.Next(bcc1.Count - 1);
                khoa += bcc1[viTri];
                bcc1.RemoveAt(viTri);
            }
            return khoa;
        }


        public String MaHoa(String duLieuCanMaHoa, String khoa)
        {
            String ketQua = "";
            for(int i = 0; i < duLieuCanMaHoa.Length; i++)
            {
                char kyTuCanMa = duLieuCanMaHoa[i];

                // Tim vi tri cua ky tu can ma trong bang chu cai
                int viTri = -1;
                for(int j = 0; j < BCC.Length; j++)
                {
                    if(BCC[j].ToString().Equals(kyTuCanMa.ToString()))
                    {
                        viTri = j;
                        break;
                    }    
                }

                // Ghi nhan ket qua
                if (viTri == -1)
                    ketQua += kyTuCanMa.ToString();
                else
                {
                    ketQua += khoa[viTri];
                }
            }
            return ketQua;
        }


        public String GiaiMa(String duLieuCanGiaiMa, String khoa)
        {
            String ketQua = "";
            for(int i = 0; i < duLieuCanGiaiMa.Length; i++)
            {
                char kyTuCanGiaiMa = duLieuCanGiaiMa[i];
                int viTri = -1;
                
                // Tim vi tri cua ky tu can giai ma trong khoa
                for(int j = 0; j < khoa.Length; j++)
                {
                    if(khoa[j].ToString().Equals(kyTuCanGiaiMa.ToString()))
                    {
                        viTri = j;
                        break;
                    }    
                }    

                // Tra giai ma
                if(viTri == -1)
                {
                    ketQua += kyTuCanGiaiMa;
                }    
                else
                {
                    ketQua += BCC[viTri].ToString();
                }    
            }
            return ketQua;
        }
    }
}
