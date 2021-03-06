﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PadraoProjeto.TemplateMethod
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            this.Itens.Add(item);
        }
    }
}
