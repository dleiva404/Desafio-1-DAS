using GestionBiblioteca.Models;

namespace GestionBiblioteca.Services
{
    public class UsuarioService
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private int _nextId = 1;

        // Agregar usuario
        public void Agregar(string nombre, string correo, string telefono)
        {
            // Validar duplicado de correo
            if (_usuarios.Any(u => u.Correo == correo))
                throw new Exception("Ya existe un usuario con ese correo.");

            var usuario = new Usuario(_nextId++, nombre, correo, telefono);
            _usuarios.Add(usuario);
        }

        // Obtener todos
        public List<Usuario> ObtenerTodos()
        {
            return _usuarios;
        }

        // Buscar por ID
        public Usuario BuscarPorId(int id)
        {
            return _usuarios.FirstOrDefault(u => u.Id == id)!;
        }

        // Actualizar usuario
        public bool Actualizar(int id, string nombre, string correo, string telefono)
        {
            var usuario = BuscarPorId(id);
            if (usuario == null) return false;
            usuario.Nombre = nombre;
            usuario.Correo = correo;
            usuario.Telefono = telefono;
            return true;
        }

        // Eliminar usuario
        public bool Eliminar(int id)
        {
            var usuario = BuscarPorId(id);
            if (usuario == null) return false;
            _usuarios.Remove(usuario);
            return true;
        }
    }
}