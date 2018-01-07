using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.State
{
    public class Reprovado: IEstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento Orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra");
        }


        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
