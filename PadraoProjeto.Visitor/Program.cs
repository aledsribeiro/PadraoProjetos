using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ////(1 + 100) + 10 + (20 - 10)
            IExpressao esquerda = new Soma(new Numero(100), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            IExpressao soma = new Soma(esquerda, direita);
            Console.WriteLine(soma.Avaliar());
           

            Impressora impressora = new Impressora();
            soma.Imprimir(impressora);

            Console.ReadKey();

        }
    }
}
