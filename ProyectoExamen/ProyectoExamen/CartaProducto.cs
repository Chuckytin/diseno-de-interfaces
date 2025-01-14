using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoExamen
{
    public partial class CartaProducto : UserControl
    {
        //Tamaños de los paneles
        private readonly Size PanelContraido = new Size(200, 75);
        private readonly Size PanelExpandido = new Size(650, 150);

        //panel que está expandido actualmente
        private Panel panelExpandido = null;

        //clases creadas aparte
        private Imagenes imagenes;
        private ProductoCatalago productoCatalago;

        //Índices actuales de las imágenes para cada PictureBox
        private int indiceImagen1 = 0;
        private int indiceImagen2 = 0;
        private int indiceImagen3 = 0;

        public CartaProducto()
        {
            InitializeComponent();
            imagenes = new Imagenes();
            productoCatalago = new ProductoCatalago();
            InicializarPaneles();
        }

        //Métodos Click que asignan los eventos de click a los paneles
        private void panel1_Click(object sender, EventArgs e)
        {
            AlternarOContraerPanel(panel1);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            AlternarOContraerPanel(panel2);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            AlternarOContraerPanel(panel3);
        }

        private void AlternarOContraerPanel(Panel panel)
        {
            //si el panel seleccionado ya está expandido lo contrae
            if (panel == panelExpandido)
            {
                panel.Size = PanelContraido; 
                panelExpandido = null; //ningún panel está expandido ahora
            }
            else
            {
                //contraer el panel actualmente expandido si hay alguno
                if (panelExpandido != null)
                {
                    panelExpandido.Size = PanelContraido;
                }

                //expande el panel seleccionado
                panel.Size = PanelExpandido; 
                panelExpandido = panel; //guarda referencia al panel expandido
            }

            AjustarPosiciones();
        }

        //Alinea los paneles verticalmente uno debajo del otro sin espacios entre ellos.
        private void AjustarPosiciones()
        {
            //lista de los paneles para iterar
            Panel [] paneles = { panel1, panel2, panel3 };

            //se inicializa en la posición
            int posicionY = 150;

            //bucle for para recorrer los paneles
            for (int i = 0; i < paneles.Length; i++)
            {
                paneles[i].Location = new Point(50, posicionY); //asigna la posición Y
                posicionY += paneles[i].Height + 10; //incrementa según la altura del panel + margen 10
            }
        }

        //Método para inicializar los paneles contraídos
        private void InicializarPaneles()
        {
            //asigna el tamaño reducido y posiciones iniciales
            panel1.Size = PanelContraido;
            panel1.Location = new Point(50, 150);

            panel2.Size = PanelContraido;
            panel2.Location = new Point(50, panel1.Bottom + 10); //10 de margen

            panel3.Size = PanelContraido;
            panel3.Location = new Point(50, panel2.Bottom + 10); //10 de margen

            //ningún panel expandido al inicio
            panelExpandido = null;
        }

        //Método para cargar las imágenes y liberar la memoria previamente ocupada por las imágenes
        private void CargarImagenes()
        {
            //carga la imagen inicial para cada PictureBox utilizando la concatenación de rutas
            try
            {
                pictureBox1.Image = Image.FromFile("imagenes" + "\\" + imagenes.imagenesRegalos[indiceImagen1]);
                pictureBox2.Image = Image.FromFile("imagenes" + "\\" + imagenes.imagenesArboles[indiceImagen2]);
                pictureBox3.Image = Image.FromFile("imagenes" + "\\" + imagenes.imagenesComidas[indiceImagen3]);
            }
            catch (FileNotFoundException)
            {
                 MessageBox.Show("ERROR: Una o más imágenes no fueron encontradas.");
            }

            //actualiza las etiquetas de cada panel
            labelPrecio1.Text = "Precio \n\n" + productoCatalago.ProductoRegalos[indiceImagen1].Precio;
            labelDisponible1.Text = "Disponibilidad \n\n" + productoCatalago.ProductoRegalos[indiceImagen1].Disponibilidad;
            labelPlazo1.Text = "Plazo de entrega \n\n" + productoCatalago.ProductoRegalos[indiceImagen1].PlazoEntrega;

            labelPrecio2.Text = "Precio \n\n" + productoCatalago.ProductoArboles[indiceImagen2].Precio;
            labelDisponible2.Text = "Disponibilidad \n\n" + productoCatalago.ProductoArboles[indiceImagen2].Disponibilidad;
            labelPlazo2.Text = "Plazo de entrega \n\n" + productoCatalago.ProductoArboles[indiceImagen2].PlazoEntrega;

            labelPrecio3.Text = "Precio \n\n" + productoCatalago.ProductoComidas[indiceImagen3].Precio;
            labelDisponible3.Text = "Disponibilidad \n\n" + productoCatalago.ProductoComidas[indiceImagen3].Disponibilidad;
            labelPlazo3.Text = "Plazo de entrega \n\n" + productoCatalago.ProductoComidas[indiceImagen3].PlazoEntrega;
        }

        //Método que cambia de imagen y los valores de las etiquetas
        private void CambiarImagen(PictureBox pictureBox, ref int indiceImagen, List<Producto> productos, Label labelPrecio, Label labelDisponibilidad, Label labelPlazoEntrega)
        {
            //incrementa el índice y asegura que vuelva al inicio si supera el número de imágenes
            indiceImagen++;
            if (indiceImagen >= productos.Count)
            {
                indiceImagen = 0;  // Vuelve al inicio
            }

            //carga la imagen correspondiente en el PictureBox
            string rutaCarpeta = Application.StartupPath + "\\imagenes";

            try
            {
                pictureBox.Image = Image.FromFile(rutaCarpeta + "\\" + productos[indiceImagen].Imagen);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ERROR: La imagen no fue encontrada.");
            }


            //actualiza las etiquetas con los valores del producto seleccionado
            labelPrecio.Text = "Precio \n\n" + productos[indiceImagen].Precio;
            labelDisponibilidad.Text = "Disponibilidad \n\n" + productos[indiceImagen].Disponibilidad;
            labelPlazoEntrega.Text = "Plazo de entrega \n\n" + productos[indiceImagen].PlazoEntrega;
        }


        //Métodos para mostrar la imagen
        private void pictureBox1_VisibleChanged(object sender, EventArgs e)
        {
            CargarImagenes();
        }

        private void pictureBox2_VisibleChanged(object sender, EventArgs e)
        {
            CargarImagenes();
        }

        private void pictureBox3_VisibleChanged(object sender, EventArgs e)
        {
            CargarImagenes();
        }

        //Métodos para cambiar la imagen al hacer click
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CambiarImagen(pictureBox1, ref indiceImagen1, productoCatalago.ProductoRegalos, labelPrecio1, labelDisponible1, labelPlazo1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CambiarImagen(pictureBox2, ref indiceImagen2, productoCatalago.ProductoArboles, labelPrecio2, labelDisponible2, labelPlazo2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CambiarImagen(pictureBox3, ref indiceImagen3, productoCatalago.ProductoComidas, labelPrecio3, labelDisponible3, labelPlazo3);
        }

    }
}
