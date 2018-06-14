/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 24/03/2018
 * Hora: 11:24 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Clases.Requisitos;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using miniLabMuestreo.Model.Logica.Requisitos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Requisitos {
    /// <summary>
    /// Description of NuevoRequisitoForm.
    /// </summary>
    public partial class NuevoRequisito : Form, ICerrar, IListaPublica<Limite>{
		private static NuevoRequisito instancia;
		
		private ControladorRequisitos cRequisitos = new ControladorRequisitos();
        private ControladorEnsayos cEnsayos = new ControladorEnsayos();
		
		// Datos de Requisito Nuevo
		private string nombreRequisito;
	
		// Limite
		private IList<Limite> limites = new List<Limite>();
		private Limite limiteSeleccionado;

        private DataTable tabla;
		
		private NuevoRequisito(){
			InitializeComponent();
            CrearTabla();
            CargarDatos();

            tablaDatos.DataSource = tabla;
        }
		
		public static NuevoRequisito GetInstancia(){
			if(instancia == null){
				instancia = new NuevoRequisito();
			}
			return instancia;
		}
		
        private void CrearTabla() {
            tabla = new DataTable();
            tabla.Columns.Add("Tipo", typeof(string));
            tabla.Columns.Add("Ensayo", typeof(string));
            tabla.Columns.Add("Referencia", typeof(string));
            tabla.Columns.Add("Valor Marginal", typeof(string));
            tabla.Columns.Add("Valor Inaceptable", typeof(string));
            tabla.Columns.Add("Deteccion", typeof(string));
        }

        private void CargarDatos() {
            LlenarTabla();
            if(cEnsayos.ListarEnsayos().Any()) {
                btnDefinirLimite.Enabled = true;
            } else {
                btnDefinirLimite.Enabled = false;
                this.btnDefinirLimite.Cursor = System.Windows.Forms.Cursors.No;
            }
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
                Requisito nuevoRequisito;
            	if((nuevoRequisito = cRequisitos.CrearNuevoRequisito(nombreRequisito))!=null) {
                    foreach(Limite limite in limites) {
                        if(limite is Busqueda) {
                            cRequisitos.CrearNuevoLimiteBusqueda(
                                    nuevoRequisito.RequisitoId,
                                    limite.Ensayo.EnsayoId,
                                    limite.ReferenciaDeLimite,
                                    (limite as Busqueda).ValorAceptableDeBusqueda,
                                    (limite as Busqueda).ValorInaceptableDeBusqueda
                                );
                        }else if(limite is Marginal) {
                            cRequisitos.CrearNuevoLimiteMarginal(
                                    nuevoRequisito.RequisitoId,
                                    limite.Ensayo.EnsayoId,
                                    limite.ReferenciaDeLimite,
                                    (limite as Marginal).ValorMarginalDeRecuento,
                                    (limite as Marginal).ValorInaceptableDeRecuento
                                );
                        }else if(limite is Inaceptable) {
                            cRequisitos.CrearNuevoLimiteInaceptable(
                                    nuevoRequisito.RequisitoId,
                                    limite.Ensayo.EnsayoId,
                                    limite.ReferenciaDeLimite,
                                    (limite as Inaceptable).ValorInaceptableDeRecuento
                                );
                        }
                    }
                    SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                    MessageBox.Show("El Requisito fue guardado");
                    this.Close();
                }else{
                    MessageBox.Show("No se pudo crear, compruebe que los datos son correctos.");
                }
            } else {
                MessageBox.Show("No se pudo crear, compruebe que los datos son correctos.");
            }            
        }
				
		private void BtnCancelarClick(object sender, EventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            this.Close();
        }
        private void NuevoRequisitoFormFormClosing(object sender, FormClosingEventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            instancia = null;
        }
		
		public override void Refresh() {
            base.Refresh();
            CargarDatos();
        }

		#region Nuevo Limite
		void BntDefinirLimiteClick(object sender, EventArgs e) {
			Form definirLimiteForm = NuevoLimite.GetInstancia(this);
			definirLimiteForm.MdiParent = this.MdiParent;
			SesionDeUsuario.AgregarFormularioAbierto(definirLimiteForm);
			definirLimiteForm.Show();
			definirLimiteForm.BringToFront();
		}
		
		private void BntQuitarLimiteClick(object sender, EventArgs e){
			limites.Remove(limiteSeleccionado);
			LlenarTabla();
		}
		
		private void LlenarTabla() {
            if(tabla.Rows.Count != 0) {
                tabla.Clear();
            }

            foreach(Limite limite in limites) {
                if(limite is Busqueda) {
                    tabla.Rows.Add("Busqueda",                                    
                                    limite.Ensayo.NombreDeEnsayo,
                                    limite.ReferenciaDeLimite,
                                    "-",
                                    "-",
                                    (limite as Busqueda).ValorAceptableDeBusqueda.ToString()
                                    );
                } else if (limite is Marginal) {
                    tabla.Rows.Add("Recuento",                                    
                                    limite.Ensayo.NombreDeEnsayo,
                                    limite.ReferenciaDeLimite,
                                    (limite as Marginal).ValorMarginalDeRecuento.ToString(),
                                    (limite as Marginal).ValorInaceptableDeRecuento.ToString(),
                                     "-"
                                    );
                } else {
                    tabla.Rows.Add("Recuento",                                   
                                    limite.Ensayo.NombreDeEnsayo,
                                    limite.ReferenciaDeLimite,
                                    "-",
                                    (limite as Inaceptable).ValorInaceptableDeRecuento.ToString(),
                                     "-"
                                    );
                }                
            }
        }
		
		#region IListaPublica implementation

		public void AddEntidad(Limite limite) {
			if(limites.Where(l=>l.Ensayo.EnsayoId == limite.Ensayo.EnsayoId).ToList().Any()){
				MessageBox.Show("Ye se agrego un limite para este ensayo.");
			}else{
				limites.Add(limite);
			}			
		}
		
		public void RemoveEntidad(Limite limite) {
			limites.Remove(limite);
		}

		#endregion
		
		#endregion
		
        private void tablaDatos_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                limiteSeleccionado = limites
                    .Single(l => l.Ensayo.NombreDeEnsayo == ((string)(tablaDatos.CurrentRow.Cells[2].Value)));
            } catch(Exception) { }
        }
		
		#region ICerrar implementation
		public void CerrarInstancia() {
			instancia = null;
		}
		#endregion
    }
}
