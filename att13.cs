using System;

class Program
{
    public static void Main(string[] args)
    {
   
            Console.WriteLine("Digite um ano");

            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine  (((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0)) ? "Ano bissexto" : "Ano não e bissexto");

            Console.ReadLine();
}
