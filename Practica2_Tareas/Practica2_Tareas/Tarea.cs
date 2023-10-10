using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_Tareas
{
    internal class Tarea
    {
        string descripcion;
        DateTime fechaVencimiento;
        bool estadoCompletado;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public bool EstadoCompletado { get => estadoCompletado; set => estadoCompletado = value; }

        public Tarea(string descripcion, DateTime fechaVencimiento, bool estadoCompletado)
        {
            Descripcion = descripcion;
            FechaVencimiento = fechaVencimiento;
            EstadoCompletado = estadoCompletado;
        }

        public Tarea(string descripcion, DateTime fechaVencimiento)
        {
            Descripcion = descripcion;
            FechaVencimiento = fechaVencimiento;
        }

        public Tarea()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is Tarea tarea &&
                   Descripcion == tarea.Descripcion &&
                   FechaVencimiento == tarea.FechaVencimiento &&
                   EstadoCompletado == tarea.EstadoCompletado;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Descripcion, FechaVencimiento, EstadoCompletado);
        }
    }
}
