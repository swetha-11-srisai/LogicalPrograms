using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class MonthlyPayment
    {
        
        public  double  monthlyCheck(double p, double y, double r)
        {
            
            double  n = 12 * y;
            double rone = r / (12 * 100);
            double payment=p * r / (1 - Math.Pow((1 + rone), -n));
            return payment;
        }


    }
}
