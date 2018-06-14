using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Clases.Requisitos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Muestreos;
using FrigLab.Model.Logica.Muestras;
using FrigLab.Model.Logica.Muestreos;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrigLab.View.Muestreos {
    public partial class NuevoMuestreo:Form, ICerrar {
		private static NuevoMuestreo instancia;

		private ControladorAreas cAreas = new ControladorAreas();
		private ControladorMuestras cMuestras = new ControladorMuestras();
		private ControladorEnsayos cEnsayos = new ControladorEnsayos();
		private ControladorMuestreos cMuestreos = new ControladorMuestreos();

        #region Datos de Muestreo
        private IEnumerable<Area> areas;
		private Area areaSeleccionada;
		private int numero;
		private DateTime fechaMuestreo = new DateTime();
		private string observaciones;
		private EnumAlmacenamientoMuestreo almacenamiento;
		private EnumTipoMuestreo tipoMuestreo;
		#endregion

		#region Datos de Muestra
		private IEnumerable<EspecificacionDeMuestra> muestras;
		private IEnumerable<EspecificacionDeMuestra> muestrasFiltradas;
		private EnumClaseMuestra claseDeMuestra;
		private EspecificacionDeMuestra especificacionSeleccionada;
		private bool esRepeticion;
		private string identificacion;

		// Producto
		private DateTime fechaFaena;
		private DateTime fechaProduccion;
		private string loteProducto;

		// Superficie y Ambiente
		private bool enContactoProducto;
		private EnumHorario horarioMuestreo;

		// Operario
		private int padronOperario;
		private string nombreOperario;
		#endregion

		#region Analisis
		private DataTable tabla;
		private IList<Ensayo> ensayosSeleccionados = new List<Ensayo>();
		private IList<Ensayo> ensayosRegistrados;
		private IList<Ensayo> ensayosCombo;
		private Ensayo ensayoSeleccionado;
		private IEnumerable<Laboratorio> laboratorios;
		private IDictionary<int, Laboratorio> laboratoriosDeEnsayo = new Dictionary<int, Laboratorio>();
		private Laboratorio laboratorioSeleccionado;

		#endregion

		// constructor
		private NuevoMuestreo(EnumClaseMuestra clase) {
			claseDeMuestra = clase;
			InitializeComponent();
			CrearTabla();

			// Clase de muestreo
			foreach(RadioButton radio in grupoClase.Controls) {
				if(radio.Text ==  claseDeMuestra.ToString()) {
					radio.Checked = true;
					GrupoClase_Click(radio, null);
				}
			}

			// almacenamiento
			foreach(RadioButton radio in grupoAlmacenamiento.Controls) {
				radio.CheckedChanged += GrupoAlmacenamiento_Click;
			}
			radioHeladera.Checked = true;

			// tipo
			foreach(RadioButton radio in grupoTipoMuestreo.Controls) {
				radio.CheckedChanged += GrupoTipoMuestreo_Click;
			}
			radioDestructivo.Checked = true;

			// clase
			foreach(RadioButton radio in grupoClase.Controls) {
				radio.CheckedChanged += GrupoClase_Click;
			}

			// horario
			foreach(RadioButton radio in grupoHorario.Controls) {
				radio.CheckedChanged += GrupoHorario_Click;
			}
			radioPreoperativo.Checked = true;

			// tabla
			tablaDatos2.DataSource = tabla;
			tablaDatos2.Columns["Id"].Visible = false;
		}

		public static NuevoMuestreo GetInstancia(EnumClaseMuestra claseMuestra) {
			if(instancia==null) {
				instancia =  new NuevoMuestreo(claseMuestra);
			}
			return instancia;
		}

		#region	Datos
		private void CargarDatos() {
			// combo Areas
			areas = cAreas.ListarAreas(false).ToList();
			cboArea.DataSource = areas;
			cboArea.DisplayMember = "NombreDeArea";

			areaSeleccionada = areas.FirstOrDefault();
			cboArea.SelectedItem = areaSeleccionada;

			// combo Muestras
			muestras = cMuestras.ListarEspecificacionesDeMuestras(false).ToList();
			ActualizarMuestras();

			cboMuestras.DataSource = muestrasFiltradas;
			cboMuestras.DisplayMember = "NombreDeEspecificacionDeMuestra";

			// Combo Analisis
			ensayosRegistrados = cEnsayos.ListarEnsayos().ToList();
			ensayosCombo = ensayosRegistrados
				.Where(e=>e.ClaseDeMuestra == claseDeMuestra)
				.Where(e=>e.LimitesDeEnsayo.Any())
				.ToList();
			ActualizarEnsayos();

			// Combo Laboratorios
			laboratorios = cEnsayos.ListarLaboratorios();
			cboLaboratorios.DataSource = laboratorios;
			cboLaboratorios.DisplayMember = "NombreDeLaboratorio";
			laboratorioSeleccionado = laboratorios.FirstOrDefault();
			cboLaboratorios.SelectedItem = laboratorioSeleccionado;
		}

		private void ActualizarMuestras() {
			muestrasFiltradas = areaSeleccionada.EspecificacionesDeMuestras
				.Where(esp => esp.ClaseDeMuestra == claseDeMuestra)
				.ToList();

			especificacionSeleccionada = muestrasFiltradas.FirstOrDefault();
			cboMuestras.DataSource = muestrasFiltradas.ToList();
			cboMuestras.SelectedItem = muestrasFiltradas.FirstOrDefault();
		}

		private void ActualizarEnsayos() {
			cboAnalisis.DataSource = ensayosCombo.ToList();
			cboAnalisis.DisplayMember = "NombreDeEnsayo";
			ensayoSeleccionado = ensayosCombo.FirstOrDefault();
			cboAnalisis.SelectedItem = ensayoSeleccionado;
			if(ensayoSeleccionado == null) {
				btnAgregarAnalisis.Enabled = false;
			} else {
				btnAgregarAnalisis.Enabled = true;
			}
		}

		private void ActualizarTabla() {
			if(tabla.Rows.Count != 0) {
				tabla.Clear();
			}
			foreach(Ensayo ensayo in ensayosSeleccionados) {
				StringBuilder requisitos = new StringBuilder();
				if(!ensayo.LimitesDeEnsayo.Any()) {
					requisitos.Append("-");
				} else {
					List<Limite> limites = ensayo.LimitesDeEnsayo.Where(l => l.FechaNoVigente == null).ToList();
					int total = limites.Count;
					
					for(int i = 0; i < total; i++) {
						Limite limite = limites.ElementAt(i);
						requisitos.Append(limite.Requisito.NombreDeRequisito);
						if(i+1 < total) {
							requisitos.Append("\n");
						} else {
							requisitos.Append(".");
						}
					}
				}
				tabla.Rows.Add(
					ensayo.EnsayoId,
					ensayo.NombreDeEnsayo,
					laboratoriosDeEnsayo[ensayo.EnsayoId].NombreDeLaboratorio,
					requisitos.ToString(),
					"Quitar"
				);
			}
		}
		#endregion

		#region	Muestras

		private void CrearTabla() {
			tabla = new DataTable();
			tabla.Columns.Add("Id", typeof(int));
			tabla.Columns.Add("Ensayo", typeof(string));
			tabla.Columns.Add("Laboratorio", typeof(string));
			tabla.Columns.Add("Requisito/Destino", typeof(string));
			tabla.Columns.Add("...", typeof(string));
		}
		private void GrupoClase_Click(object sender, EventArgs e) {
			claseDeMuestra = (EnumClaseMuestra)Enum.Parse(typeof(EnumClaseMuestra), (sender as RadioButton).Text);
			CargarDatos();
			// Mostrar u Ocultar controles segun Clase de Muestra
			switch(claseDeMuestra) {
				case EnumClaseMuestra.Producto:
					CambiarVisibilidadPaneles(true, false, false, false);
					break;

				case EnumClaseMuestra.Operario:
					CambiarVisibilidadPaneles(false, true, false, true);
					break;

					// clases Otra, Superficie y Ambiente usan los mismos controles
				default:
					CambiarVisibilidadPaneles(false, false, true, true);
					break;
			}
		}

		private void GrupoHorario_Click(object sender, EventArgs e) {
			horarioMuestreo = (EnumHorario)Enum.Parse(typeof(EnumHorario), (sender as RadioButton).Text);
		}

		private void CambiarVisibilidadPaneles(bool producto, bool operario, bool contacto, bool horario) {
			panelProducto.Visible = producto;
			panelOperario.Visible = operario;
			chkContactoProducto.Visible = contacto;
			grupoHorario.Visible = horario;
		}

		private void AreaMuestreoSelected(object sender, EventArgs e) {
			areaSeleccionada = cboArea.SelectedItem as Area;
			if(muestras!=null) {
				ActualizarMuestras();
			}
		}

		private void BtnAgregarAnalisisClick(object sender, EventArgs e) {
			ensayosSeleccionados.Add(ensayoSeleccionado);
			ensayosCombo.Remove(ensayoSeleccionado);
			// laboratorio seleccionado para el analisis se guarda en diccionario con Key=Idensayo
			laboratoriosDeEnsayo.Add(ensayoSeleccionado.EnsayoId, laboratorioSeleccionado);
			ActualizarEnsayos();
			ActualizarTabla();
		}

		private void TablaDatos_CellClick(object sender, DataGridViewCellEventArgs e) {
			try {
				ensayoSeleccionado = ensayosSeleccionados
					.Single(en => en.EnsayoId == ((int)(tablaDatos2.CurrentRow.Cells[0].Value)));
				if((tablaDatos2.CurrentCell).ColumnIndex == 3) {
					ensayosCombo.Add(ensayoSeleccionado);
					ensayosSeleccionados.Remove(ensayoSeleccionado);
					laboratoriosDeEnsayo.Remove(ensayoSeleccionado.EnsayoId);
					ActualizarEnsayos();
					ActualizarTabla();
				}
			} catch(Exception) { }
		}

		private void CboAnalisisSelectedValueChanged(object sender, EventArgs e) {
			ensayoSeleccionado = (Ensayo)cboAnalisis.SelectedItem;
		}

		private void PickerFechaMuestreo_ValueChanged(object sender, EventArgs e) {
			fechaMuestreo = (sender as DateTimePicker).Value;
		}

		private void PickerFechaFaena_ValueChanged(object sender, EventArgs e) {
			fechaFaena = (sender as DateTimePicker).Value;
		}

		private void PickerFechaProduccion_ValueChanged(object sender, EventArgs e) {
			fechaProduccion = (sender as DateTimePicker).Value;
		}

		private void ChkRepeticionCheckedChanged(object sender, EventArgs e) {
			if((sender as CheckBox).Checked) {
				esRepeticion = true;
			} else {
				esRepeticion = false;
			}
		}

		private void ChkContactoProductoCheckedChanged(object sender, EventArgs e) {
			if((sender as CheckBox).Checked) {
				enContactoProducto = true;
			} else {
				enContactoProducto = false;
			}
		}

		private void CboLaboratorios_SelectedValueChanged(object sender, EventArgs e) {
			laboratorioSeleccionado = (Laboratorio)cboLaboratorios.SelectedItem;
		}
		
		private void CboMuestrasSelectedValueChanged(object sender, EventArgs e) {
			especificacionSeleccionada = (EspecificacionDeMuestra) cboMuestras.SelectedItem;
		}

		#endregion

		#region Muestreo

		private void GrupoTipoMuestreo_Click(object sender, EventArgs e) {
			string tipo = (sender as RadioButton).Text;
			if(tipo == EnumTipoMuestreo.Destructivo.ToString()) {
				tipoMuestreo = EnumTipoMuestreo.Destructivo;
			} else {
				tipoMuestreo = EnumTipoMuestreo.NoDestructivo;
			}
		}

		private void GrupoAlmacenamiento_Click(object sender, EventArgs e) {
			almacenamiento = (EnumAlmacenamientoMuestreo)Enum.Parse(typeof(EnumAlmacenamientoMuestreo), (sender as RadioButton).Text);
		}

		#endregion

		private void BtnGuardar_Click(object sender, EventArgs e) {
			TomarValores();
			if(ComprobarDatos()) {
				List<Muestreo> muestreos = null;
				if((muestreos = cMuestreos.CrearNuevoMuestreoIndividual(
					SesionDeUsuario.UsuarioLogueado.UsuarioId,
					fechaMuestreo,
					observaciones,
					almacenamiento,
					tipoMuestreo,
					numero
				)).Any()) {
					foreach(Muestreo muestreo in muestreos) {
						Muestra muestra = null;
						switch(claseDeMuestra) {
							case EnumClaseMuestra.Producto:
								muestra = cMuestras.CrearNuevaMuestraProducto(
									especificacionSeleccionada.EspecificacionDeMuestraId,
									identificacion,
									esRepeticion,
									fechaFaena,
									fechaProduccion,
									loteProducto,
									areaSeleccionada.AreaId);
								break;
							case EnumClaseMuestra.Superficie:
								muestra = cMuestras.CrearNuevaMuestraSuperficie(
									especificacionSeleccionada.EspecificacionDeMuestraId,
									identificacion,
									esRepeticion,
									horarioMuestreo,
									enContactoProducto,
									areaSeleccionada.AreaId);
								break;
							case EnumClaseMuestra.Ambiente:
								muestra = cMuestras.CrearNuevaMuestraAmbiente(
									especificacionSeleccionada.EspecificacionDeMuestraId,
									identificacion,
									esRepeticion,
									horarioMuestreo,
									areaSeleccionada.AreaId);
								break;
							case EnumClaseMuestra.Operario:
								muestra = cMuestras.CrearNuevaMuestraOperario(
									especificacionSeleccionada.EspecificacionDeMuestraId,
									identificacion,
									esRepeticion,
									horarioMuestreo,
									padronOperario,
									nombreOperario,
									areaSeleccionada.AreaId);
								break;
							case EnumClaseMuestra.Otra:
								muestra = cMuestras.CrearNuevaOtraMuestra(
									especificacionSeleccionada.EspecificacionDeMuestraId,
									identificacion,
									esRepeticion,
									enContactoProducto,
									areaSeleccionada.AreaId);
								break;
							default:
								break;
						}
						cMuestreos.AgregarMuestra(muestra.MuestraId, muestreo.MuestreoId);
						foreach(Ensayo ensayo in ensayosSeleccionados) {
							cEnsayos.CrearNuevoAnalisis(ensayo.EnsayoId,
							                            muestreo.MuestreoId,
							                            Model.Dominio.Enumeraciones.Ensayos.EnumMotivoAnalisis.Requisito,
							                            laboratoriosDeEnsayo[ensayo.EnsayoId].LaboratorioId);
						}
					}
				}
				SesionDeUsuario.ActualizarFormulariosAbiertos(this);
				MessageBox.Show("El Muestreo fue guardado");
				this.Close();
			} else {
				MessageBox.Show("No se pudo crear, compruebe que los datos son correctos.");
			}
		}

		private void BtnCancelarClick(object sender, EventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			this.Close();
		}

		private void TomarValores() {
			identificacion = txtIdentificacion.Text;
			if(!int.TryParse(txtNumeroMuestra.Text, out numero)) {
				numero = 1;
			}
			observaciones = txtObservaciones.Text;
			loteProducto = txtLote.Text;
			nombreOperario = txtOperario.Text;
			if(!int.TryParse(txtPadron.Text, out padronOperario)) {
				padronOperario = 0;
			}
			fechaFaena = pickerFechaFaena.Value;
			fechaProduccion = pickerFechaProduccion.Value;
			fechaMuestreo = pickerFechaMuestreo.Value;

		}

		private bool ComprobarDatos() {
			// muestreo general
			if(string.IsNullOrEmpty(identificacion) || areaSeleccionada == null || especificacionSeleccionada == null) {
				return false;
			}
			// por tipo
			switch(claseDeMuestra) {
				case EnumClaseMuestra.Producto:
					if(fechaFaena.CompareTo(fechaProduccion)>0) {
						return false;
					}
					break;
				case EnumClaseMuestra.Operario:
					if(string.IsNullOrEmpty(nombreOperario) || padronOperario <= 0) {
						return false;
					}
					break;

				default:
					break;
			}
			return true;
		}

		private void NuevoMuestreoFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			instancia = null;
		}
		
		public override void Refresh() {
			base.Refresh();
			CargarDatos();
		}

		#region Interfase CerrarInstancia
		public void CerrarInstancia() {
			instancia = null;
		}

        #endregion

    }
}
