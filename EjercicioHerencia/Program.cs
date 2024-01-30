

using EjercicioHerencia;

static void Cabecera() 
{
    Console.WriteLine(new string('-', 154));
    string Cabecera = "|{0,-15} |{1,-15} |{2,-10}  |{3,-10} |{4,-10} |{5,-15} |{6,-20} |{7,-25} |{8,-15}|";
    Console.WriteLine(String.Format(Cabecera, "Nombre", "Tipo", "Nivel", "Vida", "Poder", "Ataque Especial", "Ataque Basico", "Ataque Secundario", "Puede Volar"));
}

Pokemon_Fuego charmander = new Pokemon_Fuego("Charmander", "Fuego", 6, 100, 15, "Lanzallamas", "Mar de LLamas", "Poder Solar", false);
Cabecera();
charmander.Imprimir();

Pokemon_Trueno pikachu = new Pokemon_Trueno("Pikachu","Trueno",10,150,20,"Attack-Trueno","Impac-trueno","Voltio-Cruel",false);
pikachu.Imprimir();

Pokemon_Agua squirtle = new Pokemon_Agua("Squirtle","Agua",8,160,20,"Hidro Bomba","Placaje", "Golpe Cabeza",false );
squirtle.Imprimmir();
Console.WriteLine(new string('-', 154));



