using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    internal class Quiz3
    {
        static void Main(string[] args)
        {
            int n,ptr=0;
            int[] binary = new int[32];
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0) {

                binary[ptr++] = n % 2;
                n = n / 2;
            }
            ptr = ptr - 1;
            while (ptr >= 0) { 
                Console.Write(binary[ptr--]);
            }
            Console.WriteLine();
        }
    }
}
