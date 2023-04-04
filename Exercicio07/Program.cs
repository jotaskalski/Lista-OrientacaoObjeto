namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();

            Console.WriteLine("Informe o salário base do vendedor:");
            double salarioBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o total de vendas do vendedor:");
            double totalVendas = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o percentual de comissão do vendedor:");
            double percentualComissao = double.Parse(Console.ReadLine());
            Console.WriteLine("O salário total do vendedor é: " + vendedor.CalcularSalarioTotal());
        }
    }
}