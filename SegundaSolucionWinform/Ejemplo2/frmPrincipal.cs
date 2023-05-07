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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)  // con esto recorremos los objetos de tipo forms que esten abiertos en memoria en este momento
            {
                if (item.GetType() == typeof(Form1))   // aca preguntamos con (gettype),si el tipo de objeto es igual o coincide con el mismo tipo de form1..si cocincide es que hay una ventana abierta y no me permite abrir otra
                {
                    MessageBox.Show("Termine de trabajar en la ventana actual");

                    return;
                }
                
            }
            Form1 ventana = new Form1();// creamos la instancia del objeto form1,ya no es la ventana principal
            ventana.MdiParent = this;     // Con esto le avisamo que que queremos que la ventana perfil persona se abra dentro de ventana principal
           // ventana.ShowDialog();               // para abrir la ventana del form1 que esta perfil persona,(Show dialog es para abrir una ventana por vez)
            ventana.Show();             // en este caso como habilitamos el parent de que queremos que la ventana perfil persona se abra dentro de la ventana principal no podemos usar showdialog
        }

        private void fechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)

            { 
                if (item.GetType() == typeof(EJEMPLO_FECHAS))
                {
                    MessageBox.Show("Termine de trabajar en la ventana actual");

                    return;

                }
                

             } 
            EJEMPLO_FECHAS fecha = new EJEMPLO_FECHAS();
            fecha.MdiParent = this;
            fecha.Show();
        }

        private void ecepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(EXCEPCIONES))
                {
                    MessageBox.Show("Termine de trabajar en la ventana actual");

                    return;

                }


            }
            EXCEPCIONES excepciones = new EXCEPCIONES();
           excepciones.MdiParent = this;
            excepciones.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(CALCULADORA))
                {
                    MessageBox.Show("Termine de trabajar en la ventana actual");

                    return;

                }


            }
            CALCULADORA calculadora = new CALCULADORA();
            calculadora.MdiParent = this;
            calculadora.Show();
        }
    }
}
