using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PasarModelALaVista.Models
{
    public class clsListadoPersona
    {

        //public List<clsPersona> listadoPersona { get; set; }
        public List<clsPersona> llenarLista() {
            List<clsPersona> listadoPersona;
            listadoPersona = new List<clsPersona>();
            listadoPersona.Add(new clsPersona("Alejandro", "ortiz"));
            listadoPersona.Add(new clsPersona("Alberto", "Bejarano"));
            listadoPersona.Add(new clsPersona("Manuel", "quintero"));
            return listadoPersona;
        }
       
    }
}