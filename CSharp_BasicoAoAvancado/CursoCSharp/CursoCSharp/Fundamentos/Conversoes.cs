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
            string idadeString = Console.ReadLine();
            // int idadeInteiro = int.Parse(idadeString); // Neste caso, caso o usuário digite um caractere inesperado, irá ocorrer um erro.
            //int idadeInteiro = Convert.ToInt32(idadeString); Outra forma que é possivel converter
            int idadeInteiro;
            int.TryParse(idadeString, out idadeInteiro);
            Console.WriteLine("Idade inserida: " + idadeInteiro);

            

           
        }
    }
}
