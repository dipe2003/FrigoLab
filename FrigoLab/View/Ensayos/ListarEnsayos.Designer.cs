/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 24/03/2018
 * Hora: 10:40 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FrigLab.View.Ensayos
{
	partial class ListarEnsayos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox grupoAcciones;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.GroupBox grupoFiltros;
		private System.Windows.Forms.GroupBox grupoBuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnQuitarFiltroNombre;
		private System.Windows.Forms.TextBox txtBuscarMetodo;
		private System.Windows.Forms.TextBox txtBuscarNombre;
		private System.Windows.Forms.DataGridView tablaDatos;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.grupoAcciones = new System.Windows.Forms.GroupBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.grupoFiltros = new System.Windows.Forms.GroupBox();
			this.grupoBuscar = new System.Windows.Forms.GroupBox();
			this.grupoClaseMuestra = new System.Windows.Forms.GroupBox();
			this.radioTodas = new System.Windows.Forms.RadioButton();
			this.radioOtra = new System.Windows.Forms.RadioButton();
			this.radioSuperficie = new System.Windows.Forms.RadioButton();
			this.radioAmbiente = new System.Windows.Forms.RadioButton();
			this.radioOperario = new System.Windows.Forms.RadioButton();
			this.radioProducto = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnQuitarFiltroNombre = new System.Windows.Forms.Button();
			this.txtBuscarMetodo = new System.Windows.Forms.TextBox();
			this.txtBuscarNombre = new System.Windows.Forms.TextBox();
			this.tablaDatos = new System.Windows.Forms.DataGridView();
			this.grupoAcciones.SuspendLayout();
			this.grupoFiltros.SuspendLayout();
			this.grupoBuscar.SuspendLayout();
			this.grupoClaseMuestra.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// grupoAcciones
			// 
			this.grupoAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.grupoAcciones.Controls.Add(this.btnEliminar);
			this.grupoAcciones.Controls.Add(this.btnEditar);
			this.grupoAcciones.Location = new System.Drawing.Point(451, 5);
			this.grupoAcciones.Name = "grupoAcciones";
			this.grupoAcciones.Size = new System.Drawing.Size(128, 126);
			this.grupoAcciones.TabIndex = 8;
			this.grupoAcciones.TabStop = false;
			this.grupoAcciones.Text = "Acciones";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(19, 75);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(88, 36);
			this.btnEliminar.TabIndex = 1;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditar.Enabled = false;
			this.btnEditar.Location = new System.Drawing.Point(19, 33);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(88, 32);
			this.btnEditar.TabIndex = 0;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
			// 
			// grupoFiltros
			// 
			this.grupoFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.grupoFiltros.Controls.Add(this.grupoBuscar);
			this.grupoFiltros.Location = new System.Drawing.Point(14, 5);
			this.grupoFiltros.Name = "grupoFiltros";
			this.grupoFiltros.Size = new System.Drawing.Size(434, 126);
			this.grupoFiltros.TabIndex = 7;
			this.grupoFiltros.TabStop = false;
			this.grupoFiltros.Text = "Filtros";
			// 
			// grupoBuscar
			// 
			this.grupoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.grupoBuscar.Controls.Add(this.grupoClaseMuestra);
			this.grupoBuscar.Controls.Add(this.label2);
			this.grupoBuscar.Controls.Add(this.label1);
			this.grupoBuscar.Controls.Add(this.btnQuitarFiltroNombre);
			this.grupoBuscar.Controls.Add(this.txtBuscarMetodo);
			this.grupoBuscar.Controls.Add(this.txtBuscarNombre);
			this.grupoBuscar.Location = new System.Drawing.Point(5, 18);
			this.grupoBuscar.Margin = new System.Windows.Forms.Padding(2);
			this.grupoBuscar.Name = "grupoBuscar";
			this.grupoBuscar.Padding = new System.Windows.Forms.Padding(2);
			this.grupoBuscar.Size = new System.Drawing.Size(424, 103);
			this.grupoBuscar.TabIndex = 1;
			this.grupoBuscar.TabStop = false;
			this.grupoBuscar.Text = "Busqueda";
			// 
			// grupoClaseMuestra
			// 
			this.grupoClaseMuestra.Controls.Add(this.radioTodas);
			this.grupoClaseMuestra.Controls.Add(this.radioOtra);
			this.grupoClaseMuestra.Controls.Add(this.radioSuperficie);
			this.grupoClaseMuestra.Controls.Add(this.radioAmbiente);
			this.grupoClaseMuestra.Controls.Add(this.radioOperario);
			this.grupoClaseMuestra.Controls.Add(this.radioProducto);
			this.grupoClaseMuestra.Location = new System.Drawing.Point(145, 10);
			this.grupoClaseMuestra.Margin = new System.Windows.Forms.Padding(2);
			this.grupoClaseMuestra.Name = "grupoClaseMuestra";
			this.grupoClaseMuestra.Padding = new System.Windows.Forms.Padding(2);
			this.grupoClaseMuestra.Size = new System.Drawing.Size(161, 88);
			this.grupoClaseMuestra.TabIndex = 28;
			this.grupoClaseMuestra.TabStop = false;
			this.grupoClaseMuestra.Text = "Muestra";
			// 
			// radioTodas
			// 
			this.radioTodas.AutoSize = true;
			this.radioTodas.Location = new System.Drawing.Point(81, 57);
			this.radioTodas.Margin = new System.Windows.Forms.Padding(2);
			this.radioTodas.Name = "radioTodas";
			this.radioTodas.Size = new System.Drawing.Size(55, 17);
			this.radioTodas.TabIndex = 5;
			this.radioTodas.TabStop = true;
			this.radioTodas.Text = "Todas";
			this.radioTodas.UseVisualStyleBackColor = true;
			// 
			// radioOtra
			// 
			this.radioOtra.AutoSize = true;
			this.radioOtra.Location = new System.Drawing.Point(81, 37);
			this.radioOtra.Margin = new System.Windows.Forms.Padding(2);
			this.radioOtra.Name = "radioOtra";
			this.radioOtra.Size = new System.Drawing.Size(45, 17);
			this.radioOtra.TabIndex = 4;
			this.radioOtra.TabStop = true;
			this.radioOtra.Text = "Otra";
			this.radioOtra.UseVisualStyleBackColor = true;
			// 
			// radioSuperficie
			// 
			this.radioSuperficie.AutoSize = true;
			this.radioSuperficie.Location = new System.Drawing.Point(81, 16);
			this.radioSuperficie.Margin = new System.Windows.Forms.Padding(2);
			this.radioSuperficie.Name = "radioSuperficie";
			this.radioSuperficie.Size = new System.Drawing.Size(72, 17);
			this.radioSuperficie.TabIndex = 3;
			this.radioSuperficie.TabStop = true;
			this.radioSuperficie.Text = "Superficie";
			this.radioSuperficie.UseVisualStyleBackColor = true;
			// 
			// radioAmbiente
			// 
			this.radioAmbiente.AutoSize = true;
			this.radioAmbiente.Location = new System.Drawing.Point(13, 37);
			this.radioAmbiente.Margin = new System.Windows.Forms.Padding(2);
			this.radioAmbiente.Name = "radioAmbiente";
			this.radioAmbiente.Size = new System.Drawing.Size(69, 17);
			this.radioAmbiente.TabIndex = 1;
			this.radioAmbiente.TabStop = true;
			this.radioAmbiente.Text = "Ambiente";
			this.radioAmbiente.UseVisualStyleBackColor = true;
			// 
			// radioOperario
			// 
			this.radioOperario.AutoSize = true;
			this.radioOperario.Location = new System.Drawing.Point(13, 57);
			this.radioOperario.Margin = new System.Windows.Forms.Padding(2);
			this.radioOperario.Name = "radioOperario";
			this.radioOperario.Size = new System.Drawing.Size(65, 17);
			this.radioOperario.TabIndex = 2;
			this.radioOperario.TabStop = true;
			this.radioOperario.Text = "Operario";
			this.radioOperario.UseVisualStyleBackColor = true;
			// 
			// radioProducto
			// 
			this.radioProducto.AutoSize = true;
			this.radioProducto.Location = new System.Drawing.Point(13, 16);
			this.radioProducto.Margin = new System.Windows.Forms.Padding(2);
			this.radioProducto.Name = "radioProducto";
			this.radioProducto.Size = new System.Drawing.Size(68, 17);
			this.radioProducto.TabIndex = 0;
			this.radioProducto.TabStop = true;
			this.radioProducto.Text = "Producto";
			this.radioProducto.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "Metodo";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 14);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre";
			// 
			// btnQuitarFiltroNombre
			// 
			this.btnQuitarFiltroNombre.Location = new System.Drawing.Point(321, 67);
			this.btnQuitarFiltroNombre.Name = "btnQuitarFiltroNombre";
			this.btnQuitarFiltroNombre.Size = new System.Drawing.Size(88, 31);
			this.btnQuitarFiltroNombre.TabIndex = 1;
			this.btnQuitarFiltroNombre.Text = "Borrar";
			this.btnQuitarFiltroNombre.UseVisualStyleBackColor = true;
			this.btnQuitarFiltroNombre.Click += new System.EventHandler(this.BtnQuitarFiltroBusquedasClick);
			// 
			// txtBuscarMetodo
			// 
			this.txtBuscarMetodo.Location = new System.Drawing.Point(10, 80);
			this.txtBuscarMetodo.Margin = new System.Windows.Forms.Padding(2);
			this.txtBuscarMetodo.Name = "txtBuscarMetodo";
			this.txtBuscarMetodo.Size = new System.Drawing.Size(132, 20);
			this.txtBuscarMetodo.TabIndex = 0;
			this.txtBuscarMetodo.TextChanged += new System.EventHandler(this.TxtBuscarMetodo_TextChanged);
			// 
			// txtBuscarNombre
			// 
			this.txtBuscarNombre.Location = new System.Drawing.Point(10, 31);
			this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(2);
			this.txtBuscarNombre.Name = "txtBuscarNombre";
			this.txtBuscarNombre.Size = new System.Drawing.Size(132, 20);
			this.txtBuscarNombre.TabIndex = 0;
			this.txtBuscarNombre.TextChanged += new System.EventHandler(this.TxtBuscarNombre_TextChanged);
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
			this.tablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.tablaDatos.BackgroundColor = System.Drawing.SystemColors.Control;
			this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.tablaDatos.DefaultCellStyle = dataGridViewCellStyle1;
			this.tablaDatos.Location = new System.Drawing.Point(14, 137);
			this.tablaDatos.MultiSelect = false;
			this.tablaDatos.Name = "tablaDatos";
			this.tablaDatos.ReadOnly = true;
			this.tablaDatos.RowHeadersVisible = false;
			this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tablaDatos.Size = new System.Drawing.Size(564, 240);
			this.tablaDatos.TabIndex = 6;
			this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
			this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
			// 
			// ListarEnsayos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 392);
			this.Controls.Add(this.grupoAcciones);
			this.Controls.Add(this.grupoFiltros);
			this.Controls.Add(this.tablaDatos);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(588, 426);
			this.Name = "ListarEnsayos";
			this.Text = "Listado de Ensayos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarEnsayosFormFormClosing);
			this.grupoAcciones.ResumeLayout(false);
			this.grupoFiltros.ResumeLayout(false);
			this.grupoBuscar.ResumeLayout(false);
			this.grupoBuscar.PerformLayout();
			this.grupoClaseMuestra.ResumeLayout(false);
			this.grupoClaseMuestra.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
			this.ResumeLayout(false);

		}

        private System.Windows.Forms.GroupBox grupoClaseMuestra;
        private System.Windows.Forms.RadioButton radioOtra;
        private System.Windows.Forms.RadioButton radioSuperficie;
        private System.Windows.Forms.RadioButton radioAmbiente;
        private System.Windows.Forms.RadioButton radioOperario;
        private System.Windows.Forms.RadioButton radioProducto;
        private System.Windows.Forms.RadioButton radioTodas;
    }
}
