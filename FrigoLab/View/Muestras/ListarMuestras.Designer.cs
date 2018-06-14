namespace FrigLab.View.Muestras {
    partial class ListarMuestras {
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
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        	this.grupoAcciones = new System.Windows.Forms.GroupBox();
        	this.btnEliminar = new System.Windows.Forms.Button();
        	this.btnEditar = new System.Windows.Forms.Button();
        	this.grupoFiltros = new System.Windows.Forms.GroupBox();
        	this.grupoBuscar = new System.Windows.Forms.GroupBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.btnQuitarFiltroNombre = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtBuscarNombre = new System.Windows.Forms.TextBox();
        	this.txtBuscarSector = new System.Windows.Forms.TextBox();
        	this.grupoTipo = new System.Windows.Forms.GroupBox();
        	this.RadioTodas = new System.Windows.Forms.RadioButton();
        	this.radioOtra = new System.Windows.Forms.RadioButton();
        	this.radioSuperficie = new System.Windows.Forms.RadioButton();
        	this.radioAmbiente = new System.Windows.Forms.RadioButton();
        	this.radioOperario = new System.Windows.Forms.RadioButton();
        	this.radioProducto = new System.Windows.Forms.RadioButton();
        	this.tablaDatos = new System.Windows.Forms.DataGridView();
        	this.grupoAcciones.SuspendLayout();
        	this.grupoFiltros.SuspendLayout();
        	this.grupoBuscar.SuspendLayout();
        	this.grupoTipo.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// grupoAcciones
        	// 
        	this.grupoAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.grupoAcciones.Controls.Add(this.btnEliminar);
        	this.grupoAcciones.Controls.Add(this.btnEditar);
        	this.grupoAcciones.Location = new System.Drawing.Point(524, 2);
        	this.grupoAcciones.Name = "grupoAcciones";
        	this.grupoAcciones.Size = new System.Drawing.Size(128, 156);
        	this.grupoAcciones.TabIndex = 8;
        	this.grupoAcciones.TabStop = false;
        	this.grupoAcciones.Text = "Acciones";
        	// 
        	// btnEliminar
        	// 
        	this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.btnEliminar.Enabled = false;
        	this.btnEliminar.Location = new System.Drawing.Point(19, 96);
        	this.btnEliminar.Name = "btnEliminar";
        	this.btnEliminar.Size = new System.Drawing.Size(88, 31);
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
        	this.btnEditar.Location = new System.Drawing.Point(19, 42);
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
        	this.grupoFiltros.Controls.Add(this.grupoTipo);
        	this.grupoFiltros.Location = new System.Drawing.Point(10, 2);
        	this.grupoFiltros.Name = "grupoFiltros";
        	this.grupoFiltros.Size = new System.Drawing.Size(508, 156);
        	this.grupoFiltros.TabIndex = 7;
        	this.grupoFiltros.TabStop = false;
        	this.grupoFiltros.Text = "Filtros";
        	// 
        	// grupoBuscar
        	// 
        	this.grupoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.grupoBuscar.Controls.Add(this.label4);
        	this.grupoBuscar.Controls.Add(this.btnQuitarFiltroNombre);
        	this.grupoBuscar.Controls.Add(this.label1);
        	this.grupoBuscar.Controls.Add(this.txtBuscarNombre);
        	this.grupoBuscar.Controls.Add(this.txtBuscarSector);
        	this.grupoBuscar.Location = new System.Drawing.Point(110, 18);
        	this.grupoBuscar.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoBuscar.Name = "grupoBuscar";
        	this.grupoBuscar.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoBuscar.Size = new System.Drawing.Size(393, 133);
        	this.grupoBuscar.TabIndex = 1;
        	this.grupoBuscar.TabStop = false;
        	this.grupoBuscar.Text = "Buscar por:";
        	// 
        	// label4
        	// 
        	this.label4.Location = new System.Drawing.Point(14, 15);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(100, 16);
        	this.label4.TabIndex = 2;
        	this.label4.Text = "Nombre";
        	// 
        	// btnQuitarFiltroNombre
        	// 
        	this.btnQuitarFiltroNombre.Location = new System.Drawing.Point(290, 98);
        	this.btnQuitarFiltroNombre.Name = "btnQuitarFiltroNombre";
        	this.btnQuitarFiltroNombre.Size = new System.Drawing.Size(88, 31);
        	this.btnQuitarFiltroNombre.TabIndex = 1;
        	this.btnQuitarFiltroNombre.Text = "Borrar";
        	this.btnQuitarFiltroNombre.UseVisualStyleBackColor = true;
        	this.btnQuitarFiltroNombre.Click += new System.EventHandler(this.BorrarFiltros);
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(14, 67);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(100, 16);
        	this.label1.TabIndex = 2;
        	this.label1.Text = "Sector";
        	// 
        	// txtBuscarNombre
        	// 
        	this.txtBuscarNombre.Location = new System.Drawing.Point(14, 33);
        	this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(2);
        	this.txtBuscarNombre.Name = "txtBuscarNombre";
        	this.txtBuscarNombre.Size = new System.Drawing.Size(176, 20);
        	this.txtBuscarNombre.TabIndex = 0;
        	// 
        	// txtBuscarSector
        	// 
        	this.txtBuscarSector.Location = new System.Drawing.Point(14, 84);
        	this.txtBuscarSector.Margin = new System.Windows.Forms.Padding(2);
        	this.txtBuscarSector.Name = "txtBuscarSector";
        	this.txtBuscarSector.Size = new System.Drawing.Size(176, 20);
        	this.txtBuscarSector.TabIndex = 0;
        	// 
        	// grupoTipo
        	// 
        	this.grupoTipo.Controls.Add(this.RadioTodas);
        	this.grupoTipo.Controls.Add(this.radioOtra);
        	this.grupoTipo.Controls.Add(this.radioSuperficie);
        	this.grupoTipo.Controls.Add(this.radioAmbiente);
        	this.grupoTipo.Controls.Add(this.radioOperario);
        	this.grupoTipo.Controls.Add(this.radioProducto);
        	this.grupoTipo.Location = new System.Drawing.Point(5, 18);
        	this.grupoTipo.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoTipo.Name = "grupoTipo";
        	this.grupoTipo.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoTipo.Size = new System.Drawing.Size(101, 133);
        	this.grupoTipo.TabIndex = 0;
        	this.grupoTipo.TabStop = false;
        	this.grupoTipo.Text = "Tipo";
        	// 
        	// RadioTodas
        	// 
        	this.RadioTodas.AutoSize = true;
        	this.RadioTodas.Location = new System.Drawing.Point(13, 109);
        	this.RadioTodas.Margin = new System.Windows.Forms.Padding(2);
        	this.RadioTodas.Name = "RadioTodas";
        	this.RadioTodas.Size = new System.Drawing.Size(55, 17);
        	this.RadioTodas.TabIndex = 5;
        	this.RadioTodas.TabStop = true;
        	this.RadioTodas.Text = "Todas";
        	this.RadioTodas.UseVisualStyleBackColor = true;
        	// 
        	// radioOtra
        	// 
        	this.radioOtra.AutoSize = true;
        	this.radioOtra.Location = new System.Drawing.Point(13, 92);
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
        	this.radioSuperficie.Location = new System.Drawing.Point(13, 75);
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
        	this.radioAmbiente.Location = new System.Drawing.Point(13, 41);
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
        	this.radioOperario.Location = new System.Drawing.Point(13, 58);
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
        	this.radioProducto.Location = new System.Drawing.Point(13, 24);
        	this.radioProducto.Margin = new System.Windows.Forms.Padding(2);
        	this.radioProducto.Name = "radioProducto";
        	this.radioProducto.Size = new System.Drawing.Size(68, 17);
        	this.radioProducto.TabIndex = 0;
        	this.radioProducto.TabStop = true;
        	this.radioProducto.Text = "Producto";
        	this.radioProducto.UseVisualStyleBackColor = true;
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
        	this.tablaDatos.Location = new System.Drawing.Point(10, 164);
        	this.tablaDatos.MultiSelect = false;
        	this.tablaDatos.Name = "tablaDatos";
        	this.tablaDatos.ReadOnly = true;
        	this.tablaDatos.RowHeadersVisible = false;
        	this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        	this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.tablaDatos.Size = new System.Drawing.Size(642, 275);
        	this.tablaDatos.TabIndex = 6;
        	this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
        	this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
        	// 
        	// ListarMuestras
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(663, 457);
        	this.Controls.Add(this.grupoAcciones);
        	this.Controls.Add(this.grupoFiltros);
        	this.Controls.Add(this.tablaDatos);
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.MaximizeBox = false;
        	this.MinimumSize = new System.Drawing.Size(678, 491);
        	this.Name = "ListarMuestras";
        	this.Text = "Listado de Muestras";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarMuestrasFormFormClosing);
        	this.grupoAcciones.ResumeLayout(false);
        	this.grupoFiltros.ResumeLayout(false);
        	this.grupoBuscar.ResumeLayout(false);
        	this.grupoBuscar.PerformLayout();
        	this.grupoTipo.ResumeLayout(false);
        	this.grupoTipo.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoAcciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grupoFiltros;
        private System.Windows.Forms.GroupBox grupoBuscar;
        private System.Windows.Forms.Button btnQuitarFiltroNombre;
        private System.Windows.Forms.GroupBox grupoTipo;
        private System.Windows.Forms.RadioButton RadioTodas;
        private System.Windows.Forms.RadioButton radioOtra;
        private System.Windows.Forms.RadioButton radioSuperficie;
        private System.Windows.Forms.RadioButton radioAmbiente;
        private System.Windows.Forms.RadioButton radioOperario;
        private System.Windows.Forms.RadioButton radioProducto;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarSector;
    }
}