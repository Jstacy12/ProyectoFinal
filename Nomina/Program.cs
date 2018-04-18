using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Johan De Los santos - 10-SISN-1-011 - 0908
            // Arthur Henriquez - 12-EISN-1-214 - 0908

            string nombre;
            int salario, horasTrabajadas, SalarioHora, SalarioMinimo;

            Console.WriteLine("Ingrese su nombre");
             nombre = Console.ReadLine();
            Console.WriteLine("Ingrese cuantas horas trabajó: ");
            horasTrabajadas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de las horas: ");
            SalarioHora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el salario minimo: ");
            SalarioMinimo = Convert.ToInt32(Console.ReadLine());

            string estudiante1 = "Johann De Los Santos";
            string matricula1 = "10-SISN-1-011";

            string estudiante2 = "Arthur Henriquez";
            string matricula2 = "12-EISN-1-214";


            salario = horasTrabajadas * SalarioHora;

            if(salario > SalarioMinimo)
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Salario menusal: " + salario + "\n");
            }

            if( salario < SalarioMinimo)
            {
                Console.WriteLine("Nombre: " + nombre + "\n");
            }

            if(salario == SalarioMinimo)
            {
                Console.WriteLine("Nombre: " + nombre + "\n");
                Console.WriteLine("Salario: " + salario + "que es igual al valor del salario minimo: " + SalarioMinimo + "\n");
            }

            Console.WriteLine(estudiante1 + "" + matricula1 );
            Console.WriteLine(estudiante2 + "" + matricula2 );


            Console.ReadKey();

        }
    }
}
