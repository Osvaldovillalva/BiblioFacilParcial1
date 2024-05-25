namespace Vista
{
    partial class FormPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGenerarPrestamo = new Button();
            label2 = new Label();
            textBoxDatosLibro = new TextBox();
            buttonSalir = new Button();
            label1 = new Label();
            textBoxDatosSocio = new TextBox();
            dgvSocios = new DataGridView();
            dgvLibros = new DataGridView();
            buttonLimpiartodo = new Button();
            listBoxCarrito = new ListBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // buttonGenerarPrestamo
            // 
            buttonGenerarPrestamo.Location = new Point(863, 334);
            buttonGenerarPrestamo.Name = "buttonGenerarPrestamo";
            buttonGenerarPrestamo.Size = new Size(201, 61);
            buttonGenerarPrestamo.TabIndex = 2;
            buttonGenerarPrestamo.Text = "Generar Prestamo";
            buttonGenerarPrestamo.UseVisualStyleBackColor = true;
            buttonGenerarPrestamo.Click += buttonGenerarPrestamo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 168);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Datos Libro";
            // 
            // textBoxDatosLibro
            // 
            textBoxDatosLibro.BorderStyle = BorderStyle.FixedSingle;
            textBoxDatosLibro.Location = new Point(14, 186);
            textBoxDatosLibro.Name = "textBoxDatosLibro";
            textBoxDatosLibro.Size = new Size(818, 23);
            textBoxDatosLibro.TabIndex = 8;
            textBoxDatosLibro.TextChanged += textBoxDatosLibro_TextChanged;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(1100, 414);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(201, 63);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Datos Socio";
            // 
            // textBoxDatosSocio
            // 
            textBoxDatosSocio.BorderStyle = BorderStyle.FixedSingle;
            textBoxDatosSocio.Location = new Point(13, 27);
            textBoxDatosSocio.Name = "textBoxDatosSocio";
            textBoxDatosSocio.Size = new Size(819, 23);
            textBoxDatosSocio.TabIndex = 4;
            textBoxDatosSocio.TextChanged += textBoxDatosSocio_TextChanged;
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(13, 56);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowTemplate.Height = 25;
            dgvSocios.Size = new Size(819, 97);
            dgvSocios.TabIndex = 10;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(14, 215);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowTemplate.Height = 25;
            dgvLibros.Size = new Size(818, 249);
            dgvLibros.TabIndex = 11;
            // 
            // buttonLimpiartodo
            // 
            buttonLimpiartodo.Location = new Point(1100, 321);
            buttonLimpiartodo.Name = "buttonLimpiartodo";
            buttonLimpiartodo.Size = new Size(201, 58);
            buttonLimpiartodo.TabIndex = 12;
            buttonLimpiartodo.Text = "Limpiar todo";
            buttonLimpiartodo.UseVisualStyleBackColor = true;
            buttonLimpiartodo.Click += buttonLimpiartodo_Click;
            // 
            // listBoxCarrito
            // 
            listBoxCarrito.FormattingEnabled = true;
            listBoxCarrito.ItemHeight = 15;
            listBoxCarrito.Location = new Point(863, 56);
            listBoxCarrito.Name = "listBoxCarrito";
            listBoxCarrito.Size = new Size(438, 259);
            listBoxCarrito.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(863, 27);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 14;
            label3.Text = "Carrito";
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 478);
            Controls.Add(label3);
            Controls.Add(listBoxCarrito);
            Controls.Add(buttonLimpiartodo);
            Controls.Add(dgvLibros);
            Controls.Add(dgvSocios);
            Controls.Add(buttonSalir);
            Controls.Add(label1);
            Controls.Add(textBoxDatosSocio);
            Controls.Add(label2);
            Controls.Add(textBoxDatosLibro);
            Controls.Add(buttonGenerarPrestamo);
            Name = "FormPrestamos";
            Text = "FormPrestamos";
            Load += FormPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonGenerarPrestamo;
        private Label label2;
        private TextBox textBoxDatosLibro;
        private Button buttonSalir;
        private Label label1;
        private TextBox textBoxDatosSocio;
        private DataGridView dgvSocios;
        private DataGridView dgvLibros;
        private Button buttonLimpiartodo;
        private ListBox listBoxCarrito;
        private Label label3;
    }
}