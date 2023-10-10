using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_Tareas
{
    internal class Menu
    {
        static void Main()
        {
            ListaTareas lista = new ListaTareas();
            lista.agregarTarea();
            //elegir();

        }
        static void mostrar()
        {
            Console.WriteLine("APLICACIÓN DE GESTIÓN DE TAREAS:");
            Console.WriteLine("\n\t1.Listar todas las tareas.");
            Console.WriteLine("\n\t2.Listar tareas incompletas.");
            Console.WriteLine("\n\t3.Listar tareas por fecha de vencimiento.");
            Console.WriteLine("\n\t4.Agregar nueva tarea.");
            Console.WriteLine("\n\t5.Marcar tarea como completada.");
            Console.WriteLine("\n\t6.Guardar tareas en un archivo.");
            Console.WriteLine("\n\t7.Cargar tareas desde archivo.");
            Console.WriteLine("\n\n\t8.Salir.");
        }
        static void elegir()
        {
            string entrada;
            do
            {
                mostrar();
                entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "0":
                        break;
                    case "1":
                        Console.WriteLine("Usuario creado.");
                        continue;
                    case "2":
                        Console.WriteLine("Libro creado.");
                        continue;
                    case "3":
                        Console.WriteLine("Autor creado.");
                        continue;
                    case "4":
                        Console.WriteLine("Libro reservado");
                        continue;
                    case "5":
                        Console.WriteLine("Edición añadida.");
                        continue;
                    case "6":
                        Console.WriteLine();
                        continue;
                    case "7":
                        Console.WriteLine();
                        continue;
                    case "8":
                        Console.WriteLine();
                        continue;

                    default:
                        Console.WriteLine("La entrada es inválida");
                        continue;

                }

            } while (!entrada.Equals("8"));
        }
    }

    }

