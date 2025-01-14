using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen
{
    //Clase que representa una colección de imágenes organizadas por categorías (regalos, árboles y comidas).
    internal class Imagenes
    {
        public List<string> imagenesRegalos { get; set; }
        public List<string> imagenesArboles { get; set; }
        public List<string> imagenesComidas { get; set; }

        public Imagenes()
        {
            imagenesRegalos = new List<string>
            {
                "imagen1.png",
                "imagen2.png",
                "imagen3.png"
            };

            imagenesArboles = new List<string>
            {
                "imagen4.png",
                "imagen5.png",
                "imagen6.png"
            };

            imagenesComidas = new List<string>
            {
                "imagen7.png",
                "imagen8.png",
                "imagen9.png"
            };
        }
    }
}
