public class Ave : Mascota
{
    public string Especie { get; set; }
    public string Color { get; set; }
    public string Envergadura { get; set; }
    public bool Volar { get; set; }

    public Ave(string nombre, int edad, double peso, string sexo, string propietario, string estado, string especie, string color, string envergadura, bool volar)
        : base(nombre, edad, peso, sexo, propietario, estado)
    {
        Especie = especie;
        Color = color;
        Envergadura = envergadura;
        Volar = volar;
    }

    public override void CalcularDosis(double dosis_kg)
    {
        double dosis = Peso * dosis_kg * 0.5;
        Console.WriteLine($"La dosis para el ave {Nombre} es: {dosis:F2} mg");
    }
}