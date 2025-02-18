using HamVecino_DI_Angel_Torcal;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace _20250218_HamVecino_DI_Angel_Torcal
{
    public partial class MainWindow : Window
    {
        private Carta carta;
        private Pedido pedido;
        private ObservableCollection<Pedido> pedidosGuardados;

        public MainWindow()
        {
            InitializeComponent();
            InicializarDatos();
            pedidosGuardados = new ObservableCollection<Pedido>();
        }

        // Inicializa los objetos necesarios para el manejo del pedido y la carta 
        private void InicializarDatos()
        {
            pedido = new Pedido();
            carta = new Carta();
            try
            {
                carta.CargarCarta(pedido);
            }
            catch (Exception ex)
            {
                File.AppendAllText("error_log.txt", $"{DateTime.Now}: {ex}\n");
                MessageBox.Show($"Error: {ex.Message}. Revisa error_log.txt", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Actualiza la lista de 'items' según la categoría seleccionada.
        private void CategoriaButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string categoria = button.Tag.ToString();

            try
            {
                switch (categoria)
                {
                    case "Hamburguesas":
                        ItemsList.ItemsSource = pedido.Hamburguesas;
                        Debug.WriteLine($"Hamburguesas cargadas: {pedido.Hamburguesas.Count}");
                        break;
                    case "Nuggets":
                        ItemsList.ItemsSource = pedido.Nuggets;
                        Debug.WriteLine($"Nuggets cargados: {pedido.Nuggets.Count}");
                        break;
                    case "Patatas":
                        ItemsList.ItemsSource = pedido.Patatas;
                        Debug.WriteLine($"Patatas cargadas: {pedido.Patatas.Count}");
                        break;
                    case "Bebidas":
                        ItemsList.ItemsSource = pedido.Bebidas;
                        Debug.WriteLine($"Bebidas cargadas: {pedido.Bebidas.Count}");
                        break;
                    case "Postres":
                        ItemsList.ItemsSource = pedido.Postres;
                        Debug.WriteLine($"Postres cargados: {pedido.Postres.Count}");
                        break;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("error_log.txt", $"{DateTime.Now}: {ex}\n");
                MessageBox.Show($"Error: {ex.Message}. Revisa error_log.txt", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Maneja la selección de items en la lista de productos, agrega la opción seleccionada al pedido según el tipo de producto
        // En ItemsList_SelectionChanged
        private void ItemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = ItemsList.SelectedItem;

            try
            {
                if (selectedItem is Hamburguesa hamburguesa)
                {
                    // Agrega la hamburguesa directamente al pedido 
                    pedido.AgregarHamburguesa(hamburguesa);
                }
                else if (selectedItem is Patata patata)
                {
                    // Muestra el diálogo para seleccionar el tamaño de las patatas
                    var tamanoDialog = new SeleccionarTamanoDialog(patata);
                    tamanoDialog.ShowDialog(); // Aquí ya no es necesario establecer el Owner
                    if (tamanoDialog.DialogResult == true)
                    {
                        pedido.AgregarPatata(tamanoDialog.PatataSeleccionada);
                    }
                }
                else if (selectedItem is Bebida bebida)
                {
                    // Muestra el diálogo para seleccionar el tamaño de la bebida
                    var tamanoDialog = new SeleccionarTamanoDialog(bebida);
                    tamanoDialog.ShowDialog();
                    if (tamanoDialog.DialogResult == true)
                    {
                        pedido.AgregarBebida(tamanoDialog.BebidaSeleccionada);
                    }
                }
                else if (selectedItem is Nugget nugget)
                {
                    // Muestra el diálogo para seleccionar la cantidad de nuggets
                    var cantidadDialog = new SeleccionarCantidadDialog(nugget);
                    cantidadDialog.ShowDialog();
                    if (cantidadDialog.DialogResult == true)
                    {
                        pedido.AgregarNugget(cantidadDialog.NuggetSeleccionado);
                    }
                }
                else if (selectedItem is Postre postre)
                {
                    // Agrega el postre directamente al pedido (no necesita tamaño ni cantidad)
                    pedido.AgregarPostre(postre);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("error_log.txt", $"{DateTime.Now}: {ex}\n");
                MessageBox.Show($"Error: {ex.Message}. Revisa error_log.txt", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // Actualiza el pedido en la interfaz de usuario
            ActualizarPedido();

            // Limpia la selección para permitir selecciones futuras
            ItemsList.SelectedItem = null;
        }


        // Actualiza la visualización del pedido en la interfaz, muestra todos los items del pedido y el total.
        private void ActualizarPedido()
        {
            PedidoList.Items.Clear();

            // Muestra las hamburguesas en el pedido
            foreach (var h in pedido.PedidoHamburguesa)
            {
                PedidoList.Items.Add(h.ToString());
            }

            // Muestra las patatas en el pedido
            foreach (var p in pedido.PedidoPatata)
            {
                PedidoList.Items.Add(p.ToString());
            }

            // Muestra las bebidas en el pedido
            foreach (var b in pedido.PedidoBebida)
            {
                PedidoList.Items.Add(b.ToString());
            }

            // Muestra los nuggets en el pedido
            foreach (var n in pedido.PedidoNugget)
            {
                PedidoList.Items.Add(n.ToString());
            }

            // Muestra los postres en el pedido
            foreach (var po in pedido.PedidoPostre)
            {
                PedidoList.Items.Add(po.ToString());
            }

            // Actualiza el total del pedido
            double total = pedido.calcularTotal();
            TotalTextBlock.Text = $"Total: {total:C}";
        }

        // Confirma el pedido actual y lo reinicia
        private void ConfirmarButton_Click(object sender, RoutedEventArgs e)
        {
            double total = pedido.calcularTotal();
            MessageBox.Show($"Pedido confirmado! Total: {total:C}");
            pedido.borrarPedido(); // Limpia las listas internas del pedido
            PedidoList.Items.Clear(); // Limpia la lista visual
            TotalTextBlock.Text = "Total: 0,00 €";
        }

        // Cancela el pedido actual sin confirmación
        private void BorrarButton_Click(object sender, RoutedEventArgs e)
        {
            pedido.borrarPedido();
            PedidoList.Items.Clear();
            TotalTextBlock.Text = "Total: 0,00 €";
        }

        // Método para guardar el pedido actual
        private void GuardarPedidoButton_Click(object sender, RoutedEventArgs e)
        {
            if (pedido.PedidoHamburguesa.Count == 0 &&
                pedido.PedidoPatata.Count == 0 &&
                pedido.PedidoBebida.Count == 0 &&
                pedido.PedidoNugget.Count == 0 &&
                pedido.PedidoPostre.Count == 0)
            {
                MessageBox.Show("No hay ningún pedido para guardar.", "Guardar Pedido", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            // Guarda una copia del pedido actual en la lista de pedidos guardados
            Pedido copiaPedido = new Pedido
            {
                PedidoHamburguesa = new ObservableCollection<Hamburguesa>(pedido.PedidoHamburguesa),
                PedidoPatata = new ObservableCollection<Patata>(pedido.PedidoPatata),
                PedidoBebida = new ObservableCollection<Bebida>(pedido.PedidoBebida),
                PedidoNugget = new ObservableCollection<Nugget>(pedido.PedidoNugget),
                PedidoPostre = new ObservableCollection<Postre>(pedido.PedidoPostre)
            };

            pedidosGuardados.Add(copiaPedido);
            MessageBox.Show("Pedido guardado correctamente.", "Guardar Pedido", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CargarPedidoButton_Click(object sender, RoutedEventArgs e)
        {
            var pedidosWindow = new PedidosWindow(pedidosGuardados, this); // Pasa la lista de pedidos y la referencia a MainWindow
            pedidosWindow.ShowDialog(); // Muestra la ventana de pedidos guardados
        }

        public void CargarPedidoGuardado(Pedido pedidoGuardado)
        {
            // Limpia el pedido actual
            pedido.borrarPedido();

            // Copia los items del pedido guardado al pedido actual
            foreach (var h in pedidoGuardado.PedidoHamburguesa)
            {
                pedido.AgregarHamburguesa(h);
            }
            foreach (var p in pedidoGuardado.PedidoPatata)
            {
                pedido.AgregarPatata(p);
            }
            foreach (var b in pedidoGuardado.PedidoBebida)
            {
                pedido.AgregarBebida(b);
            }
            foreach (var n in pedidoGuardado.PedidoNugget)
            {
                pedido.AgregarNugget(n);
            }
            foreach (var po in pedidoGuardado.PedidoPostre)
            {
                pedido.AgregarPostre(po);
            }

            // Actualiza la interfaz de usuario
            ActualizarPedido();
        }
    }
}
