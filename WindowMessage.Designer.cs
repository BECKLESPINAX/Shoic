namespace SHOIC
{
	partial class WindowMessage1
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
			this.ButtonOk = new System.Windows.Forms.Button();
			this.LabelAttackStateInsert = new System.Windows.Forms.Label();
			this.TimerMessage = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// ButtonOk
			// 
			this.ButtonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ButtonOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonOk.ForeColor = System.Drawing.Color.White;
			this.ButtonOk.Location = new System.Drawing.Point(341, 257);
			this.ButtonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ButtonOk.Name = "ButtonOk";
			this.ButtonOk.Size = new System.Drawing.Size(132, 46);
			this.ButtonOk.TabIndex = 35;
			this.ButtonOk.Text = "Configuración";
			this.ButtonOk.UseVisualStyleBackColor = true;
			this.ButtonOk.Click += new System.EventHandler(this.ClickOk);
			// 
			// LabelAttackStateInsert
			// 
			this.LabelAttackStateInsert.Dock = System.Windows.Forms.DockStyle.Top;
			this.LabelAttackStateInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelAttackStateInsert.ForeColor = System.Drawing.Color.White;
			this.LabelAttackStateInsert.Location = new System.Drawing.Point(0, 0);
			this.LabelAttackStateInsert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelAttackStateInsert.Name = "LabelAttackStateInsert";
			this.LabelAttackStateInsert.Size = new System.Drawing.Size(813, 199);
			this.LabelAttackStateInsert.TabIndex = 36;
			this.LabelAttackStateInsert.Text = "Ataque masivo...";
			this.LabelAttackStateInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TimerMessage
			// 
			this.TimerMessage.Tick += new System.EventHandler(this.TimerMessage_Tick);
			// 
			// WindowMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(813, 317);
			this.ControlBox = false;
			this.Controls.Add(this.LabelAttackStateInsert);
			this.Controls.Add(this.ButtonOk);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "WindowMessage";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.WindowMessage_Load);
			this.Click += new System.EventHandler(this.ClickWindowMessage);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownWindowMessage);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ButtonOk;
		private System.Windows.Forms.Label LabelAttackStateInsert;
		private System.Windows.Forms.Timer TimerMessage;
	}
}