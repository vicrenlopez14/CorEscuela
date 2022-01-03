using CoreEscuela.Entidades;
using CorEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Escuela", 2012, TiposEscuela.Primaria,
                pais: "Colombia", ciudad: "Bogotá");

            CargarCursos();
            foreach (var curso in Escuela.Cursos)
            {
                curso.Alumnos.AddRange(CargarAlumnos());
            }
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Name= "Matemáticas"},
                    new Asignatura{Name= "Educación Física"},
                    new Asignatura{Name= "Castellano"},
                    new Asignatura{Name= "Ciencias Naturales"},
                };

                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private IEnumerable<Alumno> CargarAlumnos()
        {

            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos;
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
            {
              new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
              new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
              new Curso() { Nombre = "301", Jornada = TiposJornada.Mañana },
              new Curso() { Nombre = "401", Jornada = TiposJornada.Tarde },
              new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde },
            };
        }
    }
}