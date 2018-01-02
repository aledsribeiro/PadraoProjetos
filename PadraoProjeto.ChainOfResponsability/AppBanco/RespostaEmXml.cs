using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.ChainOfResponsability.AppBanco
{
    public class RespostaEmXml:IResposta
    {
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == EFormato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                Proxima.Responde(req, conta);
            }
        }

        public IResposta Proxima { get; set; }
      
    }
}
