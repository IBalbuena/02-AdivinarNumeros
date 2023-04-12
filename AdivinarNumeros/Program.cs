using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarNumeros
{
internal class Program
{
    static void Main(string[] args)
    {
        // Instanciamos random y le damos valor.
        Random numeroRandom = new Random();
        int random = numeroRandom.Next(0,101);

        int i=0;
        int numero;

        // No saldrá del bucle hasta cuatro intentos.
        while (i < 4)
        {
            Console.WriteLine("Adivina el número entre 0 y 100.");
            Console.WriteLine("--- Intento " + (i + 1) + " ---");

            try { 
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero<0 || numero>100)
                {
                    Console.WriteLine("El número tiene que estar entre 0 y 100");
                   
                }

            if (numero == random)
            {
                Console.WriteLine("¡¡¡¡Has acertado!!!! :)");
                break;
            } else
            {
                Console.WriteLine("Intentelo de nuevo");
                Console.WriteLine();
            }
        } catch (FormatException)
            {
                Console.WriteLine("Formato no válido, tiene que ser un número");
                Console.WriteLine();
            }

            i++;
        }

        if (i == 4)
        {
            Console.WriteLine("Lo siento, ya no hay más intentos :( \nEl número secreto es: " + random );
        }
    }
}
}
