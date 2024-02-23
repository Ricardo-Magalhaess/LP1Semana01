using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
           ///Variaveis inteiras
           int num_inteiro = 8;
           short short_int = 10;
           sbyte sigma = 6;
           Console.WriteLine( num_inteiro + "" + short_int + "" + sigma);
           ///Variaveis char
           char estrela = '\u2605';
           char simbolo = '\u2742';
           Console.WriteLine("" + estrela + " " + simbolo);
           ///Variaveis reais 
           float flauta = 30;
           double dobro = 60;
           decimal dinheiro = 90;
           Console.WriteLine( flauta + "" + dobro + "" + dinheiro);
           ///Variaveis booleanas
           bool mentira = false;
           bool verdade = true;
           Console.WriteLine(mentira + "" + verdade);
        }
    }
}
