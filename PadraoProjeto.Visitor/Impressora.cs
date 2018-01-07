using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Visitor
{
    public class Impressora
    {
        public void ImprimirSoma(Soma soma)
        {
            Console.WriteLine("(");
            //esquerda
            soma.Esquerda.Imprimir(this);
            Console.WriteLine("+");
            soma.Direita.Imprimir(this);
            Console.WriteLine(")");
        }

        public void ImprimirSubtracao(Subtracao subtracao)
        {
            Console.WriteLine("(");
            subtracao.Esquerda.Imprimir(this);
            Console.WriteLine("-");
            subtracao.Direita.Imprimir(this);
            Console.WriteLine(")");
        }

        public void ImprimirNumero(Numero numero)
        {
            Console.WriteLine(numero.Valor);
        }
    }
}
