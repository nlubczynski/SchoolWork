using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace PurchaseOrder
{
	/// <summary>
	/// Summary description for PendingOrdersForm.
	/// </summary>
	public class PendingOrdersForm : System.Windows.Forms.Form
	{

		private int pendingOrderRows;

		internal System.Windows.Forms.DataGrid PendingOrdersDataGrid;
		internal System.Windows.Forms.Button CloseButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PendingOrdersForm()
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
			this.PendingOrdersDataGrid = new System.Windows.Forms.DataGrid();
			this.CloseButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PendingOrdersDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// PendingOrdersDataGrid
			// 
			this.PendingOrdersDataGrid.DataMember = "";
			this.PendingOrdersDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
			this.PendingOrdersDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.PendingOrdersDataGrid.Name = "PendingOrdersDataGrid";
			this.PendingOrdersDataGrid.Size = new System.Drawing.Size(728, 384);
			this.PendingOrdersDataGrid.TabIndex = 5;
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(624, 416);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.TabIndex = 4;
			this.CloseButton.Text = "Close";
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// PendingOrdersForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(728, 446);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.PendingOrdersDataGrid,
																		  this.CloseButton});
			this.Name = "PendingOrdersForm";
			this.Text = "PendingOrdersForm";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.PendingOrdersForm_Closing);
			this.Load += new System.EventHandler(this.frmPendingOrders_Load);
			((System.ComponentModel.ISupportInitialize)(this.PendingOrdersDataGrid)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmPendingOrders_Load(object sender, System.EventArgs e)
		{
			//Handles MyBase.Load
			if (MainModule.pendingOrdersData != null)
			{
				pendingOrderRows = MainModule.pendingOrdersData.Orders.Rows.Count;
				MainModule.pendingOrdersData.Orders.OrderIDColumn.ReadOnly = true;
				MainModule.pendingOrdersData.Orders.CustomerIDColumn.ReadOnly = true;
				MainModule.pendingOrdersData.Orders.EmployeeIDColumn.ReadOnly = true;
				MainModule.pendingOrdersData.Orders.ShippedDateColumn.ReadOnly = true;
				MainModule.pendingOrdersData.Orders.FreightColumn.ReadOnly = true;

				MainModule.pendingOrdersData.OrderDetails.OrderIDColumn.ReadOnly = true;
				MainModule.pendingOrdersData.OrderDetails.ProductIDColumn.ReadOnly = true;
				MainModule.pendingOrdersData.OrderDetails.UnitPriceColumn.ReadOnly = true;

				PendingOrdersDataGrid.AlternatingBackColor = Color.CadetBlue;
				PendingOrdersDataGrid.SetDataBinding(MainModule.pendingOrdersData, "Orders");
			}
		}

		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			this.Close();	
		}

		private void PendingOrdersForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(MainModule.pendingOrdersData != null)
			{
				pendingOrderRows = MainModule.pendingOrdersData.Orders.Rows.Count;
				MainModule.pendingOrdersData.Orders.OrderIDColumn.ReadOnly = false;
				MainModule.pendingOrdersData.Orders.CustomerIDColumn.ReadOnly = false;
				MainModule.pendingOrdersData.Orders.EmployeeIDColumn.ReadOnly = false;
				MainModule.pendingOrdersData.Orders.ShippedDateColumn.ReadOnly = false;
				MainModule.pendingOrdersData.Orders.FreightColumn.ReadOnly = false;

				MainModule.pendingOrdersData.OrderDetails.OrderIDColumn.ReadOnly = false;
				MainModule.pendingOrdersData.OrderDetails.ProductIDColumn.ReadOnly = false;
				MainModule.pendingOrdersData.OrderDetails.UnitPriceColumn.ReadOnly = false;


				if (MainModule.pendingOrdersData.Orders.Rows.Count > pendingOrderRows)
				{
					while (MainModule.pendingOrdersData.Orders.Rows.Count > pendingOrderRows)
					{
						MainModule.pendingOrdersData.Orders.Rows.RemoveAt(MainModule.pendingOrdersData.Orders.Rows.Count - 1);
					}
				}

                //MainModule.pendingOrdersData.WriteXml(Path.Combine(Application.CommonAppDataPath, @"\PendingOrders.xml"));
                MainModule.pendingOrdersData.WriteXml(Path.Combine(".", @"\PendingOrders.xml"));
                MainModule.mainPOForm.UpdateStatusBar();
			}
		}
	}
}
