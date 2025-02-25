using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_FireBase
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona imágen";
            ofd.Filter = "(*.png) | *.png (*.jpg) | *.jpg | (*.jpeg) | *.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                Image img = new Bitmap(ofd.FileName);
                pBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pBox.Image = img;
            }
        }

        //btn_insert_Click

    }
}
