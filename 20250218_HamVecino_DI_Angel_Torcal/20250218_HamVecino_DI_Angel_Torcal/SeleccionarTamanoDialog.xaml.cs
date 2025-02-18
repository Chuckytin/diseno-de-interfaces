using System.Windows;
using System.Windows.Controls;

namespace _20250218_HamVecino_DI_Angel_Torcal
{
    //Diálogo para seleccionar el tamaño de patatas o bebidas
    public partial class SeleccionarTamanoDialog : Window
    {
        //Propiedad Patata para seleccionar su tamaño
        public Patata PatataSeleccionada { get; private set; }
        //Propiedad Bebida para seleccionar su tamaño
        public Bebida BebidaSeleccionada { get; private set; }
        private readonly object _item;

        //Inicializa el diálogo para indicar el tamaño del item.
        public SeleccionarTamanoDialog(object item)
        {
            this.Owner = App.Current.MainWindow;
            InitializeComponent();
            _item = item;
            Title = _item is Patata ? "Seleccionar Tamaño de Patatas" : "Seleccionar Tamaño de Bebida";
            
            //selecciona el índice 1 (Mediano)
            TamanoComboBox.SelectedIndex = 1;
        }

        //Maneja el evento click para validar la selección del tamaño
        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            string tamaño = (TamanoComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (string.IsNullOrEmpty(tamaño))
            {
                MessageBox.Show("Seleccione un tamaño válido.");
                return;
            }

            if (_item is Patata patata)
            {
                double precio = tamaño switch
                {
                    "Pequeño" => 1.49,
                    "Mediano" => 1.99,
                    "Grande" => 2.99,
                    _ => 0
                };
                PatataSeleccionada = new Patata(patata.Nombre, precio, tamaño);
            }
            else if (_item is Bebida bebida)
            {
                double precio = tamaño switch
                {
                    "Pequeño" => 1.99,
                    "Mediano" => 2.99,
                    "Grande" => 3.49,
                    _ => 0
                };
                BebidaSeleccionada = new Bebida(bebida.Nombre, precio, tamaño);
            }

            DialogResult = true;
            Close();
        }
    }
}