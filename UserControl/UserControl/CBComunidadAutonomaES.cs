using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl1
{
    public partial class CBComunidadAutonomaES: UserControl
    {
        public CBComunidadAutonomaES()
        {
            InitializeComponent();
        }

        public Comunidades SelectComunidades 
        { 
        
            get { return (Comunidades) comboBox.SelectedItem; }
        
        }

        private void CBComunidadAutonomaES_Load(object sender, EventArgs e)
        {
            List<Comunidades> listaDeComunidades = new List<Comunidades>();
            listaDeComunidades.Add(new Comunidades() { ID = 1, Name = "Aragón"});
            listaDeComunidades.Add(new Comunidades() { ID = 2, Name = "Asturias" });
            listaDeComunidades.Add(new Comunidades() { ID = 3, Name = "Andalucía" });
            listaDeComunidades.Add(new Comunidades() { ID = 4, Name = "Madrid" });

            comboBox.DataSource = listaDeComunidades;
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "Name";

        }

        public Label LabelModification 
        {
            get { return label_CA; }
            set { label_CA = LabelModification; }
        }

    }

}
