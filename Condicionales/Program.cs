using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bandera = true;

            if (bandera) {
                Console.WriteLine("Variable verdadera");
            }

            if (!bandera)
            {
                Console.WriteLine("Variable falsa");
            }

            int a = 60, b= 30, c = 9;

            if(a > b) //A es mayor
            {
                if(a > c) { //A es mayor
                    Console.WriteLine("A es mayor");
                }
                else //C es mayor
                {
                    Console.WriteLine("C es mayor");
                }
            } else //B es mayor
            {
                if (b > c) //B es mayor
                { 
                    Console.WriteLine("B es mayor");
                }
                else //C es mayor
                {
                    Console.WriteLine("C es mayor");
                }
            }

            int opcion = 5;

            switch (opcion) {
                case 0:
                    Console.WriteLine("Opcion 0");
                    break;
                case 1:
                    Console.WriteLine("Opcion 1");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

            String opcionStr = "A";

            switch (opcionStr)
            {
                case "A":
                    Console.WriteLine("Opcion A");
                    break;
                case "B":
                    Console.WriteLine("Opcion B");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
            Console.Read();
        }
    }
}
