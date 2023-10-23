using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_Tareas
{
    internal class ErrorLogger
    {
        private string logFilePath;

        public ErrorLogger(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public void LogError(string errorMessage)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"{DateTime.Now}: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar el error en el archivo: {ex.Message}");
            }
        }
    }
}
