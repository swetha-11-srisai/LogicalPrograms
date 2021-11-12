using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class TempratureConvertion
    {
        public  void convertToFahrenheit(double celTemp)
        {
           double fTemp ;

            fTemp = (celTemp * 9) / 5 + 32;

           // return fTemp;

            Console.Write("Fahrenheit value is: " + fTemp);
        }
        public void convertToCelsius(double fahTemp)
        {
            double celTemp;

            celTemp = (fahTemp-32)*5/9;
            Console.Write("Celsius value is: " + celTemp);
        }

    }
}
