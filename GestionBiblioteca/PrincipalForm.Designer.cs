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
            TabUsuarios = new TabPage();
            TabPrestamos = new TabPage();
            dgvLibros = new DataGridView();
            panelBotonesLibros = new Panel();
            btnAgregarLibro = new Button();
            btnEditarLibro = new Button();
            btnEliminarLibro = new Button();
            btnLimpiarLibro = new Button();
            lblTitulo = new Label();
            lblAutor = new Label();
            lblAnio = new Label();
            lblGenero = new Label();
            textTitulo = new TextBox();
            txtGenero = new TextBox();
            txtAnio = new TextBox();
            txtAutor = new TextBox();
            TabControl1.SuspendLayout();
            TabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            panelBotonesLibros.SuspendLayout();
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
            TabLibros.Controls.Add(textTitulo);
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
            // TabUsuarios
            // 
            TabUsuarios.Location = new Point(4, 24);
            TabUsuarios.Name = "TabUsuarios";
            TabUsuarios.Padding = new Padding(3);
            TabUsuarios.Size = new Size(1176, 633);
            TabUsuarios.TabIndex = 1;
            TabUsuarios.Text = "Usuarios";
            TabUsuarios.UseVisualStyleBackColor = true;
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
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Dock = DockStyle.Top;
            dgvLibros.Location = new Point(3, 3);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(1170, 300);
            dgvLibros.TabIndex = 0;
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
            panelBotonesLibros.TabIndex = 1;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(95, 64);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(75, 23);
            btnAgregarLibro.TabIndex = 0;
            btnAgregarLibro.Text = "Agregar";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += button1_Click;
            // 
            // btnEditarLibro
            // 
            btnEditarLibro.Location = new Point(210, 64);
            btnEditarLibro.Name = "btnEditarLibro";
            btnEditarLibro.Size = new Size(75, 23);
            btnEditarLibro.TabIndex = 1;
            btnEditarLibro.Text = "Editar";
            btnEditarLibro.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(321, 64);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(75, 23);
            btnEliminarLibro.TabIndex = 2;
            btnEliminarLibro.Text = "Eliminar";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarLibro
            // 
            btnLimpiarLibro.Location = new Point(436, 64);
            btnLimpiarLibro.Name = "btnLimpiarLibro";
            btnLimpiarLibro.Size = new Size(75, 23);
            btnLimpiarLibro.TabIndex = 3;
            btnLimpiarLibro.Text = "Limpiar";
            btnLimpiarLibro.UseVisualStyleBackColor = true;
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
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(289, 365);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(43, 15);
            lblAutor.TabIndex = 3;
            lblAutor.Text = "Autor :";
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
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(692, 365);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(54, 15);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Género : ";
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(117, 357);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(100, 23);
            textTitulo.TabIndex = 6;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(752, 357);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(100, 23);
            txtGenero.TabIndex = 7;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(541, 357);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 8;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(338, 357);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            panelBotonesLibros.ResumeLayout(false);
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
        private TextBox textTitulo;
    }
}
