using GestionBiblioteca.Models;

namespace GestionBiblioteca.Services
{
    public class PrestamoService
    {
        private List<Prestamo> _prestamos = new List<Prestamo>();
        private int _nextId = 1;

        // Registrar préstamo
        public void Agregar(Libro libro, Usuario usuario, DateTime fechaDevolucion)
        {
            if (!libro.Disponible)
                throw new Exception("El libro no está disponible.");

            var prestamo = new Prestamo(_nextId++, libro, usuario, fechaDevolucion);
            libro.Disponible = false;
            usuario.Prestamos.Add(prestamo);
            _prestamos.Add(prestamo);
        }

        // Obtener todos
        public List<Prestamo> ObtenerTodos()
        {
            return _prestamos;
        }

        // Buscar por ID
        public Prestamo BuscarPorId(int id)
        {
            return _prestamos.FirstOrDefault(p => p.Id == id)!;
        }

        // Registrar devolución
        public bool Devolver(int id)
        {
            var prestamo = BuscarPorId(id);
            if (prestamo == null) return false;
            prestamo.Devuelto = true;
            prestamo.Libro.Disponible = true;
            return true;
        }

        // Obtener préstamos por usuario
        public List<Prestamo> ObtenerPorUsuario(int usuarioId)
        {
            return _prestamos.Where(p => p.Usuario.Id == usuarioId).ToList();
        }

        // Obtener préstamos pendientes
        public List<Prestamo> ObtenerPendientes()
        {
            return _prestamos.Where(p => !p.Devuelto).ToList();
        }
    }
}