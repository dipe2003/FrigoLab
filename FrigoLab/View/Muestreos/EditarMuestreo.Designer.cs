namespace FrigLab.View.Muestreos {
    partial class EditarMuestreo {
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
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.btnGuardar = new System.Windows.Forms.Button();
        	this.grupoRequisitosAnalisis = new System.Windows.Forms.GroupBox();
        	this.label11 = new System.Windows.Forms.Label();
        	this.label10 = new System.Windows.Forms.Label();
        	this.lblAvisoPool = new System.Windows.Forms.Label();
        	this.cboLaboratorios = new System.Windows.Forms.ComboBox();
        	this.cboAnalisis = new System.Windows.Forms.ComboBox();
        	this.tablaDatos2 = new System.Windows.Forms.DataGridView();
        	this.btnAgregarAnalisis = new System.Windows.Forms.Button();
        	this.grupoMuestreo = new System.Windows.Forms.GroupBox();
        	this.pickerFechaMuestreo = new System.Windows.Forms.DateTimePicker();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtObservaciones = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.grupoAlmacenamiento = new System.Windows.Forms.GroupBox();
        	this.radioOtro = new System.Windows.Forms.RadioButton();
        	this.radioFreezer = new System.Windows.Forms.RadioButton();
        	this.radioEstufa = new System.Windows.Forms.RadioButton();
        	this.radioHeladera = new System.Windows.Forms.RadioButton();
        	this.txtNumeroMuestra = new System.Windows.Forms.TextBox();
        	this.grupoTipoMuestreo = new System.Windows.Forms.GroupBox();
        	this.radioNoDestructivo = new System.Windows.Forms.RadioButton();
        	this.radioDestructivo = new System.Windows.Forms.RadioButton();
        	this.label4 = new System.Windows.Forms.Label();
        	this.grupoMuestra = new System.Windows.Forms.GroupBox();
        	this.panelOperario = new System.Windows.Forms.Panel();
        	this.txtPadron = new System.Windows.Forms.TextBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.label8 = new System.Windows.Forms.Label();
        	this.txtOperario = new System.Windows.Forms.TextBox();
        	this.chkRepeticion = new System.Windows.Forms.CheckBox();
        	this.panelProducto = new System.Windows.Forms.Panel();
        	this.pickerFechaFaena = new System.Windows.Forms.DateTimePicker();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.pickerFechaProduccion = new System.Windows.Forms.DateTimePicker();
        	this.label6 = new System.Windows.Forms.Label();
        	this.txtLote = new System.Windows.Forms.TextBox();
        	this.grupoArea = new System.Windows.Forms.GroupBox();
        	this.cboMuestras = new System.Windows.Forms.ComboBox();
        	this.cboArea = new System.Windows.Forms.ComboBox();
        	this.chkContactoProducto = new System.Windows.Forms.CheckBox();
        	this.txtIdentificacion = new System.Windows.Forms.TextBox();
        	this.grupoHorario = new System.Windows.Forms.GroupBox();
        	this.radioOperativo = new System.Windows.Forms.RadioButton();
        	this.radioPreoperativo = new System.Windows.Forms.RadioButton();
        	this.label9 = new System.Windows.Forms.Label();
        	this.grupoPool = new System.Windows.Forms.GroupBox();
        	this.txtDescripcionPool = new System.Windows.Forms.TextBox();
        	this.pickerFechaPool = new System.Windows.Forms.DateTimePicker();
        	this.label13 = new System.Windows.Forms.Label();
        	this.label12 = new System.Windows.Forms.Label();
        	this.btnEditarPool = new System.Windows.Forms.Button();
        	this.grupoRequisitosAnalisis.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tablaDatos2)).BeginInit();
        	this.grupoMuestreo.SuspendLayout();
        	this.grupoAlmacenamiento.SuspendLayout();
        	this.grupoTipoMuestreo.SuspendLayout();
        	this.grupoMuestra.SuspendLayout();
        	this.panelOperario.SuspendLayout();
        	this.panelProducto.SuspendLayout();
        	this.grupoArea.SuspendLayout();
        	this.grupoHorario.SuspendLayout();
        	this.grupoPool.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnCancelar.Location = new System.Drawing.Point(497, 448);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(105, 29);
        	this.btnCancelar.TabIndex = 40;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnGuardar.Location = new System.Drawing.Point(615, 448);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(105, 29);
        	this.btnGuardar.TabIndex = 39;
        	this.btnGuardar.Text = "Guardar";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
        	// 
        	// grupoRequisitosAnalisis
        	// 
        	this.grupoRequisitosAnalisis.Controls.Add(this.label11);
        	this.grupoRequisitosAnalisis.Controls.Add(this.label10);
        	this.grupoRequisitosAnalisis.Controls.Add(this.lblAvisoPool);
        	this.grupoRequisitosAnalisis.Controls.Add(this.cboLaboratorios);
        	this.grupoRequisitosAnalisis.Controls.Add(this.cboAnalisis);
        	this.grupoRequisitosAnalisis.Controls.Add(this.tablaDatos2);
        	this.grupoRequisitosAnalisis.Controls.Add(this.btnAgregarAnalisis);
        	this.grupoRequisitosAnalisis.Location = new System.Drawing.Point(7, 232);
        	this.grupoRequisitosAnalisis.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoRequisitosAnalisis.Name = "grupoRequisitosAnalisis";
        	this.grupoRequisitosAnalisis.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoRequisitosAnalisis.Size = new System.Drawing.Size(741, 166);
        	this.grupoRequisitosAnalisis.TabIndex = 38;
        	this.grupoRequisitosAnalisis.TabStop = false;
        	this.grupoRequisitosAnalisis.Text = "Analisis";
        	// 
        	// label11
        	// 
        	this.label11.AutoSize = true;
        	this.label11.Location = new System.Drawing.Point(454, 62);
        	this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label11.Name = "label11";
        	this.label11.Size = new System.Drawing.Size(60, 13);
        	this.label11.TabIndex = 34;
        	this.label11.Text = "Laboratorio";
        	// 
        	// label10
        	// 
        	this.label10.AutoSize = true;
        	this.label10.Location = new System.Drawing.Point(454, 21);
        	this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label10.Name = "label10";
        	this.label10.Size = new System.Drawing.Size(42, 13);
        	this.label10.TabIndex = 34;
        	this.label10.Text = "Ensayo";
        	// 
        	// lblAvisoPool
        	// 
        	this.lblAvisoPool.Location = new System.Drawing.Point(458, 116);
        	this.lblAvisoPool.Name = "lblAvisoPool";
        	this.lblAvisoPool.Size = new System.Drawing.Size(165, 45);
        	this.lblAvisoPool.TabIndex = 7;
        	this.lblAvisoPool.Text = "Los analisis agregados se crearan para todos los muestreos del pool";
        	this.lblAvisoPool.Visible = false;
        	// 
        	// cboLaboratorios
        	// 
        	this.cboLaboratorios.FormattingEnabled = true;
        	this.cboLaboratorios.Location = new System.Drawing.Point(454, 77);
        	this.cboLaboratorios.Margin = new System.Windows.Forms.Padding(2);
        	this.cboLaboratorios.Name = "cboLaboratorios";
        	this.cboLaboratorios.Size = new System.Drawing.Size(262, 21);
        	this.cboLaboratorios.TabIndex = 33;
        	this.cboLaboratorios.SelectedValueChanged += new System.EventHandler(this.CboLaboratorios_SelectedValueChanged);
        	// 
        	// cboAnalisis
        	// 
        	this.cboAnalisis.FormattingEnabled = true;
        	this.cboAnalisis.Location = new System.Drawing.Point(454, 37);
        	this.cboAnalisis.Name = "cboAnalisis";
        	this.cboAnalisis.Size = new System.Drawing.Size(262, 21);
        	this.cboAnalisis.TabIndex = 12;
        	this.cboAnalisis.SelectedValueChanged += new System.EventHandler(this.CboAnalisisSelectedValueChanged);
        	// 
        	// tablaDatos2
        	// 
        	this.tablaDatos2.AllowUserToAddRows = false;
        	this.tablaDatos2.AllowUserToDeleteRows = false;
        	this.tablaDatos2.AllowUserToOrderColumns = true;
        	dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        	dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.tablaDatos2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        	this.tablaDatos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.tablaDatos2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.tablaDatos2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        	this.tablaDatos2.BackgroundColor = System.Drawing.SystemColors.Control;
        	this.tablaDatos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.tablaDatos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        	dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        	dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        	dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.tablaDatos2.DefaultCellStyle = dataGridViewCellStyle2;
        	this.tablaDatos2.Location = new System.Drawing.Point(8, 18);
        	this.tablaDatos2.MultiSelect = false;
        	this.tablaDatos2.Name = "tablaDatos2";
        	this.tablaDatos2.ReadOnly = true;
        	this.tablaDatos2.RowHeadersVisible = false;
        	dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.tablaDatos2.RowsDefaultCellStyle = dataGridViewCellStyle3;
        	this.tablaDatos2.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.tablaDatos2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        	this.tablaDatos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.tablaDatos2.Size = new System.Drawing.Size(433, 143);
        	this.tablaDatos2.TabIndex = 11;
        	this.tablaDatos2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatos2CellClick);
        	// 
        	// btnAgregarAnalisis
        	// 
        	this.btnAgregarAnalisis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnAgregarAnalisis.Location = new System.Drawing.Point(626, 132);
        	this.btnAgregarAnalisis.Name = "btnAgregarAnalisis";
        	this.btnAgregarAnalisis.Size = new System.Drawing.Size(90, 29);
        	this.btnAgregarAnalisis.TabIndex = 32;
        	this.btnAgregarAnalisis.Text = "Agregar Analisis";
        	this.btnAgregarAnalisis.UseVisualStyleBackColor = true;
        	this.btnAgregarAnalisis.Click += new System.EventHandler(this.BtnAgregarAnalisisClick);
        	// 
        	// grupoMuestreo
        	// 
        	this.grupoMuestreo.Controls.Add(this.pickerFechaMuestreo);
        	this.grupoMuestreo.Controls.Add(this.label1);
        	this.grupoMuestreo.Controls.Add(this.txtObservaciones);
        	this.grupoMuestreo.Controls.Add(this.label5);
        	this.grupoMuestreo.Controls.Add(this.grupoAlmacenamiento);
        	this.grupoMuestreo.Controls.Add(this.txtNumeroMuestra);
        	this.grupoMuestreo.Controls.Add(this.grupoTipoMuestreo);
        	this.grupoMuestreo.Controls.Add(this.label4);
        	this.grupoMuestreo.Location = new System.Drawing.Point(456, 11);
        	this.grupoMuestreo.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoMuestreo.Name = "grupoMuestreo";
        	this.grupoMuestreo.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoMuestreo.Size = new System.Drawing.Size(291, 217);
        	this.grupoMuestreo.TabIndex = 37;
        	this.grupoMuestreo.TabStop = false;
        	this.grupoMuestreo.Text = "Muestreo";
        	// 
        	// pickerFechaMuestreo
        	// 
        	this.pickerFechaMuestreo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.pickerFechaMuestreo.Location = new System.Drawing.Point(5, 35);
        	this.pickerFechaMuestreo.Name = "pickerFechaMuestreo";
        	this.pickerFechaMuestreo.Size = new System.Drawing.Size(149, 20);
        	this.pickerFechaMuestreo.TabIndex = 4;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(5, 18);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(100, 14);
        	this.label1.TabIndex = 5;
        	this.label1.Text = "Fecha de Muestreo";
        	// 
        	// txtObservaciones
        	// 
        	this.txtObservaciones.Location = new System.Drawing.Point(5, 152);
        	this.txtObservaciones.Multiline = true;
        	this.txtObservaciones.Name = "txtObservaciones";
        	this.txtObservaciones.Size = new System.Drawing.Size(276, 60);
        	this.txtObservaciones.TabIndex = 6;
        	// 
        	// label5
        	// 
        	this.label5.Location = new System.Drawing.Point(9, 135);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(114, 14);
        	this.label5.TabIndex = 5;
        	this.label5.Text = "Observaciones";
        	// 
        	// grupoAlmacenamiento
        	// 
        	this.grupoAlmacenamiento.Controls.Add(this.radioOtro);
        	this.grupoAlmacenamiento.Controls.Add(this.radioFreezer);
        	this.grupoAlmacenamiento.Controls.Add(this.radioEstufa);
        	this.grupoAlmacenamiento.Controls.Add(this.radioHeladera);
        	this.grupoAlmacenamiento.Location = new System.Drawing.Point(4, 59);
        	this.grupoAlmacenamiento.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoAlmacenamiento.Name = "grupoAlmacenamiento";
        	this.grupoAlmacenamiento.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoAlmacenamiento.Size = new System.Drawing.Size(150, 71);
        	this.grupoAlmacenamiento.TabIndex = 1;
        	this.grupoAlmacenamiento.TabStop = false;
        	this.grupoAlmacenamiento.Text = "Almacenamiento";
        	// 
        	// radioOtro
        	// 
        	this.radioOtro.AutoSize = true;
        	this.radioOtro.Location = new System.Drawing.Point(85, 45);
        	this.radioOtro.Margin = new System.Windows.Forms.Padding(2);
        	this.radioOtro.Name = "radioOtro";
        	this.radioOtro.Size = new System.Drawing.Size(45, 17);
        	this.radioOtro.TabIndex = 1;
        	this.radioOtro.TabStop = true;
        	this.radioOtro.Text = "Otro";
        	this.radioOtro.UseVisualStyleBackColor = true;
        	// 
        	// radioFreezer
        	// 
        	this.radioFreezer.AutoSize = true;
        	this.radioFreezer.Location = new System.Drawing.Point(85, 23);
        	this.radioFreezer.Margin = new System.Windows.Forms.Padding(2);
        	this.radioFreezer.Name = "radioFreezer";
        	this.radioFreezer.Size = new System.Drawing.Size(60, 17);
        	this.radioFreezer.TabIndex = 0;
        	this.radioFreezer.TabStop = true;
        	this.radioFreezer.Text = "Freezer";
        	this.radioFreezer.UseVisualStyleBackColor = true;
        	// 
        	// radioEstufa
        	// 
        	this.radioEstufa.AutoSize = true;
        	this.radioEstufa.Location = new System.Drawing.Point(7, 45);
        	this.radioEstufa.Margin = new System.Windows.Forms.Padding(2);
        	this.radioEstufa.Name = "radioEstufa";
        	this.radioEstufa.Size = new System.Drawing.Size(55, 17);
        	this.radioEstufa.TabIndex = 1;
        	this.radioEstufa.TabStop = true;
        	this.radioEstufa.Text = "Estufa";
        	this.radioEstufa.UseVisualStyleBackColor = true;
        	// 
        	// radioHeladera
        	// 
        	this.radioHeladera.AutoSize = true;
        	this.radioHeladera.Location = new System.Drawing.Point(7, 23);
        	this.radioHeladera.Margin = new System.Windows.Forms.Padding(2);
        	this.radioHeladera.Name = "radioHeladera";
        	this.radioHeladera.Size = new System.Drawing.Size(68, 17);
        	this.radioHeladera.TabIndex = 0;
        	this.radioHeladera.TabStop = true;
        	this.radioHeladera.Text = "Heladera";
        	this.radioHeladera.UseVisualStyleBackColor = true;
        	// 
        	// txtNumeroMuestra
        	// 
        	this.txtNumeroMuestra.Location = new System.Drawing.Point(159, 35);
        	this.txtNumeroMuestra.Name = "txtNumeroMuestra";
        	this.txtNumeroMuestra.Size = new System.Drawing.Size(125, 20);
        	this.txtNumeroMuestra.TabIndex = 6;
        	// 
        	// grupoTipoMuestreo
        	// 
        	this.grupoTipoMuestreo.Controls.Add(this.radioNoDestructivo);
        	this.grupoTipoMuestreo.Controls.Add(this.radioDestructivo);
        	this.grupoTipoMuestreo.Location = new System.Drawing.Point(159, 59);
        	this.grupoTipoMuestreo.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoTipoMuestreo.Name = "grupoTipoMuestreo";
        	this.grupoTipoMuestreo.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoTipoMuestreo.Size = new System.Drawing.Size(124, 71);
        	this.grupoTipoMuestreo.TabIndex = 1;
        	this.grupoTipoMuestreo.TabStop = false;
        	this.grupoTipoMuestreo.Text = "Tipo de Muestreo";
        	// 
        	// radioNoDestructivo
        	// 
        	this.radioNoDestructivo.AutoSize = true;
        	this.radioNoDestructivo.Location = new System.Drawing.Point(20, 44);
        	this.radioNoDestructivo.Margin = new System.Windows.Forms.Padding(2);
        	this.radioNoDestructivo.Name = "radioNoDestructivo";
        	this.radioNoDestructivo.Size = new System.Drawing.Size(93, 17);
        	this.radioNoDestructivo.TabIndex = 1;
        	this.radioNoDestructivo.TabStop = true;
        	this.radioNoDestructivo.Text = "NoDestructivo";
        	this.radioNoDestructivo.UseVisualStyleBackColor = true;
        	// 
        	// radioDestructivo
        	// 
        	this.radioDestructivo.AutoSize = true;
        	this.radioDestructivo.Location = new System.Drawing.Point(20, 22);
        	this.radioDestructivo.Margin = new System.Windows.Forms.Padding(2);
        	this.radioDestructivo.Name = "radioDestructivo";
        	this.radioDestructivo.Size = new System.Drawing.Size(79, 17);
        	this.radioDestructivo.TabIndex = 0;
        	this.radioDestructivo.TabStop = true;
        	this.radioDestructivo.Text = "Destructivo";
        	this.radioDestructivo.UseVisualStyleBackColor = true;
        	// 
        	// label4
        	// 
        	this.label4.Location = new System.Drawing.Point(159, 18);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(114, 14);
        	this.label4.TabIndex = 5;
        	this.label4.Text = "Numero de Muestra";
        	// 
        	// grupoMuestra
        	// 
        	this.grupoMuestra.Controls.Add(this.panelOperario);
        	this.grupoMuestra.Controls.Add(this.chkRepeticion);
        	this.grupoMuestra.Controls.Add(this.panelProducto);
        	this.grupoMuestra.Controls.Add(this.grupoArea);
        	this.grupoMuestra.Controls.Add(this.chkContactoProducto);
        	this.grupoMuestra.Controls.Add(this.txtIdentificacion);
        	this.grupoMuestra.Controls.Add(this.grupoHorario);
        	this.grupoMuestra.Controls.Add(this.label9);
        	this.grupoMuestra.Location = new System.Drawing.Point(7, 11);
        	this.grupoMuestra.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoMuestra.Name = "grupoMuestra";
        	this.grupoMuestra.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoMuestra.Size = new System.Drawing.Size(445, 217);
        	this.grupoMuestra.TabIndex = 36;
        	this.grupoMuestra.TabStop = false;
        	this.grupoMuestra.Text = "Muestra";
        	// 
        	// panelOperario
        	// 
        	this.panelOperario.Controls.Add(this.txtPadron);
        	this.panelOperario.Controls.Add(this.label7);
        	this.panelOperario.Controls.Add(this.label8);
        	this.panelOperario.Controls.Add(this.txtOperario);
        	this.panelOperario.Location = new System.Drawing.Point(5, 152);
        	this.panelOperario.Name = "panelOperario";
        	this.panelOperario.Size = new System.Drawing.Size(383, 44);
        	this.panelOperario.TabIndex = 36;
        	// 
        	// txtPadron
        	// 
        	this.txtPadron.Location = new System.Drawing.Point(3, 21);
        	this.txtPadron.Name = "txtPadron";
        	this.txtPadron.Size = new System.Drawing.Size(114, 20);
        	this.txtPadron.TabIndex = 6;
        	// 
        	// label7
        	// 
        	this.label7.Location = new System.Drawing.Point(3, 4);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(114, 14);
        	this.label7.TabIndex = 5;
        	this.label7.Text = "Padron";
        	// 
        	// label8
        	// 
        	this.label8.Location = new System.Drawing.Point(122, 6);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(114, 14);
        	this.label8.TabIndex = 5;
        	this.label8.Text = "Operario";
        	// 
        	// txtOperario
        	// 
        	this.txtOperario.Location = new System.Drawing.Point(122, 21);
        	this.txtOperario.Name = "txtOperario";
        	this.txtOperario.Size = new System.Drawing.Size(254, 20);
        	this.txtOperario.TabIndex = 6;
        	// 
        	// chkRepeticion
        	// 
        	this.chkRepeticion.Location = new System.Drawing.Point(124, 120);
        	this.chkRepeticion.Name = "chkRepeticion";
        	this.chkRepeticion.Size = new System.Drawing.Size(80, 24);
        	this.chkRepeticion.TabIndex = 7;
        	this.chkRepeticion.Text = "Repeticion";
        	this.chkRepeticion.UseVisualStyleBackColor = true;
        	// 
        	// panelProducto
        	// 
        	this.panelProducto.Controls.Add(this.pickerFechaFaena);
        	this.panelProducto.Controls.Add(this.label2);
        	this.panelProducto.Controls.Add(this.label3);
        	this.panelProducto.Controls.Add(this.pickerFechaProduccion);
        	this.panelProducto.Controls.Add(this.label6);
        	this.panelProducto.Controls.Add(this.txtLote);
        	this.panelProducto.Location = new System.Drawing.Point(5, 152);
        	this.panelProducto.Name = "panelProducto";
        	this.panelProducto.Size = new System.Drawing.Size(383, 44);
        	this.panelProducto.TabIndex = 36;
        	// 
        	// pickerFechaFaena
        	// 
        	this.pickerFechaFaena.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.pickerFechaFaena.Location = new System.Drawing.Point(3, 20);
        	this.pickerFechaFaena.Name = "pickerFechaFaena";
        	this.pickerFechaFaena.Size = new System.Drawing.Size(113, 20);
        	this.pickerFechaFaena.TabIndex = 4;
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(3, 4);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(100, 15);
        	this.label2.TabIndex = 5;
        	this.label2.Text = "Fecha de Faena";
        	// 
        	// label3
        	// 
        	this.label3.Location = new System.Drawing.Point(122, 4);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(113, 14);
        	this.label3.TabIndex = 5;
        	this.label3.Text = "Fecha de Produccion";
        	// 
        	// pickerFechaProduccion
        	// 
        	this.pickerFechaProduccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.pickerFechaProduccion.Location = new System.Drawing.Point(122, 20);
        	this.pickerFechaProduccion.Name = "pickerFechaProduccion";
        	this.pickerFechaProduccion.Size = new System.Drawing.Size(113, 20);
        	this.pickerFechaProduccion.TabIndex = 4;
        	// 
        	// label6
        	// 
        	this.label6.Location = new System.Drawing.Point(249, 4);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(90, 14);
        	this.label6.TabIndex = 5;
        	this.label6.Text = "Lote";
        	// 
        	// txtLote
        	// 
        	this.txtLote.Location = new System.Drawing.Point(249, 20);
        	this.txtLote.Name = "txtLote";
        	this.txtLote.Size = new System.Drawing.Size(128, 20);
        	this.txtLote.TabIndex = 6;
        	// 
        	// grupoArea
        	// 
        	this.grupoArea.Controls.Add(this.cboMuestras);
        	this.grupoArea.Controls.Add(this.cboArea);
        	this.grupoArea.Location = new System.Drawing.Point(8, 15);
        	this.grupoArea.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoArea.Name = "grupoArea";
        	this.grupoArea.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoArea.Size = new System.Drawing.Size(328, 81);
        	this.grupoArea.TabIndex = 2;
        	this.grupoArea.TabStop = false;
        	this.grupoArea.Text = "Area";
        	// 
        	// cboMuestras
        	// 
        	this.cboMuestras.FormattingEnabled = true;
        	this.cboMuestras.Location = new System.Drawing.Point(7, 54);
        	this.cboMuestras.Margin = new System.Windows.Forms.Padding(2);
        	this.cboMuestras.Name = "cboMuestras";
        	this.cboMuestras.Size = new System.Drawing.Size(317, 21);
        	this.cboMuestras.TabIndex = 0;
        	this.cboMuestras.SelectedIndexChanged += new System.EventHandler(this.CboMuestrasSelectedValueChanged);
        	this.cboMuestras.SelectedValueChanged += new System.EventHandler(this.CboMuestrasSelectedValueChanged);
        	// 
        	// cboArea
        	// 
        	this.cboArea.FormattingEnabled = true;
        	this.cboArea.Location = new System.Drawing.Point(7, 20);
        	this.cboArea.Margin = new System.Windows.Forms.Padding(2);
        	this.cboArea.Name = "cboArea";
        	this.cboArea.Size = new System.Drawing.Size(317, 21);
        	this.cboArea.TabIndex = 0;
        	this.cboArea.SelectedValueChanged += new System.EventHandler(this.AreaMuestreoSelected);
        	// 
        	// chkContactoProducto
        	// 
        	this.chkContactoProducto.Location = new System.Drawing.Point(251, 123);
        	this.chkContactoProducto.Name = "chkContactoProducto";
        	this.chkContactoProducto.Size = new System.Drawing.Size(159, 20);
        	this.chkContactoProducto.TabIndex = 7;
        	this.chkContactoProducto.Text = "Contacto con Producto";
        	this.chkContactoProducto.UseVisualStyleBackColor = true;
        	// 
        	// txtIdentificacion
        	// 
        	this.txtIdentificacion.Location = new System.Drawing.Point(5, 123);
        	this.txtIdentificacion.Name = "txtIdentificacion";
        	this.txtIdentificacion.Size = new System.Drawing.Size(113, 20);
        	this.txtIdentificacion.TabIndex = 6;
        	// 
        	// grupoHorario
        	// 
        	this.grupoHorario.Controls.Add(this.radioOperativo);
        	this.grupoHorario.Controls.Add(this.radioPreoperativo);
        	this.grupoHorario.Location = new System.Drawing.Point(340, 15);
        	this.grupoHorario.Margin = new System.Windows.Forms.Padding(2);
        	this.grupoHorario.Name = "grupoHorario";
        	this.grupoHorario.Padding = new System.Windows.Forms.Padding(2);
        	this.grupoHorario.Size = new System.Drawing.Size(101, 81);
        	this.grupoHorario.TabIndex = 1;
        	this.grupoHorario.TabStop = false;
        	this.grupoHorario.Text = "Horario";
        	// 
        	// radioOperativo
        	// 
        	this.radioOperativo.AutoSize = true;
        	this.radioOperativo.Location = new System.Drawing.Point(6, 46);
        	this.radioOperativo.Margin = new System.Windows.Forms.Padding(2);
        	this.radioOperativo.Name = "radioOperativo";
        	this.radioOperativo.Size = new System.Drawing.Size(71, 17);
        	this.radioOperativo.TabIndex = 1;
        	this.radioOperativo.TabStop = true;
        	this.radioOperativo.Text = "Operativo";
        	this.radioOperativo.UseVisualStyleBackColor = true;
        	// 
        	// radioPreoperativo
        	// 
        	this.radioPreoperativo.AutoSize = true;
        	this.radioPreoperativo.Location = new System.Drawing.Point(6, 20);
        	this.radioPreoperativo.Margin = new System.Windows.Forms.Padding(2);
        	this.radioPreoperativo.Name = "radioPreoperativo";
        	this.radioPreoperativo.Size = new System.Drawing.Size(85, 17);
        	this.radioPreoperativo.TabIndex = 0;
        	this.radioPreoperativo.TabStop = true;
        	this.radioPreoperativo.Text = "Preoperativo";
        	this.radioPreoperativo.UseVisualStyleBackColor = true;
        	// 
        	// label9
        	// 
        	this.label9.Location = new System.Drawing.Point(4, 106);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(114, 14);
        	this.label9.TabIndex = 5;
        	this.label9.Text = "Identificacion";
        	// 
        	// grupoPool
        	// 
        	this.grupoPool.Controls.Add(this.txtDescripcionPool);
        	this.grupoPool.Controls.Add(this.pickerFechaPool);
        	this.grupoPool.Controls.Add(this.label13);
        	this.grupoPool.Controls.Add(this.label12);
        	this.grupoPool.Location = new System.Drawing.Point(7, 404);
        	this.grupoPool.Name = "grupoPool";
        	this.grupoPool.Size = new System.Drawing.Size(441, 73);
        	this.grupoPool.TabIndex = 41;
        	this.grupoPool.TabStop = false;
        	this.grupoPool.Text = "Pool";
        	this.grupoPool.Visible = false;
        	// 
        	// txtDescripcionPool
        	// 
        	this.txtDescripcionPool.Location = new System.Drawing.Point(128, 40);
        	this.txtDescripcionPool.Name = "txtDescripcionPool";
        	this.txtDescripcionPool.Size = new System.Drawing.Size(303, 20);
        	this.txtDescripcionPool.TabIndex = 8;
        	// 
        	// pickerFechaPool
        	// 
        	this.pickerFechaPool.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.pickerFechaPool.Location = new System.Drawing.Point(8, 40);
        	this.pickerFechaPool.Name = "pickerFechaPool";
        	this.pickerFechaPool.Size = new System.Drawing.Size(114, 20);
        	this.pickerFechaPool.TabIndex = 6;
        	// 
        	// label13
        	// 
        	this.label13.Location = new System.Drawing.Point(128, 23);
        	this.label13.Name = "label13";
        	this.label13.Size = new System.Drawing.Size(150, 14);
        	this.label13.TabIndex = 7;
        	this.label13.Text = "Descripcion del Pool";
        	// 
        	// label12
        	// 
        	this.label12.Location = new System.Drawing.Point(8, 23);
        	this.label12.Name = "label12";
        	this.label12.Size = new System.Drawing.Size(100, 14);
        	this.label12.TabIndex = 7;
        	this.label12.Text = "Fecha de Pool";
        	// 
        	// btnEditarPool
        	// 
        	this.btnEditarPool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnEditarPool.Location = new System.Drawing.Point(497, 412);
        	this.btnEditarPool.Name = "btnEditarPool";
        	this.btnEditarPool.Size = new System.Drawing.Size(105, 29);
        	this.btnEditarPool.TabIndex = 40;
        	this.btnEditarPool.Text = "Editar Pool";
        	this.btnEditarPool.UseVisualStyleBackColor = true;
        	this.btnEditarPool.Visible = false;
        	this.btnEditarPool.Click += new System.EventHandler(this.BtnEditarPoolClick);
        	// 
        	// EditarMuestreo
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(756, 489);
        	this.Controls.Add(this.grupoPool);
        	this.Controls.Add(this.btnEditarPool);
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnGuardar);
        	this.Controls.Add(this.grupoRequisitosAnalisis);
        	this.Controls.Add(this.grupoMuestreo);
        	this.Controls.Add(this.grupoMuestra);
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.MaximizeBox = false;
        	this.MinimumSize = new System.Drawing.Size(770, 525);
        	this.Name = "EditarMuestreo";
        	this.Text = "Editar Muestreo";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarMuestreoFormClosing);
        	this.grupoRequisitosAnalisis.ResumeLayout(false);
        	this.grupoRequisitosAnalisis.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tablaDatos2)).EndInit();
        	this.grupoMuestreo.ResumeLayout(false);
        	this.grupoMuestreo.PerformLayout();
        	this.grupoAlmacenamiento.ResumeLayout(false);
        	this.grupoAlmacenamiento.PerformLayout();
        	this.grupoTipoMuestreo.ResumeLayout(false);
        	this.grupoTipoMuestreo.PerformLayout();
        	this.grupoMuestra.ResumeLayout(false);
        	this.grupoMuestra.PerformLayout();
        	this.panelOperario.ResumeLayout(false);
        	this.panelOperario.PerformLayout();
        	this.panelProducto.ResumeLayout(false);
        	this.panelProducto.PerformLayout();
        	this.grupoArea.ResumeLayout(false);
        	this.grupoHorario.ResumeLayout(false);
        	this.grupoHorario.PerformLayout();
        	this.grupoPool.ResumeLayout(false);
        	this.grupoPool.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grupoRequisitosAnalisis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboLaboratorios;
        private System.Windows.Forms.ComboBox cboAnalisis;
        private System.Windows.Forms.DataGridView tablaDatos2;
        private System.Windows.Forms.Button btnAgregarAnalisis;
        private System.Windows.Forms.GroupBox grupoMuestreo;
        private System.Windows.Forms.DateTimePicker pickerFechaMuestreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grupoAlmacenamiento;
        private System.Windows.Forms.RadioButton radioOtro;
        private System.Windows.Forms.RadioButton radioFreezer;
        private System.Windows.Forms.RadioButton radioEstufa;
        private System.Windows.Forms.RadioButton radioHeladera;
        private System.Windows.Forms.TextBox txtNumeroMuestra;
        private System.Windows.Forms.GroupBox grupoTipoMuestreo;
        private System.Windows.Forms.RadioButton radioNoDestructivo;
        private System.Windows.Forms.RadioButton radioDestructivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grupoMuestra;
        private System.Windows.Forms.Panel panelOperario;
        private System.Windows.Forms.TextBox txtPadron;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOperario;
        private System.Windows.Forms.CheckBox chkRepeticion;
        private System.Windows.Forms.Panel panelProducto;
        private System.Windows.Forms.DateTimePicker pickerFechaFaena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker pickerFechaProduccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.GroupBox grupoArea;
        private System.Windows.Forms.ComboBox cboMuestras;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.CheckBox chkContactoProducto;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.GroupBox grupoHorario;
        private System.Windows.Forms.RadioButton radioOperativo;
        private System.Windows.Forms.RadioButton radioPreoperativo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAvisoPool;
        private System.Windows.Forms.GroupBox grupoPool;
        private System.Windows.Forms.TextBox txtDescripcionPool;
        private System.Windows.Forms.DateTimePicker pickerFechaPool;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEditarPool;
    }
}