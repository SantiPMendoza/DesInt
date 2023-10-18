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
        List<Tarea> lista;

        internal List<Tarea> Lista { get => lista; set => lista = value; }

        public ListaTareas(List<Tarea> lista)
        {
            Lista=new List<Tarea>();
        }

        public ListaTareas()
        {
                Lista = new List<Tarea>();
        }
        public void AgregarTarea()
        {
            Console.WriteLine("Añada una descripción para la nueva tarea.");
            string desc=Console.ReadLine();
            Console.WriteLine("Añada una fecha de vencimiento con este formato: MM DD, YYYY");
            string dateString = Console.ReadLine();
            var cultureInfo = new CultureInfo("es-ES");
            try
            {
                DateTime dateTime = DateTime.Parse(dateString, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
                //Console.WriteLine("Done1.");
                Tarea tarea = new Tarea(desc, dateTime);
                foreach(Tarea t in Lista)
                {
                    if (t.Equals(tarea))
                    {
                        Lista.Add(tarea);
                        Console.WriteLine("Añadido exitosamente");

                    }
                    else
                    {
                        Console.WriteLine("El elemento ya existe");

                    }
                }
                

                //Console.WriteLine(Lista.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("No se ha podido registrar la fecha. Compruebe el formato");
            }

        }
        public void EliminarTarea()
        {   
            Console.WriteLine("¿Id de la tarea a eliminar?");
            int id=int.Parse(Console.ReadLine());
            Tarea tareaAEliminar = Lista.Find(t => t.Id == id);
            if (tareaAEliminar != null)
            {
                Lista.Remove(tareaAEliminar);
            }
        }
        public void ListarTareas()
        {
            Lista.ToString();
        }
        public override string ToString()
        {
            string str="";
            foreach (Tarea tarea in Lista)
            {
                 str= str+tarea.ToString();
            }
            return str;
        }

    }
}
