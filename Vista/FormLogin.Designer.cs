using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    partial class FormLogin : Form
    {
        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Button buttonIngresar;
        private Button buttonCancelar;

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
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            buttonIngresar = new Button();
            buttonCancelar = new Button();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 83);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 156);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Location = new Point(227, 86);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(167, 23);
            textBoxUsuario.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BorderStyle = BorderStyle.FixedSingle;
            textBoxContraseña.Location = new Point(225, 154);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.Size = new Size(169, 23);
            textBoxContraseña.TabIndex = 3;
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(321, 234);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(137, 86);
            buttonIngresar.TabIndex = 4;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(121, 234);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(133, 86);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(638, 340);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(150, 98);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalir);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
    }
}
