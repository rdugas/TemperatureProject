using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterCSharp
{
    public class Fahrenheit
    {
        private const double fahrAddConstant  = 32;
        private const double fahrMultiplyConstant  = 1.8;
        private const double rankineAddConstant  = 460;
        
        public static double FahrenheitFromCelsius(double celsius)
        {
            var _celsius = celsius;
            return (fahrMultiplyConstant * _celsius) + fahrAddConstant;
        }

        public static double RankineFromFahrenheit(double fahrenheit)
        {
            var _fahrenheit = fahrenheit;
            return _fahrenheit + rankineAddConstant;
        }

        public static double RankineFromCelsius(double celsius)
        {
            var _celsius = celsius;
            var _fahrenheit = FahrenheitFromCelsius(_celsius);
            return _fahrenheit + rankineAddConstant;
        }
    }
}
