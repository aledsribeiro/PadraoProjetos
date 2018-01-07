using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Memento
{
    public class HistoricoContrato
    {
        public List<EstadoContrato> ListaEstados = new List<EstadoContrato>();

        public void AdicionarEstadoContrato(EstadoContrato estadoContrato)
        {
            this.ListaEstados.Add(estadoContrato);
        }

        public EstadoContrato ObterEstadoContrato(int indice)
        {
            return ListaEstados[indice];
        }
    }
}
