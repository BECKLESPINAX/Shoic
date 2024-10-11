/*
 * Creado por SharpDevelop.
 * Usuario: BECKLESPINAX
 * Fecha: 17/05/2012
 * Hora: 04:22 p.m.
 */
 
 
namespace SHOIC
{
	partial class WindowSoldier
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
			this.GrillaProxys = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.GrillaProxys)).BeginInit();
			this.SuspendLayout();
			// 
			// GrillaProxys
			// 
			this.GrillaProxys.AllowUserToAddRows = false;
			this.GrillaProxys.AllowUserToDeleteRows = false;
			this.GrillaProxys.AllowUserToResizeColumns = false;
			this.GrillaProxys.AllowUserToResizeRows = false;
			this.GrillaProxys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.GrillaProxys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GrillaProxys.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GrillaProxys.Location = new System.Drawing.Point(0, 0);
			this.GrillaProxys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GrillaProxys.MultiSelect = false;
			this.GrillaProxys.Name = "GrillaProxys";
			this.GrillaProxys.ReadOnly = true;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
			this.GrillaProxys.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.GrillaProxys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GrillaProxys.Size = new System.Drawing.Size(714, 431);
			this.GrillaProxys.TabIndex = 0;
			// 
			// WindowSoldier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 431);
			this.Controls.Add(this.GrillaProxys);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WindowSoldier";
			this.Text = "Soldado";
			this.Load += new System.EventHandler(this.VentanaHTTPFlooderSHOICAccionLoad);
			((System.ComponentModel.ISupportInitialize)(this.GrillaProxys)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.DataGridView GrillaProxys;
	}
}
