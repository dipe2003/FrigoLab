namespace FrigLab.View.Ensayos {
    partial class NuevoLaboratorio {
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
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.GrupoTipoLab = new System.Windows.Forms.GroupBox();
        	this.radioButton2 = new System.Windows.Forms.RadioButton();
        	this.radioButton1 = new System.Windows.Forms.RadioButton();
        	this.GrupoTipoLab.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Location = new System.Drawing.Point(25, 199);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(105, 29);
        	this.btnCancelar.TabIndex = 8;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Location = new System.Drawing.Point(147, 199);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(105, 29);
        	this.btnGuardar.TabIndex = 7;
        	this.btnGuardar.Text = "Guardar";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Location = new System.Drawing.Point(25, 56);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(227, 20);
        	this.txtNombre.TabIndex = 6;
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.Location = new System.Drawing.Point(25, 30);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(100, 23);
        	this.lblNombre.TabIndex = 5;
        	this.lblNombre.Text = "Nombre";
        	// 
        	// GrupoTipoLab
        	// 
        	this.GrupoTipoLab.Controls.Add(this.radioButton2);
        	this.GrupoTipoLab.Controls.Add(this.radioButton1);
        	this.GrupoTipoLab.Location = new System.Drawing.Point(25, 85);
        	this.GrupoTipoLab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.GrupoTipoLab.Name = "GrupoTipoLab";
        	this.GrupoTipoLab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.GrupoTipoLab.Size = new System.Drawing.Size(226, 50);
        	this.GrupoTipoLab.TabIndex = 10;
        	this.GrupoTipoLab.TabStop = false;
        	this.GrupoTipoLab.Text = "Tipo de Laboratorio";
        	// 
        	// radioButton2
        	// 
        	this.radioButton2.AutoSize = true;
        	this.radioButton2.Location = new System.Drawing.Point(129, 21);
        	this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.radioButton2.Name = "radioButton2";
        	this.radioButton2.Size = new System.Drawing.Size(61, 17);
        	this.radioButton2.TabIndex = 0;
        	this.radioButton2.TabStop = true;
        	this.radioButton2.Text = "Externo";
        	this.radioButton2.UseVisualStyleBackColor = true;
        	// 
        	// radioButton1
        	// 
        	this.radioButton1.AutoSize = true;
        	this.radioButton1.Location = new System.Drawing.Point(20, 21);
        	this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.radioButton1.Name = "radioButton1";
        	this.radioButton1.Size = new System.Drawing.Size(58, 17);
        	this.radioButton1.TabIndex = 0;
        	this.radioButton1.TabStop = true;
        	this.radioButton1.Text = "Interno";
        	this.radioButton1.UseVisualStyleBackColor = true;
        	// 
        	// NuevoLaboratorio
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
        	this.Name = "NuevoLaboratorio";
        	this.Text = "Registrar Laboratorio";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevaLaboratorioFormFormClosing);
        	this.GrupoTipoLab.ResumeLayout(false);
        	this.GrupoTipoLab.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox GrupoTipoLab;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}