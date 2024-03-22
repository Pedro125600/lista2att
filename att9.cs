using System;

class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Digite um número entre 0 e 4:");
      int numero = int.Parse(Console.ReadLine());

      switch (numero)
      {
          case 0:
              Console.WriteLine("Zero");
              break;
          case 1:
              Console.WriteLine("Um");
              break;
          case 2:
              Console.WriteLine("Dois");
              break;
          case 3:
              Console.WriteLine("Três");
              break;
          case 4:
              Console.WriteLine("Quatro");
              break;
          default:
              Console.WriteLine("Valor inválido");
              break;
      }
        Console.Readline;
    }
}