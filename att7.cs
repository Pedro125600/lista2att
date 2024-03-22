using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número:");
          int numero = int.Parse(Console.ReadLine());

          if (numero % 3 == 0 && numero % 5 == 0)
          {
              Console.WriteLine("Numero e divisivel por 3 e 5");
          }
          else
          {
              Console.WriteLine(" Numero não é divisível por 3 e por 5.");
          }

        Console.Readline;
    }
}