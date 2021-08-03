using MyUtilities;
using FahrenheitTemperature;
using System;

namespace MyFirstProgram
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Mira!!");
            Console.WriteLine("Where should we go in August? And remember, the lower the index, the greater the comfort!");
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(77), 55);
            WeatherUtilities.Report("Vienna", 34, 70);
        }
    }
}