using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class MathOps
    {
        public static ulong Factorial(ulong number)
        {
            System.Threading.Thread.Sleep(25);

            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}
