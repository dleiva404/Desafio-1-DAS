namespace GestionBiblioteca.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
        public string Genero { get; set; }
        public bool Disponible { get; set; }

        public Libro(int id, string titulo, string autor, int anio, string genero)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Genero = genero;
            Disponible = true;
        }

        public override string ToString()
        {
            return $"{Id} - {Titulo} | {Autor} | {Anio} | {(Disponible ? "Disponible" : "Prestado")}";
        }
    }
}