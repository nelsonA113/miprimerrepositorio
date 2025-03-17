using System;

class Program
{
    static void Main()
    {
        //variable de solicitud
        Console.Write("introduce el tamaño (n) de la matriz: ");
        int n = int.Parse(Console.ReadLine());
        //matriz y relleno mediante formula celda
        int[,] matriz = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
               matriz[i, j] = i + j;
            }
        }
        //print matriz llena
        Console.WriteLine("\nMatriz llenna" );
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
        //print triangulo
        Console.WriteLine("\ntriangular inferior");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j <= i )
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                else
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }
    }
}
