/*
 * Creado por SharpDevelop.
 * Usuario:SANTAFEHACK
 * Fecha: 20/09/2012
 * Hora: 04:36 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SHOIC
{
	partial class WindowHelp
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
			this.BotonSalir = new System.Windows.Forms.Button();
			this.WebBrowserAyuda = new System.Windows.Forms.WebBrowser();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BotonSalir
			// 
			this.BotonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BotonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonSalir.ForeColor = System.Drawing.Color.White;
			this.BotonSalir.Location = new System.Drawing.Point(566, 370);
			this.BotonSalir.Name = "BotonSalir";
			this.BotonSalir.Size = new System.Drawing.Size(88, 30);
			this.BotonSalir.TabIndex = 34;
			this.BotonSalir.Text = "Salir";
			this.BotonSalir.UseVisualStyleBackColor = true;
			this.BotonSalir.Click += new System.EventHandler(this.ClickSalir);
			// 
			// WebBrowserAyuda
			// 
			this.WebBrowserAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.WebBrowserAyuda.Location = new System.Drawing.Point(12, 31);
			this.WebBrowserAyuda.MinimumSize = new System.Drawing.Size(20, 20);
			this.WebBrowserAyuda.Name = "WebBrowserAyuda";
			this.WebBrowserAyuda.Size = new System.Drawing.Size(642, 333);
			this.WebBrowserAyuda.TabIndex = 35;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.LightBlue;
			this.label5.Location = new System.Drawing.Point(111, 1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(334, 27);
			this.label5.TabIndex = 36;
			this.label5.Text = "Ayuda Super High Orbit Ion Canion";
			// 
			// WindowHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(666, 412);
			this.ControlBox = false;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.WebBrowserAyuda);
			this.Controls.Add(this.BotonSalir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "WindowHelp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DobleClick);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.WebBrowser WebBrowserAyuda;
		private System.Windows.Forms.Button BotonSalir;
	}
}
