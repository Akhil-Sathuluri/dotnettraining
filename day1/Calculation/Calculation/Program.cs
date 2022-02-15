using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Program
    {
        void add(int a, int b) {
            Console.WriteLine("add value is " + (a+b));
        }
        void sub(int a, int b) {
            Console.WriteLine("sub value is " + (a-b));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 numbers");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine()); 
            Program program = new Program();
            program.add(a, b);
            program.sub(a, b);
            
        }
    }
}
