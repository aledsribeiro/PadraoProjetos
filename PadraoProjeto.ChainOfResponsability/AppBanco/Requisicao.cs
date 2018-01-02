using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.ChainOfResponsability.AppBanco
{
    public class Requisicao
    {
        public EFormato Formato { get; private set; }

        public Requisicao(EFormato formato)
        {
            this.Formato = formato;
        }
    }
}
