using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CC_WPF_Tiers_Ex1.Componentes
{
    /// <summary>
    /// Lógica de interacción para Casilla.xaml
    /// </summary>
    public partial class Casilla : UserControl
    {

        public static readonly DependencyProperty dependencyProperty = 
            DependencyProperty.Register("Description", typeof(string), typeof(Casilla),
            new PropertyMetadata(string.Empty));

        public string Description { get; set; }

        public Casilla()
        {
            InitializeComponent();
        }
    }
}
