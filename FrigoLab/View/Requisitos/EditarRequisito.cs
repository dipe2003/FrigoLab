using FrigLab.Model.Dominio.Clases.Requisitos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Requisitos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Requisitos {
    public partial class EditarRequisito:Form, ICerrar, IListaPublica<Limite> {
		private static EditarRequisito instancia;

		private ControladorRequisitos cRequisitos = new ControladorRequisitos();

		private Requisito requisitoSeleccionado;
		private Limite limiteSeleccionado;

		private string nombreRequisito;
		private DataTable tabla;
		private IList<Limite> limitesRequisito;
		private IList<Limite> limitesEditados = new List<Limite>();

		private EditarRequisito(Requisito requisitoAEditar) {
			requisitoSeleccionado = requisitoAEditar;
			InitializeComponent();
			CrearTabla();
			CargarDatos();
			tablaDatos.DataSource = tabla;
		}

		public static EditarRequisito GetInstancia(Requisito requisitoAEditar) {
			if(instancia == null) {
				instancia = new EditarRequisito(requisitoAEditar);
			}
			return instancia;
		}
		
		private void CargarDatos() {
			nombreRequisito = requisitoSeleccionado.NombreDeRequisito;
			txtNombre.Text = nombreRequisito;
			limitesRequisito = requisitoSeleccionado.LimitesDelRequisito;
			LlenarTabla();
		}

		private bool EsValidoNombre() {
			if(!string.IsNullOrEmpty(txtNombre.Text)) {
				nombreRequisito =  txtNombre.Text;
				return true;
			}
			return false;
		}

		private void BtnGuardarClick(object sender, EventArgs e) {
			if(EsValidoNombre()) {
				Requisito requisitoEditado;
				if((requisitoEditado = cRequisitos.EditarRequisito(requisitoSeleccionado.RequisitoId, nombreRequisito))!=null) {
					foreach(Limite limite in limitesEditados) {
						if(limite is Busqueda) {
							cRequisitos.CrearNuevoLimiteBusqueda(
								requisitoEditado.RequisitoId,
								limite.Ensayo.EnsayoId,
								limite.ReferenciaDeLimite,
								(limite as Busqueda).ValorAceptableDeBusqueda,
								(limite as Busqueda).ValorInaceptableDeBusqueda);
						} else if(limite is Marginal) {
							cRequisitos.CrearNuevoLimiteMarginal(
								requisitoEditado.RequisitoId,
								limite.Ensayo.EnsayoId,
								limite.ReferenciaDeLimite,
								(limite as Marginal).ValorMarginalDeRecuento,
								(limite as Marginal).ValorInaceptableDeRecuento);
						} else if(limite is Inaceptable) {
							cRequisitos.CrearNuevoLimiteInaceptable(
								requisitoEditado.RequisitoId,
								limite.Ensayo.EnsayoId,
								limite.ReferenciaDeLimite,
								(limite as Inaceptable).ValorInaceptableDeRecuento);
						}
					}
					SesionDeUsuario.ActualizarFormulariosAbiertos(this);
					MessageBox.Show("El Requisito fue guardado");
					this.Close();
				} else {
					MessageBox.Show("No se pudo actualizar, compruebe que los datos son correctos y \n " +
					                "que no existe un Requisito con el mismo nombre.");
				}
			} else {
				MessageBox.Show("No se pudo actualizar, compruebe que los datos son correctos y \n " +
				                "que no existe un Requisito con el mismo nombre.");
			}
		}

		private void BtnCancelarClick(object sender, EventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			this.Close();
		}

		#region Limites

		private void CrearTabla() {
			tabla = new DataTable();
			tabla.Columns.Add("Tipo", typeof(string));
			tabla.Columns.Add("Muestra", typeof(EnumClaseMuestra));
			tabla.Columns.Add("Ensayo", typeof(string));
			tabla.Columns.Add("Referencia", typeof(string));
			tabla.Columns.Add("Valor Marginal", typeof(string));
			tabla.Columns.Add("Valor Inaceptable", typeof(string));
			tabla.Columns.Add("Deteccion", typeof(string));
			tabla.Columns.Add("Vigente", typeof(string));
		}

		private void LlenarTabla() {
			if(tabla.Rows.Count != 0) {
				tabla.Clear();
			}
			foreach(Limite limite in limitesRequisito) {
				AgregarLimiteATabla(limite);
			}
		}

		private void AgregarLimiteATabla(Limite limite) {
			string vigencia;
			if(limite.FechaNoVigente == null) {
				vigencia = "Si";
			} else {
				vigencia = "No";
			}
			if(limite is Busqueda) {
				tabla.Rows.Add("Busqueda",
				               limite.Ensayo.ClaseDeMuestra,
				               limite.Ensayo.NombreDeEnsayo,
				               limite.ReferenciaDeLimite,
				               "-",
				               "-",
				               (limite as Busqueda).ValorAceptableDeBusqueda.ToString(),
				               vigencia);
			} else if(limite is Marginal) {
				tabla.Rows.Add("Recuento",
				               limite.Ensayo.ClaseDeMuestra,
				               limite.Ensayo.NombreDeEnsayo,
				               limite.ReferenciaDeLimite,
				               (limite as Marginal).ValorMarginalDeRecuento.ToString(),
				               (limite as Marginal).ValorInaceptableDeRecuento.ToString(),
				               "-",
				               vigencia);
			} else {
				tabla.Rows.Add("Recuento",
				               limite.Ensayo.ClaseDeMuestra,
				               limite.Ensayo.NombreDeEnsayo,
				               limite.ReferenciaDeLimite,
				               "-",
				               (limite as Inaceptable).ValorInaceptableDeRecuento.ToString(),
				               "-",
				               vigencia);
			}
		}

		private void TablaDatos_CellClick(object sender, DataGridViewCellEventArgs e) {
			limiteSeleccionado = null;
			try {
				limiteSeleccionado = limitesEditados
					.Single(l => l.Ensayo.NombreDeEnsayo == ((string)(tablaDatos.CurrentRow.Cells[1].Value)));
			} catch(Exception) { }
		}

		void BntDefinirLimiteClick(object sender, EventArgs e) {
			Form definirLimiteForm = NuevoLimite.GetInstancia(this);
			definirLimiteForm.MdiParent = this.MdiParent;
			SesionDeUsuario.AgregarFormularioAbierto(definirLimiteForm);
			definirLimiteForm.Show();
			definirLimiteForm.BringToFront();
		}

		private void BntQuitarLimiteClick(object sender, EventArgs e) {
			if(limiteSeleccionado!= null && limiteSeleccionado.LimiteId == 0) {
				limitesEditados.Remove(limiteSeleccionado);
				limiteSeleccionado = null;
				LlenarTabla();
			} else {
				MessageBox.Show("El limite selecccionado no puede ser quitado.");
			}
		}

		private void EditarRequisitoFormFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			instancia = null;
		}
		
		#region IListaPublica implementation
		public void AddEntidad(Limite limite) {
			if(limitesEditados.Where(l => l.Ensayo.EnsayoId == limite.Ensayo.EnsayoId).ToList().Any()) {
				MessageBox.Show("Ye se agrego un limite para este ensayo.");
			} else {
				limitesEditados.Add(limite);
				AgregarLimiteATabla(limite);
			}
		}

		public void RemoveEntidad(Limite limite) {
			limitesEditados.Remove(limite);
		}
		#endregion
		#endregion
		
		#region ICerrar implementation
		public void CerrarInstancia() {
			instancia = null;
		}
		#endregion


	}
}
