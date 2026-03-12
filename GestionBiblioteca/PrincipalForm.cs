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
        }
        // ===== LIBROS =====
        private void CargarLibros()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = _libroService.ObtenerTodos();
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.MultiSelect = false;
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
            dgvLibros.ClearSelection();
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLibros.Rows.Count)
            {
                var row = dgvLibros.Rows[e.RowIndex];
                if (row.Cells["Titulo"].Value != null)
                {
                    txtTitulo.Text = row.Cells["Titulo"].Value?.ToString();
                    txtAutor.Text = row.Cells["Autor"].Value?.ToString();
                    txtAnio.Text = row.Cells["Anio"].Value?.ToString();
                    txtGenero.Text = row.Cells["Genero"].Value?.ToString();
                }
            }
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _usuarioService.ObtenerTodos();
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _usuarioService.Agregar(txtNombre.Text, txtCorreo.Text, txtTelefono.Text);
                CargarUsuarios();
                LimpiarCamposUsuario();
                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
            _usuarioService.Actualizar(id, txtNombre.Text, txtCorreo.Text, txtTelefono.Text);
            CargarUsuarios();
            LimpiarCamposUsuario();
            MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
            var confirmacion = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                _usuarioService.Eliminar(id);
                CargarUsuarios();
                LimpiarCamposUsuario();
            }
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarCamposUsuario();
        }

        private void LimpiarCamposUsuario()
        {
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            dgvUsuarios.ClearSelection();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvUsuarios.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value?.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString();
            }
        }
    }
}