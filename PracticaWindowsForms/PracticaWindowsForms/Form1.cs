using System.Windows.Forms;

namespace PracticaWindowsForms
{
    public partial class Form1 : Form
    {
        // Constantes
        public const int numMin = 0;
        public const int numMax = 10;
        public const int MAX_INTENTOS = 3;

        // Variables
        private Random random;
        private int numRandom;
        private string cadenaDelTexto;
        private int intentosRestantes = MAX_INTENTOS;

        // Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            GenerarNuevoNumero();
            label_info.Text = $"Adivina del {numMin} al {numMax}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numElegido = Convert.ToInt32(textBox1.Text);

            if (numElegido < numRandom)
            {
                cadenaDelTexto = "Demasiado bajo\n";
                intentosRestantes--;
            }
            else if (numElegido > numRandom)
            {
                cadenaDelTexto = "Demasiado alto\n";
                intentosRestantes--;
            }
            else
            {
                cadenaDelTexto = "¡Acertaste!\n";
                MessageBox.Show($"¡Felicitaciones! Has acertado.\nEl número era: {numRandom}");

                Application.Exit();
            }

            textBox1.Clear();
            textBox1.AppendText(cadenaDelTexto);
            label_intentos.Text = $"Intentos restantes: {intentosRestantes}";
    
            if (intentosRestantes == 0)
            {
                MessageBox.Show("Has agotado todos tus intentos. ¡Gracias por jugar!");

                GenerarNuevoNumero();
                label_info.Text = $"Adivina un número entre {numMin} y {numMax}";
                textBox1.Clear();
                label_intentos.Text = "Intentos";
                intentosRestantes = MAX_INTENTOS;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void GenerarNuevoNumero()
        {
            numRandom = random.Next(numMin, numMax + 1);
        }
    }
}
