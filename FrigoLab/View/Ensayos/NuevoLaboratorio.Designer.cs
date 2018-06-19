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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.GrupoTipoLab = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panelInferiorControles = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.GrupoTipoLab.SuspendLayout();
            this.panelInferiorControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 69);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(301, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(33, 37);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(133, 28);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // GrupoTipoLab
            // 
            this.GrupoTipoLab.Controls.Add(this.radioButton2);
            this.GrupoTipoLab.Controls.Add(this.radioButton1);
            this.GrupoTipoLab.Location = new System.Drawing.Point(33, 105);
            this.GrupoTipoLab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrupoTipoLab.Name = "GrupoTipoLab";
            this.GrupoTipoLab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrupoTipoLab.Size = new System.Drawing.Size(301, 62);
            this.GrupoTipoLab.TabIndex = 10;
            this.GrupoTipoLab.TabStop = false;
            this.GrupoTipoLab.Text = "Tipo de Laboratorio";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(172, 26);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Externo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 26);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Interno";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.btnGuardar.Location = new System.Drawing.Point(212, 19);
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
            // NuevoLaboratorio
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
            this.Name = "NuevoLaboratorio";
            this.Text = "Registrar Laboratorio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevaLaboratorioFormFormClosing);
            this.GrupoTipoLab.ResumeLayout(false);
            this.GrupoTipoLab.PerformLayout();
            this.panelInferiorControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox GrupoTipoLab;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panelInferiorControles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}