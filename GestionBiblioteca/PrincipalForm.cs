using GestionBiblioteca.Models;
using GestionBiblioteca.Services;
using System.ComponentModel;
using System.Data;

namespace GestionBiblioteca
{
    public partial class PrincipalForm : Form
    {
        private static LibroService _libroService = new LibroService();
        private static UsuarioService _usuarioService = new UsuarioService();
        private static PrestamoService _prestamoService = new PrestamoService();

        public PrincipalForm()
        {
            InitializeComponent();
            CargarLibros();
            CargarUsuarios();
            CargarPrestamos();
        }

        // ===== LIBROS =====
        private void CargarLibros()
        {
            dgvLibros.DataSource = null;
            var lista = new BindingList<Libro>(_libroService.ObtenerTodos());
            dgvLibros.DataSource = lista;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.MultiSelect = false;
            if (dgvLibros.Columns.Contains("Disponible"))
                dgvLibros.Columns["Disponible"].Visible = false;
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
            try
            {
                if (e.RowIndex < 0) return;
                var row = dgvLibros.Rows[e.RowIndex];
                txtTitulo.Text = row.Cells["Titulo"].Value?.ToString() ?? "";
                txtAutor.Text = row.Cells["Autor"].Value?.ToString() ?? "";
                txtAnio.Text = row.Cells["Anio"].Value?.ToString() ?? "";
                txtGenero.Text = row.Cells["Genero"].Value?.ToString() ?? "";
            }
            catch { }
        }

        // ===== USUARIOS =====
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            var lista = new BindingList<Usuario>(_usuarioService.ObtenerTodos());
            dgvUsuarios.DataSource = lista;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            if (dgvUsuarios.Columns.Contains("Prestamos"))
                dgvUsuarios.Columns["Prestamos"].Visible = false;
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
            try
            {
                if (e.RowIndex < 0) return;
                var row = dgvUsuarios.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                txtCorreo.Text = row.Cells["Correo"].Value?.ToString() ?? "";
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? "";
            }
            catch { }
        }

        // ===== PRESTAMOS =====
        private void CargarPrestamos()
        {
            dgvPrestamos.DataSource = null;
            var prestamos = _prestamoService.ObtenerTodos();
            var tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Libro", typeof(string));
            tabla.Columns.Add("Usuario", typeof(string));
            tabla.Columns.Add("Fecha Préstamo", typeof(string));
            tabla.Columns.Add("Fecha Devolución", typeof(string));
            tabla.Columns.Add("Estado", typeof(string));

            foreach (var p in prestamos)
            {
                tabla.Rows.Add(
                    p.Id,
                    p.Libro.Titulo,
                    p.Usuario.Nombre,
                    p.FechaPrestamo.ToString("dd/MM/yyyy"),
                    p.FechaDevolucion.ToString("dd/MM/yyyy"),
                    p.Devuelto ? "Devuelto" : "Pendiente"
                );
            }
            dgvPrestamos.DataSource = tabla;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.MultiSelect = false;
        }

        private void CargarComboBoxes()
        {
            var usuarios = _usuarioService.ObtenerTodos();
            var librosDisponibles = _libroService.ObtenerTodos()
                .Where(l => l.Disponible).ToList();

            cmbUsuario.DataSource = null;
            cmbUsuario.Items.Clear();
            foreach (var u in usuarios)
                cmbUsuario.Items.Add(u);
            cmbUsuario.DisplayMember = "Nombre";

            cmbLibro.DataSource = null;
            cmbLibro.Items.Clear();
            foreach (var l in librosDisponibles)
                cmbLibro.Items.Add(l);
            cmbLibro.DisplayMember = "Titulo";
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedTab == TabPrestamos)
            {
                CargarComboBoxes();
                CargarPrestamos();
            }
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedItem == null || cmbLibro.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un usuario y un libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuario = (Usuario)cmbUsuario.SelectedItem;
                var libro = (Libro)cmbLibro.SelectedItem;
                _prestamoService.Agregar(libro, usuario, dtpFechaDevolucion.Value);
                CargarPrestamos();
                CargarComboBoxes();
                dgvPrestamos.ClearSelection();
                MessageBox.Show("Préstamo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevolverPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un préstamo para devolver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvPrestamos.SelectedRows[0].Cells["Id"].Value;
            var confirmacion = MessageBox.Show("¿Confirmar devolución?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                _prestamoService.Devolver(id);
                CargarPrestamos();
                CargarComboBoxes();
                dgvPrestamos.ClearSelection();
                MessageBox.Show("Devolución registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiarPrestamo_Click(object sender, EventArgs e)
        {
            dgvPrestamos.ClearSelection();
            if (cmbUsuario.Items.Count > 0) cmbUsuario.SelectedIndex = 0;
            if (cmbLibro.Items.Count > 0) cmbLibro.SelectedIndex = 0;
        }
    }
}