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
		private System.Data.SqlClient.SqlDataAdapter SalesSQLDataAdapter;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private PopulatingAndUpdateingDataSets.StoreSalesDataSet StoreSalesDataSet1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label CompanyNameLabel;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Windows.Forms.Label CityLabel;
		private System.Windows.Forms.Label StateLabel;
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
            this.SalesSQLDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreSalesDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // SalesSQLDataAdapter
            // 
            this.SalesSQLDataAdapter.SelectCommand = this.sqlSelectCommand1;
            this.SalesSQLDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "sales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("stor_id", "stor_id"),
                        new System.Data.Common.DataColumnMapping("ord_num", "ord_num"),
                        new System.Data.Common.DataColumnMapping("qty", "qty"),
                        new System.Data.Common.DataColumnMapping("ord_date", "ord_date"),
                        new System.Data.Common.DataColumnMapping("payterms", "payterms"),
                        new System.Data.Common.DataColumnMapping("title_id", "title_id"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("stor_name", "stor_name"),
                        new System.Data.Common.DataColumnMapping("city", "city"),
                        new System.Data.Common.DataColumnMapping("state", "state")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@stor_id", System.Data.SqlDbType.VarChar, 4, "stor_id")});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=KADER-PC\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StateLabel);
            this.groupBox1.Controls.Add(this.CityLabel);
            this.groupBox1.Controls.Add(this.CompanyNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(32, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Information";
            // 
            // StateLabel
            // 
            this.StateLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StoreSalesDataSet1, "sales.state", true));
            this.StateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.Location = new System.Drawing.Point(96, 48);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(32, 13);
            this.StateLabel.TabIndex = 2;
            this.StateLabel.Text = "State";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(8, 48);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(28, 13);
            this.CityLabel.TabIndex = 1;
            this.CityLabel.Text = "City";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StoreSalesDataSet1, "sales.stor_name", true));
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(8, 24);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(94, 13);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(560, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.StoresComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Store Orders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreSalesDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
			//Declare and instantiate a SqlDataAdapter, SqlCommand, and a DataTable
            System.Data.SqlClient.SqlDataAdapter storesSQLDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
			System.Data.SqlClient.SqlCommand storesSelectSQLCommand  = new System.Data.SqlClient.SqlCommand();
			DataTable storesTable = new DataTable("Stores");
			//Configure the SqlCommand object and add it to the SQLDataAdapter
			storesSelectSQLCommand.CommandType = CommandType.Text;
			storesSelectSQLCommand.CommandText = "SELECT stor_id, stor_name FROM stores";
			storesSelectSQLCommand.Connection = sqlConnection1;
			storesSQLDataAdapter.SelectCommand = storesSelectSQLCommand;

			try
			{
				//Fill the table using the SQLDataAdapter and add it to the existing DataSet
				storesSQLDataAdapter.Fill(storesTable);
				StoreSalesDataSet1.Tables.Add(storesTable);
			}
			catch (Exception xcp)
			{
				MessageBox.Show(xcp.ToString());
			}
			//TODO 1: Bind CityLabel to the city column programmatically at run time
			
CityLabel.DataBindings.Add("Text",StoreSalesDataSet1.sales,"city");

			//TODO 2: Bind StoresComboBox to the stores table programmatically at run time
			
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
			//Assign storeID to the paremeters collection of SelectCommand 
			//SelectCommand is one of the SQLCommand objects generated by the Data
			//Adapter Configuration Wizard
			 SalesSQLDataAdapter.SelectCommand.Parameters["@stor_id"].Value = storeID;
			//Clear the current sales table of any existing data
			//Because this is a typed DatSet you access the sales table as  a property of the dataset
			//instead of using:
			//StoreSalesDataSet1.Tables["sales"].Clear()
			StoreSalesDataSet1.sales.Clear();

			try
			{
				//Use the DataAdapter to fill the sales table of the StoreSalesDataSet1 DataSet
				SalesSQLDataAdapter.Fill(StoreSalesDataSet1.sales);
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
