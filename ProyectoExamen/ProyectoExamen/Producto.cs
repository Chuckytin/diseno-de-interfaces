using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen
{
    //Clase que representa un producto en el catálogo
    //incluyendo detalles como su imagen, precio, disponibilidad y plazo de entrega.
    internal class Producto
    {
        public string Imagen { get; set; }
        public string Precio { get; set; }
        public string Disponibilidad { get; set; }
        public string PlazoEntrega { get; set; }

        public Producto(string imagen, string precio, string disponibilidad, string plazoEntrega)
        {
            Imagen = imagen;
            Precio = precio;
            Disponibilidad = disponibilidad;
            PlazoEntrega = plazoEntrega;
        }
    }
}
