using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Requisitos;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Muestreos;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Resultados {
    public partial class Resultados:Form, ICerrar {

        private static Resultados instancia;

        private ControladorMuestreos cMuestreos = new ControladorMuestreos();
        private ControladorPooles cPooles = new ControladorPooles();
        private ControladorEnsayos cEnsayos = new ControladorEnsayos();

        private int idMuestreo;
        private Muestreo muestreoSeleccionado;

        private Analisis analisisSeleccionado;

        private Dictionary<string, Laboratorio> laboratoriosRegistrados;
        private Laboratorio laboratorioSeleccionado;

        private DataTable tabla;

        #region Pool
        private DateTime fechaPool;
        private string descripcionPool;
        private IList<Muestreo> muestreosDelPool = new List<Muestreo>();
        private bool perteneceAPool = false;
        private bool permitirSeparar = false;
        #endregion

        private Resultados() {
            InitializeComponent();
            CrearTabla();
            tablaDatos.ContextMenuStrip = CrearMenuContextual();
        }

        public static Resultados GetInstancia(int idMuestreo) {
            if(instancia == null) {
                instancia = new Resultados {
                    idMuestreo = idMuestreo
                };
            }
            instancia.CargarDatos();
            instancia.LlenarTabla();
            return instancia;
        }

        private ContextMenuStrip CrearMenuContextual(bool agregarResultado = false, bool quitarResultado = false,
                                                     bool verificarResultado = false, bool confirmarResultado = false,
                                                    bool separarPool = false) {
            ContextMenuStrip ctxMenuStrip = new ContextMenuStrip();
            if(!agregarResultado && !quitarResultado && !verificarResultado && !confirmarResultado && !separarPool) {
                ctxMenuStrip.Items.Add("No hay acciones disponibles", Properties.Resources.imagen_no_disponible);
            } else {
                if(agregarResultado && SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Analista 
                    || SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Administrador) ctxMenuStrip.Items.Add("&Agregar Resultado", Properties.Resources.imagen_matraz, AgregarResultado_Click);
                if(confirmarResultado && SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Analista) {
                    // item solo texto para desplegar sub-menu con combobox
                    ToolStripMenuItem item = new ToolStripMenuItem {
                        Text = "&Confirmar Resultado...",
                        Image = Properties.Resources.imagen_microscopio
                    };

                    // combobox con la lista de laboratorios disponibles
                    ToolStripComboBox cboLaboratorios = new ToolStripComboBox();
                    cboLaboratorios.Items.AddRange(laboratoriosRegistrados.Keys.ToArray());
                    cboLaboratorios.SelectedItem = laboratorioSeleccionado.NombreDeLaboratorio;
                    cboLaboratorios.SelectedIndexChanged += CboLaboratorio_SelectedItemChanged;

                    // boton para lanzar el evento
                    ToolStripButton btn = new ToolStripButton {
                        Text = "Confirmar"
                    };
                    btn.Click += ConfirmarResultado_Click;
                    btn.Image = Properties.Resources.imagen_microscopio;

                    item.DropDownItems.AddRange(new ToolStripItem[] { cboLaboratorios, btn });
                    ctxMenuStrip.Items.Add(item);
                }
                if(SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Analista || SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Administrador) {
                    if(quitarResultado) ctxMenuStrip.Items.Add("&Quitar Resultado", Properties.Resources.imagen_quitar, QuitarResultado_Click);
                    if(verificarResultado) ctxMenuStrip.Items.Add("&Verificar Resultado", Properties.Resources.imagen_verificar, VerificarResultado_Click);
                    if(separarPool) ctxMenuStrip.Items.Add("&Separar Pool", Properties.Resources.imagen_dividir, SepararPool_Click);
                }
            }
            return ctxMenuStrip;
        }

        private void CrearTabla() {
            tabla = new DataTable();
            tabla.Columns.Add("IdAnalisis", typeof(int));
            tabla.Columns.Add("Ensayo", typeof(string));
            tabla.Columns.Add("Tipo Analisis", typeof(string));
            tabla.Columns.Add("Fecha Analisis", typeof(DateTime));
            tabla.Columns.Add("Motivo", typeof(string));
            tabla.Columns.Add("Laboratorio", typeof(string));
            tabla.Columns.Add("Analista", typeof(string));
            tabla.Columns.Add("Resultado", typeof(string));
            tabla.Columns.Add("Observaciones", typeof(string));
            tabla.Columns.Add("Verificado", typeof(DateTime));
            tabla.Columns.Add("Verificador", typeof(string));
            tabla.Columns.Add("Estado", typeof(string));
        }

        private void CargarDatos() {
            muestreoSeleccionado = cMuestreos.ObtenerMuestreoIndividual(idMuestreo);
            txtArea.Text = muestreoSeleccionado.Muestra.Area.NombreDeArea;
            txtIdentificacion.Text = muestreoSeleccionado.Muestra.IdentificacionDeMuestra;
            txtClaseMuestra.Text = muestreoSeleccionado.Muestra.EspecificacionDeMuestra.ClaseDeMuestra.ToString();
            txtNombreEspecificacion.Text = muestreoSeleccionado.Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra;

            laboratoriosRegistrados = cEnsayos.ListarLaboratorios().ToDictionary<Laboratorio, string>(l => l.NombreDeLaboratorio);
            laboratorioSeleccionado = laboratoriosRegistrados.FirstOrDefault().Value;

            // Otros datos especificos por clase de muestra
            switch(muestreoSeleccionado.Muestra.EspecificacionDeMuestra.ClaseDeMuestra) {
                case EnumClaseMuestra.Producto:
                    CambiarVisibilidadPaneles(true, false, false);
                    Producto p = muestreoSeleccionado.Muestra as Producto;
                    txtFechaFaena.Text = p.FechaDeFaena.ToShortDateString();
                    txtFechaProduccion.Text = p.FechaDeProduccion.ToShortDateString();
                    txtLote.Text = p.LoteDeProducto;
                    break;

                case EnumClaseMuestra.Operario:
                    CambiarVisibilidadPaneles(false, true, true);
                    Operario op = muestreoSeleccionado.Muestra as Operario;
                    txtPadron.Text = op.PadronDeOperario.ToString();
                    txtNombreOprerario.Text = op.NombreDeOperario;
                    txtHorario.Text = op.HorarioDeMuestra.ToString();
                    break;

                // clases Otra, Superficie y Ambiente usan los mismos controles
                case EnumClaseMuestra.Superficie:
                    txtHorario.Text = (muestreoSeleccionado.Muestra as Superficie).HorarioDeMuestra.ToString();
                    break;

                case EnumClaseMuestra.Ambiente:
                    txtHorario.Text = (muestreoSeleccionado.Muestra as Ambiente).HorarioDeMuestra.ToString();
                    break;

                default:
                    CambiarVisibilidadPaneles(false, false, true);
                    break;
            }

            txtFechaMuestreo.Text = (muestreoSeleccionado as Individual).FechaHoraDeMuestreo.ToShortDateString();
            txtAlmacenamiento.Text = (muestreoSeleccionado as Individual).AlmacenamientoDeMuestreo.ToString();
            txtMonitor.Text = muestreoSeleccionado.Usuario.UsuarioId.ToString() + " | " + muestreoSeleccionado.Usuario.NombreCompleto;
            txtTipoMuestreo.Text = (muestreoSeleccionado as Individual).TipoDeMuestreo.ToString();
            txtObservaciones.Text = (muestreoSeleccionado as Individual).ObservacionesDeMuestreo;
            txtNumeroMuestreo.Text = (muestreoSeleccionado as Individual).NumeroDeMuestreo.ToString();

            // Pool
            // si el muestreo pertenece a un pool se obtienen todos los otros
            // muestreos que pertenecen al pool para agregar los resultados
            if((muestreoSeleccionado as Individual).Pool != null) {
                perteneceAPool = true;
                muestreosDelPool = (cPooles.ObtenerPool((muestreoSeleccionado as Individual).Pool.MuestreoId) as Pool).MuestreosDePool;

                fechaPool = (muestreoSeleccionado as Individual).Pool.FechaCreacionDePool;
                txtFechaPool.Text = fechaPool.ToShortDateString();

                descripcionPool = (muestreoSeleccionado as Individual).Pool.DescripcionDePool;
                txtDescripcionPool.Text = descripcionPool;

                grupoPool.Visible = true;
                txtAvisoPool.Visible = true;
                if(!(muestreoSeleccionado as Individual).Pool.FueAbierto) {
                    if(muestreoSeleccionado.EstaVerificado() && !muestreoSeleccionado.EstaHabilitado()) {
                        permitirSeparar = true;
                        btnSepararPool.Visible = true;
                    }
                }
            }
        }

        private void CambiarVisibilidadPaneles(bool producto, bool operario, bool horario) {
            panelProducto.Visible = producto;
            panelOperario.Visible = operario;
            txtHorario.Visible = horario;
        }

        private void LlenarTabla() {
            if(tabla.Rows.Count >0) {
                tabla.Clear();
            }
            foreach(Analisis analisis in muestreoSeleccionado.AnalisisDelMuestreo) {
                // definir valores según exista o no resultado
                var items = new Object[tabla.Columns.Count];
                items[0] = analisis.AnalisisId;
                items[1] = analisis.Ensayo.NombreDeEnsayo;
                items[2] = analisis.Ensayo.TipoDeAnalisis.ToString();
                if(analisis.FechaDeAnalisis == null) {
                    items[3] = null;
                } else {
                    items[3] = analisis.FechaDeAnalisis.Value.Date;
                }
                items[4] = analisis.OrigenDeAnalisis.ToString();
                items[5] = analisis.Laboratorio.NombreDeLaboratorio;
                if(analisis.Resultado != null) {
                    items[6] = analisis.UsuarioAnalista.NombreCompleto;
                    if(analisis.Resultado is Recuento) {
                        items[7] = (analisis.Resultado as Recuento).ValorDeResultadoRecuento.ToString();
                    } else {
                        items[7] = (analisis.Resultado as Deteccion).ValorDeResultadoDeteccion.ToString();
                    }
                    items[8] = analisis.Resultado.ObservacionesDeResultado;
                } else {
                    items[6] = "--";
                    items[7] = "--";
                    items[8] = "--";
                }
                items[11] = analisis.IntepretarResultado();
                if(analisis.FechaDeVerificacion != null) {
                    items[9] = analisis.FechaDeVerificacion.GetValueOrDefault().Date;
                    items[10] = analisis.UsuarioVerificador.NombreCompleto;
                } else {
                    items[9] = null;
                    if(SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario == EnumPermisoUsuario.Verificador) {
                        items[10] = "Verificar";
                    } else {
                        items[10] = "--";
                    }
                }

                DataRow dataRow = tabla.NewRow();
                dataRow.ItemArray = items;
                tabla.Rows.Add(dataRow);
            }
            tablaDatos.DataSource = tabla;
            tablaDatos.Columns["IdAnalisis"].Visible = false;
        }

        private void CambiarColor() {
            foreach(DataGridViewRow fila in tablaDatos.Rows) {
                EnumInterpretacionResultado estado = (EnumInterpretacionResultado)Enum.Parse(typeof(EnumInterpretacionResultado), fila.Cells[11].Value.ToString());
                switch(estado) {
                    case EnumInterpretacionResultado.Aceptable:
                        fila.Cells["Estado"].Style.BackColor = Color.Green;
                        fila.Cells["Estado"].Style.ForeColor = Color.White;
                        break;

                    case EnumInterpretacionResultado.Marginal:
                        fila.Cells["Estado"].Style.BackColor = Color.Black;
                        fila.Cells["Estado"].Style.ForeColor = Color.YellowGreen;
                        break;

                    default: // Inceptable
                        fila.Cells["Estado"].Style.BackColor = Color.Red;
                        fila.Cells["Estado"].Style.ForeColor = Color.White;
                        break;
                }
            }
            tablaDatos.Refresh();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SepararPool_Click(object sender, EventArgs e) {
            Form separarPool = SepararPool.GetInstancia((muestreoSeleccionado as Individual).Pool.MuestreoId);
            separarPool.MdiParent = this.MdiParent;
            separarPool.Show();
            separarPool.BringToFront();
        }

        private void AgregarResultado_Click(object sender, EventArgs e) {
            Form nuevoResultado = NuevoResultado.GetInstancia(muestreosDelPool.ToList(), analisisSeleccionado);
            nuevoResultado.MdiParent = this.MdiParent;
            SesionDeUsuario.AgregarFormularioAbierto(nuevoResultado);
            nuevoResultado.Show();
            nuevoResultado.BringToFront();
        }

        private void QuitarResultado_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Eliminar resultado?", "Resultado", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // si pertenece a un pool se eliminan todos los resultados del analisis para todos los muestreos del pool.
                if(perteneceAPool) {
                    foreach(Muestreo m in muestreosDelPool) {
                        cEnsayos.EliminarResultado(m.AnalisisDelMuestreo
                                                   .Single(a => a.Ensayo.EnsayoId == analisisSeleccionado.Ensayo.EnsayoId).AnalisisId);
                    }
                } else {
                    cEnsayos.EliminarResultado(analisisSeleccionado.AnalisisId);
                }
                MessageBox.Show("Se elimino el resultado!");
                ActualizarRegistros();
            }
        }

        private void VerificarResultado_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Verificar resultado?", "Verificacion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // si pertenece a un pool se verifican todos los resultados del analisis para todos los muestreos del pool.
                if(perteneceAPool) {
                    foreach(Muestreo m in muestreosDelPool) {
                        cEnsayos.VerificarResultado(m.AnalisisDelMuestreo
                                                    .Single(a => a.Ensayo.EnsayoId == analisisSeleccionado.Ensayo.EnsayoId).AnalisisId, SesionDeUsuario.UsuarioLogueado.UsuarioId);
                    }
                } else {
                    cEnsayos.VerificarResultado(analisisSeleccionado.AnalisisId, SesionDeUsuario.UsuarioLogueado.UsuarioId);
                }
                MessageBox.Show("Se verifico el resultado");
                Refresh();
                SesionDeUsuario.ActualizarFormulariosAbiertos(this);
            }
        }

        private void ConfirmarResultado_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Crear analisis para confirmar resultado?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // si pertenece a un pool se verifican todos los resultados del analisis para todos los muestreos del pool.
                if(perteneceAPool) {
                    foreach(Muestreo m in muestreosDelPool) {
                        cEnsayos.CrearNuevoAnalisis(analisisSeleccionado.Ensayo.EnsayoId, m.MuestreoId,
                                                    EnumMotivoAnalisis.Confirmacion, laboratorioSeleccionado.LaboratorioId);
                    }
                } else {
                    cEnsayos.CrearNuevoAnalisis(analisisSeleccionado.Ensayo.EnsayoId, muestreoSeleccionado.MuestreoId,
                                                EnumMotivoAnalisis.Confirmacion, laboratorioSeleccionado.LaboratorioId);
                }
                MessageBox.Show("Se agregó un analisis para confirmación.");
                Refresh();
                SesionDeUsuario.ActualizarFormulariosAbiertos(this);
            }
        }

        private void CboLaboratorio_SelectedItemChanged(object sender, EventArgs e) {
            laboratorioSeleccionado = laboratoriosRegistrados[(sender as ToolStripComboBox).SelectedItem.ToString()];
        }

        private void TablaDatosMouseDown(object sender, MouseEventArgs e) {
            int currentMouseOverRow = (sender as DataGridView).HitTest(e.X, e.Y).RowIndex;
            CambioFila(sender as DataGridView, currentMouseOverRow);
        }

        private void TablaDatosRowEnter(object sender, DataGridViewCellEventArgs e) {
            int currentMouseOverRow = e.RowIndex;
            CambioFila(sender as DataGridView, currentMouseOverRow);
        }

        private void CambioFila(DataGridView tabla, int filaActual) {
            if(filaActual >= 0) {
                tabla.Rows[filaActual].Selected = true;
                SeleccionarElemento(tabla, filaActual);
            } else {
                tablaDatos.ContextMenuStrip = CrearMenuContextual();
            }
        }

        private void SeleccionarElemento(DataGridView tabla, int filaActual) {
            try {
                analisisSeleccionado = muestreoSeleccionado.AnalisisDelMuestreo.Single(a => a.AnalisisId == ((int)(tabla.Rows[filaActual].Cells[0].Value)));
                bool agregar = false, quitar = false, verificar = false, confirmar = false;
                if(analisisSeleccionado.Resultado == null) {
                    agregar = true;
                }
                if(analisisSeleccionado.FechaDeVerificacion == null && analisisSeleccionado.Resultado != null) {
                    quitar = true;
                }
                if(analisisSeleccionado.Resultado != null && analisisSeleccionado.FechaDeVerificacion == null) {
                    verificar = true;
                }
                if(analisisSeleccionado.Resultado is Deteccion && analisisSeleccionado.FechaDeVerificacion!= null) {
                    if((analisisSeleccionado.Resultado as Deteccion).ValorDeResultadoDeteccion == EnumValorDeteccion.Potencial ||
                       (analisisSeleccionado.Resultado as Deteccion).ValorDeResultadoDeteccion == EnumValorDeteccion.Indeterminado) {
                        confirmar = true;
                    }
                }
                tablaDatos.ContextMenuStrip = CrearMenuContextual(agregar, quitar, verificar, confirmar, permitirSeparar);
            } catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void ActualizarRegistros() {
            muestreoSeleccionado = cMuestreos.ObtenerMuestreoIndividual(muestreoSeleccionado.MuestreoId);
            LlenarTabla();
            CambiarColor();
        }

        private void ResultadosFormClosing(object sender, FormClosingEventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            instancia = null;
        }

        public override void Refresh() {
            base.Refresh();
            ActualizarRegistros();
        }

        private void Resultados_Load(object sender, EventArgs e) {
            CambiarColor();
        }
        #region ICerrar implementation
        public void CerrarInstancia() {
            instancia = null;
        }

        #endregion

    }
}
