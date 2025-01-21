﻿//Interfaz Inicial del programa
using PruebaTecnicaTrainee;
bool flag = false;
char[,] asientos = new char[10, 10];
Metodos.llenarAsientos(asientos);
while (!flag)
{
    Console.WriteLine("Bienvenido al sistema de reservacion");
    Console.WriteLine("Por favor seleccione una opcion");
    Console.WriteLine("1. Reservar");
    Console.WriteLine("2. Ver reservaciones");
    Console.WriteLine("3. Salir");
    int opcion = Metodos.leerEntrada(1, 3);
    switch (opcion)
    {
        case 1:
            Metodos.reservarAsiento(asientos);
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

