using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class CALCULADORA : Form
    {

        public CALCULADORA()
        {
            InitializeComponent();
        }
       

        string num1 = "";
        string num2 = "";
        string operacion = "";

        private void CALCULADORA_Load(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            string numero = btn.Text;

            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;

            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }



        private void button0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;
            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;
            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;
            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;
            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;
            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;
            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;
            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;
            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;
            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string numero = btn.Text;
            if (operacion == "")
            {
                num1 += numero;
                txtResultado.Text = num1;
            }
            else
            {
                num2 += numero;
                txtResultado.Text = num1 + operacion + num2;
            }
        }
       
       
        private void buttonSumar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacion = btn.Text;
            txtResultado.Text = num1 + operacion;
        }



        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacion = btn.Text;
            txtResultado.Text = num1 + operacion;

        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacion = btn.Text;
            txtResultado.Text = num1 + operacion;
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacion = btn.Text;
            txtResultado.Text = num1 + operacion;
        }
        private void buttonResultado_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = 0;
                double n1 = double.Parse(num1);
                double n2 = double.Parse(num2);
                switch (operacion)
                {
                    case "+":
                        resultado = n1 + n2;
                        break;
                    case "-":
                        resultado = n1 - n2;
                        break;
                    case "x":
                        resultado = n1 * n2;
                        break;
                    case "/":
                        resultado = n1 / n2;
                        break;
                }
                txtResultado.Text = resultado.ToString();

                num1 = resultado.ToString();
                num2 = "";
                operacion = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingreso invalido");
            }
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            operacion = "";
            txtResultado.Text = "0";
        }

       
    }
}
