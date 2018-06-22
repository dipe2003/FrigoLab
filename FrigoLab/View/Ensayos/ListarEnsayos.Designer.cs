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
		private System.Windows.Forms.GroupBox grupoFiltros;
		private System.Windows.Forms.GroupBox grupoBuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBuscarMetodo;
		private System.Windows.Forms.TextBox txtBuscarNombre;
		
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grupoAcciones = new System.Windows.Forms.GroupBox();
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
            this.txtBuscarMetodo = new System.Windows.Forms.TextBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrarFiltros = new System.Windows.Forms.Button();
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
            this.grupoAcciones.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoAcciones.Location = new System.Drawing.Point(601, 6);
            this.grupoAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Size = new System.Drawing.Size(171, 155);
            this.grupoAcciones.TabIndex = 8;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Acciones";
            // 
            // grupoFiltros
            // 
            this.grupoFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoFiltros.Controls.Add(this.grupoBuscar);
            this.grupoFiltros.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoFiltros.Location = new System.Drawing.Point(19, 6);
            this.grupoFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Name = "grupoFiltros";
            this.grupoFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Size = new System.Drawing.Size(579, 155);
            this.grupoFiltros.TabIndex = 7;
            this.grupoFiltros.TabStop = false;
            this.grupoFiltros.Text = "Filtros";
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoBuscar.Controls.Add(this.btnBorrarFiltros);
            this.grupoBuscar.Controls.Add(this.grupoClaseMuestra);
            this.grupoBuscar.Controls.Add(this.label2);
            this.grupoBuscar.Controls.Add(this.label1);
            this.grupoBuscar.Controls.Add(this.txtBuscarMetodo);
            this.grupoBuscar.Controls.Add(this.txtBuscarNombre);
            this.grupoBuscar.Location = new System.Drawing.Point(7, 22);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Size = new System.Drawing.Size(565, 127);
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
            this.grupoClaseMuestra.Location = new System.Drawing.Point(193, 12);
            this.grupoClaseMuestra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoClaseMuestra.Name = "grupoClaseMuestra";
            this.grupoClaseMuestra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoClaseMuestra.Size = new System.Drawing.Size(215, 108);
            this.grupoClaseMuestra.TabIndex = 28;
            this.grupoClaseMuestra.TabStop = false;
            this.grupoClaseMuestra.Text = "Muestra";
            // 
            // radioTodas
            // 
            this.radioTodas.AutoSize = true;
            this.radioTodas.Location = new System.Drawing.Point(108, 70);
            this.radioTodas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTodas.Name = "radioTodas";
            this.radioTodas.Size = new System.Drawing.Size(66, 21);
            this.radioTodas.TabIndex = 5;
            this.radioTodas.TabStop = true;
            this.radioTodas.Text = "Todas";
            this.radioTodas.UseVisualStyleBackColor = true;
            // 
            // radioOtra
            // 
            this.radioOtra.AutoSize = true;
            this.radioOtra.Location = new System.Drawing.Point(108, 46);
            this.radioOtra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioOtra.Name = "radioOtra";
            this.radioOtra.Size = new System.Drawing.Size(58, 21);
            this.radioOtra.TabIndex = 4;
            this.radioOtra.TabStop = true;
            this.radioOtra.Text = "Otra";
            this.radioOtra.UseVisualStyleBackColor = true;
            // 
            // radioSuperficie
            // 
            this.radioSuperficie.AutoSize = true;
            this.radioSuperficie.Location = new System.Drawing.Point(108, 20);
            this.radioSuperficie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSuperficie.Name = "radioSuperficie";
            this.radioSuperficie.Size = new System.Drawing.Size(90, 21);
            this.radioSuperficie.TabIndex = 3;
            this.radioSuperficie.TabStop = true;
            this.radioSuperficie.Text = "Superficie";
            this.radioSuperficie.UseVisualStyleBackColor = true;
            // 
            // radioAmbiente
            // 
            this.radioAmbiente.AutoSize = true;
            this.radioAmbiente.Location = new System.Drawing.Point(17, 46);
            this.radioAmbiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAmbiente.Name = "radioAmbiente";
            this.radioAmbiente.Size = new System.Drawing.Size(92, 21);
            this.radioAmbiente.TabIndex = 1;
            this.radioAmbiente.TabStop = true;
            this.radioAmbiente.Text = "Ambiente";
            this.radioAmbiente.UseVisualStyleBackColor = true;
            // 
            // radioOperario
            // 
            this.radioOperario.AutoSize = true;
            this.radioOperario.Location = new System.Drawing.Point(17, 70);
            this.radioOperario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioOperario.Name = "radioOperario";
            this.radioOperario.Size = new System.Drawing.Size(86, 21);
            this.radioOperario.TabIndex = 2;
            this.radioOperario.TabStop = true;
            this.radioOperario.Text = "Operario";
            this.radioOperario.UseVisualStyleBackColor = true;
            // 
            // radioProducto
            // 
            this.radioProducto.AutoSize = true;
            this.radioProducto.Location = new System.Drawing.Point(17, 20);
            this.radioProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioProducto.Name = "radioProducto";
            this.radioProducto.Size = new System.Drawing.Size(89, 21);
            this.radioProducto.TabIndex = 0;
            this.radioProducto.TabStop = true;
            this.radioProducto.Text = "Producto";
            this.radioProducto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metodo";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtBuscarMetodo
            // 
            this.txtBuscarMetodo.Location = new System.Drawing.Point(13, 98);
            this.txtBuscarMetodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarMetodo.Name = "txtBuscarMetodo";
            this.txtBuscarMetodo.Size = new System.Drawing.Size(175, 22);
            this.txtBuscarMetodo.TabIndex = 0;
            this.txtBuscarMetodo.TextChanged += new System.EventHandler(this.TxtBuscarMetodo_TextChanged);
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(13, 38);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(175, 22);
            this.txtBuscarNombre.TabIndex = 0;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.TxtBuscarNombre_TextChanged);
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            this.tablaDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tablaDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.tablaDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaDatos.EnableHeadersVisualStyles = false;
            this.tablaDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tablaDatos.Location = new System.Drawing.Point(19, 169);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaDatos.MultiSelect = false;
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowHeadersVisible = false;
            this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(753, 291);
            this.tablaDatos.TabIndex = 9;
            this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
            this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnEliminar.Location = new System.Drawing.Point(25, 93);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 38);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnEditar.Location = new System.Drawing.Point(25, 34);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 38);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnBorrarFiltros
            // 
            this.btnBorrarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.btnBorrarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.btnBorrarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarFiltros.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnBorrarFiltros.Location = new System.Drawing.Point(428, 72);
            this.btnBorrarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarFiltros.Name = "btnBorrarFiltros";
            this.btnBorrarFiltros.Size = new System.Drawing.Size(117, 38);
            this.btnBorrarFiltros.TabIndex = 29;
            this.btnBorrarFiltros.Text = "Borrar";
            this.btnBorrarFiltros.UseVisualStyleBackColor = false;
            this.btnBorrarFiltros.Click += new System.EventHandler(this.BtnQuitarFiltroBusquedasClick);
            // 
            // ListarEnsayos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(791, 482);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.grupoFiltros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 513);
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
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrarFiltros;
    }
}
