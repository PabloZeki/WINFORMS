using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Persona
    {
        public Persona(string nombre,string apellido,DateTime fechanacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechanacimiento = fechanacimiento;
        }
       
       



        private string nombre;
        private string apellido;
        private DateTime fechanacimiento;
       

        //public DateTime Fecha { get; set; }
        public string Chocolate { get; set; }
        public string Tipo { get; set; }
        public string ColorFavorito { get; set;}
        public string Numerofavorito { get; set; }



        public string Saludar()
        {
            return "El Nombre es: " + nombre + "," + "Su Apellido es: " + apellido + "," + "Su fecha de nacimiento es: " + fechanacimiento + "," + "¿Le gusta el chocolate? " + Chocolate + "," + Tipo + "," + ColorFavorito + "," + Numerofavorito;




        }
    }
}
