using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PadraoProjeto.Observer
{
    public class ItemNota
    {
        public ItemNota(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
