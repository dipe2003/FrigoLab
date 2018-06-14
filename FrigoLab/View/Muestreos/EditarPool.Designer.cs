/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 09/05/2018
 * Hora: 09:47 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FrigLab.View.Muestreos
{
	partial class EditarPool
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnNuevoMuestreo;
		private System.Windows.Forms.Button btnReiniciar;
		private System.Windows.Forms.Button btnQuitarMuestreo;
		private System.Windows.Forms.Button btnAgregarMuestreo;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DataGridView tablaMuestreosAgregados;
		private System.Windows.Forms.DataGridView tablaDatos;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker pickerFechaPool;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevoMuestreo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnQuitarMuestreo = new System.Windows.Forms.Button();
            this.btnAgregarMuestreo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tablaMuestreosAgregados = new System.Windows.Forms.DataGridView();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pickerFechaPool = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarPool = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMuestreosAgregados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoMuestreo
            // 
            this.btnNuevoMuestreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoMuestreo.Location = new System.Drawing.Point(520, 357);
            this.btnNuevoMuestreo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoMuestreo.Name = "btnNuevoMuestreo";
            this.btnNuevoMuestreo.Size = new System.Drawing.Size(77, 36);
            this.btnNuevoMuestreo.TabIndex = 47;
            this.btnNuevoMuestreo.Text = "Nuevo";
            this.btnNuevoMuestreo.UseVisualStyleBackColor = true;
            this.btnNuevoMuestreo.Click += new System.EventHandler(this.BtnNuevoMuestreoClick);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciar.Location = new System.Drawing.Point(520, 287);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(77, 36);
            this.btnReiniciar.TabIndex = 48;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciarClick);
            // 
            // btnQuitarMuestreo
            // 
            this.btnQuitarMuestreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarMuestreo.Location = new System.Drawing.Point(520, 209);
            this.btnQuitarMuestreo.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitarMuestreo.Name = "btnQuitarMuestreo";
            this.btnQuitarMuestreo.Size = new System.Drawing.Size(77, 36);
            this.btnQuitarMuestreo.TabIndex = 49;
            this.btnQuitarMuestreo.Text = "<<";
            this.btnQuitarMuestreo.UseVisualStyleBackColor = true;
            this.btnQuitarMuestreo.Click += new System.EventHandler(this.BtnAgregarMuestreoClick);
            // 
            // btnAgregarMuestreo
            // 
            this.btnAgregarMuestreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMuestreo.Location = new System.Drawing.Point(520, 140);
            this.btnAgregarMuestreo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMuestreo.Name = "btnAgregarMuestreo";
            this.btnAgregarMuestreo.Size = new System.Drawing.Size(77, 36);
            this.btnAgregarMuestreo.TabIndex = 50;
            this.btnAgregarMuestreo.Text = ">>";
            this.btnAgregarMuestreo.UseVisualStyleBackColor = true;
            this.btnAgregarMuestreo.Click += new System.EventHandler(this.BtnQuitarMuestreoClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(777, 454);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 36);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(955, 454);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 36);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.tablaMuestreosAgregados.Location = new System.Drawing.Point(17, 95);
            this.tablaMuestreosAgregados.Margin = new System.Windows.Forms.Padding(5);
            this.tablaMuestreosAgregados.MultiSelect = false;
            this.tablaMuestreosAgregados.Name = "tablaMuestreosAgregados";
            this.tablaMuestreosAgregados.ReadOnly = true;
            this.tablaMuestreosAgregados.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMuestreosAgregados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaMuestreosAgregados.RowTemplate.ReadOnly = true;
            this.tablaMuestreosAgregados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMuestreosAgregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaMuestreosAgregados.Size = new System.Drawing.Size(488, 336);
            this.tablaMuestreosAgregados.TabIndex = 44;
            this.tablaMuestreosAgregados.CurrentCellChanged += new System.EventHandler(this.TablaMuestreosAgregados_SelectionChanged);
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
            this.tablaDatos.Location = new System.Drawing.Point(607, 95);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(5);
            this.tablaDatos.MultiSelect = false;
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaDatos.RowTemplate.ReadOnly = true;
            this.tablaDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(488, 336);
            this.tablaDatos.TabIndex = 45;
            this.tablaDatos.CurrentCellChanged += new System.EventHandler(this.TablaDatos_SelectionChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(237, 32);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(363, 22);
            this.txtDescripcion.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Descripcion de Pool";
            // 
            // pickerFechaPool
            // 
            this.pickerFechaPool.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerFechaPool.Location = new System.Drawing.Point(17, 32);
            this.pickerFechaPool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerFechaPool.Name = "pickerFechaPool";
            this.pickerFechaPool.Size = new System.Drawing.Size(200, 22);
            this.pickerFechaPool.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Muestreos en Pool";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Muestreos Disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fecha de Pool";
            // 
            // btnEliminarPool
            // 
            this.btnEliminarPool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPool.Location = new System.Drawing.Point(607, 454);
            this.btnEliminarPool.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPool.Name = "btnEliminarPool";
            this.btnEliminarPool.Size = new System.Drawing.Size(140, 36);
            this.btnEliminarPool.TabIndex = 51;
            this.btnEliminarPool.Text = "Eliminar";
            this.btnEliminarPool.UseVisualStyleBackColor = true;
            this.btnEliminarPool.Click += new System.EventHandler(this.BtnEliminarPool_Click);
            // 
            // EditarPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 538);
            this.Controls.Add(this.btnNuevoMuestreo);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnQuitarMuestreo);
            this.Controls.Add(this.btnAgregarMuestreo);
            this.Controls.Add(this.btnEliminarPool);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarPool";
            this.Text = "EditarPool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarPoolFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMuestreosAgregados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btnEliminarPool;
    }
}
