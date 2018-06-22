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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grupoAcciones = new System.Windows.Forms.GroupBox();
            this.grupoFiltros = new System.Windows.Forms.GroupBox();
            this.grupoSector = new System.Windows.Forms.GroupBox();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.grupoTipo = new System.Windows.Forms.GroupBox();
            this.RadioTodas = new System.Windows.Forms.RadioButton();
            this.radioOtra = new System.Windows.Forms.RadioButton();
            this.radioSuperficie = new System.Windows.Forms.RadioButton();
            this.radioAmbiente = new System.Windows.Forms.RadioButton();
            this.radioOperario = new System.Windows.Forms.RadioButton();
            this.radioProducto = new System.Windows.Forms.RadioButton();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.btnBorrarFiltros = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grupoAcciones.SuspendLayout();
            this.grupoFiltros.SuspendLayout();
            this.grupoSector.SuspendLayout();
            this.grupoTipo.SuspendLayout();
            this.grupoBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoAcciones
            // 
            this.grupoAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoAcciones.Controls.Add(this.btnEliminar);
            this.grupoAcciones.Controls.Add(this.btnEditar);
            this.grupoAcciones.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoAcciones.Location = new System.Drawing.Point(699, 2);
            this.grupoAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Size = new System.Drawing.Size(171, 164);
            this.grupoAcciones.TabIndex = 8;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Acciones";
            // 
            // grupoFiltros
            // 
            this.grupoFiltros.Controls.Add(this.btnBorrarFiltros);
            this.grupoFiltros.Controls.Add(this.grupoSector);
            this.grupoFiltros.Controls.Add(this.grupoTipo);
            this.grupoFiltros.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoFiltros.Location = new System.Drawing.Point(13, 2);
            this.grupoFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Name = "grupoFiltros";
            this.grupoFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Size = new System.Drawing.Size(433, 164);
            this.grupoFiltros.TabIndex = 7;
            this.grupoFiltros.TabStop = false;
            this.grupoFiltros.Text = "Filtros";
            // 
            // grupoSector
            // 
            this.grupoSector.Controls.Add(this.cboSector);
            this.grupoSector.Location = new System.Drawing.Point(222, 22);
            this.grupoSector.Name = "grupoSector";
            this.grupoSector.Size = new System.Drawing.Size(204, 73);
            this.grupoSector.TabIndex = 8;
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
            // grupoTipo
            // 
            this.grupoTipo.Controls.Add(this.RadioTodas);
            this.grupoTipo.Controls.Add(this.radioOtra);
            this.grupoTipo.Controls.Add(this.radioSuperficie);
            this.grupoTipo.Controls.Add(this.radioAmbiente);
            this.grupoTipo.Controls.Add(this.radioOperario);
            this.grupoTipo.Controls.Add(this.radioProducto);
            this.grupoTipo.Location = new System.Drawing.Point(7, 22);
            this.grupoTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoTipo.Name = "grupoTipo";
            this.grupoTipo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoTipo.Size = new System.Drawing.Size(209, 136);
            this.grupoTipo.TabIndex = 0;
            this.grupoTipo.TabStop = false;
            this.grupoTipo.Text = "Tipo";
            // 
            // RadioTodas
            // 
            this.RadioTodas.AutoSize = true;
            this.RadioTodas.Checked = true;
            this.RadioTodas.Location = new System.Drawing.Point(114, 98);
            this.RadioTodas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioTodas.Name = "RadioTodas";
            this.RadioTodas.Size = new System.Drawing.Size(66, 21);
            this.RadioTodas.TabIndex = 5;
            this.RadioTodas.TabStop = true;
            this.RadioTodas.Text = "Todas";
            this.RadioTodas.UseVisualStyleBackColor = true;
            // 
            // radioOtra
            // 
            this.radioOtra.AutoSize = true;
            this.radioOtra.Location = new System.Drawing.Point(114, 58);
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
            this.radioSuperficie.Location = new System.Drawing.Point(114, 24);
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
            this.radioAmbiente.Location = new System.Drawing.Point(14, 58);
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
            this.radioOperario.Location = new System.Drawing.Point(14, 98);
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
            this.radioProducto.Location = new System.Drawing.Point(13, 24);
            this.radioProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioProducto.Name = "radioProducto";
            this.radioProducto.Size = new System.Drawing.Size(89, 21);
            this.radioProducto.TabIndex = 0;
            this.radioProducto.TabStop = true;
            this.radioProducto.Text = "Producto";
            this.radioProducto.UseVisualStyleBackColor = true;
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoBuscar.Controls.Add(this.btnBuscar);
            this.grupoBuscar.Controls.Add(this.txtBuscarNombre);
            this.grupoBuscar.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoBuscar.Location = new System.Drawing.Point(453, 2);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Size = new System.Drawing.Size(239, 164);
            this.grupoBuscar.TabIndex = 1;
            this.grupoBuscar.TabStop = false;
            this.grupoBuscar.Text = "Buscar por Nombre:";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(19, 54);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(201, 22);
            this.txtBuscarNombre.TabIndex = 0;
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
            this.tablaDatos.Location = new System.Drawing.Point(13, 174);
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
            this.tablaDatos.Size = new System.Drawing.Size(856, 366);
            this.tablaDatos.TabIndex = 6;
            this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
            this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
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
            this.btnBorrarFiltros.Location = new System.Drawing.Point(308, 111);
            this.btnBorrarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarFiltros.Name = "btnBorrarFiltros";
            this.btnBorrarFiltros.Size = new System.Drawing.Size(117, 38);
            this.btnBorrarFiltros.TabIndex = 30;
            this.btnBorrarFiltros.Text = "Borrar";
            this.btnBorrarFiltros.UseVisualStyleBackColor = false;
            this.btnBorrarFiltros.Click += new System.EventHandler(this.BorrarFiltros);
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
            this.btnBuscar.Location = new System.Drawing.Point(103, 110);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 38);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(27, 111);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 38);
            this.btnEliminar.TabIndex = 22;
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
            this.btnEditar.Location = new System.Drawing.Point(27, 46);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 38);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // ListarMuestras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.grupoBuscar);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.grupoFiltros);
            this.Controls.Add(this.tablaDatos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(898, 593);
            this.Name = "ListarMuestras";
            this.Text = "Listado de Muestras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarMuestrasFormFormClosing);
            this.grupoAcciones.ResumeLayout(false);
            this.grupoFiltros.ResumeLayout(false);
            this.grupoSector.ResumeLayout(false);
            this.grupoTipo.ResumeLayout(false);
            this.grupoTipo.PerformLayout();
            this.grupoBuscar.ResumeLayout(false);
            this.grupoBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoAcciones;
        private System.Windows.Forms.GroupBox grupoFiltros;
        private System.Windows.Forms.GroupBox grupoBuscar;
        private System.Windows.Forms.GroupBox grupoTipo;
        private System.Windows.Forms.RadioButton RadioTodas;
        private System.Windows.Forms.RadioButton radioOtra;
        private System.Windows.Forms.RadioButton radioSuperficie;
        private System.Windows.Forms.RadioButton radioAmbiente;
        private System.Windows.Forms.RadioButton radioOperario;
        private System.Windows.Forms.RadioButton radioProducto;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.GroupBox grupoSector;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.Button btnBorrarFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}