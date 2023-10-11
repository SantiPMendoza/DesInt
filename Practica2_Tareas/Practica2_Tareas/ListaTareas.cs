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
            lista=new List<Tarea>();
        }

        public ListaTareas()
        {
                Lista = new List<Tarea>();
        }
        public void agregarTarea()
        {

            Console.WriteLine("Añada una descripción para la nueva tarea.");
            string desc=Console.ReadLine();
            Console.WriteLine("Añada una fecha de vencimiento con este formato: MM DD, YYYY");
            string dateString = Console.ReadLine();
            var cultureInfo = new CultureInfo("es-ES");
            try
            {
                DateTime dateTime = DateTime.Parse(dateString, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
                Console.WriteLine("Done1.");
                Lista.Add(new Tarea(desc, dateTime));
                Console.WriteLine(Lista.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("No se ha podido registrar la fecha. Compruebe el formato");
            }
        }
        public override string ToString()
        {
            string str="";
            foreach (Tarea tarea in lista)
            {
                 str= str+tarea.ToString();
            }
            return str;
        }
    }
}
