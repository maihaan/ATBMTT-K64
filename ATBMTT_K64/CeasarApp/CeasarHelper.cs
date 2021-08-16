using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CeasarApp
{
    public class CeasarHelper
    {
        public int K { get; set; }

        char[] BCC = new char[] { 'a', 'c', 'd', 'g', 'h', 'o', 'q', 'w', 'l', 'p', 'm', 'k', 's', 'n', 'v', 'b', 'u', 'r', 'y', '1', '0',
        '2', '9', '8', '5', '3', ' ', 'e', 't', 'i'};

        public CeasarHelper(int k)
        {
            K = k;
        }

        public String MaHoa(String giaTriCanMaHoa)
        {
            String ketQua = "";

            for(int i = 0; i < giaTriCanMaHoa.Length; i++)
            {
                char x = giaTriCanMaHoa[i];
                int viTriX = -1;
                for(int j = 0; j < BCC.Length; j++)
                {
                    if(BCC[j].Equals(x))
                    {
                        viTriX = j;
                        break;
                    }    
                }    
                if(viTriX == -1)
                {
                    // Ky tu can ma hoa x khong co trong BCC
                    ketQua += x.ToString();
                }    
                else
                {
                    int viTriMoi = (viTriX + K) % BCC.Length;
                    ketQua += BCC[viTriMoi].ToString();
                }    
            }

            return ketQua;
        }

        public String GiaiMa(String giaTriCanGiaiMa)
        {
            String ketQua = "";

            for (int i = 0; i < giaTriCanGiaiMa.Length; i++)
            {
                char x = giaTriCanGiaiMa[i];
                int viTriX = -1;
                for (int j = 0; j < BCC.Length; j++)
                {
                    if (BCC[j].Equals(x))
                    {
                        viTriX = j;
                        break;
                    }
                }
                if (viTriX == -1)
                {
                    // Ky tu can ma hoa x khong co trong BCC
                    ketQua += x.ToString();
                }
                else
                {
                    int viTriMoi = (viTriX - K);
                    if (viTriMoi < 0)
                        viTriMoi = viTriMoi + BCC.Length;

                    ketQua += BCC[viTriMoi].ToString();
                }
            }

            return ketQua;
        }
    }
}
