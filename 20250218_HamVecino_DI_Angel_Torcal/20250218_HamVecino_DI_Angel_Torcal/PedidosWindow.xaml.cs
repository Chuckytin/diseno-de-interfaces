using _20250218_HamVecino_DI_Angel_Torcal;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace HamVecino_DI_Angel_Torcal
{
    public partial class PedidosWindow : Window
    {
        private MainWindow _mainWindow; // Campo para almacenar la referencia a MainWindow

        public PedidosWindow(ObservableCollection<Pedido> pedidosGuardados, MainWindow mainWindow)
        {
            InitializeComponent();
            DataGridPedidos.ItemsSource = pedidosGuardados; // Asigna la lista al DataGrid
            _mainWindow = mainWindow; // Almacena la referencia a MainWindow
        }

        private void CargarPedidoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridPedidos.SelectedItem is Pedido pedidoSeleccionado)
            {
                _mainWindow.CargarPedidoGuardado(pedidoSeleccionado); // Usa la referencia a MainWindow
                Close();
            }
        }

        private void CerrarButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}