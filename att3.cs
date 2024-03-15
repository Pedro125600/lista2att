using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Informa sua habilitação");
            char ab = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantos anos tem a habilitação");
            int an = int.Parse(Console.ReadLine());

            if (id < 21)
            {

                Console.WriteLine("Menor de 21 anos não pode tirar carteira D");

            }

            if (ab == 'C' || ab == 'B')
            { 
            }
            else
            {
                Console.WriteLine("Categoria diferente de C ou B");
            }

          



            if (an < 2 && ab == 'B')
            {
                Console.WriteLine("E necessario ter 2 anos com a habilitação B para tirar D");
            }

            else if (an < 2 && ab == 'B')
            {
                Console.WriteLine("E necessario ter 1 anos com a habilitação C para tirar D");

            }

            if (id >= 21 && ( ab == 'C' && an > 1) || (ab=='B' && an >2))
            {
                Console.WriteLine("Pode tirar categoria D");

            }

            Console.ReadLine();


        }
    }
}
