using Exercicio03;

namespace Exercicio0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            Console.WriteLine("Informe o raio do cilindro:");
            cilindro.raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do cilindro:");
            cilindro.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("O volume do cilindro é: " + cilindro.CalcularVolume());
        }
    }
}