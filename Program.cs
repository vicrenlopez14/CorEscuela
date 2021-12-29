using CoreEscuela.Entidades;
using static System.Console;

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

            escuela.Cursos = new List<Curso>()
            {
              new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
              new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
              new Curso()  { Nombre = "301", Jornada = TiposJornada.Mañana },
            };

            escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso() { Nombre = "202", Jornada = TiposJornada.Tarde });

            var otrColeccion = new List<Curso>()
            {
              new Curso() { Nombre = "401", Jornada = TiposJornada.Mañana },
              new Curso() { Nombre = "501", Jornada = TiposJornada.Mañana },
              new Curso()  { Nombre = "502", Jornada = TiposJornada.Tarde },
            };

            // Let's create a temp Curso
            //Curso tmp = new Curso { Nombre = "101-Vacacional", Jornada = TiposJornada.Noche };
            // Add them to the Escuela
            //escuela.Cursos.Add(tmp);
            // Print the state
            ImprimirCursosEscuela(escuela);

            //WriteLine("Curso.Hash: " + tmp.GetHashCode());
            // Remove the temp Curso

            Predicate<Curso> miAlgoritmo = Predicado;

            escuela.Cursos.RemoveAll(miAlgoritmo);
            //escuela.Cursos.Remove(tmp);
            WriteLine("===============");

            // Append a complete collection to the Escuela
            escuela.Cursos.AddRange(otrColeccion);

            // Print the state
            ImprimirCursosEscuela(escuela);
        }

        private static bool Predicado(Curso obj)
        {
            return obj.Nombre == "301";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("*********************");
            WriteLine("Cursos de la Escuela");
            WriteLine("*********************");

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

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;

            do
            {
                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine($"Nombre: {arregloCursos[i].Nombre}, Id: {arregloCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
            }
        }
    }
}