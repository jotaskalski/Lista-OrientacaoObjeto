using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class ConversorTemperatura
    {
        public double temperaturaFahrenheit;
        public double ConverterParaCelsius()
        {
            return (temperaturaFahrenheit - 32) * 5 / 9;
        }
    }
}
