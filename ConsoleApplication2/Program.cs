using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            fib(10);
        }


        static int fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int a = fib(n - 1);
            int b = fib(n - 2);

            return a + b;
        }
    }
}
