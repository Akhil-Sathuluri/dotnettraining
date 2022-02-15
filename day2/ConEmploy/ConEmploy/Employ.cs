using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEmploy
{
    class Employ
    {
        int empno;
        string name;
        double salary;
        Employ[] employ;
        public Employ() {
            this.empno = 1;
            this.name = "akhil";
            this.salary = 50000;
        }
        public Employ(params Employ[] emp) { 
            this.employ = emp;
        }
        public Employ(int empno, string name, double salary) { 
            this.empno=empno;
            this.name = name;
            this.salary = salary;
        }
        public void show() {
            foreach (Employ e in employ) {
                Console.WriteLine(e);
            }
        }
        public override string ToString()
        {
            return empno + " " + name+" "+salary;
        }
    }
}
