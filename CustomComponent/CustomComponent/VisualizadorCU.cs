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
    public partial class VisualizadorCU : UserControl
    {
        //Clase para representar imágenes
        PictureBox pictureBox;

        public VisualizadorCU()
        {
            InitializeComponent();
            pictureBox = new PictureBox();
            this.Controls.Add(pictureBox);
        }

        [Category("Custom")]
        public string ImageFile
        {
            set { 
                Image image = Image.FromFile(value);
                pictureBox.Image = image;
                pictureBox.Size = image.Size;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

    }
}
