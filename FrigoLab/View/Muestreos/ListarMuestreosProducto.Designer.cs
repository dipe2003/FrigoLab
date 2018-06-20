/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 07/04/2018
 * Hora: 09:08 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;

namespace FrigLab.View.Muestreos
{
	partial class ListarMuestreosProducto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox grupoAcciones;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.GroupBox grupoFiltros;
		private System.Windows.Forms.Button btnQuitarFiltroNombre;
		
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerMuestreo = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grupoFiltros = new System.Windows.Forms.GroupBox();
            this.grupoSector = new System.Windows.Forms.GroupBox();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.grupoFecha = new System.Windows.Forms.GroupBox();
            this.pickerMuestreoHasta = new System.Windows.Forms.DateTimePicker();
            this.pickerProduccionHasta = new System.Windows.Forms.DateTimePicker();
            this.pickerFaenaHasta = new System.Windows.Forms.DateTimePicker();
            this.pickerMuestreoDesde = new System.Windows.Forms.DateTimePicker();
            this.pickerProduccionDesde = new System.Windows.Forms.DateTimePicker();
            this.pickerFaenaDesde = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grupoEstado = new System.Windows.Forms.GroupBox();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioNoHabilitado = new System.Windows.Forms.RadioButton();
            this.radioHabilitado = new System.Windows.Forms.RadioButton();
            this.btnQuitarFiltroNombre = new System.Windows.Forms.Button();
            this.grupoTabla = new System.Windows.Forms.GroupBox();
            this.chkPool = new System.Windows.Forms.CheckBox();
            this.chkDestinoMercado = new System.Windows.Forms.CheckBox();
            this.chkMetodo = new System.Windows.Forms.CheckBox();
            this.chkObservaciones = new System.Windows.Forms.CheckBox();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.txtBuscarTexto = new System.Windows.Forms.TextBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.grupoAcciones.SuspendLayout();
            this.grupoFiltros.SuspendLayout();
            this.grupoSector.SuspendLayout();
            this.grupoFecha.SuspendLayout();
            this.grupoEstado.SuspendLayout();
            this.grupoTabla.SuspendLayout();
            this.grupoBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoAcciones
            // 
            this.grupoAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoAcciones.Controls.Add(this.btnEliminar);
            this.grupoAcciones.Controls.Add(this.btnVerMuestreo);
            this.grupoAcciones.Controls.Add(this.btnResultado);
            this.grupoAcciones.Controls.Add(this.btnEditar);
            this.grupoAcciones.Location = new System.Drawing.Point(1068, 18);
            this.grupoAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Size = new System.Drawing.Size(171, 192);
            this.grupoAcciones.TabIndex = 5;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(27, 146);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 37);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerMuestreo
            // 
            this.btnVerMuestreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerMuestreo.Location = new System.Drawing.Point(27, 23);
            this.btnVerMuestreo.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerMuestreo.Name = "btnVerMuestreo";
            this.btnVerMuestreo.Size = new System.Drawing.Size(117, 38);
            this.btnVerMuestreo.TabIndex = 0;
            this.btnVerMuestreo.Text = "Ver";
            this.btnVerMuestreo.UseVisualStyleBackColor = true;
            this.btnVerMuestreo.Click += new System.EventHandler(this.BtnVerMuestreoClick);
            // 
            // btnResultado
            // 
            this.btnResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultado.Location = new System.Drawing.Point(27, 63);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(4);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(117, 38);
            this.btnResultado.TabIndex = 0;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(27, 105);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 38);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grupoFiltros
            // 
            this.grupoFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoFiltros.Controls.Add(this.grupoSector);
            this.grupoFiltros.Controls.Add(this.grupoFecha);
            this.grupoFiltros.Controls.Add(this.grupoEstado);
            this.grupoFiltros.Controls.Add(this.btnQuitarFiltroNombre);
            this.grupoFiltros.Location = new System.Drawing.Point(20, 18);
            this.grupoFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Name = "grupoFiltros";
            this.grupoFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Size = new System.Drawing.Size(669, 192);
            this.grupoFiltros.TabIndex = 4;
            this.grupoFiltros.TabStop = false;
            this.grupoFiltros.Text = "Filtros";
            // 
            // grupoSector
            // 
            this.grupoSector.Controls.Add(this.cboSector);
            this.grupoSector.Location = new System.Drawing.Point(458, 20);
            this.grupoSector.Name = "grupoSector";
            this.grupoSector.Size = new System.Drawing.Size(204, 73);
            this.grupoSector.TabIndex = 7;
            this.grupoSector.TabStop = false;
            this.grupoSector.Text = "Sector";
            // 
            // cboSector
            // 
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Location = new System.Drawing.Point(12, 32);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(181, 24);
            this.cboSector.TabIndex = 0;
            // 
            // grupoFecha
            // 
            this.grupoFecha.Controls.Add(this.pickerMuestreoHasta);
            this.grupoFecha.Controls.Add(this.pickerProduccionHasta);
            this.grupoFecha.Controls.Add(this.pickerFaenaHasta);
            this.grupoFecha.Controls.Add(this.pickerMuestreoDesde);
            this.grupoFecha.Controls.Add(this.pickerProduccionDesde);
            this.grupoFecha.Controls.Add(this.pickerFaenaDesde);
            this.grupoFecha.Controls.Add(this.label12);
            this.grupoFecha.Controls.Add(this.label11);
            this.grupoFecha.Controls.Add(this.label10);
            this.grupoFecha.Controls.Add(this.label3);
            this.grupoFecha.Controls.Add(this.label5);
            this.grupoFecha.Controls.Add(this.label6);
            this.grupoFecha.Location = new System.Drawing.Point(7, 20);
            this.grupoFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoFecha.Name = "grupoFecha";
            this.grupoFecha.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoFecha.Size = new System.Drawing.Size(300, 164);
            this.grupoFecha.TabIndex = 1;
            this.grupoFecha.TabStop = false;
            this.grupoFecha.Text = "Fechas";
            // 
            // pickerMuestreoHasta
            // 
            this.pickerMuestreoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerMuestreoHasta.Location = new System.Drawing.Point(182, 133);
            this.pickerMuestreoHasta.Margin = new System.Windows.Forms.Padding(4);
            this.pickerMuestreoHasta.Name = "pickerMuestreoHasta";
            this.pickerMuestreoHasta.Size = new System.Drawing.Size(111, 22);
            this.pickerMuestreoHasta.TabIndex = 7;
            // 
            // pickerProduccionHasta
            // 
            this.pickerProduccionHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerProduccionHasta.Location = new System.Drawing.Point(182, 86);
            this.pickerProduccionHasta.Margin = new System.Windows.Forms.Padding(4);
            this.pickerProduccionHasta.Name = "pickerProduccionHasta";
            this.pickerProduccionHasta.Size = new System.Drawing.Size(111, 22);
            this.pickerProduccionHasta.TabIndex = 7;
            // 
            // pickerFaenaHasta
            // 
            this.pickerFaenaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerFaenaHasta.Location = new System.Drawing.Point(182, 36);
            this.pickerFaenaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.pickerFaenaHasta.Name = "pickerFaenaHasta";
            this.pickerFaenaHasta.Size = new System.Drawing.Size(111, 22);
            this.pickerFaenaHasta.TabIndex = 7;
            // 
            // pickerMuestreoDesde
            // 
            this.pickerMuestreoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerMuestreoDesde.Location = new System.Drawing.Point(10, 133);
            this.pickerMuestreoDesde.Margin = new System.Windows.Forms.Padding(4);
            this.pickerMuestreoDesde.Name = "pickerMuestreoDesde";
            this.pickerMuestreoDesde.Size = new System.Drawing.Size(111, 22);
            this.pickerMuestreoDesde.TabIndex = 7;
            // 
            // pickerProduccionDesde
            // 
            this.pickerProduccionDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerProduccionDesde.Location = new System.Drawing.Point(10, 89);
            this.pickerProduccionDesde.Margin = new System.Windows.Forms.Padding(4);
            this.pickerProduccionDesde.Name = "pickerProduccionDesde";
            this.pickerProduccionDesde.Size = new System.Drawing.Size(111, 22);
            this.pickerProduccionDesde.TabIndex = 7;
            // 
            // pickerFaenaDesde
            // 
            this.pickerFaenaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerFaenaDesde.Location = new System.Drawing.Point(10, 38);
            this.pickerFaenaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.pickerFaenaDesde.Name = "pickerFaenaDesde";
            this.pickerFaenaDesde.Size = new System.Drawing.Size(111, 22);
            this.pickerFaenaDesde.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(127, 133);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 22);
            this.label12.TabIndex = 5;
            this.label12.Text = "Hasta";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(127, 88);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Hasta";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(127, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Faena";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Muestreo";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Produccion";
            // 
            // grupoEstado
            // 
            this.grupoEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoEstado.Controls.Add(this.radioTodos);
            this.grupoEstado.Controls.Add(this.radioNoHabilitado);
            this.grupoEstado.Controls.Add(this.radioHabilitado);
            this.grupoEstado.Location = new System.Drawing.Point(313, 20);
            this.grupoEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoEstado.Name = "grupoEstado";
            this.grupoEstado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoEstado.Size = new System.Drawing.Size(139, 164);
            this.grupoEstado.TabIndex = 1;
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
            // btnQuitarFiltroNombre
            // 
            this.btnQuitarFiltroNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarFiltroNombre.Location = new System.Drawing.Point(590, 145);
            this.btnQuitarFiltroNombre.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitarFiltroNombre.Name = "btnQuitarFiltroNombre";
            this.btnQuitarFiltroNombre.Size = new System.Drawing.Size(72, 38);
            this.btnQuitarFiltroNombre.TabIndex = 4;
            this.btnQuitarFiltroNombre.Text = "Borrar";
            this.btnQuitarFiltroNombre.UseVisualStyleBackColor = true;
            this.btnQuitarFiltroNombre.Click += new System.EventHandler(this.BorrarFiltros);
            // 
            // grupoTabla
            // 
            this.grupoTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoTabla.Controls.Add(this.chkPool);
            this.grupoTabla.Controls.Add(this.chkDestinoMercado);
            this.grupoTabla.Controls.Add(this.chkMetodo);
            this.grupoTabla.Controls.Add(this.chkObservaciones);
            this.grupoTabla.Location = new System.Drawing.Point(869, 17);
            this.grupoTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoTabla.Name = "grupoTabla";
            this.grupoTabla.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoTabla.Size = new System.Drawing.Size(192, 193);
            this.grupoTabla.TabIndex = 6;
            this.grupoTabla.TabStop = false;
            this.grupoTabla.Text = "Mostrar/Ocultar Columnas";
            // 
            // chkPool
            // 
            this.chkPool.AutoSize = true;
            this.chkPool.Location = new System.Drawing.Point(21, 133);
            this.chkPool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPool.Name = "chkPool";
            this.chkPool.Size = new System.Drawing.Size(58, 21);
            this.chkPool.TabIndex = 0;
            this.chkPool.Text = "Pool";
            this.chkPool.UseVisualStyleBackColor = true;
            // 
            // chkDestinoMercado
            // 
            this.chkDestinoMercado.AutoSize = true;
            this.chkDestinoMercado.Location = new System.Drawing.Point(21, 96);
            this.chkDestinoMercado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDestinoMercado.Name = "chkDestinoMercado";
            this.chkDestinoMercado.Size = new System.Drawing.Size(137, 21);
            this.chkDestinoMercado.TabIndex = 0;
            this.chkDestinoMercado.Text = "Destino/Mercado";
            this.chkDestinoMercado.UseVisualStyleBackColor = true;
            // 
            // chkMetodo
            // 
            this.chkMetodo.AutoSize = true;
            this.chkMetodo.Location = new System.Drawing.Point(21, 62);
            this.chkMetodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMetodo.Name = "chkMetodo";
            this.chkMetodo.Size = new System.Drawing.Size(77, 21);
            this.chkMetodo.TabIndex = 0;
            this.chkMetodo.Text = "Metodo";
            this.chkMetodo.UseVisualStyleBackColor = true;
            // 
            // chkObservaciones
            // 
            this.chkObservaciones.AutoSize = true;
            this.chkObservaciones.Location = new System.Drawing.Point(21, 30);
            this.chkObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkObservaciones.Name = "chkObservaciones";
            this.chkObservaciones.Size = new System.Drawing.Size(125, 21);
            this.chkObservaciones.TabIndex = 0;
            this.chkObservaciones.Text = "Observaciones";
            this.chkObservaciones.UseVisualStyleBackColor = true;
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Controls.Add(this.checkBox2);
            this.grupoBuscar.Controls.Add(this.checkBox1);
            this.grupoBuscar.Controls.Add(this.bntBuscar);
            this.grupoBuscar.Controls.Add(this.txtBuscarTexto);
            this.grupoBuscar.Location = new System.Drawing.Point(696, 18);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Size = new System.Drawing.Size(167, 192);
            this.grupoBuscar.TabIndex = 7;
            this.grupoBuscar.TabStop = false;
            this.grupoBuscar.Text = "Buscar por:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 109);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(112, 21);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Identificacion";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Muestra";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bntBuscar
            // 
            this.bntBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntBuscar.Location = new System.Drawing.Point(88, 146);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(72, 38);
            this.bntBuscar.TabIndex = 4;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // txtBuscarTexto
            // 
            this.txtBuscarTexto.Location = new System.Drawing.Point(12, 36);
            this.txtBuscarTexto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarTexto.Name = "txtBuscarTexto";
            this.txtBuscarTexto.Size = new System.Drawing.Size(147, 22);
            this.txtBuscarTexto.TabIndex = 1;
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
            this.tablaDatos.Size = new System.Drawing.Size(1219, 436);
            this.tablaDatos.TabIndex = 8;
            this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
            this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
            // 
            // ListarMuestreosProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1259, 667);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.grupoBuscar);
            this.Controls.Add(this.grupoTabla);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.grupoFiltros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ListarMuestreosProducto";
            this.Text = "Listar Productos Muestreados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarMuestreosProductoFormFormClosing);
            this.Load += new System.EventHandler(this.ListarMuestreosProducto_Load);
            this.grupoAcciones.ResumeLayout(false);
            this.grupoFiltros.ResumeLayout(false);
            this.grupoSector.ResumeLayout(false);
            this.grupoFecha.ResumeLayout(false);
            this.grupoEstado.ResumeLayout(false);
            this.grupoTabla.ResumeLayout(false);
            this.grupoTabla.PerformLayout();
            this.grupoBuscar.ResumeLayout(false);
            this.grupoBuscar.PerformLayout();
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

        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnVerMuestreo;
        private System.Windows.Forms.GroupBox grupoTabla;
        private System.Windows.Forms.CheckBox chkMetodo;
        private System.Windows.Forms.CheckBox chkObservaciones;
        private System.Windows.Forms.CheckBox chkDestinoMercado;
        private System.Windows.Forms.CheckBox chkPool;
        private System.Windows.Forms.GroupBox grupoFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker pickerMuestreoHasta;
        private System.Windows.Forms.DateTimePicker pickerProduccionHasta;
        private System.Windows.Forms.DateTimePicker pickerFaenaHasta;
        private System.Windows.Forms.DateTimePicker pickerMuestreoDesde;
        private System.Windows.Forms.DateTimePicker pickerProduccionDesde;
        private System.Windows.Forms.DateTimePicker pickerFaenaDesde;
        private System.Windows.Forms.GroupBox grupoEstado;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioNoHabilitado;
        private System.Windows.Forms.RadioButton radioHabilitado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grupoSector;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.GroupBox grupoBuscar;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.TextBox txtBuscarTexto;
        private System.Windows.Forms.DataGridView tablaDatos;
    }
}
