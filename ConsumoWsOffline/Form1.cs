using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ConsumoWsOffline.Servicio;
using System.Drawing;

using Ionic.Zip;
using System.ServiceModel;

namespace ConsumoWsOffline
{
	public partial class Form1 : Form
	{

        string NombreArchivoTXT;
        string Emisor_Ruc_Clave;
		public enum TipoDato { TXT, XML };
		
		public Form1()
		{
			InitializeComponent();
			btnObtener.Enabled = false;
            btnLimpiar.Enabled = false;
		}
        private string ValidarNombreArchivo( string NombreArchivo)
        {
            string NomArchivo= NombreArchivo.Substring(0, NombreArchivo.Length - 4);
            string Comprobante=null;
            string[,] ListaExpresionRegulares=new string[11,2]
                
                {{@"^[0-9]{11}[-]{1}[0]{1}[1]{1}[-]{1}[F]{1}[A-Z0-9]{3}[-]{1}[0-9]{1,8}$","FACTURA"},
                 {@"^[0-9]{11}[-]{1}[0]{1}[3]{1}[-]{1}[B]{1}[A-Z0-9]{3}[-]{1}[0-9]{1,8}$","BOLETA DE VENTA"},
                 {@"^[0-9]{11}[-]{1}[0]{1}[7]{1}[-]{1}[FB]{1}[A-Z0-9]{3}[-]{1}[0-9]{1,8}$","NOTA DE CREDITO"},
                 {@"^[0-9]{11}[-]{1}[0]{1}[8]{1}[-]{1}[FB]{1}[A-Z0-9]{3}[-]{1}[0-9]{1,8}$","NOTA DE DEBITO"},
                 {@"^[0-9]{11}[-]{1}[R]{1}[C]{1}[-]{1}" + DateTime.Now.ToString("yyyyMMdd") + "[-]{1}[0-9]{1,5}$","RESUMEN DIARIO"},
                 {@"^[0-9]{11}[-]{1}[R]{1}[A]{1}[-]{1}" + DateTime.Now.ToString("yyyyMMdd") + "[-]{1}[0-9]{1,5}$","COMUNICACION DE BAJA"},
                 {@"^[0-9]{11}[-]{1}[0]{1}[9]{1}[-]{1}[T]{1}[A-Z0-9]{3}[-]{1}[0-9]{1,8}$","GUIA DE REMISION REMITENTE"},
                 {@"^[0-9]{11}[-]{1}[2]{1}[0]{1}[-]{1}[R]{1}[A-Z0-9]{3}[-]{1}[0-9]{1,8}$","RETENCION"},
                 {@"^[0-9]{11}[-]{1}[4]{1}[0]{1}[-]{1}[P]{1}[A-Z0-9]{3}[-]{1}[0-9]{1,8}$","PERCEPCION"},
                 {@"^[0-9]{11}[-]{1}[R]{1}[R]{1}[-]{1}" + DateTime.Now.ToString("yyyyMMdd") + "[-]{1}[0-9]{1,5}$","REVERSION RETENCION"},
                 {@"^[0-9]{11}[-]{1}[R]{1}[P]{1}[-]{1}" + DateTime.Now.ToString("yyyyMMdd") + "[-]{1}[0-9]{1,5}$","REVERSION PERCEPCION" }      
                };

            for (int i = 0; i < ListaExpresionRegulares.Length; i++)
            {
                if (i < 11)
                {
                    System.Text.RegularExpressions.Regex RegEx = new System.Text.RegularExpressions.Regex(ListaExpresionRegulares[i, 0].ToString());
                    System.Text.RegularExpressions.Match Resultado = RegEx.Match(NomArchivo);
                    if (Resultado.Success)
                    {
                        Comprobante = ListaExpresionRegulares[i, 1].ToString(); break;

                        //MessageBox.Show("Bien"); break;
                        

                    }
                }
                else
                {
                    Comprobante = "Nombre del archivo no tiene el formato esperado";
                }
            }

            return Comprobante;
            //string Tipo_Comprobante = NombreArchivo.Substring(11, 4);
            //
            //switch( Tipo_Comprobante )

            //{
            //    case "-01-": Comprobante = "FACTURA"; break;
            //    case "-03-": Comprobante = "BOLETA DE VENTA"; break;
            //    case "-07-": Comprobante = "NOTA DE CREDITO"; break;
            //    case "-08-": Comprobante = "NOTA DE DEBITO"; break;
            //    case "-09-": Comprobante = "GUIA REMISION REMITENTE"; break;
            //    case "-20-": Comprobante = "RETENCION"; break;
            //    case "-40-": Comprobante = "PERCEPCION"; break;
            //    case "-RA-": Comprobante = "COMUNICACION DE BAJA"; break;
            //    case "-RC-": Comprobante = "RESUMEN DIARIO"; break;
            //    case "-RR-": Comprobante = "REVERSION RETENCION"; break;
            //    case "-RP-": Comprobante = "REVERSION PERCEPCION"; break;
            //    default: Comprobante = "El archivo no tiene el formato esperado"; break;
            //}
            
        }




		private string procesarOffLine(TipoDato voTipoDoc, string pvRuc, string pvClave,string pvNombre , byte[] pvContenido)
		{
			string voMsjRespuesta = null, voNumTicket ,voValorResumen, voValorFirma, voCodError;
			int voCodRespuesta;
			
			ConsumoWsOffline.Servicio.CoreBusinessSoapClient off = new ConsumoWsOffline.Servicio.CoreBusinessSoapClient();
			
			
			if(voTipoDoc==TipoDato.TXT)
				//voCodRespuesta = off.ProcesaComprobanteOfflineTXT(pvRuc, pvClave, pvNombre, pvContenido, out voNumTicket, out voValorResumen, out voValorFirma, out voCodError);
				voCodRespuesta = off.ProcesaComprobanteTicketTXT(pvRuc, pvClave, pvNombre, pvContenido, out voNumTicket, out voValorResumen, out voValorFirma, out voCodError);
			else
				//voCodRespuesta = off.ProcesaComprobanteOfflineXML(pvRuc, pvClave, pvNombre, pvContenido, out voNumTicket, out voValorResumen, out voValorFirma, out voCodError);
                //voCodRespuesta = off.ProcesaComprobanteTicketSND(pvRuc, pvClave, pvNombre, pvContenido, out voNumTicket, out voValorResumen, out voValorFirma, out voCodError);
                voCodRespuesta = off.ProcesaComprobanteTicketSND(pvRuc, pvClave, pvNombre, pvContenido, out voNumTicket, out voValorResumen, out voValorFirma, out voCodError);

			voMsjRespuesta += "Respuesta=" + voCodRespuesta + moProcesaDescriptionError(voCodRespuesta) + Environment.NewLine + 
									"ValorResumen=" + voValorResumen + Environment.NewLine + 
									"ValorFirma=" + voValorFirma;			
			if (voNumTicket != null)
				lblTicket.Text = voNumTicket;

			if (voCodRespuesta != 0)
				voMsjRespuesta += Environment.NewLine + "Cod Error = " + voCodError;

			return voMsjRespuesta;
		}
		private void procesarOnLine(TipoDato voTipoDoc, string pvRuc, string pvClave, string pvNombre, byte[] pvContenido)
		{
			byte[] voByteRespuesta = null;
			int voCodRespuesta;
			string voFileZipIntegracion = txtUbicacion.Text + @"\WS_INTEGRACION.zip";//Nombre del archivo de integración ZIP
			string voFileUnzipIntegracion = null;//Nombre del archivo de integración DesZipeado

			ConsumoWsOffline.Servicio.CoreBusinessSoapClient on = new ConsumoWsOffline.Servicio.CoreBusinessSoapClient();

			if (voTipoDoc == TipoDato.TXT)
			voCodRespuesta= on.ProcesaComprobanteDirectTXT(pvRuc, pvClave, pvNombre, pvContenido, out voByteRespuesta);
			//voCodRespuesta = on.ProcesaComprobanteOnlineTXT(pvRuc, pvClave, pvNombre, pvContenido, out voByteRespuesta);
				
			else
				voCodRespuesta = on.ProcesaComprobanteDirectXML(pvRuc, pvClave, pvNombre, pvContenido, out voByteRespuesta);
			//voCodRespuesta = on.ProcesaComprobanteOnlineXML(pvRuc, pvClave, pvNombre, pvContenido, out voByteRespuesta);


			if (voByteRespuesta != null)
			{
				File.WriteAllBytes(voFileZipIntegracion, voByteRespuesta);

				using (var zf = Ionic.Zip.ZipFile.Read(voFileZipIntegracion))
				{
					zf.ToList().ForEach(entry =>
					{
						entry.FileName = System.IO.Path.GetFileName(entry.FileName);
						voFileUnzipIntegracion = txtUbicacion.Text + @"\" + entry.FileName;

						if (File.Exists(voFileUnzipIntegracion))
							File.Delete(voFileUnzipIntegracion);

						entry.Extract(txtUbicacion.Text);

						MessageBox.Show("Archivo creado: " + voFileUnzipIntegracion);
					});
				}

				StreamReader sr = new StreamReader(voFileUnzipIntegracion);
				string line = sr.ReadToEnd();
				lblRespuestaIntegracion.Text = line;
			}
			

		}
		private string comprimir(string pvFileTxt, string pvFile7z)
		{
			string voFileZip;

			if (String.IsNullOrEmpty(pvFileTxt))
				voFileZip = null;
			else
			{
				string voFileName = System.IO.Path.GetFileName(pvFileTxt);
				string voAplicationPath = Path.GetDirectoryName(Application.ExecutablePath);
				string voTemporalPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\temp";

				if (!Directory.Exists(voTemporalPath))
					Directory.CreateDirectory(voTemporalPath);

				voFileZip = voTemporalPath + @"\" + voFileName.Substring(0, voFileName.Length - 4) + ".zip";

				if (File.Exists(voFileZip))
					File.Delete(voFileZip);
					
				using (ZipFile zip = new ZipFile(voFileZip))
				{
					zip.AddFile(pvFileTxt, String.Empty);
					if(!string.IsNullOrEmpty(pvFile7z))
						zip.AddFile(pvFile7z, String.Empty);

					zip.Save();

				}
			}
			return voFileZip;
		}
		private string moProcesaDescriptionError(int CodMensaje)
		{
			string voMsjRespuesta = null;
			switch(CodMensaje)
			{
				case 0:
					voMsjRespuesta="OK";
					break;

				case 1:
					voMsjRespuesta = "Formato de nombre de archivo incorrecto";
					break;

				case 2:
					voMsjRespuesta = "Datos del comprobante incongruentes con el nombre de archivo (nota: en desarrollo)";
					break;

				case 3:
					voMsjRespuesta = "RUC de Empresa y/o Clave de Acceso incorrectos";
					break;

				case 4:
					voMsjRespuesta = "Error en almacenar los archivos recibidos";
					break;

				case 5:
					voMsjRespuesta = "Error en la validación y traducción del archivo plano";
					break;

				case 6:
					voMsjRespuesta = "Error en la validación y firma del archivo XML";
					break;

				case 7:
					voMsjRespuesta = "Error en la generación del archivo de integración";
					break;

				default:
					voMsjRespuesta = "Error desconocido";
					break;
			}
			return " (" + voMsjRespuesta + ")";
		}
		private string moObtieneDescriptionError(int CodMensaje)
		{
			string voMsjRespuesta = null;
			switch (CodMensaje)
			{
				case 0:
					voMsjRespuesta = "OK";
					break;

				case 1:
					voMsjRespuesta = "RUC de Empresa y/o Clave de Acceso incorrectos";
					break;

				case 2:
					voMsjRespuesta = "Ticket inexistente";
					break;

				case 3:
					voMsjRespuesta = "Número de descargas supera el permitido";
					break;

				case 4:
					voMsjRespuesta = "Pendiente de proceso";
					break;

				case 5:
					voMsjRespuesta = "Error en la generación del archivo de integración";
					break;

				default:
					voMsjRespuesta = "Error desconocido";
					break;
			}
			return " (" + voMsjRespuesta + ")";
		}
		private void btnUbicacion_Click(object sender, EventArgs e)
		{
         

			openFileDialog1.Filter = "Files (TXT,XML)|*.TXT;*.XML";
			DialogResult result = openFileDialog1.ShowDialog();
			
			if (result == DialogResult.OK)
			{
				try
				{
					txtArchivo.Text = openFileDialog1.FileName;
                    NombreArchivoTXT= openFileDialog1.SafeFileName;
                    Emisor_Ruc_Clave = NombreArchivoTXT.Substring(0, 11);
                    txtArchivo.BackColor = Color.LemonChiffon;
                    lblTipoComprobante.Text = ValidarNombreArchivo(NombreArchivoTXT);
                   //MessageBox.Show( ValidarNombreArchivo(NombreArchivoTXT));
                    
                // MessageBox.Show(NombreArchivoTXT.Substring(0,NombreArchivoTXT.Length -4));
                    
                    
				}
				catch (IOException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
        private void btnOpcional_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Files (7Z)|*.7z";
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    txtOpcional.Text = openFileDialog2.FileName;
                    txtOpcional.BackColor = Color.LemonChiffon;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

		private void btnPath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog voFile = new FolderBrowserDialog();
			voFile.Description = "Seleccione Directorio donde almacenará los archivos de integración";
			DialogResult voDialog = voFile.ShowDialog(this);

			if (voDialog == DialogResult.OK)
				txtUbicacion.Text = voFile.SelectedPath;
            txtUbicacion.BackColor = Color.LemonChiffon;
		}
		private void lblTicket_TextChanged(object sender, EventArgs e)
		{
			this.btnObtener.Enabled = !string.IsNullOrWhiteSpace(this.lblTicket.Text);
		}
		private void btnGenerar_Click(object sender, EventArgs e)
		{
			string voExtensionArch = Path.GetExtension(txtArchivo.Text);
			string voRutaYNomArchZip = comprimir(txtArchivo.Text, txtOpcional.Text);

			if (voRutaYNomArchZip == null)
				MessageBox.Show("DEBE CARGAR OBLIGATORIAMENTE EL ARCHIVO PRINCIPAL");
			else
			{
				string voFileName = System.IO.Path.GetFileName(txtArchivo.Text);
				voFileName = voFileName.Substring(0, voFileName.Length - 4);

				if (voExtensionArch == ".txt")
					//txtRespuestaTicket.Text = procesarOffLine(TipoDato.TXT, txtRuc.Text, txtClave.Text, voFileName, File.ReadAllBytes(voRutaYNomArchZip));
                    txtRespuestaTicket.Text = procesarOffLine(TipoDato.TXT, Emisor_Ruc_Clave.ToString(), Emisor_Ruc_Clave.ToString(), voFileName, File.ReadAllBytes(voRutaYNomArchZip));
                    
				else
					//txtRespuestaTicket.Text = procesarOffLine(TipoDato.XML, txtRuc.Text, txtClave.Text, voFileName, File.ReadAllBytes(voRutaYNomArchZip));
                    txtRespuestaTicket.Text = procesarOffLine(TipoDato.XML, Emisor_Ruc_Clave.ToString(), Emisor_Ruc_Clave.ToString(), voFileName, File.ReadAllBytes(voRutaYNomArchZip));
			}


		}
		private void btnObtener_Click(object sender, EventArgs e)
		{
			byte[] voRptaIntegracion;//respuesta en bytes del consumo de web service que representa el archivo de integración
			string voFileZipIntegracion = txtUbicacion.Text + @"\WS_INTEGRACION" + "_"+ NombreArchivoTXT + "_.zip";//Nombre del archivo de integración ZIP
			string voFileUnzipIntegracion = null;//Nombre del archivo de integración DesZipeado

			if (txtUbicacion.Text.Length == 0)
				MessageBox.Show("Es necesario escoger la ruta para almacenar los archivos de integración");
			else
			{
				if (!Directory.Exists(txtUbicacion.Text))
					Directory.CreateDirectory(txtUbicacion.Text);
			
				if (File.Exists(voFileZipIntegracion))
					File.Delete(voFileZipIntegracion);
				try
				{
					ConsumoWsOffline.Servicio.CoreBusinessSoapClient off = new ConsumoWsOffline.Servicio.CoreBusinessSoapClient();
                    int voCodRespuesta = off.ObtenerEstadoComprobanteTicket(Emisor_Ruc_Clave.ToString(), Emisor_Ruc_Clave.ToString(), lblTicket.Text, out voRptaIntegracion);
                   // int voCodRespuesta = off.ObtenerEstadoComprobanteTicket(txtRuc.Text, txtClave.Text, lblTicket.Text, out voRptaIntegracion);

					//int voCodRespuesta = off.ObtenerEstadoComprobanteTicket_TEST(txtRuc.Text, txtClave.Text, lblTicket.Text, out voRptaIntegracion);
									
					lblCodRpta.Text = voCodRespuesta + moObtieneDescriptionError(voCodRespuesta);

					if (voRptaIntegracion != null)
					{
						File.WriteAllBytes(voFileZipIntegracion, voRptaIntegracion);

						using (var zf = Ionic.Zip.ZipFile.Read(voFileZipIntegracion))
						{
							zf.ToList().ForEach(entry =>
							{
								entry.FileName = System.IO.Path.GetFileName(entry.FileName);
								voFileUnzipIntegracion = txtUbicacion.Text + @"\" + entry.FileName;

								if (File.Exists(voFileUnzipIntegracion))
									File.Delete(voFileUnzipIntegracion);

								entry.Extract(txtUbicacion.Text);

								MessageBox.Show("Archivo creado: " + voFileUnzipIntegracion);
                                btnLimpiar.Enabled = true;
							});
						}

						StreamReader sr = new StreamReader(voFileUnzipIntegracion);
						string line = sr.ReadToEnd();
						lblRespuestaIntegracion.Text = line;
					}
				}
				catch (FaultException fe)
				{
					String salida = fe.Message;
				}

			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolComentarios.SetToolTip(this.btnUbicacion, "Abrir Archivo");
            ToolComentarios.SetToolTip(this.btnOpcional, "Abrir Archivo");
            ToolComentarios.SetToolTip(this.btnPath, "Seleccionar Ubicación");
            ToolComentarios.SetToolTip(this.btnGenerar, "Enviar Archivo");
            ToolComentarios.SetToolTip(this.btnObtener, "Obtener Respuesta");
            ToolComentarios.SetToolTip(this.btnLimpiar, "Limpar Formulario");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtArchivo.Clear();
            txtOpcional.Clear();
            txtUbicacion.Clear();
            lblTicket.Clear();
            txtRespuestaTicket.Clear();
            lblRespuestaIntegracion.Clear();
            btnUbicacion.Focus();
            
          
            
        }

      

	}
}
