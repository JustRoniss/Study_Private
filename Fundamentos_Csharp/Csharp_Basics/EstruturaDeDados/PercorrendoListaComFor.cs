using System.Net.Http.Headers;

namespace EstruturaDeDados;

public class PercorrendoListaComFor
{
    public static void percorreLista()
    {
        var lista = new List<string>()
        {
            "ronaldo", "luiz", "curso"
        };

        for (var i = 0; i < lista.Count; i++)
        {
            var item = lista[i];
            Console.WriteLine(item);
        }
        
    }
}

