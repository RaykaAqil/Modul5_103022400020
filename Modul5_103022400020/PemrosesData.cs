using System;
using System.Collections.Generic;
using System.Text;

namespace Modul5_103022400020
{
    public class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T>(T t1, T t2, T t3)
        {
            dynamic terbesar = t1;
            dynamic terbesar2 = t2;
            dynamic terbesar3 = t3;

            if (terbesar2 > terbesar)
            {
                terbesar = terbesar2;
            }
            if (terbesar3 > terbesar)
            {
                terbesar = terbesar3;
            }
            return terbesar;
        }
    }
}
