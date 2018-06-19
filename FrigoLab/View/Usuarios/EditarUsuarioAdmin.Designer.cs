namespace FrigLab.View.Usuarios {
    partial class EditarUsuarioAdmin {
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPadron = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grupoPermiso = new System.Windows.Forms.GroupBox();
            this.radioVisitante = new System.Windows.Forms.RadioButton();
            this.radioMonitor = new System.Windows.Forms.RadioButton();
            this.radioAnalista = new System.Windows.Forms.RadioButton();
            this.radioVerificador = new System.Windows.Forms.RadioButton();
            this.radioAdministrador = new System.Windows.Forms.RadioButton();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.bntCambiarCredencial = new System.Windows.Forms.Button();
            this.panelInferiorControles = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grupoPermiso.SuspendLayout();
            this.panelInferiorControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.DarkRed;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.White;
            this.txtMensaje.Location = new System.Drawing.Point(35, 342);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(312, 49);
            this.txtMensaje.TabIndex = 23;
            this.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMensaje.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(196, 82);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(149, 22);
            this.txtApellido.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(195, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Apellido";
            // 
            // txtPadron
            // 
            this.txtPadron.Location = new System.Drawing.Point(109, 15);
            this.txtPadron.Margin = new System.Windows.Forms.Padding(4);
            this.txtPadron.Name = "txtPadron";
            this.txtPadron.ReadOnly = true;
            this.txtPadron.Size = new System.Drawing.Size(237, 22);
            this.txtPadron.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(35, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Padron";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(109, 124);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(236, 22);
            this.txtCorreo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Correo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 82);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(35, 50);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(133, 28);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            // 
            // grupoPermiso
            // 
            this.grupoPermiso.Controls.Add(this.radioVisitante);
            this.grupoPermiso.Controls.Add(this.radioMonitor);
            this.grupoPermiso.Controls.Add(this.radioAnalista);
            this.grupoPermiso.Controls.Add(this.radioVerificador);
            this.grupoPermiso.Controls.Add(this.radioAdministrador);
            this.grupoPermiso.Location = new System.Drawing.Point(35, 156);
            this.grupoPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoPermiso.Name = "grupoPermiso";
            this.grupoPermiso.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoPermiso.Size = new System.Drawing.Size(312, 100);
            this.grupoPermiso.TabIndex = 24;
            this.grupoPermiso.TabStop = false;
            this.grupoPermiso.Text = "Permiso";
            // 
            // radioVisitante
            // 
            this.radioVisitante.AutoSize = true;
            this.radioVisitante.Location = new System.Drawing.Point(170, 44);
            this.radioVisitante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioVisitante.Name = "radioVisitante";
            this.radioVisitante.Size = new System.Drawing.Size(83, 21);
            this.radioVisitante.TabIndex = 3;
            this.radioVisitante.TabStop = true;
            this.radioVisitante.Text = "Visitante";
            this.radioVisitante.UseVisualStyleBackColor = true;
            // 
            // radioMonitor
            // 
            this.radioMonitor.AutoSize = true;
            this.radioMonitor.Location = new System.Drawing.Point(170, 19);
            this.radioMonitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMonitor.Name = "radioMonitor";
            this.radioMonitor.Size = new System.Drawing.Size(76, 21);
            this.radioMonitor.TabIndex = 3;
            this.radioMonitor.TabStop = true;
            this.radioMonitor.Text = "Monitor";
            this.radioMonitor.UseVisualStyleBackColor = true;
            // 
            // radioAnalista
            // 
            this.radioAnalista.AutoSize = true;
            this.radioAnalista.Location = new System.Drawing.Point(25, 69);
            this.radioAnalista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAnalista.Name = "radioAnalista";
            this.radioAnalista.Size = new System.Drawing.Size(79, 21);
            this.radioAnalista.TabIndex = 2;
            this.radioAnalista.TabStop = true;
            this.radioAnalista.Text = "Analista";
            this.radioAnalista.UseVisualStyleBackColor = true;
            // 
            // radioVerificador
            // 
            this.radioVerificador.AutoSize = true;
            this.radioVerificador.Location = new System.Drawing.Point(25, 44);
            this.radioVerificador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioVerificador.Name = "radioVerificador";
            this.radioVerificador.Size = new System.Drawing.Size(97, 21);
            this.radioVerificador.TabIndex = 1;
            this.radioVerificador.TabStop = true;
            this.radioVerificador.Text = "Verificador";
            this.radioVerificador.UseVisualStyleBackColor = true;
            // 
            // radioAdministrador
            // 
            this.radioAdministrador.AutoSize = true;
            this.radioAdministrador.Location = new System.Drawing.Point(25, 19);
            this.radioAdministrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAdministrador.Name = "radioAdministrador";
            this.radioAdministrador.Size = new System.Drawing.Size(116, 21);
            this.radioAdministrador.TabIndex = 0;
            this.radioAdministrador.TabStop = true;
            this.radioAdministrador.Text = "Administrador";
            this.radioAdministrador.UseVisualStyleBackColor = true;
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Checked = true;
            this.chkVigente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVigente.Location = new System.Drawing.Point(59, 266);
            this.chkVigente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(110, 21);
            this.chkVigente.TabIndex = 25;
            this.chkVigente.Text = "Esta Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            this.chkVigente.CheckedChanged += new System.EventHandler(this.ChkVigente_CheckedChanged);
            // 
            // bntCambiarCredencial
            // 
            this.bntCambiarCredencial.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bntCambiarCredencial.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntCambiarCredencial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.bntCambiarCredencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCambiarCredencial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCambiarCredencial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bntCambiarCredencial.Location = new System.Drawing.Point(33, 291);
            this.bntCambiarCredencial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntCambiarCredencial.Name = "bntCambiarCredencial";
            this.bntCambiarCredencial.Size = new System.Drawing.Size(314, 36);
            this.bntCambiarCredencial.TabIndex = 48;
            this.bntCambiarCredencial.Text = "Cambiar Password";
            this.bntCambiarCredencial.UseVisualStyleBackColor = false;
            this.bntCambiarCredencial.Click += new System.EventHandler(this.BntCambiarCredencialClick);
            // 
            // panelInferiorControles
            // 
            this.panelInferiorControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panelInferiorControles.Controls.Add(this.btnGuardar);
            this.panelInferiorControles.Controls.Add(this.btnCancelar);
            this.panelInferiorControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferiorControles.Location = new System.Drawing.Point(0, 403);
            this.panelInferiorControles.Name = "panelInferiorControles";
            this.panelInferiorControles.Size = new System.Drawing.Size(381, 68);
            this.panelInferiorControles.TabIndex = 52;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.Location = new System.Drawing.Point(212, 19);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 36);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Location = new System.Drawing.Point(36, 19);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // EditarUsuarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 471);
            this.Controls.Add(this.panelInferiorControles);
            this.Controls.Add(this.bntCambiarCredencial);
            this.Controls.Add(this.chkVigente);
            this.Controls.Add(this.grupoPermiso);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPadron);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 518);
            this.MinimumSize = new System.Drawing.Size(399, 518);
            this.Name = "EditarUsuarioAdmin";
            this.Text = "Editar Usuario (Admin)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarUsuarioAdminForm_FormClosing);
            this.grupoPermiso.ResumeLayout(false);
            this.grupoPermiso.PerformLayout();
            this.panelInferiorControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPadron;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grupoPermiso;
        private System.Windows.Forms.RadioButton radioMonitor;
        private System.Windows.Forms.RadioButton radioAnalista;
        private System.Windows.Forms.RadioButton radioVerificador;
        private System.Windows.Forms.RadioButton radioAdministrador;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.RadioButton radioVisitante;
        private System.Windows.Forms.Button bntCambiarCredencial;
        private System.Windows.Forms.Panel panelInferiorControles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}