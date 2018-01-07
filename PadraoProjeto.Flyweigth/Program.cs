using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Flyweigth
{
    class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();

            IList<INotas> listaNotas = new List<INotas>()
            {
                notas.ObterNota("do"),
                notas.ObterNota("re"),
                notas.ObterNota("mi"),
                notas.ObterNota("fa"),
                notas.ObterNota("sol"),
                notas.ObterNota("la"),
                notas.ObterNota("si")
            };

            Piano piano = new Piano();

            piano.Tocar(listaNotas);
        }
    }
}
