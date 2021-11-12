using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Fibnocci
    {
        int num1 = 0, num2 = 1, nextterm, num;
        public void FibnocieSeries()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                nextterm = num1 + num2;
                num1 = num2;
                num2 = nextterm;
                Console.WriteLine("Fibnociee Series :" + nextterm);
            }
        }
    }
}
