using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //decorando o imposto iss com o icms
            Imposto iss = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento(500);

            double imposto = iss.Calcula(orcamento);

            Console.WriteLine(imposto);
            Console.ReadKey();
        }
    }
}
