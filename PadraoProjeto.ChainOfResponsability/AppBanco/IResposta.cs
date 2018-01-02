using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.ChainOfResponsability.AppBanco
{
    public interface IResposta
    {
        void Responde(Requisicao req, Conta conta);
        IResposta Proxima { get; set; }
    }
}
