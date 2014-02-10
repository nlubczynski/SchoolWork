using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace PurchaseOrder
{
	/// <summary>
	/// Summary description for OrderItemControl.
	/// </summary>
	public class OrderItemControl : System.Windows.Forms.UserControl
	{
		internal NumericTextBox.NumericTextBox QuantityNumericTextBox;
		internal System.Windows.Forms.TextBox QuantityPerUnitTextBox;
		internal System.Windows.Forms.TextBox DiscountTextBox;
		internal System.Windows.Forms.TextBox UnitPriceTextBox;
		internal System.Windows.Forms.ComboBox ProductNameComboBox;
		private System.ComponentModel.IContainer components;

		public OrderItemControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.QuantityPerUnitTextBox = new System.Windows.Forms.TextBox();
			this.DiscountTextBox = new System.Windows.Forms.TextBox();
			this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
			this.ProductNameComboBox = new System.Windows.Forms.ComboBox();
			this.QuantityNumericTextBox = new NumericTextBox.NumericTextBox(this.components);
			this.SuspendLayout();
			// 
			// UnitPriceTextBox
			// 
			this.UnitPriceTextBox.Enabled = false;
			this.UnitPriceTextBox.Location = new System.Drawing.Point(392, 0);
			this.UnitPriceTextBox.Name = "UnitPriceTextBox";
			this.UnitPriceTextBox.ReadOnly = true;
			this.UnitPriceTextBox.Size = new System.Drawing.Size(72, 20);
			this.UnitPriceTextBox.TabIndex = 2;
			this.UnitPriceTextBox.Text = "";
			this.UnitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// DiscountTextBox
			// 
			this.DiscountTextBox.Location = new System.Drawing.Point(464, 0);
			this.DiscountTextBox.Name = "DiscountTextBox";
			this.DiscountTextBox.Size = new System.Drawing.Size(64, 20);
			this.DiscountTextBox.TabIndex = 3;
			this.DiscountTextBox.Text = "";
			this.DiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.DiscountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DiscountTextBox_Validating);
			// 
			// QuantityPerUnitTextBox
			// 
			this.QuantityPerUnitTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.QuantityPerUnitTextBox.Enabled = false;
			this.QuantityPerUnitTextBox.Location = new System.Drawing.Point(528, 0);
			this.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox";
			this.QuantityPerUnitTextBox.Size = new System.Drawing.Size(80, 20);
			this.QuantityPerUnitTextBox.TabIndex = 4;
			this.QuantityPerUnitTextBox.Text = "";
			// 
			// ProductNameComboBox
			// 
			this.ProductNameComboBox.DisplayMember = "ProductName";
			this.ProductNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ProductNameComboBox.DropDownWidth = 121;
			this.ProductNameComboBox.Location = new System.Drawing.Point(72, 0);
			this.ProductNameComboBox.Name = "ProductNameComboBox";
			this.ProductNameComboBox.Size = new System.Drawing.Size(320, 21);
			this.ProductNameComboBox.TabIndex = 1;
			this.ProductNameComboBox.ValueMember = "ProductID";
			this.ProductNameComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductNameComboBox_KeyPress);
			// 
			// QuantityNumericTextBox
			// 
			this.QuantityNumericTextBox.Name = "QuantityNumericTextBox";
			this.QuantityNumericTextBox.Size = new System.Drawing.Size(72, 20);
			this.QuantityNumericTextBox.TabIndex = 5;
			this.QuantityNumericTextBox.Text = "";
			this.QuantityNumericTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// OrderItemControl
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.QuantityNumericTextBox,
																		  this.QuantityPerUnitTextBox,
																		  this.DiscountTextBox,
																		  this.UnitPriceTextBox,
																		  this.ProductNameComboBox});
			this.Name = "OrderItemControl";
			this.Size = new System.Drawing.Size(616, 24);
			this.ResumeLayout(false);

		}
		#endregion

		public int OrderQuantity
		{
			get
			{
				return Convert.ToInt32(QuantityNumericTextBox.Text);
			}
			set
			{
				QuantityNumericTextBox.Text = value.ToString();
			}
		}
		
		public string OrderProductName
		{
			get
			{
				return ProductNameComboBox.Text;
			}
			set
			{
				ProductNameComboBox.Text = value;
			}

		}
		public string OrderPrice
		{
			get
			{
				return UnitPriceTextBox.Text;
			}
			set
			{
				UnitPriceTextBox.Text = string.Format("{0:C}",value);
			}
		}
		public string OrderDiscount
		{
			get
			{
				return DiscountTextBox.Text;
			}
			set
			{
				DiscountTextBox.Text = value;
			}
		}
		public string OrderQuantityPerUnit
		{
			get
			{
				return QuantityPerUnitTextBox.Text;
			}
			set
			{
				QuantityPerUnitTextBox.Text = value;
			}
		}
		public string OrderProductID
		{
			get
			{
				return ProductNameComboBox.SelectedValue.ToString();
			}
			set
			{
				// why is this empty - is it supposed to be readonly?
			}														
		}
		
		public void GetProductData(System.Data.DataTable productsTable)
		{
			//this function binds the controls to the Products data
			//TODO 1: Assign the DataSource of ProductNameComboBox to the DataTable passed
			//to the GetProductData procedure. Assign the DisplayMember and ValueMember of
			//ProductNameComboBox to the ProductName and ProductID columns respectively.
            ProductNameComboBox.DataSource = productsTable;
            //ProductNameComboBox.DisplayMember = productsTable.Columns["productName"];

			//create an explicit binding object for the UnitPrice. This is neccesaary 
			//to expose the Format event of the Binding object
			//TODO 2: Declare a Binding object and use it to bind the Text property of  
			//UnitPriceTextBox to the UnitPrice column of the DataTable passed 
			//to the GetProductData procedure.			


 

			//add a handler for the Format event so you can call the DecimalToCurrency procedure
			//to convert the values display to currency
			//TODO 4: Create an event handler for Format event of the Binding object created in TODO 2. 
			//Assign it to the DecimalToCurrency procedure.

 

			QuantityPerUnitTextBox.DataBindings.Add("Text", productsTable, "QuantityPerUnit");
		}
		//TODO 3: Create a event procedure named DecimalToCurrency that converts the ConvertEventArgs
		//event argument to a Currency format

 


		
		// It is not recommended to override Finalize directly - use a d'tor instead
		~OrderItemControl()
		{
			//the base destructor will be called automatically
		}


		private void ProductNameComboBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//use the FindString method to select an item in the ProductNameComboBox with a value
			//beginning the character typed by the user
			ComboBox cbSender = sender as ComboBox;
			int index;
			index = cbSender.FindString(e.KeyChar.ToString());

			if (index >= 0)
			{
				cbSender.SelectedIndex = index;
			}
		}

		public ContextMenu QuantityTextBox_ContextMenu
		{
			get
			{
				//the TextBox control exposes the system Cut, Copy, Paste ContextMenu by default.
				//to modify this behaviour you must explicitly expose the QuantityTextBox 
				//ContextMenu property to parent controls
				return QuantityNumericTextBox.ContextMenu;
			}
			set
			{
				QuantityNumericTextBox.ContextMenu = value;
			}
		}

		public ContextMenu DiscountTextBox_ContextMenu
		{
			get
			{
				//the TextBox control exposes the system Cut, Copy, Paste ContextMenu by default.
				//to modify this behaviour you must explicitly expose the DiscountTextBox 
				//ContextMenu property to parent controls
				return DiscountTextBox.ContextMenu;
			}
			set
			{
				DiscountTextBox.ContextMenu = value;
			}
		}
														  
		private void DiscountTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//if no value is entered, set the Text to "0.00%"
			if (DiscountTextBox.Text == "" )
			{
				DiscountTextBox.Text = "0.00%";
				return;
			}
			string discountValue;
			int percentSymbolPlaceHolder;
			try
			{
				//remove the % sign from the Discount value and convert it to a decimal value
				discountValue = DiscountTextBox.Text;
				percentSymbolPlaceHolder = discountValue.IndexOf("%");
				if( percentSymbolPlaceHolder >= 0)
				{
					discountValue = discountValue.Remove(percentSymbolPlaceHolder, 1);
				}
				//if the value is less then 0, set the Text to "0.00%"
				if (Convert.ToInt32(discountValue) < 0)
				{
					DiscountTextBox.Text = "0.00%";
				}
				//if the value is greater then 1, set the Text to "100.00%"
				if (Convert.ToInt32(discountValue) > 1)
				{
					DiscountTextBox.Text = "100.00%";
				}
			}
			catch
			{
				//if there are any exceptions, set the Text to "0.00%"
				DiscountTextBox.Text = "0.00%";
			}
			//format the value entered to a Percent
			DiscountTextBox.Text = string.Format("{0:P}",DiscountTextBox.Text);

		}

	}
}
