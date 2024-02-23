using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
        ///Variaveis tipo string
        string s = "Bom dia Armindo, \t  olha uma estrela \u2605";
        string a = "\u2742";
        string z = "Bom dia Jorge";
        Console.WriteLine( s + " " + a + " " + z );
        ///Mais variaveis do tipo string
        string conc = "Um" + "Dois" + "tres";
        string interp = $"valor de x e' {x}";
        Console.WriteLine(conc + " " + interp);
        }
    }
}
