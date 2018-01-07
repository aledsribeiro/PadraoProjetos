using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PadraoProjeto.Visitor
{
    public interface IExpressao
    {
        int Avaliar();
        void Imprimir(Impressora impressora);
    }
}
