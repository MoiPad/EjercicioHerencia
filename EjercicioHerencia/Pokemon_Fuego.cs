

namespace EjercicioHerencia
{
    internal class Pokemon_Fuego : Pokemon
    {
      
        public int PoderFire { get; set; }
        public string AtaqueEspecial { get; set; }
        public string AtaqueBasico { get; set; }
        public string AtaqueSecundario { get; set; }
        public bool PuedeVolar { get; set; }


        public Pokemon_Fuego(int poderFire, string ataqueEspecial, string ataqueBasico, string ataqueSecundario, bool puedeVolar) 
        {
            PoderFire = poderFire;
            AtaqueEspecial = ataqueEspecial;
            AtaqueBasico = ataqueBasico;
            AtaqueSecundario = ataqueSecundario;
            PuedeVolar = puedeVolar;
        }
    }
}
