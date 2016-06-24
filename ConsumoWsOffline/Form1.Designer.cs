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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtOpcional = new System.Windows.Forms.TextBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnObtener = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpcional = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTicket = new System.Windows.Forms.TextBox();
            this.txtRespuestaTicket = new System.Windows.Forms.RichTextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCodRpta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRespuestaIntegracion = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(704, 202);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(205, 29);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "1) Enviar (Obtener Ticket)";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruc y contraseña";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(254, 19);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(96, 20);
            this.txtClave.TabIndex = 11;
            this.txtClave.Text = "20100011884";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CLAVE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "RUC:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(58, 19);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(96, 20);
            this.txtRuc.TabIndex = 4;
            this.txtRuc.Text = "20100011884";
            // 
            // txtOpcional
            // 
            this.txtOpcional.Location = new System.Drawing.Point(140, 43);
            this.txtOpcional.Name = "txtOpcional";
            this.txtOpcional.Size = new System.Drawing.Size(655, 20);
            this.txtOpcional.TabIndex = 15;
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(140, 19);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(655, 20);
            this.txtArchivo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 46);
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
            // btnUbicacion
            // 
            this.btnUbicacion.Location = new System.Drawing.Point(801, 19);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(95, 23);
            this.btnUbicacion.TabIndex = 5;
            this.btnUbicacion.Text = "Elegir Archivo";
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(703, 385);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(205, 29);
            this.btnObtener.TabIndex = 9;
            this.btnObtener.Text = "2) Obtener Resultado";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nro. Ticket:";
            // 
            // btnOpcional
            // 
            this.btnOpcional.Location = new System.Drawing.Point(801, 43);
            this.btnOpcional.Name = "btnOpcional";
            this.btnOpcional.Size = new System.Drawing.Size(95, 23);
            this.btnOpcional.TabIndex = 18;
            this.btnOpcional.Text = "Elegir Archivo";
            this.btnOpcional.UseVisualStyleBackColor = true;
            this.btnOpcional.Click += new System.EventHandler(this.btnOpcional_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUbicacion);
            this.groupBox2.Controls.Add(this.btnPath);
            this.groupBox2.Controls.Add(this.btnOpcional);
            this.groupBox2.Controls.Add(this.btnUbicacion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtArchivo);
            this.groupBox2.Controls.Add(this.txtOpcional);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 125);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archivos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ubicación para almacenar el Archivo de integración: ";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(140, 91);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(655, 20);
            this.txtUbicacion.TabIndex = 22;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(801, 91);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(95, 23);
            this.btnPath.TabIndex = 19;
            this.btnPath.Text = "Elegir ubicacion";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTicket);
            this.groupBox3.Controls.Add(this.txtRespuestaTicket);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(908, 131);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Respuesta Ticket";
            // 
            // lblTicket
            // 
            this.lblTicket.Location = new System.Drawing.Point(76, 19);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(161, 20);
            this.lblTicket.TabIndex = 19;
            this.lblTicket.WordWrap = false;
            this.lblTicket.TextChanged += new System.EventHandler(this.lblTicket_TextChanged);
            // 
            // txtRespuestaTicket
            // 
            this.txtRespuestaTicket.Location = new System.Drawing.Point(6, 56);
            this.txtRespuestaTicket.Name = "txtRespuestaTicket";
            this.txtRespuestaTicket.Size = new System.Drawing.Size(890, 67);
            this.txtRespuestaTicket.TabIndex = 18;
            this.txtRespuestaTicket.Text = "";
            this.txtRespuestaTicket.WordWrap = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCodRpta);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblRespuestaIntegracion);
            this.groupBox4.Location = new System.Drawing.Point(12, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(908, 136);
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
            this.label6.Location = new System.Drawing.Point(7, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Respuesta (Codigo):";
            // 
            // lblRespuestaIntegracion
            // 
            this.lblRespuestaIntegracion.Location = new System.Drawing.Point(6, 35);
            this.lblRespuestaIntegracion.Name = "lblRespuestaIntegracion";
            this.lblRespuestaIntegracion.Size = new System.Drawing.Size(890, 95);
            this.lblRespuestaIntegracion.TabIndex = 19;
            this.lblRespuestaIntegracion.Text = "";
            this.lblRespuestaIntegracion.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 583);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnObtener);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesar y obtener comprobantes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGenerar;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnObtener;
		private System.Windows.Forms.TextBox txtRuc;
		private System.Windows.Forms.TextBox txtOpcional;
		private System.Windows.Forms.TextBox txtArchivo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
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
	}
}

