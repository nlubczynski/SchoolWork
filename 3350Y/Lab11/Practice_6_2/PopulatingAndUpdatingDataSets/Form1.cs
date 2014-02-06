using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PopulatingAndUpdateingDataSets
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox StoresComboBox;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button UpdateButton;
		private System.Data.SqlClient.SqlDataAdapter SalesSQLDataAdapter;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private PopulatingAndUpdateingDataSets.StoreSalesDataSet StoreSalesDataSet1;
		private System.Data.SqlClient.SqlCommand SalesSQLSelectCommand;
		private System.Data.SqlClient.SqlCommand SalesSQLInsertCommand;
		private System.Data.SqlClient.SqlCommand SalesSQLUpdateCommand;
		private System.Data.SqlClient.SqlCommand SalesSQLDeleteCommand;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.StoresComboBox = new System.Windows.Forms.ComboBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.StoreSalesDataSet1 = new PopulatingAndUpdateingDataSets.StoreSalesDataSet();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SalesSQLDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.SalesSQLDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SalesSQLInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.SalesSQLSelectCommand = new System.Data.SqlClient.SqlCommand();
            this.SalesSQLUpdateCommand = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreSalesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stores";
            // 
            // StoresComboBox
            // 
            this.StoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoresComboBox.Location = new System.Drawing.Point(28, 32);
            this.StoresComboBox.Name = "StoresComboBox";
            this.StoresComboBox.Size = new System.Drawing.Size(148, 21);
            this.StoresComboBox.TabIndex = 1;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "sales";
            this.dataGrid1.DataSource = this.StoreSalesDataSet1;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(28, 64);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(488, 176);
            this.dataGrid1.TabIndex = 2;
            // 
            // StoreSalesDataSet1
            // 
            this.StoreSalesDataSet1.DataSetName = "StoreSalesDataSet";
            this.StoreSalesDataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.StoreSalesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(441, 256);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SalesSQLDataAdapter
            // 
            this.SalesSQLDataAdapter.DeleteCommand = this.SalesSQLDeleteCommand;
            this.SalesSQLDataAdapter.InsertCommand = this.SalesSQLInsertCommand;
            this.SalesSQLDataAdapter.SelectCommand = this.SalesSQLSelectCommand;
            this.SalesSQLDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "sales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("stor_id", "stor_id"),
                        new System.Data.Common.DataColumnMapping("ord_num", "ord_num"),
                        new System.Data.Common.DataColumnMapping("qty", "qty"),
                        new System.Data.Common.DataColumnMapping("ord_date", "ord_date"),
                        new System.Data.Common.DataColumnMapping("payterms", "payterms"),
                        new System.Data.Common.DataColumnMapping("title_id", "title_id")})});
            this.SalesSQLDataAdapter.UpdateCommand = this.SalesSQLUpdateCommand;
            // 
            // SalesSQLDeleteCommand
            // 
            this.SalesSQLDeleteCommand.CommandText = resources.GetString("SalesSQLDeleteCommand.CommandText");
            this.SalesSQLDeleteCommand.Connection = this.sqlConnection1;
            this.SalesSQLDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ord_num", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ord_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_stor_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stor_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_title_id", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "title_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ord_date", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ord_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_payterms", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "payterms", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "qty", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=KADER-PC\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // SalesSQLInsertCommand
            // 
            this.SalesSQLInsertCommand.CommandText = resources.GetString("SalesSQLInsertCommand.CommandText");
            this.SalesSQLInsertCommand.Connection = this.sqlConnection1;
            this.SalesSQLInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@stor_id", System.Data.SqlDbType.VarChar, 4, "stor_id"),
            new System.Data.SqlClient.SqlParameter("@ord_num", System.Data.SqlDbType.VarChar, 20, "ord_num"),
            new System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.SmallInt, 2, "qty"),
            new System.Data.SqlClient.SqlParameter("@ord_date", System.Data.SqlDbType.DateTime, 8, "ord_date"),
            new System.Data.SqlClient.SqlParameter("@payterms", System.Data.SqlDbType.VarChar, 12, "payterms"),
            new System.Data.SqlClient.SqlParameter("@title_id", System.Data.SqlDbType.VarChar, 6, "title_id")});
            // 
            // SalesSQLSelectCommand
            // 
            this.SalesSQLSelectCommand.CommandText = "SELECT stor_id, ord_num, qty, ord_date, payterms, title_id FROM sales WHERE (stor" +
                "_id = @stor_id)";
            this.SalesSQLSelectCommand.Connection = this.sqlConnection1;
            this.SalesSQLSelectCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@stor_id", System.Data.SqlDbType.VarChar, 4, "stor_id")});
            // 
            // SalesSQLUpdateCommand
            // 
            this.SalesSQLUpdateCommand.CommandText = resources.GetString("SalesSQLUpdateCommand.CommandText");
            this.SalesSQLUpdateCommand.Connection = this.sqlConnection1;
            this.SalesSQLUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param1", System.Data.SqlDbType.VarChar, 4, "stor_id"),
            new System.Data.SqlClient.SqlParameter("@ord_num", System.Data.SqlDbType.VarChar, 20, "ord_num"),
            new System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.SmallInt, 2, "qty"),
            new System.Data.SqlClient.SqlParameter("@ord_date", System.Data.SqlDbType.DateTime, 8, "ord_date"),
            new System.Data.SqlClient.SqlParameter("@payterms", System.Data.SqlDbType.VarChar, 12, "payterms"),
            new System.Data.SqlClient.SqlParameter("@title_id", System.Data.SqlDbType.VarChar, 6, "title_id"),
            new System.Data.SqlClient.SqlParameter("@Original_ord_num", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ord_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_stor_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stor_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_title_id", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "title_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ord_date", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ord_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_payterms", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "payterms", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "qty", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@stor_id", System.Data.SqlDbType.VarChar, 4, "stor_id")});
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(544, 294);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.StoresComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Store Orders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreSalesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//TODO 1: Declare and instantiate a SqlDataAdapter, SqlCommand, and a DataTable


			//TODO 2: Configure the SqlCommand object and add it to the SQLDataAdapter


			try
			{
				//TODO 3: Fill the table using the SQLDataAdapter and add it to the existing DataSet


			}
			catch (Exception xcp)
			{
				MessageBox.Show(xcp.ToString());
			}
			//
			StoresComboBox.DataSource = StoreSalesDataSet1.Tables["Stores"];
			//The DisplayMemebr property specifies the field that will be displayed to the user
			StoresComboBox.DisplayMember = "stor_name";
			//The ValueMember property specifies an alternate field 
			StoresComboBox.ValueMember = "stor_id";
			UpdateTable();
			//Create an event handler for the ComboBox's SelectedIndexChanged event
			//after it is bound to the data. This will prevent the event from being 
			//fired each time an item is added to the ComboBox.
			this.StoresComboBox.SelectedIndexChanged += new System.EventHandler(this.StoresComboBox_SelectedIndexChanged);

		}

		private void UpdateTable()
		{
			string storeID;
			storeID = StoresComboBox.SelectedValue.ToString();
			//TODO 4: Assign storeID to the paremeters collection of SelectCommand 
			//SelectCommand is one of the SQLCommand objects generated by the Data
			//Adapter Configuration Wizard


 
			//TODO 5: Clear the current sales table of any existing data
			//Because this is a typed DatSet you access the sales table as  a property of the dataset
			//instead of using:
			//StoreSalesDataSet1.Tables["sales"].Clear()
 

			try
			{
				//TODO 6: Use the DataAdapter to fill the sales table of the StoreSalesDataSet1 DataSet
 
            
            }
			catch (Exception xcp)
			{
				MessageBox.Show(xcp.ToString());
            }
		}

		private void UpdateButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				//TODO 7: Use the Update method of the DataAdapter and pass it a copy of the StoreSalesDataSet1 DataSet

            
            
            }
			catch (Exception xcp)
			{
				MessageBox.Show(xcp.ToString());
			}
		}

		private void StoresComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateTable();
		}
	}
}
