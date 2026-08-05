public class Gato : Mascota
{
    public string Raza { get; set; }
    public string Color { get; set; }
    public bool Estirilizado { get; set; }

    public Gato(string nombre, int edad, double peso, string sexo, string propietario, string estado, string raza, string color, bool estirilizado)
        : base(nombre, edad, peso, sexo, propietario, estado)
    {
        Raza = raza;
        Color = color;
        Estirilizado = estirilizado;
    }

    public override void CalcularDosis(double dosis_kg)
    {
        double dosis = Peso*dosis_kg*0.90;
        Console.WriteLine($"La dosis para el gato {Nombre} es: {dosis:F2} mg");
    }
}