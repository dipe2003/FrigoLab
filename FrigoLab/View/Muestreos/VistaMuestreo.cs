using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Logica.Muestreos;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FrigLab.View.Muestreos {
    public partial class VistaMuestreo:Form {

		private ControladorMuestreos cMuestreos = new ControladorMuestreos();
		private ControladorEnsayos cEnsayos = new ControladorEnsayos();

		private int idMuestreo;
		private Muestreo muestreoSeleccionado;

		private DataTable tabla;

		public VistaMuestreo(int idMuestreo) {
			this.idMuestreo = idMuestreo;
			InitializeComponent();
			CargarDatos();
			CrearTabla();
			LlenarTabla();
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
			tabla.Columns.Add("Verificado", typeof(string));
			tabla.Columns.Add("Verificador", typeof(string));
			tabla.Columns.Add("Estado", typeof(string));
		}

		private void CargarDatos() {
			
			muestreoSeleccionado = cMuestreos.ObtenerMuestreoIndividual(idMuestreo);
			txtArea.Text = muestreoSeleccionado.Muestra.Area.NombreDeArea;
			txtIdentificacion.Text = muestreoSeleccionado.Muestra.IdentificacionDeMuestra;
			txtClaseMuestra.Text = muestreoSeleccionado.Muestra.EspecificacionDeMuestra.ClaseDeMuestra.ToString();
			txtNombreEspecificacion.Text = muestreoSeleccionado.Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra;
			
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
					txtPadron.Text = op.PadronDeOperario.ToString() ;
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
			
			if(muestreoSeleccionado.EstaHabilitado()){
				lblEstado.Text = "HABILITADO";
				lblEstado.BackColor = Color.Green;
				lblEstado.ForeColor = Color.White;
			}else{
				lblEstado.Text = "NO HABILITADO";
				lblEstado.BackColor = Color.Red;
				lblEstado.ForeColor = Color.White;
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
				items[3] = analisis.FechaDeAnalisis;
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
					items[9] = analisis.FechaDeVerificacion.Value.ToShortDateString();
					items[10] = analisis.UsuarioVerificador.NombreCompleto;
				}else{
					items[9] = null;
					items[10] = "--";
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
				switch (estado) {
					case EnumInterpretacionResultado.Aceptable:
						fila.Cells[11].Style.BackColor = Color.Green;
						fila.Cells[11].Style.ForeColor = Color.White;
						break;
						
					case EnumInterpretacionResultado.Marginal:
						fila.Cells[11].Style.BackColor = Color.Black;
						fila.Cells[11].Style.ForeColor = Color.YellowGreen;
						break;
						
					default:
						fila.Cells[11].Style.BackColor = Color.Red;
						fila.Cells[11].Style.ForeColor = Color.White;
						break;
				}
			}
			tablaDatos.Refresh();
		}

		private void BtnCancelar_Click(object sender, EventArgs e) {
			this.Close();
		}
		
		private void ActualizarRegistros() {
			muestreoSeleccionado = cMuestreos.ObtenerMuestreoIndividual(muestreoSeleccionado.MuestreoId);
			LlenarTabla();
			CambiarColor();
		}

		private void VistaMuestreoFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
		}
		
		public override void Refresh() {
			base.Refresh();
			ActualizarRegistros();
		}
		
		private void VistaMuestreo_Load(object sender, EventArgs e) {
			CambiarColor();
		}

	}
}
