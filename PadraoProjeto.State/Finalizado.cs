using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.State
{
    public class Finalizado: IEstadoOrcamento
    {

        public void AplicarDescontoExtra(Orcamento Orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra");
        }


        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta finalizado");
        }
    }
}
