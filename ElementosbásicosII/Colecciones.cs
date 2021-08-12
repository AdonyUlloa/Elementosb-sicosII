using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosbásicosII
{
    class Colecciones
    {
        static void Main(string[] args)
        {
            //Diccionario
            //almacena pares de datos claves y valor
            //definir un dicionario
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            //agregar elementos al dicionario
            EmployeeList.Add("Jose Flores", "Programador");
            EmployeeList.Add("Miranda Campos", "Gerente");
            EmployeeList.Add("Carmen Valladares", "Arquitencta");

            Dictionary<string, int> Students = new Dictionary<string, int>();
            Students.Add("Jose Flores", 20);
            Students.Add("Miranda Campos", 20);
            Students.Add("Carmen Valladares", 20);


            //leer el dicionario y mostrar los datos
            foreach (KeyValuePair<string, string> empleyee in EmployeeList)
            {
                Console.WriteLine("Clave: {0},  Valor: {1}", empleyee.Key, empleyee, empleyee.Value);
            }


            //ordenar elementos del diccionario
            var dic = EmployeeList.Keys.ToList();
            dic.Sort();

            Console.WriteLine("Diccionario ordenado");
            foreach (var item in dic)
            {
                Console.WriteLine("{0}: {1}", item, EmployeeList[item]);
            }

            //Contar elementos de un dicionario
            Console.WriteLine("Elementos en el diccionario: {0}", EmployeeList.Count);

            Console.ReadKey();
        }

    }
}
