using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using System;

namespace FrigLab.View.Usuarios {
    partial class ListarUsuarios {
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
        	this.grupoBuscarNombre = new System.Windows.Forms.GroupBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.BtnBorrarBusqueda = new System.Windows.Forms.Button();
        	this.txtBuscarNombre = new System.Windows.Forms.TextBox();
        	this.TxtBuscarPadron = new System.Windows.Forms.TextBox();
        	this.grupoVigencia = new System.Windows.Forms.GroupBox();
        	this.radioNoVigentes = new System.Windows.Forms.RadioButton();
        	this.radioTodos = new System.Windows.Forms.RadioButton();
        	this.radioSoloVigentes = new System.Windows.Forms.RadioButton();
        	this.tablaDatos = new System.Windows.Forms.DataGridView();
        	this.grupoAcciones.SuspendLayout();
        	this.grupoFiltros.SuspendLayout();
        	this.grupoBuscarNombre.SuspendLayout();
        	this.grupoVigencia.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// grupoAcciones
        	// 
        	this.grupoAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.grupoAcciones.Controls.Add(this.btnEliminar);
        	this.grupoAcciones.Controls.Add(this.btnEditar);
        	this.grupoAcciones.Location = new System.Drawing.Point(522, 15);
        	this.grupoAcciones.Name = "grupoAcciones";
        	this.grupoAcciones.Size = new System.Drawing.Size(128, 113);
        	this.grupoAcciones.TabIndex = 1;
        	this.grupoAcciones.TabStop = false;
        	this.grupoAcciones.Text = "Acciones";
        	// 
        	// btnEliminar
        	// 
        	this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.btnEliminar.Enabled = false;
        	this.btnEliminar.Location = new System.Drawing.Point(19, 67);
        	this.btnEliminar.Name = "btnEliminar";
        	this.btnEliminar.Size = new System.Drawing.Size(88, 31);
        	this.btnEliminar.TabIndex = 1;
        	this.btnEliminar.Text = "Eliminar";
        	this.btnEliminar.UseVisualStyleBackColor = true;
        	// 
        	// btnEditar
        	// 
        	this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.btnEditar.Enabled = false;
        	this.btnEditar.Location = new System.Drawing.Point(19, 29);
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
        	this.grupoFiltros.Controls.Add(this.grupoBuscarNombre);
        	this.grupoFiltros.Controls.Add(this.grupoVigencia);
        	this.grupoFiltros.Location = new System.Drawing.Point(12, 15);
        	this.grupoFiltros.Name = "grupoFiltros";
        	this.grupoFiltros.Size = new System.Drawing.Size(505, 113);
        	this.grupoFiltros.TabIndex = 2;
        	this.grupoFiltros.TabStop = false;
        	this.grupoFiltros.Text = "Filtros";
        	// 
        	// grupoBuscarNombre
        	// 
        	this.grupoBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.grupoBuscarNombre.Controls.Add(this.label2);
        	this.grupoBuscarNombre.Controls.Add(this.label1);
        	this.grupoBuscarNombre.Controls.Add(this.BtnBorrarBusqueda);
        	this.grupoBuscarNombre.Controls.Add(this.txtBuscarNombre);
        	this.grupoBuscarNombre.Controls.Add(this.TxtBuscarPadron);
        	this.grupoBuscarNombre.Location = new System.Drawing.Point(146, 18);
        	this.grupoBuscarNombre.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoBuscarNombre.Name = "grupoBuscarNombre";
        	this.grupoBuscarNombre.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoBuscarNombre.Size = new System.Drawing.Size(354, 90);
        	this.grupoBuscarNombre.TabIndex = 1;
        	this.grupoBuscarNombre.TabStop = false;
        	this.grupoBuscarNombre.Text = "Busqueda";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(10, 67);
        	this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(41, 13);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "Padron";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(10, 23);
        	this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(44, 13);
        	this.label1.TabIndex = 3;
        	this.label1.Text = "Nombre";
        	// 
        	// BtnBorrarBusqueda
        	// 
        	this.BtnBorrarBusqueda.Location = new System.Drawing.Point(249, 49);
        	this.BtnBorrarBusqueda.Name = "BtnBorrarBusqueda";
        	this.BtnBorrarBusqueda.Size = new System.Drawing.Size(88, 31);
        	this.BtnBorrarBusqueda.TabIndex = 2;
        	this.BtnBorrarBusqueda.Text = "Borrar";
        	this.BtnBorrarBusqueda.UseVisualStyleBackColor = true;
        	this.BtnBorrarBusqueda.Click += new System.EventHandler(this.BtnBorrarBusqueda_Click);
        	// 
        	// txtBuscarNombre
        	// 
        	this.txtBuscarNombre.Location = new System.Drawing.Point(58, 17);
        	this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(2);
        	this.txtBuscarNombre.Name = "txtBuscarNombre";
        	this.txtBuscarNombre.Size = new System.Drawing.Size(164, 20);
        	this.txtBuscarNombre.TabIndex = 0;
        	this.txtBuscarNombre.TextChanged += new System.EventHandler(this.TxtBuscarNombre_TextChanged);
        	// 
        	// TxtBuscarPadron
        	// 
        	this.TxtBuscarPadron.Location = new System.Drawing.Point(58, 60);
        	this.TxtBuscarPadron.Margin = new System.Windows.Forms.Padding(2);
        	this.TxtBuscarPadron.Name = "TxtBuscarPadron";
        	this.TxtBuscarPadron.Size = new System.Drawing.Size(164, 20);
        	this.TxtBuscarPadron.TabIndex = 1;
        	this.TxtBuscarPadron.TextChanged += new System.EventHandler(this.TxtBuscarPadron_TextChanged);
        	// 
        	// grupoVigencia
        	// 
        	this.grupoVigencia.Controls.Add(this.radioNoVigentes);
        	this.grupoVigencia.Controls.Add(this.radioTodos);
        	this.grupoVigencia.Controls.Add(this.radioSoloVigentes);
        	this.grupoVigencia.Location = new System.Drawing.Point(5, 18);
        	this.grupoVigencia.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoVigencia.Name = "grupoVigencia";
        	this.grupoVigencia.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoVigencia.Size = new System.Drawing.Size(136, 90);
        	this.grupoVigencia.TabIndex = 0;
        	this.grupoVigencia.TabStop = false;
        	this.grupoVigencia.Text = "Vigencia";
        	// 
        	// radioNoVigentes
        	// 
        	this.radioNoVigentes.AutoSize = true;
        	this.radioNoVigentes.Location = new System.Drawing.Point(16, 46);
        	this.radioNoVigentes.Margin = new System.Windows.Forms.Padding(2);
        	this.radioNoVigentes.Name = "radioNoVigentes";
        	this.radioNoVigentes.Size = new System.Drawing.Size(107, 17);
        	this.radioNoVigentes.TabIndex = 1;
        	this.radioNoVigentes.TabStop = true;
        	this.radioNoVigentes.Text = "Solo No Vigentes";
        	this.radioNoVigentes.UseVisualStyleBackColor = true;
        	this.radioNoVigentes.CheckedChanged += new System.EventHandler(this.GrupoPermisoChange_Click);
        	// 
        	// radioTodos
        	// 
        	this.radioTodos.AutoSize = true;
        	this.radioTodos.Location = new System.Drawing.Point(16, 67);
        	this.radioTodos.Margin = new System.Windows.Forms.Padding(2);
        	this.radioTodos.Name = "radioTodos";
        	this.radioTodos.Size = new System.Drawing.Size(113, 17);
        	this.radioTodos.TabIndex = 2;
        	this.radioTodos.TabStop = true;
        	this.radioTodos.Text = "Todos los usuarios";
        	this.radioTodos.UseVisualStyleBackColor = true;
        	this.radioTodos.CheckedChanged += new System.EventHandler(this.GrupoPermisoChange_Click);
        	// 
        	// radioSoloVigentes
        	// 
        	this.radioSoloVigentes.AutoSize = true;
        	this.radioSoloVigentes.Location = new System.Drawing.Point(16, 24);
        	this.radioSoloVigentes.Margin = new System.Windows.Forms.Padding(2);
        	this.radioSoloVigentes.Name = "radioSoloVigentes";
        	this.radioSoloVigentes.Size = new System.Drawing.Size(90, 17);
        	this.radioSoloVigentes.TabIndex = 0;
        	this.radioSoloVigentes.TabStop = true;
        	this.radioSoloVigentes.Text = "Solo Vigentes";
        	this.radioSoloVigentes.UseVisualStyleBackColor = true;
        	this.radioSoloVigentes.CheckedChanged += new System.EventHandler(this.GrupoPermisoChange_Click);
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
        	this.tablaDatos.Location = new System.Drawing.Point(12, 134);
        	this.tablaDatos.MinimumSize = new System.Drawing.Size(638, 301);
        	this.tablaDatos.MultiSelect = false;
        	this.tablaDatos.Name = "tablaDatos";
        	this.tablaDatos.ReadOnly = true;
        	this.tablaDatos.RowHeadersVisible = false;
        	this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        	this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.tablaDatos.Size = new System.Drawing.Size(638, 301);
        	this.tablaDatos.TabIndex = 0;
        	this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
        	this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
        	// 
        	// ListarUsuarios
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
        	this.Name = "ListarUsuarios";
        	this.Text = "Listado de Usuarios";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarUsuariosFormFormClosing);
        	this.grupoAcciones.ResumeLayout(false);
        	this.grupoFiltros.ResumeLayout(false);
        	this.grupoBuscarNombre.ResumeLayout(false);
        	this.grupoBuscarNombre.PerformLayout();
        	this.grupoVigencia.ResumeLayout(false);
        	this.grupoVigencia.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Bloquea los componentes inicializados segun el permiso del usuario segun los casos de uso.
        /// </summary>
        /// <param name="permiso"></param>
        private void BloquearComponentes(EnumPermisoUsuario permiso) {
            // Visitante
            if(permiso != EnumPermisoUsuario.Administrador) {
                btnEliminar.Enabled = false;
            }
        }

        private System.Windows.Forms.GroupBox grupoAcciones;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grupoFiltros;
        private System.Windows.Forms.GroupBox grupoBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.GroupBox grupoVigencia;
        private System.Windows.Forms.RadioButton radioNoVigentes;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioSoloVigentes;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button BtnBorrarBusqueda;
        private System.Windows.Forms.TextBox TxtBuscarPadron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
    }
}