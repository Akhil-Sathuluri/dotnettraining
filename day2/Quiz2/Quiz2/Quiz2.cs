using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    class Quiz2
    {
        void words(char[] num)
        {
            int n = num.Length;
            string[] ans = new string [ n * 5];
            string[] build = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] build2 = new string[] { "","", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] build3 = new string[] {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            int ptr = 0;
            
            for (int i = n-1; i >= 0; i--)
            {
                if (i == n - 1 && i-1 >= 0 && num[i-1] == '1')
                {
                    ans[ptr++] = build3[num[i]-'0'];
                    i--;
                }
                else if (i == n - 2 && num[i] != '1')
                {
                    ans[ptr++] = build2[num[i]-'0'];
                }
                else
                {
                    if (n-i-1 == 2)
                    {
                        ans[ptr++] = "Hundred";
                    }
                    else if (n-i-1 == 3) {
                        ans[ptr++] = "Thousand";
                    }
                    ans[ptr++] = build[num[i]-'0'];
                }
            }
            while(ptr>=0)
            {
                Console.Write(" " + ans[ptr]);
                ptr--;
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Quiz2 q = new Quiz2();
            q.words("9712".ToCharArray());

        }
    }
}
