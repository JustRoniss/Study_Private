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
        
    }
}