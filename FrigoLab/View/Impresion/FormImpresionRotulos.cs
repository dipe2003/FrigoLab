using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Logica.Muestreos;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrigoLab.View.Rotulos {
    public partial class FormImpresionRotulos:Form {
        private PrintDocument printDocument = new PrintDocument();
        private Muestreo muestreoParaImprimir;
        private Pool poolDeMuestreo;
        private int numeroCopias;

        // propiedades del papel
        int altoPapel = 0;
        int anchoPapel = 0;
        int altoRectangulo = 0;

        // tamaño de fuentes
        private int textoCodigoBarras = 48;
        private int textoNormal = 10;

        private int textoSubtitulo = 9;
        private int textoPequenio = 8;

        private int desplazamientoTexto = 0;
        private int margenIzquierdo = 0;
        private int margenSuperior = 0;

        private ControladorPooles cPool = new ControladorPooles();

        public FormImpresionRotulos(Muestreo muestreoSeleccionado) {
            InitializeComponent();

            if((muestreoSeleccionado as Individual).Pool != null) {
                poolDeMuestreo = CargarPool((muestreoSeleccionado as Individual).Pool.MuestreoId) as Pool;
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

        private Muestreo CargarPool(int id) {
            return muestreoParaImprimir = cPool.ObtenerPool(id);
        }

        private void FormImpresionRotulos_Load(object sender, EventArgs e) {
            printDocument.PrintPage +=PrintDocument_PrintPage;
            labelImpresoraSeleccionada.Text = printPreviewControl.Document.PrinterSettings.PrinterName;
            this.Icon = FrigLab.Properties.Resources.icono_imprimir;
        }

        #region Metodos para variables dependientes del tamaño del papel seleccionado
        private void CalcularPropiedadesPapel() {
            if(printDocument.PrinterSettings.DefaultPageSettings.Landscape) {
                anchoPapel = printDocument.PrinterSettings.DefaultPageSettings.PaperSize.Height;
                altoPapel = printDocument.PrinterSettings.DefaultPageSettings.PaperSize.Width;
            } else {
                altoPapel = printDocument.PrinterSettings.DefaultPageSettings.PaperSize.Height;
                anchoPapel = printDocument.PrinterSettings.DefaultPageSettings.PaperSize.Width;
            }
            // el alto del papel se divide en 4 sectores
            altoRectangulo = altoPapel/4;
            desplazamientoTexto = Convert.ToInt16(altoRectangulo * 0.05);
            margenIzquierdo = Convert.ToInt16(anchoPapel*0.01);
            margenSuperior = Convert.ToInt16(altoPapel*0.01);
        }

        private void CalcularFuentes() {
            // tamaño de fuentes
            textoCodigoBarras = 48 + Convert.ToInt16(altoRectangulo * 0.08);
            textoNormal = 10 + Convert.ToInt16(altoRectangulo * 0.01);

            textoSubtitulo = 9 + Convert.ToInt16(altoRectangulo * 0.01);
            textoPequenio = 8 + Convert.ToInt16(altoRectangulo * 0.01);
        }

        #endregion

        /// <summary>
        /// Evento que crea el documento que se enviara a imprimir.
        /// Se toma el muestreo inicializado en el constructor del formulario y se imprimen los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e) {
            try {
                // dibujar limites de rotulo
                CalcularPropiedadesPapel();
                CalcularFuentes();
                DibujarRectangulos(e);

                // Datos de identificacion
                DibuarDatosIdentificacion(e);
                DibujarDatosSectorFechas(e);

                // Datos del muestreos, si es pool identificacion de pool, si es muestra identificacoin de la muestra
                if(poolDeMuestreo != null) {
                    DibujarAreaPoolMuestra(e);
                } else {
                    DibujarAreaMuestra(e);
                }

                // Comprobar si existen observaciones
                if(!string.IsNullOrEmpty((muestreoParaImprimir as Individual).ObservacionesDeMuestreo)) {
                    DibujarAreaObservaciones(e);
                }

                // Comprobar si se asignaron analisis
                if(muestreoParaImprimir.AnalisisDelMuestreo.Any()) {
                    DibujarAreaAnalisis(e);
                }
            } catch(Exception ex) { }

        }

        #region Metodos Dibujo
        /// <summary>
        /// Dibuja las areas donde se imprimiran los datos del muestreo.
        /// Cada area se delimita segun el tamanio del papel seleccionado.
        /// </summary>
        /// <param name="e"></param>
        private void DibujarRectangulos(PrintPageEventArgs e) {
            // recuadro Sector y Fechas
            e.Graphics.DrawLine(Pens.Black, new Point { X = 0, Y=altoRectangulo }, new Point { X=anchoPapel, Y=altoRectangulo });
            e.Graphics.DrawLine(Pens.Black, new Point { X = 0, Y=altoRectangulo*2 }, new Point { X=anchoPapel, Y=altoRectangulo*2 });

            // recuadro observaciones
            e.Graphics.DrawLine(Pens.Black, new Point { X = 0, Y=altoRectangulo*3 }, new Point { X=anchoPapel, Y=altoRectangulo*3 });
        }

        /// <summary>
        /// Dibuja los datos correspondientes a la identificacion de la muesrtra.
        /// Fecha de muestreo, código y nombre de la muestra 
        /// </summary>
        /// <param name="e"></param>
        private void DibuarDatosIdentificacion(PrintPageEventArgs e) {
            DateTime fechaMuestreo = ((muestreoParaImprimir as Individual).FechaHoraDeMuestreo);            
            string textoFechaMuestreo = String.Format("{0:yy/MM/dd}", fechaMuestreo);
            string[] datosFecha = textoFechaMuestreo.Split('/');
            StringBuilder strTexto = new StringBuilder();
            // Codigo: AA/M/D/CLASEMUESTRA/IDMUESTREO
            // AA/M/D
            strTexto.Append(datosFecha[0])
                .Append(datosFecha[1])
                .Append(datosFecha[2]);
            // Clase de Muestra: entero que corresponde al enumerado
            strTexto.Append((int)(muestreoParaImprimir.Muestra.EspecificacionDeMuestra.ClaseDeMuestra));
            // id del muestreo
            strTexto.Append(muestreoParaImprimir.MuestreoId);

            // codigo
            e.Graphics.DrawString(strTexto.ToString(), new Font("Code 128", textoCodigoBarras, FontStyle.Regular), Brushes.Black, new PointF { X= Convert.ToInt16(anchoPapel*0.01), Y= Convert.ToInt16(altoPapel*0.01) });
            e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoNormal, FontStyle.Regular), Brushes.Black, new PointF { X= Convert.ToInt16(anchoPapel*0.12)+170+ Convert.ToInt16(altoRectangulo * 0.08), Y= Convert.ToInt16(altoPapel*0.01)+10 });

            // Nombre
            strTexto.Clear();
            strTexto.AppendLine((muestreoParaImprimir as Individual).Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra)
                .Append((muestreoParaImprimir as Individual).Muestra.IdentificacionDeMuestra);
            e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoNormal, FontStyle.Bold), Brushes.Black, new PointF { X= Convert.ToInt16(anchoPapel*0.12)+170+ Convert.ToInt16(altoRectangulo * 0.08), Y= Convert.ToInt16(altoPapel*0.01)+30 });
        }

        /// <summary>
        /// Dibuja los datos correspondientes a los datos del muestreo.
        /// Sector, fecha de faena, fecha de produccion.
        /// </summary>
        /// <param name="e"></param>
        private void DibujarDatosSectorFechas(PrintPageEventArgs e) {
            StringBuilder strTexto = new StringBuilder();
            // Sector
            strTexto.Append((muestreoParaImprimir as Individual).Muestra.Area.NombreDeArea);
            e.Graphics.DrawString("Sector:", new Font("Arial", textoNormal, FontStyle.Bold), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo);
            e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoNormal, FontStyle.Regular), Brushes.Black, margenIzquierdo+160 + desplazamientoTexto, margenSuperior+altoRectangulo);

            // Fecha de Muestreo
            strTexto.Clear();
            strTexto.Append((muestreoParaImprimir as Individual).FechaHoraDeMuestreo.ToShortDateString());
            e.Graphics.DrawString("Fecha Muestreo:", new Font("Arial", textoNormal, FontStyle.Bold), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo+25);
            e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoNormal, FontStyle.Regular), Brushes.Black, margenIzquierdo+160+ desplazamientoTexto, margenSuperior+altoRectangulo+25);

            //[SOLO PARA MUESTREO DE TIPO: PRODUCTO]
            // Fecha de Produccion y Faena
            if((muestreoParaImprimir as Individual).Muestra.EspecificacionDeMuestra.ClaseDeMuestra == FrigLab.Model.Dominio.Enumeraciones.Muestras.EnumClaseMuestra.Producto) {
                strTexto.Clear();
                strTexto.Append(((muestreoParaImprimir as Individual).Muestra as Producto).FechaDeProduccion.ToShortDateString());
                e.Graphics.DrawString("Fecha Produccion:", new Font("Arial", textoNormal, FontStyle.Bold), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo+50);
                e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoNormal, FontStyle.Regular), Brushes.Black, margenIzquierdo+160+ desplazamientoTexto, margenSuperior+altoRectangulo+50);

                strTexto.Clear();
                strTexto.Append(((muestreoParaImprimir as Individual).Muestra as Producto).FechaDeFaena.ToShortDateString());
                e.Graphics.DrawString("Fecha Faena:", new Font("Arial", textoNormal, FontStyle.Bold), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo+75);
                e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoNormal, FontStyle.Regular), Brushes.Black, margenIzquierdo +160+ desplazamientoTexto, margenSuperior+altoRectangulo+75);
            }
        }

        /// <summary>
        /// Dibuja los datos del pool de muestreo.
        /// Nombre del pool, fecha y total de muestras.
        /// </summary>
        /// <param name="e"></param>
        private void DibujarAreaPoolMuestra(PrintPageEventArgs e) {
            StringBuilder strTexto = new StringBuilder();
            strTexto.Clear();
            strTexto.Append(poolDeMuestreo.DescripcionDePool)
                .Append(" ")
                 .Append(poolDeMuestreo.FechaCreacionDePool.Date.ToShortDateString())
                 .Append(": ")
                 .Append((poolDeMuestreo.MuestreosDePool.Count.ToString()))
                .Append(" muestras");
            e.Graphics.DrawString("Pool:", new Font("Arial", textoNormal, FontStyle.Bold), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo*2);
            e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoNormal, FontStyle.Regular), Brushes.Black, margenIzquierdo+60 +desplazamientoTexto, margenSuperior+altoRectangulo*2);
        }

        /// <summary>
        /// Dibuja los datos de la muestra individual.
        /// Numero de muestra y usuario muestreador.
        /// </summary>
        /// <param name="e"></param>
        private void DibujarAreaMuestra(PrintPageEventArgs e) {
            StringBuilder strTexto = new StringBuilder();
            // Numero de muestra
            strTexto.Clear();
            strTexto.Append((muestreoParaImprimir as Individual).NumeroDeMuestreo.ToString());
            e.Graphics.DrawString("Muestra Nº:", new Font("Arial", textoNormal, FontStyle.Bold), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo*2);
            e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoNormal, FontStyle.Regular), Brushes.Black, margenIzquierdo + 90 +desplazamientoTexto, margenSuperior+altoRectangulo*2);

            // Muestreador
            strTexto.Clear();
            strTexto.Append((muestreoParaImprimir as Individual).Usuario.UsuarioId.ToString())
                .Append(" | ")
                .Append((muestreoParaImprimir as Individual).Usuario.NombreCompleto);
            e.Graphics.DrawString("Muestreado por:", new Font("Arial", textoNormal, FontStyle.Bold), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo*2+25);
            e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoNormal, FontStyle.Regular), Brushes.Black, margenIzquierdo +150 +desplazamientoTexto, margenSuperior+altoRectangulo*2+25);
        }

        /// <summary>
        /// Dibujar los datos de las observaciones del muestreo.
        /// </summary>
        /// <param name="e"></param>
        private void DibujarAreaObservaciones(PrintPageEventArgs e) {
            StringBuilder strTexto = new StringBuilder();
            if(!string.IsNullOrEmpty((muestreoParaImprimir as Individual).ObservacionesDeMuestreo)) {
                strTexto.Clear();
                strTexto.Append((muestreoParaImprimir as Individual).ObservacionesDeMuestreo);
                e.Graphics.DrawString("Observaciones:", new Font("Arial", textoSubtitulo, FontStyle.Bold), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo*3);
                e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoPequenio, FontStyle.Regular), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo*3+15);
            }
        }

        /// <summary>
        /// Dibujar los datos de los analisis asociados el muestreo seleccionado.
        /// </summary>
        /// <param name="e"></param>
        private void DibujarAreaAnalisis(PrintPageEventArgs e) {
            StringBuilder strTexto = new StringBuilder();
            if(muestreoParaImprimir.AnalisisDelMuestreo.Any()) {
                int cantidad = 1;
                int margen = 50;
                // titulo Analisis
                e.Graphics.DrawString("Analisis:", new Font("Arial", textoSubtitulo, FontStyle.Bold), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo*3+margen);
                // espacio luego de titulo
                margen +=15;
                foreach(var analisis in muestreoParaImprimir.AnalisisDelMuestreo) {
                strTexto.Clear();
                    strTexto.Append(analisis.Ensayo.NombreDeEnsayo)
                        .Append(" (")
                        .Append(analisis.Ensayo.GetLimiteVigente().Requisito.NombreDeRequisito)
                        .Append("). ");
                    if(cantidad%2==0) {
                        margen += 15;
                    }
                    // analisis
                    e.Graphics.DrawString(strTexto.ToString(), new Font("Arial", textoPequenio, FontStyle.Regular), Brushes.Black, margenIzquierdo, margenSuperior+altoRectangulo*3+margen);

                    cantidad++;
                }
            }
        }

        #endregion

        #region Metodos Configuracion de pagina

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
        #endregion

        #region Controles de la interfaz

        private void buttonImprimir_Click(object sender, EventArgs e) {
            try {
                printDocument.PrinterSettings.Copies = (short)numeroCopias;
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

        private void numericUpDownCopias_ValueChanged(object sender, EventArgs e) {
            numeroCopias = (int)(sender as NumericUpDown).Value;
        }
        #endregion
    }
}
