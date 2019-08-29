using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class ArithmaticClass
    {
        public int sumNumber(int x, int y)
        {
            return x + y;
        }


        public int DevideNumber(int x, int y)
        {
            if (y == 0)
            {
                throw new Exception("Number is zero");
            }
            return x / y;
        }

        public int randomFunction(int x)
        {
            int a = sumNumber(x, x);
            int b = DevideNumber(a, 2);

            return b;

        }
    }
}