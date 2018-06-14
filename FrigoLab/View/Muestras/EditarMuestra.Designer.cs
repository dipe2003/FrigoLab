/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 23/03/2018
 * Hora: 01:15 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FrigLab.View.Muestras
{
	partial class EditarMuestra
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboTipos;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
		
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cboTipos = new System.Windows.Forms.ComboBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chkListAreas = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(29, 244);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(105, 29);
			this.btnCancelar.TabIndex = 22;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(157, 244);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(105, 29);
			this.btnGuardar.TabIndex = 21;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 172);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Tipo de Muestra";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 72);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Area";
			// 
			// cboTipos
			// 
			this.cboTipos.FormattingEnabled = true;
			this.cboTipos.Location = new System.Drawing.Point(29, 188);
			this.cboTipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cboTipos.Name = "cboTipos";
			this.cboTipos.Size = new System.Drawing.Size(235, 21);
			this.cboTipos.TabIndex = 17;
			this.cboTipos.SelectedIndexChanged += new System.EventHandler(this.cboTipos_SelectedIndexChanged);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(29, 36);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(235, 20);
			this.txtNombre.TabIndex = 16;
			this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Nombre";
			// 
			// chkListAreas
			// 
			this.chkListAreas.FormattingEnabled = true;
			this.chkListAreas.Location = new System.Drawing.Point(28, 89);
			this.chkListAreas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkListAreas.Name = "chkListAreas";
			this.chkListAreas.Size = new System.Drawing.Size(235, 64);
			this.chkListAreas.TabIndex = 24;
			this.chkListAreas.SelectedIndexChanged += new System.EventHandler(this.ChkListBox_SelectedIndexChanged);
			// 
			// EditarMuestra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 302);
			this.Controls.Add(this.chkListAreas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboTipos);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(312, 340);
			this.MinimumSize = new System.Drawing.Size(312, 340);
			this.Name = "EditarMuestra";
			this.Text = "Editar Muestra";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarMuestraForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        private System.Windows.Forms.CheckedListBox chkListAreas;
    }
}
