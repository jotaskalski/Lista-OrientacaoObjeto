using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Aluno
    {
        public double nota1;
        public double nota2;
        public double nota3;

        public double CalcularMediaHarmonica()
        {
            return 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));
        }
    }
}
