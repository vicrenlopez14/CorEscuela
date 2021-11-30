using CorEscuela.Entidades;

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Escuela", 2012, TiposEscuela.Primaria,
                pais: "Colombia", ciudad: "Bogotá");
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogotá";

            var curso1 = new Curso()
            {
                Nombre = "101"
            };

            var curso2 = new Curso()
            {
                Nombre = "201"
            };

            var curso3 = new Curso()
            {
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            System.Console.WriteLine("============");
            Console.WriteLine(curso1.Nombre + "," + curso1.UniqueId);
            Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
            Console.WriteLine(curso3);

        }
    }
}