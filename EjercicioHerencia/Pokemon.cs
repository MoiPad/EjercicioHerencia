using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Pokemon
    {
        public string Nombre { get; set;}
        public string Tipo { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }

        public Pokemon() { }
        public Pokemon( string nombre, string tipo, int nivel, int vida) {
            Nombre = nombre;
            Tipo = tipo;
            Nivel = nivel;
            Vida = vida;
        }
    }
}
