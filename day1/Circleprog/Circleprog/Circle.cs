using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circleprog
{
    class Circle
    {
        void Area(double r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine("Area of Circle is " + area);
        }
        void Circum(double r)
        {
            double circum = 2 * 3.14 * r;
            Console.WriteLine("Circumference of Circle is " + circum);
        }
        static void Main(string[] args)
        {
            double r;
            Console.WriteLine("enter radius of circle : ");
            r=Convert.ToDouble(Console.ReadLine());
            Circle cir = new Circle();
            cir.Area(r);
            cir.Circum(r);
        }
    }
}
