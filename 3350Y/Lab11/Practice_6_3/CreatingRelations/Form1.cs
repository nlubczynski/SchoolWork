using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CreatingRelations
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DataComponent dataClass = new DataComponent();
		
		private System.Windows.Forms.DataGrid SuppliersDataGrid;
		private System.Windows.Forms.DataGrid ProductsDataGrid;
		private System.Windows.Forms.Button SubmitButton;
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
			this.SuppliersDataGrid = new System.Windows.Forms.DataGrid();
			this.ProductsDataGrid = new System.Windows.Forms.DataGrid();
			this.SubmitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.SuppliersDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// SuppliersDataGrid
			// 
			this.SuppliersDataGrid.DataMember = "";
			this.SuppliersDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.SuppliersDataGrid.Location = new System.Drawing.Point(40, 24);
			this.SuppliersDataGrid.Name = "SuppliersDataGrid";
			this.SuppliersDataGrid.Size = new System.Drawing.Size(440, 136);
			this.SuppliersDataGrid.TabIndex = 0;
			// 
			// ProductsDataGrid
			// 
			this.ProductsDataGrid.DataMember = "";
			this.ProductsDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.ProductsDataGrid.Location = new System.Drawing.Point(40, 176);
			this.ProductsDataGrid.Name = "ProductsDataGrid";
			this.ProductsDataGrid.Size = new System.Drawing.Size(444, 144);
			this.ProductsDataGrid.TabIndex = 1;
			// 
			// SubmitButton
			// 
			this.SubmitButton.Location = new System.Drawing.Point(384, 328);
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.Size = new System.Drawing.Size(88, 23);
			this.SubmitButton.TabIndex = 2;
			this.SubmitButton.Text = "Submit Data";
			this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 366);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.SubmitButton,
																		  this.ProductsDataGrid,
																		  this.SuppliersDataGrid});
			this.Name = "Form1";
			this.Text = "Supplier Products";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.SuppliersDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
			this.ResumeLayout(false);

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
		dataClass.SuppliersSQLDataAdapter.Fill(dataClass.suppliersProductsDataSet1.Suppliers);
		dataClass.ProductsSQLDataAdapter.Fill(dataClass.suppliersProductsDataSet1.Products);

		SuppliersDataGrid.DataSource = dataClass.suppliersProductsDataSet1.Suppliers;
		ProductsDataGrid.DataSource = dataClass.suppliersProductsDataSet1.Products;
		}

		private void SubmitButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				dataClass.SuppliersSQLDataAdapter.Update(dataClass.suppliersProductsDataSet1);
				dataClass.ProductsSQLDataAdapter.Update(dataClass.suppliersProductsDataSet1);
			}
			catch (Exception xcp)
			{
				MessageBox.Show(xcp.ToString());
			}
		}
	}
}
