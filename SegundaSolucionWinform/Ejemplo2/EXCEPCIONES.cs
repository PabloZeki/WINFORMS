using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class EXCEPCIONES : Form
    {
        public EXCEPCIONES()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, Resultado;

                n1 = int.Parse(textBox1.Text);
                n2 = int.Parse(textBox2.Text);
                Resultado = n1 / n2;

                lblResultado.Text = "=" + Resultado.ToString();

            }
            catch (DivideByZeroException ex) 
            {
                MessageBox.Show("No se puede divir por 0");
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Ingrese solo Numeros por favor");               // si le ponemos ex.ToString nos tira el tipo de error que se ejecuto en el momento
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingreso invalido");
            }

        }
    }
}
