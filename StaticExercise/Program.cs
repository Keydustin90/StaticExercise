using System;

namespace StaticExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);


            Console.WriteLine($"Celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
