using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Memento
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string NomeCliente { get;private set; }
        public ETipoContrato TipoContrato { get; set; }

        public Contrato(DateTime data, string nomeCliente, ETipoContrato tipoContrato)
        {
            this.Data = data;
            this.NomeCliente = nomeCliente;
            this.TipoContrato = tipoContrato;
        }

        public void Avancar()
        {
            if (this.TipoContrato == ETipoContrato.Novo)
            {
                this.TipoContrato = ETipoContrato.EmAndamento;
            }
            else if (this.TipoContrato == ETipoContrato.EmAndamento)
            {
                this.TipoContrato = ETipoContrato.Assertado;
            }
            else if (this.TipoContrato == ETipoContrato.Assertado)
            {
                this.TipoContrato = ETipoContrato.Concluido;
            }
        }

        public EstadoContrato SalvarEstado()
        {
            return new EstadoContrato(new Contrato(this.Data, this.NomeCliente, this.TipoContrato));
        }
    }
}
