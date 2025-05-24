using System;
using System.Collections.Generic;
using System.Linq;

public class Nodo<T>
{
    public T Valor { get; set; }
    public Nodo<T>? Anterior { get; set; }
    public Nodo<T>? Siguiente { get; set; }

    public Nodo(T valor)
    {
        Valor = valor;
        Anterior = null;
        Siguiente = null;
    }
}

public class ListaDoblementeLigada<T>
{
    private Nodo<T>? cabeza;
    private Nodo<T>? cola;

    public void Adicionar(T valor)
    {
        var nuevoNodo = new Nodo<T>(valor);
        if (cabeza == null)
        {
            cabeza = cola = nuevoNodo;
        }
        else
        {
            cola!.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = cola;
            cola = nuevoNodo;
        }
    }

    public void MostrarHaciaAdelante()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        var actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public void MostrarHaciaAtras()
    {
        if (cola == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        var actual = cola;
        while (actual != null)
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Anterior;
        }
        Console.WriteLine("null");
    }

    public void MostrarModa()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        var frecuencias = new Dictionary<T, int>();
        var actual = cabeza;
        while (actual != null)
        {
            if (frecuencias.ContainsKey(actual.Valor))
            {
                frecuencias[actual.Valor]++;
            }
            else
            {
                frecuencias[actual.Valor] = 1;
            }
            actual = actual.Siguiente;
        }

        var maxFrecuencia = frecuencias.Values.Max();
        var modas = frecuencias.Where(x => x.Value == maxFrecuencia).Select(x => x.Key).ToList();

        Console.WriteLine($"La moda es: {string.Join(", ", modas)} con {maxFrecuencia} ocurrencias.");
    }

    public void EliminarItem(T valor)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        var actual = cabeza;
        while (actual != null)
        {
            if (EqualityComparer<T>.Default.Equals(actual.Valor, valor))
            {
                if (actual.Anterior != null)
                {
                    actual.Anterior.Siguiente = actual.Siguiente;
                }
                else
                {
                    cabeza = actual.Siguiente;
                }

                if (actual.Siguiente != null)
                {
                    actual.Siguiente.Anterior = actual.Anterior;
                }
                else
                {
                    cola = actual.Anterior;
                }

                Console.WriteLine($"Elemento '{valor}' eliminado.");
                return;
            }
            actual = actual.Siguiente;
        }

        Console.WriteLine($"Elemento '{valor}' no encontrado.");
    }
    public void BuscarItem(T valor)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }
        var actual = cabeza;
        while (actual != null)
        {
            if (EqualityComparer<T>.Default.Equals(actual.Valor, valor))
            {
                Console.WriteLine($"Elemento '{valor}' encontrado.");
                return;
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine($"Elemento '{valor}' no encontrado.");
    }
    public void EliminarLista()
    {
        cabeza = null;
        cola = null;
        Console.WriteLine("Lista eliminada.");
    }
}

class Program
{
    static void Main()
    {
        ListaDoblementeLigada<string> lista = new ListaDoblementeLigada<string>(); // Permite números y letras
        int opcion;

        do
        {
            Console.WriteLine("bienvenido a la biblioteca de items");
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar un item");
            Console.WriteLine("2. Mostrar hacia adelante");
            Console.WriteLine("3. Mostrar hacia atrás");
            Console.WriteLine("4. Mostrar moda");
            Console.WriteLine("5. Eliminar un item");
            Console.WriteLine("6. Buscar un item");
            Console.WriteLine("7. Eliminar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un item (número o letra): ");
                    string item = Console.ReadLine()!;
                    lista.Adicionar(item);
                    break;
                case 2:
                    lista.MostrarHaciaAdelante();
                    break;
                case 3:
                    lista.MostrarHaciaAtras();
                    break;
                case 4:
                    lista.MostrarModa();
                    break;
                case 5:
                    Console.Write("Ingrese el item a eliminar: ");
                    string itemEliminar = Console.ReadLine()!;
                    lista.EliminarItem(itemEliminar);
                    break;
                case 6:
                    Console.Write("Ingrese el item a buscar: ");
                    string itemBuscar = Console.ReadLine()!;
                    // Implementar búsqueda aquí si es necesario
                    break;
                case 7:
                    lista.EliminarLista();
                    Console.Write("eliminar lista");
                    break;
            }

        } while (opcion != 0);

        Console.WriteLine("Fin del programa.");
    }
}