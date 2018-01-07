using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.State
{
    public class Aprovado: IEstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento Orcamento)
        {
            Orcamento.Valor = Orcamento.Valor - (Orcamento.Valor * 0.02);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento esta em aprovação e não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
