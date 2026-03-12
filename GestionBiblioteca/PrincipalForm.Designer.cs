namespace GestionBiblioteca
{
    partial class PrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabPrestamos = new TabPage();
            panelPrestamo = new Panel();
            dtpFechaDevolucion = new DateTimePicker();
            lblUsuarioPrestamo = new Label();
            cmbLibro = new ComboBox();
            lblLibroPrestamo = new Label();
            cmbUsuario = new ComboBox();
            lblFechaDevolucion = new Label();
            panelBotonesPrestamos = new Panel();
            btnLimpiarPrestamo = new Button();
            btnDevolverPrestamo = new Button();
            btnRegistrarPrestamo = new Button();
            dgvPrestamos = new DataGridView();
            TabUsuarios = new TabPage();
            panelUsuarios = new Panel();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            lblNombre = new Label();
            lblCorreo = new Label();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            panelBotonesUsuarios = new Panel();
            btnLimpiarUsuario = new Button();
            btnEliminarUsuario = new Button();
            btnEditarUsuario = new Button();
            btnAgregarUsuario = new Button();
            dgvUsuarios = new DataGridView();
            TabLibros = new TabPage();
            panelCamposLibro = new Panel();
            txtTitulo = new TextBox();
            lblAnio = new Label();
            txtAutor = new TextBox();
            txtGenero = new TextBox();
            lblTitulo = new Label();
            lblGenero = new Label();
            lblAutor = new Label();
            txtAnio = new TextBox();
            panelBotonesLibros = new Panel();
            btnLimpiarLibro = new Button();
            btnEliminarLibro = new Button();
            btnEditarLibro = new Button();
            btnAgregarLibro = new Button();
            dgvLibros = new DataGridView();
            TabControl1 = new TabControl();
            TabEstadisticas = new TabPage();
            panelGrafico2 = new Panel();
            panelGrafico1 = new Panel();
            btnGenerarGraficos = new Button();
            TabPrestamos.SuspendLayout();
            panelPrestamo.SuspendLayout();
            panelBotonesPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            TabUsuarios.SuspendLayout();
            panelUsuarios.SuspendLayout();
            panelBotonesUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            TabLibros.SuspendLayout();
            panelCamposLibro.SuspendLayout();
            panelBotonesLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            TabControl1.SuspendLayout();
            TabEstadisticas.SuspendLayout();
            SuspendLayout();
            // 
            // TabPrestamos
            // 
            TabPrestamos.Controls.Add(panelPrestamo);
            TabPrestamos.Controls.Add(panelBotonesPrestamos);
            TabPrestamos.Controls.Add(dgvPrestamos);
            TabPrestamos.Location = new Point(4, 24);
            TabPrestamos.Name = "TabPrestamos";
            TabPrestamos.Padding = new Padding(3);
            TabPrestamos.Size = new Size(1176, 633);
            TabPrestamos.TabIndex = 2;
            TabPrestamos.Text = "Préstamos";
            TabPrestamos.UseVisualStyleBackColor = true;
            // 
            // panelPrestamo
            // 
            panelPrestamo.Controls.Add(dtpFechaDevolucion);
            panelPrestamo.Controls.Add(lblUsuarioPrestamo);
            panelPrestamo.Controls.Add(cmbLibro);
            panelPrestamo.Controls.Add(lblLibroPrestamo);
            panelPrestamo.Controls.Add(cmbUsuario);
            panelPrestamo.Controls.Add(lblFechaDevolucion);
            panelPrestamo.Dock = DockStyle.Bottom;
            panelPrestamo.Location = new Point(3, 409);
            panelPrestamo.Name = "panelPrestamo";
            panelPrestamo.Size = new Size(1170, 171);
            panelPrestamo.TabIndex = 9;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 11F);
            dtpFechaDevolucion.Location = new Point(137, 119);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(288, 27);
            dtpFechaDevolucion.TabIndex = 8;
            dtpFechaDevolucion.ValueChanged += dtpFechaDevolucion_ValueChanged;
            // 
            // lblUsuarioPrestamo
            // 
            lblUsuarioPrestamo.AutoSize = true;
            lblUsuarioPrestamo.Font = new Font("Segoe UI", 11F);
            lblUsuarioPrestamo.Location = new Point(65, 36);
            lblUsuarioPrestamo.Name = "lblUsuarioPrestamo";
            lblUsuarioPrestamo.Size = new Size(70, 20);
            lblUsuarioPrestamo.TabIndex = 3;
            lblUsuarioPrestamo.Text = "Usuario : ";
            lblUsuarioPrestamo.Click += lblUsuarioPrestamo_Click;
            // 
            // cmbLibro
            // 
            cmbLibro.Font = new Font("Segoe UI", 11F);
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(137, 77);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(121, 28);
            cmbLibro.TabIndex = 7;
            cmbLibro.SelectedIndexChanged += cmbLibro_SelectedIndexChanged;
            // 
            // lblLibroPrestamo
            // 
            lblLibroPrestamo.AutoSize = true;
            lblLibroPrestamo.Font = new Font("Segoe UI", 11F);
            lblLibroPrestamo.Location = new Point(81, 80);
            lblLibroPrestamo.Name = "lblLibroPrestamo";
            lblLibroPrestamo.Size = new Size(50, 20);
            lblLibroPrestamo.TabIndex = 4;
            lblLibroPrestamo.Text = "Libro :";
            // 
            // cmbUsuario
            // 
            cmbUsuario.Font = new Font("Segoe UI", 11F);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(137, 33);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(121, 28);
            cmbUsuario.TabIndex = 6;
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Font = new Font("Segoe UI", 11F);
            lblFechaDevolucion.Location = new Point(69, 124);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(62, 20);
            lblFechaDevolucion.TabIndex = 5;
            lblFechaDevolucion.Text = "Fecha  : ";
            // 
            // panelBotonesPrestamos
            // 
            panelBotonesPrestamos.Controls.Add(btnLimpiarPrestamo);
            panelBotonesPrestamos.Controls.Add(btnDevolverPrestamo);
            panelBotonesPrestamos.Controls.Add(btnRegistrarPrestamo);
            panelBotonesPrestamos.Dock = DockStyle.Bottom;
            panelBotonesPrestamos.Location = new Point(3, 580);
            panelBotonesPrestamos.Name = "panelBotonesPrestamos";
            panelBotonesPrestamos.Size = new Size(1170, 50);
            panelBotonesPrestamos.TabIndex = 2;
            // 
            // btnLimpiarPrestamo
            // 
            btnLimpiarPrestamo.Font = new Font("Segoe UI", 11F);
            btnLimpiarPrestamo.Location = new Point(217, 10);
            btnLimpiarPrestamo.Name = "btnLimpiarPrestamo";
            btnLimpiarPrestamo.Size = new Size(100, 35);
            btnLimpiarPrestamo.TabIndex = 2;
            btnLimpiarPrestamo.Text = "Limpiar";
            btnLimpiarPrestamo.UseVisualStyleBackColor = true;
            btnLimpiarPrestamo.Click += btnLimpiarPrestamo_Click;
            // 
            // btnDevolverPrestamo
            // 
            btnDevolverPrestamo.Font = new Font("Segoe UI", 11F);
            btnDevolverPrestamo.Location = new Point(111, 10);
            btnDevolverPrestamo.Name = "btnDevolverPrestamo";
            btnDevolverPrestamo.Size = new Size(100, 35);
            btnDevolverPrestamo.TabIndex = 1;
            btnDevolverPrestamo.Text = "Devolver";
            btnDevolverPrestamo.UseVisualStyleBackColor = true;
            btnDevolverPrestamo.Click += btnDevolverPrestamo_Click;
            // 
            // btnRegistrarPrestamo
            // 
            btnRegistrarPrestamo.Font = new Font("Segoe UI", 11F);
            btnRegistrarPrestamo.Location = new Point(5, 10);
            btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            btnRegistrarPrestamo.Size = new Size(100, 35);
            btnRegistrarPrestamo.TabIndex = 0;
            btnRegistrarPrestamo.Text = "Registrar";
            btnRegistrarPrestamo.UseVisualStyleBackColor = true;
            btnRegistrarPrestamo.Click += btnRegistrarPrestamo_Click;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(3, 3);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.Size = new Size(1170, 300);
            dgvPrestamos.TabIndex = 1;
            // 
            // TabUsuarios
            // 
            TabUsuarios.Controls.Add(panelUsuarios);
            TabUsuarios.Controls.Add(panelBotonesUsuarios);
            TabUsuarios.Controls.Add(dgvUsuarios);
            TabUsuarios.Location = new Point(4, 24);
            TabUsuarios.Name = "TabUsuarios";
            TabUsuarios.Padding = new Padding(3);
            TabUsuarios.Size = new Size(1176, 633);
            TabUsuarios.TabIndex = 1;
            TabUsuarios.Text = "Usuarios";
            TabUsuarios.UseVisualStyleBackColor = true;
            // 
            // panelUsuarios
            // 
            panelUsuarios.Controls.Add(txtCorreo);
            panelUsuarios.Controls.Add(txtTelefono);
            panelUsuarios.Controls.Add(lblNombre);
            panelUsuarios.Controls.Add(lblCorreo);
            panelUsuarios.Controls.Add(txtNombre);
            panelUsuarios.Controls.Add(lblTelefono);
            panelUsuarios.Dock = DockStyle.Bottom;
            panelUsuarios.Location = new Point(3, 409);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(1170, 171);
            panelUsuarios.TabIndex = 8;
            panelUsuarios.Paint += panel1_Paint;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Location = new Point(127, 66);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 6;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(127, 107);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(50, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre :";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 11F);
            lblCorreo.Location = new Point(55, 69);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(65, 20);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo : ";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(127, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11F);
            lblTelefono.Location = new Point(45, 110);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono : ";
            // 
            // panelBotonesUsuarios
            // 
            panelBotonesUsuarios.Controls.Add(btnLimpiarUsuario);
            panelBotonesUsuarios.Controls.Add(btnEliminarUsuario);
            panelBotonesUsuarios.Controls.Add(btnEditarUsuario);
            panelBotonesUsuarios.Controls.Add(btnAgregarUsuario);
            panelBotonesUsuarios.Dock = DockStyle.Bottom;
            panelBotonesUsuarios.Location = new Point(3, 580);
            panelBotonesUsuarios.Name = "panelBotonesUsuarios";
            panelBotonesUsuarios.Size = new Size(1170, 50);
            panelBotonesUsuarios.TabIndex = 1;
            // 
            // btnLimpiarUsuario
            // 
            btnLimpiarUsuario.Font = new Font("Segoe UI", 11F);
            btnLimpiarUsuario.Location = new Point(323, 10);
            btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            btnLimpiarUsuario.Size = new Size(100, 35);
            btnLimpiarUsuario.TabIndex = 11;
            btnLimpiarUsuario.Text = "Limpiar";
            btnLimpiarUsuario.UseVisualStyleBackColor = true;
            btnLimpiarUsuario.Click += btnLimpiarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Font = new Font("Segoe UI", 11F);
            btnEliminarUsuario.Location = new Point(217, 10);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(100, 35);
            btnEliminarUsuario.TabIndex = 10;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Font = new Font("Segoe UI", 11F);
            btnEditarUsuario.Location = new Point(111, 10);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(100, 35);
            btnEditarUsuario.TabIndex = 9;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Font = new Font("Segoe UI", 11F);
            btnAgregarUsuario.Location = new Point(5, 10);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(100, 35);
            btnAgregarUsuario.TabIndex = 8;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(1170, 300);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // TabLibros
            // 
            TabLibros.Controls.Add(panelCamposLibro);
            TabLibros.Controls.Add(panelBotonesLibros);
            TabLibros.Controls.Add(dgvLibros);
            TabLibros.Location = new Point(4, 24);
            TabLibros.Name = "TabLibros";
            TabLibros.Padding = new Padding(3);
            TabLibros.Size = new Size(1176, 633);
            TabLibros.TabIndex = 0;
            TabLibros.Text = "Libros";
            TabLibros.UseVisualStyleBackColor = true;
            // 
            // panelCamposLibro
            // 
            panelCamposLibro.Controls.Add(txtTitulo);
            panelCamposLibro.Controls.Add(lblAnio);
            panelCamposLibro.Controls.Add(txtAutor);
            panelCamposLibro.Controls.Add(txtGenero);
            panelCamposLibro.Controls.Add(lblTitulo);
            panelCamposLibro.Controls.Add(lblGenero);
            panelCamposLibro.Controls.Add(lblAutor);
            panelCamposLibro.Controls.Add(txtAnio);
            panelCamposLibro.Dock = DockStyle.Bottom;
            panelCamposLibro.Location = new Point(3, 409);
            panelCamposLibro.Name = "panelCamposLibro";
            panelCamposLibro.Size = new Size(1170, 171);
            panelCamposLibro.TabIndex = 7;
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.Location = new Point(111, 18);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(280, 23);
            txtTitulo.TabIndex = 3;
            // 
            // lblAnio
            // 
            lblAnio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Segoe UI", 11F);
            lblAnio.Location = new Point(62, 89);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(43, 20);
            lblAnio.TabIndex = 4;
            lblAnio.Text = "Año :";
            // 
            // txtAutor
            // 
            txtAutor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAutor.Location = new Point(111, 53);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(280, 23);
            txtAutor.TabIndex = 4;
            // 
            // txtGenero
            // 
            txtGenero.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtGenero.Location = new Point(111, 124);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(100, 23);
            txtGenero.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11F);
            lblTitulo.Location = new Point(51, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(54, 20);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Título :";
            // 
            // lblGenero
            // 
            lblGenero.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 11F);
            lblGenero.Location = new Point(41, 123);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(68, 20);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Género : ";
            // 
            // lblAutor
            // 
            lblAutor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 11F);
            lblAutor.Location = new Point(52, 53);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(53, 20);
            lblAutor.TabIndex = 3;
            lblAutor.Text = "Autor :";
            // 
            // txtAnio
            // 
            txtAnio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAnio.Location = new Point(111, 89);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 5;
            // 
            // panelBotonesLibros
            // 
            panelBotonesLibros.Controls.Add(btnLimpiarLibro);
            panelBotonesLibros.Controls.Add(btnEliminarLibro);
            panelBotonesLibros.Controls.Add(btnEditarLibro);
            panelBotonesLibros.Controls.Add(btnAgregarLibro);
            panelBotonesLibros.Dock = DockStyle.Bottom;
            panelBotonesLibros.Location = new Point(3, 580);
            panelBotonesLibros.Name = "panelBotonesLibros";
            panelBotonesLibros.Size = new Size(1170, 50);
            panelBotonesLibros.TabIndex = 6;
            // 
            // btnLimpiarLibro
            // 
            btnLimpiarLibro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpiarLibro.Font = new Font("Segoe UI", 11F);
            btnLimpiarLibro.Location = new Point(323, 11);
            btnLimpiarLibro.Name = "btnLimpiarLibro";
            btnLimpiarLibro.Size = new Size(100, 35);
            btnLimpiarLibro.TabIndex = 3;
            btnLimpiarLibro.Text = "Limpiar";
            btnLimpiarLibro.UseVisualStyleBackColor = true;
            btnLimpiarLibro.Click += btnLimpiarLibro_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminarLibro.Font = new Font("Segoe UI", 11F);
            btnEliminarLibro.Location = new Point(217, 10);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(100, 35);
            btnEliminarLibro.TabIndex = 3;
            btnEliminarLibro.Text = "Eliminar";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnEditarLibro
            // 
            btnEditarLibro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditarLibro.Font = new Font("Segoe UI", 11F);
            btnEditarLibro.Location = new Point(111, 10);
            btnEditarLibro.Name = "btnEditarLibro";
            btnEditarLibro.Size = new Size(100, 35);
            btnEditarLibro.TabIndex = 2;
            btnEditarLibro.Text = "Editar";
            btnEditarLibro.UseVisualStyleBackColor = true;
            btnEditarLibro.Click += btnEditarLibro_Click;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregarLibro.Font = new Font("Segoe UI", 11F);
            btnAgregarLibro.Location = new Point(5, 10);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(100, 35);
            btnAgregarLibro.TabIndex = 1;
            btnAgregarLibro.Text = "Agregar";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(3, 3);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(1170, 300);
            dgvLibros.TabIndex = 1;
            dgvLibros.CellClick += dgvLibros_CellClick;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabLibros);
            TabControl1.Controls.Add(TabUsuarios);
            TabControl1.Controls.Add(TabPrestamos);
            TabControl1.Controls.Add(TabEstadisticas);
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.Location = new Point(0, 0);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1184, 661);
            TabControl1.TabIndex = 0;
            TabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // 
            // TabEstadisticas
            // 
            TabEstadisticas.Controls.Add(panelGrafico2);
            TabEstadisticas.Controls.Add(panelGrafico1);
            TabEstadisticas.Controls.Add(btnGenerarGraficos);
            TabEstadisticas.Location = new Point(4, 24);
            TabEstadisticas.Name = "TabEstadisticas";
            TabEstadisticas.Padding = new Padding(3);
            TabEstadisticas.Size = new Size(1176, 633);
            TabEstadisticas.TabIndex = 3;
            TabEstadisticas.Text = "Graficos";
            TabEstadisticas.UseVisualStyleBackColor = true;
            // 
            // panelGrafico2
            // 
            panelGrafico2.Dock = DockStyle.Fill;
            panelGrafico2.Location = new Point(483, 26);
            panelGrafico2.Name = "panelGrafico2";
            panelGrafico2.Size = new Size(690, 604);
            panelGrafico2.TabIndex = 2;
            // 
            // panelGrafico1
            // 
            panelGrafico1.Dock = DockStyle.Left;
            panelGrafico1.Location = new Point(3, 26);
            panelGrafico1.Name = "panelGrafico1";
            panelGrafico1.Size = new Size(480, 604);
            panelGrafico1.TabIndex = 1;
            // 
            // btnGenerarGraficos
            // 
            btnGenerarGraficos.Dock = DockStyle.Top;
            btnGenerarGraficos.Location = new Point(3, 3);
            btnGenerarGraficos.Name = "btnGenerarGraficos";
            btnGenerarGraficos.Size = new Size(1170, 23);
            btnGenerarGraficos.TabIndex = 0;
            btnGenerarGraficos.Text = "Generar graficos";
            btnGenerarGraficos.UseVisualStyleBackColor = true;
            btnGenerarGraficos.Click += btnGenerarGraficos_Click;
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(TabControl1);
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Biblioteca - UDB";
            WindowState = FormWindowState.Maximized;
            TabPrestamos.ResumeLayout(false);
            panelPrestamo.ResumeLayout(false);
            panelPrestamo.PerformLayout();
            panelBotonesPrestamos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            TabUsuarios.ResumeLayout(false);
            panelUsuarios.ResumeLayout(false);
            panelUsuarios.PerformLayout();
            panelBotonesUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            TabLibros.ResumeLayout(false);
            panelCamposLibro.ResumeLayout(false);
            panelCamposLibro.PerformLayout();
            panelBotonesLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            TabControl1.ResumeLayout(false);
            TabEstadisticas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage TabPrestamos;
        private DateTimePicker dtpFechaDevolucion;
        private ComboBox cmbLibro;
        private ComboBox cmbUsuario;
        private Label lblFechaDevolucion;
        private Label lblLibroPrestamo;
        private Label lblUsuarioPrestamo;
        private Panel panelBotonesPrestamos;
        private Button btnLimpiarPrestamo;
        private Button btnDevolverPrestamo;
        private Button btnRegistrarPrestamo;
        private DataGridView dgvPrestamos;
        private TabPage TabUsuarios;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblNombre;
        private Panel panelBotonesUsuarios;
        private Button btnLimpiarUsuario;
        private Button btnEliminarUsuario;
        private Button btnEditarUsuario;
        private Button btnAgregarUsuario;
        private DataGridView dgvUsuarios;
        private TabPage TabLibros;
        private TextBox txtAutor;
        private TextBox txtAnio;
        private TextBox txtGenero;
        private TextBox txtTitulo;
        private Label lblGenero;
        private Label lblAnio;
        private Label lblAutor;
        private Label lblTitulo;
        private Panel panelBotonesLibros;
        private Button btnLimpiarLibro;
        private Button btnEliminarLibro;
        private Button btnEditarLibro;
        private Button btnAgregarLibro;
        private DataGridView dgvLibros;
        private TabControl TabControl1;
        private TabPage TabEstadisticas;
        private Panel panelGrafico1;
        private Button btnGenerarGraficos;
        private Panel panelGrafico2;
        private Panel panelCamposLibro;
        private Panel panelUsuarios;
        private Panel panelPrestamo;
    }
}
