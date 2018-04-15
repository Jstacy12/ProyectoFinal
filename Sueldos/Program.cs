using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldos
{
    class Operarios
    {
        int cantidad;
        string estudiante1 = "Johann De Los Santos";
        string matricula1 = "10-SISN-1-011";

        string estudiante2 = "Arthur Henriquez";
        string matricula2 = "12-EISN-1-214";
        private int[] sueldos;
        public Operarios()
        {
            Console.Write("Cuantos sueldos quieres ingresar? ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            sueldos = new int[cantidad];
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.Write("Ingrese el sueldo " + (f + 1) + ": ");
                string linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Los Sueldos Ingresados.");
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f] + "\n" );
            }
            Console.WriteLine(estudiante1 + "" + matricula1);
            Console.WriteLine(estudiante2 + "" + matricula2);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            // Johan De Los santos - 10-SISN-1-011 - 0908
            // Arthur Henriquez - 12-EISN-1-214 - 0908

            Operarios op = new Operarios();
            op.Imprimir();
        }
    }
}

