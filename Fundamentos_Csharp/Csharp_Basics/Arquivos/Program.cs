// See https://aka.ms/new-console-template for more information

namespace Arquivos
{
    public class Program
    {

        public static void Main()
        {
            var escrever =
                new StreamWriter(
                    @"/home/justronis/Developer/Study_Private/Fundamentos_Csharp/Csharp_Basics/Arquivos/cadastro.txt",
                    true); // O append verifica se o arquivo já esta criado, se for o caso ele adiciona o conteúdo ao final do arquivo

            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();
            escrever.WriteLine("ID - " + Random.Shared.Next(1, 100));
            escrever.WriteLine("Nome - " + nome);
            escrever.WriteLine("---------------------------------");
            escrever.Close();


            //Ler-----------------------------------------------------------------------------------------

            var ler = File.ReadAllText(
                @"/home/justronis/Developer/Study_Private/Fundamentos_Csharp/Csharp_Basics/Arquivos/cadastro.txt");
            Console.WriteLine(ler);

            var ler2 = new StreamReader(
                @"/home/justronis/Developer/Study_Private/Fundamentos_Csharp/Csharp_Basics/Arquivos/cadastro.txt");

            while (!ler2.EndOfStream) // Enquanto não chegar ao final do arquivo, continua no loop
            {
                var linha = ler2.ReadLine();
                Console.WriteLine(linha);
                System.Threading.Thread.Sleep(500);
            }
            
            //Excluir-----------------------------------------------------------------------------------------

            if (File.Exists(
                    @"/home/justronis/Developer/Study_Private/Fundamentos_Csharp/Csharp_Basics/Arquivos/cadastro.txt"))
            {
                File.Delete(@"/home/justronis/Developer/Study_Private/Fundamentos_Csharp/Csharp_Basics/Arquivos/cadastro.txt");
            }



        }

    }

}

