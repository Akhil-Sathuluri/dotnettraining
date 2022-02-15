using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;
using AgentEntity;
using AgentBusinessLayer;

namespace AgentMainUI
{
    class Program
    {
        static AgentBAL bal = new AgentBAL();
        public static void AddAgentMain() {
            List<Agent> al = bal.ShowAgentDAL();
            Agent a = new Agent();
            if (al.Count!=0)
            {
                Agent last = al.Last();
                a.Agentid = last.Agentid + 1;
            }
            else {
                a.Agentid = 1;
            }
            Console.WriteLine("Enter Agent Name : ");
            a.AgentName = Console.ReadLine();
            Console.WriteLine("Enter Agent Gender : ");
            a.Gender = Console.ReadLine();
            Console.WriteLine("Choose Paymode 1 or 2 or 3");
            a.PayMode=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Agent Premium");
            a.Premium=Convert.ToDouble(Console.ReadLine());
            bal.AddAgentBAL(a);
        }
        public static void UpdateAgentMain()
        {
            Agent a = new Agent();
            Console.WriteLine("Enter Agent id : ");
            a.Agentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Agent Name : ");
            a.AgentName = Console.ReadLine();
            Console.WriteLine("Enter Agent Gender : ");
            a.Gender = Console.ReadLine();
            Console.WriteLine("Choose Paymode 1 or 2 or 3");
            a.PayMode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Agent Premium");
            a.Premium = Convert.ToDouble(Console.ReadLine());
            bal.UpdateAgentBAL(a);
        }
        public static void SearchAgentMain()
        {
            Console.WriteLine("Enter Agent id");
            int agtno=Convert.ToInt32(Console.ReadLine());
            Agent a = bal.SearchAgentBAL(agtno);
            if (a != null)
            {
                Console.WriteLine(a);
            }
            else {
                Console.WriteLine("Record Not Found");
            }
        }
        public static void DeleteAgentMain() {
            Console.WriteLine("Enter Agent id");
            int agtno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bal.DeleteAgentBAL(agtno));
        }
        public static void ShowAgentMain() {
            List<Agent> al = bal.ShowAgentDAL();
            foreach (Agent a in al) {
                Console.WriteLine(a);
            }
        }
        public static void ReadAgentFileMain() {
            bal.ReadAgentBAL();
        }
        public static void WriteAgentFileMain() {
            bal.WriteAgentBAL();
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("OPTIONS");
                Console.WriteLine("1.ADD AGENT");
                Console.WriteLine("2.SHOW AGENT");
                Console.WriteLine("3.SEARCH AGENT");
                Console.WriteLine("4.DELETE AGENT");
                Console.WriteLine("5.UPDATE AGENT DATA");
                Console.WriteLine("6.WRITE AGENT FILE");
                Console.WriteLine("7.READ AGENT FILE");
                Console.WriteLine("8.EXIT");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            AddAgentMain();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        ShowAgentMain();
                        break;
                    case 3:
                        SearchAgentMain();
                        break;
                    case 4:
                        DeleteAgentMain();
                        break;
                    case 5:
                        UpdateAgentMain();
                        break;
                    case 6:
                        WriteAgentFileMain();
                        break;
                    case 7:
                        ReadAgentFileMain();
                        break;
                    case 8:
                        return;
                }
            } while (choice != 8);
        }
    }
}
