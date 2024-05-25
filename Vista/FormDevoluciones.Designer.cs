namespace Vista
{
    partial class FormDevoluciones
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
            buttonSalir = new Button();
            dgvPrestamos = new DataGridView();
            textBoxBuscar = new TextBox();
            label1 = new Label();
            buttonGenerarDevolucion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(654, 356);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(114, 71);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(23, 59);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowTemplate.Height = 25;
            dgvPrestamos.Size = new Size(745, 276);
            dgvPrestamos.TabIndex = 1;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Location = new Point(90, 26);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(678, 23);
            textBoxBuscar.TabIndex = 2;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Buscar";
            // 
            // buttonGenerarDevolucion
            // 
            buttonGenerarDevolucion.Location = new Point(33, 356);
            buttonGenerarDevolucion.Name = "buttonGenerarDevolucion";
            buttonGenerarDevolucion.Size = new Size(156, 71);
            buttonGenerarDevolucion.TabIndex = 4;
            buttonGenerarDevolucion.Text = "Generar Devolucion";
            buttonGenerarDevolucion.UseVisualStyleBackColor = true;
            buttonGenerarDevolucion.Click += buttonGenerarDevolucion_Click;
            // 
            // FormDevoluciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 450);
            Controls.Add(buttonGenerarDevolucion);
            Controls.Add(label1);
            Controls.Add(textBoxBuscar);
            Controls.Add(dgvPrestamos);
            Controls.Add(buttonSalir);
            Name = "FormDevoluciones";
            Text = "FormDevoluciones";
            Load += FormDevoluciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private DataGridView dgvPrestamos;
        private TextBox textBoxBuscar;
        private Label label1;
        private Button buttonGenerarDevolucion;
    }
}