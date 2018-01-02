using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Decorator
{
    /// <summary>
    /// Classe para compor o imposto
    /// </summary>
    public abstract class Imposto
    {
        /// <summary>
        /// Construtor que recebe o outro imposto
        /// </summary>
        /// <param name="imposto"></param>
        public Imposto(Imposto imposto)
        {
            this.outroImposto = imposto;
        }

        /// <summary>
        /// Construtor padrão para finalizar a composição do imposto
        /// </summary>
        public Imposto()
        {
            this.outroImposto = null;
        }

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (outroImposto == null)
                return 0;
            return outroImposto.Calcula(orcamento);
        }

        /// <summary>
        /// 
        /// </summary>
        public Imposto outroImposto { get; set; }


        public abstract double Calcula(Orcamento orcamento);
    }
}
