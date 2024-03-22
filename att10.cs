using System;

class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Escolha uma opção de conversão:");
      Console.WriteLine("1. Converter de centímetros para metros");
      Console.WriteLine("2. Converter de metros para centímetros");
      Console.WriteLine("3. Converter de milímetros para metros");
      Console.WriteLine("4. Converter de metros para milímetros");

      int opcao = int.Parse(Console.ReadLine());

      double v;
      double r;

      switch (opcao)
      {
          case 1:
              Console.WriteLine("Digite o valor em centímetros:");
              v = Double.Parse(Console.ReadLine());
              r = v / 100;
              Console.WriteLine("centímetros para metros:" + r);
              break;
          case 2:
              Console.WriteLine("Digite o valor em metros:");
              v = Double.Parse(Console.ReadLine());
              r = v * 100;
              Console.WriteLine(" metros para centímetros:" + r);
              break;
          case 3:
              Console.WriteLine("Digite o valor em milímetros:");
              v = Double.Parse(Console.ReadLine());
              r = v / 1000;
              Console.WriteLine(" milímetros para metros." + r);
              break;
          case 4:
              Console.WriteLine("Digite o valor em metros:");
              v = Double.Parse(Console.ReadLine());
              r = v * 1000;
              Console.WriteLine(" Metros para Milimetros : " + r);
              break;
          default:
              Console.WriteLine("Opção Inválida");
              break;
      }
        Console.Readline;
    }
}