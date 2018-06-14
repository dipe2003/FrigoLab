/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 16/05/2018
 * Hora: 11:41 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Logica.Muestras;
using FrigLab.Model.Logica.Muestreos;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Resultados {
    /// <summary>
    /// Description of SepararPool.
    /// </summary>
    public partial class SepararPool:Form {

        private static SepararPool instancia;

        private ControladorEnsayos cEnsayos = new ControladorEnsayos();
        private ControladorPooles cPooles = new ControladorPooles();
        private ControladorMuestreos cMuestreos = new ControladorMuestreos();
        private ControladorMuestras cMuestras = new ControladorMuestras();

        private int idPool;
        private List<Laboratorio> laboratorios;
        private Laboratorio laboratorioSeleccionado;

        private SepararPool() {
            InitializeComponent();
        }

        public static SepararPool GetInstancia(int idDePool) {
            if(instancia == null) {
                instancia = new SepararPool {
                    idPool = idDePool
                };
            }
            instancia.CargarDatos();
            return instancia;
        }

        // Datos
        private void CargarDatos() {
            laboratorios = cEnsayos.ListarLaboratorios().ToList();
            laboratorioSeleccionado = laboratorios.FirstOrDefault();
            cboLaboratorios.DataSource = laboratorios;
            cboLaboratorios.DisplayMember = "NombreDeLaboratorio";
            cboLaboratorios.SelectedItem = laboratorioSeleccionado;
        }

        private void CboLaboratorios_SelectedValueChanged(object sender, EventArgs e) {
            laboratorioSeleccionado = (Laboratorio)cboLaboratorios.SelectedItem;
        }

        private void BtnCancelarClick(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnAbrirPoolClick(object sender, EventArgs e) {
            UseWaitCursor = true;
            if(SepararPoolDeMuestreo(idPool, laboratorioSeleccionado.LaboratorioId).Any()) {
                MessageBox.Show("El pool fue separado. Se crearon los muestreos individuales para ser analizados.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                UseWaitCursor = false;
                SesionDeUsuario.formulariosAbiertos.Single(f => f.Name == "Resultados").Close();
                this.Close();
            } else {
                MessageBox.Show("Ocurrio un error y el pool no fue separado",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UseWaitCursor = false;
                this.Close();
            }
        }

        public List<Muestreo> SepararPoolDeMuestreo(int idDePool, int idLaboratorioDeAnalisis) {
            Pool pool = cPooles.ObtenerPool(idPool) as Pool;
            List<Muestreo> muestreos = new List<Muestreo>();
            foreach(Individual m in pool.MuestreosDePool) {
                Muestreo mAbierto = cMuestreos.CrearNuevoMuestreoIndividual(
                    m.Usuario.UsuarioId, m.FechaHoraDeMuestreo, m.ObservacionesDeMuestreo,
                    m.AlmacenamientoDeMuestreo, m.TipoDeMuestreo, 1).FirstOrDefault();
                (mAbierto as Individual).NumeroDeMuestreo = m.NumeroDeMuestreo;
                Muestra muestra = null;
                switch(m.Muestra.EspecificacionDeMuestra.ClaseDeMuestra) {
                    case EnumClaseMuestra.Producto:
                        muestra = cMuestras.CrearNuevaMuestraProducto(
                            m.Muestra.EspecificacionDeMuestra.EspecificacionDeMuestraId,
                            m.Muestra.IdentificacionDeMuestra, m.Muestra.EsRepeticion, (m.Muestra as Producto).FechaDeFaena,
                            (m.Muestra as Producto).FechaDeProduccion, (m.Muestra as Producto).LoteDeProducto, m.Muestra.Area.AreaId);
                        break;

                    case EnumClaseMuestra.Ambiente:
                        muestra = cMuestras.CrearNuevaMuestraAmbiente(
                            m.Muestra.EspecificacionDeMuestra.EspecificacionDeMuestraId,
                            m.Muestra.IdentificacionDeMuestra, m.Muestra.EsRepeticion, (m.Muestra as Ambiente).HorarioDeMuestra,
                            m.Muestra.Area.AreaId);
                        break;

                    case EnumClaseMuestra.Superficie:
                        muestra = cMuestras.CrearNuevaMuestraSuperficie(
                            m.Muestra.EspecificacionDeMuestra.EspecificacionDeMuestraId,
                            m.Muestra.IdentificacionDeMuestra, m.Muestra.EsRepeticion, (m.Muestra as Ambiente).HorarioDeMuestra,
                            (m.Muestra as Superficie).EnContactoConProducto, m.Muestra.Area.AreaId);
                        break;

                    default:
                        muestra = cMuestras.CrearNuevaOtraMuestra(
                            m.Muestra.EspecificacionDeMuestra.EspecificacionDeMuestraId,
                            m.Muestra.IdentificacionDeMuestra, m.Muestra.EsRepeticion, (m.Muestra as Otra).EnContactoConProducto,
                            m.Muestra.Area.AreaId);
                        break;
                }
                cMuestreos.AgregarMuestra(muestra.MuestraId, mAbierto.MuestreoId);
                foreach(Analisis analisis in m.AnalisisDelMuestreo) {
                    cEnsayos.CrearNuevoAnalisis(analisis.Ensayo.EnsayoId, mAbierto.MuestreoId,
                                                EnumMotivoAnalisis.PoolAbierto, idLaboratorioDeAnalisis);
                }
                muestreos.Add(mAbierto);
            }
            cPooles.MarcarPoolAbierto(pool.MuestreoId);
            return muestreos;
        }

        private void ResultadosFormClosing(object sender, FormClosingEventArgs e) {
            instancia = null;
        }

    }
}
