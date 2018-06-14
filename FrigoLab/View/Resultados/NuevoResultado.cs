/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 19/04/2018
 * Hora: 08:18 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Clases.Requisitos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Requisitos;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Resultados {
    /// <summary>
    /// Description of NuevoResultado.
    /// </summary>
    public partial class NuevoResultado:Form, ICerrar {

		private static NuevoResultado instancia;

		private ControladorEnsayos cEnsayos = new ControladorEnsayos();

		private List<Muestreo> muestreosSeleccionado;
		private Analisis analisisSeleccionado;
		private EnumTipoAnalisis tipoAnalisis;
		private bool PerteneceAPool = false;

		// Datos del analisis
		private DateTime fechaAnalisis;

		// Datos del Resultado
		private string observacionesResultado;
		private DateTime fechaResultado;
		private float resultadoRecuento;
		private EnumValorDeteccion resultadoDeteccion;

		private NuevoResultado() {
			InitializeComponent();
		}

		public static NuevoResultado GetInstancia(List<Muestreo> muestreos, Analisis analisis) {
			if(instancia == null) {
				instancia = new NuevoResultado {
					muestreosSeleccionado = muestreos,
					analisisSeleccionado = analisis,
					tipoAnalisis = analisis.Ensayo.TipoDeAnalisis
				};
				instancia.CargarDatos();
			}
			return instancia;
		}

		private void CambiarVisibilidadPanel(bool panelRecuento, bool panelDeteccion) {
			GrupoRecuento.Visible = panelRecuento;
			GrupoDeteccion.Visible = panelDeteccion;
		}

		private void CargarDatos() {
			if(muestreosSeleccionado.Any()) {
				PerteneceAPool = true;
			}
			if(tipoAnalisis==EnumTipoAnalisis.Busqueda) {
				CambiarVisibilidadPanel(false, true);
				// llenar combobox segun los valores seleccionados en el ensayo como aceptable e inaceptable
				// y los indeterminados para confirmación
				cboResultadoDeteccion.DataSource = new string[] {
					(analisisSeleccionado.Ensayo.GetLimiteVigente() as Busqueda).ValorAceptableDeBusqueda.ToString(),
					(analisisSeleccionado.Ensayo.GetLimiteVigente() as Busqueda).ValorInaceptableDeBusqueda.ToString(),
					EnumValorDeteccion.Potencial.ToString(),
					EnumValorDeteccion.Indeterminado.ToString()
				};
				resultadoDeteccion = (EnumValorDeteccion)Enum.Parse(typeof(EnumValorDeteccion), cboResultadoDeteccion.Items[0].ToString());
				cboResultadoDeteccion.SelectedItem = resultadoDeteccion.ToString();
			} else {
				CambiarVisibilidadPanel(true, false);
			}
		}

		private bool CargarComprobarDatos() {
			fechaResultado = pickerFechaResultado.Value;
			observacionesResultado = txtObservaciones.Text;
			if(tipoAnalisis != EnumTipoAnalisis.Busqueda) {
				if(!float.TryParse(txtResultadoRecuento.Text, out resultadoRecuento)) {
					MessageBox.Show("El resultado ingresado no es correcto.");
					return false;
				}
			}
			fechaAnalisis = pickerFechaAnalisis.Value;
			if(fechaResultado.CompareTo(fechaAnalisis)>1) {
				MessageBox.Show("La fecha de resultado no puede ser anterior al analisis");
				return false;
			}
			return true;
		}

		private void BtnCancelarClick(object sender, EventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			this.Close();
		}

		private void BtnGuardarClick(object sender, EventArgs e) {
			if(CargarComprobarDatos()) {
				List<Resultado> resultados = new List<Resultado>();
				if(tipoAnalisis == EnumTipoAnalisis.Busqueda) {
					if(PerteneceAPool) {
						foreach(Muestreo m in muestreosSeleccionado) {
							resultados.Add(cEnsayos.CrearNuevoResultadoDeteccion(
								m.AnalisisDelMuestreo.Single(a => a.Ensayo.EnsayoId == analisisSeleccionado.Ensayo.EnsayoId).AnalisisId,
								SesionDeUsuario.UsuarioLogueado.UsuarioId,
								observacionesResultado,
								fechaAnalisis,
								fechaResultado,
								resultadoDeteccion));
						}
					} else {
						resultados.Add(cEnsayos.CrearNuevoResultadoDeteccion(
							analisisSeleccionado.AnalisisId,
							SesionDeUsuario.UsuarioLogueado.UsuarioId,
							observacionesResultado,
							fechaAnalisis,
							fechaResultado,
							resultadoDeteccion));
					}
				} else {
					if(PerteneceAPool) {
						foreach(Muestreo m in muestreosSeleccionado) {
							resultados.Add(cEnsayos.CrearNuevoResultadoRecuento(
								m.AnalisisDelMuestreo.Single(a => a.Ensayo.EnsayoId == analisisSeleccionado.Ensayo.EnsayoId).AnalisisId,
								SesionDeUsuario.UsuarioLogueado.UsuarioId,
								observacionesResultado,
								fechaAnalisis,
								fechaResultado,
								resultadoRecuento));
						}
					} else {
						resultados.Add(cEnsayos.CrearNuevoResultadoRecuento(
							analisisSeleccionado.AnalisisId,
							SesionDeUsuario.UsuarioLogueado.UsuarioId,
							observacionesResultado,
							fechaAnalisis,
							fechaResultado,
							resultadoRecuento));
					}
				}
				if(resultados.Count >= muestreosSeleccionado.Count) {
					MessageBox.Show("El resultado fue guardado.");
					SesionDeUsuario.ActualizarFormulariosAbiertos(this);
					this.Close();
				} else {
					MessageBox.Show("No se guardó, compruebe los datos ingresados.");
				}
			}
		}

		private void CboResultadoDeteccion_SelectedIndexChanged(object sender, EventArgs e) {
			resultadoDeteccion = (EnumValorDeteccion)Enum.Parse(typeof(EnumValorDeteccion), (sender as ComboBox).SelectedItem.ToString());
		}

		private void NuevoResultadoFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			instancia = null;
		}

		#region ICerrar implementation
		public void CerrarInstancia() {
			instancia = null;
		}
		#endregion


	}
}
