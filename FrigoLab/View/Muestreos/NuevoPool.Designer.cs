namespace FrigLab.View.Muestreos {
    partial class NuevoPool {
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
            this.label1 = new System.Windows.Forms.Label();
            this.pickerFechaPool = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.tablaMuestreosAgregados = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregarMuestreo = new System.Windows.Forms.Button();
            this.btnQuitarMuestreo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grupoClase = new System.Windows.Forms.GroupBox();
            this.RadioTodas = new System.Windows.Forms.RadioButton();
            this.radioSuperficie = new System.Windows.Forms.RadioButton();
            this.radioProducto = new System.Windows.Forms.RadioButton();
            this.radioAmbiente = new System.Windows.Forms.RadioButton();
            this.radioOperario = new System.Windows.Forms.RadioButton();
            this.btnNuevoMuestreo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMuestreosAgregados)).BeginInit();
            this.grupoClase.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Pool";
            // 
            // pickerFechaPool
            // 
            this.pickerFechaPool.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerFechaPool.Location = new System.Drawing.Point(16, 34);
            this.pickerFechaPool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerFechaPool.Name = "pickerFechaPool";
            this.pickerFechaPool.Size = new System.Drawing.Size(200, 22);
            this.pickerFechaPool.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion de Pool";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(236, 34);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(363, 22);
            this.txtDescripcion.TabIndex = 3;
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
            this.tablaDatos.Location = new System.Drawing.Point(16, 97);
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
            this.tablaDatos.Size = new System.Drawing.Size(488, 336);
            this.tablaDatos.TabIndex = 4;
            this.tablaDatos.SelectionChanged += new System.EventHandler(this.tablaDatos_SelectionChanged);
            // 
            // tablaMuestreosAgregados
            // 
            this.tablaMuestreosAgregados.AllowUserToAddRows = false;
            this.tablaMuestreosAgregados.AllowUserToDeleteRows = false;
            this.tablaMuestreosAgregados.AllowUserToOrderColumns = true;
            this.tablaMuestreosAgregados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaMuestreosAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMuestreosAgregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaMuestreosAgregados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaMuestreosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMuestreosAgregados.Location = new System.Drawing.Point(605, 97);
            this.tablaMuestreosAgregados.Margin = new System.Windows.Forms.Padding(5);
            this.tablaMuestreosAgregados.MultiSelect = false;
            this.tablaMuestreosAgregados.Name = "tablaMuestreosAgregados";
            this.tablaMuestreosAgregados.ReadOnly = true;
            this.tablaMuestreosAgregados.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMuestreosAgregados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaMuestreosAgregados.RowTemplate.ReadOnly = true;
            this.tablaMuestreosAgregados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMuestreosAgregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaMuestreosAgregados.Size = new System.Drawing.Size(488, 336);
            this.tablaMuestreosAgregados.TabIndex = 4;
            this.tablaMuestreosAgregados.SelectionChanged += new System.EventHandler(this.tablaMuestreosAgregados_SelectionChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(776, 457);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 36);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(953, 457);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 36);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // btnAgregarMuestreo
            // 
            this.btnAgregarMuestreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMuestreo.Location = new System.Drawing.Point(519, 143);
            this.btnAgregarMuestreo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMuestreo.Name = "btnAgregarMuestreo";
            this.btnAgregarMuestreo.Size = new System.Drawing.Size(77, 36);
            this.btnAgregarMuestreo.TabIndex = 36;
            this.btnAgregarMuestreo.Text = ">>";
            this.btnAgregarMuestreo.UseVisualStyleBackColor = true;
            this.btnAgregarMuestreo.Click += new System.EventHandler(this.BtnAgregarMuestreoClick);
            // 
            // btnQuitarMuestreo
            // 
            this.btnQuitarMuestreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarMuestreo.Location = new System.Drawing.Point(519, 212);
            this.btnQuitarMuestreo.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitarMuestreo.Name = "btnQuitarMuestreo";
            this.btnQuitarMuestreo.Size = new System.Drawing.Size(77, 36);
            this.btnQuitarMuestreo.TabIndex = 36;
            this.btnQuitarMuestreo.Text = "<<";
            this.btnQuitarMuestreo.UseVisualStyleBackColor = true;
            this.btnQuitarMuestreo.Click += new System.EventHandler(this.BtnQuitarMuestreoClick);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciar.Location = new System.Drawing.Point(519, 289);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(77, 36);
            this.btnReiniciar.TabIndex = 36;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciarClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Muestreos Disponibles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Muestreos en Pool";
            // 
            // grupoClase
            // 
            this.grupoClase.Controls.Add(this.RadioTodas);
            this.grupoClase.Controls.Add(this.radioSuperficie);
            this.grupoClase.Controls.Add(this.radioProducto);
            this.grupoClase.Controls.Add(this.radioAmbiente);
            this.grupoClase.Controls.Add(this.radioOperario);
            this.grupoClase.Location = new System.Drawing.Point(605, 14);
            this.grupoClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoClase.Name = "grupoClase";
            this.grupoClase.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoClase.Size = new System.Drawing.Size(493, 46);
            this.grupoClase.TabIndex = 37;
            this.grupoClase.TabStop = false;
            this.grupoClase.Text = "Tipo";
            // 
            // RadioTodas
            // 
            this.RadioTodas.AutoSize = true;
            this.RadioTodas.Location = new System.Drawing.Point(416, 17);
            this.RadioTodas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioTodas.Name = "RadioTodas";
            this.RadioTodas.Size = new System.Drawing.Size(57, 21);
            this.RadioTodas.TabIndex = 5;
            this.RadioTodas.TabStop = true;
            this.RadioTodas.Text = "Otra";
            this.RadioTodas.UseVisualStyleBackColor = true;
            // 
            // radioSuperficie
            // 
            this.radioSuperficie.AutoSize = true;
            this.radioSuperficie.Location = new System.Drawing.Point(303, 17);
            this.radioSuperficie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSuperficie.Name = "radioSuperficie";
            this.radioSuperficie.Size = new System.Drawing.Size(92, 21);
            this.radioSuperficie.TabIndex = 3;
            this.radioSuperficie.TabStop = true;
            this.radioSuperficie.Text = "Superficie";
            this.radioSuperficie.UseVisualStyleBackColor = true;
            // 
            // radioProducto
            // 
            this.radioProducto.AutoSize = true;
            this.radioProducto.Location = new System.Drawing.Point(5, 17);
            this.radioProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioProducto.Name = "radioProducto";
            this.radioProducto.Size = new System.Drawing.Size(86, 21);
            this.radioProducto.TabIndex = 3;
            this.radioProducto.TabStop = true;
            this.radioProducto.Text = "Producto";
            this.radioProducto.UseVisualStyleBackColor = true;
            // 
            // radioAmbiente
            // 
            this.radioAmbiente.AutoSize = true;
            this.radioAmbiente.Location = new System.Drawing.Point(193, 17);
            this.radioAmbiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAmbiente.Name = "radioAmbiente";
            this.radioAmbiente.Size = new System.Drawing.Size(88, 21);
            this.radioAmbiente.TabIndex = 1;
            this.radioAmbiente.TabStop = true;
            this.radioAmbiente.Text = "Ambiente";
            this.radioAmbiente.UseVisualStyleBackColor = true;
            // 
            // radioOperario
            // 
            this.radioOperario.AutoSize = true;
            this.radioOperario.Location = new System.Drawing.Point(101, 17);
            this.radioOperario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioOperario.Name = "radioOperario";
            this.radioOperario.Size = new System.Drawing.Size(85, 21);
            this.radioOperario.TabIndex = 2;
            this.radioOperario.TabStop = true;
            this.radioOperario.Text = "Operario";
            this.radioOperario.UseVisualStyleBackColor = true;
            // 
            // btnNuevoMuestreo
            // 
            this.btnNuevoMuestreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoMuestreo.Location = new System.Drawing.Point(519, 359);
            this.btnNuevoMuestreo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoMuestreo.Name = "btnNuevoMuestreo";
            this.btnNuevoMuestreo.Size = new System.Drawing.Size(77, 36);
            this.btnNuevoMuestreo.TabIndex = 36;
            this.btnNuevoMuestreo.Text = "Nuevo";
            this.btnNuevoMuestreo.UseVisualStyleBackColor = true;
            this.btnNuevoMuestreo.Click += new System.EventHandler(this.BtnNuevoMuestreoClick);
            // 
            // NuevoPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 496);
            this.Controls.Add(this.grupoClase);
            this.Controls.Add(this.btnNuevoMuestreo);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnQuitarMuestreo);
            this.Controls.Add(this.btnAgregarMuestreo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tablaMuestreosAgregados);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickerFechaPool);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1127, 543);
            this.MinimumSize = new System.Drawing.Size(1127, 543);
            this.Name = "NuevoPool";
            this.Text = "Nuevo Pool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevoPoolFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMuestreosAgregados)).EndInit();
            this.grupoClase.ResumeLayout(false);
            this.grupoClase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker pickerFechaPool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.DataGridView tablaMuestreosAgregados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarMuestreo;
        private System.Windows.Forms.Button btnQuitarMuestreo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grupoClase;
        private System.Windows.Forms.RadioButton RadioTodas;
        private System.Windows.Forms.RadioButton radioSuperficie;
        private System.Windows.Forms.RadioButton radioProducto;
        private System.Windows.Forms.RadioButton radioAmbiente;
        private System.Windows.Forms.RadioButton radioOperario;
        private System.Windows.Forms.Button btnNuevoMuestreo;
    }
}