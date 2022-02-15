using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosNeg
{
    class Poscheck
    {
        void check(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("it's a Positive Number");
            }
            else
            {
                Console.WriteLine("it's a Negative Number");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Poscheck d = new Poscheck();
            d.check(n);
        }
    }
}
