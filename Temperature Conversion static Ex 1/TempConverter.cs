using System;
using System.Collections.Generic;
using System.Text;

namespace Temperature_Conversion_static_Ex_1
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahTemp)
        {
            return (fahTemp - 32) * 5.0 / 9.0;
        }

        public static double CelsiusToFahrenheit(double celsTemp)
        {
            return (celsTemp * 9.0 / 5.0) + 32;
        }

    }
}
