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
    public partial class EJEMPLO_FECHAS : Form
    {
        public EJEMPLO_FECHAS()
        {
            InitializeComponent();
        }

        private void prb1_Click(object sender, EventArgs e)
        {
            DateTime fecha1;         // creamos una variable del tipo datetime

            fecha1 = dtpfecha.Value; // capturamos la fecha del btnprueba (datepicker),guardamos en var fecha1;

            MessageBox.Show("La fecha seleccionada es: " + fecha1.ToString("dd/MM/yyyy"));   // Mostramos el contenido de la variable fecha1
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es: " + calfecha.SelectionStart.ToString("dd/MM/yyyy"));
        }
    }
}
