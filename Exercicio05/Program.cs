﻿namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();
            Console.WriteLine("Informe o raio da esfera:");
            esfera.raio = double.Parse(Console.ReadLine());
            Console.WriteLine("O volume da esfera é: " + esfera.CalcularVolume());
        }
    }
}