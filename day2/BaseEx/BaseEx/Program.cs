using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEx
{
    class Emp {
        int id;
        string name;
        double salary;
        public Emp(int id, string name, double salary) {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return id +" "+ name+" " + salary;
        }
    }
    class Akhil : Emp {
        public Akhil(int id, string name, double salary) : base(id, name, salary) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Akhil a = new Akhil(299, "akhil", 50000);
            Console.WriteLine(a);
        }
    }
}
