using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while(1<1)
            {
                Console.WriteLine("Hola");
            }*/

            int numero = 1;
            while (numero < 5)
            {
                Console.WriteLine("Hola");
                numero++;
            }

            int limite=10, numero2 = 1;
            while (numero2 < limite)
            {
                if(numero2 % 2 == 0)
                {
                    Console.WriteLine(numero2 + " Es par");
                } else if (numero2 % 2 == 1)
                {
                    Console.WriteLine(numero2 + " Es impar");
                }

                numero2++;
            }

            int valor = 10;
            do
            {
                Console.WriteLine(valor);
                valor++;
            } while (valor < 10);

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("xxxxx: " + i);
            }

            Console.Read();
        }
    }
}
