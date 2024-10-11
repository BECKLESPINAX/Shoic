/*
 * Creado por SharpDevelop.
 * Usuario: BlackCrystal™
 * Fecha: 24/04/2012
 * Hora: 08:59 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SHOIC
{
	partial class WindowSHOIC
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowSHOIC));
			this.PictureBoxAnonymous = new System.Windows.Forms.PictureBox();
			this.ButtonAttack = new System.Windows.Forms.Button();
			this.BotonPausa = new System.Windows.Forms.Button();
			this.BotonStop = new System.Windows.Forms.Button();
			this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
			this.BotonPlay = new System.Windows.Forms.Button();
			this.TextBoxTarget = new System.Windows.Forms.TextBox();
			this.txtTargetIP = new System.Windows.Forms.TextBox();
			this.ButtonRestart = new System.Windows.Forms.Button();
			this.ComboTargetURL = new System.Windows.Forms.ComboBox();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.ButtonAnonymousSantaFe = new System.Windows.Forms.Button();
			this.NumericProcess = new System.Windows.Forms.NumericUpDown();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tShowStats = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.ButtonTargetIP = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonTargetURL = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.ButtonHelp = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ButtonConfiguration = new System.Windows.Forms.Button();
			this.ButtonAddProcess = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.ButtonDeath = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LabelAttackStateInsert = new System.Windows.Forms.Label();
			this.LabelAttackState = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxAnonymous)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericProcess)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PictureBoxAnonymous
			// 
			this.PictureBoxAnonymous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxAnonymous.BackgroundImage")));
			this.PictureBoxAnonymous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PictureBoxAnonymous.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PictureBoxAnonymous.Location = new System.Drawing.Point(619, 28);
			this.PictureBoxAnonymous.Name = "PictureBoxAnonymous";
			this.PictureBoxAnonymous.Size = new System.Drawing.Size(169, 128);
			this.PictureBoxAnonymous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBoxAnonymous.TabIndex = 29;
			this.PictureBoxAnonymous.TabStop = false;
			// 
			// ButtonAttack
			// 
			this.ButtonAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.ButtonAttack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonAttack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAttack.ForeColor = System.Drawing.Color.Azure;
			this.ButtonAttack.Location = new System.Drawing.Point(9, 17);
			this.ButtonAttack.Name = "ButtonAttack";
			this.ButtonAttack.Size = new System.Drawing.Size(219, 56);
			this.ButtonAttack.TabIndex = 1;
			this.ButtonAttack.Text = "COMENZAR ATAQUE!";
			this.ButtonAttack.UseVisualStyleBackColor = false;
			this.ButtonAttack.Click += new System.EventHandler(this.ClickAttack);
			// 
			// BotonPausa
			// 
			this.BotonPausa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BotonPausa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonPausa.Image = ((System.Drawing.Image)(resources.GetObject("BotonPausa.Image")));
			this.BotonPausa.Location = new System.Drawing.Point(374, 330);
			this.BotonPausa.Name = "BotonPausa";
			this.BotonPausa.Size = new System.Drawing.Size(24, 30);
			this.BotonPausa.TabIndex = 28;
			this.ToolTips.SetToolTip(this.BotonPausa, "Pausar Marcha de Unión.");
			this.BotonPausa.UseVisualStyleBackColor = true;
			this.BotonPausa.Click += new System.EventHandler(this.ClickPausa);
			// 
			// BotonStop
			// 
			this.BotonStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BotonStop.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonStop.Image = ((System.Drawing.Image)(resources.GetObject("BotonStop.Image")));
			this.BotonStop.Location = new System.Drawing.Point(404, 330);
			this.BotonStop.Name = "BotonStop";
			this.BotonStop.Size = new System.Drawing.Size(24, 30);
			this.BotonStop.TabIndex = 27;
			this.ToolTips.SetToolTip(this.BotonStop, "Detener Marcha de Unión.");
			this.BotonStop.UseVisualStyleBackColor = true;
			this.BotonStop.Click += new System.EventHandler(this.ClickStop);
			// 
			// ToolTips
			// 
			this.ToolTips.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.ToolTips.IsBalloon = true;
			// 
			// BotonPlay
			// 
			this.BotonPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BotonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonPlay.Image = ((System.Drawing.Image)(resources.GetObject("BotonPlay.Image")));
			this.BotonPlay.Location = new System.Drawing.Point(345, 330);
			this.BotonPlay.Name = "BotonPlay";
			this.BotonPlay.Size = new System.Drawing.Size(23, 30);
			this.BotonPlay.TabIndex = 26;
			this.ToolTips.SetToolTip(this.BotonPlay, "Iniciar Marcha de Unión.");
			this.BotonPlay.UseVisualStyleBackColor = true;
			this.BotonPlay.Click += new System.EventHandler(this.ClickPlay);
			// 
			// TextBoxTarget
			// 
			this.TextBoxTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.TextBoxTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxTarget.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxTarget.ForeColor = System.Drawing.Color.Azure;
			this.TextBoxTarget.Location = new System.Drawing.Point(6, 14);
			this.TextBoxTarget.Name = "TextBoxTarget";
			this.TextBoxTarget.Size = new System.Drawing.Size(523, 63);
			this.TextBoxTarget.TabIndex = 1;
			this.TextBoxTarget.TabStop = false;
			this.TextBoxTarget.Text = "Ninguno!";
			this.TextBoxTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ToolTips.SetToolTip(this.TextBoxTarget, "Objetivo Seleccionado.");
			// 
			// txtTargetIP
			// 
			this.txtTargetIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTargetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtTargetIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTargetIP.ForeColor = System.Drawing.Color.Azure;
			this.txtTargetIP.Location = new System.Drawing.Point(45, 32);
			this.txtTargetIP.Name = "txtTargetIP";
			this.txtTargetIP.Size = new System.Drawing.Size(198, 20);
			this.txtTargetIP.TabIndex = 3;
			this.ToolTips.SetToolTip(this.txtTargetIP, "Si sabes la IP del sitio que deseas atacar, introdúcela, presiona \"Seleccionar\" o" +
        " la tecla \"Enter\".");
			this.txtTargetIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PresionarEnterIP);
			// 
			// ButtonRestart
			// 
			this.ButtonRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.ButtonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonRestart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonRestart.ForeColor = System.Drawing.Color.Azure;
			this.ButtonRestart.Location = new System.Drawing.Point(9, 176);
			this.ButtonRestart.Name = "ButtonRestart";
			this.ButtonRestart.Size = new System.Drawing.Size(78, 56);
			this.ButtonRestart.TabIndex = 33;
			this.ButtonRestart.Text = "Reiniciar";
			this.ToolTips.SetToolTip(this.ButtonRestart, resources.GetString("ButtonRestart.ToolTip"));
			this.ButtonRestart.UseVisualStyleBackColor = false;
			this.ButtonRestart.Click += new System.EventHandler(this.ClickRestart);
			// 
			// ComboTargetURL
			// 
			this.ComboTargetURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.ComboTargetURL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ComboTargetURL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboTargetURL.ForeColor = System.Drawing.Color.Azure;
			this.ComboTargetURL.FormattingEnabled = true;
			this.ComboTargetURL.Location = new System.Drawing.Point(45, 3);
			this.ComboTargetURL.Name = "ComboTargetURL";
			this.ComboTargetURL.Size = new System.Drawing.Size(198, 22);
			this.ComboTargetURL.TabIndex = 35;
			this.ToolTips.SetToolTip(this.ComboTargetURL, "Objetivo del ataque:\r\nAquí debes colocar la dirección de la página web que desea " +
        "atacar.\r\nLuego se presiona \"enter\" o se hace click en el botón \"Seleccionar\".");
			this.ComboTargetURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PresionarEnter);
			// 
			// ButtonExit
			// 
			this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonExit.ForeColor = System.Drawing.Color.White;
			this.ButtonExit.Location = new System.Drawing.Point(692, 331);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(75, 30);
			this.ButtonExit.TabIndex = 25;
			this.ButtonExit.Text = "Salir";
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ClickExit);
			// 
			// ButtonAnonymousSantaFe
			// 
			this.ButtonAnonymousSantaFe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonAnonymousSantaFe.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonAnonymousSantaFe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonAnonymousSantaFe.ForeColor = System.Drawing.Color.White;
			this.ButtonAnonymousSantaFe.Location = new System.Drawing.Point(599, 331);
			this.ButtonAnonymousSantaFe.Name = "ButtonAnonymousSantaFe";
			this.ButtonAnonymousSantaFe.Size = new System.Drawing.Size(87, 30);
			this.ButtonAnonymousSantaFe.TabIndex = 24;
			this.ButtonAnonymousSantaFe.Text = "Anonymous";
			this.ButtonAnonymousSantaFe.UseVisualStyleBackColor = true;
			this.ButtonAnonymousSantaFe.Click += new System.EventHandler(this.ClickAnonymous);
			// 
			// NumericProcess
			// 
			this.NumericProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.NumericProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.NumericProcess.ForeColor = System.Drawing.Color.Azure;
			this.NumericProcess.Location = new System.Drawing.Point(161, 338);
			this.NumericProcess.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.NumericProcess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericProcess.Name = "NumericProcess";
			this.NumericProcess.Size = new System.Drawing.Size(67, 20);
			this.NumericProcess.TabIndex = 32;
			this.NumericProcess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.ButtonAttack);
			this.groupBox4.ForeColor = System.Drawing.Color.LightBlue;
			this.groupBox4.Location = new System.Drawing.Point(375, 38);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(238, 82);
			this.groupBox4.TabIndex = 19;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "3. Listo?";
			// 
			// tShowStats
			// 
			this.tShowStats.Interval = 10;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(3, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 30);
			this.label2.TabIndex = 5;
			this.label2.Text = "IP";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ButtonTargetIP
			// 
			this.ButtonTargetIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonTargetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.ButtonTargetIP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonTargetIP.ForeColor = System.Drawing.Color.Azure;
			this.ButtonTargetIP.Location = new System.Drawing.Point(249, 32);
			this.ButtonTargetIP.Name = "ButtonTargetIP";
			this.ButtonTargetIP.Size = new System.Drawing.Size(89, 24);
			this.ButtonTargetIP.TabIndex = 4;
			this.ButtonTargetIP.Text = "Seleccionar";
			this.ButtonTargetIP.UseVisualStyleBackColor = false;
			this.ButtonTargetIP.Click += new System.EventHandler(this.cmdTargetIP_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "URL";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ButtonTargetURL
			// 
			this.ButtonTargetURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonTargetURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.ButtonTargetURL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonTargetURL.ForeColor = System.Drawing.Color.Azure;
			this.ButtonTargetURL.Location = new System.Drawing.Point(249, 3);
			this.ButtonTargetURL.Name = "ButtonTargetURL";
			this.ButtonTargetURL.Size = new System.Drawing.Size(89, 23);
			this.ButtonTargetURL.TabIndex = 2;
			this.ButtonTargetURL.Text = "Seleccionar";
			this.ButtonTargetURL.UseVisualStyleBackColor = false;
			this.ButtonTargetURL.Click += new System.EventHandler(this.cmdTargetURL_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.TextBoxTarget);
			this.groupBox2.ForeColor = System.Drawing.Color.LightBlue;
			this.groupBox2.Location = new System.Drawing.Point(97, 162);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(535, 85);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Objetivo seleccionado";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel2);
			this.groupBox1.ForeColor = System.Drawing.Color.LightBlue;
			this.groupBox1.Location = new System.Drawing.Point(9, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(353, 82);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "1. Seleccione su objetivo";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.31672F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.82405F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63158F));
			this.tableLayoutPanel2.Controls.Add(this.ComboTargetURL, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.ButtonTargetIP, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.txtTargetIP, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.ButtonTargetURL, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 17);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 59);
			this.tableLayoutPanel2.TabIndex = 6;
			// 
			// ButtonHelp
			// 
			this.ButtonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonHelp.ForeColor = System.Drawing.Color.White;
			this.ButtonHelp.Location = new System.Drawing.Point(505, 331);
			this.ButtonHelp.Name = "ButtonHelp";
			this.ButtonHelp.Size = new System.Drawing.Size(88, 30);
			this.ButtonHelp.TabIndex = 30;
			this.ButtonHelp.Text = "Ayuda";
			this.ButtonHelp.UseVisualStyleBackColor = true;
			this.ButtonHelp.Click += new System.EventHandler(this.ClickHelp);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(7, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 23);
			this.label3.TabIndex = 31;
			this.label3.Text = "SHOIC";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.LightBlue;
			this.label5.Location = new System.Drawing.Point(94, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(334, 27);
			this.label5.TabIndex = 32;
			this.label5.Text = "Super High Orbit Ion Canion";
			// 
			// ButtonConfiguration
			// 
			this.ButtonConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonConfiguration.ForeColor = System.Drawing.Color.White;
			this.ButtonConfiguration.Location = new System.Drawing.Point(12, 331);
			this.ButtonConfiguration.Name = "ButtonConfiguration";
			this.ButtonConfiguration.Size = new System.Drawing.Size(88, 30);
			this.ButtonConfiguration.TabIndex = 34;
			this.ButtonConfiguration.Text = "Configuración";
			this.ButtonConfiguration.UseVisualStyleBackColor = true;
			this.ButtonConfiguration.Click += new System.EventHandler(this.ClickConfiguration);
			// 
			// ButtonAddProcess
			// 
			this.ButtonAddProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonAddProcess.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonAddProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonAddProcess.ForeColor = System.Drawing.Color.White;
			this.ButtonAddProcess.Location = new System.Drawing.Point(234, 318);
			this.ButtonAddProcess.Name = "ButtonAddProcess";
			this.ButtonAddProcess.Size = new System.Drawing.Size(74, 43);
			this.ButtonAddProcess.TabIndex = 35;
			this.ButtonAddProcess.Text = "Crear Procesos";
			this.ButtonAddProcess.UseVisualStyleBackColor = true;
			this.ButtonAddProcess.Click += new System.EventHandler(this.ClickAddProcess);
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.LightBlue;
			this.label8.Location = new System.Drawing.Point(162, 320);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 36;
			this.label8.Text = "Procesos";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// ButtonDeath
			// 
			this.ButtonDeath.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonDeath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDeath.ForeColor = System.Drawing.Color.White;
			this.ButtonDeath.Location = new System.Drawing.Point(653, 176);
			this.ButtonDeath.Name = "ButtonDeath";
			this.ButtonDeath.Size = new System.Drawing.Size(104, 70);
			this.ButtonDeath.TabIndex = 37;
			this.ButtonDeath.Text = "Comprobar \r\nMuerte";
			this.ButtonDeath.UseVisualStyleBackColor = true;
			this.ButtonDeath.Click += new System.EventHandler(this.ClickDeath);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.61877F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.38123F));
			this.tableLayoutPanel1.Controls.Add(this.LabelAttackStateInsert, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.LabelAttackState, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(87, 253);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 47);
			this.tableLayoutPanel1.TabIndex = 38;
			// 
			// LabelAttackStateInsert
			// 
			this.LabelAttackStateInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelAttackStateInsert.ForeColor = System.Drawing.Color.White;
			this.LabelAttackStateInsert.Location = new System.Drawing.Point(133, 0);
			this.LabelAttackStateInsert.Name = "LabelAttackStateInsert";
			this.LabelAttackStateInsert.Size = new System.Drawing.Size(305, 47);
			this.LabelAttackStateInsert.TabIndex = 3;
			this.LabelAttackStateInsert.Text = "Ataque masivo...";
			this.LabelAttackStateInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelAttackState
			// 
			this.LabelAttackState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelAttackState.ForeColor = System.Drawing.Color.White;
			this.LabelAttackState.Location = new System.Drawing.Point(3, 0);
			this.LabelAttackState.Name = "LabelAttackState";
			this.LabelAttackState.Size = new System.Drawing.Size(124, 47);
			this.LabelAttackState.TabIndex = 2;
			this.LabelAttackState.Text = "Estado del Ataque:";
			this.LabelAttackState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Orange;
			this.label4.Location = new System.Drawing.Point(623, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 25);
			this.label4.TabIndex = 39;
			this.label4.Text = "Becklespinax";
			// 
			// WindowSHOIC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(786, 373);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.ButtonDeath);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.ButtonAddProcess);
			this.Controls.Add(this.NumericProcess);
			this.Controls.Add(this.ButtonConfiguration);
			this.Controls.Add(this.ButtonRestart);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ButtonHelp);
			this.Controls.Add(this.PictureBoxAnonymous);
			this.Controls.Add(this.BotonPausa);
			this.Controls.Add(this.BotonStop);
			this.Controls.Add(this.BotonPlay);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.ButtonAnonymousSantaFe);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WindowSHOIC";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.WindowSHOICLoad);
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxAnonymous)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericProcess)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button ButtonDeath;
		private System.Windows.Forms.Button ButtonAddProcess;
		private System.Windows.Forms.ComboBox ComboTargetURL;
		private System.Windows.Forms.Button ButtonConfiguration;
		private System.Windows.Forms.Button ButtonRestart;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown NumericProcess;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ButtonHelp;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button ButtonTargetURL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ButtonTargetIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer tShowStats;
		private System.Windows.Forms.TextBox txtTargetIP;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button ButtonAnonymousSantaFe;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.TextBox TextBoxTarget;
		private System.Windows.Forms.Button BotonPlay;
		private System.Windows.Forms.Button BotonStop;
		private System.Windows.Forms.ToolTip ToolTips;
		private System.Windows.Forms.Button BotonPausa;
		private System.Windows.Forms.Button ButtonAttack;
		private System.Windows.Forms.PictureBox PictureBoxAnonymous;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label LabelAttackStateInsert;
		private System.Windows.Forms.Label LabelAttackState;
		private System.Windows.Forms.Label label4;
	}
}
