using PadraoProjeto.ChainOfResponsability.AppBanco;
using PadraoProjeto.ChainOfResponsability.Desconto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto.ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            //ValidaDesconto();
            GerarResposta();

            Console.ReadKey();
        }

        private static void ValidaDesconto()
        {
            CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);

            orcamento.AdicionarItem(new Item("Caneta", 250));
            orcamento.AdicionarItem(new Item("Borracha", 250));

            double desconto = calculadorDeDescontos.Calcula(orcamento);

            Console.WriteLine(desconto);
        }

        private static void GerarResposta()
        {
            GeradorResposta resposta = new GeradorResposta();
            Conta conta = new Conta("Alessandra", 10000);
            Requisicao requisicao = new Requisicao(EFormato.XML);

            resposta.GerarResposta(requisicao, conta);
        }
    }
}
