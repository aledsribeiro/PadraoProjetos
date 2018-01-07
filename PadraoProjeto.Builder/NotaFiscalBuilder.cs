using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Builder
{
     public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        private double _valorTotal { get;set;}
        private double _valorImpostos { get; set; }
        private IList<ItemNota> _itensNota = new List<ItemNota>();
        public string Observacoes { get; set; }
        public DateTime Data { get; set; }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
         {
             this.RazaoSocial = razaoSocial;
             return this;
         }

         public NotaFiscalBuilder ComCNPJ(string cnpj)
         {
             this.CNPJ = cnpj;
             return this;
         }

         public NotaFiscalBuilder ComItens(ItemNota itemNota)
         {
             _itensNota.Add(itemNota);
             _valorTotal += itemNota.Valor;
             _valorImpostos += itemNota.Valor * 0.05;
             return this;
         }

         public NotaFiscalBuilder ComObservacao(string observacao)
         {
             this.Observacoes = observacao;
             return this;
         }

         public NotaFiscalBuilder NaDataAtual()
         {
             this.Data = DateTime.Now;
             return this;
         }


         public NotaFiscal ConstruirNota()
         {
             return new NotaFiscal(RazaoSocial, CNPJ, Data, _valorTotal, _valorImpostos, _itensNota, Observacoes);
         }
    }
}
