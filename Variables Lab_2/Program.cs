namespace Variables_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double temperatureFahrenheit = 90;

            double temperatureCelsius = (temperatureFahrenheit - 32) * 5 / 9;

            Console.WriteLine($" {temperatureFahrenheit} Fahrenheit is {temperatureCelsius} degrees Celsius");


        }
    }
}