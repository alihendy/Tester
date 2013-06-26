using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class PracticeProbs
    {
        public PracticeProbs()
        {
           
        }

        public long nthOfFib(int n)
        {
            long fib=1, temp=0, ans=0;
            if(n == 1) { ans = 0; }
            else if (n == 2) { ans = 1; }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    ans = temp + fib;
                    temp = fib;
                    fib = ans;
                }
            }
            return ans;
        }

        public void printYo()
        {
            for (int i = 1; i < 20; i++)
            {
                Console.Write(nthOfFib(i) + " ");
            }
        }
    }
}
