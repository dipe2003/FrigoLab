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
    public partial class EditarMuestreo:Form {
		private static EditarMuestreo instancia;

		// Controladores
		private ControladorAreas cAreas = new ControladorAreas();
		private ControladorMuestras cMuestras = new ControladorMuestras();
		private ControladorEnsayos cEnsayos = new ControladorEnsayos();
		private ControladorMuestreos cMuestreos = new ControladorMuestreos();
		private ControladorPooles cPooles = new ControladorPooles();

		private int idMuestreo;
		private Muestreo muestreoSeleccionado;

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

		#region	Pool
		private DateTime fechaPool;
		private string descripcionPool;
		private IList<Muestreo> muestreosDelPool = new List<Muestreo>();
		private bool perteneceAPool = false;
		#endregion

		private EditarMuestreo() {
			InitializeComponent();

			// almacenamiento
			foreach(RadioButton radio in grupoAlmacenamiento.Controls) {
				radio.CheckedChanged += GrupoAlmacenamiento_Click;
			}

			// tipo
			foreach(RadioButton radio in grupoTipoMuestreo.Controls) {
				radio.CheckedChanged += GrupoTipoMuestreo_Click;
			}

			// horario
			foreach(RadioButton radio in grupoHorario.Controls) {
				radio.CheckedChanged += GrupoHorario_Click;
			}
			
			tablaDatos2.ContextMenuStrip = CrearMenuContextual();
		}

		public static EditarMuestreo GetInstancia(int muestreoAEditar) {
			if(instancia == null) {
				instancia = new EditarMuestreo {
					idMuestreo = muestreoAEditar
				};
				instancia.CrearTabla();
				instancia.CargarDatos();
			}
			return instancia;
		}

		#region	Datos
		private void CargarDatos() {
			
			muestreoSeleccionado = cMuestreos.ObtenerMuestreoIndividual(idMuestreo);
			claseDeMuestra = muestreoSeleccionado.Muestra.EspecificacionDeMuestra.ClaseDeMuestra;

			// Titulo del formulario
			this.Text = this.Text += ": " + claseDeMuestra.ToString();

			// identificacion
			identificacion = muestreoSeleccionado.Muestra.IdentificacionDeMuestra;
			txtIdentificacion.Text = identificacion;

			// repeticion
			esRepeticion = muestreoSeleccionado.Muestra.EsRepeticion;
			chkRepeticion.Checked = esRepeticion;

			// Otros datos
			switch(claseDeMuestra) {
				case EnumClaseMuestra.Producto:
					CambiarVisibilidadPaneles(true, false, false, false);
					Producto p = muestreoSeleccionado.Muestra as Producto;
					fechaFaena = p.FechaDeFaena;
					fechaProduccion = p.FechaDeProduccion;
					loteProducto = p.LoteDeProducto;

					pickerFechaFaena.Value = fechaFaena;
					pickerFechaProduccion.Value = fechaProduccion;
					txtLote.Text = loteProducto;
					break;

				case EnumClaseMuestra.Operario:
					CambiarVisibilidadPaneles(false, true, false, true);
					Operario op = muestreoSeleccionado.Muestra as Operario;
					padronOperario = op.PadronDeOperario;
					nombreOperario = op.NombreDeOperario;

					txtPadron.Text = padronOperario.ToString();
					txtOperario.Text = nombreOperario;
					break;

					// clases Otra, Superficie y Ambiente usan los mismos controles
				default:
					CambiarVisibilidadPaneles(false, false, true, true);
					break;
			}

			#region Combo boxes
			// combo Areas
			areas = cAreas.ListarAreas(false).ToList();
			cboArea.DataSource = areas;
			cboArea.DisplayMember = "NombreDeArea";

			areaSeleccionada = areas.First(a => a.AreaId == muestreoSeleccionado.Muestra.Area.AreaId);
			cboArea.SelectedItem = areaSeleccionada;

			// combo Muestras
			muestras = cMuestras.ListarEspecificacionesDeMuestras(false)
				.Where((m => m.Areas.Select<Area, int>(a => a.AreaId).Contains(areaSeleccionada.AreaId)))
				.Where(m => m.ClaseDeMuestra == claseDeMuestra)
				.OrderBy(es => es.NombreDeEspecificacionDeMuestra)
				.ToList();

			cboMuestras.DataSource = muestras;
			cboMuestras.DisplayMember = "NombreDeEspecificacionDeMuestra";
			cboMuestras.SelectedItem = muestras.Single(m => m.EspecificacionDeMuestraId == muestreoSeleccionado.Muestra.EspecificacionDeMuestraId);

			// combo Ensayos
			ensayosRegistrados = cEnsayos.ListarEnsayos().ToList();
			ensayosCombo = ensayosRegistrados
				.Where(e => e.ClaseDeMuestra == claseDeMuestra)
				.Where(e => e.LimitesDeEnsayo.Any())
				.ToList();

			// Combo Laboratorios
			laboratoriosDeEnsayo.Clear();
			laboratorios = cEnsayos.ListarLaboratorios();
			cboLaboratorios.DataSource = laboratorios;
			cboLaboratorios.DisplayMember = "NombreDeLaboratorio";
			laboratorioSeleccionado = laboratorios.FirstOrDefault();
			cboLaboratorios.SelectedItem = laboratorioSeleccionado;

			// tabla analisis
			ensayosSeleccionados = new List<Ensayo>();
			if(muestreoSeleccionado.AnalisisDelMuestreo.Any()) {
				foreach(var analisis in muestreoSeleccionado.AnalisisDelMuestreo) {
					AgregarAnalisis(analisis.Ensayo, true);
				}
			} else {
				ActualizarEnsayos();
				ActualizarTabla();
			}

			#endregion

			#region Datos de la muestra, Grupos de Opciones y Checkboxes
			// Horarios
			foreach(RadioButton radio in grupoHorario.Controls) {
				if(radio.Text == muestreoSeleccionado.Muestra.EspecificacionDeMuestra.ClaseDeMuestra.ToString()) {
					radio.Checked = true;
				}
			}

			if(muestreoSeleccionado is Individual) {
				Individual m = muestreoSeleccionado as Individual;
				// fecha
				fechaMuestreo = m.FechaHoraDeMuestreo;
				pickerFechaMuestreo.Value = fechaMuestreo;

				// Numero
				numero = m.NumeroDeMuestreo;
				txtNumeroMuestra.Text = numero.ToString();

				// Observaciones
				observaciones = m.ObservacionesDeMuestreo;
				txtObservaciones.Text = observaciones;

				// Almacenamiento
				foreach(RadioButton radio in grupoAlmacenamiento.Controls) {
					if(radio.Text == m.AlmacenamientoDeMuestreo.ToString()) {
						radio.Checked = true;
					}
				}
				// tipo de muestreo
				tipoMuestreo = m.TipoDeMuestreo;
				foreach(RadioButton radio in grupoTipoMuestreo.Controls) {
					if(radio.Text == tipoMuestreo.ToString()) {
						radio.Checked = true;
					}
				}

				// Contacto con producto
				if(m.Muestra.EspecificacionDeMuestra.ClaseDeMuestra == EnumClaseMuestra.Otra) {
					if((m.Muestra as Otra).EnContactoConProducto) {
						enContactoProducto = (m.Muestra as Otra).EnContactoConProducto;
						chkContactoProducto.Checked = enContactoProducto;
					}
				}

				if(m.Muestra.EspecificacionDeMuestra.ClaseDeMuestra == EnumClaseMuestra.Superficie) {
					if((m.Muestra as Superficie).EnContactoConProducto) {
						enContactoProducto = (m.Muestra as Superficie).EnContactoConProducto;
						chkContactoProducto.Checked = enContactoProducto;
					}
				}
			}

			// Pool
			CargarControlesPool();
			#endregion

			// tabla
			tablaDatos2.DataSource = tabla;
			tablaDatos2.Columns["Id"].Visible = false;
			
			// permitir modificar analisis
			if(muestreoSeleccionado.EstaVerificado()){
				btnAgregarAnalisis.Enabled = false;
			}
		}
		
		private void CargarControlesPool(){
			// Pool
			// si el muestreo pertenece a un pool se bloquea el numero de muestreo y se obtienen todos los otros
			// muestreos que pertenecen al pool para agregar los analisis
			if((muestreoSeleccionado as Individual).Pool != null) {
				perteneceAPool = true;
				txtNumeroMuestra.ReadOnly = true;
				muestreosDelPool = (cPooles.ObtenerPool((muestreoSeleccionado as Individual).Pool.MuestreoId) as Pool).MuestreosDePool;

				fechaPool = (muestreoSeleccionado as Individual).Pool.FechaCreacionDePool;
				pickerFechaPool.Value = fechaPool;

				descripcionPool = (muestreoSeleccionado as Individual).Pool.DescripcionDePool;
				txtDescripcionPool.Text = descripcionPool;

				grupoPool.Visible = true;
				lblAvisoPool.Visible = true;

				if(!muestreoSeleccionado.EstaHabilitado()) {
					btnEditarPool.Visible = true;
				}
			}else{
				perteneceAPool = false;
				txtNumeroMuestra.ReadOnly = false;
				grupoPool.Visible = false;
				lblAvisoPool.Visible = false;
				btnEditarPool.Visible = false;
			}
		}

		private void ActualizarMuestras() {
			muestrasFiltradas = areaSeleccionada.EspecificacionesDeMuestras
				.Where(esp => esp.ClaseDeMuestra == claseDeMuestra)
				.OrderBy(es => es.NombreDeEspecificacionDeMuestra)
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
					// comprobar que en ensayo sea sobre la misma clase de muestra de la tabla
					// antes agregar el requisito para evitar que se listen los nombres de los requisitos
					// del mismo ensayo pero de otra clase de muestra
					if(ensayo.ClaseDeMuestra == muestreoSeleccionado.Muestra.EspecificacionDeMuestra.ClaseDeMuestra) {
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
				}
				tabla.Rows.Add(
					ensayo.EnsayoId,
					ensayo.NombreDeEnsayo,
					laboratoriosDeEnsayo[ensayo.EnsayoId].NombreDeLaboratorio,
					requisitos.ToString()
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
			AgregarAnalisis(ensayoSeleccionado, false);
		}

		private void AgregarAnalisis(Ensayo ensayo, bool perteneceMuestreoSeleccionado) {
			ensayosSeleccionados.Add(ensayo);
			// buscar el ensayo por id en el datasource del combo
			Ensayo aRemover = ensayosCombo.First(e => e.EnsayoId == ensayo.EnsayoId);
			ensayosCombo.Remove(aRemover);
			// laboratorio seleccionado para el analisis se guarda en diccionario con Key=Idensayo
			// si pertenece al muestreo seleccionado se debe usar el id del laboratorio del seleccionado
			if(perteneceMuestreoSeleccionado) {
				laboratoriosDeEnsayo.Add(ensayo.EnsayoId, laboratorios
				                         .Single(l => l.LaboratorioId == muestreoSeleccionado.AnalisisDelMuestreo
				                                 .Single(a => a.Ensayo == ensayo).Laboratorio.LaboratorioId));
			} else {
				laboratoriosDeEnsayo.Add(ensayo.EnsayoId, laboratorioSeleccionado);
			}
			ActualizarEnsayos();
			ActualizarTabla();
		}

		private void QuitarAnalisis(object sender, EventArgs e){
			try{
				ensayosCombo.Add(ensayoSeleccionado);
				ensayosSeleccionados.Remove(ensayoSeleccionado);
				laboratoriosDeEnsayo.Remove(ensayoSeleccionado.EnsayoId);
				ActualizarEnsayos();
				ActualizarTabla();
				tablaDatos2.ContextMenuStrip = CrearMenuContextual();
			} catch (NullReferenceException){}
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
			especificacionSeleccionada = (EspecificacionDeMuestra)cboMuestras.SelectedItem;
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
				if(cMuestreos.ActualizarMuestreoIndividual(
					muestreoSeleccionado.MuestreoId, fechaMuestreo, observaciones,
					almacenamiento, numero) != muestreoSeleccionado.MuestreoId) {
					muestreoSeleccionado.Muestra.EspecificacionDeMuestra = especificacionSeleccionada;
					muestreoSeleccionado.Muestra.EsRepeticion = esRepeticion;
					muestreoSeleccionado.Muestra.Area = areaSeleccionada;
					muestreoSeleccionado.Muestra.IdentificacionDeMuestra = identificacion;

					switch(claseDeMuestra) {
						case EnumClaseMuestra.Producto:
							Producto producto = muestreoSeleccionado.Muestra as Producto;
							producto.FechaDeFaena = fechaFaena;
							producto.FechaDeProduccion = fechaProduccion;
							producto.LoteDeProducto = loteProducto;
							break;

						case EnumClaseMuestra.Superficie:
							Superficie superficie = muestreoSeleccionado.Muestra as Superficie;
							superficie.HorarioDeMuestra = horarioMuestreo;
							superficie.EnContactoConProducto = enContactoProducto;
							break;

						case EnumClaseMuestra.Ambiente:
							Ambiente ambiente = muestreoSeleccionado.Muestra as Ambiente;
							ambiente.HorarioDeMuestra = horarioMuestreo;
							break;

						case EnumClaseMuestra.Operario:
							Operario operario = muestreoSeleccionado.Muestra as Operario;
							operario.PadronDeOperario = padronOperario;
							operario.NombreDeOperario = nombreOperario;
							operario.HorarioDeMuestra = horarioMuestreo;
							break;

						default:
							Otra otra = muestreoSeleccionado.Muestra as Otra;
							otra.EnContactoConProducto = enContactoProducto;
							break;
					}

					cMuestras.ActualizarMuestra(muestreoSeleccionado.Muestra);

					// se comprueba si el muetreo pertenece a un pool
					// luego se agregan/editan/eliminan segun corresponda a pool o individual
					if(muestreosDelPool.Any()) {
						foreach(Muestreo m in muestreosDelPool) {
							ComprobarAgregarAnalisis(m, ensayosSeleccionados);
						}
						// Comprobar si se editaron valores del pool y actualizar.
						if(descripcionPool != (muestreoSeleccionado as Individual).Pool.DescripcionDePool &&
						   fechaPool != (muestreoSeleccionado as Individual).Pool.FechaCreacionDePool) {
							if(cPooles.ActualizarPool((muestreoSeleccionado as Individual).Pool.MuestreoId, fechaPool, descripcionPool) !=
							   (muestreoSeleccionado as Individual).Pool.MuestreoId) {
								MessageBox.Show("No se pudieron actualizar datos del pool.");
							}
						}
					} else {
						ComprobarAgregarAnalisis(muestreoSeleccionado, ensayosSeleccionados);
					}
				}

				SesionDeUsuario.ActualizarFormulariosAbiertos(this);
				MessageBox.Show("El Muestreo fue guardado");
				this.Close();
			} else {
				MessageBox.Show("No se pudo guardar, compruebe que los datos son correctos.");
			}
		}

		private void EditarAnalisisExistentes() {
			for(int i = 0; i < muestreoSeleccionado.AnalisisDelMuestreo.Count; i++) {
				Analisis analisis = muestreoSeleccionado.AnalisisDelMuestreo[i];
				if(!ensayosSeleccionados.Contains(analisis.Ensayo)) {
					cEnsayos.EliminarAnalisis(analisis.Ensayo.EnsayoId, analisis.AnalisisId);
					muestreoSeleccionado.AnalisisDelMuestreo.Remove(analisis);
					i--;
				} else {
					// comprobar si se cambio laboratorio de analisis y se dejo el mismo ensayo
					if(analisis.Laboratorio.LaboratorioId != laboratoriosDeEnsayo[analisis.Ensayo.EnsayoId].LaboratorioId) {
						cEnsayos.ActualizarAnalisis(analisis.AnalisisId, analisis.OrigenDeAnalisis, laboratoriosDeEnsayo[analisis.Ensayo.EnsayoId].LaboratorioId);
					}
				}
			}
		}

		private void CrearNuevoAnalisis(Ensayo ensayo, Muestreo muestreo) {
			cEnsayos.CrearNuevoAnalisis(ensayo.EnsayoId,
			                            muestreo.MuestreoId,
			                            Model.Dominio.Enumeraciones.Ensayos.EnumMotivoAnalisis.Requisito,
			                            laboratoriosDeEnsayo[ensayo.EnsayoId].LaboratorioId);
		}

		private void ComprobarAgregarAnalisis(Muestreo muestreo, IList<Ensayo> ensayos) {
			// comprobar si se quitaron analisis del muestreo a editar y eliminarlos.
			EditarAnalisisExistentes();

			// comprobar si hay analisis agregados y se seleccionaron nuevos.
			foreach(Ensayo ensayo in ensayos) {
				if(!muestreo.AnalisisDelMuestreo.Any()) {
					CrearNuevoAnalisis(ensayo, muestreo);
				} else {
					if(!muestreo.EsEnsayoAsociado(ensayo.EnsayoId)) {
						CrearNuevoAnalisis(ensayo, muestreo);
					}
				}
			}
		}

		private void BtnCancelarClick(object sender, EventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			this.Close();
		}

		private void TablaDatos2CellClick(object sender, DataGridViewCellEventArgs e) {
			try {
				ensayoSeleccionado = ensayosSeleccionados
					.Single(en => en.EnsayoId == ((int)(tablaDatos2.CurrentRow.Cells[0].Value)));
				if(ensayoSeleccionado != null && !muestreoSeleccionado.EstaVerificado()){
					tablaDatos2.ContextMenuStrip = CrearMenuContextual(true);
				}else{
					tablaDatos2.ContextMenuStrip = CrearMenuContextual();
				}
			} catch(Exception) { }
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

			// Pool
			if(perteneceAPool) {
				descripcionPool = txtDescripcionPool.Text;
				fechaPool = pickerFechaPool.Value;
			}
		}

		private bool ComprobarDatos() {
			// muestreo general
			if(string.IsNullOrEmpty(identificacion) || areaSeleccionada == null || especificacionSeleccionada == null) {
				return false;
			}
			if(perteneceAPool) {
				if(string.IsNullOrEmpty(descripcionPool) || fechaPool == null) {
					return false;
				}
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

		private void EditarMuestreoFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			instancia = null;
		}

		private void BtnEditarPoolClick(object sender, EventArgs e) {
			Form editarPool = EditarPool.GetInstancia((muestreoSeleccionado as Individual).Pool.MuestreoId);
			editarPool.MdiParent = this.MdiParent;
			SesionDeUsuario.AgregarFormularioAbierto(editarPool);
			editarPool.Show();
			editarPool.BringToFront();
		}
		
		private ContextMenuStrip CrearMenuContextual(bool quitar = false){
			ContextMenuStrip ctxMenuStrip = new ContextMenuStrip();
			if(quitar) {
				ctxMenuStrip.Items.Add("&Quitar", Properties.Resources.imagen_no_verificar, new EventHandler(QuitarAnalisis));
			}else{
				ctxMenuStrip.Items.Add("No hay acciones disponibles.", Properties.Resources.imagen_no_disponible);
			}
			return ctxMenuStrip;
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
