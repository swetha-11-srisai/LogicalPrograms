using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        int sum = 0;
        public void CheckPerfect(int num)
        {
           
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum+i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(" Perfect Number" + sum);
            }
            else
            {
                Console.WriteLine("Not a Perfect Number");
            }
        }
    }
}
