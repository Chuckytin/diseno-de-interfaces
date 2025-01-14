using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen
{
    //Clase que representa un catálogo de productos
    //con listas separadas para diferentes categorías de productos (regalos, árboles y comidas).
    internal class ProductoCatalago
    {
        public List<Producto> ProductoRegalos { get; set; }
        public List<Producto> ProductoArboles { get; set; }
        public List<Producto> ProductoComidas { get; set; }

        public ProductoCatalago()
        {
            ProductoRegalos = new List<Producto>
            {
                new Producto("imagen1.png", "$10.00", "Disponible", "3-5 días"),
                new Producto("imagen2.png", "$15.00", "Disponible", "2-4 días"),
                new Producto("imagen3.png", "$12.00", "Agotado", "7-10 días")
            };

            ProductoArboles = new List<Producto>
            {
                new Producto("imagen4.png", "$20.00", "Disponible", "5-7 días"),
                new Producto("imagen5.png", "$25.00", "Disponible", "4-6 días"),
                new Producto("imagen6.png", "$18.00", "Agotado", "10-14 días")
            };

            ProductoComidas = new List<Producto>
            {
                new Producto("imagen7.png", "$5.00", "Disponible", "1-2 días"),
                new Producto("imagen8.png", "$8.00", "Disponible", "1-3 días"),
                new Producto("imagen9.png", "$7.00", "Agotado", "5-7 días")
            };
        }

    }
}
