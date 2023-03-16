using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm
{
    internal class TinhToan
    {
        //Hàm tính tổng của a và b
        public static void CongHaiSo(int a, int b, ref int s)
        {
            s = a + b;
        }

        //Hàm tính tổng của các số từ 1 tới n
        public static int TongDaySo(int n)
        {
            int tong = 0;
            for (int i = 1; i < n; i++)
            {
                tong += i;
            }
            return tong;
        }    
    }
}
