using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Operacion calculator = new Operacion(0, 0);

        public Form1()
        {
            InitializeComponent();
            lbl_op.Text = "";
        }

        private void addNumber(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (textBox1.Text == "0" || textBox1.Text == "")
                textBox1.Text = btn.Text;
            else
                textBox1.Text += btn.Text;
        }

        private void getOperator(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            calculator.regOperacion = Convert.ToInt32(btn.Tag);
            calculator.num1 = Convert.ToDouble(textBox1.Text);

            switch (calculator.regOperacion)
            {
                case 1:
                    lbl_op.Text = textBox1.Text + " + ";
                    break;
                case 2:
                    lbl_op.Text = textBox1.Text + " - ";
                    break;
                case 3:
                    lbl_op.Text = textBox1.Text + " x ";
                    break;
                case 4:
                    lbl_op.Text = textBox1.Text + " / ";
                    break;
                default:
                    break;
            }

            textBox1.Text = "0";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.num2 = Convert.ToDouble(textBox1.Text);

                switch (calculator.regOperacion)
                {
                    case 1:
                        lbl_op.Text = textBox1.Text + " = ";
                        calculator.OpSuma(calculator.num1, calculator.num2);
                        break;
                    case 2:
                        lbl_op.Text = textBox1.Text + " = ";
                        calculator.OpResta(calculator.num1, calculator.num2);
                        break;
                    case 3:
                        calculator.OpMultiplicacion(calculator.num1, calculator.num2);
                        lbl_op.Text = textBox1.Text + " = ";
                        break;
                    case 4:
                        if (double.Parse(textBox1.Text) != 0)
                            calculator.OpDivision(calculator.num1, calculator.num2);
                        else
                            MessageBox.Show("No se puede dividir por cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lbl_op.Text = textBox1.Text + " = ";
                        break;
                    default:
                        break;
                }

                textBox1.Text = calculator.resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            calculator.opClean();
            lbl_op.Text = "";
            textBox1.Text = "0";
        }

        private void btn_coma_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text += ",";
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            number *= -1;
            textBox1.Text = number.ToString();
        }

        private void btn_mas_menos_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            number *= -1;
            textBox1.Text = number.ToString();
        }
    }
}
