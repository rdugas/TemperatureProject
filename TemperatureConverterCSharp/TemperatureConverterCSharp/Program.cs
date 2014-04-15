using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Convert F to C");
            Console.WriteLine("2. Convert C to F");
            Console.WriteLine("3. Convert F to R");
            Console.WriteLine("4. Convert C to K");
            Console.WriteLine("5. Convert F to K");
            Console.WriteLine("6. Convert C to R");
            Console.WriteLine("E. Exit the program");
            Console.WriteLine("Choose an option or type E followed by enter to exit: ");
            var selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    var response1 = PromptUserBasedOnInput("F");
                    var output1 = Celsius.CelsiusFromFahrenheit(response1);
                    Console.WriteLine("{0} Fahrenheit is {1} Celsius.", response1, output1);
                    Console.WriteLine("Press Enter To Exit");
                    Console.ReadLine();
                    break;
                case "3":
                    var response3 = PromptUserBasedOnInput("F");
                    var output3 = Fahrenheit.RankineFromFahrenheit(response3);
                    Console.WriteLine("{0} Fahrenheit is {1} Rankine.", response3, output3);
                    Console.WriteLine("Press Enter To Exit");
                    Console.ReadLine();
                    break;
                case "5":
                    var response5 = PromptUserBasedOnInput("F");
                    var output5 = Celsius.KelvinFromFahrenheit(response5);
                    Console.WriteLine("{0} Fahrenheit is {1} Kelvin.", response5, output5);
                    Console.WriteLine("Press Enter To Exit");
                    Console.ReadLine();
                    break;
                case "2":
                    var response2 = PromptUserBasedOnInput("C");
                    var output2 = Fahrenheit.FahrenheitFromCelsius(response2);
                    Console.WriteLine("{0} Celsius is {1} Fahrenheit.", response2, output2);
                    Console.WriteLine("Press Enter To Exit");
                    Console.ReadLine();
                    break;
                case "4":
                    var response4 = PromptUserBasedOnInput("C");
                    var output4 = Celsius.KelvinFromCelsius(response4);
                    Console.WriteLine("{0} Celsius is {1} Kelvin.", response4, output4);
                    Console.WriteLine("Press Enter To Exit");
                    Console.ReadLine();
                    break;
                case "6":
                    var response6 = PromptUserBasedOnInput("C");
                    var output6 = Fahrenheit.RankineFromCelsius(response6);
                    Console.WriteLine("{0} Celsius is {1} Rankine.",response6,output6);
                    Console.WriteLine("Press Enter To Exit");
                    Console.ReadLine();
                    break;
                case "E":
                    Console.WriteLine("Thanks for playing! Press Enter To Exit");
                    Console.ReadLine();
                    break;
            }
            

        }

        static double PromptUserBasedOnInput(string option)
        {
            var sharedPhrase = "Enter degrees in ";
            if (option == "F")
            {
                Console.WriteLine("{0}Fahrenheit: ",sharedPhrase);
                double userInput = Convert.ToDouble(Console.ReadLine());
                return userInput;
            }
            else
            {
                Console.WriteLine("{0}Celsius: ", sharedPhrase);
                double userInput = Convert.ToDouble(Console.ReadLine());
                return userInput;
            };

        }
    }
}
