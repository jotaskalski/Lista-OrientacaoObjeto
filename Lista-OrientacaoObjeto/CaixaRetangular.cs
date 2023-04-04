using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_OrientacaoObjeto
{
    internal class CaixaRetangular
    {
        public double comprimento;
        public double largura;
        public double altura;

        public double CalcularVolume()
        {
            return comprimento * largura * altura;
        }
    }


}
