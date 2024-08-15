﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaria.Models
{
    internal class Persona
    {
        public int Dni
        {
            get; private set;
        }

        public string Nombre 
        { 
            get; private set;
        }

        public Persona(int dni, string nombre) 
        {
            Dni = dni;
            Nombre = nombre;
        }

        public string VerDatos()
        {
            string datos = $"Dni: {Dni} Nombre: {Nombre}";
            return datos;
        }
    }
}
