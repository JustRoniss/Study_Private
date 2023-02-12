using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Transforma o valor em string e a formatação F1, significa que quero apenas uma casa decimal
            Console.WriteLine(valor.ToString("C")); // C de currency, formata o valor em moeda. Pega as configurações do sistema operacinal, neste caso ele sabe que a moeda é o Real.
            Console.WriteLine(valor.ToString("P")); // P de percentual 
            Console.WriteLine(valor.ToString("#.##")); // Tipo de formatação personalizada, ele faz arredondamento

            //CultureInfo cultura = new CultureInfo("pt-BR");
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C"), cultura);

            int inteiro = 256;
        }
    }
}
