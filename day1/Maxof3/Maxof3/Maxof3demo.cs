using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxof3
{
    class Maxof3demo
    {
        void max(double a, double b, double c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("maximum is " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("maximum is " + b);
            }
            else
            {
                Console.WriteLine("maximum is " + c);
            }
        }
        static void Main(string[] args)
        {
            Maxof3demo demo = new Maxof3demo();
            Console.WriteLine("enter 3 numbers ");
            demo.max(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
        }
    }
}
