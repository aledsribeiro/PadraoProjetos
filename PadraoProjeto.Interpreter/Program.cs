using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            ////(1 + 100) + 10 + (20 - 10)
            //IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            //IExpressao soma = new Soma(esquerda, direita);
            //Console.WriteLine(soma.Avaliar());
            //Console.ReadKey();

            //API de expressão do .NET - ela usa interpreter
            Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));

            //devolve uma função que retorna um numeto inteiro
            Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
            Console.WriteLine(funcao());
            Console.ReadKey();
        }
    }
}
