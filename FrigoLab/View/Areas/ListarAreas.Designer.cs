/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 14/03/2018
 * Hora: 11:54 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FrigLab.View.Areas {
    partial class ListarAreas {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
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
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.grupoVigencia = new System.Windows.Forms.GroupBox();
            this.radioNoVigentes = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioSoloVigentes = new System.Windows.Forms.RadioButton();
            this.grupoFiltros = new System.Windows.Forms.GroupBox();
            this.grupoAcciones = new System.Windows.Forms.GroupBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrarFiltros = new System.Windows.Forms.Button();
            this.grupoBuscar.SuspendLayout();
            this.grupoVigencia.SuspendLayout();
            this.grupoFiltros.SuspendLayout();
            this.grupoAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Controls.Add(this.btnBuscar);
            this.grupoBuscar.Controls.Add(this.btnBorrarFiltros);
            this.grupoBuscar.Controls.Add(this.txtBuscarNombre);
            this.grupoBuscar.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoBuscar.Location = new System.Drawing.Point(214, 15);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Size = new System.Drawing.Size(352, 143);
            this.grupoBuscar.TabIndex = 1;
            this.grupoBuscar.TabStop = false;
            this.grupoBuscar.Text = "Buscar por Nombre";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(13, 33);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(321, 22);
            this.txtBuscarNombre.TabIndex = 0;
            // 
            // grupoVigencia
            // 
            this.grupoVigencia.Controls.Add(this.radioNoVigentes);
            this.grupoVigencia.Controls.Add(this.radioTodos);
            this.grupoVigencia.Controls.Add(this.radioSoloVigentes);
            this.grupoVigencia.Location = new System.Drawing.Point(7, 22);
            this.grupoVigencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoVigencia.Name = "grupoVigencia";
            this.grupoVigencia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoVigencia.Size = new System.Drawing.Size(170, 114);
            this.grupoVigencia.TabIndex = 0;
            this.grupoVigencia.TabStop = false;
            this.grupoVigencia.Text = "Vigencia";
            // 
            // radioNoVigentes
            // 
            this.radioNoVigentes.AutoSize = true;
            this.radioNoVigentes.Location = new System.Drawing.Point(21, 57);
            this.radioNoVigentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioNoVigentes.Name = "radioNoVigentes";
            this.radioNoVigentes.Size = new System.Drawing.Size(138, 21);
            this.radioNoVigentes.TabIndex = 1;
            this.radioNoVigentes.TabStop = true;
            this.radioNoVigentes.Text = "Solo No Vigentes";
            this.radioNoVigentes.UseVisualStyleBackColor = true;
            this.radioNoVigentes.CheckedChanged += new System.EventHandler(this.GrupoVigenciaChange_Click);
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(21, 82);
            this.radioTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(126, 21);
            this.radioTodos.TabIndex = 2;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todas las Areas";
            this.radioTodos.UseVisualStyleBackColor = true;
            this.radioTodos.CheckedChanged += new System.EventHandler(this.GrupoVigenciaChange_Click);
            // 
            // radioSoloVigentes
            // 
            this.radioSoloVigentes.AutoSize = true;
            this.radioSoloVigentes.Location = new System.Drawing.Point(21, 30);
            this.radioSoloVigentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSoloVigentes.Name = "radioSoloVigentes";
            this.radioSoloVigentes.Size = new System.Drawing.Size(115, 21);
            this.radioSoloVigentes.TabIndex = 0;
            this.radioSoloVigentes.TabStop = true;
            this.radioSoloVigentes.Text = "Solo Vigentes";
            this.radioSoloVigentes.UseVisualStyleBackColor = true;
            this.radioSoloVigentes.CheckedChanged += new System.EventHandler(this.GrupoVigenciaChange_Click);
            // 
            // grupoFiltros
            // 
            this.grupoFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoFiltros.Controls.Add(this.grupoVigencia);
            this.grupoFiltros.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoFiltros.Location = new System.Drawing.Point(17, 15);
            this.grupoFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Name = "grupoFiltros";
            this.grupoFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Size = new System.Drawing.Size(190, 143);
            this.grupoFiltros.TabIndex = 1;
            this.grupoFiltros.TabStop = false;
            this.grupoFiltros.Text = "Filtros";
            // 
            // grupoAcciones
            // 
            this.grupoAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoAcciones.Controls.Add(this.btnEliminar);
            this.grupoAcciones.Controls.Add(this.btnEditar);
            this.grupoAcciones.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoAcciones.Location = new System.Drawing.Point(573, 15);
            this.grupoAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Size = new System.Drawing.Size(171, 143);
            this.grupoAcciones.TabIndex = 2;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Acciones";
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
            this.tablaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.tablaDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
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
            this.tablaDatos.Location = new System.Drawing.Point(17, 166);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaDatos.MultiSelect = false;
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowHeadersVisible = false;
            this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(727, 303);
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
            this.btnEliminar.Location = new System.Drawing.Point(27, 84);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 38);
            this.btnEliminar.TabIndex = 16;
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
            this.btnEditar.Location = new System.Drawing.Point(27, 33);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 38);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(217, 84);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 38);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
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
            this.btnBorrarFiltros.Location = new System.Drawing.Point(78, 84);
            this.btnBorrarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarFiltros.Name = "btnBorrarFiltros";
            this.btnBorrarFiltros.Size = new System.Drawing.Size(117, 38);
            this.btnBorrarFiltros.TabIndex = 12;
            this.btnBorrarFiltros.Text = "Borrar";
            this.btnBorrarFiltros.UseVisualStyleBackColor = false;
            this.btnBorrarFiltros.Click += new System.EventHandler(this.BtnQuitarFiltroNombreClick);
            // 
            // ListarAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(764, 482);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.grupoBuscar);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.grupoFiltros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 516);
            this.Name = "ListarAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Areas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarAreasFormFormClosing);
            this.grupoBuscar.ResumeLayout(false);
            this.grupoBuscar.PerformLayout();
            this.grupoVigencia.ResumeLayout(false);
            this.grupoVigencia.PerformLayout();
            this.grupoFiltros.ResumeLayout(false);
            this.grupoAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.GroupBox grupoVigencia;
        private System.Windows.Forms.RadioButton radioNoVigentes;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioSoloVigentes;
        private System.Windows.Forms.GroupBox grupoBuscar;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.GroupBox grupoFiltros;
        private System.Windows.Forms.GroupBox grupoAcciones;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrarFiltros;
    }
}
