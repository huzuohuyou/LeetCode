namespace LeetCode
{

    public class Solution_JZO16 : ISolution
    {
        public void Test()
        {
            var f = MyPow(2,3);
        }
        public double MyPow(double x, int n)
        {
            if (x == 0) return 0;
            long b = n;
            double res = 1.0;
            if (b < 0)
            {
                x = 1 / x;
                b = -b;
            }
            while (b > 0)
            {
                if ((b & 1) == 1) res *= x;
                x *= x;
                b >>= 1;
            }
            return res;
        }

    }
}

