/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 19/04/2018
 * Hora: 08:18 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FrigLab.View.Resultados
{
	partial class NuevoResultado
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox GrupoRecuento;
		private System.Windows.Forms.TextBox txtResultadoRecuento;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox GrupoDeteccion;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboResultadoDeteccion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker pickerFechaAnalisis;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker pickerFechaResultado;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		
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
            this.GrupoRecuento = new System.Windows.Forms.GroupBox();
            this.txtResultadoRecuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GrupoDeteccion = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboResultadoDeteccion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pickerFechaAnalisis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pickerFechaResultado = new System.Windows.Forms.DateTimePicker();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.GrupoRecuento.SuspendLayout();
            this.GrupoDeteccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrupoRecuento
            // 
            this.GrupoRecuento.Controls.Add(this.txtResultadoRecuento);
            this.GrupoRecuento.Controls.Add(this.label5);
            this.GrupoRecuento.Location = new System.Drawing.Point(17, 82);
            this.GrupoRecuento.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoRecuento.Name = "GrupoRecuento";
            this.GrupoRecuento.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoRecuento.Size = new System.Drawing.Size(349, 86);
            this.GrupoRecuento.TabIndex = 27;
            this.GrupoRecuento.TabStop = false;
            this.GrupoRecuento.Text = "Recuento";
            // 
            // txtResultadoRecuento
            // 
            this.txtResultadoRecuento.Location = new System.Drawing.Point(121, 37);
            this.txtResultadoRecuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultadoRecuento.Name = "txtResultadoRecuento";
            this.txtResultadoRecuento.Size = new System.Drawing.Size(208, 22);
            this.txtResultadoRecuento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Resultado";
            // 
            // GrupoDeteccion
            // 
            this.GrupoDeteccion.Controls.Add(this.label6);
            this.GrupoDeteccion.Controls.Add(this.cboResultadoDeteccion);
            this.GrupoDeteccion.Location = new System.Drawing.Point(17, 82);
            this.GrupoDeteccion.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoDeteccion.Name = "GrupoDeteccion";
            this.GrupoDeteccion.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoDeteccion.Size = new System.Drawing.Size(349, 86);
            this.GrupoDeteccion.TabIndex = 28;
            this.GrupoDeteccion.TabStop = false;
            this.GrupoDeteccion.Text = "Deteccion";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Resultado";
            // 
            // cboResultadoDeteccion
            // 
            this.cboResultadoDeteccion.FormattingEnabled = true;
            this.cboResultadoDeteccion.Location = new System.Drawing.Point(117, 34);
            this.cboResultadoDeteccion.Margin = new System.Windows.Forms.Padding(4);
            this.cboResultadoDeteccion.Name = "cboResultadoDeteccion";
            this.cboResultadoDeteccion.Size = new System.Drawing.Size(208, 24);
            this.cboResultadoDeteccion.TabIndex = 0;
            this.cboResultadoDeteccion.SelectedIndexChanged += new System.EventHandler(this.CboResultadoDeteccion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de Analisis";
            // 
            // pickerFechaAnalisis
            // 
            this.pickerFechaAnalisis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerFechaAnalisis.Location = new System.Drawing.Point(17, 39);
            this.pickerFechaAnalisis.Margin = new System.Windows.Forms.Padding(4);
            this.pickerFechaAnalisis.Name = "pickerFechaAnalisis";
            this.pickerFechaAnalisis.Size = new System.Drawing.Size(156, 22);
            this.pickerFechaAnalisis.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(204, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de Resultado";
            // 
            // pickerFechaResultado
            // 
            this.pickerFechaResultado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerFechaResultado.Location = new System.Drawing.Point(204, 39);
            this.pickerFechaResultado.Margin = new System.Windows.Forms.Padding(4);
            this.pickerFechaResultado.Name = "pickerFechaResultado";
            this.pickerFechaResultado.Size = new System.Drawing.Size(157, 22);
            this.pickerFechaResultado.TabIndex = 29;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(17, 202);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(348, 160);
            this.txtObservaciones.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Observaciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(48, 392);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 36);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(208, 392);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 36);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // NuevoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pickerFechaResultado);
            this.Controls.Add(this.pickerFechaAnalisis);
            this.Controls.Add(this.GrupoDeteccion);
            this.Controls.Add(this.GrupoRecuento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "NuevoResultado";
            this.Text = "NuevoResultado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevoResultadoFormClosing);
            this.GrupoRecuento.ResumeLayout(false);
            this.GrupoRecuento.PerformLayout();
            this.GrupoDeteccion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
