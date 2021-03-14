using System;

namespace Aula_de_PC1_Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            string leet;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Faça um recado para ser codificado em Leet Speak!");
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Digite seu recado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            leet = Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Aperte qualquer tecla para ver seu recado codificado: ");
            Console.ReadKey();
            Console.Clear();
            //Um código muito longo nem sempre é bom, mas linhas extensas são piores, dividir ajuda a localizar!//
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(leet
            .Replace("A","4")
            .Replace("a","4")
            .Replace("E","3")
            .Replace("e","3")
            .Replace("I","1")
            .Replace("i","1")
            .Replace("L","1")
            .Replace("l","1")
            .Replace("O","0")
            .Replace("o","0")
            .Replace("T","7")
            .Replace("t","7")
            .Replace("S","5")
            .Replace("s","5"));
            Console.ResetColor();
        }
    }
}
