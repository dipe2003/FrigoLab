/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 24/03/2018
 * Hora: 11:24 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FrigLab.View.Requisitos
{
	partial class NuevoRequisito
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button btnDefinirLimite;
		
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.btnDefinirLimite = new System.Windows.Forms.Button();
			this.tablaDatos = new System.Windows.Forms.DataGridView();
			this.btnQuitarLimite = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.Location = new System.Drawing.Point(209, 317);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(105, 29);
			this.btnCancelar.TabIndex = 18;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardar.Location = new System.Drawing.Point(320, 317);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(105, 29);
			this.btnGuardar.TabIndex = 17;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(29, 51);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(227, 20);
			this.txtNombre.TabIndex = 16;
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(29, 25);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(100, 23);
			this.lblNombre.TabIndex = 14;
			this.lblNombre.Text = "Nombre";
			// 
			// btnDefinirLimite
			// 
			this.btnDefinirLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDefinirLimite.Location = new System.Drawing.Point(332, 262);
			this.btnDefinirLimite.Name = "btnDefinirLimite";
			this.btnDefinirLimite.Size = new System.Drawing.Size(79, 29);
			this.btnDefinirLimite.TabIndex = 18;
			this.btnDefinirLimite.Text = "Definir Limite";
			this.btnDefinirLimite.UseVisualStyleBackColor = true;
			this.btnDefinirLimite.Click += new System.EventHandler(this.BntDefinirLimiteClick);
			// 
			// tablaDatos
			// 
			this.tablaDatos.AllowUserToAddRows = false;
			this.tablaDatos.AllowUserToDeleteRows = false;
			this.tablaDatos.AllowUserToOrderColumns = true;
			this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.tablaDatos.BackgroundColor = System.Drawing.SystemColors.Control;
			this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tablaDatos.Location = new System.Drawing.Point(28, 76);
			this.tablaDatos.MinimumSize = new System.Drawing.Size(390, 179);
			this.tablaDatos.MultiSelect = false;
			this.tablaDatos.Name = "tablaDatos";
			this.tablaDatos.ReadOnly = true;
			this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tablaDatos.Size = new System.Drawing.Size(398, 179);
			this.tablaDatos.TabIndex = 28;
			this.tablaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDatos_CellClick);
			// 
			// btnQuitarLimite
			// 
			this.btnQuitarLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnQuitarLimite.Location = new System.Drawing.Point(227, 262);
			this.btnQuitarLimite.Name = "btnQuitarLimite";
			this.btnQuitarLimite.Size = new System.Drawing.Size(79, 29);
			this.btnQuitarLimite.TabIndex = 18;
			this.btnQuitarLimite.Text = "Quitar Limite";
			this.btnQuitarLimite.UseVisualStyleBackColor = true;
			this.btnQuitarLimite.Click += new System.EventHandler(this.BntQuitarLimiteClick);
			// 
			// NuevoRequisito
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 375);
			this.Controls.Add(this.tablaDatos);
			this.Controls.Add(this.btnQuitarLimite);
			this.Controls.Add(this.btnDefinirLimite);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(469, 413);
			this.Name = "NuevoRequisito";
			this.Text = "Registrar Requisito";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevoRequisitoFormFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button btnQuitarLimite;
    }
}
