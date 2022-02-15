using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Data
    {
        public void Akhil() 
        {
            Console.WriteLine("hi i am akhil");
        }
        public void Sathuluri()
        {
            Console.WriteLine("hi my last name is sathuluri");
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dotnet Programming");
            Data obj=new Data();
            obj.Akhil();
            obj.Sathuluri();
        }
    }
}
