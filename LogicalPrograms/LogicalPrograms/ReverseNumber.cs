using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        int reminder, reverse = 0;
        /// <summary>
        /// this method is responsible for reversing a number
        /// </summary>
        public void Reverse()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = num % 10;
                //multiply the sum with 10 and then add the reminder
                reverse = (reverse * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                num = num / 10;
            }
            Console.Write("the reversed number is : "+num);

        }
    }
}
