using PadraoProjeto.Strategy.Imposto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Strategy
{
    /// <summary>
    /// Classe que contem a regra de negócio para o calculo de imposto
    /// </summary>
    public class CalculadorImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double impostoCalculado = imposto.Calcula(orcamento);
            Console.WriteLine(impostoCalculado);
        }
    }
}
