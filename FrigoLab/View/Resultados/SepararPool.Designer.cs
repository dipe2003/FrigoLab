/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 16/05/2018
 * Hora: 11:41 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FrigLab.View.Resultados
{
	partial class SepararPool
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cboLaboratorios;
		
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
            this.label11 = new System.Windows.Forms.Label();
            this.cboLaboratorios = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAbrirPool = new System.Windows.Forms.Button();
            this.panelInferiorControles = new System.Windows.Forms.Panel();
            this.panelInferiorControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Laboratorio";
            // 
            // cboLaboratorios
            // 
            this.cboLaboratorios.FormattingEnabled = true;
            this.cboLaboratorios.Location = new System.Drawing.Point(15, 44);
            this.cboLaboratorios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLaboratorios.Name = "cboLaboratorios";
            this.cboLaboratorios.Size = new System.Drawing.Size(348, 24);
            this.cboLaboratorios.TabIndex = 35;
            this.cboLaboratorios.SelectedValueChanged += new System.EventHandler(this.CboLaboratorios_SelectedValueChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Location = new System.Drawing.Point(50, 19);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 36);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // btnAbrirPool
            // 
            this.btnAbrirPool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirPool.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAbrirPool.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbrirPool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnAbrirPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirPool.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPool.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAbrirPool.Location = new System.Drawing.Point(223, 19);
            this.btnAbrirPool.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirPool.Name = "btnAbrirPool";
            this.btnAbrirPool.Size = new System.Drawing.Size(140, 36);
            this.btnAbrirPool.TabIndex = 44;
            this.btnAbrirPool.Text = "Separar";
            this.btnAbrirPool.UseVisualStyleBackColor = false;
            this.btnAbrirPool.Click += new System.EventHandler(this.BtnAbrirPoolClick);
            // 
            // panelInferiorControles
            // 
            this.panelInferiorControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panelInferiorControles.Controls.Add(this.btnAbrirPool);
            this.panelInferiorControles.Controls.Add(this.btnCancelar);
            this.panelInferiorControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferiorControles.Location = new System.Drawing.Point(0, 96);
            this.panelInferiorControles.Name = "panelInferiorControles";
            this.panelInferiorControles.Size = new System.Drawing.Size(379, 68);
            this.panelInferiorControles.TabIndex = 52;
            // 
            // SepararPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(379, 164);
            this.ControlBox = false;
            this.Controls.Add(this.panelInferiorControles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboLaboratorios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SepararPool";
            this.Text = "Separar Pool";
            this.TopMost = true;
            this.panelInferiorControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAbrirPool;
        private System.Windows.Forms.Panel panelInferiorControles;
    }
}
