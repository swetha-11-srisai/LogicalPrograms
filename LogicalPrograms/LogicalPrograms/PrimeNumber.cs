using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        int num, counter = 0;
        public void CheckPrime()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                Console.WriteLine(" Prime Number"+ num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
