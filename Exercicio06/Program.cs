namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();
            Console.WriteLine("Informe a temperatura em Celsius:");
            temperatura.celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("A temperatura em Fahrenheit é: " + temperatura.ConverterFahrenheit());
        }
    }
}