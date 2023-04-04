using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Temperatura
    {
        public double celsius;

        public double ConverterFahrenheit()
        {
            return (celsius * 9.0 / 5.0) + 32;
        }
    }
}
