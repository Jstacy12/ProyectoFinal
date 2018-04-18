using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_positivos
{
    class Program
    {


        static void Main(string[] args)
        {
            // Johan De Los santos - 10-SISN-1-011 - 0908
            // Arthur Henriquez - 12-EISN-1-214 - 0908


            int n, valor, positivos, negativos, pares, impares, ciclo;
            positivos = 0;
            negativos = 0;
            pares = 0;
            impares = 0;
            ciclo = 0;
            string linea;
            Console.Write("Ingrese valor de n: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            string estudiante1 = "Johann De Los Santos";
            string matricula1 = "10-SISN-1-011";

            string estudiante2 = "Arthur Henriquez";
            string matricula2 = "12-EISN-1-214";


            try
            {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write("Ingrese numero " + i + ": ");
                        linea = Console.ReadLine();
                        valor = int.Parse(linea);
                        if (valor > 0)
                        {
                            positivos++;
                        }
                        else
                        {
                            if (valor < 0)
                            {
                                negativos++;
                            }
                        }
                        if (valor % 2 == 0)
                        {
                            pares++;
                        }
                        else
                        {
                            if (valor % 2 != 0)
                            {
                                impares++;
                            }
                        }
                    }

                    for( int k = 0; k <= n; k++)
                {
                    ciclo = k++;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Numero invalido" + ex);
            }

            Console.WriteLine("Cantidad de numeros negativos: " + negativos);
            Console.WriteLine("Cantidad de numeros positivos: " + positivos);
            Console.WriteLine("Cantidad de numeros pares: " + pares);
            Console.WriteLine("Cantidad de numeros impares: " + impares);
            Console.WriteLine("Las veces que se ejecutó el ciclo for fueron: " + ciclo + "\n");

            Console.WriteLine(estudiante1 + " " + matricula1);
            Console.WriteLine(estudiante2 + " " + matricula2);
            Console.ReadKey();
        }
    }
}
        