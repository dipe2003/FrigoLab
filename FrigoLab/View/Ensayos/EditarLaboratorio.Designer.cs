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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelInferiorControles = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.GrupoTipoLab.SuspendLayout();
            this.panelInferiorControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrupoTipoLab
            // 
            this.GrupoTipoLab.Controls.Add(this.radioExterno);
            this.GrupoTipoLab.Controls.Add(this.radioInterno);
            this.GrupoTipoLab.Location = new System.Drawing.Point(35, 102);
            this.GrupoTipoLab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrupoTipoLab.Name = "GrupoTipoLab";
            this.GrupoTipoLab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrupoTipoLab.Size = new System.Drawing.Size(301, 62);
            this.GrupoTipoLab.TabIndex = 16;
            this.GrupoTipoLab.TabStop = false;
            this.GrupoTipoLab.Text = "Tipo de Laboratorio";
            // 
            // radioExterno
            // 
            this.radioExterno.AutoSize = true;
            this.radioExterno.Location = new System.Drawing.Point(172, 26);
            this.radioExterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioExterno.Name = "radioExterno";
            this.radioExterno.Size = new System.Drawing.Size(77, 21);
            this.radioExterno.TabIndex = 0;
            this.radioExterno.TabStop = true;
            this.radioExterno.Text = "Externo";
            this.radioExterno.UseVisualStyleBackColor = true;
            // 
            // radioInterno
            // 
            this.radioInterno.AutoSize = true;
            this.radioInterno.Location = new System.Drawing.Point(27, 26);
            this.radioInterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioInterno.Name = "radioInterno";
            this.radioInterno.Size = new System.Drawing.Size(73, 21);
            this.radioInterno.TabIndex = 0;
            this.radioInterno.TabStop = true;
            this.radioInterno.Text = "Interno";
            this.radioInterno.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(301, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(35, 34);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(133, 28);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // panelInferiorControles
            // 
            this.panelInferiorControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panelInferiorControles.Controls.Add(this.btnGuardar);
            this.panelInferiorControles.Controls.Add(this.btnCancelar);
            this.panelInferiorControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferiorControles.Location = new System.Drawing.Point(0, 243);
            this.panelInferiorControles.Name = "panelInferiorControles";
            this.panelInferiorControles.Size = new System.Drawing.Size(371, 68);
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
            this.btnGuardar.Location = new System.Drawing.Point(196, 19);
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
            this.btnCancelar.Location = new System.Drawing.Point(35, 19);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // EditarLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 311);
            this.Controls.Add(this.panelInferiorControles);
            this.Controls.Add(this.GrupoTipoLab);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 358);
            this.MinimumSize = new System.Drawing.Size(389, 358);
            this.Name = "EditarLaboratorio";
            this.Text = "Editar Laboratorio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarLaboratorioFormFormClosing);
            this.GrupoTipoLab.ResumeLayout(false);
            this.GrupoTipoLab.PerformLayout();
            this.panelInferiorControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoTipoLab;
        private System.Windows.Forms.RadioButton radioExterno;
        private System.Windows.Forms.RadioButton radioInterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelInferiorControles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}