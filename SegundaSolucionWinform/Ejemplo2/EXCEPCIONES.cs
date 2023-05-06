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
    public partial class EXCEPCIONES : Form
    {
        public EXCEPCIONES()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1, n2, Resultado;

            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            Resultado = n1 + n2;



        }
    }
}
