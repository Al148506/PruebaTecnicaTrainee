using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaTrainee
{
    public static class Metodos
    {
        public static void mostrarAsientos(char[,] asientos)
        {
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos.GetLength(1); j++)
                {
                    Console.Write($"| {asientos[i, j]} |");
                }
                Console.WriteLine();
            }
        }
        public static int leerEntrada(int min, int max)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int entrada) && entrada >= min && entrada <= max)
                {
                    return entrada;
                }
                Console.WriteLine($"Por favor, introduzca un número válido entre {min} y {max}:");
            }
        }
        public static void llenarAsientos(char[,] asientos)
        {
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos.GetLength(1); j++)
                {
                    asientos[i, j] = 'l';
                }
            }
        }

        public static void reservarAsiento(char[,] asientos)
        {
            bool reservando = true;
            while (reservando)
            {
                Console.Clear();
                Console.WriteLine("Reservación de asientos");
                Console.Write("Introduce la fila del asiento (1-10): ");
                int fila = leerEntrada(1, asientos.GetLength(0)) - 1;

                Console.Write("Introduce la columna del asiento (1-10): ");
                int columna = leerEntrada(1, asientos.GetLength(1)) - 1;

                if (asientos[fila, columna] == 'l')
                {
                    asientos[fila, columna] = 'x';
                    Console.WriteLine("El asiento se ha reservado de forma exitosa.");
                }
                else
                {
                    Console.WriteLine("El asiento no está disponible.");
                }

                Console.WriteLine("¿Desea reservar otro asiento? (s/n)");
                string? respuesta = Console.ReadLine()?.ToLower();
                reservando = respuesta == "s";
            }

        }
    }
}
