using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCon
{
    class First {
        public void show() {
            Console.WriteLine("first");
        }
    }
    class Second:First
    {
        public new void show()
        {
            base.show();
            Console.WriteLine("second");
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            Second s = new Second();
            s.show();
        }
    }
}
