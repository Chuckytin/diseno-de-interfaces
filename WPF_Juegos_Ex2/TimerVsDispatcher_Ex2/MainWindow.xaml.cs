using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TimerVsDispatcher_Ex2
{
       
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //1. Declaración de variables
        private DispatcherTimer dispatcherTimer;
        private System.Timers.Timer systemTimer;

        private int dispatcherCounter = 0;
        private int systemCounter = 0;


        public MainWindow()
        {
            InitializeComponent();

            // Initialize both timers
            InitializeDispatcherTimer();
            InitializeSystemTimer();

        }


        //2. UI refresco de cada Frame excluvamente para elementos
        //gráficos
        private void InitializeDispatcherTimer() {
            dispatcherTimer = new DispatcherTimer();

            //Configuración de la clase tipo temporizador
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1); // Attempt to update every 1 ms
            
            //Vinculación del evento tick con un handler definido
            //por función lambda, handler anónimo
            dispatcherTimer.Tick += (s, e) =>
            {
                dispatcherCounter++;
                DispatcherLabel.Content = $"Contador Dispatcher: " +
                $"{dispatcherCounter} ms";
            };

            //Inicialización del timer
            dispatcherTimer.Start();
        }


        // 3. Medir tiempo real de la aplicación sin que tenga
        // el problema del hilo del refresco del frame
        private void InitializeSystemTimer()
        {
            //Configuración del intervalo en la misma
            //declaración de clase por constructor
            systemTimer = new System.Timers.Timer(1); // Trigger every 1 ms
            
            systemTimer.Elapsed += (s, e) =>
            {
                systemCounter++;
                //Al definir el handler dentro y tener que actualizar un 
                //elemento gráfico, requerimos de Dispatcher
                Dispatcher.Invoke(() =>
                {
                    SystemTimerLabel.Content = $"Contador System Timer: " +
                    $"{systemCounter} ms";
                });
            };
            systemTimer.Start();
        }

        private void StartTimers_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Start();
            systemTimer.Start();

        }

        private void StopTimers_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer?.Stop();
            systemTimer?.Stop();
        }

        private void ResetTimers_Click(object sender, RoutedEventArgs e)
        {
            StopTimers_Click((object) sender, e);
            dispatcherCounter = 0;
            systemCounter = 0;

            //Actualizar el UI
            DispatcherLabel.Content = "Contador Dispatcher: 0 ms";
            SystemTimerLabel.Content = "Contador System Timer: 0 ms";
        }
    }
}