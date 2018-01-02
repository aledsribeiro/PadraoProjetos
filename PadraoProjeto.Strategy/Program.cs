using PadraoProjeto.Strategy.Imposto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto ICMS = new ICMS();
            IImposto ISS = new ISS();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorImpostos calculadora = new CalculadorImpostos();

            calculadora.RealizaCalculo(orcamento, ISS);
            calculadora.RealizaCalculo(orcamento, ICMS);

            Console.ReadKey();

        }
    }
}
