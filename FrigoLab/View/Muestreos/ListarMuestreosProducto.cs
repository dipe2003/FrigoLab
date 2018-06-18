/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 07/04/2018
 * Hora: 09:08 a.m.
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
    /// Description of LIstarMuestreosProducto.
    /// </summary>
    public partial class ListarMuestreosProducto:Form, ICerrar {

		private static ListarMuestreosProducto instancia;

		// Controladores
		private ControladorMuestreos cMuestreos = new ControladorMuestreos();

		// Datos
		private IEnumerable<Muestreo> muestreosRegistrados;
		private Muestreo muestreoSeleccionado;
        private IList<Muestreo> muestreosFiltrados = new List<Muestreo>();

        #region	Variables de Filtros
        private string claseMuestra = "Todas";
        private string estadoMuestreo = "Todos";
        private string sectorMuestreo = "Todos";
        private List<string> sectoresEnFiltro = new List<string>();

        // Fechas
        private DateTime fechaFaenaDesde;
		private DateTime fechaFaenaHasta;

		private DateTime fechaMuestreoDesde;
		private DateTime fechaMuestreoHasta;

		private DateTime fechaProduccionDesde;
		private DateTime fechaProduccionHasta;
        #endregion

        #region Variables Busqueda
        private bool buscarMuestra;
        private bool buscarIdentificacion;
        private string buscarTexto;
        #endregion

        private DataTable tabla;

		private ListarMuestreosProducto() {
			InitializeComponent();
			CrearTabla();
			CargarDatos();
			CalcularFechasIniciales();
			LlenarControlesFechas();
            LLenarComboSectores(true);

            // tabla
            tablaDatos.DataSource = tabla;
			tablaDatos.Columns["Id"].Visible = false;

			// Grupo Columna
			foreach(CheckBox chk in grupoTabla.Controls) {
				chk.CheckedChanged += CambiarVisibilidadColumna;
				tablaDatos.Columns[chk.Text].Visible = chk.Checked;
			}

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

            // Grupo Busqueda
            foreach(Control check in grupoBuscar.Controls) {
                if(check is CheckBox) {
                    (check as CheckBox).CheckedChanged += CriterioBusqueda;
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

		public static ListarMuestreosProducto GetInstancia() {
			if(instancia == null) {
				instancia = new ListarMuestreosProducto();
			}
			return instancia;
		}

		#region Datos

		private void CargarDatos() {
			muestreosRegistrados = cMuestreos.ListarMuestreosIndividuales()
				.Where(m => m.Muestra.EspecificacionDeMuestra.ClaseDeMuestra == EnumClaseMuestra.Producto)
				.OrderBy(m => (m.Muestra as Producto).FechaDeFaena);
			muestreosFiltrados = muestreosRegistrados
				.OrderBy(m => (m.Muestra as Producto).FechaDeFaena)
				.ToList();
			LlenarTabla();		
		}
		
		private void CalcularFechasIniciales(){
			if(muestreosFiltrados.Any()) {
				Individual primerMuestreo = muestreosFiltrados.FirstOrDefault() as Individual;
				Individual ultimoMuestreo = muestreosFiltrados.LastOrDefault() as Individual;

				// el rango más amplio de fechas va desde FechaFaenaDesde hasta FechaMuestreoHasta
				fechaFaenaDesde = (primerMuestreo.Muestra as Producto).FechaDeFaena;
				fechaFaenaHasta = (ultimoMuestreo.Muestra as Producto).FechaDeFaena;
				fechaMuestreoDesde = primerMuestreo.FechaHoraDeMuestreo;
				fechaMuestreoHasta = ultimoMuestreo.FechaHoraDeMuestreo;
				fechaProduccionDesde = (primerMuestreo.Muestra as Producto).FechaDeProduccion;
				fechaProduccionHasta = (ultimoMuestreo.Muestra as Producto).FechaDeProduccion;
			}
		}

		private void CrearTabla() {
			tabla = new DataTable();
			tabla.Columns.Add("Id", typeof(int)); // Columna oculta
			tabla.Columns.Add("Fecha Faena", typeof(DateTime));
			tabla.Columns.Add("Fecha Produccion", typeof(DateTime));
			tabla.Columns.Add("Fecha Muestreo", typeof(DateTime));
			tabla.Columns.Add("Sector", typeof(string));
			tabla.Columns.Add("Pool", typeof(string)); // fecha y nombre de pool (si aplica)
			tabla.Columns.Add("Muestra", typeof(string)); // NombreDeEspecificacion
			tabla.Columns.Add("Identificacion", typeof(string)); // Identificacion
			tabla.Columns.Add("Metodo", typeof(string)); // Destructivo o No Destructivo
			tabla.Columns.Add("Observaciones", typeof(string));
			tabla.Columns.Add("Destino/Mercado", typeof(string)); // NombreDeRequisitos
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

				StringBuilder estado = new StringBuilder();
				if(muestreo.EstaHabilitado()) {
					estado.Append("Habilitado");
				} else {
					estado.Append("No Habilitado");
					if(!muestreo.EstaAnalizado()) {
						estado.Append(" (Faltan Resultados)");
					} else {
						if(!muestreo.EstaVerificado()) {
							estado.Append(" (Falta Verificacion)");
						}
					}
				}
				StringBuilder pool = new StringBuilder();
				if((muestreo as Individual).Pool != null) {
					pool.Append((muestreo as Individual).Pool.DescripcionDePool);
					pool.Append(" | ");
					pool.Append((muestreo as Individual).Pool.FechaCreacionDePool.Date);
				}
				tabla.Rows.Add(muestreo.MuestreoId,
				               (m as Producto).FechaDeFaena.Date,
				               (m as Producto).FechaDeProduccion.Date,
				               (muestreo as Individual).FechaHoraDeMuestreo.Date,
				               m.Area.NombreDeArea,
				               pool,
				               m.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra,
				               m.IdentificacionDeMuestra,
				               (muestreo as Individual).TipoDeMuestreo.ToString(),
				               (muestreo as Individual).ObservacionesDeMuestreo,
				               requisitos.ToString(),
				               estado.ToString());
			}
			CambiarColor();
		}

		private void LlenarControlesFechas() {
            if(muestreosRegistrados.Any()) {
                pickerFaenaDesde.Value = fechaFaenaDesde;
                pickerFaenaHasta.Value = fechaFaenaHasta;
                pickerMuestreoDesde.Value = fechaMuestreoDesde;
                pickerMuestreoHasta.Value = fechaMuestreoHasta;
                pickerProduccionDesde.Value = fechaProduccionDesde;
                pickerProduccionHasta.Value = fechaProduccionHasta;
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

		#endregion

		#region	Acciones
		private void btnEditar_Click(object sender, EventArgs e) {
			if(muestreoSeleccionado != null) {
				Form editarMuestreo = EditarMuestreo.GetInstancia(muestreoSeleccionado.MuestreoId);
				SesionDeUsuario.AgregarFormularioAbierto(editarMuestreo);
				editarMuestreo.MdiParent = this.MdiParent;
				editarMuestreo.Show();
				editarMuestreo.BringToFront();
			} else {
				MessageBox.Show("No hay muestreo seleccionado");
			}
		}

		private void btnResultado_Click(object sender, EventArgs e) {
			if(muestreoSeleccionado != null) {
				Form resultados = Resultados.Resultados.GetInstancia(muestreoSeleccionado.MuestreoId);
				SesionDeUsuario.AgregarFormularioAbierto(resultados);
				resultados.MdiParent = this.MdiParent;
				resultados.Show();
				resultados.BringToFront();
			} else {
				MessageBox.Show("No hay muestreo seleccionado");
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e) {
			if(muestreoSeleccionado!=null) {
				if((muestreoSeleccionado as Individual).Pool != null) {
					MessageBox.Show("No se puede eliminar porque el muestreo pertenece a un pool.");
				} else {
					if(MessageBox.Show("Seguro que quiere eliminar el muestreo seleccionado? \n" +
					                   "Esta accion no se puede deshacer.", "Eliminar Muestreo?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
						if(cMuestreos.EliminarMuestreo(muestreoSeleccionado.MuestreoId)) {
							MessageBox.Show("Se elimino");
							this.Refresh();
						} else {
							MessageBox.Show("No se elimino");
						}
					}
				}
			} else {
				MessageBox.Show("No hay muestreo seleccionado.");
			}

		}

		private void BtnVerMuestreoClick(object sender, EventArgs e) {
			if(muestreoSeleccionado != null) {
				Form vistaRegistro = new VistaMuestreo(muestreoSeleccionado.MuestreoId);
				SesionDeUsuario.AgregarFormularioAbierto(vistaRegistro);
				vistaRegistro.MdiParent = this.MdiParent;
				vistaRegistro.Show();
				vistaRegistro.BringToFront();
			} else {
				MessageBox.Show("No hay muestreo seleccionado");
			}
		}

        #endregion

        #region	Filtros
        private void FiltrarTabla() {
            muestreosFiltrados = FiltrarFechas(muestreosRegistrados.ToList());
            muestreosFiltrados = FiltrarClase(claseMuestra, muestreosFiltrados.ToList());
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

        #region Filtro::Clase de Muestra
        private void GrupoTipos_CheckedChanged(object sender, EventArgs e) {
            claseMuestra = (sender as RadioButton).Text;
            FiltrarTabla();
        }

        private List<Muestreo> FiltrarClase(string clase, List<Muestreo> muestreosAFiltrar) {
            if(clase!= "Todas") {
                EnumClaseMuestra filtro = (EnumClaseMuestra)(Enum.Parse(typeof(EnumClaseMuestra), clase));
                return muestreosAFiltrar
                     .Where(m => m.Muestra.EspecificacionDeMuestra.ClaseDeMuestra == filtro)
                         .OrderBy(m => m.Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra)
                         .ToList();
            }
            return muestreosAFiltrar
                    .OrderBy(m => m.Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra)
                    .ToList();
        }
        #endregion

        #region Filtro::Fechas
        private List<Muestreo> FiltrarFechas(List<Muestreo> muestreosAfiltrar) {
            return muestreosAfiltrar
               .Where(m => (m.Muestra as Producto).FechaDeFaena >= fechaFaenaDesde)
                .Where(m => (m.Muestra as Producto).FechaDeFaena <= fechaFaenaHasta)
                .Where(m => (m.Muestra as Producto).FechaDeProduccion >= fechaProduccionDesde)
                .Where(m => (m.Muestra as Producto).FechaDeProduccion <= fechaProduccionHasta)
                .Where(m => (m as Individual).FechaHoraDeMuestreo >= fechaMuestreoDesde)
                .Where(m => (m as Individual).FechaHoraDeMuestreo <= fechaMuestreoHasta)
                .ToList();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e) {
            string picker = (sender as DateTimePicker).Name;
            switch(picker) {
                case "pickerFaenaDesde":
                    fechaFaenaDesde = (sender as DateTimePicker).Value;
                    break;
                case "pickerFaenaHasta":
                    fechaFaenaHasta= (sender as DateTimePicker).Value;
                    break;
                case "pickerProduccionDesde":
                    fechaProduccionDesde = (sender as DateTimePicker).Value;
                    break;
                case "pickerProduccionHasta":
                    fechaProduccionHasta = (sender as DateTimePicker).Value;
                    break;
                case "pickerMuestreoDesde":
                    fechaMuestreoDesde = (sender as DateTimePicker).Value;
                    break;
                default:
                    fechaMuestreoHasta = (sender as DateTimePicker).Value;
                    break;
            }
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
            txtBuscarTexto.Clear();
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
				muestreoSeleccionado = muestreosFiltrados.Single(m => m.MuestreoId == ((int)(tabla.Rows[filaActual].Cells[0].Value)));
				tablaDatos.ContextMenuStrip = CrearMenuContextual(true);
			} catch(Exception ex) { }
		}

		private void CambiarVisibilidadColumna(object sender, EventArgs e) {
			tablaDatos.Columns[(sender as CheckBox).Text].Visible = (sender as CheckBox).Checked;
		}

		private ContextMenuStrip CrearMenuContextual(bool seleccion = false) {
			ContextMenuStrip ctxMenuStrip = new ContextMenuStrip();
			if(!seleccion) {
				ctxMenuStrip.Items.Add("No hay acciones disponibles", Properties.Resources.imagen_no_disponible);
			} else {
				ctxMenuStrip.Items.Add("&Ver", Properties.Resources.imagen_ver_detalle, new EventHandler(BtnVerMuestreoClick));
                if(SesionDeUsuario.PermisoUsuario() != EnumPermisoUsuario.Visitante) {
                    if(SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Administrador ||
                        SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Verificador||
                        SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Monitor) {
                        ctxMenuStrip.Items.Add("&Editar", Properties.Resources.imagen_editar, btnEditar_Click);
                        ctxMenuStrip.Items.Add("E&liminar", Properties.Resources.imagen_eliminar, btnEliminar_Click);
                    }
                    ctxMenuStrip.Items.Add("&Resultado", Properties.Resources.imagen_resultados, btnResultado_Click);
                }
            }
			return ctxMenuStrip;
		}

		private void ListarMuestreosProductoFormFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			instancia = null;
		}

		public override void Refresh() {
			base.Refresh();
			CargarDatos();
			radioTodos.Checked = true;
		}

		private void ListarMuestreosProducto_Load(object sender, EventArgs e) {
			CambiarColor();
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

