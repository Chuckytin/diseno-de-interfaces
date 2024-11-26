using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        /*
         * Establece un table grid view 4x4
         * Centrar label, letra webdings, la c es un cuadrado
         * replicar la label
         */
        public Form1()
        {
            InitializeComponent();

            asignarIconos();
            
        }

        /*
         * Cambiamos el color de las label para ocultarlas
         * en eventos creamos label_click
         */


        //Definir variables
        Random random = new Random();
        List<string> iconos = new List<string>()
        { 
            "!", "!", "N", "N", ",", ",", "K", "K", 
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        Label firstClicked, secondClicked;

        //función de asignación de imágenes
        private void asignarIconos()
        {
            Label label;
            int randomNumero;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                //verificación de las label dentro del tableLayoutPanel
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                {
                    continue;
                }

                randomNumero = random.Next(0, iconos.Count);
                label.Text = iconos[randomNumero];

                //Elimina los elementos para no repetir
                iconos.RemoveAt(randomNumero);
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null) return;

            //verifica
            Label clicked_label = sender as Label;

            //si no es nada, salir
            if (clicked_label == null) return;
            //si ya está descubierto, salir
            if (clicked_label.ForeColor == Color.AliceBlue) return;

            if (firstClicked == null)
            {
                firstClicked = clicked_label;
                firstClicked.ForeColor = Color.AliceBlue;
                return;
            }

            secondClicked = clicked_label;
            secondClicked.ForeColor = Color.AliceBlue;

            clickForWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                timer1.Start();
            }
            
        }

        //comprueba el color de los controles para descubrir si se ha ganado
        private void clickForWinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                //si tienen mismo color de frente y de atrás, no has terminado
                if (label != null && label.ForeColor == label.BackColor) return;
            }

            MessageBox.Show("Victoria!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //se define la respuesta al tick cada 750ms que hemos configurado en las propiedades
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            //pasalo el tiempo devuelve el color para ocultarlo y dejarlo a null las label
            firstClicked.ForeColor = Color.Silver;
            secondClicked.ForeColor = Color.Silver;

            firstClicked = null;
            secondClicked = null;
        }
    }
}
