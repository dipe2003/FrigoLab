namespace FrigLab.View.Ensayos {
    partial class ListarLaboratorios {
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
        	this.btnQuitarFiltroNombre = new System.Windows.Forms.Button();
        	this.txtBuscarNombre = new System.Windows.Forms.TextBox();
        	this.grupoTipo = new System.Windows.Forms.GroupBox();
        	this.radioExternos = new System.Windows.Forms.RadioButton();
        	this.radioTodos = new System.Windows.Forms.RadioButton();
        	this.radioSoloInternos = new System.Windows.Forms.RadioButton();
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
        	this.grupoAcciones.Location = new System.Drawing.Point(428, 11);
        	this.grupoAcciones.Name = "grupoAcciones";
        	this.grupoAcciones.Size = new System.Drawing.Size(128, 116);
        	this.grupoAcciones.TabIndex = 5;
        	this.grupoAcciones.TabStop = false;
        	this.grupoAcciones.Text = "Acciones";
        	// 
        	// btnEliminar
        	// 
        	this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.btnEliminar.Enabled = false;
        	this.btnEliminar.Location = new System.Drawing.Point(19, 71);
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
        	this.btnEditar.Location = new System.Drawing.Point(19, 28);
        	this.btnEditar.Name = "btnEditar";
        	this.btnEditar.Size = new System.Drawing.Size(88, 31);
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
        	this.grupoFiltros.Location = new System.Drawing.Point(13, 11);
        	this.grupoFiltros.Name = "grupoFiltros";
        	this.grupoFiltros.Size = new System.Drawing.Size(412, 116);
        	this.grupoFiltros.TabIndex = 4;
        	this.grupoFiltros.TabStop = false;
        	this.grupoFiltros.Text = "Filtros";
        	// 
        	// grupoBuscar
        	// 
        	this.grupoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.grupoBuscar.Controls.Add(this.btnQuitarFiltroNombre);
        	this.grupoBuscar.Controls.Add(this.txtBuscarNombre);
        	this.grupoBuscar.Location = new System.Drawing.Point(223, 18);
        	this.grupoBuscar.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoBuscar.Name = "grupoBuscar";
        	this.grupoBuscar.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoBuscar.Size = new System.Drawing.Size(184, 93);
        	this.grupoBuscar.TabIndex = 1;
        	this.grupoBuscar.TabStop = false;
        	this.grupoBuscar.Text = "Buscar por Nombre";
        	// 
        	// btnQuitarFiltroNombre
        	// 
        	this.btnQuitarFiltroNombre.Location = new System.Drawing.Point(83, 53);
        	this.btnQuitarFiltroNombre.Name = "btnQuitarFiltroNombre";
        	this.btnQuitarFiltroNombre.Size = new System.Drawing.Size(88, 31);
        	this.btnQuitarFiltroNombre.TabIndex = 1;
        	this.btnQuitarFiltroNombre.Text = "Borrar";
        	this.btnQuitarFiltroNombre.UseVisualStyleBackColor = true;
        	this.btnQuitarFiltroNombre.Click += new System.EventHandler(this.BtnQuitarFiltroNombreClick);
        	// 
        	// txtBuscarNombre
        	// 
        	this.txtBuscarNombre.Location = new System.Drawing.Point(10, 27);
        	this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(2);
        	this.txtBuscarNombre.Name = "txtBuscarNombre";
        	this.txtBuscarNombre.Size = new System.Drawing.Size(161, 20);
        	this.txtBuscarNombre.TabIndex = 0;
        	this.txtBuscarNombre.TextChanged += new System.EventHandler(this.TxtBuscarNombre_TextChanged);
        	// 
        	// grupoTipo
        	// 
        	this.grupoTipo.Controls.Add(this.radioExternos);
        	this.grupoTipo.Controls.Add(this.radioTodos);
        	this.grupoTipo.Controls.Add(this.radioSoloInternos);
        	this.grupoTipo.Location = new System.Drawing.Point(5, 18);
        	this.grupoTipo.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoTipo.Name = "grupoTipo";
        	this.grupoTipo.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoTipo.Size = new System.Drawing.Size(214, 93);
        	this.grupoTipo.TabIndex = 0;
        	this.grupoTipo.TabStop = false;
        	this.grupoTipo.Text = "Tipo de Laboratorio";
        	// 
        	// radioExternos
        	// 
        	this.radioExternos.AutoSize = true;
        	this.radioExternos.Location = new System.Drawing.Point(16, 46);
        	this.radioExternos.Margin = new System.Windows.Forms.Padding(2);
        	this.radioExternos.Name = "radioExternos";
        	this.radioExternos.Size = new System.Drawing.Size(90, 17);
        	this.radioExternos.TabIndex = 1;
        	this.radioExternos.TabStop = true;
        	this.radioExternos.Text = "Solo Externos";
        	this.radioExternos.UseVisualStyleBackColor = true;
        	// 
        	// radioTodos
        	// 
        	this.radioTodos.AutoSize = true;
        	this.radioTodos.Location = new System.Drawing.Point(16, 67);
        	this.radioTodos.Margin = new System.Windows.Forms.Padding(2);
        	this.radioTodos.Name = "radioTodos";
        	this.radioTodos.Size = new System.Drawing.Size(132, 17);
        	this.radioTodos.TabIndex = 2;
        	this.radioTodos.TabStop = true;
        	this.radioTodos.Text = "Todos los Laboratorios";
        	this.radioTodos.UseVisualStyleBackColor = true;
        	// 
        	// radioSoloInternos
        	// 
        	this.radioSoloInternos.AutoSize = true;
        	this.radioSoloInternos.Location = new System.Drawing.Point(16, 24);
        	this.radioSoloInternos.Margin = new System.Windows.Forms.Padding(2);
        	this.radioSoloInternos.Name = "radioSoloInternos";
        	this.radioSoloInternos.Size = new System.Drawing.Size(87, 17);
        	this.radioSoloInternos.TabIndex = 0;
        	this.radioSoloInternos.TabStop = true;
        	this.radioSoloInternos.Text = "Solo Internos";
        	this.radioSoloInternos.UseVisualStyleBackColor = true;
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
        	dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
        	dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.tablaDatos.DefaultCellStyle = dataGridViewCellStyle1;
        	this.tablaDatos.Location = new System.Drawing.Point(13, 133);
        	this.tablaDatos.MultiSelect = false;
        	this.tablaDatos.Name = "tablaDatos";
        	this.tablaDatos.ReadOnly = true;
        	this.tablaDatos.RowHeadersVisible = false;
        	this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        	this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.tablaDatos.Size = new System.Drawing.Size(542, 232);
        	this.tablaDatos.TabIndex = 3;
        	this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
        	this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
        	// 
        	// ListarLaboratorios
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(573, 392);
        	this.Controls.Add(this.grupoAcciones);
        	this.Controls.Add(this.grupoFiltros);
        	this.Controls.Add(this.tablaDatos);
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.MaximizeBox = false;
        	this.MinimumSize = new System.Drawing.Size(588, 428);
        	this.Name = "ListarLaboratorios";
        	this.Text = "Listado de Laboratorios";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarLaboratoriosFormFormClosing);
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
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.GroupBox grupoTipo;
        private System.Windows.Forms.RadioButton radioExternos;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioSoloInternos;
    }
}