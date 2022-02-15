using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Multiplier
{
    static class Multi {
        public static int Mul(this Calculate ob, int a, int b) {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12, y = 3;
            Calculate ob = new Calculate();
            Console.WriteLine(ob.Mul(x,y));
        }
    }
}
