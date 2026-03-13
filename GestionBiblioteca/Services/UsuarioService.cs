using GestionBiblioteca.Models;

namespace GestionBiblioteca.Services
{
    public class UsuarioService
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private int _nextId = 1;

        public void Agregar(string nombre, string correo, string telefono)
        {
            if (_usuarios.Any(u => u.Correo == correo))
                throw new Exception("Ya existe un usuario con ese correo.");

            var usuario = new Usuario(_nextId++, nombre, correo, telefono);
            _usuarios.Add(usuario);
        }

        public List<Usuario> ObtenerTodos()
        {
            return _usuarios;
        }

        public Usuario BuscarPorId(int id)
        {
            return _usuarios.FirstOrDefault(u => u.Id == id)!;
        }

        public bool Actualizar(int id, string nombre, string correo, string telefono)
        {
            var usuario = BuscarPorId(id);
            if (usuario == null) return false;
            usuario.Nombre = nombre;
            usuario.Correo = correo;
            usuario.Telefono = telefono;
            return true;
        }

        public bool Eliminar(int id)
        {
            var usuario = BuscarPorId(id);
            if (usuario == null) return false;
            _usuarios.Remove(usuario);
            return true;
        }
    }
}