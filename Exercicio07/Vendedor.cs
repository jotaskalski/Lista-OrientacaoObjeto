using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Vendedor
    {
        private double salarioBase;
        private double totalVendas;
        private double percentualComissao;

        public double CalcularSalarioTotal()
        {
            double comissao = totalVendas * (percentualComissao / 100);
            return salarioBase + comissao;
        }
    }
}
