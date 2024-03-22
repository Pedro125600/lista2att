using System;

class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Digite uma letra:");
      char letra = char.Parse(Console.ReadLine());

      switch (letra)
      {
          case 'a':
              Console.WriteLine("é uma vogal.");
              break;
               case 'e':
              Console.WriteLine("é uma vogal.");
              break;
               case 'i':
              Console.WriteLine("é uma vogal.");
              break;
               case 'o':
              Console.WriteLine("é uma vogal.");
              break;
               case 'u':
              Console.WriteLine("é uma vogal.");
              break;
          default:
              Console.WriteLine("é uma consoante.");
              break;
      }
    }
}
