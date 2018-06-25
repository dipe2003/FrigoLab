/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 05/04/2018
 * Hora: 07:03 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Clases.Requisitos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Muestreos;
using FrigLab.Model.Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrigLab.View.Muestreos {
    /// <summary>
    /// Description of ListarMuestreos.
    /// </summary>
    public partial class ListarOtrosMuestreos:Form, ICerrar {

		private static ListarOtrosMuestreos instancia;

		// Controladores
		private ControladorMuestreos cMuestreos = new ControladorMuestreos();

		// Datos
		private IList<Muestreo> muestreosFiltrados = new List<Muestreo>();
		private IEnumerable<Muestreo> muestreosRegistrados;
		private Muestreo muestreoSeleccionado;

		private DataTable tabla;

        #region	Variables de Filtros

        private string estadoMuestreo = "Todos";
        private string sectorMuestreo = "Todos";
        private List<string> sectoresEnFiltro = new List<string>();

        // Fechas		
        private DateTime fechaMuestreoDesde;
        private DateTime fechaMuestreoHasta;
        #endregion

        #region Variables Busqueda
        private bool buscarMuestra;
        private bool buscarIdentificacion;
        private string buscarTexto;
        #endregion

        private ListarOtrosMuestreos() {
			InitializeComponent();
			CrearTabla();
			CargarDatos();
			CalcularFechasIniciales();
			LlenarControlesFechas();
            LLenarComboSectores(true);

            // tabla
            tablaDatos.DataSource = tabla;
			tablaDatos.Columns["Id"].Visible = false;
			
			// Grupo Estado
			foreach(RadioButton radio in grupoEstado.Controls) {
				radio.CheckedChanged += GrupoEstado_CheckedChanged;
			}
			
			// Grupo Fechas
			foreach(Control picker in grupoFecha.Controls) {
				if(picker is DateTimePicker) {
					(picker as DateTimePicker).ValueChanged += DateTimePicker_ValueChanged;
				}
			}

            // Grupo Sectores
            cboSector.DataSource = sectoresEnFiltro;
            sectorMuestreo = "Todos";
            cboSector.Text = sectorMuestreo;

            // Menu Contextual
            tablaDatos.ContextMenuStrip = CrearMenuContextual();

            muestreoSeleccionado = muestreosFiltrados.FirstOrDefault();

            //bloquear Controles por permiso
            if(SesionDeUsuario.HaySesionIniciada()) {
                BloquearComponentes(SesionDeUsuario.PermisoUsuario());
            }
        }

		public static ListarOtrosMuestreos GetInstancia() {
			if(instancia == null) {
				instancia = new ListarOtrosMuestreos();
			}
			return instancia;
		}

		#region Datos

		private void CargarDatos() {
			muestreosRegistrados = cMuestreos.ListarMuestreosIndividuales()
				.Where(m => m.Muestra.EspecificacionDeMuestra.ClaseDeMuestra == EnumClaseMuestra.Otra)
				.OrderBy(m => m.Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra);
			muestreosFiltrados = muestreosRegistrados
				.OrderBy(m => m.Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra)
				.ToList();
			LlenarTabla();
		}
		
		private void CalcularFechasIniciales(){
			if(muestreosFiltrados.Any()) {
				Individual primerMuestreo = muestreosFiltrados.FirstOrDefault() as Individual;
				Individual ultimoMuestreo = muestreosFiltrados.LastOrDefault() as Individual;

				fechaMuestreoDesde = primerMuestreo.FechaHoraDeMuestreo;
				fechaMuestreoHasta = ultimoMuestreo.FechaHoraDeMuestreo;
			}
		}

		private void CrearTabla() {
			tabla = new DataTable();
			tabla.Columns.Add("Id", typeof(int)); // Columna oculta
			tabla.Columns.Add("Fecha Muestreo", typeof(DateTime));
			tabla.Columns.Add("Sector", typeof(string));
			tabla.Columns.Add("Muestra", typeof(string)); // NombreDeEspecificacion
			tabla.Columns.Add("Identificacion", typeof(string)); // Identificacion
			tabla.Columns.Add("Conacto con Producto", typeof(string)); // En contacto o no con el producto
			tabla.Columns.Add("Repeticion", typeof(string));
			tabla.Columns.Add("Observaciones", typeof(string));
			tabla.Columns.Add("Destino/Mercado", typeof(string)); // NombreDeRequisitos
			tabla.Columns.Add("Monitor", typeof(string)); // IdOperario + NombreCompletoOperario
			tabla.Columns.Add("Almacenamiento", typeof(string));
			tabla.Columns.Add("Estado", typeof(string));
		}

		private void LlenarTabla() {
			if(tabla.Rows.Count != 0) {
				tabla.Clear();
			}

			foreach(Muestreo muestreo in muestreosFiltrados) {
				Muestra m = muestreo.Muestra;
				StringBuilder requisitos = new StringBuilder();
				if(muestreo.AnalisisDelMuestreo.Any()) {
					for(int i = 0; i < muestreo.AnalisisDelMuestreo.Count; i++) {
						Analisis analisis = muestreo.AnalisisDelMuestreo.ElementAt(i);
						requisitos.Append(analisis.Ensayo.NombreDeEnsayo).Append(": ");
						List<Limite> limites = analisis.Ensayo.LimitesDeEnsayo.Where(l => l.FechaNoVigente == null).ToList();
						int contador = 0;
						while(contador < limites.Count) {
							Limite limite = limites.ElementAt(contador);
							requisitos.Append(limite.Requisito.NombreDeRequisito);
							contador++;
							if(contador<limites.Count) {
								requisitos.Append(" / ");
							}
						}
						if(i+1 < muestreo.AnalisisDelMuestreo.Count) {
							requisitos.AppendLine();
						}
					}
				} else {
					requisitos.Append("---");
				}
				string repeticion = "No";
				if(m.EsRepeticion) {
					repeticion = "Si";
				}
				string contacto = "No";
				if((m as Superficie).EnContactoConProducto) {
					contacto = "Si";
				}
				StringBuilder estado = new StringBuilder();
				if(muestreo.EstaHabilitado()){
					estado.Append("Habilitado");
				}else{
					estado.Append("No Habilitado");
					if(!muestreo.EstaAnalizado()) {
						estado.Append(" (Faltan Resultados)");
					} else {
						if(!muestreo.EstaVerificado()) {
							estado.Append(" (Falta Verificacion)");
						}
					}
				}
				tabla.Rows.Add(muestreo.MuestreoId,
				               (muestreo as Individual).FechaHoraDeMuestreo,
				               m.EspecificacionDeMuestra.ClaseDeMuestra,
				               m.Area.NombreDeArea,
				               m.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra,
				               m.IdentificacionDeMuestra,
				               repeticion,
				               contacto,
				               (muestreo as Individual).ObservacionesDeMuestreo,
				               requisitos.ToString(),
				               muestreo.Usuario.UsuarioId.ToString() + " | " + muestreo.Usuario.NombreCompleto,
				               (muestreo as Individual).AlmacenamientoDeMuestreo.ToString(),
				               estado.ToString());
			}
			CambiarColor();
		}

		private void CambiarColor() {
			foreach(DataGridViewRow fila in tablaDatos.Rows) {
				string estado = (string)(fila.Cells["Estado"].Value);
				if(estado == "Habilitado") {
					fila.Cells["Estado"].Style.BackColor = Color.Green;
					fila.Cells["Estado"].Style.ForeColor = Color.White;
				} else {
					fila.Cells["Estado"].Style.BackColor = Color.Red;
					fila.Cells["Estado"].Style.ForeColor = Color.White;
				}
			}
			tablaDatos.Refresh();
		}

		private void LlenarControlesFechas() {
            if(muestreosRegistrados.Any()) {
                pickerMuestreoDesde.Value = fechaMuestreoDesde;
                pickerMuestreoHasta.Value = fechaMuestreoHasta;
            }
		}

        private void LLenarComboSectores(bool inicio) {
            List<string> nombreSectores = new List<string>();
            if(inicio) {
                var sectores = from m in muestreosRegistrados
                               select m.Muestra.Area.NombreDeArea;
                nombreSectores = sectores.Distinct().ToList();
                nombreSectores.Add("Todos");
            } else {
                if(muestreosFiltrados.Any()) {
                    var sectores = from m in muestreosFiltrados
                                   select m.Muestra.Area.NombreDeArea;
                    nombreSectores = sectores.Distinct().ToList();
                    nombreSectores.Add("Todos");
                } else {
                    var sectores = new List<string> { "Todos" };
                }
            }
            sectoresEnFiltro = nombreSectores;
            cboSector.Text = sectorMuestreo =="Todos" ? "Todos" : sectoresEnFiltro.FirstOrDefault();
        }
        #endregion

        #region	Acciones
        private void btnEditar_Click(object sender, EventArgs e) {
			if (muestreoSeleccionado != null){
				Form editarMuestreo = EditarMuestreo.GetInstancia(muestreoSeleccionado.MuestreoId);
				editarMuestreo.MdiParent = this.MdiParent;
				editarMuestreo.Show();
				editarMuestreo.BringToFront();
			}else{
				MessageBox.Show("No hay muestreo seleccionado");
			}
		}
		
		private void btnResultado_Click(object sender, EventArgs e) {
			if (muestreoSeleccionado != null){
				Form resultados = Resultados.Resultados.GetInstancia(muestreoSeleccionado.MuestreoId);
				SesionDeUsuario.AgregarFormularioAbierto(resultados);
				resultados.MdiParent = this.MdiParent;
				resultados.Show();
				resultados.BringToFront();
			}else{
				MessageBox.Show("No hay muestreo seleccionado");
			}
		}
		
		private void BtnVerMuestreoClick(object sender, EventArgs e) {
			if (muestreoSeleccionado != null){
				Form vistaRegistro = new VistaMuestreo(muestreoSeleccionado.MuestreoId);
				SesionDeUsuario.AgregarFormularioAbierto(vistaRegistro);
				vistaRegistro.MdiParent = this.MdiParent;
				vistaRegistro.Show();
				vistaRegistro.BringToFront();
			}else{
				MessageBox.Show("No hay muestreo seleccionado");
			}
		}
		
		private void btnEliminar_Click(object sender, EventArgs e) {
			if(muestreoSeleccionado!=null) {
				if(MessageBox.Show("Seguro que quiere eliminar el muestreo seleccionado? \n" +
				                   "Esta accion no se puede deshacer.", "Eliminar Muestreo?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
					if(cMuestreos.EliminarMuestreo(muestreoSeleccionado.MuestreoId)) {
						MessageBox.Show("Se elimino");
						this.Refresh();
					} else {
						MessageBox.Show("No se elimino");
					}
				}
			} else {
				MessageBox.Show("No se elimino");
			}
		}
        #endregion

        #region	Filtros
        private void FiltrarTabla() {
            muestreosFiltrados = FiltrarFechas(muestreosRegistrados.ToList());
            muestreosFiltrados = FiltrarEstados(estadoMuestreo, muestreosFiltrados.ToList());
            muestreosFiltrados = FiltrarSectores(sectorMuestreo, muestreosFiltrados.ToList());
            LlenarTabla();
            LLenarComboSectores(false);
        }

        #region Filtro::Estado
        private void GrupoEstado_CheckedChanged(object sender, EventArgs e) {
            estadoMuestreo = (sender as RadioButton).Text;
            FiltrarTabla();
        }

        private List<Muestreo> FiltrarEstados(string estado, List<Muestreo> muestreoAfiltrar) {
            switch(estado) {
                case "Habilitados":
                    return muestreoAfiltrar.Where(m => m.EstaHabilitado()).ToList();

                case "No Habilitados":
                    return muestreoAfiltrar.Where(m => !m.EstaHabilitado()).ToList();

                default:
                    return muestreoAfiltrar.ToList();
            }
        }

        #endregion
        
        #region Filtro::Fechas
        private List<Muestreo> FiltrarFechas(List<Muestreo> muestreosAfiltrar) {
            return muestreosAfiltrar
               .Where(m => (m as Individual).FechaHoraDeMuestreo >= fechaMuestreoDesde)
               .Where(m => (m as Individual).FechaHoraDeMuestreo <= fechaMuestreoHasta)
               .ToList();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e) {
            string picker = (sender as DateTimePicker).Name;
            switch(picker) {
                case "pickerMuestreoDesde":
                    fechaMuestreoDesde = (sender as DateTimePicker).Value;
                    break;
                default:
                    fechaMuestreoHasta = (sender as DateTimePicker).Value;
                    break;
            }
            if(fechaMuestreoDesde.Date > fechaMuestreoHasta) fechaMuestreoHasta = fechaMuestreoDesde;
            FiltrarTabla();
        }
        #endregion

        #region Filtro::Sectores
        private List<Muestreo> FiltrarSectores(string sector, List<Muestreo> muestreoAFiltrar) {
            if(string.IsNullOrEmpty(sector) || sector=="Todos") {
                return muestreoAFiltrar;
            }
            return muestreoAFiltrar.Where(m => m.Muestra.Area.NombreDeArea == sector).ToList();
        }

        private void CboSectores_SelectedIndexChanged(object sender, EventArgs e) {
            sectorMuestreo = (sender as ComboBox).Text;
            FiltrarTabla();
        }

        #endregion

        private void BorrarFiltros(object sender, EventArgs e) {
            foreach(Control txtbox in grupoBuscar.Controls) {
                if(txtbox is TextBox) {
                    (txtbox as TextBox).Clear();
                    (txtbox as TextBox).Enabled = true;
                }
            }
            this.Refresh();
            CalcularFechasIniciales();
            LlenarControlesFechas();
            LLenarComboSectores(true);
        }

        #endregion

        #region Busqueda
        private void CriterioBusqueda(object sender, EventArgs e) {
            if((sender as CheckBox).Text == "Muestra") {
                buscarMuestra = ((sender as CheckBox).Checked);
            }
            if((sender as CheckBox).Text == "Identificacion") {
                buscarIdentificacion = ((sender as CheckBox).Checked);
            }
        }

        private void bntBuscar_Click(object sender, EventArgs e) {
            buscarTexto =  txtBuscarTexto.Text;
            BuscarEnMuestreos();
        }

        private void BuscarEnMuestreos() {
            if(buscarMuestra && buscarIdentificacion) {
                muestreosFiltrados =  muestreosFiltrados
                    .Where(m => m.Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra.ToLower().Contains(buscarTexto.ToLower())
                    || m.Muestra.IdentificacionDeMuestra.ToLower().Contains(buscarTexto.ToLower()))
                    .ToList();
                LlenarTabla();
            } else if(buscarMuestra && !buscarIdentificacion) {
                muestreosFiltrados =  muestreosFiltrados
                    .Where(m => m.Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra.ToLower().Contains(buscarTexto.ToLower()))
                    .ToList();
                LlenarTabla();
            } else if(!buscarMuestra && buscarIdentificacion) {
                muestreosFiltrados =  muestreosFiltrados
                    .Where(m => m.Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra.ToLower().Contains(buscarTexto.ToLower()))
                    .ToList();
                LlenarTabla();
            } else if(!buscarMuestra && !buscarIdentificacion) {
                MessageBox.Show("No se selecciono criterio de busqueda.");
            }
        }
        #endregion

        private void TablaDatosMouseDown(object sender, MouseEventArgs e) {
			int currentMouseOverRow = (sender as DataGridView).HitTest(e.X,e.Y).RowIndex;
			CambioFila(sender as DataGridView, currentMouseOverRow);
		}
		
		private void TablaDatosRowEnter(object sender, DataGridViewCellEventArgs e) {
			int currentMouseOverRow = e.RowIndex;
			CambioFila(sender as DataGridView, currentMouseOverRow);
		}
		
		private void CambioFila(DataGridView tabla, int filaActual){
			if (filaActual >= 0){
				tabla.Rows[filaActual].Selected = true;
				SeleccionarElemento(tabla, filaActual);
			}else{
				tablaDatos.ContextMenuStrip = CrearMenuContextual();
			}
		}
		
		private void SeleccionarElemento(DataGridView tabla, int filaActual){
			try{
				muestreoSeleccionado = muestreosFiltrados.Single(m=>m.MuestreoId == ((int)(tabla.Rows[filaActual].Cells[0].Value)));
				tablaDatos.ContextMenuStrip = CrearMenuContextual(true);
			} catch (Exception ex){}
		}

		private ContextMenuStrip CrearMenuContextual(bool seleccion = false){
			ContextMenuStrip ctxMenuStrip = new ContextMenuStrip();
			if(!seleccion){
				ctxMenuStrip.Items.Add("No hay acciones disponibles", Properties.Resources.imagen_no_disponible);
			} else {
				ctxMenuStrip.Items.Add("&Ver", Properties.Resources.imagen_ver_detalle, BtnVerMuestreoClick);
                if(SesionDeUsuario.PermisoUsuario() != EnumPermisoUsuario.Visitante) {
                    if(SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Administrador ||
                        SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Verificador ||
                        SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Monitor) {
                        ctxMenuStrip.Items.Add(new ToolStripSeparator());
                        ctxMenuStrip.Items.Add("&Editar", Properties.Resources.imagen_editar, btnEditar_Click);
                        ctxMenuStrip.Items.Add("E&liminar", Properties.Resources.imagen_eliminar, btnEliminar_Click);
                    }
                    ctxMenuStrip.Items.Add("&Resultado", Properties.Resources.imagen_resultados, btnResultado_Click);
                }
            }
			return ctxMenuStrip;
		}
		
		private void ListarMuestreosFormFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			instancia = null;
		}
		
		private void ListarOtrosMuestreos_Load(object sender, EventArgs e) {
			CambiarColor();
		}
		
		public override void Refresh() {
			base.Refresh();
			CargarDatos();
			CalcularFechasIniciales();
			LlenarControlesFechas();
			radioTodos.Checked = true;
		}
		
		private void TablaDatosSorted(object sender, EventArgs e) {
			CambiarColor();
		}
		#region ICerrar implementation
		public void CerrarInstancia() {
			instancia = null;
		}
		#endregion
	}
}
