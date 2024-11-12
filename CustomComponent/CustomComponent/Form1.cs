using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using permite acotar la existencia de objetos durante
            //una determinada sección de código. Lo que se traduce
            //en control de memoria en tiempo de ejecución
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {

                Multiselect = false,
                ValidateNames = true,
                Filter = "PNG|*.png"

            }) {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;
                    visualizadorCU1.ImageFile = openFileDialog.FileName;
                }

            }
        }
    }
}
