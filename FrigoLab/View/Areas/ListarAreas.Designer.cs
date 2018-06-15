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
        private System.Windows.Forms.DataGridView tablaDatos;

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
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.grupoBuscar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuitarFiltroNombre = new System.Windows.Forms.Button();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.grupoVigencia = new System.Windows.Forms.GroupBox();
            this.radioNoVigentes = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioSoloVigentes = new System.Windows.Forms.RadioButton();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grupoFiltros = new System.Windows.Forms.GroupBox();
            this.grupoAcciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.grupoBuscar.SuspendLayout();
            this.grupoVigencia.SuspendLayout();
            this.grupoFiltros.SuspendLayout();
            this.grupoAcciones.SuspendLayout();
            this.SuspendLayout();
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
            this.tablaDatos.Location = new System.Drawing.Point(17, 165);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaDatos.MultiSelect = false;
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowHeadersVisible = false;
            this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(725, 295);
            this.tablaDatos.TabIndex = 0;
            this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
            this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
            // 
            // grupoBuscar
            // 
            this.grupoBuscar.Controls.Add(this.button1);
            this.grupoBuscar.Controls.Add(this.btnQuitarFiltroNombre);
            this.grupoBuscar.Controls.Add(this.txtBuscarNombre);
            this.grupoBuscar.Location = new System.Drawing.Point(214, 15);
            this.grupoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Name = "grupoBuscar";
            this.grupoBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscar.Size = new System.Drawing.Size(352, 143);
            this.grupoBuscar.TabIndex = 1;
            this.grupoBuscar.TabStop = false;
            this.grupoBuscar.Text = "Buscar por Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnQuitarFiltroNombre
            // 
            this.btnQuitarFiltroNombre.Location = new System.Drawing.Point(92, 95);
            this.btnQuitarFiltroNombre.Margin = new System.Windows.Forms.Padding(4);
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
            this.radioTodos.Size = new System.Drawing.Size(132, 21);
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
            this.radioSoloVigentes.Size = new System.Drawing.Size(116, 21);
            this.radioSoloVigentes.TabIndex = 0;
            this.radioSoloVigentes.TabStop = true;
            this.radioSoloVigentes.Text = "Solo Vigentes";
            this.radioSoloVigentes.UseVisualStyleBackColor = true;
            this.radioSoloVigentes.CheckedChanged += new System.EventHandler(this.GrupoVigenciaChange_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(25, 34);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
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
            this.grupoFiltros.Controls.Add(this.grupoVigencia);
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
            this.grupoAcciones.Location = new System.Drawing.Point(573, 15);
            this.grupoAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Size = new System.Drawing.Size(171, 143);
            this.grupoAcciones.TabIndex = 2;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(25, 87);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 38);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
            // 
            // ListarAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 482);
            this.Controls.Add(this.grupoBuscar);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.grupoFiltros);
            this.Controls.Add(this.tablaDatos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 516);
            this.Name = "ListarAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Areas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarAreasFormFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.grupoBuscar.ResumeLayout(false);
            this.grupoBuscar.PerformLayout();
            this.grupoVigencia.ResumeLayout(false);
            this.grupoVigencia.PerformLayout();
            this.grupoFiltros.ResumeLayout(false);
            this.grupoAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grupoVigencia;
        private System.Windows.Forms.RadioButton radioNoVigentes;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioSoloVigentes;
        private System.Windows.Forms.GroupBox grupoBuscar;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.GroupBox grupoFiltros;
        private System.Windows.Forms.GroupBox grupoAcciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnQuitarFiltroNombre;
        private System.Windows.Forms.Button button1;
    }
}
