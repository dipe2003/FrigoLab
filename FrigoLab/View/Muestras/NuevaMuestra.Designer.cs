namespace FrigLab.View.Muestras {
    partial class NuevaMuestra {
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.cboTipos = new System.Windows.Forms.ComboBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.btnGuardar = new System.Windows.Forms.Button();
        	this.chkListAreas = new System.Windows.Forms.CheckedListBox();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(32, 24);
        	this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(44, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Nombre";
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Location = new System.Drawing.Point(32, 40);
        	this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(235, 20);
        	this.txtNombre.TabIndex = 1;
        	this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(32, 76);
        	this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(29, 13);
        	this.label2.TabIndex = 3;
        	this.label2.Text = "Area";
        	// 
        	// cboTipos
        	// 
        	this.cboTipos.FormattingEnabled = true;
        	this.cboTipos.Location = new System.Drawing.Point(32, 197);
        	this.cboTipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.cboTipos.Name = "cboTipos";
        	this.cboTipos.Size = new System.Drawing.Size(235, 21);
        	this.cboTipos.TabIndex = 2;
        	this.cboTipos.SelectedIndexChanged += new System.EventHandler(this.cboTipos_SelectedIndexChanged);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(32, 181);
        	this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(84, 13);
        	this.label3.TabIndex = 3;
        	this.label3.Text = "Tipo de Muestra";
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Location = new System.Drawing.Point(32, 253);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(105, 29);
        	this.btnCancelar.TabIndex = 13;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Location = new System.Drawing.Point(160, 253);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(105, 29);
        	this.btnGuardar.TabIndex = 12;
        	this.btnGuardar.Text = "Guardar";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
        	// 
        	// chkListAreas
        	// 
        	this.chkListAreas.FormattingEnabled = true;
        	this.chkListAreas.Location = new System.Drawing.Point(32, 92);
        	this.chkListAreas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.chkListAreas.Name = "chkListAreas";
        	this.chkListAreas.Size = new System.Drawing.Size(235, 64);
        	this.chkListAreas.TabIndex = 15;
        	this.chkListAreas.SelectedValueChanged += new System.EventHandler(this.ChkListBox_SelectedIndexChanged);
        	// 
        	// NuevaMuestra
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(296, 302);
        	this.Controls.Add(this.chkListAreas);
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnGuardar);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.cboTipos);
        	this.Controls.Add(this.txtNombre);
        	this.Controls.Add(this.label1);
        	this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.MaximizeBox = false;
        	this.MaximumSize = new System.Drawing.Size(312, 340);
        	this.MinimumSize = new System.Drawing.Size(312, 340);
        	this.Name = "NuevaMuestra";
        	this.Text = "Nueva Muestra";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevaMuestraForm_FormClosing);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckedListBox chkListAreas;
    }
}