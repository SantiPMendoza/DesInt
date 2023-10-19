using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_Tareas
{
    internal class Menu
    {
        static ListaTareas lista;
        static void Main()
        {
            lista = new ListaTareas();
            lista.Lista.Add(new Tarea("aupa",DateTime.Now));
            lista.Lista.Add(new Tarea("aupaaaa", DateTime.Now));
            Elegir();
            
            //lista.AgregarTarea();
            //lista.ListarTareas();

        }
        static void Mostrar()
        {
            Console.WriteLine("APLICACIÓN DE GESTIÓN DE TAREAS:");
            Console.WriteLine("\n\t1.Listar todas las tareas.");
            Console.WriteLine("\n\t2.Listar tareas incompletas.");
            Console.WriteLine("\n\t3.Listar tareas por fecha de vencimiento.");
            Console.WriteLine("\n\t4.Agregar nueva tarea.");
            Console.WriteLine("\n\t5.Eliminar una tarea.");
            Console.WriteLine("\n\t6.Marcar tarea como completada.");
            Console.WriteLine("\n\t7.Guardar tareas en un archivo.");
            Console.WriteLine("\n\t8.Cargar tareas desde archivo.");
            Console.WriteLine("\n\n\t9.Salir.\n");
        }
        static void Elegir()
        {
            string entrada;
            do
            {
                Mostrar();
                entrada = Console.ReadLine();

                switch (entrada)
                {

                    case "1":
                        lista.ListarTareas();
                        Console.WriteLine("Todas las tareas listadas.\n");
                        continue;
                    case "2":
                        Console.WriteLine("Tareas incompletas listadas.");
                        continue;
                    case "3":
                        Console.WriteLine("Tareas listadas por fecha de vencimiento.");
                        continue;
                    case "4":
                        lista.AgregarTarea();
                        Console.WriteLine("");
                        continue;
                    case "5":
                        lista.EliminarTarea();
                        Console.WriteLine("Tarea eliminada exitosamente.\n");
                        continue;
                    case "6":
                        Console.WriteLine("Tarea marcada como completada.");
                        continue;
                    case "7":
                        Console.WriteLine("Tareas guardadas en archivo exitosamente.");
                        continue;
                    case "8":
                        Console.WriteLine("Tareas cargadas desde archivo exitosamente.");
                        continue;
                    case "0":
                        break;

                    default:
                        Console.WriteLine("La entrada es inválida");
                        continue;

                }

            } while (!entrada.Equals("0"));
        }
    }

    }

