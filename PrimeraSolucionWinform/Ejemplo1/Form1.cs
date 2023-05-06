using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hola mundo");
            string texto = textNombre.Text; // para capturar el texto de la caja de texto en este caso el nombre
                                            // guardamos en una variable de tipo string llamada texto
            lblSaludo.Text = " HOLA " + texto; // aca le asignamos la variable texto a la etiaqueta saludo                              
        }                                   // entonces al hacer click en button1 me saluda con elnombre que cargue en textbox

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("BIENVENIDO");
        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // MessageBox.Show("Gracias por utilizar la app...");    // evento cuando queremos dejar un mensaje al cerrar la app
        }

        private void chkApellido_CheckedChanged(object sender, EventArgs e)
        {
            string apellido = textApellido.Text;
            lblmostrarapellido.Text =" Su apellido es: " + apellido; 
        }

        private void chkDni_CheckedChanged(object sender, EventArgs e)
        {
            string dni = textDni.Text;
            lblMostrardni.Text = " Su dni es: " + dni;
        }
    }
}
