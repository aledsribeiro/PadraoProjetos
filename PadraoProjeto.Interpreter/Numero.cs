using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Interpreter
{
    public class Numero:IExpressao
    {
        private int _numero { get; set; }

        public Numero(int numero)
        {
            this._numero = numero;
        }

        public int Avaliar()
        {
            return this._numero;
        }
    }
}
