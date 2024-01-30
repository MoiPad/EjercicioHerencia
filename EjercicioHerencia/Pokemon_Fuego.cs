

using System.Globalization;

namespace EjercicioHerencia
{
    internal class Pokemon_Fuego : Pokemon
    {
      
        public int PoderDeFuego { get; set; }
        public string AtaqueEspecial { get; set; }
        public string AtaqueBasico { get; set; }
        public string AtaqueSecundario { get; set; }
        public bool PuedeVolar { get; set; }


        public Pokemon_Fuego(string nombre,string tipo ,int nivel, int vida ,int poderDeFuego, string ataqueEspecial, string ataqueBasico, string ataqueSecundario, bool puedeVolar) 
            : base(nombre, tipo, nivel, vida)
        {
            PoderDeFuego = poderDeFuego;
            AtaqueEspecial = ataqueEspecial;
            AtaqueBasico = ataqueBasico;
            AtaqueSecundario = ataqueSecundario;
            PuedeVolar = puedeVolar;
        }

        public void Imprimir() 
        {
            Console.WriteLine(new string('-', 154));
            string fila = "|{0,-15} |{1,-15} |{2,-10}  |{3,-10} |{4,-10} |{5,-15} |{6,-20} |{7,-25} |{8,-15}|";
            Console.WriteLine(String.Format(fila, Nombre, Tipo, Nivel, Vida, PoderDeFuego, AtaqueEspecial, AtaqueBasico, AtaqueSecundario, Validacion(PuedeVolar)));
        }
        public string Validacion(bool PuedeVolar)
        {
            return PuedeVolar ? "Si" : "No";
        }
    }
}
