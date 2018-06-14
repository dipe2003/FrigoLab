using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Logica.Muestras;
using FrigLab.Model.Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Muestras {
    public partial class NuevaMuestra:Form, ICerrar {
        private static NuevaMuestra instancia;

        private ControladorMuestras cMuestras = new ControladorMuestras();
        private ControladorAreas cAreas = new ControladorAreas();

        private IList<Area> areasRegistadas = new List<Area>();
        private IList<int> idAreasSeleccionadas = new List<int>();
        private int idAreaSeleccionada;

        private EnumClaseMuestra claseMuestraSeleccionada;

        private string nombre;

        private NuevaMuestra() {
            InitializeComponent();
            CargarDatos();
        }

        public static NuevaMuestra GetInstancia() {
            if(instancia == null) {
                instancia = new NuevaMuestra();
            }
            return instancia;
        }

        private void CargarDatos() {
            areasRegistadas = cAreas.ListarAreas(false).ToList();

            chkListAreas.Items.AddRange(areasRegistadas.OrderBy(a => a.NombreDeArea).ToArray()) ;
            chkListAreas.DisplayMember = "NombreDeArea";
            chkListAreas.ValueMember = "AreaId";

            cboTipos.DataSource = Enum.GetNames(typeof(EnumClaseMuestra)).ToList();
            cboTipos.SelectedItem = EnumClaseMuestra.Producto.ToString();
            claseMuestraSeleccionada = EnumClaseMuestra.Producto;
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
        	if(!string.IsNullOrEmpty(nombre)) {
                EspecificacionDeMuestra muestra;
                if((muestra = cMuestras.CrearEspecificacionDeMuestra(idAreasSeleccionadas.ToList(), nombre, claseMuestraSeleccionada))!= null) {
                    SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                    MessageBox.Show("La Muestra fue guardada");
                    this.Close();
                } else {
                    MessageBox.Show("No se pudo crear, compruebe que los datos son correctos y \n" +
                        "que no existe una Muestra con el mismo nombre.");
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void NuevaMuestraForm_FormClosing(object sender, FormClosingEventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            instancia=null;
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

        private void cboTipos_SelectedIndexChanged(object sender, EventArgs e) {
            claseMuestraSeleccionada = (EnumClaseMuestra) Enum.Parse(typeof(EnumClaseMuestra), ((sender as ComboBox).SelectedItem.ToString()));
        }

        public override void Refresh() {
            base.Refresh();
            CargarDatos();
        }

        public void CerrarInstancia() {
            instancia = null;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e) {
            nombre = (sender as TextBox).Text;
            if(nombre == "") {
                MessageBox.Show("El nombre no es valido o esta vacio.");
            }
        }
    }
}
