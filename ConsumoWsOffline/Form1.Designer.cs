namespace ConsumoWsOffline
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtOpcional = new System.Windows.Forms.TextBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnOpcional = new System.Windows.Forms.Button();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTicket = new System.Windows.Forms.TextBox();
            this.txtRespuestaTicket = new System.Windows.Forms.RichTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCodRpta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRespuestaIntegracion = new System.Windows.Forms.RichTextBox();
            this.btnObtener = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolComentarios = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtOpcional
            // 
            this.txtOpcional.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOpcional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcional.Location = new System.Drawing.Point(11, 106);
            this.txtOpcional.Name = "txtOpcional";
            this.txtOpcional.ReadOnly = true;
            this.txtOpcional.Size = new System.Drawing.Size(813, 23);
            this.txtOpcional.TabIndex = 15;
            // 
            // txtArchivo
            // 
            this.txtArchivo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo.Location = new System.Drawing.Point(11, 38);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(813, 23);
            this.txtArchivo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adjunto (Opcional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Principal (TXT ó XML)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nro. Ticket:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblTipoComprobante);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUbicacion);
            this.groupBox2.Controls.Add(this.btnPath);
            this.groupBox2.Controls.Add(this.btnOpcional);
            this.groupBox2.Controls.Add(this.btnUbicacion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtArchivo);
            this.groupBox2.Controls.Add(this.txtOpcional);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 195);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archivos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ubicación para almacenar el Archivo de integración: ";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(11, 156);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.ReadOnly = true;
            this.txtUbicacion.Size = new System.Drawing.Size(813, 23);
            this.txtUbicacion.TabIndex = 22;
            // 
            // btnPath
            // 
            this.btnPath.BackgroundImage = global::ConsumoWsOffline.Properties.Resources.Ubicacion;
            this.btnPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPath.Location = new System.Drawing.Point(830, 152);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(33, 27);
            this.btnPath.TabIndex = 19;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnOpcional
            // 
            this.btnOpcional.BackgroundImage = global::ConsumoWsOffline.Properties.Resources.Abrir;
            this.btnOpcional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpcional.Location = new System.Drawing.Point(830, 102);
            this.btnOpcional.Name = "btnOpcional";
            this.btnOpcional.Size = new System.Drawing.Size(33, 27);
            this.btnOpcional.TabIndex = 18;
            this.btnOpcional.UseVisualStyleBackColor = true;
            this.btnOpcional.Click += new System.EventHandler(this.btnOpcional_Click);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.BackColor = System.Drawing.Color.White;
            this.btnUbicacion.BackgroundImage = global::ConsumoWsOffline.Properties.Resources.Abrir;
            this.btnUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUbicacion.Location = new System.Drawing.Point(830, 34);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(33, 27);
            this.btnUbicacion.TabIndex = 5;
            this.btnUbicacion.UseVisualStyleBackColor = false;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblTicket);
            this.groupBox3.Controls.Add(this.txtRespuestaTicket);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnGenerar);
            this.groupBox3.Location = new System.Drawing.Point(12, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(874, 135);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Respuesta Ticket";
            // 
            // lblTicket
            // 
            this.lblTicket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTicket.Location = new System.Drawing.Point(76, 20);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.ReadOnly = true;
            this.lblTicket.Size = new System.Drawing.Size(161, 20);
            this.lblTicket.TabIndex = 19;
            this.lblTicket.WordWrap = false;
            this.lblTicket.TextChanged += new System.EventHandler(this.lblTicket_TextChanged);
            // 
            // txtRespuestaTicket
            // 
            this.txtRespuestaTicket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRespuestaTicket.Location = new System.Drawing.Point(52, 48);
            this.txtRespuestaTicket.Name = "txtRespuestaTicket";
            this.txtRespuestaTicket.ReadOnly = true;
            this.txtRespuestaTicket.Size = new System.Drawing.Size(811, 73);
            this.txtRespuestaTicket.TabIndex = 18;
            this.txtRespuestaTicket.Text = "";
            this.txtRespuestaTicket.WordWrap = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackgroundImage = global::ConsumoWsOffline.Properties.Resources.Enviar2;
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerar.Location = new System.Drawing.Point(13, 48);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(33, 33);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lblCodRpta);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblRespuestaIntegracion);
            this.groupBox4.Controls.Add(this.btnObtener);
            this.groupBox4.Location = new System.Drawing.Point(12, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(874, 125);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Respuesta Integración";
            // 
            // lblCodRpta
            // 
            this.lblCodRpta.AutoSize = true;
            this.lblCodRpta.Location = new System.Drawing.Point(56, 19);
            this.lblCodRpta.Name = "lblCodRpta";
            this.lblCodRpta.Size = new System.Drawing.Size(0, 13);
            this.lblCodRpta.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Respuesta (Codigo):";
            // 
            // lblRespuestaIntegracion
            // 
            this.lblRespuestaIntegracion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRespuestaIntegracion.Location = new System.Drawing.Point(52, 45);
            this.lblRespuestaIntegracion.Name = "lblRespuestaIntegracion";
            this.lblRespuestaIntegracion.ReadOnly = true;
            this.lblRespuestaIntegracion.Size = new System.Drawing.Size(811, 70);
            this.lblRespuestaIntegracion.TabIndex = 19;
            this.lblRespuestaIntegracion.Text = "";
            this.lblRespuestaIntegracion.WordWrap = false;
            // 
            // btnObtener
            // 
            this.btnObtener.BackgroundImage = global::ConsumoWsOffline.Properties.Resources.Descargar;
            this.btnObtener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObtener.Location = new System.Drawing.Point(13, 45);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(33, 33);
            this.btnObtener.TabIndex = 9;
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(925, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::ConsumoWsOffline.Properties.Resources.Salir;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(844, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 33);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.BackgroundImage = global::ConsumoWsOffline.Properties.Resources.Limpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Location = new System.Drawing.Point(23, 533);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(35, 33);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::ConsumoWsOffline.Properties.Resources.GreenImageDots;
            this.pictureBox2.Location = new System.Drawing.Point(136, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(759, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ConsumoWsOffline.Properties.Resources.Logo_PSeN;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipo de comprobante:";
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoComprobante.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTipoComprobante.Location = new System.Drawing.Point(127, 68);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(104, 13);
            this.lblTipoComprobante.TabIndex = 24;
            this.lblTipoComprobante.Text = "No Seleccionado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(895, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesar y obtener comprobantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnObtener;
		private System.Windows.Forms.TextBox txtOpcional;
		private System.Windows.Forms.TextBox txtArchivo;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnUbicacion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnOpcional;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.RichTextBox lblRespuestaIntegracion;
		private System.Windows.Forms.RichTextBox txtRespuestaTicket;
		private System.Windows.Forms.Label lblCodRpta;
		private System.Windows.Forms.TextBox lblTicket;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnPath;
		private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ToolComentarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipoComprobante;
	}
}

