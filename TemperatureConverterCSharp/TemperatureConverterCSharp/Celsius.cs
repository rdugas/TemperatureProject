using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterCSharp
{
    public class Celsius
    {
        private const double celsSubtractConstant  = 32;
        private const double celsMultiplyConstant  = .5555555556;
        public const double kelvinAddConstant  = 273.16;

        public static double CelsiusFromFahrenheit(double fahrenheit)
        {
            var _fahrenheit = fahrenheit;
            return (_fahrenheit - 32) * celsMultiplyConstant;

        }

        public static double KelvinFromCelsius(double celsius)
        {
            var _celsius = celsius;
            return _celsius + kelvinAddConstant;
        }

        public static double KelvinFromFahrenheit(double fahrenheit)
        {
            var _fahrenheit = fahrenheit;
            var _celsius = CelsiusFromFahrenheit(_fahrenheit);
            return _celsius + kelvinAddConstant;
        }
    }
}
