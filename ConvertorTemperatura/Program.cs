using System;
using ConvertorTemperatura.Entities;
using System.Globalization;

namespace ConvertorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius;
            char repetir;

            do
            {
                Console.Write("Informe a Temperatura em °Celcius para conversão: ");
                celcius = double.Parse(Console.ReadLine());

                double fahrenheit = Calcular.Fahrenheit(celcius);
                double kelvin = Calcular.Kelvin(celcius);

                Console.WriteLine($"\nTemperatura atual: {celcius}°C \nEquivalente em Fahrenheit: {fahrenheit}°F \nEquivalente em Kelvin {kelvin.ToString("F2")}K");

                Console.WriteLine("\nDeseja repetir (s/n):");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');
        }
    }
}
