// See https://aka.ms/new-console-template for more information
namespace LINQ
{
    public class Program
    {
        public static void Main()
        {
            // LINQ = Consulta integrada a linguagem
            /* LINQ foi inicialmente adcionado à versão do .NET framework 3.5 no final do ano de 2007, juntamente com o Visual Studio 2008. Esse foi um marco muito importante para o ecossitema .NET
             * O LINQ surfiu para fornecer a capacidade de efetuar consultas em fonte de dados diferentes, seu principal objetivo é abstrair toda a complexidade ao fazer consultas em uma fonte de dados
             * ou seja, você consegue efetuar consultas de forma muito fácil em qualquer tipo de coleção, inclusive, em uma cadeia de caracteres. Essas consutas são feiras por meio de expressões ou delegates
             */
            
            //Where---------------------------------------------------------------------------------------------------------
            Console.WriteLine("Where-----------------------------------------------------------------------------------------");
            string nomeCompleto = "RONALDO LUIZ";
            var resultado = nomeCompleto.Where(p => p == 'O');
            foreach (var letra in resultado)
            {
                Console.WriteLine(letra);
            }

            Func<char, bool> filtroNome = c => c == 'A';

            var resultado2 = nomeCompleto.Where(filtroNome);
            foreach (var letra in resultado2)
            {
                Console.WriteLine(letra);
            }

            var resultado3 = from c in nomeCompleto where c == 'R' select c;
            foreach (var letra in resultado3)
            {
                Console.WriteLine(letra);
            }


            var numeros = new int[] { 10, 6, 5, 50, 12, 2 };
            var resultado4 = numeros.Where(p => p >= 10);
            foreach (var numero in resultado4)
            {
                Console.WriteLine(numero);
            }
            
            //Order By---------------------------------------------------------------------------------------------------------
            Console.WriteLine("OrderBy----------------------------------------------------------------------------------------------");
            var numeros2 = new int[] { 10, 6, 5, 50, 12, 2 };
            var resultado5 = numeros2.OrderBy(p => p);
            foreach (var numero in resultado5)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("OrderByDescending----------------------------------------------------------------------------------------------");
            var resultado6 = numeros2.OrderByDescending(p => p);
            foreach (var numero in resultado6)
            {
                Console.WriteLine(numero);
            }
            //Take---------------------------------------------------------------------------------------------------------
            Console.WriteLine("Take----------------------------------------------------------------------------------------------");
            
            var numeros3 = new int[] { 10, 6, 5, 50, 12, 2 };
            var resultado7 = numeros3.Take(3);
            foreach (var paginacao in resultado7)
            {
                Console.WriteLine(paginacao);
            }
            Console.WriteLine("Take Ordenado------------------------------------------------------------------------------------");
            var numeros4 = new int[] { 10, 6, 5, 50, 12, 2 };
            var resultado8 = numeros3.Take(3).OrderBy(p => p);
            foreach (var paginacao2 in resultado8)
            {
                Console.WriteLine(paginacao2);
            }
            
            Console.WriteLine("Take Ordenado e filtrado----------------------------------------------------------------");
            var numeros5 = new int[] { 10, 6, 5, 50, 12, 2 };
            var resultado9 = numeros3.Where(p => p > 10).Take(3).OrderBy(p => p); // Aqui mesmo que eu tenha usado o take para trazer 3 números, ele trás 3 números que atenda o filtro do where.
            foreach (var paginacao3 in resultado9)
            {
                Console.WriteLine(paginacao3);
            }
            
            //Count---------------------------------------------------------------------------------------------------------
            Console.WriteLine("Count------------------------------------------------------------------------------------");
            var numeros6 = new int[] { 10, 6, 5, 50, 12, 2 };

            var resultado10 = numeros6.Count();
            Console.WriteLine(resultado10);
            
            Console.WriteLine("Count com filtro--------------------------------------------------------------------------");
            var numeros7 = new int[] { 10, 6, 5, 50, 12, 2 };
            var resultado11 = numeros.Count(p => p > 10); // vai contar quantos elementos na coleção são maiores do que 10
            Console.WriteLine(resultado11);
            
            //Firt/FirstOrDefault-------------------------------------------------------------------------------------
            Console.WriteLine("Firt/FirstOrDefault---------------------------------------------------------------------");
            var numeros8 = new int[] { 10, 6, 5, 50, 12, 2 };
            var resultado12 = numeros.First(); // irá pegar o primeiro elemento da coleção
            Console.WriteLine(resultado12);
            
            Console.WriteLine("Firt com filtro---------------------------------------------------------------------");
            var numeros9 = new int[] { 10, 6, 5, 50, 12, 2 };
            var resultados13 = numeros9.First(p => p > 15); // Devolve o primeiro item encontrado na coleção que seja maior do que 15
            Console.WriteLine(resultados13);
            
            Console.WriteLine("Firt caindo em Exception---------------------------------------------------------------------");
            try
            {
                var numeros10 = new int[] { 10, 6, 5, 50, 12, 2 };
                var resultados14 = numeros10.First(p => p > 100); // vai gerar uma exceção pois na coleção não existe nenhum item maior que 100.
                Console.WriteLine(resultados14);
            }
            catch (Exception e)
            {
               Console.WriteLine("Caiu na exceção pois não existe elemento na coleção que seja maior do que 100");
            }
            
            Console.WriteLine("FirstOrDefault---------------------------------------------------------------------");
            var numeros11 = new int[] { 10, 6, 5, 50, 12, 2 };
            var resultado15 = numeros11.FirstOrDefault(p => p > 100); // Como não encontrou um elemento que seja maior que 0 na coleção, ele devolve o valor padrão do tipo. No caso do tipo int, o valor padrão é 0
            Console.WriteLine(resultado15);
            
            
            Console.WriteLine("FirstOrDefault onde foi definido o valor padrão caso não seja encontrado----------");
            var numeros12 = new int[] { 10, 6, 5, 50, 12, 2 };
            var resultado16 = numeros12.FirstOrDefault(p => p > 100, -1000); //vai retornar -1000 pois não encontrou nenhum valor maior do que 100 na coleção. Definimos o valor padrão como -1000.
            Console.WriteLine(resultado16);



        }
    }
}