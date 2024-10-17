
namespace HerenciaQ42024
{
    public class Invertebrado : Animal
    {
        public string TipoCuerpo { get; set; }
        public string MetodoReproduccion { get; set; }
        public string TipoAlimentacion { get; set; }
        public string HabitatPreferido { get; set; }
        public int CicloVida { get; set; }
        public string Tamano { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Tipo de cuerpo: {TipoCuerpo}");
            Console.WriteLine($"Método de reproducción: {MetodoReproduccion}");
            Console.WriteLine($"Tipo de Alimentación: {TipoAlimentacion}");
            Console.WriteLine($"Habitat preferido: {HabitatPreferido}");
            Console.WriteLine($"Ciclo de Vida: {CicloVida}");
            Console.WriteLine($"Tamño: {Tamano}");
        }
    }
}
