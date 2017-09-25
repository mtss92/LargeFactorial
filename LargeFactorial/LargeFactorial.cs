using System.Collections.Generic;

namespace LargeFactorial
{
    public static class LargeFactorial
    {
        public static string Factorial(int n)
        {
            List<int> nArr = GetDigits(n);

            for (int i = n - 1; i > 0; i--)
            {
                nArr = Mul(nArr, i);
            }
            nArr.Reverse();
            return string.Join("", nArr);
        }


        private static List<int> Mul(List<int> nArr, int m)
        {
            List<int> res = new List<int>();

            int mod = 0;
            for (int i = 0; i < nArr.Count; i++)
            {
                int mul = (nArr[i] * m) + mod;
                int y = mul % 10;
                res.Add(y);
                mod = (int)(mul / 10);
            }

            if (mod != 0)
            {
                List<int> modArr = GetDigits(mod);

                for (int i = 0; i < modArr.Count; i++)
                {
                    res.Add(modArr[i]);
                }
            }

            return res;
        }

        private static List<int> GetDigits(int n)
        {
            List<int> res = new List<int>();

            int a = n;
            int m = 0;

            do
            {
                m = (int)(a % 10);
                a = (int)(a / 10);
                res.Add(m);
            } while (a != 0);

            return res;
        }
    }
}
