/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 19/03/2018
 * Hora: 09:20 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FrigLab.View.Usuarios
{
	partial class CambiarCredencial
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtMensaje;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtConfirmPass;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassNuevo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtMensaje = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtConfirmPass = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassNuevo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtMensaje
			// 
			this.txtMensaje.BackColor = System.Drawing.Color.DarkRed;
			this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMensaje.ForeColor = System.Drawing.Color.White;
			this.txtMensaje.Location = new System.Drawing.Point(22, 169);
			this.txtMensaje.Multiline = true;
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.ReadOnly = true;
			this.txtMensaje.Size = new System.Drawing.Size(234, 46);
			this.txtMensaje.TabIndex = 8;
			this.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtMensaje.Visible = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(22, 221);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(105, 29);
			this.btnCancelar.TabIndex = 4;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(153, 221);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(105, 29);
			this.btnGuardar.TabIndex = 3;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtConfirmPass
			// 
			this.txtConfirmPass.Location = new System.Drawing.Point(22, 141);
			this.txtConfirmPass.Name = "txtConfirmPass";
			this.txtConfirmPass.PasswordChar = '*';
			this.txtConfirmPass.Size = new System.Drawing.Size(235, 20);
			this.txtConfirmPass.TabIndex = 2;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(24, 37);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(235, 20);
			this.txtPass.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(22, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 17);
			this.label6.TabIndex = 7;
			this.label6.Text = "Confirmar Password";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(22, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 14);
			this.label4.TabIndex = 5;
			this.label4.Text = "Password Actual";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "Password Nuevo";
			// 
			// txtPassNuevo
			// 
			this.txtPassNuevo.Location = new System.Drawing.Point(24, 85);
			this.txtPassNuevo.Name = "txtPassNuevo";
			this.txtPassNuevo.PasswordChar = '*';
			this.txtPassNuevo.Size = new System.Drawing.Size(235, 20);
			this.txtPassNuevo.TabIndex = 1;
			// 
			// CambiarCredencial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.txtMensaje);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtConfirmPass);
			this.Controls.Add(this.txtPassNuevo);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.MaximizeBox = false;
			this.Name = "CambiarCredencial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cambiar Password";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CambiarCredencialFormFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
