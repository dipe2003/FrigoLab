namespace FrigoLab.View.Rotulos {
    partial class FormImpresionRotulos {
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
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.labelNivelZoom = new System.Windows.Forms.Label();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.panelInferiorControles = new System.Windows.Forms.Panel();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxImpresion = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBoxImagenImpresora = new System.Windows.Forms.PictureBox();
            this.labelImpresoraSeleccionada = new System.Windows.Forms.Label();
            this.labelCopias = new System.Windows.Forms.Label();
            this.numericUpDownCopias = new System.Windows.Forms.NumericUpDown();
            this.panelPrintPreviewControl = new System.Windows.Forms.Panel();
            this.printPreviewControl = new System.Windows.Forms.PrintPreviewControl();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.panelMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.panelInferiorControles.SuspendLayout();
            this.groupBoxImpresion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenImpresora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopias)).BeginInit();
            this.panelPrintPreviewControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.Controls.Add(this.labelNivelZoom);
            this.panelMenuLateral.Controls.Add(this.trackBarZoom);
            this.panelMenuLateral.Controls.Add(this.panelInferiorControles);
            this.panelMenuLateral.Controls.Add(this.groupBoxImpresion);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(352, 593);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // labelNivelZoom
            // 
            this.labelNivelZoom.AutoSize = true;
            this.labelNivelZoom.Location = new System.Drawing.Point(162, 404);
            this.labelNivelZoom.Name = "labelNivelZoom";
            this.labelNivelZoom.Size = new System.Drawing.Size(20, 17);
            this.labelNivelZoom.TabIndex = 2;
            this.labelNivelZoom.Text = "%";
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.LargeChange = 25;
            this.trackBarZoom.Location = new System.Drawing.Point(12, 365);
            this.trackBarZoom.Maximum = 150;
            this.trackBarZoom.Minimum = 1;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(320, 56);
            this.trackBarZoom.SmallChange = 10;
            this.trackBarZoom.TabIndex = 3;
            this.trackBarZoom.Value = 100;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // panelInferiorControles
            // 
            this.panelInferiorControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInferiorControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panelInferiorControles.Controls.Add(this.buttonImprimir);
            this.panelInferiorControles.Controls.Add(this.buttonCancelar);
            this.panelInferiorControles.Location = new System.Drawing.Point(-5, 525);
            this.panelInferiorControles.Name = "panelInferiorControles";
            this.panelInferiorControles.Size = new System.Drawing.Size(357, 68);
            this.panelInferiorControles.TabIndex = 55;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonImprimir.Location = new System.Drawing.Point(202, 19);
            this.buttonImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(107, 36);
            this.buttonImprimir.TabIndex = 2;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCancelar.Location = new System.Drawing.Point(36, 19);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(107, 36);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // groupBoxImpresion
            // 
            this.groupBoxImpresion.Controls.Add(this.button1);
            this.groupBoxImpresion.Controls.Add(this.btnCerrar);
            this.groupBoxImpresion.Controls.Add(this.pictureBoxImagenImpresora);
            this.groupBoxImpresion.Controls.Add(this.labelImpresoraSeleccionada);
            this.groupBoxImpresion.Controls.Add(this.labelCopias);
            this.groupBoxImpresion.Controls.Add(this.numericUpDownCopias);
            this.groupBoxImpresion.Font = new System.Drawing.Font("Century Gothic", 7.2F);
            this.groupBoxImpresion.Location = new System.Drawing.Point(12, 21);
            this.groupBoxImpresion.Name = "groupBoxImpresion";
            this.groupBoxImpresion.Size = new System.Drawing.Size(320, 299);
            this.groupBoxImpresion.TabIndex = 54;
            this.groupBoxImpresion.TabStop = false;
            this.groupBoxImpresion.Text = "Imprimir";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.button1.Location = new System.Drawing.Point(37, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 53);
            this.button1.TabIndex = 56;
            this.button1.Text = "Seleccionar Impresora";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonSeleccionarImpresora_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnCerrar.Location = new System.Drawing.Point(37, 178);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(239, 53);
            this.btnCerrar.TabIndex = 56;
            this.btnCerrar.Text = "Configurar Pagina";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.buttonConfigPagina_Click);
            // 
            // pictureBoxImagenImpresora
            // 
            this.pictureBoxImagenImpresora.BackgroundImage = global::FrigLab.Properties.Resources.imagen_imprimir_48;
            this.pictureBoxImagenImpresora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxImagenImpresora.Location = new System.Drawing.Point(19, 32);
            this.pictureBoxImagenImpresora.Name = "pictureBoxImagenImpresora";
            this.pictureBoxImagenImpresora.Size = new System.Drawing.Size(51, 50);
            this.pictureBoxImagenImpresora.TabIndex = 4;
            this.pictureBoxImagenImpresora.TabStop = false;
            // 
            // labelImpresoraSeleccionada
            // 
            this.labelImpresoraSeleccionada.AutoSize = true;
            this.labelImpresoraSeleccionada.Location = new System.Drawing.Point(76, 46);
            this.labelImpresoraSeleccionada.Name = "labelImpresoraSeleccionada";
            this.labelImpresoraSeleccionada.Size = new System.Drawing.Size(142, 17);
            this.labelImpresoraSeleccionada.TabIndex = 3;
            this.labelImpresoraSeleccionada.Text = "Seleccionar Impresora";
            // 
            // labelCopias
            // 
            this.labelCopias.AutoSize = true;
            this.labelCopias.Location = new System.Drawing.Point(34, 258);
            this.labelCopias.Name = "labelCopias";
            this.labelCopias.Size = new System.Drawing.Size(49, 17);
            this.labelCopias.TabIndex = 2;
            this.labelCopias.Text = "Copias";
            // 
            // numericUpDownCopias
            // 
            this.numericUpDownCopias.Location = new System.Drawing.Point(156, 253);
            this.numericUpDownCopias.Name = "numericUpDownCopias";
            this.numericUpDownCopias.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCopias.TabIndex = 1;
            this.numericUpDownCopias.ValueChanged += new System.EventHandler(this.numericUpDownCopias_ValueChanged);
            // 
            // panelPrintPreviewControl
            // 
            this.panelPrintPreviewControl.Controls.Add(this.printPreviewControl);
            this.panelPrintPreviewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrintPreviewControl.Location = new System.Drawing.Point(352, 0);
            this.panelPrintPreviewControl.Name = "panelPrintPreviewControl";
            this.panelPrintPreviewControl.Size = new System.Drawing.Size(630, 593);
            this.panelPrintPreviewControl.TabIndex = 1;
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.AutoZoom = false;
            this.printPreviewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControl.Location = new System.Drawing.Point(0, 0);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(630, 593);
            this.printPreviewControl.TabIndex = 53;
            this.printPreviewControl.Zoom = 0.43090909090909091D;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // FormImpresionRotulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(982, 593);
            this.Controls.Add(this.panelPrintPreviewControl);
            this.Controls.Add(this.panelMenuLateral);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "FormImpresionRotulos";
            this.Text = "Imprimir Rotulo";
            this.Load += new System.EventHandler(this.FormImpresionRotulos_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.panelInferiorControles.ResumeLayout(false);
            this.groupBoxImpresion.ResumeLayout(false);
            this.groupBoxImpresion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenImpresora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopias)).EndInit();
            this.panelPrintPreviewControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelInferiorControles;
        protected System.Windows.Forms.Button buttonImprimir;
        protected System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBoxImpresion;
        private System.Windows.Forms.Panel panelPrintPreviewControl;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.Label labelCopias;
        private System.Windows.Forms.NumericUpDown numericUpDownCopias;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.Label labelNivelZoom;
        private System.Windows.Forms.PictureBox pictureBoxImagenImpresora;
        private System.Windows.Forms.Label labelImpresoraSeleccionada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
    }
}