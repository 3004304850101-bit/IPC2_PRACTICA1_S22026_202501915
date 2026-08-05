public class Perro : Mascota
{
    public string Raza { get; set; }
    public string Tamaño { get; set; }
    public string Color { get; set; }

    public Perro(string nombre, int edad, double peso, string sexo, string propietario, string estado, string raza, string tamaño, string color)
        : base(nombre, edad, peso, sexo, propietario, estado)
    {
        Raza = raza;
        Tamaño = tamaño;
        Color = color;
    }

    public override void CalcularDosis(double dosis_kg)
    {
        double dosis = Peso * dosis_kg;
        Console.WriteLine($"La dosis para el perro {Nombre} es: {dosis:F2} mg");
    }
}