using System;

int opcion;
List<Mascota> mascotas = new List<Mascota>();
string nombre;
int edad;
double peso;
string sexo;
string propietario;
string estado;

do
{
    Console.WriteLine("==================VETERINARIA==================");
    Console.WriteLine("Menú de opciones:");
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("[1] Registrar mascota");
    Console.WriteLine("[2] Gestionar mascotas");
    Console.WriteLine("[3] Salir");
    Console.Write("Opción: ");
    int.TryParse(Console.ReadLine(), out opcion);
    Console.Clear();
    switch (opcion)
    {
        case 1:
            // Lógica para registrar una mascota
           Console.WriteLine("==================REGISTRAR MASCOTA==================");
           Console.WriteLine("Seleccione el tipo de mascota a registrar:");
           Console.WriteLine("[1] Perro");
           Console.WriteLine("[2] Gato");
           Console.WriteLine("[3] Ave");
           Console.WriteLine("[4] Tortuga");
              Console.Write("Opción: ");
              int tipoMascota;
                int.TryParse(Console.ReadLine(), out tipoMascota);
                Console.Clear();
                switch (tipoMascota)
                {
                    case 1:
                        // Lógica para registrar un perro
                        Console.WriteLine("==================PERRO==================");
                        (nombre, edad, peso, sexo, propietario, estado) = RegistroBasico();
                        Console.WriteLine("Ingrese la raza de la mascota:");
                        string razaPerro = Console.ReadLine() ?? "";
                        Console.WriteLine("Ingrese el tamaño de la mascota:");
                        string tamañoPerro = Console.ReadLine() ?? "";
                        Console.WriteLine("Ingrese el color de la mascota:");
                        string colorPerro = Console.ReadLine() ?? "";
                        Perro nuevoPerro = new Perro(nombre, edad, peso, sexo, propietario, estado, razaPerro, tamañoPerro, colorPerro);
                        Console.WriteLine($"Se ha registrado un nuevo perro con ID: {nuevoPerro.Id}");
                        Mascota mascotaPerro = nuevoPerro;
                        mascotas.Add(mascotaPerro);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        // Lógica para registrar un gato
                        Console.WriteLine("==================GATO==================");
                        (nombre, edad, peso, sexo, propietario, estado) = RegistroBasico();
                        Console.WriteLine("Ingrese la raza de la mascota:");
                        string razaGato = Console.ReadLine() ?? "";
                        Console.WriteLine("Ingrese el color de la mascota:");
                        string colorGato = Console.ReadLine() ?? "";
                        Console.WriteLine("¿Está esterilizado? (S/N):");
                        bool esterilizado = false;
                        string esterilizadoInput = Console.ReadLine() ?? "";
                        if (esterilizadoInput.ToUpper() == "S")
                        {
                            esterilizado= true;
                        }
                        else if (esterilizadoInput.ToUpper() == "N")
                        {
                            esterilizado= false;
                        }
                        Gato nuevoGato = new Gato(nombre, edad, peso, sexo, propietario, estado, razaGato, colorGato, esterilizado);
                        Mascota mascotaGato = nuevoGato;
                        mascotas.Add(mascotaGato);
                        Console.WriteLine($"Se ha registrado un nuevo gato con ID: {nuevoGato.Id}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        // Lógica para registrar un ave
                        Console.WriteLine("==================AVE==================");
                        (nombre, edad, peso, sexo, propietario, estado) = RegistroBasico();
                        Console.WriteLine("Ingrese la especie del ave:");
                        string especieAve = Console.ReadLine() ?? "";
                        Console.WriteLine("Ingrese el color del ave:");
                        string colorAve = Console.ReadLine() ?? "";
                        Console.WriteLine("Ingrese la envergadura del ave:");
                        string envergaduraAve = Console.ReadLine() ?? "";
                        Console.WriteLine("¿Puede volar? (S/N):");
                        string volarInput = Console.ReadLine() ?? "";
                        bool volar = volarInput.ToUpper() == "S";
                        Ave nuevoAve = new Ave(nombre, edad, peso, sexo, propietario, estado, especieAve, colorAve, envergaduraAve, volar);
                        Mascota mascotaAve = nuevoAve;
                        mascotas.Add(mascotaAve);
                        Console.WriteLine($"Se ha registrado un nuevo ave con ID: {nuevoAve.Id}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        // Lógica para registrar una tortuga
                        Console.WriteLine("==================TORTUGA==================");
                        (nombre, edad, peso, sexo, propietario, estado) = RegistroBasico();
                        Console.WriteLine("Ingrese la especie de la tortuga:");
                        string especieTortuga = Console.ReadLine() ?? "";
                        Console.WriteLine("Ingrese el color de la tortuga:");
                        string colorTortuga = Console.ReadLine() ?? "";
                        Console.WriteLine("¿Es acuática? (S/N):");
                        bool acuatico = false;
                        string acuaticoInput = Console.ReadLine() ?? "";
                        if (acuaticoInput.ToUpper() == "S")
                        {
                            acuatico = true;
                        }
                        else if (acuaticoInput.ToUpper() == "N")
                        {
                            acuatico = false;
                        }
                        Tortuga nuevaTortuga = new Tortuga(nombre, edad, peso, sexo, propietario, estado, especieTortuga, colorTortuga, acuatico);
                        Mascota mascotaTortuga = nuevaTortuga;
                        mascotas.Add(mascotaTortuga);
                        Console.WriteLine($"Se ha registrado un nueva tortuga con ID: {nuevaTortuga.Id}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            Console.Clear();
           break;
        case 2:
            // Lógica para gestionar mascotas
            Console.WriteLine("==================GESTIONAR MASCOTAS==================");
            if (mascotas.Count == 0)
            {
                Console.WriteLine("No hay mascotas registradas.");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("[1] Mostrar información de todas las mascotas");
            Console.WriteLine("[2] Cambiar estado de una mascota");
            Console.WriteLine("[3] Calcular dosis de una mascota");
            Console.WriteLine("[4] Buscar mascota por ID");
            Console.Write("Opción: ");
            int opcionGestion;
            int.TryParse(Console.ReadLine(), out opcionGestion);
            Console.Clear();
            switch(opcionGestion)
            {
                case 1:
                    // Mostrar información de todas las mascotas
                    foreach (var mascota in mascotas)
                    {
                        mascota.MostrarInformacion();

                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    // Cambiar estado de una mascota
                    Console.WriteLine("Ingrese el ID de la mascota:");
                    string idCambioEstado = Console.ReadLine() ?? "";
                    Mascota? mascotaCambioEstado = mascotas.Find(m => m.Id == idCambioEstado);
                    if (mascotaCambioEstado != null)
                    {
                        Console.WriteLine($"Estado actual: {mascotaCambioEstado.Estado}");
                        Console.WriteLine("Ingrese el nuevo estado (enfermo[-]/sano[+]):");
                        string nuevoEstado = Console.ReadLine() ?? "";
                        mascotaCambioEstado.CambiarEstado(nuevoEstado);
                        Console.WriteLine("Estado actualizado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ninguna mascota con ese ID");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    // Calcular dosis de una mascota
                    Console.WriteLine("Ingrese el ID de la mascota:");
                    string idCalcularDosis = Console.ReadLine() ?? "";
                    Mascota? mascotaCalcularDosis = mascotas.Find(m => m.Id == idCalcularDosis);
                    if (mascotaCalcularDosis != null)
                    {
                        Console.WriteLine("Ingrese la dosis por kg:");
                        double dosisKg;
                        while (!double.TryParse(Console.ReadLine(), out dosisKg) || dosisKg < 0)
                        {
                            Console.WriteLine("Dosis inválida. Por favor, ingrese un número no negativo.");
                            Console.WriteLine("Ingrese la dosis por kg:");
                        }
                        mascotaCalcularDosis.CalcularDosis(dosisKg);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ninguna mascota con ese ID");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    // Buscar mascota por ID
                    Console.WriteLine("Ingrese el ID de la mascota:");
                    string idBuscar = Console.ReadLine() ?? "";
                    Mascota? mascotaBuscar = mascotas.Find(m => m.Id == idBuscar);
                    if (mascotaBuscar != null)
                    {
                        mascotaBuscar.MostrarInformacion();
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ninguna mascota con ese ID");
                    }
                    Console.ReadKey();
                    Console.Clear();
            break;
            default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida");
                    break;
            }
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida");
            Console.Clear();
            break;
    }
}while(opcion != 3);
    Console.Clear();


 (string nombre, int edad, double peso, string sexo, string propietario, string estado) RegistroBasico()
{
        Console.WriteLine("Ingrese el nombre de la mascota:");
        string nombre = Console.ReadLine() ?? "";
        Console.WriteLine("Ingrese la edad de la mascota:");
        int edad;
        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
            {
            Console.WriteLine("Edad inválida. Por favor, ingrese un número entero no negativo");
            Console.WriteLine("Ingrese la edad de la mascota:");
            }
            Console.WriteLine("Ingrese el peso de la mascota (en kg):");
                double peso;
                while (!double.TryParse(Console.ReadLine(), out peso) || peso < 0)
            {
            Console.WriteLine("Peso inválido. Por favor, ingrese un número no negativo");
            Console.WriteLine("Ingrese el peso de la mascota (en kg):");
            }
            Console.WriteLine("Ingrese el sexo de la mascota (M/F):");
            string sexo = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese el nombre del propietario:");
            string propietario = Console.ReadLine() ?? "";
            Console.WriteLine("Ingrese el estado de la mascota (enfermo[-]/sano[+]):");
            string estado = Console.ReadLine() ?? "";

            return (nombre, edad, peso, sexo, propietario, estado);
}


