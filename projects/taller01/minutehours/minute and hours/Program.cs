using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingrese un número para la hora (0-23): ");
        int hour = Convert.ToInt32(Console.ReadLine());

        Console.Write("Por favor, ingrese un número para los minutos (00-59): ");
        int minute = Convert.ToInt32(Console.ReadLine());

        Console.Write("Por favor, ingrese un número para los segundos (00-59): ");
        int second = Convert.ToInt32(Console.ReadLine());

        Console.Write("Por favor, ingrese un número para los milisegundos (0-999): ");
        int millisecond = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Es AM o PM?: ");
        string amPm = Console.ReadLine().ToUpper();
        if (amPm != "AM" && amPm != "PM")
        {
            Console.Write("porfavor ingresa el termino correcto");
        }
        


        Console.WriteLine($"la hora es:hora {hour}, minuto: {minute}, segundo: {second}, milisegundo: {millisecond}, horario: {amPm}");
        Console.Write("el dia es al otro dia");
        if (amPm != "AM")
        {
            Console.WriteLine("true");
        }
    }

}
