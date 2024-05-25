namespace Vista
{
    partial class FormRegistros
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
            dgvDevoluciones = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dgvMultas = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).BeginInit();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(633, 560);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(138, 64);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // dgvDevoluciones
            // 
            dgvDevoluciones.AllowUserToAddRows = false;
            dgvDevoluciones.AllowUserToDeleteRows = false;
            dgvDevoluciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevoluciones.Location = new Point(22, 65);
            dgvDevoluciones.Name = "dgvDevoluciones";
            dgvDevoluciones.ReadOnly = true;
            dgvDevoluciones.RowTemplate.Height = 25;
            dgvDevoluciones.Size = new Size(749, 150);
            dgvDevoluciones.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2676, 71);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "Devoluciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 36);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Devoluciones";
            // 
            // dgvMultas
            // 
            dgvMultas.AllowUserToAddRows = false;
            dgvMultas.AllowUserToDeleteRows = false;
            dgvMultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMultas.Location = new Point(22, 276);
            dgvMultas.Name = "dgvMultas";
            dgvMultas.ReadOnly = true;
            dgvMultas.RowTemplate.Height = 25;
            dgvMultas.Size = new Size(749, 150);
            dgvMultas.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 248);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Multas";
            // 
            // FormRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 636);
            Controls.Add(label3);
            Controls.Add(dgvMultas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDevoluciones);
            Controls.Add(buttonSalir);
            Name = "FormRegistros";
            Text = "FormRegistros";
            Load += FormRegistros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private DataGridView dgvDevoluciones;
        private Label label1;
        private Label label2;
        private DataGridView dgvMultas;
        private Label label3;
    }
}