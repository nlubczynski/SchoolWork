using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace PurchaseOrder
{
	/// <summary>
	/// Summary description for OptionsForm.
	/// </summary>
	public class OptionsForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.Button CancelUserButton;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button btnConnect;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Button CancelSoundButton;
		internal System.Windows.Forms.Button OKButton;
		internal System.Windows.Forms.CheckBox DisableSoundCheckBox;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public OptionsForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.CancelUserButton = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.CancelSoundButton = new System.Windows.Forms.Button();
			this.OKButton = new System.Windows.Forms.Button();
			this.DisableSoundCheckBox = new System.Windows.Forms.CheckBox();
			this.TabControl1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabControl1
			// 
			this.TabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.TabPage2,
																					  this.TabPage1});
			this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(292, 266);
			this.TabControl1.TabIndex = 1;
			// 
			// TabPage2
			// 
			this.TabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.CancelUserButton,
																				   this.Label2,
																				   this.Label1,
																				   this.btnConnect});
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Size = new System.Drawing.Size(284, 240);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "User";
			// 
			// CancelUserButton
			// 
			this.CancelUserButton.Location = new System.Drawing.Point(192, 200);
			this.CancelUserButton.Name = "CancelUserButton";
			this.CancelUserButton.TabIndex = 3;
			this.CancelUserButton.Text = "Cancel";
			this.CancelUserButton.Click += new System.EventHandler(this.CancelOptions);
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(32, 120);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(224, 56);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "This will change order history data to contain the new user\'s information. All ne" +
				"w orders created will be assigned to the new user.";
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.Location = new System.Drawing.Point(24, 40);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(240, 16);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "To change users, press the Connect button";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(192, 72);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// TabPage1
			// 
			this.TabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.CancelSoundButton,
																				   this.OKButton,
																				   this.DisableSoundCheckBox});
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Size = new System.Drawing.Size(284, 240);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Sound";
			this.TabPage1.Visible = false;
			// 
			// CancelSoundButton
			// 
			this.CancelSoundButton.Location = new System.Drawing.Point(200, 208);
			this.CancelSoundButton.Name = "CancelSoundButton";
			this.CancelSoundButton.TabIndex = 2;
			this.CancelSoundButton.Text = "Cancel";
			this.CancelSoundButton.Click += new System.EventHandler(this.CancelOptions);
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(112, 208);
			this.OKButton.Name = "OKButton";
			this.OKButton.TabIndex = 1;
			this.OKButton.Text = "OK";
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// DisableSoundCheckBox
			// 
			this.DisableSoundCheckBox.Location = new System.Drawing.Point(24, 40);
			this.DisableSoundCheckBox.Name = "DisableSoundCheckBox";
			this.DisableSoundCheckBox.TabIndex = 0;
			this.DisableSoundCheckBox.Text = "Disable sound";
			// 
			// OptionsForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.TabControl1});
			this.Name = "OptionsForm";
			this.Text = "Options";
			this.Load += new System.EventHandler(this.OptionsForm_Load);
			this.TabControl1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			MainModule.employeeID = 0;
			MainModule.orderData.RefreshLocalData();
			this.Close();
		}

		private void OKButton_Click(object sender, System.EventArgs e)
		{
			MainModule.soundOn = !(DisableSoundCheckBox.Checked);
			MainModule.orderData.ToggleSound();
			this.Close();
		}

		private void OptionsForm_Load(object sender, System.EventArgs e)
		{
			DisableSoundCheckBox.Checked = !(MainModule.soundOn);
		}
		private void CancelOptions(object sender ,System.EventArgs e) 
		{
			//Handles CancelSoundButton.Click, CancelUserButton.Click
			this.Close();
		}


	}
}
