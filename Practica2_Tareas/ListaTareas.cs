using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practica2_Tareas
{
    internal class ListaTareas
    {
        List<Tarea> lista = new List<Tarea>();

        internal List<Tarea> Lista { get => lista; set => lista = value; }

        public ListaTareas(List<Tarea> lista)
        {
            Lista = new List<Tarea>();
        }

        public ListaTareas()
        {
            Lista = new List<Tarea>();
        }
        public void AgregarTarea()
        {
            Console.WriteLine("Añada una descripción para la nueva tarea.");
            string desc = Console.ReadLine();
            Console.WriteLine("Añada una fecha de vencimiento con este formato: MM DD, YYYY");
            string dateString = Console.ReadLine();
            var cultureInfo = new CultureInfo("es-ES");

            try
            {
                DateTime dateTime = DateTime.Parse(dateString, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
                Tarea nuevaTarea = new Tarea(desc, dateTime);

                // Verificar si la tarea ya existe en la lista
                bool tareaExistente = false;
                foreach (Tarea t in Lista)
                {
                    if (t.Equals(nuevaTarea))
                    {
                        tareaExistente = true;
                        break;
                    }
                }

                if (!tareaExistente)
                {
                    Lista.Add(nuevaTarea);
                    Console.WriteLine("Tarea añadida exitosamente.\n");
                }
                else
                {
                    Console.WriteLine("La tarea ya existe en la lista.");
                }

            }

            catch (FormatException)
            {
                Console.WriteLine("No se ha podido registrar la fecha. Compruebe el formato.");
            }

        }
        public void EliminarTarea()
        {
            ListarTareas();
            Console.WriteLine("¿Id de la tarea a eliminar?");
            int id = int.Parse(Console.ReadLine());
            Tarea tareaAEliminar = Lista.Find(t => t.Id == id);
            if (tareaAEliminar != null)
            {
                Lista.Remove(tareaAEliminar);
            }
        }
        public void ListarTareas()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Tarea tarea in Lista)
            {
                str.AppendLine(tarea.ToString());
            }
            return str.ToString();
        }
        
    }
}
