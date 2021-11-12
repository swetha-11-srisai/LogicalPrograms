using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-Fibnoccie,2-Prime,3-Reverse,4-Perfect,5-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Fibnocci series = new Fibnocci();
                        series.FibnocieSeries();
                        break;
                    case 2:
                        PrimeNumber prime = new PrimeNumber();
                        prime.CheckPrime();
                        break;
                    case 3:
                        ReverseNumber rev = new ReverseNumber();
                        rev.Reverse();
                        break;
                    case 4:
                        Console.WriteLine("Enter the number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.CheckPerfect(num);
                        break;

                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}