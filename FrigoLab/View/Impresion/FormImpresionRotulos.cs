using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Logica.Muestreos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrigoLab.View.Rotulos {
    public partial class FormImpresionRotulos:Form {
        private PrintDocument printDocument = new PrintDocument();
        private Muestreo muestreoParaImprimir;
        private Pool poolDeMuestreo;

        private ControladorPooles cPool = new ControladorPooles();

        public FormImpresionRotulos(Muestreo muestreoSeleccionado) {
            InitializeComponent();

            if((muestreoSeleccionado as Individual).Pool != null) {
                poolDeMuestreo = CargarMuestreo((muestreoSeleccionado as Individual).Pool.MuestreoId) as Pool;
            }
            muestreoParaImprimir = muestreoSeleccionado;

            trackBarZoom.Minimum = 50;
            trackBarZoom.Maximum = 150;
            trackBarZoom.Value = 100;
            labelNivelZoom.Text = trackBarZoom.Value.ToString()  + " %";
            printPreviewControl.Zoom = Convert.ToDouble(trackBarZoom.Value)/100;

            // controles de impresion
            printDialog.Document = printDocument;
            printPreviewControl.Document = printDocument;
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;
            printDialog.PrinterSettings = printPreviewControl.Document.PrinterSettings;
        }

        private Muestreo CargarMuestreo(int id) {
            return muestreoParaImprimir = cPool.ObtenerPool(id);
        }

        private void FormImpresionRotulos_Load(object sender, EventArgs e) {
            printDocument.PrintPage +=PrintDocument_PrintPage;
            labelImpresoraSeleccionada.Text = printPreviewControl.Document.PrinterSettings.PrinterName;
            this.Icon = FrigLab.Properties.Resources.icono_imprimir;
        }

        /// <summary>
        /// Evento que crea el documento que se enviara a imprimir.
        /// Se toma el muestreo inicializado en el constructor del formulario y se imprimen los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e) {
            try {
                StringBuilder strTexto = new StringBuilder();
                DateTime fechaMuestreo = ((muestreoParaImprimir as Individual).FechaHoraDeMuestreo);
                strTexto.Append(fechaMuestreo.Year.ToString())
                    .Append(fechaMuestreo.Month.ToString())
                    .Append(fechaMuestreo.Day.ToString());
                strTexto.Append(muestreoParaImprimir.MuestreoId);
                // recuadro exterior
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle { Height=400, Width=400 });
                // codigo
                e.Graphics.DrawString(strTexto.ToString(), new Font("Code 128", 48, FontStyle.Regular), Brushes.Black, 10, 10);
                e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 45, 75);
                // Nombre
                strTexto.Clear();
                strTexto.Append((muestreoParaImprimir as Individual).Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra)
                    .Append(" ")
                    .Append((muestreoParaImprimir as Individual).Muestra.IdentificacionDeMuestra);
                e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 150, 25);
                // Sector
                e.Graphics.DrawRectangle(Pens.Black, 0, 100, 400, 100);
                strTexto.Clear();
                strTexto.Append((muestreoParaImprimir as Individual).Muestra.Area.NombreDeArea);
                e.Graphics.DrawString("Sector:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 25, 100);
                e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 90, 100);
                // Fecha de Muestreo
                strTexto.Clear();
                strTexto.Append((muestreoParaImprimir as Individual).FechaHoraDeMuestreo.ToShortDateString());
                e.Graphics.DrawString("Fecha Muestreo:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 25, 125);
                e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 190, 125);
                //[SOLO PARA MUESTREO DE TIPO PRODUCTO]
                // Fecha de Produccion y Faena
                if((muestreoParaImprimir as Individual).Muestra.EspecificacionDeMuestra.ClaseDeMuestra == FrigLab.Model.Dominio.Enumeraciones.Muestras.EnumClaseMuestra.Producto) {
                    strTexto.Clear();
                    strTexto.Append(((muestreoParaImprimir as Individual).Muestra as Producto).FechaDeProduccion.ToShortDateString());
                    e.Graphics.DrawString("Fecha Produccion:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 25, 150);
                    e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 190, 150);

                    strTexto.Clear();
                    strTexto.Append(((muestreoParaImprimir as Individual).Muestra as Producto).FechaDeFaena.ToShortDateString());
                    e.Graphics.DrawString("Fecha Faena:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 25, 175);
                    e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 190, 175);
                }
                // Observaciones
                if(!string.IsNullOrEmpty((muestreoParaImprimir as Individual).ObservacionesDeMuestreo)) {
                    // recuadro observaciones
                    e.Graphics.DrawRectangle(Pens.Black, 0, 200, 400, 100);
                    strTexto.Clear();
                    strTexto.Append((muestreoParaImprimir as Individual).ObservacionesDeMuestreo);
                    e.Graphics.DrawString("Observaciones:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 25, 200);
                    e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 220);
                }
                // Otros datos
                e.Graphics.DrawRectangle(Pens.Black, 0, 300, 400, 100);
                if(poolDeMuestreo != null) {
                    strTexto.Clear();
                    strTexto.Append(poolDeMuestreo.DescripcionDePool)
                        .Append(" ")
                         .Append(poolDeMuestreo.FechaCreacionDePool.Date.ToShortDateString())
                         .Append(": ")
                         .Append((poolDeMuestreo.MuestreosDePool.Count.ToString()))
                        .Append(" muestras");
                    e.Graphics.DrawString("Pool:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 25, 300);
                    e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 320);
                } else {
                    // Numero de muestra
                    strTexto.Clear();
                    strTexto.Append((muestreoParaImprimir as Individual).NumeroDeMuestreo.ToString());
                    e.Graphics.DrawString("Muestra Nº:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 25, 300);
                    e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 175, 300);

                    // Muestreador
                    strTexto.Clear();
                    strTexto.Append((muestreoParaImprimir as Individual).Usuario.UsuarioId.ToString())
                        .Append(" | ")
                        .Append((muestreoParaImprimir as Individual).Usuario.NombreCompleto);
                    e.Graphics.DrawString("Muestreado por:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 25, 320);
                    e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 175, 322);
                }

            } catch(Exception ex) { }

        }

        private void buttonConfigPagina_Click(object sender, EventArgs e) {
            if(pageSetupDialog.ShowDialog() == DialogResult.OK) {
                printPreviewControl.Document.DefaultPageSettings = pageSetupDialog.PageSettings;
                printPreviewControl.InvalidatePreview();
            }
        }

        private void buttonSeleccionarImpresora_Click(object sender, EventArgs e) {
            printDialog.UseEXDialog  = true;
            if(printDialog.ShowDialog() == DialogResult.OK) {
                printPreviewControl.Document.PrinterSettings = printDialog.PrinterSettings;
                labelImpresoraSeleccionada.Text = printPreviewControl.Document.PrinterSettings.PrinterName;
                printPreviewControl.Update();
                printPreviewControl.InvalidatePreview();
            }
        }

        private void buttonImprimir_Click(object sender, EventArgs e) {
            try {
                printDocument.Print();
            } catch(InvalidPrinterException printerException) {
                MessageBox.Show("No se pudo imprimir. Existe un problema con la impresora.");
            } catch(Exception ex) {
                MessageBox.Show("Error desconocido.");
                this.Close();
            }
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e) {
            printPreviewControl.Zoom = Convert.ToDouble((sender as TrackBar).Value)/100;
            printPreviewControl.Update();
            labelNivelZoom.Text = (sender as TrackBar).Value.ToString() + " %";
        }

        private void buttonCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
