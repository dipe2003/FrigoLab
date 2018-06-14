/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 16/05/2018
 * Hora: 11:41 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FrigLab.View.Resultados
{
	partial class SepararPool
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cboLaboratorios;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAbrirPool;
		
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
			this.label11 = new System.Windows.Forms.Label();
			this.cboLaboratorios = new System.Windows.Forms.ComboBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAbrirPool = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(11, 21);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 13);
			this.label11.TabIndex = 36;
			this.label11.Text = "Laboratorio";
			// 
			// cboLaboratorios
			// 
			this.cboLaboratorios.FormattingEnabled = true;
			this.cboLaboratorios.Location = new System.Drawing.Point(11, 36);
			this.cboLaboratorios.Margin = new System.Windows.Forms.Padding(2);
			this.cboLaboratorios.Name = "cboLaboratorios";
			this.cboLaboratorios.Size = new System.Drawing.Size(262, 21);
			this.cboLaboratorios.TabIndex = 35;
			this.cboLaboratorios.SelectedValueChanged += new System.EventHandler(this.CboLaboratorios_SelectedValueChanged);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.Location = new System.Drawing.Point(49, 92);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(105, 29);
			this.btnCancelar.TabIndex = 42;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAbrirPool
			// 
			this.btnAbrirPool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAbrirPool.Location = new System.Drawing.Point(167, 92);
			this.btnAbrirPool.Name = "btnAbrirPool";
			this.btnAbrirPool.Size = new System.Drawing.Size(105, 29);
			this.btnAbrirPool.TabIndex = 41;
			this.btnAbrirPool.Text = "Separar";
			this.btnAbrirPool.UseVisualStyleBackColor = true;
			this.btnAbrirPool.Click += new System.EventHandler(this.BtnAbrirPoolClick);
			// 
			// SepararPool
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 133);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAbrirPool);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cboLaboratorios);
			this.Name = "SepararPool";
			this.Text = "Separar Pool";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
