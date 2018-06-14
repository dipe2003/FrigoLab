/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 23/02/2018
 * Time: 02:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using System;

namespace FrigLab
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSesion = new System.Windows.Forms.ToolStripSplitButton();
            this.misDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirAppMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.areasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevaAreaMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAreasMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.muestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevaMuestraMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarMuestrasMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.muestreosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoMuestreoMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superficieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarMuestreosMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ambientalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LaboratorioMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoLaboratorioMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarLaboratoriosMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EnsayosMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoEnsayoMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarEnsayosMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.requisitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoRequisitoMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarRequisitosMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoUsuarioMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarUsuariosMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSesion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(939, 26);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSesion
            // 
            this.toolStripSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misDatosToolStripMenuItem,
            this.toolStripCerrarSesion});
            this.toolStripSesion.Image = global::FrigLab.Properties.Resources.imagen_usuario;
            this.toolStripSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSesion.Name = "toolStripSesion";
            this.toolStripSesion.Size = new System.Drawing.Size(101, 24);
            this.toolStripSesion.Text = "Info Sesion";
            // 
            // misDatosToolStripMenuItem
            // 
            this.misDatosToolStripMenuItem.Image = global::FrigLab.Properties.Resources.imagen_editar_usuario;
            this.misDatosToolStripMenuItem.Name = "misDatosToolStripMenuItem";
            this.misDatosToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.misDatosToolStripMenuItem.Text = "Mis Datos";
            this.misDatosToolStripMenuItem.Click += new System.EventHandler(this.MisDatosToolStripMenuItemClick);
            // 
            // toolStripCerrarSesion
            // 
            this.toolStripCerrarSesion.Image = global::FrigLab.Properties.Resources.imagen_logout;
            this.toolStripCerrarSesion.Name = "toolStripCerrarSesion";
            this.toolStripCerrarSesion.Size = new System.Drawing.Size(171, 26);
            this.toolStripCerrarSesion.Text = "Cerrar Sesion";
            this.toolStripCerrarSesion.Click += new System.EventHandler(this.ToolStripCerrarSesionClick);
            // 
            // mainMenu
            // 
            this.mainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.areasToolStripMenuItem,
            this.muestrasToolStripMenuItem,
            this.muestreosToolStripMenuItem,
            this.LaboratorioMainMenu,
            this.requisitosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.toolStripMenuItem1});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenu.Size = new System.Drawing.Size(939, 28);
            this.mainMenu.TabIndex = 26;
            this.mainMenu.Text = "MainMenu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.salirAppMainMenu});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // salirAppMainMenu
            // 
            this.salirAppMainMenu.Name = "salirAppMainMenu";
            this.salirAppMainMenu.Size = new System.Drawing.Size(113, 26);
            this.salirAppMainMenu.Text = "&Salir";
            this.salirAppMainMenu.Click += new System.EventHandler(this.SalirAppMainMenuClick);
            // 
            // areasToolStripMenuItem
            // 
            this.areasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevaAreaMainMenu,
            this.listarAreasMainMenu});
            this.areasToolStripMenuItem.Name = "areasToolStripMenuItem";
            this.areasToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.areasToolStripMenuItem.Text = "Areas";
            // 
            // NuevaAreaMainMenu
            // 
            this.NuevaAreaMainMenu.Name = "NuevaAreaMainMenu";
            this.NuevaAreaMainMenu.Size = new System.Drawing.Size(216, 26);
            this.NuevaAreaMainMenu.Text = "Nueva";
            this.NuevaAreaMainMenu.Click += new System.EventHandler(this.NuevaAreaMainMenuClick);
            // 
            // listarAreasMainMenu
            // 
            this.listarAreasMainMenu.Name = "listarAreasMainMenu";
            this.listarAreasMainMenu.Size = new System.Drawing.Size(216, 26);
            this.listarAreasMainMenu.Text = "Listar";
            this.listarAreasMainMenu.Click += new System.EventHandler(this.ListarAreasMainMenuClick);
            // 
            // muestrasToolStripMenuItem
            // 
            this.muestrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevaMuestraMainMenu,
            this.ListarMuestrasMainMenu,
            this.toolStripSeparator3});
            this.muestrasToolStripMenuItem.Name = "muestrasToolStripMenuItem";
            this.muestrasToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.muestrasToolStripMenuItem.Text = "Muestras";
            // 
            // NuevaMuestraMainMenu
            // 
            this.NuevaMuestraMainMenu.Name = "NuevaMuestraMainMenu";
            this.NuevaMuestraMainMenu.Size = new System.Drawing.Size(126, 26);
            this.NuevaMuestraMainMenu.Text = "Nueva";
            this.NuevaMuestraMainMenu.Click += new System.EventHandler(this.NuevaMuestraMainMenu_Click);
            // 
            // ListarMuestrasMainMenu
            // 
            this.ListarMuestrasMainMenu.Name = "ListarMuestrasMainMenu";
            this.ListarMuestrasMainMenu.Size = new System.Drawing.Size(126, 26);
            this.ListarMuestrasMainMenu.Text = "Listar";
            this.ListarMuestrasMainMenu.Click += new System.EventHandler(this.ListarMuestrasMainMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(123, 6);
            // 
            // muestreosToolStripMenuItem
            // 
            this.muestreosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoMuestreoMainMenu,
            this.ListarMuestreosMainMenu,
            this.poolToolStripMenuItem});
            this.muestreosToolStripMenuItem.Name = "muestreosToolStripMenuItem";
            this.muestreosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.muestreosToolStripMenuItem.Text = "Muestreos";
            // 
            // NuevoMuestreoMainMenu
            // 
            this.NuevoMuestreoMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.operarioToolStripMenuItem,
            this.superficieToolStripMenuItem,
            this.ambienteToolStripMenuItem,
            this.otraToolStripMenuItem});
            this.NuevoMuestreoMainMenu.Name = "NuevoMuestreoMainMenu";
            this.NuevoMuestreoMainMenu.Size = new System.Drawing.Size(160, 26);
            this.NuevoMuestreoMainMenu.Text = "Nuevo";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.ProductoToolStripMenuItem_Click);
            // 
            // operarioToolStripMenuItem
            // 
            this.operarioToolStripMenuItem.Name = "operarioToolStripMenuItem";
            this.operarioToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.operarioToolStripMenuItem.Text = "Operario";
            this.operarioToolStripMenuItem.Click += new System.EventHandler(this.OperarioToolStripMenuItem_Click);
            // 
            // superficieToolStripMenuItem
            // 
            this.superficieToolStripMenuItem.Name = "superficieToolStripMenuItem";
            this.superficieToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.superficieToolStripMenuItem.Text = "Superficie";
            this.superficieToolStripMenuItem.Click += new System.EventHandler(this.SuperficieToolStripMenuItem_Click);
            // 
            // ambienteToolStripMenuItem
            // 
            this.ambienteToolStripMenuItem.Name = "ambienteToolStripMenuItem";
            this.ambienteToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.ambienteToolStripMenuItem.Text = "Ambiente";
            this.ambienteToolStripMenuItem.Click += new System.EventHandler(this.AmbienteToolStripMenuItem_Click);
            // 
            // otraToolStripMenuItem
            // 
            this.otraToolStripMenuItem.Name = "otraToolStripMenuItem";
            this.otraToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.otraToolStripMenuItem.Text = "Otra";
            this.otraToolStripMenuItem.Click += new System.EventHandler(this.OtraToolStripMenuItem_Click);
            // 
            // ListarMuestreosMainMenu
            // 
            this.ListarMuestreosMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem1,
            this.ambientalesToolStripMenuItem,
            this.otrosToolStripMenuItem});
            this.ListarMuestreosMainMenu.Name = "ListarMuestreosMainMenu";
            this.ListarMuestreosMainMenu.Size = new System.Drawing.Size(160, 26);
            this.ListarMuestreosMainMenu.Text = "Listar";
            // 
            // productoToolStripMenuItem1
            // 
            this.productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            this.productoToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.productoToolStripMenuItem1.Text = "Producto";
            this.productoToolStripMenuItem1.Click += new System.EventHandler(this.ProductoToolStripMenuItem1Click);
            // 
            // ambientalesToolStripMenuItem
            // 
            this.ambientalesToolStripMenuItem.Name = "ambientalesToolStripMenuItem";
            this.ambientalesToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.ambientalesToolStripMenuItem.Text = "Ambientales";
            this.ambientalesToolStripMenuItem.Click += new System.EventHandler(this.AmbientalesToolStripMenuItemClick);
            // 
            // otrosToolStripMenuItem
            // 
            this.otrosToolStripMenuItem.Name = "otrosToolStripMenuItem";
            this.otrosToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.otrosToolStripMenuItem.Text = "Otros";
            this.otrosToolStripMenuItem.Click += new System.EventHandler(this.otrosToolStripMenuItem_Click);
            // 
            // poolToolStripMenuItem
            // 
            this.poolToolStripMenuItem.Name = "poolToolStripMenuItem";
            this.poolToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.poolToolStripMenuItem.Text = "Nuevo Pool";
            this.poolToolStripMenuItem.Click += new System.EventHandler(this.poolToolStripMenuItem_Click);
            // 
            // LaboratorioMainMenu
            // 
            this.LaboratorioMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratoriosMainMenu,
            this.toolStripSeparator2,
            this.EnsayosMainMenu});
            this.LaboratorioMainMenu.Name = "LaboratorioMainMenu";
            this.LaboratorioMainMenu.Size = new System.Drawing.Size(99, 24);
            this.LaboratorioMainMenu.Text = "Laboratorio";
            // 
            // laboratoriosMainMenu
            // 
            this.laboratoriosMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoLaboratorioMainMenu,
            this.ListarLaboratoriosMainMenu});
            this.laboratoriosMainMenu.Name = "laboratoriosMainMenu";
            this.laboratoriosMainMenu.Size = new System.Drawing.Size(168, 26);
            this.laboratoriosMainMenu.Text = "Laboratorios";
            // 
            // NuevoLaboratorioMainMenu
            // 
            this.NuevoLaboratorioMainMenu.Name = "NuevoLaboratorioMainMenu";
            this.NuevoLaboratorioMainMenu.Size = new System.Drawing.Size(209, 26);
            this.NuevoLaboratorioMainMenu.Text = "Nuevo Laboratorio";
            this.NuevoLaboratorioMainMenu.Click += new System.EventHandler(this.NuevoLaboratorioMainMenu_Click);
            // 
            // ListarLaboratoriosMainMenu
            // 
            this.ListarLaboratoriosMainMenu.Name = "ListarLaboratoriosMainMenu";
            this.ListarLaboratoriosMainMenu.Size = new System.Drawing.Size(209, 26);
            this.ListarLaboratoriosMainMenu.Text = "Listar Laboratorios";
            this.ListarLaboratoriosMainMenu.Click += new System.EventHandler(this.ListarLaboratoriosMainMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // EnsayosMainMenu
            // 
            this.EnsayosMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoEnsayoMainMenu,
            this.ListarEnsayosMainMenu});
            this.EnsayosMainMenu.Name = "EnsayosMainMenu";
            this.EnsayosMainMenu.Size = new System.Drawing.Size(168, 26);
            this.EnsayosMainMenu.Text = "Ensayos";
            // 
            // NuevoEnsayoMainMenu
            // 
            this.NuevoEnsayoMainMenu.Name = "NuevoEnsayoMainMenu";
            this.NuevoEnsayoMainMenu.Size = new System.Drawing.Size(177, 26);
            this.NuevoEnsayoMainMenu.Text = "Nuevo Ensayo";
            this.NuevoEnsayoMainMenu.Click += new System.EventHandler(this.NuevoEnsayoMainMenu_Click);
            // 
            // ListarEnsayosMainMenu
            // 
            this.ListarEnsayosMainMenu.Name = "ListarEnsayosMainMenu";
            this.ListarEnsayosMainMenu.Size = new System.Drawing.Size(177, 26);
            this.ListarEnsayosMainMenu.Text = "Listar Ensayos";
            this.ListarEnsayosMainMenu.Click += new System.EventHandler(this.ListarEnsayosMainMenuClick);
            // 
            // requisitosToolStripMenuItem
            // 
            this.requisitosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoRequisitoMainMenu,
            this.ListarRequisitosMainMenu});
            this.requisitosToolStripMenuItem.Name = "requisitosToolStripMenuItem";
            this.requisitosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.requisitosToolStripMenuItem.Text = "Requisitos";
            // 
            // NuevoRequisitoMainMenu
            // 
            this.NuevoRequisitoMainMenu.Name = "NuevoRequisitoMainMenu";
            this.NuevoRequisitoMainMenu.Size = new System.Drawing.Size(216, 26);
            this.NuevoRequisitoMainMenu.Text = "Nuevo";
            this.NuevoRequisitoMainMenu.Click += new System.EventHandler(this.RequisitosMainMenuClick);
            // 
            // ListarRequisitosMainMenu
            // 
            this.ListarRequisitosMainMenu.Name = "ListarRequisitosMainMenu";
            this.ListarRequisitosMainMenu.Size = new System.Drawing.Size(216, 26);
            this.ListarRequisitosMainMenu.Text = "Listar";
            this.ListarRequisitosMainMenu.Click += new System.EventHandler(this.ListarRequisitosMainMenu_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoUsuarioMainMenu,
            this.ListarUsuariosMainMenu});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // NuevoUsuarioMainMenu
            // 
            this.NuevoUsuarioMainMenu.Name = "NuevoUsuarioMainMenu";
            this.NuevoUsuarioMainMenu.Size = new System.Drawing.Size(127, 26);
            this.NuevoUsuarioMainMenu.Text = "Nuevo";
            this.NuevoUsuarioMainMenu.Click += new System.EventHandler(this.NuevoUsuarioMainMenuClick);
            // 
            // ListarUsuariosMainMenu
            // 
            this.ListarUsuariosMainMenu.Name = "ListarUsuariosMainMenu";
            this.ListarUsuariosMainMenu.Size = new System.Drawing.Size(127, 26);
            this.ListarUsuariosMainMenu.Text = "Listar";
            this.ListarUsuariosMainMenu.Click += new System.EventHandler(this.ListarUsuariosMainMenu_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 24);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(939, 679);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(954, 713);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrigoLab";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        /// <summary>
        /// Bloquea los componentes inicializados segun el permiso del usuario segun los casos de uso.
        /// </summary>
        /// <param name="permiso"></param>
        private void BloquearComponentes(EnumPermisoUsuario permiso) {
            // Visitante
            switch(permiso) {                
                case EnumPermisoUsuario.Verificador:
                    NuevoUsuarioMainMenu.Enabled = false;
                    poolToolStripMenuItem.Enabled = false;
                    break;

                case EnumPermisoUsuario.Analista:
                    NuevoUsuarioMainMenu.Enabled = false;
                    NuevoRequisitoMainMenu.Enabled = false;
                    NuevoEnsayoMainMenu.Enabled = false;
                    NuevoLaboratorioMainMenu.Enabled = false;
                    break;

                case EnumPermisoUsuario.Monitor:
                    NuevoUsuarioMainMenu.Enabled = false;
                    NuevoRequisitoMainMenu.Enabled = false;
                    NuevoEnsayoMainMenu.Enabled = false;
                    NuevoLaboratorioMainMenu.Enabled = false;
                    break;

                case EnumPermisoUsuario.Visitante:
                    NuevoUsuarioMainMenu.Enabled = false;
                    NuevoMuestreoMainMenu.Enabled = false;
                    NuevoLaboratorioMainMenu.Enabled = false;
                    NuevaMuestraMainMenu.Enabled = false;
                    NuevaAreaMainMenu.Enabled = false;
                    NuevoEnsayoMainMenu.Enabled = false;
                    NuevoRequisitoMainMenu.Enabled = false;
                    poolToolStripMenuItem.Enabled = false;
                    break;

                default:
                    break;
            }
        }

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirAppMainMenu;
        private System.Windows.Forms.ToolStripMenuItem areasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevaAreaMainMenu;
        private System.Windows.Forms.ToolStripMenuItem listarAreasMainMenu;
        private System.Windows.Forms.ToolStripMenuItem muestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevaMuestraMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ListarMuestrasMainMenu;
        private System.Windows.Forms.ToolStripMenuItem muestreosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevoMuestreoMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ListarMuestreosMainMenu;
        private System.Windows.Forms.ToolStripMenuItem LaboratorioMainMenu;
        private System.Windows.Forms.ToolStripMenuItem requisitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevoRequisitoMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ListarRequisitosMainMenu;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevoUsuarioMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ListarUsuariosMainMenu;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSesion;
        private System.Windows.Forms.ToolStripMenuItem misDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosMainMenu;
        private System.Windows.Forms.ToolStripMenuItem NuevoLaboratorioMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ListarLaboratoriosMainMenu;
        private System.Windows.Forms.ToolStripMenuItem EnsayosMainMenu;
        private System.Windows.Forms.ToolStripMenuItem NuevoEnsayoMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ListarEnsayosMainMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem superficieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ambientalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poolToolStripMenuItem;
    }    
}
