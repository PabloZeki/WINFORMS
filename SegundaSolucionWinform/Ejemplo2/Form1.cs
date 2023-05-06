using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;      // guardamos el texto de la textbox
            lwElementos.Items.Add(elem);        // agregamos objetos previamente cargados de la textbox      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");         // agregamos elementos a la lista desplegable
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Amarillo");
        }

       
       
        

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            DateTime fechanacimiento;
           fechanacimiento = dtpFechaNacimiento.Value;

            if(txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;

            }
            else 
            { 
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                
            }
            if(txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
            }

            Persona p1 = new Persona(txtNombre.Text,txtApellido.Text,fechanacimiento);

            


            p1.Chocolate = cbxChocolate.Checked == true ? "Si le gusta..." : "Odia el chocolate...";


           
            
            //string nombre = txtNombre.Text;          // Capturamos el nombre igresado en la textbox
            // DateTime fecha = dtpFechaNacimiento.Value;   // Capturamos la fecha de nacimiento ingresada
           // string chocolate = cbxChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate"; // operador ternario ? es un if de una sola linea pregunta si esta tildado el cheked box
            string tipo;
         

            if (rbMuggle.Checked)
            {
                tipo = "Muggle";

            }else if (rdWizard.Checked)       // capturamos segun lo que selecciona el usuario de radiobuton
            {
                tipo = "Wizard";

            }
            else
            {
                tipo = "Squibs";
            }

            p1.Tipo = tipo;


            p1.ColorFavorito = cboColorFavorito.SelectedItem.ToString();
            p1.Numerofavorito = nudNumeroFavorito.Value.ToString();

            MessageBox.Show(p1.Saludar());

           // string colorfavorito = cboColorFavorito.SelectedItem.ToString(); // caturar el objeto elejido de la lista desplegable
          // string numerofavorito = nudNumeroFavorito.Value.ToString();    // para capturar el numero elejido 

           

        }

        
    }
}
