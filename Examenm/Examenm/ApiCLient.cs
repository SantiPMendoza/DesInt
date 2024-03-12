using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Examenm
{
    public class ApiClient
    {
        private HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:6969/"); // Cambia la URL base según la dirección de tu API
        }

        public async Task<int> CompararArchivos(string archivo1, string archivo2)
        {
            // Creamos un objeto que coincida con el esquema de la API
            var files = new
            {
                contentFileOrigin = archivo1,
                contentFileOther = archivo2
            };

            // Simulamos una operación que lleva tiempo (por ejemplo, una solicitud HTTP)
            using (HttpClient httpClient = new HttpClient())
            {
                var result = await httpClient.PostAsJsonAsync("http://localhost:6969/LevenshteinDistance", files);
                var data = await result.Content.ReadFromJsonAsync<int>();
                return data;
            }
        }
    }
}