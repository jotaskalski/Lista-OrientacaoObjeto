namespace Lista_OrientacaoObjeto
{
    public class Program
    {
        public static void Main()
        {
            CaixaRetangular caixa = new CaixaRetangular();
            Console.WriteLine("Informe o comprimento da caixa:");
            caixa.comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a largura da caixa:");
            caixa.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da caixa:");
            caixa.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("O volume da caixa é: " + caixa.CalcularVolume());
        }
    }
}