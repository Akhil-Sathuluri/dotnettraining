using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Demo
    {
        void check(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("it's an Even Number");
            }
            else {
                Console.WriteLine("it's an Odd Number");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number : ");
            n=Convert.ToInt32(Console.ReadLine());
            Demo d=new Demo();
            d.check(n);
        }
    }
}
