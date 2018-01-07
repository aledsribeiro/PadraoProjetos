using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Observer
{
    public class NotaFiscalDAO: IAcoesNotaFiscal
    {
        public void ExecutaAcao(NotaFiscal nf)
        {
            Console.WriteLine("Simulando banco de dados");
        }

    }
}
