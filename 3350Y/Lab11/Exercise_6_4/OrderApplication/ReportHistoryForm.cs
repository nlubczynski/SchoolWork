using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace PurchaseOrder
{
	/// <summary>
	/// Summary description for ReportHistoryForm.
	/// </summary>
	public class ReportHistoryForm : System.Windows.Forms.Form
	{

		private OrderHistory orderHistoryReport;
		internal CrystalDecisions.Windows.Forms.CrystalReportViewer HistoryCrystalReportViewer;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ReportHistoryForm()
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
			this.HistoryCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// HistoryCrystalReportViewer
			// 
			this.HistoryCrystalReportViewer.ActiveViewIndex = -1;
			this.HistoryCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HistoryCrystalReportViewer.Name = "HistoryCrystalReportViewer";
			this.HistoryCrystalReportViewer.ReportSource = null;
			this.HistoryCrystalReportViewer.Size = new System.Drawing.Size(896, 502);
			this.HistoryCrystalReportViewer.TabIndex = 0;
			// 
			// ReportHistoryForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(896, 502);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.HistoryCrystalReportViewer});
			this.Name = "ReportHistoryForm";
			this.Text = "Report History";
			this.Load += new System.EventHandler(this.frmReportHistory_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmReportHistory_Load(object sender, System.EventArgs e)
		{
			//instantiate the OrderHistory Crystal Report
			orderHistoryReport = new OrderHistory();
			//bind the report to the northwindData dataset
			orderHistoryReport.SetDataSource(MainModule.northwindData);
			//set the ReportSource of the Crystal Report Viewer to the OrderHistory Crystal Report
			HistoryCrystalReportViewer.ReportSource = orderHistoryReport;
		}
	}
}
