using System.Windows;

namespace _20250218_HamVecino_DI_Angel_Torcal
{
    //Diálogo para seleccionar la cantidad deseada en un pedido
    public partial class SeleccionarCantidadDialog : Window
    {
        //Propiedad Nugget para seleccionar su cantidad
        public Nugget NuggetSeleccionado { get; private set; }
        private readonly Nugget _nugget;

        // Inicializa el diálogo para seleccionar la cantidad de nuggets
        public SeleccionarCantidadDialog(Nugget nugget)
        {
            this.Owner = App.Current.MainWindow;
            InitializeComponent(); // Asegúrate de que este método esté presente
            _nugget = nugget;
        }

        // Maneja el evento click para validad la cantidad ingresada 
        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(CantidadTextBox.Text, out int cantidad) && cantidad > 0)
            {
                double precioTotal = _nugget.Precio * cantidad;
                NuggetSeleccionado = new Nugget(_nugget.Nombre, precioTotal, cantidad);
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Introduzca una cantidad válida.");
            }
        }
    }
}