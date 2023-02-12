using CursoCSharp.Fundamentos;
using System;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
            });

            central.SelecionarEExecutar();
            Console.WriteLine("teste");
        }
    }
}