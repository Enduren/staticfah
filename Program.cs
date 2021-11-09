using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(70);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(21.11);

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celcius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}