using System;

namespace FahrenheitTemperature
{
    public class Temperature
    {
        public static void FahrenheitToCelsius()
        {
            float temperatureFahrenheit = 79;
            Console.WriteLine($"79 degrees Fahrenheit is {(temperatureFahrenheit - 32) * 5 / 9} in Celsius");
            Console.ReadLine();
        }
    }
}