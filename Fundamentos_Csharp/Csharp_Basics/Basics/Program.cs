// See https://aka.ms/new-console-template for more information

namespace Program;

public class Basics
{
    static void Main()
    {
        //Conversão de valor------------------------------------------------------------------------------------------------------------------------------------------------------
        
        int numero = 1;
        int numero1 = int.Parse("1");
        int numero2 = Convert.ToInt32("2");
        int numero3 = Convert.ToInt32(null); // Foi feita uma conversão de null para int, que retorna 0. Então por boa prática é melhor usar o int.parse para converter o valor. Pois o mesmo é mais performatico. Se converter um valor para null retornar 0 for aceitavel para a aplicação, então tudo bem usar o Convert, caso contrario é melhor usar o int.Parse mesmo.
        Console.WriteLine(numero3);
        bool verdadeiro = bool.Parse("true");
        
        var numero4 = "a"; // Pode mudar o valor de numero4 para simular a condição do if abaixo
        
        if (int.TryParse(numero4, out int numero4Convertido)) // O metodo TryParse tenta converter o numero e devolve um booleano. True em caso de sucesso, ou false caso não conseguir converter o número
        {
            Console.WriteLine("Numero convertido com sucesso");
        }
        else
        {
            Console.WriteLine("Não foi possivel converter o número");
        				
        }
        			
        //Strings------------------------------------------------------------------------------------------------------------------------------------------------------
        			
        Console.Write("Digete seu nome completo: ");
        string nome = Console.ReadLine();
        nome = nome.ToLower();
        Console.WriteLine(nome);
        nome = nome.ToUpper();
        Console.WriteLine(nome);

        string nomeArquivo = "2022_12_30_backup.bak";
        string ano = nomeArquivo[..4]; // aqui estamos utilizando range, neste caso irá pegar os 4 primeiros digitos da string nomeArquivo
        Console.WriteLine(ano);
        
        string extensaoArquivo = nomeArquivo[^3..]; // Neste caso vamos pegar os ultimos 3 caracteres da string nomeArquivo
        Console.WriteLine(extensaoArquivo);

        string nomeArquivoSemExtensao = nomeArquivo[..^4]; // Irá retornar a string, com exceção dos ultimos 4 caracteres;
        Console.WriteLine(nomeArquivoSemExtensao);
        
        Console.WriteLine("Contem nome: " + nomeArquivo.Contains("backup")); // Utilizamos o contains para verificar se determinada string contem determinado conteudo. Neste caso, verifiquei se na string nomeArquivo contem a "backup". Este metodo retorna um booleano

        string nomeArquivoFormatado = nomeArquivo.Trim('_'); //aqui iremos remover todos os "_" que contem na string nomeArquivo; Se usarmos o trim com parametro vazio, ele irá remover espaços da string.
        Console.WriteLine(nomeArquivoFormatado);
        
        Console.WriteLine("Inicia com 2022? " + nomeArquivo.StartsWith("2022")); //Vericando se a string nomeArquivo inicia com "2022". Retorna um booleano;
        Console.WriteLine("Termina com .bak? " + nomeArquivo.EndsWith(".bak")); // Verificando se a string nomeArquivo termina com ".bak". Retorna um booleano.

        string nomeArquivoExtensaoPDF = nomeArquivo.Replace(".bak", ".pdf"); // O replace tenta encontrar o valor mecionado na primeira propriedade do parametro, neste caso ".bak", se encontrar substitui por um novo valor ".pdf". Se não encontrar, não faz nada e também não retorna erro.
        Console.WriteLine(nomeArquivoExtensaoPDF);
        
        Console.WriteLine(nomeArquivoExtensaoPDF.Length); //retorna a quantidade de caracteres que possuim na string nomeArquivoExtensaoPDF, incluido caracteres especiais, espaços... Qualquer conteudo presente na string, conta como caractere.

    }
}