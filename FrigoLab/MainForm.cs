/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 23/02/2018
 * Time: 02:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using FrigLab.Model.Sesion;
using FrigLab.View.Areas;
using FrigLab.View.Requisitos;
using FrigLab.View.Usuarios;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using FrigLab.View.Muestras;
using FrigLab.View.Ensayos;
using FrigLab.View.Muestreos;

namespace FrigLab {
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm:Form {

        public MainForm() {
            InitializeComponent();

            CambiarInfoSesion();

            SesionDeUsuario.AgregarFormularioAbierto(this);
            if(SesionDeUsuario.HaySesionIniciada()) {
                BloquearComponentes(SesionDeUsuario.PermisoUsuario());
            }
        }

        private void SalirAppMainMenuClick(object sender, EventArgs e) {
            if(MessageBox.Show("Seguro que quiere salir?", "Salir?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                SesionDeUsuario.CerrarSesion();
                Application.Exit();
            }
        }

        private void NuevaAreaMainMenuClick(object sender, EventArgs e) {
            Form nuevaAreaForm = NuevaArea.getInstancia();
            MostrarFormulario(nuevaAreaForm, true);
        }
        private void ListarAreasMainMenuClick(object sender, EventArgs e) {
            Form listaAreaForm = ListarAreas.GetInstancia();
            MostrarFormulario(listaAreaForm, true);
        }

        private void NuevoUsuarioMainMenuClick(object sender, EventArgs e) {
            Form nuevoUsuarioform = NuevoUsuario.GetInstancia();
            MostrarFormulario(nuevoUsuarioform, true);
        }
        private void MainFormFormClosing(object sender, FormClosingEventArgs e) {
            if(e.CloseReason == CloseReason.UserClosing) {
                if(MessageBox.Show("Seguro que quiere salir?", "Salir?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    SesionDeUsuario.CerrarSesion();
                    Application.Exit();
                } else {
                    e.Cancel = true;
                }
            }
        }

        private void MostrarFormulario(Form formulario, bool agregarSesionAbierto = false) {
            if(agregarSesionAbierto) {
                SesionDeUsuario.AgregarFormularioAbierto(formulario);
            }
            formulario.MdiParent = this;
            formulario.Show();
            formulario.BringToFront();
        }

        private void ListarUsuariosMainMenu_Click(object sender, EventArgs e) {
            Form listaUsuarioForm = ListarUsuarios.GetInstancia();
            MostrarFormulario(listaUsuarioForm, true);
        }

        private void ToolStripCerrarSesionClick(object sender, EventArgs e) {
            if(MessageBox.Show("Seguro que quiere cerrar sesion?", "Salir?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                SesionDeUsuario.CerrarSesion();
                this.Dispose();
                CambiarInfoSesion();
            }
        }

        public void CambiarInfoSesion() {
            if(SesionDeUsuario.HaySesionIniciada()) {
                toolStripSesion.Text = SesionDeUsuario.UsuarioLogueado.NombreCompleto + " | " +
                    SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario;
            } else {
                toolStripSesion.Text = "Iniciar Sesion...";
                new LoginForm().ShowDialog();
            }
        }

        void MisDatosToolStripMenuItemClick(object sender, EventArgs e) {
            Form editarUsuarioForm = EditarUsuario.GetInstancia(SesionDeUsuario.UsuarioLogueado);
            MostrarFormulario(editarUsuarioForm, true);
        }

        private void NuevaMuestraMainMenu_Click(object sender, EventArgs e) {
            Form nuevaMuestraForm = NuevaMuestra.GetInstancia();
            MostrarFormulario(nuevaMuestraForm, true);
        }

        private void ListarMuestrasMainMenu_Click(object sender, EventArgs e) {
            Form listarEspecificacionesMuestras = ListarMuestras.GetInstancia();
            MostrarFormulario(listarEspecificacionesMuestras, true);
        }

        private void NuevoLaboratorioMainMenu_Click(object sender, EventArgs e) {
            Form nuevoLaboratorioForm = NuevoLaboratorio.GetInstancia();
            MostrarFormulario(nuevoLaboratorioForm, true);
        }

        private void ListarLaboratoriosMainMenu_Click(object sender, EventArgs e) {
            Form listarLaboratorios = ListarLaboratorios.GetInstancia();
            MostrarFormulario(listarLaboratorios, true);
        }

        private void NuevoEnsayoMainMenu_Click(object sender, EventArgs e) {
            Form nuevaEspecificacionEnsayoForm = NuevoEnsayo.GetInstancia();
            MostrarFormulario(nuevaEspecificacionEnsayoForm, true);
        }

        void ListarEnsayosMainMenuClick(object sender, EventArgs e) {
            Form listarEnsayos = ListarEnsayos.GetInstancia();
            MostrarFormulario(listarEnsayos, true);
        }
        void RequisitosMainMenuClick(object sender, EventArgs e) {
            Form nuevoRequisitoForm = NuevoRequisito.GetInstancia();
            MostrarFormulario(nuevoRequisitoForm, true);
        }

        private void ListarRequisitosMainMenu_Click(object sender, EventArgs e) {
            Form listarRequisitos = ListarRequisitos.GetInstancia();
            MostrarFormulario(listarRequisitos, true);
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e) {
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(Model.Dominio.Enumeraciones.Muestras.EnumClaseMuestra.Producto);
            MostrarFormulario(nuevoMuestreo, true);
        }

        private void OperarioToolStripMenuItem_Click(object sender, EventArgs e) {
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(Model.Dominio.Enumeraciones.Muestras.EnumClaseMuestra.Operario);
            MostrarFormulario(nuevoMuestreo, true);
        }

        private void SuperficieToolStripMenuItem_Click(object sender, EventArgs e) {
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(Model.Dominio.Enumeraciones.Muestras.EnumClaseMuestra.Superficie);
            MostrarFormulario(nuevoMuestreo, true);
        }

        private void AmbienteToolStripMenuItem_Click(object sender, EventArgs e) {
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(Model.Dominio.Enumeraciones.Muestras.EnumClaseMuestra.Ambiente);
            MostrarFormulario(nuevoMuestreo, true);
        }

        private void OtraToolStripMenuItem_Click(object sender, EventArgs e) {
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(Model.Dominio.Enumeraciones.Muestras.EnumClaseMuestra.Otra);
            MostrarFormulario(nuevoMuestreo, true);
        }
        void ProductoToolStripMenuItem1Click(object sender, EventArgs e) {
            Form listarMuestreosProd = ListarMuestreosProducto.GetInstancia();
            MostrarFormulario(listarMuestreosProd, true);
        }
        void AmbientalesToolStripMenuItemClick(object sender, EventArgs e) {
            Form listarMuestreosAmb = ListarMuestreosAmbientales.GetInstancia();
            MostrarFormulario(listarMuestreosAmb, true);
        }

        private void otrosToolStripMenuItem_Click(object sender, EventArgs e) {
            Form listarMuestreos = ListarOtrosMuestreos.GetInstancia();
            MostrarFormulario(listarMuestreos, true);
        }

        private void poolToolStripMenuItem_Click(object sender, EventArgs e) {
            Form nuevoPool = NuevoPool.GetInstancia();
            MostrarFormulario(nuevoPool, true);
        }
    }
}
