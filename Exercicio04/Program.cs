namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro = new Veiculo();
            Console.WriteLine("Informe a kilometragem inicial:");
            carro.kilometragemInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a kilometragem final:");
            carro.kilometragemFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o consumo de combustível:");
            carro.consumoCombustivel = double.Parse(Console.ReadLine());
            Console.WriteLine("O consumo por km é: " + carro.CalcularConsumoPorKm());
        }
    }
}