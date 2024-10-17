using HerenciaQ42024;

Vertebrado vertebrado = new Vertebrado();
Invertebrado invertebrado = new Invertebrado();
int opcion;

Console.WriteLine("***************************");
Console.WriteLine("*           MENU          *");
Console.WriteLine("* 1. Animal Vertebrado    *");
Console.WriteLine("* 2. Animal Invertebrado  *");
Console.WriteLine("***************************");
Console.WriteLine("Escoja la opción:");
opcion = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
switch (opcion)
{
    case 1:
        Console.WriteLine("Escriba el nombre:");
        vertebrado.Nombre = Console.ReadLine();

        Console.WriteLine("Escriba la edad:");
        vertebrado.Edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba la especie:");
        vertebrado.Especie = Console.ReadLine();

        Console.WriteLine("Escriba el habitat:");
        vertebrado.Habitat = Console.ReadLine();

        Console.WriteLine("Escriba el tipo de esqueleto:");
        vertebrado.TipoEsqueleto = Console.ReadLine();

        Console.WriteLine("Escriba el número de extremidades:");
        vertebrado.NumeroExtremidades = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba el tipo de sangre:");
        vertebrado.TipoSangre = Console.ReadLine();

        Console.WriteLine("Escriba la dieta:");
        vertebrado.Dieta = Console.ReadLine();

        Console.WriteLine("Escriba la expectativa de vida:");
        vertebrado.ExpectativaVida = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba la reproducción:");
        vertebrado.Reproduccion = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("-----------------------------------------");
        vertebrado.Imprimir();
        break;

    case 2:
        Console.WriteLine("Escriba el nombre:");
        invertebrado.Nombre = Console.ReadLine();

        Console.WriteLine("Escriba la edad:");
        invertebrado.Edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba la especie:");
        invertebrado.Especie = Console.ReadLine();

        Console.WriteLine("Escriba el habitat:");
        invertebrado.Habitat = Console.ReadLine();

        Console.WriteLine("Escriba el tipo de cuerpo:");
        invertebrado.TipoCuerpo = Console.ReadLine();

        Console.WriteLine("Escriba el método de reproducción:");
        invertebrado.MetodoReproduccion = Console.ReadLine();

        Console.WriteLine("Escriba el tipo de alimentación:");
        invertebrado.TipoAlimentacion = Console.ReadLine();

        Console.WriteLine("Escriba el habitat preferido:");
        invertebrado.HabitatPreferido = Console.ReadLine();

        Console.WriteLine("Escriba el cliclo de vida:");
        invertebrado.CicloVida = Console.ReadLine();

        Console.WriteLine("Escriba el tamaño:");
        invertebrado.Tamano = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("-----------------------------------------");
        invertebrado.Imprimir();
        break;

    default:
        Console.WriteLine("ADIOS");
        break;
}