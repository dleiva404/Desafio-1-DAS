using GestionBiblioteca.Models;

namespace GestionBiblioteca.Services
{
    public class LibroService
    {
        private List<Libro> _libros = new List<Libro>();
        private int _nextId = 1;

        public void Agregar(string titulo, string autor, int anio, string genero)
        {
            var libro = new Libro(_nextId++, titulo, autor, anio, genero);
            _libros.Add(libro);
        }

        public List<Libro> ObtenerTodos()
        {
            return _libros;
        }

        public Libro BuscarPorId(int id)
        {
            return _libros.FirstOrDefault(l => l.Id == id)!;
        }

        public bool Actualizar(int id, string titulo, string autor, int anio, string genero)
        {
            var libro = BuscarPorId(id);
            if (libro == null) return false;
            libro.Titulo = titulo;
            libro.Autor = autor;
            libro.Anio = anio;
            libro.Genero = genero;
            return true;
        }

        public bool Eliminar(int id)
        {
            var libro = BuscarPorId(id);
            if (libro == null) return false;
            _libros.Remove(libro);
            return true;
        }
    }
}