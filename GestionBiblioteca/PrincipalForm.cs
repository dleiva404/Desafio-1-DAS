using GestionBiblioteca.Models;
using GestionBiblioteca.Services;
using System.ComponentModel;
using System.Data;
using ScottPlot;
using Font = System.Drawing.Font;
using Color = System.Drawing.Color;
using FontStyle = System.Drawing.FontStyle;

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
            this.MinimumSize = new Size(800, 600);
            this.WindowState = FormWindowState.Maximized;
            AplicarEstilo();
            CargarLibros();
            CargarUsuarios();
            CargarPrestamos();
            dtpFechaDevolucion.Value = DateTime.Now.AddDays(7);
            dtpFechaDevolucion.MinDate = DateTime.Now.AddDays(1);
            this.Resize += PrincipalForm_Resize;
        }

        private void PrincipalForm_Resize(object sender, EventArgs e)
        {
            int alturaFormulario = TabLibros.Height;
            int alturaCampos = 130;
            int alturaTabla = alturaFormulario - alturaCampos - 10;

            if (alturaTabla > 50)
            {
                dgvLibros.Height = alturaTabla;
                dgvUsuarios.Height = alturaTabla;
                dgvPrestamos.Height = alturaTabla;
            }

            // Ajustar ancho de TextBoxes al ancho de la ventana
            int anchoTexto = (this.Width - 200) / 4;
            if (anchoTexto > 100)
            {
                txtTitulo.Width = anchoTexto;
                txtAutor.Width = anchoTexto;
                txtAnio.Width = anchoTexto / 2;
                txtGenero.Width = anchoTexto;
                txtNombre.Width = anchoTexto;
                txtCorreo.Width = anchoTexto;
                txtTelefono.Width = anchoTexto;
            }
        }

        private void AplicarEstilo()
        {
            // Colores UDB El Salvador
            Color azulUDB = Color.FromArgb(0, 51, 153);
            Color amarilloUDB = Color.FromArgb(255, 204, 0);
            Color blancoUDB = Color.White;
            Color rojoUDB = Color.FromArgb(200, 0, 0);
            Color grisClaro = Color.FromArgb(245, 245, 245);

            this.BackColor = grisClaro;
            this.Font = new Font("Segoe UI", 9);

            // Botones Libros
            foreach (Button b in new Button[] { btnAgregarLibro, btnEditarLibro })
            {
                b.Width = 100;
                b.Height = 35;
                b.BackColor = azulUDB;
                b.ForeColor = blancoUDB;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                b.Cursor = Cursors.Hand;
            }

            btnEliminarLibro.Width = 100;
            btnEliminarLibro.Height = 35;
            btnEliminarLibro.BackColor = rojoUDB;
            btnEliminarLibro.ForeColor = blancoUDB;
            btnEliminarLibro.FlatStyle = FlatStyle.Flat;
            btnEliminarLibro.FlatAppearance.BorderSize = 0;
            btnEliminarLibro.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnEliminarLibro.Cursor = Cursors.Hand;

            btnLimpiarLibro.Width = 100;
            btnLimpiarLibro.Height = 35;
            btnLimpiarLibro.BackColor = amarilloUDB;
            btnLimpiarLibro.ForeColor = azulUDB;
            btnLimpiarLibro.FlatStyle = FlatStyle.Flat;
            btnLimpiarLibro.FlatAppearance.BorderSize = 0;
            btnLimpiarLibro.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnLimpiarLibro.Cursor = Cursors.Hand;

            // Botones Usuarios
            foreach (Button b in new Button[] { btnAgregarUsuario, btnEditarUsuario })
            {
                b.Width = 100;
                b.Height = 35;
                b.BackColor = azulUDB;
                b.ForeColor = blancoUDB;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                b.Cursor = Cursors.Hand;
            }

            btnEliminarUsuario.Width = 100;
            btnEliminarUsuario.Height = 35;
            btnEliminarUsuario.BackColor = rojoUDB;
            btnEliminarUsuario.ForeColor = blancoUDB;
            btnEliminarUsuario.FlatStyle = FlatStyle.Flat;
            btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            btnEliminarUsuario.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnEliminarUsuario.Cursor = Cursors.Hand;

            btnLimpiarUsuario.Width = 100;
            btnLimpiarUsuario.Height = 35;
            btnLimpiarUsuario.BackColor = amarilloUDB;
            btnLimpiarUsuario.ForeColor = azulUDB;
            btnLimpiarUsuario.FlatStyle = FlatStyle.Flat;
            btnLimpiarUsuario.FlatAppearance.BorderSize = 0;
            btnLimpiarUsuario.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnLimpiarUsuario.Cursor = Cursors.Hand;

            // Botones Préstamos
            foreach (Button b in new Button[] { btnRegistrarPrestamo, btnDevolverPrestamo })
            {
                b.Width = 100;
                b.Height = 35;
                b.BackColor = azulUDB;
                b.ForeColor = blancoUDB;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                b.Cursor = Cursors.Hand;
            }

            btnLimpiarPrestamo.Width = 100;
            btnLimpiarPrestamo.Height = 35;
            btnLimpiarPrestamo.BackColor = amarilloUDB;
            btnLimpiarPrestamo.ForeColor = azulUDB;
            btnLimpiarPrestamo.FlatStyle = FlatStyle.Flat;
            btnLimpiarPrestamo.FlatAppearance.BorderSize = 0;
            btnLimpiarPrestamo.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnLimpiarPrestamo.Cursor = Cursors.Hand;

            // Botón Generar Gráficos
            btnGenerarGraficos.BackColor = azulUDB;
            btnGenerarGraficos.ForeColor = blancoUDB;
            btnGenerarGraficos.FlatStyle = FlatStyle.Flat;
            btnGenerarGraficos.FlatAppearance.BorderSize = 0;
            btnGenerarGraficos.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnGenerarGraficos.Cursor = Cursors.Hand;

            // Encabezados de tablas en azul UDB
            dgvLibros.ColumnHeadersDefaultCellStyle.BackColor = azulUDB;
            dgvLibros.ColumnHeadersDefaultCellStyle.ForeColor = blancoUDB;
            dgvLibros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = azulUDB;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = blancoUDB;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvPrestamos.ColumnHeadersDefaultCellStyle.BackColor = azulUDB;
            dgvPrestamos.ColumnHeadersDefaultCellStyle.ForeColor = blancoUDB;
            dgvPrestamos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Filas alternadas en amarillo suave
            dgvLibros.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 220);
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 220);
            dgvPrestamos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 220);

            // Fondo de los paneles de campos en azul UDB
            panelCamposLibro.BackColor = azulUDB;
            panelUsuarios.BackColor = azulUDB;
            panelPrestamo.BackColor = azulUDB;

            // Fondo de los paneles de botones en gris claro
            panelBotonesUsuarios.BackColor = grisClaro;
            panelBotonesPrestamos.BackColor = grisClaro;

            // Labels en blanco y TextBoxes visibles en paneles
            foreach (Control c in panelCamposLibro.Controls)
            {
                if (c is System.Windows.Forms.Label) c.ForeColor = blancoUDB;
                if (c is TextBox) { c.BackColor = blancoUDB; c.ForeColor = Color.Black; }
            }

            foreach (Control c in panelUsuarios.Controls)
            {
                if (c is System.Windows.Forms.Label) c.ForeColor = blancoUDB;
                if (c is TextBox) { c.BackColor = blancoUDB; c.ForeColor = Color.Black; }
            }

            foreach (Control c in panelPrestamo.Controls)
            {
                if (c is System.Windows.Forms.Label) c.ForeColor = blancoUDB;
                if (c is TextBox) { c.BackColor = blancoUDB; c.ForeColor = Color.Black; }
                if (c is ComboBox) { c.BackColor = blancoUDB; c.ForeColor = Color.Black; }
            }
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
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvLibros.RowTemplate.Height = 28;
            dgvLibros.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
        }

        private bool ValidarLibro()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtAnio.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtAutor.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El autor no puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtAnio.Text, out int anio) || anio < 1000 || anio > DateTime.Now.Year)
            {
                MessageBox.Show($"El año debe ser un número entre 1000 y {DateTime.Now.Year}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (!ValidarLibro()) return;
            int.TryParse(txtAnio.Text, out int anio);
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
            if (!ValidarLibro()) return;
            int id = (int)dgvLibros.SelectedRows[0].Cells["Id"].Value;
            int.TryParse(txtAnio.Text, out int anio);
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

        private void btnLimpiarLibro_Click(object sender, EventArgs e) => LimpiarCamposLibro();

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
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvUsuarios.RowTemplate.Height = 28;
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
        }

        private bool ValidarUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show("El correo no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarUsuario()) return;
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
            if (!ValidarUsuario()) return;
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

        private void btnLimpiarUsuario_Click(object sender, EventArgs e) => LimpiarCamposUsuario();

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
                    p.Devuelto ? p.FechaDevolucion.ToString("dd/MM/yyyy") : "",
                    p.Devuelto ? "Devuelto" : "Pendiente"
                );
            }
            dgvPrestamos.DataSource = tabla;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvPrestamos.RowTemplate.Height = 28;
            dgvPrestamos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
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
            if (TabControl1.SelectedTab == TabEstadisticas)
            {
                MostrarGraficoLibrosMasPrestados();
                MostrarGraficoUsuariosMasActivos();
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
            var estado = dgvPrestamos.SelectedRows[0].Cells["Estado"].Value?.ToString();
            if (estado == "Devuelto")
            {
                MessageBox.Show("Este préstamo ya fue devuelto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        // ===== ESTADISTICAS =====
        private void btnGenerarGraficos_Click(object sender, EventArgs e)
        {
            MostrarGraficoLibrosMasPrestados();
            MostrarGraficoUsuariosMasActivos();
        }

        private void MostrarGraficoLibrosMasPrestados()
        {
            panelGrafico1.Controls.Clear();

            var prestamos = _prestamoService.ObtenerTodos();
            var datos = prestamos
                .GroupBy(p => p.Libro.Titulo)
                .Select(g => new { Titulo = g.Key, Total = g.Count() })
                .OrderByDescending(x => x.Total)
                .Take(5)
                .ToList();

            if (datos.Count == 0)
            {
                MessageBox.Show("No hay préstamos registrados.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formsPlot = new ScottPlot.WinForms.FormsPlot { Dock = DockStyle.Fill };
            var plot = formsPlot.Plot;

            double[] valores = datos.Select(x => (double)x.Total).ToArray();
            string[] etiquetas = datos.Select(x => x.Titulo).ToArray();

            plot.Add.Bars(valores);
            plot.Axes.Bottom.SetTicks(
                Enumerable.Range(0, etiquetas.Length).Select(i => (double)i).ToArray(),
                etiquetas
            );
            plot.Title("Libros más prestados");
            plot.YLabel("Total préstamos");
            formsPlot.Refresh();

            panelGrafico1.Controls.Add(formsPlot);
        }

        private void MostrarGraficoUsuariosMasActivos()
        {
            panelGrafico2.Controls.Clear();

            var prestamos = _prestamoService.ObtenerTodos();
            var datos = prestamos
                .GroupBy(p => p.Usuario.Nombre)
                .Select(g => new { Nombre = g.Key, Total = g.Count() })
                .OrderByDescending(x => x.Total)
                .Take(5)
                .ToList();

            if (datos.Count == 0) return;

            var formsPlot = new ScottPlot.WinForms.FormsPlot { Dock = DockStyle.Fill };
            var plot = formsPlot.Plot;

            double[] valores = datos.Select(x => (double)x.Total).ToArray();
            string[] etiquetas = datos.Select(x => x.Nombre).ToArray();

            plot.Add.Bars(valores);
            plot.Axes.Bottom.SetTicks(
                Enumerable.Range(0, etiquetas.Length).Select(i => (double)i).ToArray(),
                etiquetas
            );
            plot.Title("Usuarios más activos");
            plot.YLabel("Total préstamos");
            formsPlot.Refresh();

            panelGrafico2.Controls.Add(formsPlot);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsuarioPrestamo_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaDevolucion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}