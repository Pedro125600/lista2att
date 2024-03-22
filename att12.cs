using System;

class Program
{
    public static void Main(string[] args)
    {
  Console.Write("Digite a altura em metros: ");
  double al = double.Parse(Console.ReadLine());

  Console.Write("Digite o sexo (F/M): ");
  char sexo = Char.Parse(Console.ReadLine());

  double peso = sexo == 'M' ? (72.7 * al) - 58 : (62.1 * al) - 44.7;

  Console.WriteLine("O peso ideal :" + peso);

      Console.ReadLine();
}
