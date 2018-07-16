namespace FrigLab.View.Buscar {
    partial class BuscarCodigo {
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxCodigoNumerico = new System.Windows.Forms.TextBox();
            this.textBoxCodigoBarras = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCodigoNumerico
            // 
            this.textBoxCodigoNumerico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.textBoxCodigoNumerico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodigoNumerico.Location = new System.Drawing.Point(22, 138);
            this.textBoxCodigoNumerico.Name = "textBoxCodigoNumerico";
            this.textBoxCodigoNumerico.Size = new System.Drawing.Size(258, 22);
            this.textBoxCodigoNumerico.TabIndex = 0;
            this.textBoxCodigoNumerico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCodigoNumerico.TextChanged += new System.EventHandler(this.textBoxCodigoNumerico_TextChanged);
            // 
            // textBoxCodigoBarras
            // 
            this.textBoxCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.textBoxCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodigoBarras.Font = new System.Drawing.Font("Code 128", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxCodigoBarras.Location = new System.Drawing.Point(22, 25);
            this.textBoxCodigoBarras.Name = "textBoxCodigoBarras";
            this.textBoxCodigoBarras.ReadOnly = true;
            this.textBoxCodigoBarras.Size = new System.Drawing.Size(258, 81);
            this.textBoxCodigoBarras.TabIndex = 0;
            this.textBoxCodigoBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.buttonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.buttonBuscar.Location = new System.Drawing.Point(163, 200);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(117, 38);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.buttonCancelar.Location = new System.Drawing.Point(22, 200);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(117, 38);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // BuscarCodigo
            // 
            this.AcceptButton = this.buttonBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(302, 268);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxCodigoBarras);
            this.Controls.Add(this.textBoxCodigoNumerico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Muestreo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscarCodigo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxCodigoNumerico;
        private System.Windows.Forms.TextBox textBoxCodigoBarras;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}