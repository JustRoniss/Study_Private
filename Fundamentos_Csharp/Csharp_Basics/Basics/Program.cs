// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;

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

        
        //Datas------------------------------------------------------------------------------------------------------------------------------------------------------

        var date1 = new DateTime(2012, 12, 02);
        var date2 = new DateTime(2016, 05, 23, 21, 05, 43);
        var date3 = DateTime.Parse("2022/12/22 19:15:58");

        var date4 = DateTime.Now;
        Console.WriteLine(date4);
        var date5 = DateTime.Today;
        Console.WriteLine(date5);

       Console.WriteLine(date3.ToString("dd-MM-yyyy"));
       Console.WriteLine(date3.ToString("dd/MM/yyyy"));
       Console.WriteLine(date3.ToString("dd*MM*yyyy"));
       Console.WriteLine(date3.ToString("yyyy"));

       var dataOffSet1 = new DateTimeOffset(date2, new TimeSpan(-3, 0, 0));
       Console.WriteLine(dataOffSet1.LocalDateTime);
       Console.WriteLine(dataOffSet1.UtcDateTime);
       
       //SUBTRAINDO DATA

       var date6 = DateTime.Now;
       var date7 = DateTime.Parse("2022-01-01");

       var diff = date6 - date7;
       Console.WriteLine(diff.TotalDays);
       Console.WriteLine((int)diff.TotalDays);

       var diff2 = date6.Subtract(date7);
       Console.WriteLine(diff2);
       Console.WriteLine((int)diff2.TotalDays);
       
       
       //ADICIONANDO DATA

       var date8 = DateTime.Now;
       Console.WriteLine(date8.AddDays(7).ToString("dd-MM-yyyy"));
       Console.WriteLine(date8.AddMonths(7).ToString("dd-MM-yyyy"));
       Console.WriteLine(date8.AddYears(7).ToString("dd-MM-yyyy"));
       
       Console.WriteLine(date8.AddHours(2).ToString("HH:mm:ss"));
       Console.WriteLine(date8.AddMinutes(30).ToString("HH:mm:ss"));
       Console.WriteLine(date8.AddSeconds(60).ToString("HH:mm:ss"));
       
       
       // Recuperar dia da semana de uma data. O idioma exibido é o idioma do sistema operacional.
       Console.WriteLine(date8.DayOfWeek);
       Console.WriteLine(date2.DayOfWeek);
       

        //DateOnly

        var somenteData1 = new DateOnly(2022,12,2);
        var somenteData2 = DateOnly.Parse("2022-12-01");
        
        Console.WriteLine(somenteData1.ToString("dd/MM/yyyy"));
        
        //TimeOnly

        var somenteHora1 = new TimeOnly(23, 40, 00);
        var somenteHora2 = TimeOnly.Parse("23:40:00");
        Console.WriteLine(somenteHora1);
        Console.WriteLine(somenteHora2.ToString("HH:m:s"));
        
        //Exception------------------------------------------------------------------------------------------------------------------------------------------------------
        
        /* Exceções basicamente são os erros que acontecem em seu programa em tempo de execução e são capturados por um mecanismo do .NET chamado exceptions, por meio de
         * uma exception/exceção é possível inclusive, saber em qual linha de código ocorreu o erro, tornando mais fácil a identificação e solução do problema. */
        
        
        // Gerando uma Exception

        while (true)
        {
            Console.Write("Informe um número(número 0 irá gerar uma exceção): ");
            var numeroInput = Console.ReadLine();
            var resultado = 10 / int.Parse(numeroInput);
            Console.WriteLine(resultado);
            System.Threading.Thread.Sleep(1000);
            Console.Write("[Digite] 1 para sair do loop ou qualquer tecla para continuar: ");
            var sair = int.Parse(Console.ReadLine());
            if (sair == 1) break;
            
        } // Ao digitar 0, irá gerar uma exceção automaticamente pelo .NET, afinal não é possivel dividir um número por 0. Quando uma Exception acontece, e não existe um tratamento para mesma, o progroma é encerrado.
        
        //Tratando uma Exception
        Console.WriteLine("Você saiu do primeiro Loop, agora está num loop com tratamento da exceção");
        while (true)
        {
            try
            {
                
                Console.Write("Informe um número(número 0 irá gerar uma exceção): ");
                var numeroInput = Console.ReadLine();
                var resultado = 10 / int.Parse(numeroInput);
                Console.WriteLine(resultado);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("[Digite] 1 para sair do loop ou qualquer tecla para continuar");
                var sair = int.Parse(Console.ReadLine());
                if (sair == 1) break;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Você caiu na trativa de exceção pois digitou 0 " + exception.Message + exception.StackTrace);
            }
        }
        
        

    }
}