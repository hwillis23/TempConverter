using System;
using System.Collections.Generic;

namespace Temperature_Conversion_static_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahTemp = 45.7;
            double celsTemp = 15.2;


            Console.WriteLine($" The temperature value in Fahrenheite is: {TempConverter.FahrenheitToCelsius(fahTemp)}");
            Console.WriteLine();
            Console.WriteLine($"The temperature value in Celsius is: {TempConverter.CelsiusToFahrenheit(celsTemp)}"); 

        }
    }
}
