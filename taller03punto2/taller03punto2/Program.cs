using System;

class Program
{
    static void Main(string[] args)
    { 
        //limite
        int N = 11;
        //matriz
        int[,] matriz = new int[N, N];
        //numeros relleno
        int numero = 1;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = numero;
                numero++;
            }
        }
            Console.WriteLine("matriz completa");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.WriteLine() ;

            Console.WriteLine("El Reloj");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0 ; j < N ; j++)
                {
                    if (j >= i && j < N - i || j <= i && j >= N - i - 1)

                    {
                       Console.Write(matriz[i,j].ToString().PadLeft(4));
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        
    }
}