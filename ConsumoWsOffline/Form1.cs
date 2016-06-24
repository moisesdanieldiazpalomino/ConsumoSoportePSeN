using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ConsumoWsOffline.Servicio;

using Ionic.Zip;
using System.ServiceModel;

namespace ConsumoWsOffline
{
	public partial class Form1 : Form
	{
		
		public enum TipoDato { TXT, XML };
		
		public Form1()
		{
			InitializeComponent();
			btnObtener.Enabled = false;
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
					txtRespuestaTicket.Text = procesarOffLine(TipoDato.TXT, txtRuc.Text, txtClave.Text, voFileName, File.ReadAllBytes(voRutaYNomArchZip));
				else
					txtRespuestaTicket.Text = procesarOffLine(TipoDato.XML, txtRuc.Text, txtClave.Text, voFileName, File.ReadAllBytes(voRutaYNomArchZip));
			}


		}
		private void btnObtener_Click(object sender, EventArgs e)
		{
			byte[] voRptaIntegracion;//respuesta en bytes del consumo de web service que representa el archivo de integración
			string voFileZipIntegracion = txtUbicacion.Text + @"\WS_INTEGRACION.zip";//Nombre del archivo de integración ZIP
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
					int voCodRespuesta = off.ObtenerEstadoComprobanteTicket(txtRuc.Text, txtClave.Text, lblTicket.Text, out voRptaIntegracion);
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

	}
}
