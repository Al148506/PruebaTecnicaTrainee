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
        public static int LeerEntrada(int min, int max)
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
        public static void llenarAsientos (char[,] asientos)
        {
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos.GetLength(1); j++)
                {
                    asientos[i, j] = 'l';
                }
            }
        }

    }
}
