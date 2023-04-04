namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Informe a primeira nota do aluno:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota do aluno:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota do aluno:");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("A média harmônica das notas do aluno é: " + aluno.CalcularMediaHarmonica());
        }
    }
}