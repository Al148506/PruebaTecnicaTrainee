//Interfaz Inicial del programa
using PruebaTecnicaTrainee;
using System;
using System.Linq.Expressions;
using System.Security.Cryptography;
bool flag = false;
char[,] asientos = new char[10, 10];
int min = 1;
int max = 10;
Metodos.llenarAsientos(asientos);
while (!flag)
{
    Console.WriteLine("Bienvenido al sistema de reservacion");
    Console.WriteLine("Por favor seleccione una opcion");
    Console.WriteLine("1. Reservar");
    Console.WriteLine("2. Ver reservaciones");
    Console.WriteLine("3. Salir");
    int opcion = Convert.ToInt32(Console.ReadLine());
    int opcionIntento = 0;
    switch (opcion)
    {
        case 1:
            do
            {
                Console.WriteLine("Introduce la fila del asiento que quieres reservar");
                int fila = Metodos.LeerEntrada(min,max ) - 1;
                Console.WriteLine("Introduce la columna del asiento que quieres reservar");
                int columna = Metodos.LeerEntrada(min, max) - 1;

                if (asientos[fila, columna] == 'l')
                {
                    asientos[fila, columna] = 'x';
                    Console.WriteLine("El asiento se ha reservado de forma exitosa");
                    Console.WriteLine("Oprima 1 si quiere resevar otro asiento o cualquier otra tecla si desea volver al menu principal");
                    opcionIntento = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("El asiento no esta disponible, oprima 1 si quiere resevar otro asiento o cualquier otra tecla si desea volver al menu principal");
                    opcionIntento = Convert.ToInt32(Console.ReadLine());
                    if (opcionIntento == 1)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            } while (opcionIntento == 1);

            break;
        case 2:
            Metodos.mostrarAsientos(asientos);
            Console.WriteLine();
            break;
        case 3:
            flag = true;
            break;
        default:
            Console.WriteLine("Seleccione una opcion valida");
            break;
    }
}

