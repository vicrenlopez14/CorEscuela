using CorEscuela.Entidades;

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Escuela", 2012);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogotá";

            Console.WriteLine(escuela.Nombre);
        }
    }
}