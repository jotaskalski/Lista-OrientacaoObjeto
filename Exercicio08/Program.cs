namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataOleo lataDeOleo = new LataOleo();
            Console.WriteLine("Informe o raio da lata de óleo:");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da lata de óleo:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("O volume da lata de óleo é: " + lataDeOleo.CalcularVolume());
        }
    }
}