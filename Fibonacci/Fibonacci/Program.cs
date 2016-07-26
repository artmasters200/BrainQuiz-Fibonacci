using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static void DoFibonacci(int x)
        {
            int curValue = 1;
            int prevValue = 0;

            Console.Write(prevValue + " " + curValue);

            for (int i = 2; i < x; i++)
            {
                var old = curValue;
                curValue = curValue + prevValue;
                prevValue = old;
                Console.Write(" " + curValue);
            }
        }

        public static void Main(string[] args)
        {
            DoFibonacci(11);
            //Output should be --> 0 1 1 2 3 5 8 13 21 34 55
        }
    }
}
