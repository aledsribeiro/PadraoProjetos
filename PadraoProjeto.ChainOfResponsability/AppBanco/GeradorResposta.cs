using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.ChainOfResponsability.AppBanco
{
    public class GeradorResposta
    {
        public void GerarResposta(Requisicao requisicao, Conta conta)
        {
            IResposta respostaXml = new RespostaEmXml();
            IResposta respostaCsv = new RespostaEmCSV();
            IResposta respostaPorCento = new RespostaEmPorcento();

            respostaXml.Proxima = respostaCsv;
            respostaCsv.Proxima = respostaPorCento;

            respostaXml.Responde(requisicao, conta);
        }
    }
}
