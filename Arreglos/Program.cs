using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            numeros = new int[10];

            numeros[0] = 1;
            numeros[1] = 2;

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Posicion " + i + ": " + numeros[i]);
            }
           

            int[] otroNumeros = { 1, 2, 3, 4, 5 };
            int resultado = 0;
            for(int i = 0; i<otroNumeros.Length; i++)
            {
                resultado += otroNumeros[i];
            }

       

            int[,] numeroMultidimencional = new int[10, 8];

            Random r = new Random();

            for(int x=0; x < 10; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    numeroMultidimencional[x, y] = r.Next(0, 9);
                    Console.Write(numeroMultidimencional[x, y] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
