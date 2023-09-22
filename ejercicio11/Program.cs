using System;

namespace ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un
            //número negativo, el programa debe finalizar y mostrar en consola la cantidad total de
            //números positivos que ingresó hasta antes de ingresarse el número negativo.

            //1 definir las variables.

            int n;
            int contador = 0;
            bool positivo = true;

            // captura de datos
            do
            {
                Console.WriteLine("Ingrese un numeros: ");
                n = Convert.ToInt32(Console.ReadLine());
                // calculos
                if (n > 0)
                {
                    contador++;
                }
                else
                {
                    positivo = false;
                }
            } while (n > 0);

            //mostrar resusltados

            Console.WriteLine($"la cantidad de numeros positivos es: {contador},");
                                   
        }
    }
}
