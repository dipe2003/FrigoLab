/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 26/03/2018
 * Hora: 08:53 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FrigLab.View.Requisitos
{
	partial class NuevoLimite
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtReferencias;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.GroupBox GrupoBusqueda;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboInaceptable;
		private System.Windows.Forms.ComboBox cboAceptable;
		private System.Windows.Forms.GroupBox GrupoMarginal;
		private System.Windows.Forms.TextBox txtMarginalInaceptable;
		private System.Windows.Forms.TextBox txtMarginalMarginal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox GrupoRecuento;
		private System.Windows.Forms.TextBox txtRecuentoInaceptable;
		private System.Windows.Forms.Label label5;
		
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
            this.txtReferencias = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.GrupoBusqueda = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboInaceptable = new System.Windows.Forms.ComboBox();
            this.cboAceptable = new System.Windows.Forms.ComboBox();
            this.GrupoMarginal = new System.Windows.Forms.GroupBox();
            this.txtMarginalInaceptable = new System.Windows.Forms.TextBox();
            this.txtMarginalMarginal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrupoRecuento = new System.Windows.Forms.GroupBox();
            this.txtRecuentoInaceptable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEnsayos = new System.Windows.Forms.ComboBox();
            this.grupoClaseMuestra = new System.Windows.Forms.GroupBox();
            this.radioOtra = new System.Windows.Forms.RadioButton();
            this.radioSuperficie = new System.Windows.Forms.RadioButton();
            this.radioAmbiente = new System.Windows.Forms.RadioButton();
            this.radioOperario = new System.Windows.Forms.RadioButton();
            this.radioProducto = new System.Windows.Forms.RadioButton();
            this.panelInferiorControles = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.GrupoBusqueda.SuspendLayout();
            this.GrupoMarginal.SuspendLayout();
            this.GrupoRecuento.SuspendLayout();
            this.grupoClaseMuestra.SuspendLayout();
            this.panelInferiorControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReferencias
            // 
            this.txtReferencias.Location = new System.Drawing.Point(28, 39);
            this.txtReferencias.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferencias.Multiline = true;
            this.txtReferencias.Name = "txtReferencias";
            this.txtReferencias.Size = new System.Drawing.Size(351, 29);
            this.txtReferencias.TabIndex = 21;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(25, 14);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 18);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Referencias";
            // 
            // GrupoBusqueda
            // 
            this.GrupoBusqueda.Controls.Add(this.label2);
            this.GrupoBusqueda.Controls.Add(this.label1);
            this.GrupoBusqueda.Controls.Add(this.cboInaceptable);
            this.GrupoBusqueda.Controls.Add(this.cboAceptable);
            this.GrupoBusqueda.Location = new System.Drawing.Point(28, 199);
            this.GrupoBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoBusqueda.Name = "GrupoBusqueda";
            this.GrupoBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoBusqueda.Size = new System.Drawing.Size(349, 117);
            this.GrupoBusqueda.TabIndex = 26;
            this.GrupoBusqueda.TabStop = false;
            this.GrupoBusqueda.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inaceptable";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aceptable";
            // 
            // cboInaceptable
            // 
            this.cboInaceptable.FormattingEnabled = true;
            this.cboInaceptable.Location = new System.Drawing.Point(117, 73);
            this.cboInaceptable.Margin = new System.Windows.Forms.Padding(4);
            this.cboInaceptable.Name = "cboInaceptable";
            this.cboInaceptable.Size = new System.Drawing.Size(208, 24);
            this.cboInaceptable.TabIndex = 0;
            // 
            // cboAceptable
            // 
            this.cboAceptable.FormattingEnabled = true;
            this.cboAceptable.Location = new System.Drawing.Point(117, 23);
            this.cboAceptable.Margin = new System.Windows.Forms.Padding(4);
            this.cboAceptable.Name = "cboAceptable";
            this.cboAceptable.Size = new System.Drawing.Size(208, 24);
            this.cboAceptable.TabIndex = 0;
            // 
            // GrupoMarginal
            // 
            this.GrupoMarginal.Controls.Add(this.txtMarginalInaceptable);
            this.GrupoMarginal.Controls.Add(this.txtMarginalMarginal);
            this.GrupoMarginal.Controls.Add(this.label3);
            this.GrupoMarginal.Controls.Add(this.label4);
            this.GrupoMarginal.Location = new System.Drawing.Point(28, 199);
            this.GrupoMarginal.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoMarginal.Name = "GrupoMarginal";
            this.GrupoMarginal.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoMarginal.Size = new System.Drawing.Size(349, 117);
            this.GrupoMarginal.TabIndex = 26;
            this.GrupoMarginal.TabStop = false;
            this.GrupoMarginal.Text = "Resultado";
            // 
            // txtMarginalInaceptable
            // 
            this.txtMarginalInaceptable.Location = new System.Drawing.Point(117, 73);
            this.txtMarginalInaceptable.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarginalInaceptable.Name = "txtMarginalInaceptable";
            this.txtMarginalInaceptable.Size = new System.Drawing.Size(208, 22);
            this.txtMarginalInaceptable.TabIndex = 3;
            // 
            // txtMarginalMarginal
            // 
            this.txtMarginalMarginal.Location = new System.Drawing.Point(117, 25);
            this.txtMarginalMarginal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarginalMarginal.Name = "txtMarginalMarginal";
            this.txtMarginalMarginal.Size = new System.Drawing.Size(208, 22);
            this.txtMarginalMarginal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inaceptable";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Marginal";
            // 
            // GrupoRecuento
            // 
            this.GrupoRecuento.Controls.Add(this.txtRecuentoInaceptable);
            this.GrupoRecuento.Controls.Add(this.label5);
            this.GrupoRecuento.Location = new System.Drawing.Point(28, 199);
            this.GrupoRecuento.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoRecuento.Name = "GrupoRecuento";
            this.GrupoRecuento.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoRecuento.Size = new System.Drawing.Size(349, 117);
            this.GrupoRecuento.TabIndex = 26;
            this.GrupoRecuento.TabStop = false;
            this.GrupoRecuento.Text = "Resultado";
            // 
            // txtRecuentoInaceptable
            // 
            this.txtRecuentoInaceptable.Location = new System.Drawing.Point(117, 73);
            this.txtRecuentoInaceptable.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecuentoInaceptable.Name = "txtRecuentoInaceptable";
            this.txtRecuentoInaceptable.Size = new System.Drawing.Size(208, 22);
            this.txtRecuentoInaceptable.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Inaceptable";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ensayo";
            // 
            // cboEnsayos
            // 
            this.cboEnsayos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEnsayos.FormattingEnabled = true;
            this.cboEnsayos.Location = new System.Drawing.Point(28, 170);
            this.cboEnsayos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEnsayos.Name = "cboEnsayos";
            this.cboEnsayos.Size = new System.Drawing.Size(351, 24);
            this.cboEnsayos.TabIndex = 27;
            this.cboEnsayos.SelectedIndexChanged += new System.EventHandler(this.CboEnsayosSelectedIndexChanged);
            // 
            // grupoClaseMuestra
            // 
            this.grupoClaseMuestra.Controls.Add(this.radioOtra);
            this.grupoClaseMuestra.Controls.Add(this.radioSuperficie);
            this.grupoClaseMuestra.Controls.Add(this.radioAmbiente);
            this.grupoClaseMuestra.Controls.Add(this.radioOperario);
            this.grupoClaseMuestra.Controls.Add(this.radioProducto);
            this.grupoClaseMuestra.Location = new System.Drawing.Point(28, 74);
            this.grupoClaseMuestra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoClaseMuestra.Name = "grupoClaseMuestra";
            this.grupoClaseMuestra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoClaseMuestra.Size = new System.Drawing.Size(349, 71);
            this.grupoClaseMuestra.TabIndex = 28;
            this.grupoClaseMuestra.TabStop = false;
            this.grupoClaseMuestra.Text = "Clase";
            // 
            // radioOtra
            // 
            this.radioOtra.AutoSize = true;
            this.radioOtra.Location = new System.Drawing.Point(237, 18);
            this.radioOtra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioOtra.Name = "radioOtra";
            this.radioOtra.Size = new System.Drawing.Size(57, 21);
            this.radioOtra.TabIndex = 4;
            this.radioOtra.TabStop = true;
            this.radioOtra.Text = "Otra";
            this.radioOtra.UseVisualStyleBackColor = true;
            // 
            // radioSuperficie
            // 
            this.radioSuperficie.AutoSize = true;
            this.radioSuperficie.Location = new System.Drawing.Point(117, 18);
            this.radioSuperficie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSuperficie.Name = "radioSuperficie";
            this.radioSuperficie.Size = new System.Drawing.Size(92, 21);
            this.radioSuperficie.TabIndex = 3;
            this.radioSuperficie.TabStop = true;
            this.radioSuperficie.Text = "Superficie";
            this.radioSuperficie.UseVisualStyleBackColor = true;
            // 
            // radioAmbiente
            // 
            this.radioAmbiente.AutoSize = true;
            this.radioAmbiente.Location = new System.Drawing.Point(17, 38);
            this.radioAmbiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAmbiente.Name = "radioAmbiente";
            this.radioAmbiente.Size = new System.Drawing.Size(88, 21);
            this.radioAmbiente.TabIndex = 1;
            this.radioAmbiente.TabStop = true;
            this.radioAmbiente.Text = "Ambiente";
            this.radioAmbiente.UseVisualStyleBackColor = true;
            // 
            // radioOperario
            // 
            this.radioOperario.AutoSize = true;
            this.radioOperario.Location = new System.Drawing.Point(117, 39);
            this.radioOperario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioOperario.Name = "radioOperario";
            this.radioOperario.Size = new System.Drawing.Size(85, 21);
            this.radioOperario.TabIndex = 2;
            this.radioOperario.TabStop = true;
            this.radioOperario.Text = "Operario";
            this.radioOperario.UseVisualStyleBackColor = true;
            // 
            // radioProducto
            // 
            this.radioProducto.AutoSize = true;
            this.radioProducto.Location = new System.Drawing.Point(17, 18);
            this.radioProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioProducto.Name = "radioProducto";
            this.radioProducto.Size = new System.Drawing.Size(86, 21);
            this.radioProducto.TabIndex = 0;
            this.radioProducto.TabStop = true;
            this.radioProducto.Text = "Producto";
            this.radioProducto.UseVisualStyleBackColor = true;
            // 
            // panelInferiorControles
            // 
            this.panelInferiorControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panelInferiorControles.Controls.Add(this.btnGuardar);
            this.panelInferiorControles.Controls.Add(this.btnCancelar);
            this.panelInferiorControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferiorControles.Location = new System.Drawing.Point(0, 353);
            this.panelInferiorControles.Name = "panelInferiorControles";
            this.panelInferiorControles.Size = new System.Drawing.Size(411, 68);
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
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
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
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // NuevoLimite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(411, 421);
            this.Controls.Add(this.panelInferiorControles);
            this.Controls.Add(this.grupoClaseMuestra);
            this.Controls.Add(this.cboEnsayos);
            this.Controls.Add(this.GrupoMarginal);
            this.Controls.Add(this.GrupoRecuento);
            this.Controls.Add(this.GrupoBusqueda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReferencias);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(429, 468);
            this.MinimumSize = new System.Drawing.Size(429, 468);
            this.Name = "NuevoLimite";
            this.Text = "Nuevo Limite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevoLimiteForm_FormClosing);
            this.GrupoBusqueda.ResumeLayout(false);
            this.GrupoMarginal.ResumeLayout(false);
            this.GrupoMarginal.PerformLayout();
            this.GrupoRecuento.ResumeLayout(false);
            this.GrupoRecuento.PerformLayout();
            this.grupoClaseMuestra.ResumeLayout(false);
            this.grupoClaseMuestra.PerformLayout();
            this.panelInferiorControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEnsayos;
        private System.Windows.Forms.GroupBox grupoClaseMuestra;
        private System.Windows.Forms.RadioButton radioOtra;
        private System.Windows.Forms.RadioButton radioSuperficie;
        private System.Windows.Forms.RadioButton radioAmbiente;
        private System.Windows.Forms.RadioButton radioOperario;
        private System.Windows.Forms.RadioButton radioProducto;
        private System.Windows.Forms.Panel panelInferiorControles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
