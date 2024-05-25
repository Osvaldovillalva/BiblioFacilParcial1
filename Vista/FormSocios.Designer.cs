namespace Vista
{
    partial class FormSocios
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDni = new TextBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            buttonLimpiar = new Button();
            buttonAgregar = new Button();
            BtnModificar = new Button();
            buttonBorrar = new Button();
            buttonSalir = new Button();
            dgvSocios = new DataGridView();
            textBoxBuscar = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxDni);
            panel1.Controls.Add(textBoxApellido);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(buttonLimpiar);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(BtnModificar);
            panel1.Controls.Add(buttonBorrar);
            panel1.Controls.Add(buttonSalir);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 488);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 117);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 11;
            label3.Text = "D.N.I";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 67);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // textBoxDni
            // 
            textBoxDni.BorderStyle = BorderStyle.FixedSingle;
            textBoxDni.Location = new Point(14, 135);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(192, 23);
            textBoxDni.TabIndex = 8;
            textBoxDni.TextChanged += textBoxDni_TextChanged;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BorderStyle = BorderStyle.FixedSingle;
            textBoxApellido.Location = new Point(14, 85);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(192, 23);
            textBoxApellido.TabIndex = 7;
            textBoxApellido.TextChanged += textBoxApellido_TextChanged;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Location = new Point(11, 34);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(195, 23);
            textBoxNombre.TabIndex = 6;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(45, 174);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(137, 51);
            buttonLimpiar.TabIndex = 5;
            buttonLimpiar.Text = "Limpiar Todo";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Dock = DockStyle.Bottom;
            buttonAgregar.Location = new Point(0, 265);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(225, 59);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Dock = DockStyle.Bottom;
            BtnModificar.Location = new Point(0, 324);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(225, 52);
            BtnModificar.TabIndex = 3;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Dock = DockStyle.Bottom;
            buttonBorrar.Location = new Point(0, 376);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(225, 56);
            buttonBorrar.TabIndex = 2;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Dock = DockStyle.Bottom;
            buttonSalir.Location = new Point(0, 432);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(225, 54);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(251, 48);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowTemplate.Height = 25;
            dgvSocios.Size = new Size(917, 428);
            dgvSocios.TabIndex = 2;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Location = new Point(299, 14);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(869, 23);
            textBoxBuscar.TabIndex = 3;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 17);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Buscar";
            // 
            // FormSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 488);
            Controls.Add(label4);
            Controls.Add(textBoxBuscar);
            Controls.Add(dgvSocios);
            Controls.Add(panel1);
            Name = "FormSocios";
            Text = "FormSocios";
            Load += FormSocios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonSalir;
        private DataGridView dgvSocios;
        private Button buttonLimpiar;
        private Button buttonAgregar;
        private Button BtnModificar;
        private Button buttonBorrar;
        private TextBox textBoxNombre;
        private TextBox textBoxDni;
        private TextBox textBoxApellido;
        private Label label1;
        private TextBox textBoxBuscar;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}