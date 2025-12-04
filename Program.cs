using System;
using System.Collections.Generic; // <--- OBLIGATORIO para usar Listas

namespace GestorTareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. CREAR LA LISTA
            // En Python sería: tareas = []
            // En C# debemos decir DE QUÉ es la lista: List<Tarea>
            List<Tarea> listaTareas = new List<Tarea>();

            bool continuar = true;

            while (continuar)
            {
                // Limpiar pantalla para que se vea como una app real
                Console.Clear(); 
                
                Console.WriteLine("--- GESTOR DE TAREAS v1.0 ---");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Listar Tareas");
                Console.WriteLine("3. Salir");
                Console.Write("\nOpcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("\nEscribe la descripcion de la tarea: ");
                        string descripcion = Console.ReadLine();
                        
                        // 2. INSTANCIAR (CREAR) EL OBJETO
                        // Aquí usamos el constructor que hiciste en Tarea.cs
                        Tarea nuevaTarea = new Tarea(descripcion);
                        
                        // 3. GUARDAR EN LA LISTA
                        listaTareas.Add(nuevaTarea);
                        
                        Console.WriteLine("¡Tarea guardada exitosamente!");
                        Console.ReadKey(); // Pausa para que el usuario lea
                        break;

                    case "2":
                        Console.WriteLine("\n--- TUS TAREAS ---");
                        
                        // 4. RECORRER LA LISTA
                        // Si la lista está vacía, avisamos
                        if (listaTareas.Count == 0)
                        {
                            Console.WriteLine("No hay tareas pendientes.");
                        }
                        else
                        {
                            // Usamos un ciclo 'for' para tener el número (i)
                            for (int i = 0; i < listaTareas.Count; i++)
                            {
                                // Operador ternario: (condición) ? verdadero : falso
                                // Si esta completada pone [X], si no [ ]
                                string check = listaTareas[i].EstaCompletada ? "[X]" : "[ ]";
                                
                                // Interpolación de strings ($"...") para mezclar texto y variables
                                Console.WriteLine($"{i + 1}. {check} {listaTareas[i].Descripcion}");
                            }
                        }
                        Console.WriteLine("\nPresiona cualquier tecla para volver...");
                        Console.ReadKey();
                        break;

                    case "3":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}