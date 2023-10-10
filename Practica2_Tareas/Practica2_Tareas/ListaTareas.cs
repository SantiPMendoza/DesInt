using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_Tareas
{
    internal class ListaTareas
    {
        List<Tarea> lista;

        internal List<Tarea> Lista { get => lista; set => lista = value; }

        public ListaTareas(List<Tarea> lista)
        {
            Lista = lista;
        }

        public ListaTareas()
        {
            List<Tarea> tareas = new List<Tarea>();
        }
        public void agregarTarea()
        {
            ListaTareas listaTareas = new ListaTareas();
            Console.WriteLine("Añada una descripción para la nueva tarea.");
            string desc=Console.ReadLine();
            Console.WriteLine("Añada una fecha de vencimiento con este formato: MM DD, YYYY");
            string dateString = Console.ReadLine();
            var cultureInfo = new CultureInfo("es-ES");
            try
            {
                DateTime dateTime = DateTime.Parse(dateString, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
                Console.WriteLine("Done1.");
                listaTareas.Add(new Tarea(desc, dateTime));
                Console.WriteLine("Done2.");
            }
            catch (FormatException)
            {
                Console.WriteLine("No se ha podido registrar la fecha. Compruebe el formato");
            }
        }
    }
}
