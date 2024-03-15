using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Imprima um numero entre 0 e 5");
            int n1 = int.Parse(Console.ReadLine());

                switch(n1)
                {
                    case 1: Console.WriteLine("Um");
                        break;
                    case 2: Console.WriteLine("Dois");
                        break;
                    case 3: Console.WriteLine("tres");
                        break;
                    case 4: Console.WriteLine("Quatro");
                        break;
                    case 5: Console.WriteLine("Cinco");
                        break;
                    default: Console.WriteLine("Valor inválido");
                    break;
                }


            Console.ReadLine();

        }
    }
}
