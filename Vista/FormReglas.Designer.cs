namespace Vista
{
    partial class FormReglas
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
            textBoxDiasMulta = new TextBox();
            label3 = new Label();
            buttonModificar = new Button();
            buttonSalir = new Button();
            label2 = new Label();
            textBoxMaximoPrestamo = new TextBox();
            label1 = new Label();
            textBoxDiasPrestamo = new TextBox();
            dgvReglas = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReglas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxDiasMulta);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonModificar);
            panel1.Controls.Add(buttonSalir);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxMaximoPrestamo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxDiasPrestamo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 440);
            panel1.TabIndex = 0;
            // 
            // textBoxDiasMulta
            // 
            textBoxDiasMulta.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiasMulta.Location = new Point(31, 169);
            textBoxDiasMulta.Name = "textBoxDiasMulta";
            textBoxDiasMulta.Size = new Size(189, 23);
            textBoxDiasMulta.TabIndex = 6;
            textBoxDiasMulta.TextChanged += textBoxDiasMulta_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 144);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 5;
            label3.Text = "Dias de Multa";
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(23, 270);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(175, 60);
            buttonModificar.TabIndex = 4;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Dock = DockStyle.Bottom;
            buttonSalir.Location = new Point(0, 369);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(238, 71);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(197, 15);
            label2.TabIndex = 1;
            label2.Text = "Maxima Cantidad de libros a Prestar";
            // 
            // textBoxMaximoPrestamo
            // 
            textBoxMaximoPrestamo.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaximoPrestamo.Location = new Point(29, 110);
            textBoxMaximoPrestamo.Name = "textBoxMaximoPrestamo";
            textBoxMaximoPrestamo.Size = new Size(191, 23);
            textBoxMaximoPrestamo.TabIndex = 2;
            textBoxMaximoPrestamo.TextChanged += textBoxMaximoPrestamo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 1;
            label1.Text = "Cantidad dias de prestamo";
            // 
            // textBoxDiasPrestamo
            // 
            textBoxDiasPrestamo.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiasPrestamo.Location = new Point(29, 38);
            textBoxDiasPrestamo.Name = "textBoxDiasPrestamo";
            textBoxDiasPrestamo.Size = new Size(191, 23);
            textBoxDiasPrestamo.TabIndex = 0;
            textBoxDiasPrestamo.TextChanged += textBoxDiasPrestamo_TextChanged;
            // 
            // dgvReglas
            // 
            dgvReglas.AllowUserToAddRows = false;
            dgvReglas.AllowUserToDeleteRows = false;
            dgvReglas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReglas.Location = new Point(254, 12);
            dgvReglas.Name = "dgvReglas";
            dgvReglas.ReadOnly = true;
            dgvReglas.RowTemplate.Height = 25;
            dgvReglas.Size = new Size(471, 416);
            dgvReglas.TabIndex = 1;
            dgvReglas.CellContentClick += dgvReglas_CellContentClick;
            // 
            // FormReglas
            // 
            ClientSize = new Size(737, 440);
            Controls.Add(dgvReglas);
            Controls.Add(panel1);
            Name = "FormReglas";
            Text = "FormReglas";
            Load += FormReglas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReglas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox textBoxMaximoPrestamo;
        private Label label1;
        private TextBox textBoxDiasPrestamo;
        private Button buttonSalir;
        private DataGridView dgvReglas;
        private Button buttonModificar;
        private TextBox textBoxDiasMulta;
        private Label label3;
    }
}