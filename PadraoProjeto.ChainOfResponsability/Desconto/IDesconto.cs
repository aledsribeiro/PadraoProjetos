using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.ChainOfResponsability.Desconto
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double Descontar(Orcamento orcamento);


    }
}
