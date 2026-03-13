namespace GestionBiblioteca.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public Libro Libro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }

        public Prestamo(int id, Libro libro, Usuario usuario, DateTime fechaDevolucion)
        {
            Id = id;
            Libro = libro;
            Usuario = usuario;
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = fechaDevolucion;
            Devuelto = false;
        }

        public override string ToString()
        {
            return $"{Id} | {Libro.Titulo} | {Usuario.Nombre} | {FechaPrestamo:dd/MM/yyyy} | {(Devuelto ? "Devuelto" : "Pendiente")}";
        }
    }
}
