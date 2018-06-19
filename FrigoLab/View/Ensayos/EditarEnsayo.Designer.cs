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
            this.panelInferiorControles = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.GrupoTipoAnalisis.SuspendLayout();
            this.grupoClaseMuestra.SuspendLayout();
            this.panelInferiorControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMetodo
            // 
            this.txtMetodo.Location = new System.Drawing.Point(35, 101);
            this.txtMetodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMetodo.Name = "txtMetodo";
            this.txtMetodo.Size = new System.Drawing.Size(409, 22);
            this.txtMetodo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Metodo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 46);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(409, 22);
            this.txtNombre.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(35, 21);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(133, 21);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // GrupoTipoAnalisis
            // 
            this.GrupoTipoAnalisis.Controls.Add(this.RadioRecuento);
            this.GrupoTipoAnalisis.Controls.Add(this.RadioMarginal);
            this.GrupoTipoAnalisis.Controls.Add(this.RadioBusqueda);
            this.GrupoTipoAnalisis.Location = new System.Drawing.Point(35, 135);
            this.GrupoTipoAnalisis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrupoTipoAnalisis.Name = "GrupoTipoAnalisis";
            this.GrupoTipoAnalisis.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrupoTipoAnalisis.Size = new System.Drawing.Size(199, 108);
            this.GrupoTipoAnalisis.TabIndex = 27;
            this.GrupoTipoAnalisis.TabStop = false;
            this.GrupoTipoAnalisis.Text = "Tipo";
            // 
            // RadioRecuento
            // 
            this.RadioRecuento.AutoSize = true;
            this.RadioRecuento.Location = new System.Drawing.Point(13, 78);
            this.RadioRecuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioRecuento.Name = "RadioRecuento";
            this.RadioRecuento.Size = new System.Drawing.Size(90, 21);
            this.RadioRecuento.TabIndex = 3;
            this.RadioRecuento.TabStop = true;
            this.RadioRecuento.Text = "Recuento";
            this.RadioRecuento.UseVisualStyleBackColor = true;
            // 
            // RadioMarginal
            // 
            this.RadioMarginal.AutoSize = true;
            this.RadioMarginal.Location = new System.Drawing.Point(13, 52);
            this.RadioMarginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioMarginal.Name = "RadioMarginal";
            this.RadioMarginal.Size = new System.Drawing.Size(185, 21);
            this.RadioMarginal.TabIndex = 1;
            this.RadioMarginal.TabStop = true;
            this.RadioMarginal.Text = "Recuento (con Marginal)";
            this.RadioMarginal.UseVisualStyleBackColor = true;
            // 
            // RadioBusqueda
            // 
            this.RadioBusqueda.AutoSize = true;
            this.RadioBusqueda.Location = new System.Drawing.Point(13, 26);
            this.RadioBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioBusqueda.Name = "RadioBusqueda";
            this.RadioBusqueda.Size = new System.Drawing.Size(93, 21);
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
            this.grupoClaseMuestra.Location = new System.Drawing.Point(239, 135);
            this.grupoClaseMuestra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoClaseMuestra.Name = "grupoClaseMuestra";
            this.grupoClaseMuestra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoClaseMuestra.Size = new System.Drawing.Size(205, 108);
            this.grupoClaseMuestra.TabIndex = 28;
            this.grupoClaseMuestra.TabStop = false;
            this.grupoClaseMuestra.Text = "Clase";
            // 
            // radioOtra
            // 
            this.radioOtra.AutoSize = true;
            this.radioOtra.Location = new System.Drawing.Point(115, 55);
            this.radioOtra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioOtra.Name = "radioOtra";
            this.radioOtra.Size = new System.Drawing.Size(57, 21);
            this.radioOtra.TabIndex = 4;
            this.radioOtra.TabStop = true;
            this.radioOtra.Text = "Otra";
            this.radioOtra.UseVisualStyleBackColor = true;
            // 
            // radioSuperficie
            // 
            this.radioSuperficie.AutoSize = true;
            this.radioSuperficie.Location = new System.Drawing.Point(17, 75);
            this.radioSuperficie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSuperficie.Name = "radioSuperficie";
            this.radioSuperficie.Size = new System.Drawing.Size(92, 21);
            this.radioSuperficie.TabIndex = 3;
            this.radioSuperficie.TabStop = true;
            this.radioSuperficie.Text = "Superficie";
            this.radioSuperficie.UseVisualStyleBackColor = true;
            // 
            // radioAmbiente
            // 
            this.radioAmbiente.AutoSize = true;
            this.radioAmbiente.Location = new System.Drawing.Point(17, 50);
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
            this.radioOperario.Location = new System.Drawing.Point(115, 30);
            this.radioOperario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioOperario.Name = "radioOperario";
            this.radioOperario.Size = new System.Drawing.Size(85, 21);
            this.radioOperario.TabIndex = 2;
            this.radioOperario.TabStop = true;
            this.radioOperario.Text = "Operario";
            this.radioOperario.UseVisualStyleBackColor = true;
            // 
            // radioProducto
            // 
            this.radioProducto.AutoSize = true;
            this.radioProducto.Location = new System.Drawing.Point(17, 30);
            this.radioProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioProducto.Name = "radioProducto";
            this.radioProducto.Size = new System.Drawing.Size(86, 21);
            this.radioProducto.TabIndex = 0;
            this.radioProducto.TabStop = true;
            this.radioProducto.Text = "Producto";
            this.radioProducto.UseVisualStyleBackColor = true;
            // 
            // panelInferiorControles
            // 
            this.panelInferiorControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panelInferiorControles.Controls.Add(this.btnGuardar);
            this.panelInferiorControles.Controls.Add(this.btnCancelar);
            this.panelInferiorControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferiorControles.Location = new System.Drawing.Point(0, 293);
            this.panelInferiorControles.Name = "panelInferiorControles";
            this.panelInferiorControles.Size = new System.Drawing.Size(467, 68);
            this.panelInferiorControles.TabIndex = 52;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.Location = new System.Drawing.Point(304, 19);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 36);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Location = new System.Drawing.Point(36, 19);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // EditarEnsayo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 361);
            this.Controls.Add(this.panelInferiorControles);
            this.Controls.Add(this.grupoClaseMuestra);
            this.Controls.Add(this.GrupoTipoAnalisis);
            this.Controls.Add(this.txtMetodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 408);
            this.MinimumSize = new System.Drawing.Size(485, 408);
            this.Name = "EditarEnsayo";
            this.Text = "Editar Ensayo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarLaboratorioFormFormClosing);
            this.GrupoTipoAnalisis.ResumeLayout(false);
            this.GrupoTipoAnalisis.PerformLayout();
            this.grupoClaseMuestra.ResumeLayout(false);
            this.grupoClaseMuestra.PerformLayout();
            this.panelInferiorControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel panelInferiorControles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}