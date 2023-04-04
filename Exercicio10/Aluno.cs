using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Aluno
    {
        public double nota1;
        public double nota2;

        public double CalcularMediaPonderada()
        {
            return (nota1 * 0.4) + (nota2 * 0.6);
        }
    }
}
