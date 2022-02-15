using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objdemo
{
    class Demo
    {
        void unbox(params object[] obs) {
            foreach (Object ob in obs) {
                if (ob.GetType().Name.Equals("Int32")) {
                    Console.WriteLine((Int32)ob);
                }
                else if (ob.GetType().Name.Equals("Double"))
                {
                    Console.WriteLine((Double)ob);
                }
                else if (ob.GetType().Name.Equals("String"))
                {
                    Console.WriteLine((string)ob);
                }
            }
        
        }
        static void Main(string[] args)
        {
            int a = 12;
            double b = 3.14;
            string name = "akhil";
            /* boxing data types*/
            object obj1 = a;
            object obj2 = b;
            object obj3 = name;
            /*unboxing back*/
            int x = (Int32)obj1;
            double y = (Double)obj2;
            string z = (string)obj3;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Demo d= new Demo();
            d.unbox(obj1,obj2,obj3);
        }
    }
}
