using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Observer
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
        public IList<IAcoesNotaFiscal> AcoesNotafiscal = new List<IAcoesNotaFiscal>();

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
             NotaFiscal nf = new NotaFiscal(RazaoSocial, CNPJ, Data, _valorTotal, _valorImpostos, _itensNota, Observacoes);

             //Toda vez que uma ação nova precisar ser incluida teremos que criar uma classe e lembrar de instancia-la aqui
             //Aprendizado: 1º quando encontramos classes que fazem coisas parecidas temos que fazer uma abstração
             //new EnviadorEmail().ExecutaAcao(nf);
             //new EnviadorSMS().ExecutaAcao(nf);
             //new NotaFiscalDAO().ExecutaAcao(nf);

             foreach (IAcoesNotaFiscal acao in AcoesNotafiscal)
             {
                 acao.ExecutaAcao(nf);
             }
             return nf;
         }

         public void AdicionarAcao(IAcoesNotaFiscal novaAcao)
         {
             AcoesNotafiscal.Add(novaAcao);
         }

    }
}
