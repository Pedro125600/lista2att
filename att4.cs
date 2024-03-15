using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2;

            Console.WriteLine("Escolha um numeros");

            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha outro numeros");

            n2= double.Parse(Console.ReadLine());



            Console.WriteLine("escolha a operação + - * ou /");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+': n1 += n2;
                    break;
                case '-':
                   n1 -= n2;
                    break;
                case '*':
                     n1 *= n2;
                    break;
                case '/': if (n2 == 0)
                    {
                        Console.WriteLine("Erro");
                        n1 = 0;
                    }
                else
                    {
                       n1 /= n2;
                    }
                    break;
                default:Console.WriteLine("Operação invalida");
                    break;
            }
            
            Console.WriteLine("Resultado :" + n1 );
            Console.ReadLine();
        }
    }
}
