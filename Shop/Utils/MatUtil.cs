using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Utils
{
    public static class MatUtil
    {
        public static long Factorial(int num)
        {
            int n = 1;
            if (num == 1) return 1;

            return n * Factorial(num - 1);
        }
    }
}
