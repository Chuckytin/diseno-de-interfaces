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

namespace ClickGame_Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //1. Generar los elementos del interfaz gráfico
        //2. Declaración de variables      
        DispatcherTimer gameTimer = new DispatcherTimer(); 
        List<Ellipse> removeThis = new List<Ellipse>();

        //3 Declaración de integers necesarios para el juego
        int spawnRate = 60; // default spawn rate of the circles
        int currentRate; // current rate will help add an interval between spawning of the circles
        int lastScore = 0; // this will hold the last played score for this game
        int health = 350; // total health of the player in the begining of the game
        int posX; // x position of the circles
        int posY; // y position of the circles
        private SolidColorBrush brush;
        int score = 0; // current score for the game
        double growthRate = 0.6; // the default growth rate for each circle in the game
        Random rand = new Random(); // a random number generator

        //4. Declaración de dos media player
        MediaPlayer playClickSound = new MediaPlayer();
        MediaPlayer playerPopSound = new MediaPlayer();

        //5. Dos URI (Idenficador de recursos uniforme ) location classes para ambos archviso mp3
        //importados para el juego
        Uri ClickedSound;
        Uri PoppedSound;

        //6.

        public MainWindow()
        {
            InitializeComponent();

            //configuración del timer
            gameTimer.Tick += GameLoop;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Start();

            //definición de los reproductores
            ClickedSound = new Uri("pack://siteoforigin:,,,/sound/clickedpop.mp3");
            PoppedSound = new Uri("pack://siteoforigin:,,,/sound/pop.mp3");
            
            //inicializar currentRate
            currentRate = spawnRate;

        }

        private void GameLoop(object sender, EventArgs e)
        {

            txtScore.Content = "Puntuación: " + score;
            txtLastScore.Content = "Última puntuación: " + lastScore;

            currentRate -= 2;

            if (currentRate < 1)
            {
                currentRate = spawnRate;
                
                posX = rand.Next(15, 700);
                posY = rand.Next(50, 350);

                //creación del color
                brush = new SolidColorBrush(Color.FromRgb((byte)rand.Next(1, 255),
                    (byte)rand.Next(1, 255), (byte)rand.Next(1, 255)));

                //crea los circulos
                Ellipse circle = new Ellipse
                {
                    Tag = "circle",
                    Height = 10,
                    Width = 10,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    Fill = brush
                };

                Canvas.SetLeft(circle, posX);
                Canvas.SetTop(circle, posY);

                MyCanvas.Children.Add(circle);

            }

            foreach (var item in MyCanvas.Children.OfType<Ellipse>())
            {
                //busca las elipses que existen
                item.Height += growthRate; 
                item.Width += growthRate; 
                item.RenderTransformOrigin = new Point(0.5, 0.5); //el origen de la transformación es en el centro

                if (item.Width > 70)
                {
                    removeThis.Add(item);
                    health -= 15;
                    playerPopSound.Open(PoppedSound);
                    playerPopSound.Play();
                }

            }

            if (health > 1)
            {
                healthBar.Width = health;
            }
            else 
            {
                GameOverFunction();
            }

            //elimina los circulos
            foreach (Ellipse item in removeThis)
            {
                MyCanvas.Children.Remove(item);
            }

            //tras 5 la velocidad de spawn aumenta
            if (score > 5)
            {
                spawnRate = 25;
            }

            //tras 20 la velocidad aumenta
            if (score > 20)
            {
                spawnRate = 15;
                growthRate = 1.5;
            }

        }

        private void ClickOnCanvas(object sender, MouseButtonEventArgs e)
        {

            if (e.OriginalSource is Ellipse)
            {
                Ellipse circle = (Ellipse)e.OriginalSource;

                MyCanvas.Children.Remove(circle);

                score++;

                playClickSound.Open(ClickedSound);
                playClickSound.Play();
            }

        }

        private void GameOverFunction()
        {
            gameTimer.Stop();
            MessageBox.Show("GAME OVER" + Environment.NewLine + "Tu puntuación es: " + score + 
                Environment.NewLine + "¡Clicl Ok para volver a jugar!");

            //identificación de burbujas
            foreach (var item in MyCanvas.Children.OfType<Ellipse>())
            {
                removeThis.Add(item);
            }

            //eliminación
            foreach (Ellipse item in removeThis)
            {
                MyCanvas.Children.Remove(item);
            }

            //iniciación de variables
            growthRate = .6;
            spawnRate = 60;
            lastScore = score;
            score = 0;
            currentRate = 5;
            health = 350;
            removeThis.Clear();
            gameTimer.Start();

        }

    }
}