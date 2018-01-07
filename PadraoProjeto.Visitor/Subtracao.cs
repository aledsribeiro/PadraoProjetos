﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Visitor
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;

        }

        public int Avaliar()
        {
            int valorEsquerda = Esquerda.Avaliar();
            int valorDireita = Direita.Avaliar();
            return valorEsquerda - valorDireita;
        }


        public void Imprimir(Impressora impressora)
        {
            impressora.ImprimirSubtracao(this);
        }
    }
}
