using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;

            double nota = 9.7;
            int notaTruncada = (int)nota; //casting

            Console.WriteLine("Digite sua idade ");
            // int idadeInteiro = int.Parse(idadeString); // Neste caso, caso o usuário digite um caractere inesperado, irá ocorrer um erro.
            //int idadeInteiro = Convert.ToInt32(idadeString); Outra forma que é possivel converter
            int.TryParse(Console.ReadLine(), out int idadeInteiro); // Está é uma forma mais segura de converter uma string para um inteiro, ele tenta converter, e joga o output da conversão para a variável idadeInteiro. Caso não consiga converter, o valor será 0(valor padrão do tipo inteiro)
            Console.WriteLine("Idade inserida: " + idadeInteiro);

        }
    }
}
