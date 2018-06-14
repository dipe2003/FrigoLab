﻿/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 05/04/2018
 * Hora: 07:03 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;

namespace FrigLab.View.Muestreos
{
	partial class ListarOtrosMuestreos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox grupoAcciones;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.DataGridView tablaDatos;
		private System.Windows.Forms.Button btnResultado;
		private System.Windows.Forms.Button btnVerMuestreo;
		
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
            this.btnVerMuestreo = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.grupoFiltros = new System.Windows.Forms.GroupBox();
            this.grupoSector = new System.Windows.Forms.GroupBox();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.grupoFecha = new System.Windows.Forms.GroupBox();
            this.pickerMuestreoHasta = new System.Windows.Forms.DateTimePicker();
            this.pickerMuestreoDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnQuitarFiltroNombre = new System.Windows.Forms.Button();
            this.grupoEstado = new System.Windows.Forms.GroupBox();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioNoHabilitado = new System.Windows.Forms.RadioButton();
            this.radioHabilitado = new System.Windows.Forms.RadioButton();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.txtBuscarTexto = new System.Windows.Forms.TextBox();
            this.grupoAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.grupoFiltros.SuspendLayout();
            this.grupoSector.SuspendLayout();
            this.grupoFecha.SuspendLayout();
            this.grupoEstado.SuspendLayout();
            this.grupoBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoAcciones
            // 
            this.grupoAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoAcciones.Controls.Add(this.btnVerMuestreo);
            this.grupoAcciones.Controls.Add(this.btnResultado);
            this.grupoAcciones.Controls.Add(this.btnEliminar);
            this.grupoAcciones.Controls.Add(this.btnEditar);
            this.grupoAcciones.Location = new System.Drawing.Point(1064, 15);
            this.grupoAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Size = new System.Drawing.Size(171, 192);
            this.grupoAcciones.TabIndex = 2;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Acciones";
            // 
            // btnVerMuestreo
            // 
            this.btnVerMuestreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerMuestreo.Location = new System.Drawing.Point(25, 20);
            this.btnVerMuestreo.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerMuestreo.Name = "btnVerMuestreo";
            this.btnVerMuestreo.Size = new System.Drawing.Size(117, 38);
            this.btnVerMuestreo.TabIndex = 8;
            this.btnVerMuestreo.Text = "Ver";
            this.btnVerMuestreo.UseVisualStyleBackColor = true;
            this.btnVerMuestreo.Click += new System.EventHandler(this.BtnVerMuestreoClick);
            // 
            // btnResultado
            // 
            this.btnResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultado.Location = new System.Drawing.Point(25, 60);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(4);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(117, 38);
            this.btnResultado.TabIndex = 7;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(25, 148);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 38);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(25, 102);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 38);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.tablaDatos.Location = new System.Drawing.Point(17, 215);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(5);
            this.tablaDatos.MultiSelect = false;
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowHeadersVisible = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDatos.RowTemplate.ReadOnly = true;
            this.tablaDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(1217, 430);
            this.tablaDatos.TabIndex = 0;
            this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
            this.tablaDatos.Sorted += new System.EventHandler(this.TablaDatosSorted);
            this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
            // 
            // grupoFiltros
            // 
            this.grupoFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoFiltros.Controls.Add(this.grupoSector);
            this.grupoFiltros.Controls.Add(this.grupoFecha);
            this.grupoFiltros.Controls.Add(this.btnQuitarFiltroNombre);
            this.grupoFiltros.Controls.Add(this.grupoEstado);
            this.grupoFiltros.Location = new System.Drawing.Point(17, 15);
            this.grupoFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Name = "grupoFiltros";
            this.grupoFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Size = new System.Drawing.Size(560, 192);
            this.grupoFiltros.TabIndex = 10;
            this.grupoFiltros.TabStop = false;
            this.grupoFiltros.Text = "Filtros";
            // 
            // grupoSector
            // 
            this.grupoSector.Controls.Add(this.cboSector);
            this.grupoSector.Location = new System.Drawing.Point(310, 21);
            this.grupoSector.Name = "grupoSector";
            this.grupoSector.Size = new System.Drawing.Size(243, 73);
            this.grupoSector.TabIndex = 6;
            this.grupoSector.TabStop = false;
            this.grupoSector.Text = "Sector";
            // 
            // cboSector
            // 
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Location = new System.Drawing.Point(12, 32);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(225, 24);
            this.cboSector.TabIndex = 0;
            this.cboSector.SelectedIndexChanged += new System.EventHandler(this.CboSectores_SelectedIndexChanged);
            // 
            // grupoFecha
            // 
            this.grupoFecha.Controls.Add(this.pickerMuestreoHasta);
            this.grupoFecha.Controls.Add(this.pickerMuestreoDesde);
            this.grupoFecha.Controls.Add(this.label3);
            this.grupoFecha.Controls.Add(this.label12);
            this.grupoFecha.Location = new System.Drawing.Point(7, 21);
            this.grupoFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoFecha.Name = "grupoFecha";
            this.grupoFecha.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoFecha.Size = new System.Drawing.Size(150, 164);
            this.grupoFecha.TabIndex = 5;
            this.grupoFecha.TabStop = false;
            this.grupoFecha.Text = "Fecha de Muestreo";
            // 
            // pickerMuestreoHasta
            // 
            this.pickerMuestreoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerMuestreoHasta.Location = new System.Drawing.Point(7, 125);
            this.pickerMuestreoHasta.Margin = new System.Windows.Forms.Padding(4);
            this.pickerMuestreoHasta.Name = "pickerMuestreoHasta";
            this.pickerMuestreoHasta.Size = new System.Drawing.Size(136, 22);
            this.pickerMuestreoHasta.TabIndex = 7;
            // 
            // pickerMuestreoDesde
            // 
            this.pickerMuestreoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerMuestreoDesde.Location = new System.Drawing.Point(7, 59);
            this.pickerMuestreoDesde.Margin = new System.Windows.Forms.Padding(4);
            this.pickerMuestreoDesde.Name = "pickerMuestreoDesde";
            this.pickerMuestreoDesde.Size = new System.Drawing.Size(136, 22);
            this.pickerMuestreoDesde.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desde";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(7, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Hasta";
            // 
            // btnQuitarFiltroNombre
            // 
            this.btnQuitarFiltroNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarFiltroNombre.Location = new System.Drawing.Point(465, 140);
            this.btnQuitarFiltroNombre.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitarFiltroNombre.Name = "btnQuitarFiltroNombre";
            this.btnQuitarFiltroNombre.Size = new System.Drawing.Size(82, 38);
            this.btnQuitarFiltroNombre.TabIndex = 4;
            this.btnQuitarFiltroNombre.Text = "Borrar";
            this.btnQuitarFiltroNombre.UseVisualStyleBackColor = true;
            // 
            // grupoEstado
            // 
            this.grupoEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoEstado.Controls.Add(this.radioTodos);
            this.grupoEstado.Controls.Add(this.radioNoHabilitado);
            this.grupoEstado.Controls.Add(this.radioHabilitado);
            this.grupoEstado.Location = new System.Drawing.Point(163, 21);
            this.grupoEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoEstado.Name = "grupoEstado";
            this.grupoEstado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoEstado.Size = new System.Drawing.Size(141, 164);
            this.grupoEstado.TabIndex = 2;
            this.grupoEstado.TabStop = false;
            this.grupoEstado.Text = "Estado";
            // 
            // radioTodos
            // 
            this.radioTodos.Checked = true;
            this.radioTodos.Location = new System.Drawing.Point(7, 103);
            this.radioTodos.Margin = new System.Windows.Forms.Padding(4);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(120, 30);
            this.radioTodos.TabIndex = 0;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseVisualStyleBackColor = true;
            // 
            // radioNoHabilitado
            // 
            this.radioNoHabilitado.Location = new System.Drawing.Point(7, 69);
            this.radioNoHabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.radioNoHabilitado.Name = "radioNoHabilitado";
            this.radioNoHabilitado.Size = new System.Drawing.Size(125, 30);
            this.radioNoHabilitado.TabIndex = 0;
            this.radioNoHabilitado.Text = "No Habilitados";
            this.radioNoHabilitado.UseVisualStyleBackColor = true;
            // 
            // radioHabilitado
            // 
            this.radioHabilitado.Location = new System.Drawing.Point(7, 32);
            this.radioHabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.radioHabilitado.Name = "radioHabilitado";
            this.radioHabilitado.Size = new System.Drawing.Size(120, 30);
            this.radioHabilitado.TabIndex = 0;
            this.radioHabilitado.Text = "Habilitados";
            this.radioHabilitado.UseVisualStyleBackColor = true;
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Controls.Add(this.checkBox2);
            this.grupoBuscar.Controls.Add(this.checkBox1);
            this.grupoBuscar.Controls.Add(this.bntBuscar);
            this.grupoBuscar.Controls.Add(this.txtBuscarTexto);
            this.grupoBuscar.Location = new System.Drawing.Point(584, 15);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Size = new System.Drawing.Size(270, 192);
            this.grupoBuscar.TabIndex = 9;
            this.grupoBuscar.TabStop = false;
            this.grupoBuscar.Text = "Buscar por:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 109);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(112, 21);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Identificacion";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Muestra";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bntBuscar
            // 
            this.bntBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntBuscar.Location = new System.Drawing.Point(181, 143);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(82, 38);
            this.bntBuscar.TabIndex = 4;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // txtBuscarTexto
            // 
            this.txtBuscarTexto.Location = new System.Drawing.Point(21, 36);
            this.txtBuscarTexto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarTexto.Name = "txtBuscarTexto";
            this.txtBuscarTexto.Size = new System.Drawing.Size(242, 22);
            this.txtBuscarTexto.TabIndex = 1;
            // 
            // ListarOtrosMuestreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 661);
            this.Controls.Add(this.grupoFiltros);
            this.Controls.Add(this.grupoBuscar);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.tablaDatos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ListarOtrosMuestreos";
            this.Text = "Listar Otros Muestreos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarMuestreosFormFormClosing);
            this.Load += new System.EventHandler(this.ListarOtrosMuestreos_Load);
            this.grupoAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.grupoFiltros.ResumeLayout(false);
            this.grupoSector.ResumeLayout(false);
            this.grupoFecha.ResumeLayout(false);
            this.grupoEstado.ResumeLayout(false);
            this.grupoBuscar.ResumeLayout(false);
            this.grupoBuscar.PerformLayout();
            this.ResumeLayout(false);

		}

        /// <summary>
        /// Bloquea los componentes inicializados segun el permiso del usuario segun los casos de uso.
        /// </summary>
        /// <param name="permiso"></param>
        private void BloquearComponentes(EnumPermisoUsuario permiso) {
            // Visitante
            switch(permiso) {
                case EnumPermisoUsuario.Visitante:
                case EnumPermisoUsuario.Verificador:
                case EnumPermisoUsuario.Monitor:
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnResultado.Enabled = false;
                    break;

                default:
                    break;
            }
        }

        private System.Windows.Forms.GroupBox grupoFiltros;
        private System.Windows.Forms.GroupBox grupoSector;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.GroupBox grupoFecha;
        private System.Windows.Forms.DateTimePicker pickerMuestreoHasta;
        private System.Windows.Forms.DateTimePicker pickerMuestreoDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnQuitarFiltroNombre;
        private System.Windows.Forms.GroupBox grupoEstado;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioNoHabilitado;
        private System.Windows.Forms.RadioButton radioHabilitado;
        private System.Windows.Forms.GroupBox grupoBuscar;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.TextBox txtBuscarTexto;
    }
}