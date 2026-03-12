using GestionBiblioteca.Models;
using GestionBiblioteca.Services;

namespace GestionBiblioteca
{
    public partial class PrincipalForm : Form
    {
        private LibroService _libroService = new LibroService();
        private UsuarioService _usuarioService = new UsuarioService();
        private PrestamoService _prestamoService = new PrestamoService();

        public PrincipalForm()
        {
            InitializeComponent();
            CargarLibros();
        }

        // ===== LIBROS =====
        private void CargarLibros()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = _libroService.ObtenerTodos();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtAnio.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show("El año debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _libroService.Agregar(txtTitulo.Text, txtAutor.Text, anio, txtGenero.Text);
            CargarLibros();
            LimpiarCamposLibro();
            MessageBox.Show("Libro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un libro para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvLibros.SelectedRows[0].Cells["Id"].Value;
            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show("El año debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _libroService.Actualizar(id, txtTitulo.Text, txtAutor.Text, anio, txtGenero.Text);
            CargarLibros();
            LimpiarCamposLibro();
            MessageBox.Show("Libro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un libro para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvLibros.SelectedRows[0].Cells["Id"].Value;
            var confirmacion = MessageBox.Show("¿Estás seguro de eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                _libroService.Eliminar(id);
                CargarLibros();
                LimpiarCamposLibro();
            }
        }

        private void btnLimpiarLibro_Click(object sender, EventArgs e)
        {
            LimpiarCamposLibro();
        }

        private void LimpiarCamposLibro()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtAnio.Text = "";
            txtGenero.Text = "";
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvLibros.Rows[e.RowIndex];
                txtTitulo.Text = row.Cells["Titulo"].Value?.ToString();
                txtAutor.Text = row.Cells["Autor"].Value?.ToString();
                txtAnio.Text = row.Cells["Anio"].Value?.ToString();
                txtGenero.Text = row.Cells["Genero"].Value?.ToString();
            }
        }
    }
}