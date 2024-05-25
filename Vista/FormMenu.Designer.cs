namespace Vista
{
    partial class FormMenu
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
            panel1 = new Panel();
            buttonReglas = new Button();
            button1 = new Button();
            buttonPrestamos = new Button();
            buttonSocios = new Button();
            buttonLibros = new Button();
            buttonSalir = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonReglas);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonPrestamos);
            panel1.Controls.Add(buttonSocios);
            panel1.Controls.Add(buttonLibros);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 492);
            panel1.TabIndex = 0;
            // 
            // buttonReglas
            // 
            buttonReglas.Dock = DockStyle.Top;
            buttonReglas.Location = new Point(0, 306);
            buttonReglas.Name = "buttonReglas";
            buttonReglas.Size = new Size(197, 87);
            buttonReglas.TabIndex = 2;
            buttonReglas.Text = "Reglas de la Biblioteca";
            buttonReglas.UseVisualStyleBackColor = true;
            buttonReglas.Click += buttonReglas_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 229);
            button1.Name = "button1";
            button1.Size = new Size(197, 77);
            button1.TabIndex = 2;
            button1.Text = "Consulta Prestamos \r\n\r\n Generar Devoluciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonPrestamos
            // 
            buttonPrestamos.Dock = DockStyle.Top;
            buttonPrestamos.Location = new Point(0, 152);
            buttonPrestamos.Name = "buttonPrestamos";
            buttonPrestamos.Size = new Size(197, 77);
            buttonPrestamos.TabIndex = 2;
            buttonPrestamos.Text = "Generar Prestamos ";
            buttonPrestamos.UseVisualStyleBackColor = true;
            buttonPrestamos.Click += buttonPrestamos_Click;
            // 
            // buttonSocios
            // 
            buttonSocios.Dock = DockStyle.Top;
            buttonSocios.Location = new Point(0, 81);
            buttonSocios.Name = "buttonSocios";
            buttonSocios.Size = new Size(197, 71);
            buttonSocios.TabIndex = 1;
            buttonSocios.Text = "Socios";
            buttonSocios.UseVisualStyleBackColor = true;
            buttonSocios.Click += buttonSocios_Click;
            // 
            // buttonLibros
            // 
            buttonLibros.Dock = DockStyle.Top;
            buttonLibros.Location = new Point(0, 0);
            buttonLibros.Name = "buttonLibros";
            buttonLibros.Size = new Size(197, 81);
            buttonLibros.TabIndex = 0;
            buttonLibros.Text = "Libros";
            buttonLibros.UseVisualStyleBackColor = true;
            buttonLibros.Click += buttonLibros_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(609, 329);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(156, 74);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 390);
            button2.Name = "button2";
            button2.Size = new Size(197, 102);
            button2.TabIndex = 3;
            button2.Text = "Registros";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(buttonSalir);
            Controls.Add(panel1);
            Name = "FormMenu";
            Text = "Menu";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonLibros;
        private Button buttonSalir;
        private Button buttonSocios;
        private Button buttonPrestamos;
        private Button buttonReglas;
        private Button button1;
        private Button button2;
    }
}