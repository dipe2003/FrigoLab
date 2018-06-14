/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 14/03/2018
 * Hora: 11:41 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Logica.Muestras;
using FrigLab.Model.Sesion;
using System.Linq;

namespace FrigLab.View.Areas
{
	/// <summary>
	/// Description of EditarAreaForm.
	/// </summary>
	public partial class EditarArea : Form, ICerrar{
		
		private ControladorAreas cAreas = new ControladorAreas();
		
		private Area areaSeleccionada;
		private DateTime? fechaNoVigente;

		private static EditarArea instancia;
		
		private EditarArea() {
			InitializeComponent();
		}
		
		public static EditarArea GetInstancia(Area areaAEditar){
			if(instancia==null){
				instancia = new EditarArea {
					areaSeleccionada = areaAEditar
				};
				instancia.CargarDatos();				
				instancia.Text += instancia.areaSeleccionada.NombreDeArea;
				instancia.txtNombre.Text = instancia.areaSeleccionada.NombreDeArea;
			}
			return instancia;
		}
		
		private void BtnGuardarClick(object sender, EventArgs e) {
			string nombreArea = txtNombre.Text;
			Area area;
			if(nombreArea!="" && ((area = cAreas.EditarArea(areaSeleccionada.AreaId, nombreArea))!=null)){
                // comprobar si cambia vigencia para actualizar
            if(areaSeleccionada.FechaNoVigente == null && fechaNoVigente != null){
						cAreas.CambiarVigencia(areaSeleccionada.AreaId, false);
                }else if(areaSeleccionada.FechaNoVigente != null && fechaNoVigente == null) {
                    cAreas.CambiarVigencia(areaSeleccionada.AreaId, true);
                }

				SesionDeUsuario.ActualizarFormulariosAbiertos(this);
				MessageBox.Show("El área fue guardada");
                this.Close();
            }
            MessageBox.Show("No se pudo guardar, compruebe que no existe un Area con el mismo nombre.");
		}
		
		private void BtnCancelarClick(object sender, EventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
            this.Close();
        }

		private void ChkVigente_CheckedChanged(object sender, EventArgs e) {
			if((sender as CheckBox).Checked) {
				fechaNoVigente = null;
			} else {				
				fechaNoVigente = new DateTime();
			}
		}
		
		private void CargarDatos(){
			
			 if(areaSeleccionada.FechaNoVigente != null){
				fechaNoVigente = areaSeleccionada.FechaNoVigente.Value;
				 chkVigente.Checked = false;
            } else {
                chkVigente.Checked = true;
            }
		}
		
		private void EditarAreaFormFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			instancia=null;
		}
		
		#region ICerrar implementation
		public void CerrarInstancia() {
			instancia = null;
		}
		#endregion
	}
}

