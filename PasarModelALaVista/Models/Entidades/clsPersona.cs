using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PasarModelALaVista.Models
{
    public class clsPersona
    {
        public clsPersona() {
            this.nombre="";
            this.apellidos = "";
        }
        public clsPersona(String nombre, String apellidos) {

            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public int edad { get; set; }

    }
}