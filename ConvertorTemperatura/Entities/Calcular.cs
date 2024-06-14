namespace ConvertorTemperatura.Entities
{
    internal class Calcular
    {
        public double Celcius { get; set; }

        public Calcular(double celcius)
        {
            Celcius = celcius;
        }

        public static double Fahrenheit(double celcius)
        {
            return 9.0 * celcius / 5.0 + 32.0;
        }

        public static double Kelvin(double celcius)
        {
            return celcius + 273.15;
        }

    }
}
