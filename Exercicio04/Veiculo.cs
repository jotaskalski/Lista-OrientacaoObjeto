using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Veiculo
    {
        public double kilometragemInicial;
        public double kilometragemFinal;
        public double consumoCombustivel;

        public double CalcularConsumoPorKm()
        {
            double distanciaPercorrida = kilometragemFinal - kilometragemInicial;
            return distanciaPercorrida / consumoCombustivel;
        }
    }
}
