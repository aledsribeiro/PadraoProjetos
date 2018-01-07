using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criadorNota = new NotaFiscalBuilder();
            //chama-se fluent interface
            //um metodo atras do outro = metodo chain
            criadorNota
                .ParaEmpresa("Ale.TI")
                .ComCNPJ("123456")
                .ComItens(new ItemNota("Item1", 100))
                .ComItens(new ItemNota("Item2", 200))
                .NaDataAtual()
                .ComObservacao("obs");

            criadorNota.AdicionarAcao(new EnviadorSMS());
            NotaFiscal nota = criadorNota.ConstruirNota();
           

            Console.WriteLine(nota.ValorBruto);
            Console.WriteLine(nota.Impostos);

            Console.ReadKey();
        }
    }
}
