using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.ChainOfResponsability.Desconto
{
    public class DescontoPorVendaCasada: IDesconto
    {
        public IDesconto Proximo { get; set; }
        

        public double Descontar(Orcamento orcamento)
        {
            if (VerificarVendaCasada(orcamento))
                return orcamento.Valor * 0.05;
            else
                return Proximo.Descontar(orcamento);
        }

        public bool VerificarVendaCasada(Orcamento orcamento)
        {
            return existe("Caneta", orcamento) && existe("Lapis", orcamento);
        }

        private bool existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem)) return true;
            }
            return false;
        }
    }
}
