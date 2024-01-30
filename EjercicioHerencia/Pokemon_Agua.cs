

namespace EjercicioHerencia
{
    internal class Pokemon_Agua : Pokemon
    {
        public int PoderDeAgua { get; set; }
        public string AtaqueEspecial { get; set; }
        public string AtaqueBasico { get; set; }
        public string AtaqueSecundario { get; set; }
        public bool PuedeVolar { get; set; }

        public Pokemon_Agua(string nombre, string tipo, int nivel, int vida, int poderDeAgua, string ataqueEspecial, string ataqieBasico, string ataqueSecundario, bool puedeVolar)
        : base(nombre, tipo, nivel, vida)
        {
            PoderDeAgua = poderDeAgua;
            AtaqueEspecial = ataqueEspecial;
            AtaqueBasico = ataqieBasico;
            AtaqueSecundario = ataqueSecundario;
            PuedeVolar = puedeVolar;

        }

        public void Imprimmir() 
        {
            Console.WriteLine(new string('-', 154));
            string Fila = "|{0,-15} |{1,-15} |{2,-10}  |{3,-10} |{4,-10} |{5,-15} |{6,-20} |{7,-25} |{8,-15}|";
            Console.WriteLine(String.Format(Fila, Nombre, Tipo, Nivel, Vida, PoderDeAgua, AtaqueEspecial, AtaqueBasico, AtaqueSecundario, Validacion(PuedeVolar)));
        }

        public string Validacion(bool PuedeVolar) 
        {
            return PuedeVolar ? "Si" : "No";
        }
    }
}
