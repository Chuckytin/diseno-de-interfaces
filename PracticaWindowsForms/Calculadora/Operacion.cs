using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacion
    {

        public double resultado;

        public double num1;
        public double num2;
        public string display;

        public Operacion (double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public Operacion (double num1, double num2, double resultado, string display) : this(num1, num2)
        {
            this.resultado = resultado;
            this.display = display;
        }

        //Registra la operación pulsada
        //1 (suma) 2 (resta) 3 (multiplicación) 4 (divisón)
        public int regOperacion 
        {
            get { return regOperacion; }
            set { regOperacion = value; }
        }

        public void OpSuma(double num1, double num2)
        {
            resultado = num1 + num2;
        }

        public void OpResta(double num1, double num2)
        {
            resultado = num1 - num2;
        }

        public void OpMultiplicacion(double num1, double num2)
        {
            resultado = num1 * num2;
        }

        public void OpDivision(double num1, double num2)
        {
            resultado = num1 / num2;
        }

        public void opClean()
        {
            num1 = 0;
            num2 = 0;
            resultado = 0;
            display = "";
        }
    }
}
