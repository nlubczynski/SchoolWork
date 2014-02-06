using System;
using System.IO;
using System.Windows.Forms;

namespace PurchaseOrder
{
	/// <summary>
	/// Summary description for MainModule.
	/// </summary>
	public class MainModule
	{
		static internal int employeeID;
		static internal bool soundOn = true;
		static internal string empName;
		static internal AppSettingsDataSet /*WithEvents*/ appSettingsData;
		static internal NorthwindDataSet /*WithEvents*/ pendingOrdersData;
		static internal NorthwindDataSet /*WithEvents*/ northwindData;
		static internal MainForm /*WithEvents*/ mainPOForm;
		static internal OrderApplicationDataClass orderData;


		// the following variables are used by MainForm and PrintingForm2565Class to construct 
		//   a Purchase Order document that contains all the data entered on MainForm
		//
		static internal int purchaseItemNumber;						// current Purchase Item being printed
		static internal int purchaseItemCount;						// total number of purchase items
		static internal string [] customerData = new string[9];		// Address and Ship To information
		static internal string[,] purchaseData = new string[1, 5];	// Purchase data

		public static void Main()
		{
			northwindData = new NorthwindDataSet();
			pendingOrdersData = new NorthwindDataSet();
			appSettingsData = new AppSettingsDataSet();
			orderData = new OrderApplicationDataClass();
			mainPOForm = new MainForm();
			mainPOForm.ShipViaListBox.SelectedIndex=0;
			try
			{
				appSettingsData.ReadXml(".\\AppSettings.xml");
				employeeID = (int)appSettingsData.AppSettings[0].EmployeeID;
				empName = appSettingsData.AppSettings[0].EmployeeName;
				soundOn = appSettingsData.AppSettings[0].SoundOn;
			}
			catch
			{}

			try
			{
				pendingOrdersData.ReadXml(".\\PendingOrders.xml");
			}
			catch
			{}

			try
			{
				northwindData.ReadXml(".\\NorthwindData.xml");
				mainPOForm.BindControls();
				mainPOForm.ViewSubmittedOrdersMenuItem.Enabled = true;
				mainPOForm.NewOrderItemButton.Enabled = true;
				
			}
			catch 
			{
				MessageBox.Show("The NorthwindData.xml file is missing or corrupt. Please connect to the database " + 
					"and rebuild this file using the Refresh Data option.", "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			mainPOForm.UpdateStatusBar();
			Application.Run(mainPOForm);

		}
	}

}
