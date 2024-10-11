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
	partial class WindowFirst
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowFirst));
			this.lbFailed = new System.Windows.Forms.Label();
			this.lbRequested = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.lbDownloaded = new System.Windows.Forms.Label();
			this.lbDownloading = new System.Windows.Forms.Label();
			this.lbRequesting = new System.Windows.Forms.Label();
			this.lbConnecting = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbIdle = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.GroupBoxAttackState = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.ButtonAttack = new System.Windows.Forms.Button();
			this.BotonPausa = new System.Windows.Forms.Button();
			this.BotonStop = new System.Windows.Forms.Button();
			this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
			this.BotonPlay = new System.Windows.Forms.Button();
			this.txtSubsite = new System.Windows.Forms.TextBox();
			this.txtTimeout = new System.Windows.Forms.TextBox();
			this.txtTarget = new System.Windows.Forms.TextBox();
			this.txtTargetIP = new System.Windows.Forms.TextBox();
			this.tbSpeed = new System.Windows.Forms.TrackBar();
			this.ButtonRestart = new System.Windows.Forms.Button();
			this.ComboTargetURL = new System.Windows.Forms.ComboBox();
			this.chkResp = new System.Windows.Forms.CheckBox();
			this.cbMethod = new System.Windows.Forms.ComboBox();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.ButtonAnonymousSantaFe = new System.Windows.Forms.Button();
			this.GroupBoxAttackOption = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label9 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtData = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.NumericUpDownPort = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.NumericUpDownThreads = new System.Windows.Forms.NumericUpDown();
			this.label20 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
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
			this.GroupAttackMethod = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.GroupBoxAttackState.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
			this.GroupBoxAttackOption.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownThreads)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericProcess)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.GroupAttackMethod.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbFailed
			// 
			this.lbFailed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbFailed.Location = new System.Drawing.Point(619, 24);
			this.lbFailed.Name = "lbFailed";
			this.lbFailed.Size = new System.Drawing.Size(104, 16);
			this.lbFailed.TabIndex = 24;
			this.lbFailed.Text = "-----";
			this.lbFailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbRequested
			// 
			this.lbRequested.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbRequested.Location = new System.Drawing.Point(521, 24);
			this.lbRequested.Name = "lbRequested";
			this.lbRequested.Size = new System.Drawing.Size(89, 16);
			this.lbRequested.TabIndex = 23;
			this.lbRequested.Text = "-----";
			this.lbRequested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label22
			// 
			this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label22.Location = new System.Drawing.Point(619, 3);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(104, 18);
			this.label22.TabIndex = 22;
			this.label22.Text = "Fallas";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label23.Location = new System.Drawing.Point(521, 3);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(89, 18);
			this.label23.TabIndex = 21;
			this.label23.Text = "Solicitados";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbDownloaded
			// 
			this.lbDownloaded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbDownloaded.Location = new System.Drawing.Point(418, 24);
			this.lbDownloaded.Name = "lbDownloaded";
			this.lbDownloaded.Size = new System.Drawing.Size(94, 16);
			this.lbDownloaded.TabIndex = 20;
			this.lbDownloaded.Text = "-----";
			this.lbDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbDownloading
			// 
			this.lbDownloading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbDownloading.BackColor = System.Drawing.Color.Transparent;
			this.lbDownloading.Location = new System.Drawing.Point(315, 24);
			this.lbDownloading.Name = "lbDownloading";
			this.lbDownloading.Size = new System.Drawing.Size(94, 16);
			this.lbDownloading.TabIndex = 19;
			this.lbDownloading.Text = "-----";
			this.lbDownloading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbRequesting
			// 
			this.lbRequesting.Location = new System.Drawing.Point(212, 24);
			this.lbRequesting.Name = "lbRequesting";
			this.lbRequesting.Size = new System.Drawing.Size(94, 16);
			this.lbRequesting.TabIndex = 18;
			this.lbRequesting.Text = "-----";
			this.lbRequesting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbConnecting
			// 
			this.lbConnecting.Location = new System.Drawing.Point(109, 24);
			this.lbConnecting.Name = "lbConnecting";
			this.lbConnecting.Size = new System.Drawing.Size(94, 16);
			this.lbConnecting.TabIndex = 17;
			this.lbConnecting.Text = "-----";
			this.lbConnecting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Location = new System.Drawing.Point(619, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(169, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			// 
			// lbIdle
			// 
			this.lbIdle.Location = new System.Drawing.Point(6, 24);
			this.lbIdle.Name = "lbIdle";
			this.lbIdle.Size = new System.Drawing.Size(94, 16);
			this.lbIdle.TabIndex = 16;
			this.lbIdle.Text = "-----";
			this.lbIdle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.Location = new System.Drawing.Point(418, 3);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(94, 18);
			this.label12.TabIndex = 15;
			this.label12.Text = "Descargados";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GroupBoxAttackState
			// 
			this.GroupBoxAttackState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.GroupBoxAttackState.Controls.Add(this.tableLayoutPanel1);
			this.GroupBoxAttackState.ForeColor = System.Drawing.Color.LightBlue;
			this.GroupBoxAttackState.Location = new System.Drawing.Point(9, 345);
			this.GroupBoxAttackState.Name = "GroupBoxAttackState";
			this.GroupBoxAttackState.Size = new System.Drawing.Size(758, 71);
			this.GroupBoxAttackState.TabIndex = 22;
			this.GroupBoxAttackState.TabStop = false;
			this.GroupBoxAttackState.Text = "Estado de Ataque";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanel1.ColumnCount = 7;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.58025F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.08916F));
			this.tableLayoutPanel1.Controls.Add(this.lbFailed, 6, 1);
			this.tableLayoutPanel1.Controls.Add(this.label16, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label22, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbRequested, 5, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbIdle, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label15, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label23, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbConnecting, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbDownloaded, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.label14, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label12, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbDownloading, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbRequesting, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label13, 3, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 18);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 43);
			this.tableLayoutPanel1.TabIndex = 30;
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.Location = new System.Drawing.Point(6, 3);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(94, 18);
			this.label16.TabIndex = 11;
			this.label16.Text = "Estado";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.Location = new System.Drawing.Point(109, 3);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(94, 18);
			this.label15.TabIndex = 12;
			this.label15.Text = "Conexiones";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.Location = new System.Drawing.Point(212, 3);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(94, 18);
			this.label14.TabIndex = 13;
			this.label14.Text = "Solicitando";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.Location = new System.Drawing.Point(315, 3);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 18);
			this.label13.TabIndex = 14;
			this.label13.Text = "Descargando";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.BotonPausa.Location = new System.Drawing.Point(374, 446);
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
			this.BotonStop.Location = new System.Drawing.Point(404, 446);
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
			this.BotonPlay.Location = new System.Drawing.Point(345, 446);
			this.BotonPlay.Name = "BotonPlay";
			this.BotonPlay.Size = new System.Drawing.Size(23, 30);
			this.BotonPlay.TabIndex = 26;
			this.ToolTips.SetToolTip(this.BotonPlay, "Iniciar Marcha de Unión.");
			this.BotonPlay.UseVisualStyleBackColor = true;
			this.BotonPlay.Click += new System.EventHandler(this.ClickPlay);
			// 
			// txtSubsite
			// 
			this.txtSubsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtSubsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSubsite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubsite.ForeColor = System.Drawing.Color.Azure;
			this.txtSubsite.Location = new System.Drawing.Point(59, 19);
			this.txtSubsite.Name = "txtSubsite";
			this.txtSubsite.Size = new System.Drawing.Size(291, 20);
			this.txtSubsite.TabIndex = 2;
			this.txtSubsite.Text = "/";
			this.txtSubsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ToolTips.SetToolTip(this.txtSubsite, "Sub-Sitio en ataque HTTP.");
			// 
			// txtTimeout
			// 
			this.txtTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtTimeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTimeout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimeout.ForeColor = System.Drawing.Color.Azure;
			this.txtTimeout.Location = new System.Drawing.Point(3, 19);
			this.txtTimeout.Name = "txtTimeout";
			this.txtTimeout.Size = new System.Drawing.Size(50, 20);
			this.txtTimeout.TabIndex = 1;
			this.txtTimeout.Text = "9001";
			this.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ToolTips.SetToolTip(this.txtTimeout, "Tiempo Máximo para esperar respuesta.");
			// 
			// txtTarget
			// 
			this.txtTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTarget.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTarget.ForeColor = System.Drawing.Color.Azure;
			this.txtTarget.Location = new System.Drawing.Point(33, 14);
			this.txtTarget.Name = "txtTarget";
			this.txtTarget.Size = new System.Drawing.Size(473, 63);
			this.txtTarget.TabIndex = 1;
			this.txtTarget.TabStop = false;
			this.txtTarget.Text = "Ninguno!";
			this.txtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ToolTips.SetToolTip(this.txtTarget, "Objetivo Seleccionado.");
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
			// tbSpeed
			// 
			this.tbSpeed.Location = new System.Drawing.Point(405, 74);
			this.tbSpeed.Maximum = 20;
			this.tbSpeed.Name = "tbSpeed";
			this.tbSpeed.Size = new System.Drawing.Size(308, 45);
			this.tbSpeed.TabIndex = 8;
			this.ToolTips.SetToolTip(this.tbSpeed, "Velocidad del Cañón");
			this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
			// 
			// ButtonRestart
			// 
			this.ButtonRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.ButtonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonRestart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonRestart.ForeColor = System.Drawing.Color.Azure;
			this.ButtonRestart.Location = new System.Drawing.Point(12, 269);
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
			// chkResp
			// 
			this.chkResp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chkResp.AutoSize = true;
			this.chkResp.Checked = true;
			this.chkResp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkResp.Location = new System.Drawing.Point(276, 24);
			this.chkResp.Name = "chkResp";
			this.chkResp.Size = new System.Drawing.Size(88, 23);
			this.chkResp.TabIndex = 7;
			this.chkResp.Text = "Esperar respuesta";
			this.ToolTips.SetToolTip(this.chkResp, "No desconecte antes de que el servidor ha empezado a responder.");
			this.chkResp.UseVisualStyleBackColor = true;
			// 
			// cbMethod
			// 
			this.cbMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbMethod.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMethod.ForeColor = System.Drawing.Color.Azure;
			this.cbMethod.FormattingEnabled = true;
			this.cbMethod.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "HTTP",
            "HTTP SHOIC",
            "PING SHOIC"});
			this.cbMethod.Location = new System.Drawing.Point(3, 17);
			this.cbMethod.Name = "cbMethod";
			this.cbMethod.Size = new System.Drawing.Size(194, 22);
			this.cbMethod.TabIndex = 5;
			this.ToolTips.SetToolTip(this.cbMethod, "Tipo de ataque a utilizar.");
			this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.SeleccionarMétodo);
			// 
			// ButtonExit
			// 
			this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonExit.ForeColor = System.Drawing.Color.White;
			this.ButtonExit.Location = new System.Drawing.Point(692, 447);
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
			this.ButtonAnonymousSantaFe.Location = new System.Drawing.Point(599, 447);
			this.ButtonAnonymousSantaFe.Name = "ButtonAnonymousSantaFe";
			this.ButtonAnonymousSantaFe.Size = new System.Drawing.Size(87, 30);
			this.ButtonAnonymousSantaFe.TabIndex = 24;
			this.ButtonAnonymousSantaFe.Text = "Anonymous";
			this.ButtonAnonymousSantaFe.UseVisualStyleBackColor = true;
			this.ButtonAnonymousSantaFe.Click += new System.EventHandler(this.ClickAnonymous);
			// 
			// GroupBoxAttackOption
			// 
			this.GroupBoxAttackOption.Controls.Add(this.tableLayoutPanel4);
			this.GroupBoxAttackOption.Controls.Add(this.tableLayoutPanel3);
			this.GroupBoxAttackOption.Controls.Add(this.label20);
			this.GroupBoxAttackOption.Controls.Add(this.tbSpeed);
			this.GroupBoxAttackOption.ForeColor = System.Drawing.Color.LightBlue;
			this.GroupBoxAttackOption.Location = new System.Drawing.Point(9, 126);
			this.GroupBoxAttackOption.Name = "GroupBoxAttackOption";
			this.GroupBoxAttackOption.Size = new System.Drawing.Size(758, 124);
			this.GroupBoxAttackOption.TabIndex = 21;
			this.GroupBoxAttackOption.TabStop = false;
			this.GroupBoxAttackOption.Text = "2. Opciones de ataque";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.734057F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.1981F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.20353F));
			this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.label18, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.txtTimeout, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.label17, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.txtData, 2, 1);
			this.tableLayoutPanel4.Controls.Add(this.txtSubsite, 1, 1);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 16);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.55914F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.44086F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(737, 44);
			this.tableLayoutPanel4.TabIndex = 30;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(3, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Timeout";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(369, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(365, 16);
			this.label18.TabIndex = 25;
			this.label18.Text = "TCP / UDP mensaje";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(59, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(291, 13);
			this.label17.TabIndex = 24;
			this.label17.Text = "HTTP Subsite";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtData
			// 
			this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtData.ForeColor = System.Drawing.Color.Azure;
			this.txtData.Location = new System.Drawing.Point(369, 19);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(365, 20);
			this.txtData.TabIndex = 3;
			this.txtData.Text = "Unión es grande";
			this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.Controls.Add(this.NumericUpDownPort, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.NumericUpDownThreads, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.chkResp, 3, 1);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 66);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.10345F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.89655F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(367, 50);
			this.tableLayoutPanel3.TabIndex = 30;
			// 
			// NumericUpDownPort
			// 
			this.NumericUpDownPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NumericUpDownPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.NumericUpDownPort.ForeColor = System.Drawing.Color.Azure;
			this.NumericUpDownPort.Location = new System.Drawing.Point(3, 24);
			this.NumericUpDownPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.NumericUpDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownPort.Name = "NumericUpDownPort";
			this.NumericUpDownPort.Size = new System.Drawing.Size(85, 20);
			this.NumericUpDownPort.TabIndex = 32;
			this.NumericUpDownPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 21);
			this.label6.TabIndex = 20;
			this.label6.Text = "Puerto";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Location = new System.Drawing.Point(185, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 21);
			this.label7.TabIndex = 22;
			this.label7.Text = "Hilos";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// NumericUpDownThreads
			// 
			this.NumericUpDownThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NumericUpDownThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.NumericUpDownThreads.ForeColor = System.Drawing.Color.Azure;
			this.NumericUpDownThreads.Location = new System.Drawing.Point(185, 24);
			this.NumericUpDownThreads.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.NumericUpDownThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownThreads.Name = "NumericUpDownThreads";
			this.NumericUpDownThreads.Size = new System.Drawing.Size(85, 20);
			this.NumericUpDownThreads.TabIndex = 31;
			this.NumericUpDownThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(401, 63);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(315, 13);
			this.label20.TabIndex = 18;
			this.label20.Text = "<= mas rápido                  Velocidad                  mas lento =>";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(194, 14);
			this.label4.TabIndex = 21;
			this.label4.Text = "Método";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// NumericProcess
			// 
			this.NumericProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NumericProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.NumericProcess.ForeColor = System.Drawing.Color.Azure;
			this.NumericProcess.Location = new System.Drawing.Point(158, 451);
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
			this.groupBox4.Location = new System.Drawing.Point(386, 74);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(238, 82);
			this.groupBox4.TabIndex = 19;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "3. Listo?";
			// 
			// tShowStats
			// 
			this.tShowStats.Interval = 10;
			this.tShowStats.Tick += new System.EventHandler(this.tShowStats_Tick);
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
			this.groupBox2.Controls.Add(this.txtTarget);
			this.groupBox2.ForeColor = System.Drawing.Color.LightBlue;
			this.groupBox2.Location = new System.Drawing.Point(96, 255);
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
			this.ButtonHelp.Location = new System.Drawing.Point(505, 447);
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
			this.ButtonConfiguration.Location = new System.Drawing.Point(12, 447);
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
			this.ButtonAddProcess.Location = new System.Drawing.Point(234, 434);
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
			this.label8.Location = new System.Drawing.Point(162, 436);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 36;
			this.label8.Text = "Procesos";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// ButtonDeath
			// 
			this.ButtonDeath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonDeath.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonDeath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDeath.ForeColor = System.Drawing.Color.White;
			this.ButtonDeath.Location = new System.Drawing.Point(641, 267);
			this.ButtonDeath.Name = "ButtonDeath";
			this.ButtonDeath.Size = new System.Drawing.Size(104, 70);
			this.ButtonDeath.TabIndex = 37;
			this.ButtonDeath.Text = "Comprobar \r\nMuerte";
			this.ButtonDeath.UseVisualStyleBackColor = true;
			this.ButtonDeath.Click += new System.EventHandler(this.ClickDeath);
			// 
			// GroupAttackMethod
			// 
			this.GroupAttackMethod.Controls.Add(this.tableLayoutPanel5);
			this.GroupAttackMethod.ForeColor = System.Drawing.Color.LightBlue;
			this.GroupAttackMethod.Location = new System.Drawing.Point(404, 8);
			this.GroupAttackMethod.Name = "GroupAttackMethod";
			this.GroupAttackMethod.Size = new System.Drawing.Size(238, 65);
			this.GroupAttackMethod.TabIndex = 38;
			this.GroupAttackMethod.TabStop = false;
			this.GroupAttackMethod.Text = "Método de Ataque";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.cbMethod, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(19, 15);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.69231F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.30769F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 43);
			this.tableLayoutPanel5.TabIndex = 22;
			// 
			// WindowFirst
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(786, 489);
			this.ControlBox = false;
			this.Controls.Add(this.GroupAttackMethod);
			this.Controls.Add(this.ButtonDeath);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.ButtonAddProcess);
			this.Controls.Add(this.NumericProcess);
			this.Controls.Add(this.ButtonConfiguration);
			this.Controls.Add(this.ButtonRestart);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ButtonHelp);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.GroupBoxAttackState);
			this.Controls.Add(this.BotonPausa);
			this.Controls.Add(this.BotonStop);
			this.Controls.Add(this.BotonPlay);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.ButtonAnonymousSantaFe);
			this.Controls.Add(this.GroupBoxAttackOption);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WindowFirst";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.WindowFirstLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.GroupBoxAttackState.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
			this.GroupBoxAttackOption.ResumeLayout(false);
			this.GroupBoxAttackOption.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownThreads)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericProcess)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.GroupAttackMethod.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
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
		private System.Windows.Forms.NumericUpDown NumericUpDownThreads;
		private System.Windows.Forms.Button ButtonHelp;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
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
		private System.Windows.Forms.TrackBar tbSpeed;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.GroupBox GroupBoxAttackOption;
		private System.Windows.Forms.Button ButtonAnonymousSantaFe;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.ComboBox cbMethod;
		private System.Windows.Forms.TextBox txtTimeout;
		private System.Windows.Forms.TextBox txtSubsite;
		private System.Windows.Forms.CheckBox chkResp;
		private System.Windows.Forms.Button BotonPlay;
		private System.Windows.Forms.Button BotonStop;
		private System.Windows.Forms.ToolTip ToolTips;
		private System.Windows.Forms.Button BotonPausa;
		private System.Windows.Forms.Button ButtonAttack;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox GroupBoxAttackState;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lbIdle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbConnecting;
		private System.Windows.Forms.Label lbRequesting;
		private System.Windows.Forms.Label lbDownloading;
		private System.Windows.Forms.Label lbDownloaded;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label lbRequested;
		private System.Windows.Forms.Label lbFailed;
		private System.Windows.Forms.NumericUpDown NumericUpDownPort;
		private System.Windows.Forms.GroupBox GroupAttackMethod;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
	}
}
