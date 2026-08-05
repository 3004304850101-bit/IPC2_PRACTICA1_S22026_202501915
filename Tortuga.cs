public class Tortuga : Mascota
{
    public string Especie { get; set; }
    public string Color { get; set; }
    public bool Acuatico { get; set; }

    public Tortuga(string nombre, int edad, double peso, string sexo, string propietario, string estado, string especie, string color, bool acuatico)
        : base(nombre, edad, peso, sexo, propietario, estado)
    {
        Especie = especie;
        Color = color;
        Acuatico = acuatico;
    }

    public override void CalcularDosis(double dosis_kg)
    {
        double dosis = Peso * dosis_kg * 0.80;
        Console.WriteLine($"La dosis para la tortuga {Nombre} es: {dosis:F2} mg");
    }
}