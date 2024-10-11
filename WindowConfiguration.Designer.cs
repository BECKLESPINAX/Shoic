/*
 * Creado por SharpDevelop.
 * Usuario:SANTAFEHACK
 * Fecha: 17/05/2012
 * Hora: 03:09 p.m.
 */

namespace SHOIC
{
	partial class WindowConfiguration
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowConfiguration));
			this.ButtonHelp = new System.Windows.Forms.Button();
			this.DataGridViewProxys = new System.Windows.Forms.DataGridView();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonClearAutoCompleted = new System.Windows.Forms.Button();
			this.RadioButtonProxyAuto = new System.Windows.Forms.RadioButton();
			this.RadioButtonProxyManual = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewProxys)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonHelp
			// 
			this.ButtonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonHelp.ForeColor = System.Drawing.Color.White;
			this.ButtonHelp.Location = new System.Drawing.Point(284, 349);
			this.ButtonHelp.Name = "ButtonHelp";
			this.ButtonHelp.Size = new System.Drawing.Size(88, 30);
			this.ButtonHelp.TabIndex = 31;
			this.ButtonHelp.Text = "Ayuda";
			this.ButtonHelp.UseVisualStyleBackColor = true;
			this.ButtonHelp.Click += new System.EventHandler(this.ClickHelp);
			// 
			// DataGridViewProxys
			// 
			this.DataGridViewProxys.AllowUserToOrderColumns = true;
			this.DataGridViewProxys.AllowUserToResizeColumns = false;
			this.DataGridViewProxys.AllowUserToResizeRows = false;
			this.DataGridViewProxys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridViewProxys.DefaultCellStyle = dataGridViewCellStyle1;
			this.DataGridViewProxys.Location = new System.Drawing.Point(48, 37);
			this.DataGridViewProxys.MultiSelect = false;
			this.DataGridViewProxys.Name = "DataGridViewProxys";
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.DataGridViewProxys.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridViewProxys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridViewProxys.Size = new System.Drawing.Size(375, 198);
			this.DataGridViewProxys.TabIndex = 32;
			this.DataGridViewProxys.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GrillaDataError);
			// 
			// ButtonExit
			// 
			this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonExit.ForeColor = System.Drawing.Color.White;
			this.ButtonExit.Location = new System.Drawing.Point(378, 349);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(88, 30);
			this.ButtonExit.TabIndex = 33;
			this.ButtonExit.Text = "Salir";
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ClickExit);
			// 
			// ButtonSave
			// 
			this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSave.ForeColor = System.Drawing.Color.White;
			this.ButtonSave.Location = new System.Drawing.Point(193, 241);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(88, 30);
			this.ButtonSave.TabIndex = 34;
			this.ButtonSave.Text = "Guardar";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ClickSave);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(140, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 19);
			this.label1.TabIndex = 35;
			this.label1.Text = "Configuración de Proxys";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// ButtonClearAutoCompleted
			// 
			this.ButtonClearAutoCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonClearAutoCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonClearAutoCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonClearAutoCompleted.ForeColor = System.Drawing.Color.White;
			this.ButtonClearAutoCompleted.Location = new System.Drawing.Point(93, 349);
			this.ButtonClearAutoCompleted.Name = "ButtonClearAutoCompleted";
			this.ButtonClearAutoCompleted.Size = new System.Drawing.Size(175, 30);
			this.ButtonClearAutoCompleted.TabIndex = 36;
			this.ButtonClearAutoCompleted.Text = "Limpiar Autocompletado";
			this.ButtonClearAutoCompleted.UseVisualStyleBackColor = true;
			this.ButtonClearAutoCompleted.Click += new System.EventHandler(this.ClickClearAutoCompleted);
			// 
			// RadioButtonProxyAuto
			// 
			this.RadioButtonProxyAuto.Checked = true;
			this.RadioButtonProxyAuto.Location = new System.Drawing.Point(73, 283);
			this.RadioButtonProxyAuto.Name = "RadioButtonProxyAuto";
			this.RadioButtonProxyAuto.Size = new System.Drawing.Size(152, 24);
			this.RadioButtonProxyAuto.TabIndex = 40;
			this.RadioButtonProxyAuto.TabStop = true;
			this.RadioButtonProxyAuto.Text = "Usar Proxys Automáticos";
			this.RadioButtonProxyAuto.UseVisualStyleBackColor = true;
			this.RadioButtonProxyAuto.Click += new System.EventHandler(this.ClickProxyAutoManual);
			// 
			// RadioButtonProxyManual
			// 
			this.RadioButtonProxyManual.Location = new System.Drawing.Point(246, 283);
			this.RadioButtonProxyManual.Name = "RadioButtonProxyManual";
			this.RadioButtonProxyManual.Size = new System.Drawing.Size(155, 24);
			this.RadioButtonProxyManual.TabIndex = 41;
			this.RadioButtonProxyManual.Text = "Usar Proxys Manuales";
			this.RadioButtonProxyManual.UseVisualStyleBackColor = true;
			this.RadioButtonProxyManual.Click += new System.EventHandler(this.ClickProxyAutoManual);
			// 
			// WindowConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(478, 391);
			this.ControlBox = false;
			this.Controls.Add(this.RadioButtonProxyManual);
			this.Controls.Add(this.RadioButtonProxyAuto);
			this.Controls.Add(this.ButtonClearAutoCompleted);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.DataGridViewProxys);
			this.Controls.Add(this.ButtonHelp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WindowConfiguration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewProxys)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.RadioButton RadioButtonProxyManual;
		private System.Windows.Forms.RadioButton RadioButtonProxyAuto;
		private System.Windows.Forms.Button ButtonClearAutoCompleted;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.DataGridView DataGridViewProxys;
		private System.Windows.Forms.Button ButtonHelp;
		
	
	}
}
