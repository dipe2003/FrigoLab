namespace FrigLab.View.Requisitos {
    partial class EditarRequisito {
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
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.btnGuardar = new System.Windows.Forms.Button();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.tablaDatos = new System.Windows.Forms.DataGridView();
        	this.btnQuitarLimite = new System.Windows.Forms.Button();
        	this.btnDefinirLimite = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnCancelar.Location = new System.Drawing.Point(205, 288);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(105, 29);
        	this.btnCancelar.TabIndex = 23;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnGuardar.Location = new System.Drawing.Point(316, 288);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(105, 29);
        	this.btnGuardar.TabIndex = 22;
        	this.btnGuardar.Text = "Guardar";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Location = new System.Drawing.Point(26, 47);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(227, 20);
        	this.txtNombre.TabIndex = 21;
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.Location = new System.Drawing.Point(26, 21);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(100, 23);
        	this.lblNombre.TabIndex = 20;
        	this.lblNombre.Text = "Nombre";
        	// 
        	// tablaDatos
        	// 
        	this.tablaDatos.AllowUserToAddRows = false;
        	this.tablaDatos.AllowUserToDeleteRows = false;
        	this.tablaDatos.AllowUserToOrderColumns = true;
        	this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.tablaDatos.BackgroundColor = System.Drawing.SystemColors.Control;
        	this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        	dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
        	dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
        	dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.tablaDatos.DefaultCellStyle = dataGridViewCellStyle1;
        	this.tablaDatos.Location = new System.Drawing.Point(26, 72);
        	this.tablaDatos.MultiSelect = false;
        	this.tablaDatos.Name = "tablaDatos";
        	this.tablaDatos.ReadOnly = true;
        	this.tablaDatos.RowHeadersVisible = false;
        	this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.tablaDatos.Size = new System.Drawing.Size(394, 154);
        	this.tablaDatos.TabIndex = 31;
        	this.tablaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatos_CellClick);
        	// 
        	// btnQuitarLimite
        	// 
        	this.btnQuitarLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnQuitarLimite.Location = new System.Drawing.Point(218, 232);
        	this.btnQuitarLimite.Name = "btnQuitarLimite";
        	this.btnQuitarLimite.Size = new System.Drawing.Size(82, 29);
        	this.btnQuitarLimite.TabIndex = 29;
        	this.btnQuitarLimite.Text = "Quitar Limite";
        	this.btnQuitarLimite.UseVisualStyleBackColor = true;
        	this.btnQuitarLimite.Click += new System.EventHandler(this.BntQuitarLimiteClick);
        	// 
        	// btnDefinirLimite
        	// 
        	this.btnDefinirLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnDefinirLimite.Location = new System.Drawing.Point(328, 232);
        	this.btnDefinirLimite.Name = "btnDefinirLimite";
        	this.btnDefinirLimite.Size = new System.Drawing.Size(82, 29);
        	this.btnDefinirLimite.TabIndex = 30;
        	this.btnDefinirLimite.Text = "Definir Limite";
        	this.btnDefinirLimite.UseVisualStyleBackColor = true;
        	this.btnDefinirLimite.Click += new System.EventHandler(this.BntDefinirLimiteClick);
        	// 
        	// EditarRequisito
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(453, 351);
        	this.Controls.Add(this.tablaDatos);
        	this.Controls.Add(this.btnQuitarLimite);
        	this.Controls.Add(this.btnDefinirLimite);
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnGuardar);
        	this.Controls.Add(this.txtNombre);
        	this.Controls.Add(this.lblNombre);
        	this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.MaximizeBox = false;
        	this.MinimumSize = new System.Drawing.Size(469, 389);
        	this.Name = "EditarRequisito";
        	this.Text = "Editar Requisito";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarRequisitoFormFormClosing);
        	((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button btnQuitarLimite;
        private System.Windows.Forms.Button btnDefinirLimite;
    }
}