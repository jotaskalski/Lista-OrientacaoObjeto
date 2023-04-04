namespace Exercicio02
{
    public class Program
    {
        public static void Main()
        {
            ConversorTemperatura conversor = new ConversorTemperatura();

            Console.WriteLine("Informe a temperatura em graus Fahrenheit:");
            conversor.temperaturaFahrenheit = double.Parse(Console.ReadLine());

            Console.WriteLine("A temperatura em graus Celsius é: " + conversor.ConverterParaCelsius());
        }
    }
}