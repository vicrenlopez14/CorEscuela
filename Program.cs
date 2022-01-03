using CoreEscuela.Entidades;
using CoreEscuela.Utils;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            Printer.Beep(10000, 1, cantidad: 10);
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");

            try
            {
                if (escuela?.Cursos != null)
                {
                    foreach (var curso in escuela.Cursos)
                    {
                        Console.WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }

        }

    }
}