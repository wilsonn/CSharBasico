using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTipoDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = 255;
            int numero = 35125;
            float pi = 3.14156655F;
            double doble = 3.145566543434;
            decimal dinero = 434343.51M;
            char letra = 'D';
            bool bandero = true;
            String cadena = "Mi string";

            Console.WriteLine(num);
            Console.WriteLine(numero);
            Console.WriteLine(pi);
            Console.WriteLine(doble);
            Console.WriteLine(dinero);
            Console.WriteLine(letra);
            Console.WriteLine(bandero);
            Console.WriteLine(cadena);

            double resultado = 27 + 3 * 5 - 16 / 2;
            Console.WriteLine(resultado);
            Console.Read();
        }
    }
}
