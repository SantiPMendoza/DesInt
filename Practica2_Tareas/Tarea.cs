using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_Tareas
{
    internal class Tarea
    {
        private static int contadorId = 0;
        int id;
        string descripcion;
        DateTime fechaVencimiento;
        bool estadoCompletado;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public bool EstadoCompletado { get => estadoCompletado; set => estadoCompletado = value; }
        public int Id { get => id; set => id = value; }

        public Tarea(string descripcion, DateTime fechaVencimiento, bool estadoCompletado)
        {
            Id= Interlocked.Increment(ref contadorId);
            Descripcion = descripcion;
            FechaVencimiento = fechaVencimiento;
            EstadoCompletado = estadoCompletado;
        }

        public Tarea(string descripcion, DateTime fechaVencimiento)
        {
            Id = Interlocked.Increment(ref contadorId);
            Descripcion = descripcion;
            FechaVencimiento = fechaVencimiento;
        }

        public Tarea()
        {
            Id = Interlocked.Increment(ref contadorId);
        }


        public override string ToString()
        {
            return "Tarea: "+Id+"\n\t"+Descripcion+"\n\t"+FechaVencimiento.ToString()+"\n\tCompletado: "+(EstadoCompletado? "Completado":"Pendiente");
        }

        public override bool Equals(object? obj)
        {
            return obj is Tarea tarea &&
                   id == tarea.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, descripcion, fechaVencimiento, estadoCompletado);
        }
    }
}
