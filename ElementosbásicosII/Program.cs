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
            //2 - Calcular el promedio de los numeros almacenados en un array


            int[] numbers = new int[10];
            int sumatoria=0;  //almacena los datos de sumatoria

            /*numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;*/

            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Escriba el valor del elemento {0}:  ", x);
                numbers[x] = Convert.ToInt32(Console.ReadLine());
            }



            //ciclo white
            int i = 0;
            Console.WriteLine("IMPRIMIR ELEMENTOS CON WHITE");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i=i+1; //i++
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;  
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (inc < numbers.Length);

            Console.WriteLine("IMPRIME ELEMENTOS CON FOR  - ARREGLO  ORDENADO" );
            //llamada a la  clase  Array  y al metodo sort
            Array.Sort(numbers); //el metodo sort permite  ordenar  los valores  dentro  de un array
            for (int j=0; j <  numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);

                //sumar los valores dentro del array
                //samatoria = 
                sumatoria = sumatoria + numbers[j];
                //Console.WriteLine(sumatoria);
            }

            Console.WriteLine("IMPRIMIR ELEMENTOS CON FOREACH - ARREGLO  INVERTIDO");
            Array.Reverse(numbers); //reverse pemite invertir  los valores dentro de un array
            foreach (int iteam in numbers)
            {
                Console.WriteLine(iteam);
            }


            Console.WriteLine("EL VALOR PROMEDIO es IGUAL {0} ", sumatoria/(numbers.Length));

        }
    }
}
