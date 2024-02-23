using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {

        ///exercicio 6
        double xx =1.23456;
        int ii = 19;
        Console.WriteLine($"{xx:f2}" + " " + $"{xx,p1}" + " " + $"{ii,X}"
         + " " + $"{ii,C}"); 
        //formatação de string com variáveis e valores


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
