using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaBang
{
    public class DaBangHelper
    {
        char[] BCC = new char[]
        {
            'a', 'b', 'g','h','j','m','u', 'i', 'o', 'p', '0', ' ', '3', '4', '6', '1', 'q', 'w', 'r'
        };

        char[,] BangTra;

        public DaBangHelper()
        {
            BangTra = new char[BCC.Length, BCC.Length];
            for(int i = 0; i < BCC.Length; i++)
            {
                for(int j = 0; j < BCC.Length; j++)
                {
                    BangTra[i, j] = BCC[(i + j) % BCC.Length];
                }    
            }    
        }

        public String TaoKhoa(int doDaiKhoa)
        {
            Random rd = new Random();
            String khoa = "";
            for (int i = 0; i < doDaiKhoa; i++)
                khoa += BCC[rd.Next(BCC.Length - 1)].ToString();
            return khoa;
        }

        public String MaHoa(String duLieuCanMaHoa, String khoa)
        {
            String ketQua = "";
            for(int i = 0; i < duLieuCanMaHoa.Length; i++)
            {
                char kyTuCanMaHoa = duLieuCanMaHoa[i];
                char kyTuKhoa = khoa[i];

                int viTriKyTuCanMaHoa = -1;
                for(int j = 0; j < BCC.Length; j++)
                {
                    if(BCC[j].ToString().Equals(kyTuCanMaHoa.ToString()))
                    {
                        viTriKyTuCanMaHoa = j;
                        break;
                    }    
                }    

                if(viTriKyTuCanMaHoa == -1)
                {
                    ketQua += kyTuCanMaHoa;
                }    
                else
                {
                    int viTriKyTuKhoa = -1;
                    for(int j = 0; j < BCC.Length; j++)
                    {
                        if(BCC[j].ToString().Equals(kyTuKhoa.ToString()))
                        {
                            viTriKyTuKhoa = j;
                            break;
                        }    
                    }
                    ketQua += BangTra[viTriKyTuKhoa, viTriKyTuCanMaHoa];
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
                char kyTuKhoa = khoa[i];

                // Tim vi tri cua ky tu khoa trong BCC
                int viTriKhoa = -1;
                for(int j = 0; j < BCC.Length; j++)
                {
                    if(BCC[j].ToString().Equals(kyTuKhoa.ToString()))
                    {
                        viTriKhoa = j;
                        break;
                    }    
                }

                // Tim vi tri ky tu can giai ma trong dong viTriKhoa o bang tra
                int viTriKyTuCanGiaiMa = -1;
                for(int j = 0; j < BCC.Length; j++)
                {
                    if(BangTra[viTriKhoa, j].ToString().Equals(kyTuCanGiaiMa.ToString()))
                    {
                        viTriKyTuCanGiaiMa = j;
                        break;
                    }    
                }    

                if(viTriKyTuCanGiaiMa == -1)
                {
                    ketQua += kyTuCanGiaiMa;
                }    
                else
                {
                    ketQua += BCC[viTriKyTuCanGiaiMa];
                }    
            }
            return ketQua;
        }
    }
}
