using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PadraoProjeto.Decorator
{
    public class Item
    {
        public Item(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
        public string Nome { get; private set; }
        public double Valor { get; set; }
    }
}
