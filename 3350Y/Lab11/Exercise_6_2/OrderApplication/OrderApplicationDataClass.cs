using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace PurchaseOrder
{
	/// <summary>
	/// Summary description for OrderApplicationDataClass.
	/// </summary>
	public class OrderApplicationDataClass : System.ComponentModel.Component
	{
		internal System.Data.SqlClient.SqlCommand cmINSERTOrderDetails;
		internal System.Data.SqlClient.SqlConnection NorthwindConnection;
		internal System.Data.SqlClient.SqlDataAdapter OrderDetailsDataAdapter;
		internal System.Data.SqlClient.SqlCommand cmDELETEOrderDetails;
		internal System.Data.SqlClient.SqlCommand cmSELECTOrderDetails;
		internal System.Data.SqlClient.SqlCommand cmUPDATEOrderDetails;
		internal System.Data.SqlClient.SqlCommand cmDELETEOrders;
		internal System.Data.SqlClient.SqlCommand cmSELECTCustomers;
		internal System.Data.SqlClient.SqlDataAdapter OrdersDataAdapter;
		internal System.Data.SqlClient.SqlCommand cmINSERTOrders;
		internal System.Data.SqlClient.SqlCommand cmSELECTOrders;
		internal System.Data.SqlClient.SqlCommand cmUPDATEOrders;
		internal System.Data.SqlClient.SqlCommand cmSELECTProducts;
		internal System.Data.SqlClient.SqlDataAdapter CustomersDataAdapter;
		internal System.Data.SqlClient.SqlCommand SqlSelectCommand1;
		internal System.Data.SqlClient.SqlDataAdapter EmployeesDataAdapter;
		internal System.Data.SqlClient.SqlDataAdapter ProductsDataAdapter;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public OrderApplicationDataClass(System.ComponentModel.IContainer container)
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			container.Add(this);
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public OrderApplicationDataClass()
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderApplicationDataClass));
            this.cmINSERTOrderDetails = new System.Data.SqlClient.SqlCommand();
            this.NorthwindConnection = new System.Data.SqlClient.SqlConnection();
            this.OrderDetailsDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.cmDELETEOrderDetails = new System.Data.SqlClient.SqlCommand();
            this.cmSELECTOrderDetails = new System.Data.SqlClient.SqlCommand();
            this.cmUPDATEOrderDetails = new System.Data.SqlClient.SqlCommand();
            this.cmDELETEOrders = new System.Data.SqlClient.SqlCommand();
            this.cmSELECTCustomers = new System.Data.SqlClient.SqlCommand();
            this.OrdersDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.cmINSERTOrders = new System.Data.SqlClient.SqlCommand();
            this.cmSELECTOrders = new System.Data.SqlClient.SqlCommand();
            this.cmUPDATEOrders = new System.Data.SqlClient.SqlCommand();
            this.cmSELECTProducts = new System.Data.SqlClient.SqlCommand();
            this.CustomersDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.EmployeesDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.ProductsDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            // 
            // cmINSERTOrderDetails
            // 
            this.cmINSERTOrderDetails.CommandText = "INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount) V" +
    "ALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)";
            this.cmINSERTOrderDetails.Connection = this.NorthwindConnection;
            this.cmINSERTOrderDetails.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"),
            new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"),
            new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"),
            new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"),
            new System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount")});
            // 
            // NorthwindConnection
            // 
            this.NorthwindConnection.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\NikLubz\\Source\\Repos\\School" +
    "Work\\3350Y\\Lab11\\Databases\\northwind.mdf;Integrated Security=True;Connect Timeou" +
    "t=30";
            this.NorthwindConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // OrderDetailsDataAdapter
            // 
            this.OrderDetailsDataAdapter.DeleteCommand = this.cmDELETEOrderDetails;
            this.OrderDetailsDataAdapter.InsertCommand = this.cmINSERTOrderDetails;
            this.OrderDetailsDataAdapter.SelectCommand = this.cmSELECTOrderDetails;
            this.OrderDetailsDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Order Details", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
                        new System.Data.Common.DataColumnMapping("Discount", "Discount")})});
            this.OrderDetailsDataAdapter.UpdateCommand = this.cmUPDATEOrderDetails;
            // 
            // cmDELETEOrderDetails
            // 
            this.cmDELETEOrderDetails.CommandText = resources.GetString("cmDELETEOrderDetails.CommandText");
            this.cmDELETEOrderDetails.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Discount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null)});
            // 
            // cmSELECTOrderDetails
            // 
            this.cmSELECTOrderDetails.CommandText = resources.GetString("cmSELECTOrderDetails.CommandText");
            this.cmSELECTOrderDetails.Connection = this.NorthwindConnection;
            this.cmSELECTOrderDetails.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID")});
            // 
            // cmUPDATEOrderDetails
            // 
            this.cmUPDATEOrderDetails.CommandText = resources.GetString("cmUPDATEOrderDetails.CommandText");
            this.cmUPDATEOrderDetails.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"),
            new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"),
            new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"),
            new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"),
            new System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount"),
            new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Discount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null)});
            // 
            // cmDELETEOrders
            // 
            this.cmDELETEOrders.CommandText = resources.GetString("cmDELETEOrders.CommandText");
            this.cmDELETEOrders.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Freight", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null)});
            // 
            // cmSELECTCustomers
            // 
            this.cmSELECTCustomers.CommandText = "SELECT CustomerID, CompanyName, Address, City, Region, PostalCode, Country FROM C" +
    "ustomers ORDER BY CompanyName";
            this.cmSELECTCustomers.Connection = this.NorthwindConnection;
            // 
            // OrdersDataAdapter
            // 
            this.OrdersDataAdapter.DeleteCommand = this.cmDELETEOrders;
            this.OrdersDataAdapter.InsertCommand = this.cmINSERTOrders;
            this.OrdersDataAdapter.SelectCommand = this.cmSELECTOrders;
            this.OrdersDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                        new System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"),
                        new System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"),
                        new System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"),
                        new System.Data.Common.DataColumnMapping("Freight", "Freight"),
                        new System.Data.Common.DataColumnMapping("ShipName", "ShipName"),
                        new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
                        new System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"),
                        new System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"),
                        new System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"),
                        new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})});
            this.OrdersDataAdapter.UpdateCommand = this.cmUPDATEOrders;
            // 
            // cmINSERTOrders
            // 
            this.cmINSERTOrders.CommandText = resources.GetString("cmINSERTOrders.CommandText");
            this.cmINSERTOrders.Connection = this.NorthwindConnection;
            this.cmINSERTOrders.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"),
            new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"),
            new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"),
            new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"),
            new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"),
            new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"),
            new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"),
            new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"),
            new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"),
            new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"),
            new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"),
            new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry")});
            // 
            // cmSELECTOrders
            // 
            this.cmSELECTOrders.CommandText = resources.GetString("cmSELECTOrders.CommandText");
            this.cmSELECTOrders.Connection = this.NorthwindConnection;
            this.cmSELECTOrders.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID")});
            // 
            // cmUPDATEOrders
            // 
            this.cmUPDATEOrders.CommandText = resources.GetString("cmUPDATEOrders.CommandText");
            this.cmUPDATEOrders.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@Param1", System.Data.SqlDbType.Int, 4, "EmployeeID"),
            new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"),
            new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"),
            new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"),
            new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"),
            new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"),
            new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"),
            new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"),
            new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"),
            new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"),
            new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"),
            new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"),
            new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Freight", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID")});
            // 
            // cmSELECTProducts
            // 
            this.cmSELECTProducts.CommandText = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice FROM Products ORDER BY " +
    "ProductName";
            this.cmSELECTProducts.Connection = this.NorthwindConnection;
            // 
            // CustomersDataAdapter
            // 
            this.CustomersDataAdapter.SelectCommand = this.cmSELECTCustomers;
            this.CustomersDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country")})});
            // 
            // SqlSelectCommand1
            // 
            this.SqlSelectCommand1.CommandText = "SELECT EmployeeID, LastName +\',\'+ FirstName AS FullName FROM Employees";
            this.SqlSelectCommand1.Connection = this.NorthwindConnection;
            // 
            // EmployeesDataAdapter
            // 
            this.EmployeesDataAdapter.SelectCommand = this.SqlSelectCommand1;
            this.EmployeesDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("FullName", "FullName")})});
            // 
            // ProductsDataAdapter
            // 
            this.ProductsDataAdapter.SelectCommand = this.cmSELECTProducts;
            this.ProductsDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice")})});

		}
		#endregion

		public void RefreshLocalData()
		{
			NorthwindDataSet tempDataSet = new NorthwindDataSet();
			//if theMainModule.employeeID value is not set, call the ChooseEmployee method to
			//allow the user to choose their name from a list
			if (MainModule.employeeID == 0)
			{
				ChooseEmployee();
			}
			//try to open a connection
			if (NorthwindConnection.State != ConnectionState.Open)
			{
				try
				{
					NorthwindConnection.Open();
				}
				catch (Exception Xcp)
				{
					MessageBox.Show("Failed to connect because:\n" + Xcp.ToString() +"\n\nTry a different server name.", "Get from central database", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			
			try
			{
				if (MainModule.employeeID > 0)
				{
					//fill the temporary dataset
					CustomersDataAdapter.Fill(tempDataSet.Customers);
					ProductsDataAdapter.Fill(tempDataSet.Products);
					OrdersDataAdapter.SelectCommand.Parameters["@EmployeeID"].Value =MainModule.employeeID;
					OrdersDataAdapter.Fill(tempDataSet.Orders);
					OrderDetailsDataAdapter.SelectCommand.Parameters["@EmployeeID"].Value =MainModule.employeeID;
					OrderDetailsDataAdapter.Fill(tempDataSet.OrderDetails);

					NorthwindConnection.Close();
					//merge the temporary dataset into the nothwindData dataset and persist it
					//as NorthwindData.xml in the CommonAppDataPath
					MainModule.northwindData.Merge(tempDataSet, false);
					MainModule.northwindData.AcceptChanges();
                    //MainModule.northwindData.WriteXml(Application.CommonAppDataPath + "\\NorthwindData.xml");
                    MainModule.northwindData.WriteXml(".\\NorthwindData.xml");
                }
				else
				{
					return;
				}
			}
			catch(Exception Xcp)
			{
				MessageBox.Show(Xcp.ToString(), "Title", MessageBoxButtons.OK);
			}
			MainModule.mainPOForm.NewOrderItemButton.Enabled = true;
		}

		public void ChooseEmployee()
		{
			//try to open a connection
			if (NorthwindConnection.State != ConnectionState.Open)
			{
				try
				{
					NorthwindConnection.Open();
				}
				catch(Exception Xcp)
				{
					MessageBox.Show("Failed to connect because:\n" + Xcp.ToString() +"\n\nTry a different server name.", "Get from central database", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			try
			{
				// fill the Employees DataTable
				this.EmployeesDataAdapter.Fill(MainModule.northwindData.Employees);
				NorthwindConnection.Close();
			}
			catch(Exception Xcp)
			{
				MessageBox.Show("Failed to retrieve employee list because: \n" + Xcp.ToString(), "Get from central database", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			LogonForm frm = new LogonForm();
			frm.ShowDialog();

			if (frm.EmployeeID > 0 )
			{
				MainModule.employeeID = frm.EmployeeID;
				MainModule.empName = frm.EmployeeName;
			}
			else
			{
				return;
			}

			//Clear the Employee data from the dataset. We do not want to persist it.
			MainModule.northwindData.Employees.Clear();
			
			//Because we merge this dataset at the end of this procedure we need to 
			//Clear the Order and OrderDetails tables of the previous employee. 
			//You must also clear the OrderDetails child table before the clearing the 
			//Orders parent table or you will get a referentil integrity error
			MainModule.northwindData.OrderDetails.Clear();
			MainModule.northwindData.Orders.Clear();

			frm.Close();

			//All of the data in the MainModule.appSettingsData table is on the first row (0).
			//Here we test to ensure that the first row does exist. If it does not exist
			//we add it to the MainModule.appSettingsData table. If it does exist we save the 
			//application variables to it.
			if (MainModule.appSettingsData.AppSettings.Rows.Count <= 0)
			{
				AppSettingsDataSet.AppSettingsRow settingsRow = MainModule.appSettingsData.AppSettings.NewRow() as AppSettingsDataSet.AppSettingsRow;
				settingsRow.EmployeeID =MainModule.employeeID;
				settingsRow.EmployeeName = MainModule.empName;
				MainModule.appSettingsData.AppSettings.AddAppSettingsRow(settingsRow);
			}
			else
			{
				MainModule.appSettingsData.AppSettings[0].EmployeeID =MainModule.employeeID;
				MainModule.appSettingsData.AppSettings[0].EmployeeName = MainModule.empName;
			}

			MainModule.mainPOForm.UpdateStatusBar();
            //MainModule.appSettingsData.WriteXml(Application.CommonAppDataPath + "\\AppSettings.xml");
            MainModule.appSettingsData.WriteXml(".\\AppSettings.xml");
        }
		public void SubmitOrders()
		{
			//create two tables to hold Orders and Order Details
			System.Data.DataTable ordersTable = MainModule.pendingOrdersData.Tables["Orders"];
			System.Data.DataTable orderDetailsTable = MainModule.pendingOrdersData.Tables["OrderDetails"];

				if (NorthwindConnection.State != ConnectionState.Open)
				{
					try
					{
						NorthwindConnection.Open();
					}
					catch(Exception Xcp)
					{
						MessageBox.Show("Failed to connect because:\n" + Xcp.ToString() +"\n\nTry a different server name.", "Get from central database", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
			//Update the database. You must call the Update method of the parent Order
			//table first. The Update method retrieves the OrderID generated by the server and assigns it
			//to related rows in the Order Details table.
			try
			{
				MainModule.orderData.OrdersDataAdapter.Update(ordersTable);
				MainModule.orderData.OrderDetailsDataAdapter.Update(orderDetailsTable);
			}
			catch(Exception xcp)
			{
				MessageBox.Show("Update failed because:\n" + xcp.ToString());
				return;
			}

			NorthwindConnection.Close();
			MainModule.pendingOrdersData.Clear();

            //MainModule.pendingOrdersData.WriteXml(Application.CommonAppDataPath + "\\PendingOrders.xml");
            MainModule.pendingOrdersData.WriteXml(".\\PendingOrders.xml");
        }
		
		public void ToggleSound()
		{
			MainModule.appSettingsData.AppSettings[0].SoundOn = MainModule.soundOn;
            //MainModule.appSettingsData.WriteXml(Application.CommonAppDataPath + "\\AppSettings.xml");
            MainModule.appSettingsData.WriteXml(".\\AppSettings.xml");
        }
	}
}
