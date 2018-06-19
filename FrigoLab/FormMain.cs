using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Sesion;
using FrigLab.View.Areas;
using FrigLab.View.Ensayos;
using FrigLab.View.Muestras;
using FrigLab.View.Muestreos;
using FrigLab.View.Requisitos;
using FrigLab.View.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrigLab {
    public partial class FormMain:Form {
        private List<Panel> formPaneles;

        public FormMain() {
            InitializeComponent();

            CambiarInfoSesion();

            SesionDeUsuario.AgregarFormularioAbierto(this);
            if(SesionDeUsuario.HaySesionIniciada()) {
                BloquearComponentes(SesionDeUsuario.PermisoUsuario());
            }

            // Paneles
            formPaneles = AgruparPaneles();
        }

        #region Botones::Main Menu

        #region Main Menu::Areas
        private void buttonAreas_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuAreas });
        }

        private void buttonNuevaArea_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevaAreaForm = NuevaArea.getInstancia();
            MostrarFormulario(nuevaAreaForm, true);
        }

        private void buttonListarAreas_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles);
            Form listaAreaForm = ListarAreas.GetInstancia();
            MostrarFormulario(listaAreaForm, true);
        }
        #endregion

        #region Main Menu::Muestras
        private void buttonMuestras_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuMuestras });
        }

        private void buttonListarMuestras_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles);
            Form listarEspecificacionesMuestras = ListarMuestras.GetInstancia();
            MostrarFormulario(listarEspecificacionesMuestras, true);
        }

        private void buttonNuevaMuestra_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevaMuestraForm = NuevaMuestra.GetInstancia();
            MostrarFormulario(nuevaMuestraForm, true);
        }

        #endregion

        #region Main Menu::Muestreos
        private void buttonMuestreos_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuMuestreos });
        }

        private void buttonListarMuestreos_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            buttonNuevoPool.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuMuestreos, panelSubmenuButtonListarMuestreo });
        }

        void ButtonListarMuestreosProducto_Click(object sender, EventArgs e) {
            buttonListarMuestreos.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form listarMuestreosProd = ListarMuestreosProducto.GetInstancia();
            MostrarFormulario(listarMuestreosProd, true);
        }

        void ButtonListarMuestreosAmbientales_Click(object sender, EventArgs e) {
            buttonListarMuestreos.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form listarMuestreosAmb = ListarMuestreosAmbientales.GetInstancia();
            MostrarFormulario(listarMuestreosAmb, true);
        }

        private void ButtonListarOtrosMuestreos_Click(object sender, EventArgs e) {
            buttonListarMuestreos.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form listarMuestreos = ListarOtrosMuestreos.GetInstancia();
            MostrarFormulario(listarMuestreos, true);
        }

        private void buttonNuevoMuestreo_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            buttonNuevoPool.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuMuestreos, panelSubmenuButtonNuevoMuestreo });
        }

        private void buttonNuevoProducto_Click(object sender, EventArgs e) {
            buttonNuevoMuestreo.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(EnumClaseMuestra.Producto);
            MostrarFormulario(nuevoMuestreo, true);
        }

        private void buttonNuevoAmbiente_Click(object sender, EventArgs e) {
            buttonNuevoMuestreo.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(EnumClaseMuestra.Ambiente);
            MostrarFormulario(nuevoMuestreo, true);
        }

        private void buttonNuevoSuperficie_Click(object sender, EventArgs e) {
            buttonNuevoMuestreo.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(EnumClaseMuestra.Superficie);
            MostrarFormulario(nuevoMuestreo, true);
        }

        private void buttonNuevoOperario_Click(object sender, EventArgs e) {
            buttonNuevoMuestreo.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(EnumClaseMuestra.Operario);
            MostrarFormulario(nuevoMuestreo, true);
        }

        private void buttonNuevoOtro_Click(object sender, EventArgs e) {
            buttonNuevoMuestreo.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(EnumClaseMuestra.Otra);
            MostrarFormulario(nuevoMuestreo, true);
        }

        private void buttonNuevoPool_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevoPool = NuevoPool.GetInstancia();
            MostrarFormulario(nuevoPool, true);
        }
        #endregion

        #region Main Menu::Laboratorios
        private void buttonLaboratorio_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuLaboratorio });
        }

        private void buttonEnsayos_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            buttonRequisitos.BackColor = Color.FromArgb(41, 57, 85);
            buttonLaboratorios.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuLaboratorio, panelSubMenuButtonEnsayos });
        }

        private void buttonRequisitos_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            buttonEnsayos.BackColor = Color.FromArgb(41, 57, 85);
            buttonLaboratorios.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuLaboratorio, panelSubmenuButtonRequisitos });
        }

        private void buttonLaboratorios_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            buttonEnsayos.BackColor = Color.FromArgb(41, 57, 85);
            buttonRequisitos.BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuLaboratorio, panelSubmenuButtonLaboratorios });
        }

        private void buttonListarEnsayos_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form listarEnsayos = ListarEnsayos.GetInstancia();
            MostrarFormulario(listarEnsayos, true);
        }

        private void buttonListarLaboratorios_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form listarLaboratorios = ListarLaboratorios.GetInstancia();
            MostrarFormulario(listarLaboratorios, true);
        }

        private void buttonListarRequisitos_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form listarRequisitos = ListarRequisitos.GetInstancia();
            MostrarFormulario(listarRequisitos, true);
        }

        private void buttonNuevoLaboratorio_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevoLaboratorioForm = NuevoLaboratorio.GetInstancia();
            MostrarFormulario(nuevoLaboratorioForm, true);
        }

        private void buttonNuevoEnsayo_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevaEspecificacionEnsayoForm = NuevoEnsayo.GetInstancia();
            MostrarFormulario(nuevaEspecificacionEnsayoForm, true);
        }

        private void buttonNuevoRequisito_Click(object sender, EventArgs e) {
            (sender as Button).BackColor = Color.FromArgb(41, 57, 85);
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevoRequisitoForm = NuevoRequisito.GetInstancia();
            MostrarFormulario(nuevoRequisitoForm, true);
        }

        #endregion

        #region Main Menu::Usuarios
        private void buttonUsuarios_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuUsuarios });
        }

        private void buttonListarUsuarios_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles);
            Form listaUsuarioForm = ListarUsuarios.GetInstancia();
            MostrarFormulario(listaUsuarioForm, true);
        }

        private void buttonNuevoUsuario_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles);
            Form nuevoUsuarioform = NuevoUsuario.GetInstancia();
            MostrarFormulario(nuevoUsuarioform, true);
        }
        #endregion

        #region Main Menu::Sesion
        private void buttonSesion_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles, new Panel[] { panelSubmenuSesion });
        }

        private void buttonMisDatos_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles);
            Form editarUsuarioForm = EditarUsuario.GetInstancia(SesionDeUsuario.UsuarioLogueado);
            MostrarFormulario(editarUsuarioForm, true);
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles);
            if(MessageBox.Show("Seguro que quiere cerrar sesion?", "Salir?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                SesionDeUsuario.CerrarSesion();
                this.Dispose();
                CambiarInfoSesion();
            }
        }
        #endregion

        private void panelContenido_Click(object sender, EventArgs e) {
            CambiarVisibilidadPaneles(formPaneles);
        }
        #endregion

        public void CambiarInfoSesion() {
            if(SesionDeUsuario.HaySesionIniciada()) {
                buttonSesion.Text = SesionDeUsuario.UsuarioLogueado.NombreCompleto + "\n" +
                    SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario;
            } else {
                buttonSesion.Text = "Iniciar Sesion...";
                new LoginForm().ShowDialog();
            }
        }

        private void MostrarFormulario(Form formulario, bool agregarSesionAbierto = false) {
            if(agregarSesionAbierto) {
                SesionDeUsuario.AgregarFormularioAbierto(formulario);
            }
            formulario.MdiParent = this;
            panelContenido.Controls.Add(formulario);
            formulario.Show();
            formulario.BringToFront();
        }

        private List<Panel> AgruparPaneles() {
            List<Panel> paneles = new List<Panel>() {
                panelSubmenuAreas,
                panelSubmenuMuestras,
                panelSubmenuMuestreos,
                panelSubmenuUsuarios,
                panelSubMenuButtonEnsayos,
                panelSubmenuButtonLaboratorios,
                panelSubmenuButtonRequisitos,
                panelSubmenuLaboratorio,
                panelSubmenuSesion,
                panelSubmenuButtonNuevoMuestreo,
                panelSubmenuButtonListarMuestreo
            };
            return paneles;
        }

        private void CambiarVisibilidadPaneles(List<Panel> grupoPaneles, Panel[] excepciones = null) {
            foreach(Panel panel in grupoPaneles) {
                if(excepciones != null && excepciones.Contains(panel)) {
                    panel.Visible = true;
                    panel.BringToFront();
                } else {
                    panel.Visible = false;
                }
            }
        }

        private void SalirAppMainMenuClick(object sender, EventArgs e) {
            if(MessageBox.Show("Seguro que quiere salir?", "Salir?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                SesionDeUsuario.CerrarSesion();
                Application.Exit();
            }
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
        
    }
}
