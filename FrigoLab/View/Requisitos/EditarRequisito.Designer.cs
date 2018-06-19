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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelInferiorControles = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnQuitarLimite = new System.Windows.Forms.Button();
            this.btnDefinirLimite = new System.Windows.Forms.Button();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.panelInferiorControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 58);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(301, 22);
            this.txtNombre.TabIndex = 21;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(35, 26);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(133, 28);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            // 
            // panelInferiorControles
            // 
            this.panelInferiorControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panelInferiorControles.Controls.Add(this.btnGuardar);
            this.panelInferiorControles.Controls.Add(this.btnCancelar);
            this.panelInferiorControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferiorControles.Location = new System.Drawing.Point(0, 364);
            this.panelInferiorControles.Name = "panelInferiorControles";
            this.panelInferiorControles.Size = new System.Drawing.Size(604, 68);
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
            this.btnGuardar.Location = new System.Drawing.Point(420, 19);
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
            this.btnCancelar.Location = new System.Drawing.Point(248, 19);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // btnQuitarLimite
            // 
            this.btnQuitarLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarLimite.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuitarLimite.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuitarLimite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuitarLimite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarLimite.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarLimite.ForeColor = System.Drawing.Color.Maroon;
            this.btnQuitarLimite.Location = new System.Drawing.Point(248, 287);
            this.btnQuitarLimite.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitarLimite.Name = "btnQuitarLimite";
            this.btnQuitarLimite.Size = new System.Drawing.Size(140, 36);
            this.btnQuitarLimite.TabIndex = 54;
            this.btnQuitarLimite.Text = "Quitar Limite";
            this.btnQuitarLimite.UseVisualStyleBackColor = false;
            this.btnQuitarLimite.Click += new System.EventHandler(this.BntQuitarLimiteClick);
            // 
            // btnDefinirLimite
            // 
            this.btnDefinirLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefinirLimite.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDefinirLimite.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDefinirLimite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnDefinirLimite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefinirLimite.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefinirLimite.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDefinirLimite.Location = new System.Drawing.Point(420, 287);
            this.btnDefinirLimite.Margin = new System.Windows.Forms.Padding(4);
            this.btnDefinirLimite.Name = "btnDefinirLimite";
            this.btnDefinirLimite.Size = new System.Drawing.Size(140, 36);
            this.btnDefinirLimite.TabIndex = 53;
            this.btnDefinirLimite.Text = "Definir Limite";
            this.btnDefinirLimite.UseVisualStyleBackColor = false;
            this.btnDefinirLimite.Click += new System.EventHandler(this.BntDefinirLimiteClick);
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
            this.tablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.tablaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDatos.EnableHeadersVisualStyles = false;
            this.tablaDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tablaDatos.Location = new System.Drawing.Point(35, 88);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaDatos.MultiSelect = false;
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowHeadersVisible = false;
            this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(525, 191);
            this.tablaDatos.TabIndex = 55;
            this.tablaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatos_CellClick);
            // 
            // EditarRequisito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 432);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.btnQuitarLimite);
            this.Controls.Add(this.btnDefinirLimite);
            this.Controls.Add(this.panelInferiorControles);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(619, 468);
            this.Name = "EditarRequisito";
            this.Text = "Editar Requisito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarRequisitoFormFormClosing);
            this.panelInferiorControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelInferiorControles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnQuitarLimite;
        private System.Windows.Forms.Button btnDefinirLimite;
        private System.Windows.Forms.DataGridView tablaDatos;
    }
}