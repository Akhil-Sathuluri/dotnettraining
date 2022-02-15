using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEmploy
{
    internal class Demo
    {
        static void Main(string[] args)
        { 
            Employ e1=new Employ();
            Console.WriteLine(e1);
            Employ e2=new Employ(299,"akhil",50000);
            Console.WriteLine(e2);
            Employ[] arr = new Employ[] {
            e2,
            new Employ(380,"chandra",45000)
            };
            Employ arr2 = new Employ(arr);
            arr2.show();
        }
    }
}
