﻿/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 07/04/2018
 * Hora: 10:09 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;

namespace FrigLab.View.Muestreos
{
	partial class ListarMuestreosAmbientales
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox grupoAcciones;
		private System.Windows.Forms.GroupBox grupoFiltros;
		private System.Windows.Forms.GroupBox grupoBuscar;
		private System.Windows.Forms.TextBox txtBuscarTexto;
		private System.Windows.Forms.GroupBox grupoClase;
		private System.Windows.Forms.RadioButton RadioTodas;
		private System.Windows.Forms.RadioButton radioSuperficie;
		private System.Windows.Forms.RadioButton radioAmbiente;
		private System.Windows.Forms.RadioButton radioOperario;
		private System.Windows.Forms.GroupBox grupoTabla;
		private System.Windows.Forms.CheckBox chkPool;
		private System.Windows.Forms.CheckBox chkRequisitos;
		private System.Windows.Forms.CheckBox chkRepeticion;
		private System.Windows.Forms.CheckBox chkObservaciones;
		private System.Windows.Forms.GroupBox grupoEstado;
		private System.Windows.Forms.RadioButton radioTodos;
		private System.Windows.Forms.RadioButton radioNoHabilitado;
		private System.Windows.Forms.RadioButton radioHabilitado;
		private System.Windows.Forms.GroupBox grupoFecha;
		private System.Windows.Forms.DateTimePicker pickerMuestreoHasta;
		private System.Windows.Forms.DateTimePicker pickerMuestreoDesde;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label12;
		
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
            this.btnVerMuestreo = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grupoFiltros = new System.Windows.Forms.GroupBox();
            this.btnBorrarFiltros = new System.Windows.Forms.Button();
            this.grupoSector = new System.Windows.Forms.GroupBox();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.grupoFecha = new System.Windows.Forms.GroupBox();
            this.pickerMuestreoHasta = new System.Windows.Forms.DateTimePicker();
            this.pickerMuestreoDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grupoEstado = new System.Windows.Forms.GroupBox();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioNoHabilitado = new System.Windows.Forms.RadioButton();
            this.radioHabilitado = new System.Windows.Forms.RadioButton();
            this.grupoClase = new System.Windows.Forms.GroupBox();
            this.RadioTodas = new System.Windows.Forms.RadioButton();
            this.radioSuperficie = new System.Windows.Forms.RadioButton();
            this.radioAmbiente = new System.Windows.Forms.RadioButton();
            this.radioOperario = new System.Windows.Forms.RadioButton();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtBuscarTexto = new System.Windows.Forms.TextBox();
            this.grupoTabla = new System.Windows.Forms.GroupBox();
            this.chkPool = new System.Windows.Forms.CheckBox();
            this.chkRequisitos = new System.Windows.Forms.CheckBox();
            this.chkRepeticion = new System.Windows.Forms.CheckBox();
            this.chkObservaciones = new System.Windows.Forms.CheckBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.grupoAcciones.SuspendLayout();
            this.grupoFiltros.SuspendLayout();
            this.grupoSector.SuspendLayout();
            this.grupoFecha.SuspendLayout();
            this.grupoEstado.SuspendLayout();
            this.grupoClase.SuspendLayout();
            this.grupoBuscar.SuspendLayout();
            this.grupoTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoAcciones
            // 
            this.grupoAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoAcciones.Controls.Add(this.btnVerMuestreo);
            this.grupoAcciones.Controls.Add(this.btnResultado);
            this.grupoAcciones.Controls.Add(this.btnEliminar);
            this.grupoAcciones.Controls.Add(this.btnEditar);
            this.grupoAcciones.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoAcciones.Location = new System.Drawing.Point(1071, 11);
            this.grupoAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Size = new System.Drawing.Size(171, 199);
            this.grupoAcciones.TabIndex = 5;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Acciones";
            // 
            // btnVerMuestreo
            // 
            this.btnVerMuestreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerMuestreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.btnVerMuestreo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.btnVerMuestreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMuestreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMuestreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnVerMuestreo.Location = new System.Drawing.Point(27, 23);
            this.btnVerMuestreo.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerMuestreo.Name = "btnVerMuestreo";
            this.btnVerMuestreo.Size = new System.Drawing.Size(117, 38);
            this.btnVerMuestreo.TabIndex = 16;
            this.btnVerMuestreo.Text = "Ver";
            this.btnVerMuestreo.UseVisualStyleBackColor = false;
            this.btnVerMuestreo.Click += new System.EventHandler(this.BtnVerMuestreoClick);
            // 
            // btnResultado
            // 
            this.btnResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.btnResultado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnResultado.Location = new System.Drawing.Point(27, 66);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(4);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(117, 38);
            this.btnResultado.TabIndex = 15;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.BtnVerMuestreoClick);
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
            this.btnEliminar.Location = new System.Drawing.Point(27, 151);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 38);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(27, 108);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 38);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grupoFiltros
            // 
            this.grupoFiltros.Controls.Add(this.btnBorrarFiltros);
            this.grupoFiltros.Controls.Add(this.grupoSector);
            this.grupoFiltros.Controls.Add(this.grupoFecha);
            this.grupoFiltros.Controls.Add(this.grupoEstado);
            this.grupoFiltros.Controls.Add(this.grupoClase);
            this.grupoFiltros.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoFiltros.Location = new System.Drawing.Point(20, 13);
            this.grupoFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Name = "grupoFiltros";
            this.grupoFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Size = new System.Drawing.Size(649, 197);
            this.grupoFiltros.TabIndex = 4;
            this.grupoFiltros.TabStop = false;
            this.grupoFiltros.Text = "Filtros";
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
            this.btnBorrarFiltros.Location = new System.Drawing.Point(524, 147);
            this.btnBorrarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarFiltros.Name = "btnBorrarFiltros";
            this.btnBorrarFiltros.Size = new System.Drawing.Size(117, 38);
            this.btnBorrarFiltros.TabIndex = 10;
            this.btnBorrarFiltros.Text = "Borrar";
            this.btnBorrarFiltros.UseVisualStyleBackColor = false;
            this.btnBorrarFiltros.Click += new System.EventHandler(this.BorrarFiltros);
            // 
            // grupoSector
            // 
            this.grupoSector.Controls.Add(this.cboSector);
            this.grupoSector.Location = new System.Drawing.Point(429, 22);
            this.grupoSector.Name = "grupoSector";
            this.grupoSector.Size = new System.Drawing.Size(209, 73);
            this.grupoSector.TabIndex = 6;
            this.grupoSector.TabStop = false;
            this.grupoSector.Text = "Sector";
            // 
            // cboSector
            // 
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Location = new System.Drawing.Point(12, 32);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(181, 25);
            this.cboSector.TabIndex = 0;
            this.cboSector.SelectedIndexChanged += new System.EventHandler(this.CboSectores_SelectedIndexChanged);
            // 
            // grupoFecha
            // 
            this.grupoFecha.Controls.Add(this.pickerMuestreoHasta);
            this.grupoFecha.Controls.Add(this.pickerMuestreoDesde);
            this.grupoFecha.Controls.Add(this.label3);
            this.grupoFecha.Controls.Add(this.label12);
            this.grupoFecha.Location = new System.Drawing.Point(154, 21);
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
            // grupoEstado
            // 
            this.grupoEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoEstado.Controls.Add(this.radioTodos);
            this.grupoEstado.Controls.Add(this.radioNoHabilitado);
            this.grupoEstado.Controls.Add(this.radioHabilitado);
            this.grupoEstado.Location = new System.Drawing.Point(7, 22);
            this.grupoEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoEstado.Name = "grupoEstado";
            this.grupoEstado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoEstado.Size = new System.Drawing.Size(144, 164);
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
            // grupoClase
            // 
            this.grupoClase.Controls.Add(this.RadioTodas);
            this.grupoClase.Controls.Add(this.radioSuperficie);
            this.grupoClase.Controls.Add(this.radioAmbiente);
            this.grupoClase.Controls.Add(this.radioOperario);
            this.grupoClase.Location = new System.Drawing.Point(310, 22);
            this.grupoClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoClase.Name = "grupoClase";
            this.grupoClase.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoClase.Size = new System.Drawing.Size(113, 164);
            this.grupoClase.TabIndex = 0;
            this.grupoClase.TabStop = false;
            this.grupoClase.Text = "Tipo";
            // 
            // RadioTodas
            // 
            this.RadioTodas.AutoSize = true;
            this.RadioTodas.Checked = true;
            this.RadioTodas.Location = new System.Drawing.Point(13, 126);
            this.RadioTodas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioTodas.Name = "RadioTodas";
            this.RadioTodas.Size = new System.Drawing.Size(63, 21);
            this.RadioTodas.TabIndex = 5;
            this.RadioTodas.TabStop = true;
            this.RadioTodas.Text = "Todas";
            this.RadioTodas.UseVisualStyleBackColor = true;
            // 
            // radioSuperficie
            // 
            this.radioSuperficie.AutoSize = true;
            this.radioSuperficie.Location = new System.Drawing.Point(13, 96);
            this.radioSuperficie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSuperficie.Name = "radioSuperficie";
            this.radioSuperficie.Size = new System.Drawing.Size(89, 21);
            this.radioSuperficie.TabIndex = 3;
            this.radioSuperficie.Text = "Superficie";
            this.radioSuperficie.UseVisualStyleBackColor = true;
            // 
            // radioAmbiente
            // 
            this.radioAmbiente.AutoSize = true;
            this.radioAmbiente.Location = new System.Drawing.Point(13, 30);
            this.radioAmbiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAmbiente.Name = "radioAmbiente";
            this.radioAmbiente.Size = new System.Drawing.Size(88, 21);
            this.radioAmbiente.TabIndex = 1;
            this.radioAmbiente.Text = "Ambiente";
            this.radioAmbiente.UseVisualStyleBackColor = true;
            // 
            // radioOperario
            // 
            this.radioOperario.AutoSize = true;
            this.radioOperario.Location = new System.Drawing.Point(13, 64);
            this.radioOperario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioOperario.Name = "radioOperario";
            this.radioOperario.Size = new System.Drawing.Size(82, 21);
            this.radioOperario.TabIndex = 2;
            this.radioOperario.Text = "Operario";
            this.radioOperario.UseVisualStyleBackColor = true;
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Controls.Add(this.btnBuscar);
            this.grupoBuscar.Controls.Add(this.checkBox2);
            this.grupoBuscar.Controls.Add(this.checkBox1);
            this.grupoBuscar.Controls.Add(this.txtBuscarTexto);
            this.grupoBuscar.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoBuscar.Location = new System.Drawing.Point(673, 13);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Size = new System.Drawing.Size(184, 197);
            this.grupoBuscar.TabIndex = 1;
            this.grupoBuscar.TabStop = false;
            this.grupoBuscar.Text = "Buscar por:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnBuscar.Location = new System.Drawing.Point(60, 149);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 38);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 109);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 21);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Identificacion";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Muestra";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtBuscarTexto
            // 
            this.txtBuscarTexto.Location = new System.Drawing.Point(21, 36);
            this.txtBuscarTexto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarTexto.Name = "txtBuscarTexto";
            this.txtBuscarTexto.Size = new System.Drawing.Size(156, 22);
            this.txtBuscarTexto.TabIndex = 1;
            // 
            // grupoTabla
            // 
            this.grupoTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoTabla.Controls.Add(this.chkPool);
            this.grupoTabla.Controls.Add(this.chkRequisitos);
            this.grupoTabla.Controls.Add(this.chkRepeticion);
            this.grupoTabla.Controls.Add(this.chkObservaciones);
            this.grupoTabla.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoTabla.Location = new System.Drawing.Point(866, 11);
            this.grupoTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoTabla.Name = "grupoTabla";
            this.grupoTabla.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoTabla.Size = new System.Drawing.Size(199, 200);
            this.grupoTabla.TabIndex = 7;
            this.grupoTabla.TabStop = false;
            this.grupoTabla.Text = "Mostrar/Ocultar Columnas";
            // 
            // chkPool
            // 
            this.chkPool.AutoSize = true;
            this.chkPool.Checked = true;
            this.chkPool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPool.Location = new System.Drawing.Point(21, 133);
            this.chkPool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPool.Name = "chkPool";
            this.chkPool.Size = new System.Drawing.Size(56, 21);
            this.chkPool.TabIndex = 0;
            this.chkPool.Text = "Pool";
            this.chkPool.UseVisualStyleBackColor = true;
            // 
            // chkRequisitos
            // 
            this.chkRequisitos.AutoSize = true;
            this.chkRequisitos.Checked = true;
            this.chkRequisitos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRequisitos.Location = new System.Drawing.Point(21, 96);
            this.chkRequisitos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRequisitos.Name = "chkRequisitos";
            this.chkRequisitos.Size = new System.Drawing.Size(89, 21);
            this.chkRequisitos.TabIndex = 0;
            this.chkRequisitos.Text = "Requisitos";
            this.chkRequisitos.UseVisualStyleBackColor = true;
            // 
            // chkRepeticion
            // 
            this.chkRepeticion.AutoSize = true;
            this.chkRepeticion.Checked = true;
            this.chkRepeticion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRepeticion.Location = new System.Drawing.Point(21, 62);
            this.chkRepeticion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRepeticion.Name = "chkRepeticion";
            this.chkRepeticion.Size = new System.Drawing.Size(95, 21);
            this.chkRepeticion.TabIndex = 0;
            this.chkRepeticion.Text = "Repeticion";
            this.chkRepeticion.UseVisualStyleBackColor = true;
            // 
            // chkObservaciones
            // 
            this.chkObservaciones.AutoSize = true;
            this.chkObservaciones.Checked = true;
            this.chkObservaciones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObservaciones.Location = new System.Drawing.Point(21, 30);
            this.chkObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkObservaciones.Name = "chkObservaciones";
            this.chkObservaciones.Size = new System.Drawing.Size(120, 21);
            this.chkObservaciones.TabIndex = 0;
            this.chkObservaciones.Text = "Observaciones";
            this.chkObservaciones.UseVisualStyleBackColor = true;
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            this.tablaDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
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
            this.tablaDatos.Location = new System.Drawing.Point(20, 218);
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
            this.tablaDatos.Size = new System.Drawing.Size(1222, 428);
            this.tablaDatos.TabIndex = 8;
            this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
            this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
            // 
            // ListarMuestreosAmbientales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.grupoTabla);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.grupoFiltros);
            this.Controls.Add(this.grupoBuscar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "ListarMuestreosAmbientales";
            this.Text = "Listar Muestreos Ambientales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarMuestreosAmbientalesFormFormClosing);
            this.Load += new System.EventHandler(this.ListarMuestreosAmbientales_Load);
            this.grupoAcciones.ResumeLayout(false);
            this.grupoFiltros.ResumeLayout(false);
            this.grupoSector.ResumeLayout(false);
            this.grupoFecha.ResumeLayout(false);
            this.grupoEstado.ResumeLayout(false);
            this.grupoClase.ResumeLayout(false);
            this.grupoClase.PerformLayout();
            this.grupoBuscar.ResumeLayout(false);
            this.grupoBuscar.PerformLayout();
            this.grupoTabla.ResumeLayout(false);
            this.grupoTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
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
        private System.Windows.Forms.GroupBox grupoSector;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button btnVerMuestreo;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrarFiltros;
        private System.Windows.Forms.Button btnBuscar;
    }
}
