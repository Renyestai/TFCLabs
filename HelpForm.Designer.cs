﻿namespace TFCLab1
{
	partial class HelpForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
			this.webBrowserHelp = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// webBrowserHelp
			// 
			this.webBrowserHelp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowserHelp.Location = new System.Drawing.Point(0, 0);
			this.webBrowserHelp.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowserHelp.Name = "webBrowserHelp";
			this.webBrowserHelp.Size = new System.Drawing.Size(800, 450);
			this.webBrowserHelp.TabIndex = 0;
			// 
			// HelpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.webBrowserHelp);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HelpForm";
			this.Text = "Справка";
			this.Load += new System.EventHandler(this.Help_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowserHelp;
	}
}