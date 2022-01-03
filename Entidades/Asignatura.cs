namespace CorEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; private set; }

        public string Name { get; set; }

        public Asignatura() => UniqueId = System.Guid.NewGuid().ToString();
    }
}
