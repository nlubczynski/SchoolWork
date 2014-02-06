using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;

namespace PurchaseOrder
{
	/// <summary>
	/// Summary description for BaseAboutForm.
	/// </summary>
	public class BaseAboutForm : System.Windows.Forms.Form
	{
		protected System.Windows.Forms.Label ProductNameLabel;
		protected System.Windows.Forms.Button AboutOkButton;
		private System.Windows.Forms.Button SysInfoButton;
		private System.Windows.Forms.Label WarningLabel;
		private System.Windows.Forms.PictureBox CompanyLogoImage;
		protected System.Windows.Forms.Label VersionNumber;
		protected System.Windows.Forms.Label AllRightsReservedLabel;
		protected System.Windows.Forms.Label CopyrightLabel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BaseAboutForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BaseAboutForm));
			this.ProductNameLabel = new System.Windows.Forms.Label();
			this.CopyrightLabel = new System.Windows.Forms.Label();
			this.AboutOkButton = new System.Windows.Forms.Button();
			this.VersionNumber = new System.Windows.Forms.Label();
			this.AllRightsReservedLabel = new System.Windows.Forms.Label();
			this.SysInfoButton = new System.Windows.Forms.Button();
			this.WarningLabel = new System.Windows.Forms.Label();
			this.CompanyLogoImage = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// ProductNameLabel
			// 
			this.ProductNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
			this.ProductNameLabel.ForeColor = System.Drawing.Color.Green;
			this.ProductNameLabel.Location = new System.Drawing.Point(143, 32);
			this.ProductNameLabel.Name = "ProductNameLabel";
			this.ProductNameLabel.Size = new System.Drawing.Size(163, 16);
			this.ProductNameLabel.TabIndex = 0;
			this.ProductNameLabel.Text = "Purchase Order Application";
			this.ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CopyrightLabel
			// 
			this.CopyrightLabel.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
			this.CopyrightLabel.ForeColor = System.Drawing.Color.Green;
			this.CopyrightLabel.Location = new System.Drawing.Point(143, 56);
			this.CopyrightLabel.Name = "CopyrightLabel";
			this.CopyrightLabel.Size = new System.Drawing.Size(208, 16);
			this.CopyrightLabel.TabIndex = 2;
			this.CopyrightLabel.Text = "Copyright © 2002 Northwind Traders";
			this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AboutOkButton
			// 
			this.AboutOkButton.Location = new System.Drawing.Point(384, 136);
			this.AboutOkButton.Name = "AboutOkButton";
			this.AboutOkButton.Size = new System.Drawing.Size(96, 23);
			this.AboutOkButton.TabIndex = 3;
			this.AboutOkButton.Text = "&OK";
			this.AboutOkButton.Click += new System.EventHandler(this.AboutOkButton_Click);
			// 
			// VersionNumber
			// 
			this.VersionNumber.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
			this.VersionNumber.ForeColor = System.Drawing.Color.Green;
			this.VersionNumber.Location = new System.Drawing.Point(368, 32);
			this.VersionNumber.Name = "VersionNumber";
			this.VersionNumber.Size = new System.Drawing.Size(112, 16);
			this.VersionNumber.TabIndex = 4;
			this.VersionNumber.Text = "Version <1.0.0000>";
			this.VersionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AllRightsReservedLabel
			// 
			this.AllRightsReservedLabel.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
			this.AllRightsReservedLabel.ForeColor = System.Drawing.Color.Green;
			this.AllRightsReservedLabel.Location = new System.Drawing.Point(376, 56);
			this.AllRightsReservedLabel.Name = "AllRightsReservedLabel";
			this.AllRightsReservedLabel.Size = new System.Drawing.Size(104, 16);
			this.AllRightsReservedLabel.TabIndex = 5;
			this.AllRightsReservedLabel.Text = "All rights reserved";
			this.AllRightsReservedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SysInfoButton
			// 
			this.SysInfoButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.SysInfoButton.Location = new System.Drawing.Point(384, 88);
			this.SysInfoButton.Name = "SysInfoButton";
			this.SysInfoButton.Size = new System.Drawing.Size(96, 23);
			this.SysInfoButton.TabIndex = 6;
			this.SysInfoButton.Text = "&System Info...";
			this.SysInfoButton.Click += new System.EventHandler(this.SysInfoButton_Click);
			// 
			// WarningLabel
			// 
			this.WarningLabel.Font = new System.Drawing.Font("Trebuchet MS", 8F);
			this.WarningLabel.Location = new System.Drawing.Point(143, 88);
			this.WarningLabel.Name = "WarningLabel";
			this.WarningLabel.Size = new System.Drawing.Size(233, 80);
			this.WarningLabel.TabIndex = 8;
			this.WarningLabel.Text = @"This program is protected by copyright law and international treaties. Unauthorized reproduction or distribution of this program, or any portion of it, may result in severe civil and criminal penalties, and will be prosecuted to the maximum extent possible under law.";
			// 
			// CompanyLogoImage
			// 
			this.CompanyLogoImage.Image = ((System.Drawing.Bitmap)(resources.GetObject("CompanyLogoImage.Image")));
			this.CompanyLogoImage.Location = new System.Drawing.Point(10, 24);
			this.CompanyLogoImage.Name = "CompanyLogoImage";
			this.CompanyLogoImage.Size = new System.Drawing.Size(120, 130);
			this.CompanyLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CompanyLogoImage.TabIndex = 9;
			this.CompanyLogoImage.TabStop = false;
			// 
			// BaseAboutForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(494, 180);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.CompanyLogoImage,
																		  this.WarningLabel,
																		  this.SysInfoButton,
																		  this.AllRightsReservedLabel,
																		  this.VersionNumber,
																		  this.AboutOkButton,
																		  this.CopyrightLabel,
																		  this.ProductNameLabel});
			this.Font = new System.Drawing.Font("Trebuchet MS", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BaseAboutForm";
			this.Text = "About Purchase Order Application";
			this.ResumeLayout(false);

		}
		#endregion

		protected void AboutOkButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void SysInfoButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				Process msinfo = new Process();
				msinfo.StartInfo.ErrorDialog = true;
				msinfo.StartInfo.FileName = "C:\\Program Files\\Common Files\\Microsoft Shared\\MSInfo\\msinfo32.exe";
				msinfo.Start();
			}
			catch (Exception exc)
			{
				MessageBox.Show (exc.Message);
			}
		}
	}
}
