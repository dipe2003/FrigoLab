namespace FrigLab.View.Ensayos {
    partial class EditarLaboratorio {
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
        	this.GrupoTipoLab = new System.Windows.Forms.GroupBox();
        	this.radioExterno = new System.Windows.Forms.RadioButton();
        	this.radioInterno = new System.Windows.Forms.RadioButton();
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.btnGuardar = new System.Windows.Forms.Button();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.GrupoTipoLab.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// GrupoTipoLab
        	// 
        	this.GrupoTipoLab.Controls.Add(this.radioExterno);
        	this.GrupoTipoLab.Controls.Add(this.radioInterno);
        	this.GrupoTipoLab.Location = new System.Drawing.Point(26, 83);
        	this.GrupoTipoLab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.GrupoTipoLab.Name = "GrupoTipoLab";
        	this.GrupoTipoLab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.GrupoTipoLab.Size = new System.Drawing.Size(226, 50);
        	this.GrupoTipoLab.TabIndex = 16;
        	this.GrupoTipoLab.TabStop = false;
        	this.GrupoTipoLab.Text = "Tipo de Laboratorio";
        	// 
        	// radioExterno
        	// 
        	this.radioExterno.AutoSize = true;
        	this.radioExterno.Location = new System.Drawing.Point(129, 21);
        	this.radioExterno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.radioExterno.Name = "radioExterno";
        	this.radioExterno.Size = new System.Drawing.Size(61, 17);
        	this.radioExterno.TabIndex = 0;
        	this.radioExterno.TabStop = true;
        	this.radioExterno.Text = "Externo";
        	this.radioExterno.UseVisualStyleBackColor = true;
        	// 
        	// radioInterno
        	// 
        	this.radioInterno.AutoSize = true;
        	this.radioInterno.Location = new System.Drawing.Point(20, 21);
        	this.radioInterno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.radioInterno.Name = "radioInterno";
        	this.radioInterno.Size = new System.Drawing.Size(58, 17);
        	this.radioInterno.TabIndex = 0;
        	this.radioInterno.TabStop = true;
        	this.radioInterno.Text = "Interno";
        	this.radioInterno.UseVisualStyleBackColor = true;
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Location = new System.Drawing.Point(26, 197);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(105, 29);
        	this.btnCancelar.TabIndex = 14;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Location = new System.Drawing.Point(148, 197);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(105, 29);
        	this.btnGuardar.TabIndex = 13;
        	this.btnGuardar.Text = "Guardar";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Location = new System.Drawing.Point(26, 54);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(227, 20);
        	this.txtNombre.TabIndex = 12;
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.Location = new System.Drawing.Point(26, 28);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(100, 23);
        	this.lblNombre.TabIndex = 11;
        	this.lblNombre.Text = "Nombre";
        	// 
        	// EditarLaboratorio
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(280, 262);
        	this.Controls.Add(this.GrupoTipoLab);
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnGuardar);
        	this.Controls.Add(this.txtNombre);
        	this.Controls.Add(this.lblNombre);
        	this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.MaximizeBox = false;
        	this.MaximumSize = new System.Drawing.Size(296, 300);
        	this.MinimumSize = new System.Drawing.Size(296, 300);
        	this.Name = "EditarLaboratorio";
        	this.Text = "Editar Laboratorio";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarLaboratorioFormFormClosing);
        	this.GrupoTipoLab.ResumeLayout(false);
        	this.GrupoTipoLab.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoTipoLab;
        private System.Windows.Forms.RadioButton radioExterno;
        private System.Windows.Forms.RadioButton radioInterno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}