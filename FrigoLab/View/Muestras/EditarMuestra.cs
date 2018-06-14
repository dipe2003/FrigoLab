/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 23/03/2018
 * Hora: 01:15 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Logica.Muestras;
using FrigLab.Model.Sesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Muestras {
    /// <summary>
    /// Description of EditarMuestraForm.
    /// </summary>
    public partial class EditarMuestra : Form, ICerrar {
		
		private static EditarMuestra instancia;
		
		private ControladorMuestras cMuestras = new ControladorMuestras();
		private ControladorAreas cAreas = new ControladorAreas();
		
		private EspecificacionDeMuestra especificacionSeleccionada;

		private IList<Area> areasRegistadas = new List<Area>();
		private IList<int> idAreasSeleccionadas = new List<int>();
		private int idAreaSeleccionada;

		private string nombre;
		private EnumClaseMuestra claseMuestraSeleccionada;
		
		private EditarMuestra(){
			InitializeComponent();
		}
		
		public static EditarMuestra GetInstancia(EspecificacionDeMuestra especificacionAEditar){
			if(instancia == null){
				instancia = new EditarMuestra {
					especificacionSeleccionada = especificacionAEditar
				};
				instancia.CargarDatos();
			}
			return instancia;
		}
		
		private void CargarDatos() {
			areasRegistadas = cAreas.ListarAreas(false).ToList();

			chkListAreas.Items.AddRange(areasRegistadas.OrderBy(a=>a.NombreDeArea).ToArray());
			chkListAreas.DisplayMember = "NombreDeArea";
			chkListAreas.ValueMember = "AreaId";
			
			foreach (Area area in especificacionSeleccionada.Areas) {
				idAreasSeleccionadas.Add(area.AreaId);
				for (int j = 0; j < chkListAreas.Items.Count; j++) {
					int id = ((chkListAreas.Items[j] as Area).AreaId);
					if(area.AreaId == id) {
						chkListAreas.SetItemChecked(j, true);
					}
				}
			}

			nombre = especificacionSeleccionada.NombreDeEspecificacionDeMuestra;
			txtNombre.Text = nombre;

			cboTipos.DataSource = Enum.GetNames(typeof(EnumClaseMuestra)).ToList();
			cboTipos.SelectedItem = especificacionSeleccionada.ClaseDeMuestra.ToString();
			claseMuestraSeleccionada = especificacionSeleccionada.ClaseDeMuestra;
		}
		
		private void BtnGuardar_Click(object sender, EventArgs e) {
			if (!string.IsNullOrEmpty(nombre)){
				EspecificacionDeMuestra muestra;
				if ((muestra = cMuestras.EditarEspecificacionDeMuestra(idAreasSeleccionadas.ToList(),
				                                                       especificacionSeleccionada.EspecificacionDeMuestraId,
				                                                       nombre, claseMuestraSeleccionada)) != null){
					SesionDeUsuario.ActualizarFormulariosAbiertos(this);
					MessageBox.Show("La Muestra fue guardada");
					this.Close();
				} else{
                    MessageBox.Show("No se pudo crear, compruebe que los datos son correctos y \n" +
                        "que no existe una Muestra con el mismo nombre.");
                }
			}
		}

		private void ChkListBox_SelectedIndexChanged(object sender, EventArgs e) {
			if ((sender as CheckedListBox).Focused){
				idAreaSeleccionada = ((sender as CheckedListBox).SelectedItem as Area).AreaId;
				if (idAreasSeleccionadas.Contains(idAreaSeleccionada)){
					idAreasSeleccionadas.Remove(idAreaSeleccionada);
					chkListAreas.SetItemChecked((sender as CheckedListBox).SelectedIndex, false);
				} else{
					idAreasSeleccionadas.Add(idAreaSeleccionada);
					chkListAreas.SetItemChecked((sender as CheckedListBox).SelectedIndex, true);
				}
			}
		}

		private void BtnCancelar_Click(object sender, EventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			this.Close();
		}

		private void cboTipos_SelectedIndexChanged(object sender, EventArgs e) {
			claseMuestraSeleccionada = (EnumClaseMuestra)Enum.Parse(typeof(EnumClaseMuestra), ((sender as ComboBox).SelectedItem.ToString()));
		}

		private void TxtNombre_TextChanged(object sender, EventArgs e) {
			nombre = (sender as TextBox).Text;
			if(nombre == "") {
                MessageBox.Show("El nombre no es valido o esta vacio.");
            }
		}
		
		private void EditarMuestraForm_FormClosing(object sender, FormClosingEventArgs e) {
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
