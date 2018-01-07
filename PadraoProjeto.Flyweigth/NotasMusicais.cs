using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Flyweigth
{
    public class NotasMusicais
    {
        private static IDictionary<string, INotas> notas = new Dictionary<string, INotas>() {
            {"Do", new Do()},
            {"Re", new Re()},
            {"Mi", new Mi()},
            {"Fa", new Fa()},
            {"Sol", new Sol()},
            {"La", new La()}
        
        };

        public INotas ObterNota(string nome)
        {
            return notas[nome];
        }
    }


}
