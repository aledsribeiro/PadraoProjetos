﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.State
{
    public interface IEstadoOrcamento
    {
        void AplicarDescontoExtra(Orcamento Orcamento);

        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}
