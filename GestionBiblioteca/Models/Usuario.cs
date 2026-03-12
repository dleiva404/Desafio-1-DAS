using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public List<Prestamo> Prestamos { get; set; }

        public Usuario(int id, string nombre, string correo, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Prestamos = new List<Prestamo>();
        }

        public override string ToString()
        {
            return $"{Id} - {Nombre} | {Correo} | {Telefono}";
        }
    }
}
