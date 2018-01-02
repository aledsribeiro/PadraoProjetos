using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.ChainOfResponsability.AppBanco
{
    public class RespostaEmCSV: IResposta
    {
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == EFormato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                Proxima.Responde(req, conta);
            }
        }

        public IResposta Proxima { get; set; }
    }
}
