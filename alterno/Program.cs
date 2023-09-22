using System;

namespace alterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un
            //número negativo, el programa debe finalizar y mostrar en consola la cantidad total de
            //números positivos que ingresó hasta antes de ingresarse el número negativo.

            // declaracion de variables
            int num, conteo = 0;

            Console.WriteLine("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            while(num >= 0)
            {
                conteo++;
                Console.WriteLine("Ingrese un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Format("la cantidad de numeros positivos es {0}", conteo));

        }

    }
}
