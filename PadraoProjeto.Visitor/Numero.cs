using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Visitor
{
    public class Numero:IExpressao
    {
        public  int Valor { get; set; }

        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public int Avaliar()
        {
            return this.Valor;
        }


        public void Imprimir(Impressora impressora)
        {
            impressora.ImprimirNumero(this);
        }
    }
}
