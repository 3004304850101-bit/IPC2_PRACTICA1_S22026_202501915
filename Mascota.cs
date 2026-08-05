public abstract class Mascota
{
    public string Nombre { get; set; }
    public double Peso { get; set; }
    public string Sexo { get; set; }
    public int Edad { get; set; }
    public string Propietario { get; set; }
    public string Id { get; set; }
    public string Estado { get; set; }
    private static Random random = new Random();
    
    public static string IdMascota(){
    string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    string id = "";

    for (int i = 1; i <= 8; i++){
        int num = random.Next(0, caracteres.Length);
        id += caracteres.Substring(num, 1);
    }
    return id;
    }

    public Mascota(string nombre, int edad, double peso, string sexo, string propietario, string estado)
    {
        Nombre = nombre;
        Edad = edad;
        Peso = peso;
        Sexo = sexo;
        Propietario = propietario;
        Id = IdMascota();
        Estado = estado;
    }

    public abstract void CalcularDosis(double dosis_kg);

    public void CambiarEstado(string nuevoEstado)
    {
        Estado = nuevoEstado;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine($"Peso: {Peso} kg");
        Console.WriteLine($"Sexo: {Sexo}");
        Console.WriteLine($"Propietario: {Propietario}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Estado: {Estado}");
    }
}
    