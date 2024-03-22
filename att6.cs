using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite quatro números inteiros positivos (w, x, y e z): O valor de W sera o tipo de media que deseja calcular, sendo 1 para media geometrica, 2 para media ponderada ,3  harmonica e 4 arimetica");

        int w = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        double resp = 0;
        switch (w)
        {
            case 1:
                resp = Math.Sqrt(x * y * z);
                break;
            case 2:
                resp = (x + 2 * y + 3 * z) / 6;
                break;
            case 3:
                resp = 1 / (1 / x + 1 / y + 1 / z);
                break;
            case 4:
                resp = (x + y + z) / 3;
                break;
            default:
                Console.WriteLine("Numero Invalido");
                break;
        }


        Console.WriteLine("O resultado e : " + resp);

        Console.ReadLine();
    }
}