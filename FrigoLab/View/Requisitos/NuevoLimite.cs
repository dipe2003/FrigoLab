/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 26/03/2018
 * Hora: 08:53 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Requisitos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Requisitos;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Requisitos {
    /// <summary>
    /// Description of NuevoLimite.
    /// </summary>
    public partial class NuevoLimite:Form, ICerrar {
		private static NuevoLimite instancia;

		private ControladorEnsayos cEnsayos = new ControladorEnsayos();

        private EnumClaseMuestra claseSeleccionada = EnumClaseMuestra.Producto;
		private IEnumerable<Ensayo> ensayosRegistrados;
        private IEnumerable<Ensayo> ensayosFiltrados;
        private Ensayo ensayoSeleccionado;

		private string referenciaLimite;
		private float valorMarginal;
		private float valorInaceptable;
		private float valorMarginalInaceptable;
		private EnumValorDeteccion valorDeteccionAceptable;
		private EnumValorDeteccion valorDeteccionInaceptable;

		private GroupBox[] grupos;

		private Form formAnterior;

		private NuevoLimite(Form formularioAnterior) {
			formAnterior = formularioAnterior;

			InitializeComponent();

			grupos = new GroupBox[3] { GrupoBusqueda, GrupoMarginal, GrupoRecuento };

            // Clase de Muestra
            foreach(RadioButton radio in grupoClaseMuestra.Controls) {
                radio.CheckedChanged += GrupoClaseMuestra_CheckedChanged;
            }
			
			CargarDatos();
		}

		private void CargarDatos() {
			ensayosRegistrados = cEnsayos.ListarEnsayos();
            ensayosFiltrados = ensayosRegistrados.OrderBy(e => e.NombreDeEnsayo).ToList();

			cboEnsayos.DisplayMember = "NombreDeEnsayo";
			cboEnsayos.ValueMember = "EnsayoId";
            
			
			cboAceptable.DataSource = new string[] {
				EnumValorDeteccion.Ausencia.ToString(),
				EnumValorDeteccion.NoDetectado.ToString(),
				EnumValorDeteccion.Negativo.ToString()					
			};
			
			cboInaceptable.DataSource = new string[] {
					EnumValorDeteccion.Positivo.ToString(),
					EnumValorDeteccion.Presencia.ToString()				
			};
            ActualizarEnsayos();

            radioProducto.Checked =true;
        }

		public static NuevoLimite GetInstancia(Form formularioAnterior) {
			if(instancia == null) {
				instancia = new NuevoLimite(formularioAnterior);
			}
			return instancia;
		}

        private void GrupoClaseMuestra_CheckedChanged(object sender, EventArgs e) {
            claseSeleccionada = (EnumClaseMuestra)Enum.Parse(typeof(EnumClaseMuestra), ((sender as RadioButton).Text));
            ActualizarEnsayos();
        }

        private void ActualizarEnsayos() {
            ensayosFiltrados = ensayosRegistrados.Where(e => e.ClaseDeMuestra == claseSeleccionada).OrderBy(e => e.NombreDeEnsayo).ToList();
            cboEnsayos.DataSource = ensayosFiltrados;
            ensayoSeleccionado = ensayosFiltrados.FirstOrDefault();
            cboEnsayos.SelectedItem = ensayoSeleccionado;
        }

        private void HabilitarGrupoLimite() {
			switch(ensayoSeleccionado.TipoDeAnalisis) {
				case EnumTipoAnalisis.Busqueda:
					CambiarVisibilidadTipoResultado("GrupoBusqueda");
					break;

				case EnumTipoAnalisis.Recuento:
                    CambiarVisibilidadTipoResultado("GrupoRecuento");
					break;

				default:
					CambiarVisibilidadTipoResultado("GrupoMarginal");
					break;
			}
		}

		private void CambiarVisibilidadTipoResultado(string nombreVisible) {
			foreach(GroupBox grupo in grupos) {
				if(grupo.Name != nombreVisible) {
					grupo.Visible = false;
				} else {
					grupo.Visible = true;
				}
			}
		}

		private bool ComprobarValores() {
			if(string.IsNullOrEmpty(txtReferencias.Text) || !ensayosRegistrados.Contains(ensayoSeleccionado)) {
				return false;
			} else {
				referenciaLimite = txtReferencias.Text;
				switch(ensayoSeleccionado.TipoDeAnalisis) {
					case EnumTipoAnalisis.RecuentoMarginal:
						if(!float.TryParse(txtMarginalMarginal.Text, out valorMarginal) ||
						   !float.TryParse(txtMarginalInaceptable.Text, out valorMarginalInaceptable)) {
							return false;
						}
						break;
					case EnumTipoAnalisis.Recuento:
						if(!float.TryParse(txtRecuentoInaceptable.Text, out valorInaceptable)) {
							return false;
						}
						break;
					default:
						valorDeteccionAceptable = (EnumValorDeteccion) Enum.Parse(typeof(EnumValorDeteccion), cboAceptable.SelectedItem.ToString());
						valorDeteccionInaceptable = (EnumValorDeteccion) Enum.Parse(typeof(EnumValorDeteccion), cboInaceptable.SelectedItem.ToString());
						break;
				}
			}
			return true;
		}

		void BtnGuardarClick(object sender, EventArgs e) {
			if(ComprobarValores()) {
				Limite nuevoLimite = null;
				switch(ensayoSeleccionado.TipoDeAnalisis) {
					case EnumTipoAnalisis.Busqueda:
						nuevoLimite = new Busqueda {
							ValorAceptableDeBusqueda = valorDeteccionAceptable,
							ValorInaceptableDeBusqueda = valorDeteccionInaceptable,
							ReferenciaDeLimite = referenciaLimite,
							Ensayo = ensayoSeleccionado
						};
						break;

					case EnumTipoAnalisis.Recuento:
						nuevoLimite = new Inaceptable {
							ReferenciaDeLimite = referenciaLimite,
							ValorInaceptableDeRecuento = valorInaceptable,
							Ensayo = ensayoSeleccionado
						};
						break;

					case EnumTipoAnalisis.RecuentoMarginal:
						nuevoLimite = new Marginal {
							ReferenciaDeLimite = referenciaLimite,
							ValorInaceptableDeRecuento = valorMarginalInaceptable,
							ValorMarginalDeRecuento = valorMarginal,
							Ensayo = ensayoSeleccionado
						};
						break;
				}
				(formAnterior as IListaPublica<Limite>).AddEntidad(nuevoLimite);
				formAnterior.Refresh();
				this.Close();
			}else{
                MessageBox.Show("Datos no validos.");
            }
		}
		
		void CboEnsayosSelectedIndexChanged(object sender, EventArgs e) {
			ensayoSeleccionado = ensayosRegistrados.Single(en=>en.EnsayoId == ((sender as ComboBox).SelectedItem as Ensayo).EnsayoId);
            HabilitarGrupoLimite();
		}
		
		void BtnCancelarClick(object sender, EventArgs e) {
			this.Close();
		}

		private void NuevoLimiteForm_FormClosing(object sender, FormClosingEventArgs e) {
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
