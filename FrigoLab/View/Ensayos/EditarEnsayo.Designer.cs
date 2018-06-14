namespace FrigLab.View.Ensayos {
    partial class EditarEnsayo {
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
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.btnGuardar = new System.Windows.Forms.Button();
        	this.txtMetodo = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.GrupoTipoAnalisis = new System.Windows.Forms.GroupBox();
        	this.RadioRecuento = new System.Windows.Forms.RadioButton();
        	this.RadioMarginal = new System.Windows.Forms.RadioButton();
        	this.RadioBusqueda = new System.Windows.Forms.RadioButton();
        	this.grupoClaseMuestra = new System.Windows.Forms.GroupBox();
        	this.radioOtra = new System.Windows.Forms.RadioButton();
        	this.radioSuperficie = new System.Windows.Forms.RadioButton();
        	this.radioAmbiente = new System.Windows.Forms.RadioButton();
        	this.radioOperario = new System.Windows.Forms.RadioButton();
        	this.radioProducto = new System.Windows.Forms.RadioButton();
        	this.GrupoTipoAnalisis.SuspendLayout();
        	this.grupoClaseMuestra.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Location = new System.Drawing.Point(26, 255);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(105, 29);
        	this.btnCancelar.TabIndex = 18;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Location = new System.Drawing.Point(228, 255);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(105, 29);
        	this.btnGuardar.TabIndex = 17;
        	this.btnGuardar.Text = "Guardar";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
        	// 
        	// txtMetodo
        	// 
        	this.txtMetodo.Location = new System.Drawing.Point(26, 82);
        	this.txtMetodo.Name = "txtMetodo";
        	this.txtMetodo.Size = new System.Drawing.Size(308, 20);
        	this.txtMetodo.TabIndex = 15;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(26, 63);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(100, 15);
        	this.label1.TabIndex = 13;
        	this.label1.Text = "Metodo";
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Location = new System.Drawing.Point(26, 37);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(308, 20);
        	this.txtNombre.TabIndex = 16;
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.Location = new System.Drawing.Point(26, 17);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(100, 17);
        	this.lblNombre.TabIndex = 14;
        	this.lblNombre.Text = "Nombre";
        	// 
        	// GrupoTipoAnalisis
        	// 
        	this.GrupoTipoAnalisis.Controls.Add(this.RadioRecuento);
        	this.GrupoTipoAnalisis.Controls.Add(this.RadioMarginal);
        	this.GrupoTipoAnalisis.Controls.Add(this.RadioBusqueda);
        	this.GrupoTipoAnalisis.Location = new System.Drawing.Point(26, 110);
        	this.GrupoTipoAnalisis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.GrupoTipoAnalisis.Name = "GrupoTipoAnalisis";
        	this.GrupoTipoAnalisis.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.GrupoTipoAnalisis.Size = new System.Drawing.Size(149, 88);
        	this.GrupoTipoAnalisis.TabIndex = 27;
        	this.GrupoTipoAnalisis.TabStop = false;
        	this.GrupoTipoAnalisis.Text = "Tipo";
        	// 
        	// RadioRecuento
        	// 
        	this.RadioRecuento.AutoSize = true;
        	this.RadioRecuento.Location = new System.Drawing.Point(10, 63);
        	this.RadioRecuento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.RadioRecuento.Name = "RadioRecuento";
        	this.RadioRecuento.Size = new System.Drawing.Size(72, 17);
        	this.RadioRecuento.TabIndex = 3;
        	this.RadioRecuento.TabStop = true;
        	this.RadioRecuento.Text = "Recuento";
        	this.RadioRecuento.UseVisualStyleBackColor = true;
        	// 
        	// RadioMarginal
        	// 
        	this.RadioMarginal.AutoSize = true;
        	this.RadioMarginal.Location = new System.Drawing.Point(10, 42);
        	this.RadioMarginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.RadioMarginal.Name = "RadioMarginal";
        	this.RadioMarginal.Size = new System.Drawing.Size(142, 17);
        	this.RadioMarginal.TabIndex = 1;
        	this.RadioMarginal.TabStop = true;
        	this.RadioMarginal.Text = "Recuento (con Marginal)";
        	this.RadioMarginal.UseVisualStyleBackColor = true;
        	// 
        	// RadioBusqueda
        	// 
        	this.RadioBusqueda.AutoSize = true;
        	this.RadioBusqueda.Location = new System.Drawing.Point(10, 21);
        	this.RadioBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.RadioBusqueda.Name = "RadioBusqueda";
        	this.RadioBusqueda.Size = new System.Drawing.Size(73, 17);
        	this.RadioBusqueda.TabIndex = 0;
        	this.RadioBusqueda.TabStop = true;
        	this.RadioBusqueda.Text = "Busqueda";
        	this.RadioBusqueda.UseVisualStyleBackColor = true;
        	// 
        	// grupoClaseMuestra
        	// 
        	this.grupoClaseMuestra.Controls.Add(this.radioOtra);
        	this.grupoClaseMuestra.Controls.Add(this.radioSuperficie);
        	this.grupoClaseMuestra.Controls.Add(this.radioAmbiente);
        	this.grupoClaseMuestra.Controls.Add(this.radioOperario);
        	this.grupoClaseMuestra.Controls.Add(this.radioProducto);
        	this.grupoClaseMuestra.Location = new System.Drawing.Point(179, 110);
        	this.grupoClaseMuestra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.grupoClaseMuestra.Name = "grupoClaseMuestra";
        	this.grupoClaseMuestra.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.grupoClaseMuestra.Size = new System.Drawing.Size(154, 88);
        	this.grupoClaseMuestra.TabIndex = 28;
        	this.grupoClaseMuestra.TabStop = false;
        	this.grupoClaseMuestra.Text = "Clase";
        	// 
        	// radioOtra
        	// 
        	this.radioOtra.AutoSize = true;
        	this.radioOtra.Location = new System.Drawing.Point(86, 45);
        	this.radioOtra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.radioOtra.Name = "radioOtra";
        	this.radioOtra.Size = new System.Drawing.Size(45, 17);
        	this.radioOtra.TabIndex = 4;
        	this.radioOtra.TabStop = true;
        	this.radioOtra.Text = "Otra";
        	this.radioOtra.UseVisualStyleBackColor = true;
        	// 
        	// radioSuperficie
        	// 
        	this.radioSuperficie.AutoSize = true;
        	this.radioSuperficie.Location = new System.Drawing.Point(13, 61);
        	this.radioSuperficie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.radioSuperficie.Name = "radioSuperficie";
        	this.radioSuperficie.Size = new System.Drawing.Size(72, 17);
        	this.radioSuperficie.TabIndex = 3;
        	this.radioSuperficie.TabStop = true;
        	this.radioSuperficie.Text = "Superficie";
        	this.radioSuperficie.UseVisualStyleBackColor = true;
        	// 
        	// radioAmbiente
        	// 
        	this.radioAmbiente.AutoSize = true;
        	this.radioAmbiente.Location = new System.Drawing.Point(13, 41);
        	this.radioAmbiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.radioAmbiente.Name = "radioAmbiente";
        	this.radioAmbiente.Size = new System.Drawing.Size(69, 17);
        	this.radioAmbiente.TabIndex = 1;
        	this.radioAmbiente.TabStop = true;
        	this.radioAmbiente.Text = "Ambiente";
        	this.radioAmbiente.UseVisualStyleBackColor = true;
        	// 
        	// radioOperario
        	// 
        	this.radioOperario.AutoSize = true;
        	this.radioOperario.Location = new System.Drawing.Point(86, 24);
        	this.radioOperario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.radioOperario.Name = "radioOperario";
        	this.radioOperario.Size = new System.Drawing.Size(65, 17);
        	this.radioOperario.TabIndex = 2;
        	this.radioOperario.TabStop = true;
        	this.radioOperario.Text = "Operario";
        	this.radioOperario.UseVisualStyleBackColor = true;
        	// 
        	// radioProducto
        	// 
        	this.radioProducto.AutoSize = true;
        	this.radioProducto.Location = new System.Drawing.Point(13, 24);
        	this.radioProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.radioProducto.Name = "radioProducto";
        	this.radioProducto.Size = new System.Drawing.Size(68, 17);
        	this.radioProducto.TabIndex = 0;
        	this.radioProducto.TabStop = true;
        	this.radioProducto.Text = "Producto";
        	this.radioProducto.UseVisualStyleBackColor = true;
        	// 
        	// EditarEnsayo
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(352, 302);
        	this.Controls.Add(this.grupoClaseMuestra);
        	this.Controls.Add(this.GrupoTipoAnalisis);
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnGuardar);
        	this.Controls.Add(this.txtMetodo);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.txtNombre);
        	this.Controls.Add(this.lblNombre);
        	this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.MaximizeBox = false;
        	this.MaximumSize = new System.Drawing.Size(368, 340);
        	this.MinimumSize = new System.Drawing.Size(368, 340);
        	this.Name = "EditarEnsayo";
        	this.Text = "Editar Ensayo";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarLaboratorioFormFormClosing);
        	this.GrupoTipoAnalisis.ResumeLayout(false);
        	this.GrupoTipoAnalisis.PerformLayout();
        	this.grupoClaseMuestra.ResumeLayout(false);
        	this.grupoClaseMuestra.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtMetodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox GrupoTipoAnalisis;
        private System.Windows.Forms.RadioButton RadioRecuento;
        private System.Windows.Forms.RadioButton RadioMarginal;
        private System.Windows.Forms.RadioButton RadioBusqueda;
        private System.Windows.Forms.GroupBox grupoClaseMuestra;
        private System.Windows.Forms.RadioButton radioOtra;
        private System.Windows.Forms.RadioButton radioSuperficie;
        private System.Windows.Forms.RadioButton radioAmbiente;
        private System.Windows.Forms.RadioButton radioOperario;
        private System.Windows.Forms.RadioButton radioProducto;
    }
}