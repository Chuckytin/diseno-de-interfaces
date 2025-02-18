using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace _20250218_HamVecino_DI_Angel_Torcal
{
    //ventana de bienvenida que carga una animación de barra de progreso animada antes de mostrar la interfaz principal
    public partial class BienvenidaWindow : Window
    {
        private bool _loaded = false;

        public BienvenidaWindow()
        {
            InitializeComponent();
            Loaded += BienvenidaWindow_Loaded;
        }

        //Maneja el evento de carga de la ventana e inicia la animación de la barra de progreso
        private void BienvenidaWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (!_loaded)
            {
                _loaded = true;
                Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(InicializaAnimacion));
            }
        }

        //Inicializa la animación de la barra de progreso
        private void InicializaAnimacion()
        {
            var loadingBar = FindName("LoadingBar") as Border;
            double width = 0;

            //crea un temporizador para controlar la animación
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Tick += (s, args) =>
            {
                width += 4;
                loadingBar.Width = width;

                if (width >= 200)
                {
                    timer.Stop();
                    MostrarVentanaPrincipal();
                }
            };
            timer.Start();
        }

        //muestra la ventana principal de la APP y cierra la ventana de bienvenida
        private void MostrarVentanaPrincipal()
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}