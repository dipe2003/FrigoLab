﻿using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using System;

namespace FrigLab.View.Usuarios {
    partial class ListarUsuarios {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grupoAcciones = new System.Windows.Forms.GroupBox();
            this.grupoFiltros = new System.Windows.Forms.GroupBox();
            this.grupoBuscarNombre = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.TxtBuscarPadron = new System.Windows.Forms.TextBox();
            this.grupoVigencia = new System.Windows.Forms.GroupBox();
            this.radioNoVigentes = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioSoloVigentes = new System.Windows.Forms.RadioButton();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.BtnBorrarBusqueda = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grupoAcciones.SuspendLayout();
            this.grupoFiltros.SuspendLayout();
            this.grupoBuscarNombre.SuspendLayout();
            this.grupoVigencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoAcciones
            // 
            this.grupoAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoAcciones.Controls.Add(this.btnEliminar);
            this.grupoAcciones.Controls.Add(this.btnEditar);
            this.grupoAcciones.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoAcciones.Location = new System.Drawing.Point(696, 18);
            this.grupoAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.grupoAcciones.Size = new System.Drawing.Size(171, 139);
            this.grupoAcciones.TabIndex = 1;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Acciones";
            // 
            // grupoFiltros
            // 
            this.grupoFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoFiltros.Controls.Add(this.grupoBuscarNombre);
            this.grupoFiltros.Controls.Add(this.grupoVigencia);
            this.grupoFiltros.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoFiltros.Location = new System.Drawing.Point(16, 18);
            this.grupoFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Name = "grupoFiltros";
            this.grupoFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grupoFiltros.Size = new System.Drawing.Size(673, 139);
            this.grupoFiltros.TabIndex = 2;
            this.grupoFiltros.TabStop = false;
            this.grupoFiltros.Text = "Filtros";
            // 
            // grupoBuscarNombre
            // 
            this.grupoBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoBuscarNombre.Controls.Add(this.BtnBorrarBusqueda);
            this.grupoBuscarNombre.Controls.Add(this.label2);
            this.grupoBuscarNombre.Controls.Add(this.label1);
            this.grupoBuscarNombre.Controls.Add(this.txtBuscarNombre);
            this.grupoBuscarNombre.Controls.Add(this.TxtBuscarPadron);
            this.grupoBuscarNombre.Location = new System.Drawing.Point(195, 22);
            this.grupoBuscarNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscarNombre.Name = "grupoBuscarNombre";
            this.grupoBuscarNombre.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoBuscarNombre.Size = new System.Drawing.Size(472, 111);
            this.grupoBuscarNombre.TabIndex = 1;
            this.grupoBuscarNombre.TabStop = false;
            this.grupoBuscarNombre.Text = "Busqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Padron";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(77, 21);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(217, 22);
            this.txtBuscarNombre.TabIndex = 0;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.TxtBuscarNombre_TextChanged);
            // 
            // TxtBuscarPadron
            // 
            this.TxtBuscarPadron.Location = new System.Drawing.Point(77, 74);
            this.TxtBuscarPadron.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscarPadron.Name = "TxtBuscarPadron";
            this.TxtBuscarPadron.Size = new System.Drawing.Size(217, 22);
            this.TxtBuscarPadron.TabIndex = 1;
            this.TxtBuscarPadron.TextChanged += new System.EventHandler(this.TxtBuscarPadron_TextChanged);
            // 
            // grupoVigencia
            // 
            this.grupoVigencia.Controls.Add(this.radioNoVigentes);
            this.grupoVigencia.Controls.Add(this.radioTodos);
            this.grupoVigencia.Controls.Add(this.radioSoloVigentes);
            this.grupoVigencia.Location = new System.Drawing.Point(7, 22);
            this.grupoVigencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoVigencia.Name = "grupoVigencia";
            this.grupoVigencia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoVigencia.Size = new System.Drawing.Size(181, 111);
            this.grupoVigencia.TabIndex = 0;
            this.grupoVigencia.TabStop = false;
            this.grupoVigencia.Text = "Vigencia";
            // 
            // radioNoVigentes
            // 
            this.radioNoVigentes.AutoSize = true;
            this.radioNoVigentes.Location = new System.Drawing.Point(21, 57);
            this.radioNoVigentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioNoVigentes.Name = "radioNoVigentes";
            this.radioNoVigentes.Size = new System.Drawing.Size(138, 21);
            this.radioNoVigentes.TabIndex = 1;
            this.radioNoVigentes.TabStop = true;
            this.radioNoVigentes.Text = "Solo No Vigentes";
            this.radioNoVigentes.UseVisualStyleBackColor = true;
            this.radioNoVigentes.CheckedChanged += new System.EventHandler(this.GrupoPermisoChange_Click);
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(21, 82);
            this.radioTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(142, 21);
            this.radioTodos.TabIndex = 2;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todos los usuarios";
            this.radioTodos.UseVisualStyleBackColor = true;
            this.radioTodos.CheckedChanged += new System.EventHandler(this.GrupoPermisoChange_Click);
            // 
            // radioSoloVigentes
            // 
            this.radioSoloVigentes.AutoSize = true;
            this.radioSoloVigentes.Location = new System.Drawing.Point(21, 30);
            this.radioSoloVigentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSoloVigentes.Name = "radioSoloVigentes";
            this.radioSoloVigentes.Size = new System.Drawing.Size(115, 21);
            this.radioSoloVigentes.TabIndex = 0;
            this.radioSoloVigentes.TabStop = true;
            this.radioSoloVigentes.Text = "Solo Vigentes";
            this.radioSoloVigentes.UseVisualStyleBackColor = true;
            this.radioSoloVigentes.CheckedChanged += new System.EventHandler(this.GrupoPermisoChange_Click);
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            this.tablaDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tablaDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.tablaDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.DefaultCellStyle = dataGridViewCellStyle11;
            this.tablaDatos.EnableHeadersVisualStyles = false;
            this.tablaDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tablaDatos.Location = new System.Drawing.Point(16, 165);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaDatos.MultiSelect = false;
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowHeadersVisible = false;
            this.tablaDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(851, 370);
            this.tablaDatos.TabIndex = 8;
            this.tablaDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatosRowEnter);
            this.tablaDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TablaDatosMouseDown);
            // 
            // BtnBorrarBusqueda
            // 
            this.BtnBorrarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBorrarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.BtnBorrarBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.BtnBorrarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.BtnBorrarBusqueda.Location = new System.Drawing.Point(336, 58);
            this.BtnBorrarBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBorrarBusqueda.Name = "BtnBorrarBusqueda";
            this.BtnBorrarBusqueda.Size = new System.Drawing.Size(117, 38);
            this.BtnBorrarBusqueda.TabIndex = 31;
            this.BtnBorrarBusqueda.Text = "Borrar";
            this.BtnBorrarBusqueda.UseVisualStyleBackColor = false;
            this.BtnBorrarBusqueda.Click += new System.EventHandler(this.BtnBorrarBusqueda_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnEliminar.Location = new System.Drawing.Point(27, 79);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 38);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(187)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnEditar.Location = new System.Drawing.Point(27, 29);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 38);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // ListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.grupoFiltros);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(898, 593);
            this.Name = "ListarUsuarios";
            this.Text = "Listado de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarUsuariosFormFormClosing);
            this.grupoAcciones.ResumeLayout(false);
            this.grupoFiltros.ResumeLayout(false);
            this.grupoBuscarNombre.ResumeLayout(false);
            this.grupoBuscarNombre.PerformLayout();
            this.grupoVigencia.ResumeLayout(false);
            this.grupoVigencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Bloquea los componentes inicializados segun el permiso del usuario segun los casos de uso.
        /// </summary>
        /// <param name="permiso"></param>
        private void BloquearComponentes(EnumPermisoUsuario permiso) {
            // Visitante
            if(permiso != EnumPermisoUsuario.Administrador) {
                btnEliminar.Enabled = false;
            }
        }

        private System.Windows.Forms.GroupBox grupoAcciones;
        private System.Windows.Forms.GroupBox grupoFiltros;
        private System.Windows.Forms.GroupBox grupoBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.GroupBox grupoVigencia;
        private System.Windows.Forms.RadioButton radioNoVigentes;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioSoloVigentes;
        private System.Windows.Forms.TextBox TxtBuscarPadron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button BtnBorrarBusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}