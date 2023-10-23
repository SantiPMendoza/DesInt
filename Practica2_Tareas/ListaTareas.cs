using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practica2_Tareas
{
    internal class ListaTareas
    {
        List<Tarea> lista = new List<Tarea>();
        ErrorLogger errorLogger = new ErrorLogger("Errors Logfile.log");

        internal List<Tarea> Lista { get => lista; set => lista = value; }

        public ListaTareas(List<Tarea> lista)
        {
            Lista = new List<Tarea>();
        }

        public ListaTareas()
        {
            Lista = new List<Tarea>();
        }
        /**
         * Agrega una tarea pidiendo por teclado una Descripción y una FechaVencimiento.
         * ID con autoincremento y estado default de EstadoCompletado es no completado.
         * */
        public void AgregarTarea()
        {
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine("Añada una descripción para la nueva tarea.");
            string desc = Console.ReadLine();
            Console.WriteLine("Añada una fecha de vencimiento con este formato: MM DD, YYYY");
            string dateString = Console.ReadLine();
            var cultureInfo = new CultureInfo("es-ES");

            try
            {
                DateTime dateTime = DateTime.Parse(dateString, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
                Tarea nuevaTarea = new Tarea(desc, dateTime);

                // Verificar si la tarea ya existe en la lista y si la fecha es superior a la actual
                bool tareaExistente = false;
                foreach (Tarea t in Lista)
                {
                    if (t.Equals(nuevaTarea))
                    {
                        tareaExistente = true;
                        break;
                    }
                }
                if (!tareaExistente && dateTime > fechaActual)
                {
                    Lista.Add(nuevaTarea);
                    Console.WriteLine("Tarea añadida exitosamente.\n");
                }
                else
                {
                    Console.WriteLine("La tarea ya existe en la lista o la fecha proporcionada es inferior a la actual.");
                }

            }

            catch (FormatException)
            {
                Console.WriteLine("No se ha podido registrar la fecha. Compruebe el formato.");
                errorLogger.LogError("Intento de registrar una tarea con formato de fecha incorrecto.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
                errorLogger.LogError($"Error inesperado: {ex.Message}");
            };

        }
        /**
         * Elimina una tarea según el ID elegido de la lista de tareas
         * */
        public void EliminarTarea()
        {
            ListarTareas();
            Console.WriteLine("¿Id de la tarea a eliminar?");
            int id = int.Parse(Console.ReadLine());
            Tarea tareaAEliminar = Lista.Find(t => t.Id == id);

            try
            {
                if (tareaAEliminar != null)
                {
                    Lista.Remove(tareaAEliminar);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No existe una tarea con ese ID o ya ha sido eliminada.");
                errorLogger.LogError($"Intento de eliminar una tarea con ID inexistente o inválido: {ex.Message}");
            };
        }
        /**Lista todas las tareas que no hayan sido eliminadas de la lista
         * */
        public void ListarTareas()
        {
            Console.WriteLine(ToString());
        }
        public void ListarTareasIncompletas()
        {
            var tareasIncompletas = from tarea in Lista
                                    where !tarea.EstadoCompletado
                                    select tarea;

            foreach (var tarea in tareasIncompletas)
            {
                Console.WriteLine(tarea.ToString());
            }
        }
        /**
         * Lista todas las tareas (completadas o no) ordenadas por orden ascendente de fecha
         * */
        public void ListarTareasFecha()
        {
            DateTime fechaActual = DateTime.Now;
            var tareasFecha = from tarea in Lista
                              orderby tarea.FechaVencimiento
                              select tarea;
            foreach (var tarea in tareasFecha)
            {
                Console.WriteLine(tarea.ToString());
            }
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
        /**
         * Completa una tarea según el ID elegido de la lista de tareas no completadas.
         */
        public void CompletarTarea()
        {
            Console.WriteLine("Lista de tareas incompletas:");
            ListarTareasIncompletas();
            Console.WriteLine("¿Cuál deseas marcar como completada? (Id)");

            try
            {
                int entrada = int.Parse(Console.ReadLine());
                var tareaPedida = Lista.FirstOrDefault(t => t.Id == entrada);

                if (tareaPedida != null && !tareaPedida.EstadoCompletado)
                {
                    tareaPedida.EstadoCompletado = true;
                    Console.WriteLine("Tarea marcada como completada.");
                }
                else if (tareaPedida == null)
                {
                    Console.WriteLine("Tarea no encontrada.");
                }
                else
                {
                    Console.WriteLine("La tarea ya está completada.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa un número válido.");
                errorLogger.LogError("Se ingresó una entrada inválida al intentar marcar una tarea como completada.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
                errorLogger.LogError($"Error inesperado: {ex.Message}");
            }

        }
        public async Task GuardarArchivo()
        {
            Console.WriteLine("Elija en qué formato desea guardar el archivo: JSON = 1 || XML = 2");
            int formato = int.Parse(Console.ReadLine());
            try
            {
                if (formato == 1)
                {
                    string json = JsonSerializer.Serialize(this.Lista);
                    string nombreArchivo = $"{DateTime.Now:yyyyMMdd}_Download.json";
                    await File.WriteAllTextAsync(nombreArchivo, json);
                    Console.WriteLine("Tareas guardadas en formato JSON correctamente.");
                }
                else if (formato == 2)
                {
                    string nombreArchivo = $"{DateTime.Now:yyyyMMdd}_Download.xml";
                    using (FileStream fs = new FileStream(nombreArchivo, FileMode.Create))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Tarea>));
                        await Task.Run(() => serializer.Serialize(fs, this.Lista));
                    }
                    Console.WriteLine("Tareas guardadas en formato XML correctamente.");
                }
                else
                {
                    Console.WriteLine("Formato no admitido. Use 1 para JSON o 2 para XML.");
                    errorLogger.LogError("Se ingresó un número no válido al intentar guardar el archivo como JSON o XML.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar las tareas de forma asíncrona: {ex.Message}");
                errorLogger.LogError($"Error inesperado: {ex.Message}");
            }
        }

        public async Task ListarArchivos(string directorio)
        {
            try
            {
                if (Directory.Exists(directorio))
                {
                    string[] archivos = Directory.GetFiles(directorio, "*.*")
                        .Where(file => file.EndsWith(".json", StringComparison.OrdinalIgnoreCase) || file.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
                        .ToArray();

                    if (archivos.Any())
                    {
                        Console.WriteLine("Archivos en el directorio con formato .json o .xml:");
                        for (int i = 0; i < archivos.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {archivos[i]}");
                        }

                        Console.WriteLine("Elija el número de archivo para cargar:");
                        if (int.TryParse(Console.ReadLine(), out int id) && id >= 1 && id <= archivos.Length)
                        {
                            await CargarArchivo(archivos[id - 1]);
                        }
                        else
                        {
                            Console.WriteLine("ID de archivo no válido.");
                            errorLogger.LogError("ID de archivo proporcionado al intentar cargar no válido.")
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron archivos con formato .json o .xml en el directorio.");
                        errorLogger.LogError("No se encontraron archivos con formato .json o .xml en el directorio proporcionado.");
                    }
                }
                else
                {
                    Console.WriteLine("El directorio especificado no existe.");
                    errorLogger.LogError("El directorio especificado al intentar cargar archivos no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar archivos: {ex.Message}");
                errorLogger.LogError($"Error al listar archivos: {ex.Message}");
            }
        }

        public async Task CargarArchivo(string archivo)
        {
            try
            {
                if (archivo.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    string json = await File.ReadAllTextAsync(archivo);

                    Console.WriteLine($"Archivo {archivo} cargado en formato JSON correctamente.");
                }
                else if (archivo.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
                {
                    using (FileStream fs = new FileStream(archivo, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Tarea>));

                        List<Tarea> tareas = (List<Tarea>)serializer.Deserialize(fs);
                        Console.WriteLine($"Archivo {archivo} cargado en formato XML correctamente.");
                    }
                }
                else
                {
                    Console.WriteLine("El formato del archivo seleccionado no es compatible.");
                    errorLogger.LogError("El formato del archivo seleccionado a cargar no es compatible.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar el archivo: {ex.Message}");
                errorLogger.LogError($"Error inesperado: {ex.Message}");

            }
        }

    }
}
    

