using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato contrato = new Contrato(DateTime.Now, "Alessandra", ETipoContrato.Novo);
            HistoricoContrato historico = new HistoricoContrato();

            historico.AdicionarEstadoContrato(contrato.SalvarEstado());
            Console.WriteLine(contrato.TipoContrato);
            contrato.Avancar();
            Console.WriteLine(contrato.TipoContrato);
            historico.AdicionarEstadoContrato(contrato.SalvarEstado());
            contrato.Avancar();
            Console.WriteLine(contrato.TipoContrato);
            historico.AdicionarEstadoContrato(contrato.SalvarEstado());
            Console.WriteLine(historico.ObterEstadoContrato(0).Contrato.TipoContrato);
            Console.ReadKey();
        }
    }
}
