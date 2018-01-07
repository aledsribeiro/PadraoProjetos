using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Flyweigth
{
    public class Piano
    {
        public void Tocar(IList<INotas> listaNotas)
        {
            foreach (var item in listaNotas)
            {
                Console.Beep(item.Frequencia, 300);
            }
        }
    }
}
