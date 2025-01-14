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

namespace WpfApp1
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public const string PIEDRA = "PIEDRA";
        public const string PAPEL = "PAPEL";
        public const string TIJERA = "TIJERA";

        public Random Random = new Random();

        private void Jugar(String opcionJugador)
        {
            string eleccionMaquina = opcionMaquina();
            string resultadoFinal = resultadoRonda(opcionJugador, eleccionMaquina);

            lbl_opcion_maquina.Content = $"OPCIÓN DE LA MÁQUINA\n\t{eleccionMaquina}";
            lbl_resultado.Content = $"{resultadoFinal}";

        }

        private string opcionMaquina()
        {
            string[] opciones = { PIEDRA, PAPEL, TIJERA };
            return opciones[Random.Next(opciones.Length)];
        }

        private string resultadoRonda(string opcionJugador, string opcionMaquina)
        {
            if (opcionJugador == opcionMaquina)
            {
                return "EMPATE";
            }
            else if ((opcionJugador.Equals(PIEDRA) && opcionMaquina.Equals(TIJERA)) ||
                (opcionJugador.Equals(PAPEL) && opcionMaquina.Equals(PIEDRA)) ||
                (opcionJugador.Equals(TIJERA) && opcionMaquina.Equals(PAPEL)))
            {
                return "GANA EL JUGADOR";
            }
            else
            {
                return "GANA LA MÁQUINA";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Jugar(PIEDRA);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Jugar(PAPEL);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Jugar(TIJERA);
        }
    }
}
