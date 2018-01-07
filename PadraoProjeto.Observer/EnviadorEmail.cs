using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Observer
{
    public class EnviadorEmail: IAcoesNotaFiscal
    {
        public void ExecutaAcao(NotaFiscal nf)
        {
            Console.WriteLine("Simulando e-mail");
        }

    }
}
