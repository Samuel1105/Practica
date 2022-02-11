using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Persona
    {
        string Nombre;
        int Edad;

        public string Tnombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int Tedad
        {
            get { return Edad; }
            set { Edad = value; }
        }
    }
}
