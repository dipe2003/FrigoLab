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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grupoAcciones = new System.Windows.Forms.GroupBox();
            this.grupoFiltros = new System.Windows.Forms.GroupBox();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.grupoTipo = new System.Windows.Forms.GroupBox();
            this.radioExternos = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioSoloInternos = new System.Windows.Forms.RadioButton();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrarFiltros = new System.Windows.Forms.Button();
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
            this.grupoAcciones.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoAcciones.Location = new System.Drawing.Point(571, 14);
            this.grupoAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Size = new System.Drawing.Size(171, 143);
            this.grupoAcciones.TabIndex = 5;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Acciones";
            // 
            // grupoFiltros
            // 
            this.grupoFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoFiltros.Controls.Add(this.grupoBuscar);
            this.grupoFiltros.Controls.Add(this.grupoTipo);
            this.grupoFiltros.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoFiltros.Location = new System.Drawing.Point(17, 14);
            this.grupoFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Name = "grupoFiltros";
            this.grupoFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Size = new System.Drawing.Size(549, 143);
            this.grupoFiltros.TabIndex = 4;
            this.grupoFiltros.TabStop = false;
            this.grupoFiltros.Text = "Filtros";
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoBuscar.Controls.Add(this.btnBorrarFiltros);
            this.grupoBuscar.Controls.Add(this.txtBuscarNombre);
            this.grupoBuscar.Location = new System.Drawing.Point(297, 22);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Size = new System.Drawing.Size(245, 114);
            this.grupoBuscar.TabIndex = 1;
            this.grupoBuscar.TabStop = false;
            this.grupoBuscar.Text = "Buscar por Nombre";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(13, 33);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(213, 22);
            this.txtBuscarNombre.TabIndex = 0;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.TxtBuscarNombre_TextChanged);
            // 
            // grupoTipo
            // 
            this.grupoTipo.Controls.Add(this.radioExternos);
            this.grupoTipo.Controls.Add(this.radioTodos);
            this.grupoTipo.Controls.Add(this.radioSoloInternos);
            this.grupoTipo.Location = new System.Drawing.Point(7, 22);
            this.grupoTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoTipo.Name = "grupoTipo";
            this.grupoTipo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoTipo.Size = new System.Drawing.Size(285, 114);
            this.grupoTipo.TabIndex = 0;
            this.grupoTipo.TabStop = false;
            this.grupoTipo.Text = "Tipo de Laboratorio";
            // 
            // radioExternos
            // 
            this.radioExternos.AutoSize = true;
            this.radioExternos.Location = new System.Drawing.Point(21, 57);
            this.radioExternos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioExternos.Name = "radioExternos";
            this.radioExternos.Size = new System.Drawing.Size(112, 21);
            this.radioExternos.TabIndex = 1;
            this.radioExternos.TabStop = true;
            this.radioExternos.Text = "Solo Externos";
            this.radioExternos.UseVisualStyleBackColor = true;
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(21, 82);
            this.radioTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(172, 21);
            this.radioTodos.TabIndex = 2;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todos los Laboratorios";
            this.radioTodos.UseVisualStyleBackColor = true;
            // 
            // radioSoloInternos
            // 
            this.radioSoloInternos.AutoSize = true;
            this.radioSoloInternos.Location = new System.Drawing.Point(21, 30);
            this.radioSoloInternos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSoloInternos.Name = "radioSoloInternos";
            this.radioSoloInternos.Size = new System.Drawing.Size(110, 21);
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
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.tablaDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.tablaDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.DefaultCellStyle = dataGridViewCellStyle11;
            this.tablaDatos.EnableHeadersVisualStyles = false;
            this.tablaDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tablaDatos.Location = new System.Drawing.Point(17, 165);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaDatos.MultiSelect = false;
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowHeadersVisible = false;
            this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(725, 294);
            this.tablaDatos.TabIndex = 7;
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
            this.btnEliminar.Location = new System.Drawing.Point(27, 83);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 38);
            this.btnEliminar.TabIndex = 20;
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
            this.btnEditar.Location = new System.Drawing.Point(27, 23);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 38);
            this.btnEditar.TabIndex = 19;
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
            this.btnBorrarFiltros.Location = new System.Drawing.Point(109, 61);
            this.btnBorrarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarFiltros.Name = "btnBorrarFiltros";
            this.btnBorrarFiltros.Size = new System.Drawing.Size(117, 38);
            this.btnBorrarFiltros.TabIndex = 30;
            this.btnBorrarFiltros.Text = "Borrar";
            this.btnBorrarFiltros.UseVisualStyleBackColor = false;
            this.btnBorrarFiltros.Click += new System.EventHandler(this.BtnQuitarFiltroNombreClick);
            // 
            // ListarLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(764, 482);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.grupoFiltros);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 516);
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
        private System.Windows.Forms.GroupBox grupoFiltros;
        private System.Windows.Forms.GroupBox grupoBuscar;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.GroupBox grupoTipo;
        private System.Windows.Forms.RadioButton radioExternos;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioSoloInternos;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrarFiltros;
    }
}