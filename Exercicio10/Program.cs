namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Aluno aluno = new Aluno();
            Console.WriteLine("Informe a nota da primeira prova:");
            aluno.nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota da segunda prova:");
            aluno.nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("A média ponderada das notas do aluno é: " + aluno.CalcularMediaPonderada());
        }
    }
}