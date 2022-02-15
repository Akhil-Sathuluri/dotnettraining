using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Quiz1
    {
        string mul(string num1,string num2)
        {
            int l1=num1.Length;
            int l2=num2.Length;
            if (l1 == 0 || l2 == 0)
                return "0";
            int[] ans =new int[l1+l2];
            int i,i_n1=0,i_n2=0;
            for (i = l1-1; i >= 0; i--){
                int c=0;
                int n1 = num1[i] - '0';
                i_n2 = 0;
                for (int j = l2 - 1; j >= 0; j--) 
                { 
                    int n2=num2[j] - '0';
                    int sum = n1 * n2 + ans[i_n1 + i_n2] + c;
                    c = sum / 10;
                    ans[i_n1 + i_n2] = sum % 10;
                    i_n2++;
                }
                if (c > 0)
                    ans[i_n1 + i_n2] += c;
                i_n1++;
            }
            i=ans.Length-1;
            while (i >= 0 && ans[i] == 0)
                i--;
            if (i == -1)
                return "0";
            string s = " ";
            while (i >= 0)
                s += (ans[i--]);
            return s;
        }
        static void Main(string[] args)
        {
            Quiz1 p = new Quiz1();
            string str1="180303105299992501303801",str2="98765432109876";
            #region managing-sign
            if ((str1[0] == '-' || str2[0] == '-') && (str1[0] != '-' || str2[0] != '-'))
                Console.Write('-');
            if (str1[0]=='-' && str2[0]=='-')
                str1=str1.Substring(1);
            else if (str1[0]!='-' && str2[0] == '-')
                str2=str2.Substring(1);
            else if (str1[0] == '-' && str2[0] != '-')
                str1 = str1.Substring(1);
            #endregion managing-sign
            Console.WriteLine(p.mul(str1,str2));
        }
    }
}
