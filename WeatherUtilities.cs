using System;

namespace MyUtilities
{
    class WeatherUtilities
    {
        //float - better than double for this instance
        public static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) / 1.8f;
        }
        public static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return temperatureCelsius * 1.8f + 32;
        }

        // The higher the Index Number, the lower the comfort:
        private static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            //There might be also other ways to calculate comfort
            return (temperatureFahrenheit + humidityPercent) / 4;
        }
        public static void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine($"Comfort Index for {location}: {ComfortIndex(temperatureFahrenheit, humidity)}");
        }
    }
}