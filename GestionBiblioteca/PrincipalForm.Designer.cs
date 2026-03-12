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
            TabControl1 = new TabControl();
            TabLibros = new TabPage();
            txtAutor = new TextBox();
            txtAnio = new TextBox();
            txtGenero = new TextBox();
            txtTitulo = new TextBox();
            lblGenero = new Label();
            lblAnio = new Label();
            lblAutor = new Label();
            lblTitulo = new Label();
            panelBotonesLibros = new Panel();
            btnLimpiarLibro = new Button();
            btnEliminarLibro = new Button();
            btnEditarLibro = new Button();
            btnAgregarLibro = new Button();
            dgvLibros = new DataGridView();
            TabUsuarios = new TabPage();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblNombre = new Label();
            panelBotonesUsuarios = new Panel();
            btnLimpiarUsuario = new Button();
            btnEliminarUsuario = new Button();
            btnEditarUsuario = new Button();
            btnAgregarUsuario = new Button();
            dgvUsuarios = new DataGridView();
            TabPrestamos = new TabPage();
            TabControl1.SuspendLayout();
            TabLibros.SuspendLayout();
            panelBotonesLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            TabUsuarios.SuspendLayout();
            panelBotonesUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabLibros);
            TabControl1.Controls.Add(TabUsuarios);
            TabControl1.Controls.Add(TabPrestamos);
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.Location = new Point(0, 0);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1184, 661);
            TabControl1.TabIndex = 0;
            // 
            // TabLibros
            // 
            TabLibros.Controls.Add(txtAutor);
            TabLibros.Controls.Add(txtAnio);
            TabLibros.Controls.Add(txtGenero);
            TabLibros.Controls.Add(txtTitulo);
            TabLibros.Controls.Add(lblGenero);
            TabLibros.Controls.Add(lblAnio);
            TabLibros.Controls.Add(lblAutor);
            TabLibros.Controls.Add(lblTitulo);
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
            // txtAutor
            // 
            txtAutor.Location = new Point(338, 357);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 4;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(541, 357);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 5;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(752, 357);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(100, 23);
            txtGenero.TabIndex = 6;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(117, 357);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 3;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(692, 365);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(54, 15);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Género : ";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(500, 365);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(35, 15);
            lblAnio.TabIndex = 4;
            lblAnio.Text = "Año :";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(289, 365);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(43, 15);
            lblAutor.TabIndex = 3;
            lblAutor.Text = "Autor :";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(67, 365);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(44, 15);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Título :";
            // 
            // panelBotonesLibros
            // 
            panelBotonesLibros.Controls.Add(btnLimpiarLibro);
            panelBotonesLibros.Controls.Add(btnEliminarLibro);
            panelBotonesLibros.Controls.Add(btnEditarLibro);
            panelBotonesLibros.Controls.Add(btnAgregarLibro);
            panelBotonesLibros.Dock = DockStyle.Bottom;
            panelBotonesLibros.Location = new Point(3, 480);
            panelBotonesLibros.Name = "panelBotonesLibros";
            panelBotonesLibros.Size = new Size(1170, 150);
            panelBotonesLibros.TabIndex = 6;
            // 
            // btnLimpiarLibro
            // 
            btnLimpiarLibro.Location = new Point(436, 64);
            btnLimpiarLibro.Name = "btnLimpiarLibro";
            btnLimpiarLibro.Size = new Size(75, 23);
            btnLimpiarLibro.TabIndex = 3;
            btnLimpiarLibro.Text = "Limpiar";
            btnLimpiarLibro.UseVisualStyleBackColor = true;
            btnLimpiarLibro.Click += btnLimpiarLibro_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(321, 64);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(75, 23);
            btnEliminarLibro.TabIndex = 3;
            btnEliminarLibro.Text = "Eliminar";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnEditarLibro
            // 
            btnEditarLibro.Location = new Point(210, 64);
            btnEditarLibro.Name = "btnEditarLibro";
            btnEditarLibro.Size = new Size(75, 23);
            btnEditarLibro.TabIndex = 2;
            btnEditarLibro.Text = "Editar";
            btnEditarLibro.UseVisualStyleBackColor = true;
            btnEditarLibro.Click += btnEditarLibro_Click;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(95, 64);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(75, 23);
            btnAgregarLibro.TabIndex = 1;
            btnAgregarLibro.Text = "Agregar";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Dock = DockStyle.Top;
            dgvLibros.Location = new Point(3, 3);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(1170, 300);
            dgvLibros.TabIndex = 1;
            dgvLibros.CellClick += dgvLibros_CellClick;
            // 
            // TabUsuarios
            // 
            TabUsuarios.Controls.Add(txtTelefono);
            TabUsuarios.Controls.Add(txtCorreo);
            TabUsuarios.Controls.Add(txtNombre);
            TabUsuarios.Controls.Add(lblTelefono);
            TabUsuarios.Controls.Add(lblCorreo);
            TabUsuarios.Controls.Add(lblNombre);
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
            // txtTelefono
            // 
            txtTelefono.Location = new Point(638, 380);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(353, 380);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 380);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(570, 388);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(62, 15);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono : ";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(295, 388);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(52, 15);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo : ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(63, 388);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre :";
            // 
            // panelBotonesUsuarios
            // 
            panelBotonesUsuarios.Controls.Add(btnLimpiarUsuario);
            panelBotonesUsuarios.Controls.Add(btnEliminarUsuario);
            panelBotonesUsuarios.Controls.Add(btnEditarUsuario);
            panelBotonesUsuarios.Controls.Add(btnAgregarUsuario);
            panelBotonesUsuarios.Dock = DockStyle.Bottom;
            panelBotonesUsuarios.Location = new Point(3, 530);
            panelBotonesUsuarios.Name = "panelBotonesUsuarios";
            panelBotonesUsuarios.Size = new Size(1170, 100);
            panelBotonesUsuarios.TabIndex = 1;
            // 
            // btnLimpiarUsuario
            // 
            btnLimpiarUsuario.Location = new Point(518, 30);
            btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            btnLimpiarUsuario.Size = new Size(75, 23);
            btnLimpiarUsuario.TabIndex = 11;
            btnLimpiarUsuario.Text = "Limpiar";
            btnLimpiarUsuario.UseVisualStyleBackColor = true;
            btnLimpiarUsuario.Click += btnLimpiarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(375, 30);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(75, 23);
            btnEliminarUsuario.TabIndex = 10;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Location = new Point(233, 30);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(75, 23);
            btnEditarUsuario.TabIndex = 9;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(90, 30);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(75, 23);
            btnAgregarUsuario.TabIndex = 8;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Top;
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(1170, 300);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // TabPrestamos
            // 
            TabPrestamos.Location = new Point(4, 24);
            TabPrestamos.Name = "TabPrestamos";
            TabPrestamos.Padding = new Padding(3);
            TabPrestamos.Size = new Size(1176, 633);
            TabPrestamos.TabIndex = 2;
            TabPrestamos.Text = "Préstamos";
            TabPrestamos.UseVisualStyleBackColor = true;
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
            TabControl1.ResumeLayout(false);
            TabLibros.ResumeLayout(false);
            TabLibros.PerformLayout();
            panelBotonesLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            TabUsuarios.ResumeLayout(false);
            TabUsuarios.PerformLayout();
            panelBotonesUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl1;
        private TabPage TabLibros;
        private TabPage TabUsuarios;
        private TabPage TabPrestamos;
        private Panel panelBotonesLibros;
        private Button btnLimpiarLibro;
        private Button btnEliminarLibro;
        private Button btnEditarLibro;
        private Button btnAgregarLibro;
        private DataGridView dgvLibros;
        private Label lblGenero;
        private Label lblAnio;
        private Label lblAutor;
        private Label lblTitulo;
        private TextBox txtAutor;
        private TextBox txtAnio;
        private TextBox txtGenero;
        private TextBox txtTitulo;
        private Label lblNombre;
        private Panel panelBotonesUsuarios;
        private DataGridView dgvUsuarios;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Label lblCorreo;
        private Button btnLimpiarUsuario;
        private Button btnEliminarUsuario;
        private Button btnEditarUsuario;
        private Button btnAgregarUsuario;
    }
}
