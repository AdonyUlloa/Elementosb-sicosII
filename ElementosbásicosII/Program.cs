using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosbásicosII
{
    class Program
    {
        private static int inc;

        static void Main(string[] args)
        {
            //Llamado al metodo loops
            loops();

            Console.ReadLine();
        }

        //Bucles
        public static void loops()
        {
            //escribir un ciclo que permita capturar los valores
            //a almacenar en el arreglo de numbers con un tamaño de 10

            int[] numbers = new int[10];

            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Escriba el valor del elemento {0}:  ", x);
                numbers[x] = Convert.ToInt32(Console.ReadLine());
            }



            //ciclo white
            int i = 0;
            Console.WriteLine("IMPRIMIR ELEMENTOS CON WHITE");
            while (10 < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i=i+1; //i++
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
                
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (10 < numbers.Length);

            Console.WriteLine("IMPRIME ELEMENTOS CON FOR" );
            for (int j=0; j <  numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);
            }

            Console.WriteLine("IMPRIMIR ELEMENTOS CON FOREACH");
            foreach (int iteam in numbers)
            {
                Console.WriteLine(iteam);
            }



        }
    }
}
