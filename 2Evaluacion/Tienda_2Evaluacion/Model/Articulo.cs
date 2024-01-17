using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_2Evaluacion.Model
{
    public class Articulo
    {
        public int Id { get; set; }
        public SportType Deporte { get; set; }
        public ArticleType TipoArticulo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public enum SportType
        {
            Futbol,
            Baloncesto,
            Tenis,
            Esqui,
            Boxeo
        }

        public enum ArticleType
        {
            Accesorio,
            Ropa,
            Zapatillas,
            Articulo
        }
    }
}
