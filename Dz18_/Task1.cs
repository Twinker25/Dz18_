using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz18_
{
    public class CustomNumberComparer
    {
        public static void SortByDigitSum(int[] arr)
        {
            Array.Sort(arr, CompareByDigitSum);
        }

        private static int CompareByDigitSum(int x, int y)
        {
            int sumX = GetDigitSum(x);
            int sumY = GetDigitSum(y);

            return sumX.CompareTo(sumY);
        }

        private static int GetDigitSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
