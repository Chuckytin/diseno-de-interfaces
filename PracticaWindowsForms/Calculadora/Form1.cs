namespace Calculadora
{
    public partial class Form1 : Form
    {

        Operacion Calculo = new(5, 2);

        public Form1()
        {
            InitializeComponent();

        }

        /*
         * 1. Crear función que se asignará como handler
         * 2. Extraer información del objeto que ha desatado el evento
         * 3. Extraer una propiedad del objeto creador del evento y utilizarla
         */

        public void addNumber(object sender, EventArgs e) 
        {
            var btn = (Button)sender;

            textBox1.Text = btn.Text;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
