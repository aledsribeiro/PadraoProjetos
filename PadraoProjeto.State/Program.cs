using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.State
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(500);
            Console.WriteLine("Valor orcamento inicial  " + orcamento.Valor);
            orcamento.AplicaDescontoExtra();
            Console.WriteLine("Valor orcamento com desconto  " + orcamento.Valor);
            orcamento.Aprova();
            orcamento.AplicaDescontoExtra();
            Console.WriteLine("Valor orcamento aprovado com desconto  " + orcamento.Valor);

            orcamento.Finaliza();
            orcamento.AplicaDescontoExtra();
            Console.ReadKey();
        }
    }
}
