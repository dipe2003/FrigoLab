namespace FrigLab.View.Requisitos {
    partial class ListarRequisitos {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grupoAcciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grupoFiltros = new System.Windows.Forms.GroupBox();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.btnQuitarFiltroNombre = new System.Windows.Forms.Button();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.tablaDatos2 = new System.Windows.Forms.DataGridView();
            this.grupoAcciones.SuspendLayout();
            this.grupoFiltros.SuspendLayout();
            this.grupoBuscar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos2)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoAcciones
            // 
            this.grupoAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoAcciones.Controls.Add(this.btnEliminar);
            this.grupoAcciones.Controls.Add(this.btnEditar);
            this.grupoAcciones.Location = new System.Drawing.Point(691, 14);
            this.grupoAcciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupoAcciones.Size = new System.Drawing.Size(171, 143);
            this.grupoAcciones.TabIndex = 8;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(25, 87);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 38);
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
            this.btnEditar.Location = new System.Drawing.Point(25, 34);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 38);
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
            this.grupoFiltros.Location = new System.Drawing.Point(19, 14);
            this.grupoFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupoFiltros.Name = "grupoFiltros";
            this.grupoFiltros.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupoFiltros.Size = new System.Drawing.Size(669, 143);
            this.grupoFiltros.TabIndex = 7;
            this.grupoFiltros.TabStop = false;
            this.grupoFiltros.Text = "Filtros";
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Controls.Add(this.btnQuitarFiltroNombre);
            this.grupoBuscar.Controls.Add(this.txtBuscarNombre);
            this.grupoBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.grupoBuscar.Location = new System.Drawing.Point(4, 19);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Size = new System.Drawing.Size(245, 120);
            this.grupoBuscar.TabIndex = 1;
            this.grupoBuscar.TabStop = false;
            this.grupoBuscar.Text = "Buscar por Nombre";
            // 
            // btnQuitarFiltroNombre
            // 
            this.btnQuitarFiltroNombre.Location = new System.Drawing.Point(111, 65);
            this.btnQuitarFiltroNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitarFiltroNombre.Name = "btnQuitarFiltroNombre";
            this.btnQuitarFiltroNombre.Size = new System.Drawing.Size(117, 38);
            this.btnQuitarFiltroNombre.TabIndex = 1;
            this.btnQuitarFiltroNombre.Text = "Borrar";
            this.btnQuitarFiltroNombre.UseVisualStyleBackColor = true;
            this.btnQuitarFiltroNombre.Click += new System.EventHandler(this.BtnQuitarFiltroNombreClick);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tablaDatos);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(225, 290);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requisitos";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tablaDatos2);
            this.groupBox2.Location = new System.Drawing.Point(235, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(601, 290);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limites";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(23, 164);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 297);
            this.panel1.TabIndex = 11;
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            this.tablaDatos.AllowUserToOrderColumns = true;
            this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.tablaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDatos.EnableHeadersVisualStyles = false;
            this.tablaDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tablaDatos.Location = new System.Drawing.Point(7, 22);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaDatos.MultiSelect = false;
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowHeadersVisible = false;
            this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(211, 257);
            this.tablaDatos.TabIndex = 7;
            this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
            this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
            // 
            // tablaDatos2
            // 
            this.tablaDatos2.AllowUserToAddRows = false;
            this.tablaDatos2.AllowUserToDeleteRows = false;
            this.tablaDatos2.AllowUserToOrderColumns = true;
            this.tablaDatos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDatos2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDatos2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDatos2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.tablaDatos2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaDatos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos2.DefaultCellStyle = dataGridViewCellStyle5;
            this.tablaDatos2.EnableHeadersVisualStyles = false;
            this.tablaDatos2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tablaDatos2.Location = new System.Drawing.Point(7, 22);
            this.tablaDatos2.Margin = new System.Windows.Forms.Padding(4);
            this.tablaDatos2.MultiSelect = false;
            this.tablaDatos2.Name = "tablaDatos2";
            this.tablaDatos2.ReadOnly = true;
            this.tablaDatos2.RowHeadersVisible = false;
            this.tablaDatos2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDatos2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaDatos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos2.Size = new System.Drawing.Size(587, 257);
            this.tablaDatos2.TabIndex = 7;
            // 
            // ListarRequisitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.grupoFiltros);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(898, 516);
            this.Name = "ListarRequisitos";
            this.Text = "Listado de  Requisitos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarRequisitosFormFormClosing);
            this.grupoAcciones.ResumeLayout(false);
            this.grupoFiltros.ResumeLayout(false);
            this.grupoBuscar.ResumeLayout(false);
            this.grupoBuscar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos2)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.DataGridView tablaDatos2;
    }
}