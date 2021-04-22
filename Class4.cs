using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto2
{
    class Persona
    {
        string nombre;
        string apellido;

        public string nombreCompleto
        {
            get => this.nombre + " " + this.apellido;
        }



        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }
}
