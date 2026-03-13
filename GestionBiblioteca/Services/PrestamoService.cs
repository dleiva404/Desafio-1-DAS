using GestionBiblioteca.Models;

namespace GestionBiblioteca.Services
{
    public class PrestamoService
    {
        private List<Prestamo> _prestamos = new List<Prestamo>();
        private int _nextId = 1;

        public void Agregar(Libro libro, Usuario usuario, DateTime fechaDevolucion)
        {
            if (!libro.Disponible) throw new Exception("El libro no está disponible.");
            var prestamo = new Prestamo(_nextId++, libro, usuario, fechaDevolucion);
            libro.Disponible = false;
            usuario.Prestamos.Add(prestamo);
            _prestamos.Add(prestamo);
        }

        public List<Prestamo> ObtenerTodos() => _prestamos;

        public Prestamo BuscarPorId(int id) => _prestamos.FirstOrDefault(p => p.Id == id)!;

        public bool Devolver(int id)
        {
            var p = BuscarPorId(id);
            if (p == null) return false;
            p.Devuelto = true;
            p.Libro.Disponible = true;
            p.FechaDevolucion = DateTime.Now;
            return true;
        }

        public List<Prestamo> ObtenerPorUsuario(int usuarioId) =>
            _prestamos.Where(p => p.Usuario.Id == usuarioId).ToList();

        public List<Prestamo> ObtenerPendientes() =>
            _prestamos.Where(p => !p.Devuelto).ToList();
    }
}