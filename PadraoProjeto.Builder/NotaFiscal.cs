using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Builder
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao,
            double valorBruto, double impostos, IList<ItemNota> itensNota, string observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            this.DataEmissao = dataEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.ItensNota = itensNota;
            this.Observacoes = observacoes;

        }

        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemNota> ItensNota { get; set; }
        public string Observacoes { get; set; }
    }
}
