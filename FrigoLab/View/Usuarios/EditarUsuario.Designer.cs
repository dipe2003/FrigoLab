namespace FrigLab.View.Usuarios {
    partial class EditarUsuario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
        	this.txtMensaje = new System.Windows.Forms.TextBox();
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.btnGuardar = new System.Windows.Forms.Button();
        	this.txtApellido = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtPadron = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.txtCorreo = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.bntCambiarCredencial = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// txtMensaje
        	// 
        	this.txtMensaje.BackColor = System.Drawing.Color.DarkRed;
        	this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtMensaje.ForeColor = System.Drawing.Color.White;
        	this.txtMensaje.Location = new System.Drawing.Point(30, 195);
        	this.txtMensaje.Multiline = true;
        	this.txtMensaje.Name = "txtMensaje";
        	this.txtMensaje.ReadOnly = true;
        	this.txtMensaje.Size = new System.Drawing.Size(234, 46);
        	this.txtMensaje.TabIndex = 11;
        	this.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	this.txtMensaje.Visible = false;
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Location = new System.Drawing.Point(30, 261);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(105, 29);
        	this.btnCancelar.TabIndex = 5;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Location = new System.Drawing.Point(159, 261);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(105, 29);
        	this.btnGuardar.TabIndex = 4;
        	this.btnGuardar.Text = "Guardar";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
        	// 
        	// txtApellido
        	// 
        	this.txtApellido.Location = new System.Drawing.Point(152, 80);
        	this.txtApellido.Name = "txtApellido";
        	this.txtApellido.Size = new System.Drawing.Size(113, 20);
        	this.txtApellido.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(150, 54);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(100, 23);
        	this.label1.TabIndex = 9;
        	this.label1.Text = "Apellido";
        	// 
        	// txtPadron
        	// 
        	this.txtPadron.Location = new System.Drawing.Point(85, 18);
        	this.txtPadron.Name = "txtPadron";
        	this.txtPadron.ReadOnly = true;
        	this.txtPadron.Size = new System.Drawing.Size(180, 20);
        	this.txtPadron.TabIndex = 7;
        	// 
        	// label3
        	// 
        	this.label3.Location = new System.Drawing.Point(30, 20);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(100, 23);
        	this.label3.TabIndex = 6;
        	this.label3.Text = "Padron";
        	// 
        	// txtCorreo
        	// 
        	this.txtCorreo.Location = new System.Drawing.Point(85, 110);
        	this.txtCorreo.Name = "txtCorreo";
        	this.txtCorreo.Size = new System.Drawing.Size(180, 20);
        	this.txtCorreo.TabIndex = 2;
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(28, 113);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(43, 23);
        	this.label2.TabIndex = 10;
        	this.label2.Text = "Correo";
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Location = new System.Drawing.Point(30, 80);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(113, 20);
        	this.txtNombre.TabIndex = 0;
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.Location = new System.Drawing.Point(30, 54);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(100, 23);
        	this.lblNombre.TabIndex = 8;
        	this.lblNombre.Text = "Nombre";
        	// 
        	// bntCambiarCredencial
        	// 
        	this.bntCambiarCredencial.Location = new System.Drawing.Point(30, 150);
        	this.bntCambiarCredencial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.bntCambiarCredencial.Name = "bntCambiarCredencial";
        	this.bntCambiarCredencial.Size = new System.Drawing.Size(234, 29);
        	this.bntCambiarCredencial.TabIndex = 3;
        	this.bntCambiarCredencial.Text = "Cambiar Password";
        	this.bntCambiarCredencial.UseVisualStyleBackColor = true;
        	this.bntCambiarCredencial.Click += new System.EventHandler(this.BntCambiarCredencialClick);
        	// 
        	// EditarUsuario
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(296, 310);
        	this.Controls.Add(this.bntCambiarCredencial);
        	this.Controls.Add(this.txtMensaje);
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnGuardar);
        	this.Controls.Add(this.txtApellido);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.txtPadron);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.txtCorreo);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.txtNombre);
        	this.Controls.Add(this.lblNombre);
        	this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.MaximizeBox = false;
        	this.MaximumSize = new System.Drawing.Size(312, 348);
        	this.MinimumSize = new System.Drawing.Size(312, 348);
        	this.Name = "EditarUsuario";
        	this.Text = "Editar Usuario";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarUsuarioForm_FormClosing);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPadron;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button bntCambiarCredencial;
    }
}