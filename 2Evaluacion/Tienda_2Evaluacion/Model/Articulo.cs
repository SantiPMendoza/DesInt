using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_2Evaluacion.Model
{
    public class Articulo
    {
        public int Id { get; set; }
        public SportType? Deporte { get; set; }
        public ArticleType? TipoArticulo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public enum SportType
        {
            futbol,
            baloncesto,
            tenis,
            esqui,
            boxeo
        }

        public enum ArticleType
        {
            accesorio,
            ropa,
            zapatillas,
            articulo
        }
    }
}
