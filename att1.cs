using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma idade");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outra idade");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outra idade");
            int n3 = int.Parse(Console.ReadLine());


            if ( n1 > n2 && n1 > n3)
            {
                Console.WriteLine("A maior idade e " + n1);

                if ( n2 < n3)
                {
                    Console.WriteLine("A menor idade e " + n2);
                }

                else
                {
                    Console.WriteLine("A menor idade e " + n3);
                }
            }

            else if (n2 > n3)
            {
                Console.WriteLine("A maior idade e " + n2);

                if (n1 < n3)
                {
                    Console.WriteLine("A menor idade e " + n1);
                }

                else
                {
                    Console.WriteLine("A menor idade e " + n3);
                }
            }

            else
            {
                Console.WriteLine("A maior idade e " + n3);

                if (n1 < n2)
                {
                    Console.WriteLine("A menor idade e " + n1);
                }

                else
                {
                    Console.WriteLine("A menor idade e" + n2);
                }
            }




            Console.ReadLine();

        }
    }
}
