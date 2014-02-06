using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PurchaseOrder
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class LogonForm : System.Windows.Forms.Form
	{
	    private int empID;
		private string empFullName;

		internal System.Windows.Forms.Button CancelLogonButton;
		internal System.Windows.Forms.Button OKButton;
		internal System.Windows.Forms.ListBox EmployeesListBox;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LogonForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			EmployeesListBox.DataSource = MainModule.northwindData.Employees;
			EmployeesListBox.DisplayMember = "FullName";
			EmployeesListBox.ValueMember = "EmployeeID";

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.CancelLogonButton = new System.Windows.Forms.Button();
			this.OKButton = new System.Windows.Forms.Button();
			this.EmployeesListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// CancelLogonButton
			// 
			this.CancelLogonButton.Location = new System.Drawing.Point(275, 101);
			this.CancelLogonButton.Name = "CancelLogonButton";
			this.CancelLogonButton.TabIndex = 5;
			this.CancelLogonButton.Text = "Cancel";
			this.CancelLogonButton.Click += new System.EventHandler(this.CancelLogonButton_Click);
			// 
			// OKButton
			// 
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OKButton.Location = new System.Drawing.Point(275, 61);
			this.OKButton.Name = "OKButton";
			this.OKButton.TabIndex = 4;
			this.OKButton.Text = "OK";
			this.OKButton.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// EmployeesListBox
			// 
			this.EmployeesListBox.Location = new System.Drawing.Point(51, 53);
			this.EmployeesListBox.Name = "EmployeesListBox";
			this.EmployeesListBox.Size = new System.Drawing.Size(200, 173);
			this.EmployeesListBox.TabIndex = 3;
			// 
			// LogonForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(400, 278);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.CancelLogonButton,
																		  this.OKButton,
																		  this.EmployeesListBox});
			this.Name = "LogonForm";
			this.Text = "Logon";
			this.ResumeLayout(false);

		}
		#endregion

		public int EmployeeID
		{
			get
			{
				return empID;
			}
		}

		public string EmployeeName
		{
			get
			{
				return empFullName;
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			empID = Convert.ToInt32(EmployeesListBox.SelectedValue);
			empFullName = EmployeesListBox.Text;
		}

		private void CancelLogonButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
