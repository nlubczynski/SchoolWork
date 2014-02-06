using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.IO;


namespace PurchaseOrder
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		// use an instance of a custom PrintDocument class
		private NorthwindForms.PrintingForm2555Class form2555Document = new NorthwindForms.PrintingForm2555Class();

		// settings for the printer
		private PageSettings form2555PageSettings;

		//used to increment the Y coordinate for new ProductOrder controls
		private int yPositionOrderItemControl;

		internal OrderItemControl/*WithEvents*/ tempProductOrder;


		private System.Windows.Forms.ContextMenu ProductContextMenu;
		private System.Windows.Forms.MenuItem DeleteOrderItemMenuItem;
		private System.Windows.Forms.MenuItem DeleteAllOrderItemsMenuItem;
		private System.Windows.Forms.Label CustomerCountryLabel;
		internal System.Windows.Forms.MenuItem HelpAboutMenu;
		private System.Windows.Forms.Label UnitPriceLabel;
		private System.Windows.Forms.Button SaveOrderButton;
		private System.Windows.Forms.DateTimePicker RequiredDateDateTimePicker;
		private System.Windows.Forms.TextBox CustomerCityTextBox;
		private System.Windows.Forms.TextBox ShipToAddressTextBox;
		internal System.Windows.Forms.MenuItem DataSubmitMenuItem;
		private System.Windows.Forms.Label CustomerCityLabel;
		internal System.Windows.Forms.MenuItem FilePrintMenuItem;
		private System.Windows.Forms.Label ShipToCountryLabel;
		private System.Windows.Forms.MenuItem mnuFileSep1;
		private System.Windows.Forms.Label DiscountLabel;
		private System.Windows.Forms.DateTimePicker OrderDateDateTimePicker;
		internal System.Windows.Forms.MenuItem FilePrintPreviewMenuItem;
		private System.Windows.Forms.TextBox ShipToPostalCodeTextBox;
		private System.Windows.Forms.TextBox ShipToCityTextBox;
		private System.Windows.Forms.Label ProductDescriptionLabel;
		private System.Windows.Forms.Label CustomerPostalCodeLabel;
		private System.Windows.Forms.Label NWTradersLabel;
		private System.Windows.Forms.ComboBox CustomersComboBox;
		private System.Windows.Forms.MainMenu POMainMenu;
		internal System.Windows.Forms.MenuItem FileMenuItem;
		internal System.Windows.Forms.MenuItem FilePageSetupMenuItem;
		internal System.Windows.Forms.MenuItem FileExitMenuItem;
		internal System.Windows.Forms.MenuItem ViewMenuItem;
		internal System.Windows.Forms.MenuItem ViewSubmittedOrdersMenuItem;
		internal System.Windows.Forms.MenuItem ViewUnsubmittedOrdersMenuItem;
		private System.Windows.Forms.MenuItem DataMenuItem;
		internal System.Windows.Forms.MenuItem DataRefreshMenuItem;
		internal System.Windows.Forms.MenuItem ToolsMenuItem;
		internal System.Windows.Forms.MenuItem ToolsOptionMenuItem;
		internal System.Windows.Forms.MenuItem HelpMenuItem;
		private System.Windows.Forms.TextBox ShipToCountryTextBox;
		private System.Windows.Forms.Label ShipToRegionLabel;
		private System.Windows.Forms.Label ShipToLabel;
		private System.Windows.Forms.Label CustomerRegionLabel;
		private System.Windows.Forms.Label QuantityLabel;
		private System.Windows.Forms.Label CustomerLabel;
		private System.Windows.Forms.FontDialog FontDialog1;
		private System.Windows.Forms.Label NWTradersAddressLabel;
		private System.Windows.Forms.Panel ProductOrderPanel;
		internal System.Windows.Forms.Button NewOrderItemButton;
		private System.Windows.Forms.Label ShipToCityLabel;
		private System.Windows.Forms.TextBox CustomerAddressTextBox;
		private System.Windows.Forms.TextBox CustomerCountryTextBox;
		internal System.Windows.Forms.ListBox ShipViaListBox;
		private System.Windows.Forms.Label UnitSizeLabel;
		private System.Windows.Forms.Label ShipToAddressLabel;
		private System.Windows.Forms.TextBox ShipToNameTextBox;
		private System.Windows.Forms.Label OrderDateLabel;
		private System.Windows.Forms.Label RequiredDateLabel;
		private System.Windows.Forms.StatusBar PendingOrdersStatusBar;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		private System.Windows.Forms.Label ShipToPostalCodeLabel;
		private System.Windows.Forms.Label CustomerAddressLabel;
		private System.Windows.Forms.TextBox ShipToRegionTextBox;
		private System.Windows.Forms.Label ShippingMethodLabel;
		private System.Drawing.Printing.PrintDocument PrintDocument1;
		private System.Windows.Forms.TextBox CustomerRegionTextBox;
		private System.Windows.Forms.TextBox CustomerPostalCodeTextBox;
		internal System.Windows.Forms.ToolBar POToolBar;
		internal System.Windows.Forms.ToolBarButton RefreshToolBarButton;
		internal System.Windows.Forms.ToolBarButton AddOrderItemToolBarButton;
		internal System.Windows.Forms.ToolBarButton SaveOrderToolbarButton;
		internal System.Windows.Forms.ToolBarButton SubmitToolBarButton;
		internal System.Windows.Forms.ToolBarButton ViewUnsubmittedToolBarButton;
		internal System.Windows.Forms.ToolBarButton ViewSubmittedToolBarButton;
		internal System.Windows.Forms.ImageList POImageList;
		internal System.Windows.Forms.ToolBarButton PrintPreviewToolBarButton;
		private System.ComponentModel.IContainer components;

		public MainForm()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProductContextMenu = new System.Windows.Forms.ContextMenu();
            this.DeleteOrderItemMenuItem = new System.Windows.Forms.MenuItem();
            this.DeleteAllOrderItemsMenuItem = new System.Windows.Forms.MenuItem();
            this.CustomerCountryLabel = new System.Windows.Forms.Label();
            this.HelpAboutMenu = new System.Windows.Forms.MenuItem();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.SaveOrderButton = new System.Windows.Forms.Button();
            this.RequiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomerCityTextBox = new System.Windows.Forms.TextBox();
            this.ShipToAddressTextBox = new System.Windows.Forms.TextBox();
            this.DataSubmitMenuItem = new System.Windows.Forms.MenuItem();
            this.CustomerCityLabel = new System.Windows.Forms.Label();
            this.FilePrintMenuItem = new System.Windows.Forms.MenuItem();
            this.ShipToCountryLabel = new System.Windows.Forms.Label();
            this.mnuFileSep1 = new System.Windows.Forms.MenuItem();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.OrderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FilePrintPreviewMenuItem = new System.Windows.Forms.MenuItem();
            this.ShipToPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.ShipToCityTextBox = new System.Windows.Forms.TextBox();
            this.ProductDescriptionLabel = new System.Windows.Forms.Label();
            this.CustomerPostalCodeLabel = new System.Windows.Forms.Label();
            this.NWTradersLabel = new System.Windows.Forms.Label();
            this.CustomersComboBox = new System.Windows.Forms.ComboBox();
            this.POMainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenuItem = new System.Windows.Forms.MenuItem();
            this.FilePageSetupMenuItem = new System.Windows.Forms.MenuItem();
            this.FileExitMenuItem = new System.Windows.Forms.MenuItem();
            this.ViewMenuItem = new System.Windows.Forms.MenuItem();
            this.ViewSubmittedOrdersMenuItem = new System.Windows.Forms.MenuItem();
            this.ViewUnsubmittedOrdersMenuItem = new System.Windows.Forms.MenuItem();
            this.DataMenuItem = new System.Windows.Forms.MenuItem();
            this.DataRefreshMenuItem = new System.Windows.Forms.MenuItem();
            this.ToolsMenuItem = new System.Windows.Forms.MenuItem();
            this.ToolsOptionMenuItem = new System.Windows.Forms.MenuItem();
            this.HelpMenuItem = new System.Windows.Forms.MenuItem();
            this.ShipToCountryTextBox = new System.Windows.Forms.TextBox();
            this.ShipToRegionLabel = new System.Windows.Forms.Label();
            this.ShipToLabel = new System.Windows.Forms.Label();
            this.CustomerRegionLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.FontDialog1 = new System.Windows.Forms.FontDialog();
            this.NWTradersAddressLabel = new System.Windows.Forms.Label();
            this.ProductOrderPanel = new System.Windows.Forms.Panel();
            this.NewOrderItemButton = new System.Windows.Forms.Button();
            this.ShipToCityLabel = new System.Windows.Forms.Label();
            this.CustomerAddressTextBox = new System.Windows.Forms.TextBox();
            this.CustomerCountryTextBox = new System.Windows.Forms.TextBox();
            this.ShipViaListBox = new System.Windows.Forms.ListBox();
            this.UnitSizeLabel = new System.Windows.Forms.Label();
            this.ShipToAddressLabel = new System.Windows.Forms.Label();
            this.ShipToNameTextBox = new System.Windows.Forms.TextBox();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.RequiredDateLabel = new System.Windows.Forms.Label();
            this.PendingOrdersStatusBar = new System.Windows.Forms.StatusBar();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ShipToPostalCodeLabel = new System.Windows.Forms.Label();
            this.CustomerAddressLabel = new System.Windows.Forms.Label();
            this.ShipToRegionTextBox = new System.Windows.Forms.TextBox();
            this.ShippingMethodLabel = new System.Windows.Forms.Label();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.CustomerRegionTextBox = new System.Windows.Forms.TextBox();
            this.CustomerPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.POToolBar = new System.Windows.Forms.ToolBar();
            this.RefreshToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.AddOrderItemToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.SaveOrderToolbarButton = new System.Windows.Forms.ToolBarButton();
            this.PrintPreviewToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.SubmitToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.ViewUnsubmittedToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.ViewSubmittedToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.POImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ProductContextMenu
            // 
            this.ProductContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.DeleteOrderItemMenuItem,
            this.DeleteAllOrderItemsMenuItem});
            // 
            // DeleteOrderItemMenuItem
            // 
            this.DeleteOrderItemMenuItem.Index = 0;
            this.DeleteOrderItemMenuItem.Text = "Delete";
            this.DeleteOrderItemMenuItem.Click += new System.EventHandler(this.DeleteOrderItemMenuItem_Click);
            // 
            // DeleteAllOrderItemsMenuItem
            // 
            this.DeleteAllOrderItemsMenuItem.Index = 1;
            this.DeleteAllOrderItemsMenuItem.Text = "Delete All";
            this.DeleteAllOrderItemsMenuItem.Click += new System.EventHandler(this.DeleteAllOrderItemsMenuItem_Click);
            // 
            // CustomerCountryLabel
            // 
            this.CustomerCountryLabel.Location = new System.Drawing.Point(328, 144);
            this.CustomerCountryLabel.Name = "CustomerCountryLabel";
            this.CustomerCountryLabel.Size = new System.Drawing.Size(48, 20);
            this.CustomerCountryLabel.TabIndex = 67;
            this.CustomerCountryLabel.Text = "Country";
            this.CustomerCountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HelpAboutMenu
            // 
            this.HelpAboutMenu.Index = 0;
            this.HelpAboutMenu.Text = "&About...";
            this.HelpAboutMenu.Click += new System.EventHandler(this.HelpAboutMenu_Click);
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UnitPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceLabel.Location = new System.Drawing.Point(464, 296);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(72, 24);
            this.UnitPriceLabel.TabIndex = 40;
            this.UnitPriceLabel.Text = "Unit Price";
            this.UnitPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveOrderButton
            // 
            this.SaveOrderButton.Enabled = false;
            this.SaveOrderButton.Location = new System.Drawing.Point(600, 512);
            this.SaveOrderButton.Name = "SaveOrderButton";
            this.SaveOrderButton.Size = new System.Drawing.Size(96, 23);
            this.SaveOrderButton.TabIndex = 76;
            this.SaveOrderButton.Text = "Save Order";
            this.SaveOrderButton.Click += new System.EventHandler(this.SaveOrderButton_Click);
            // 
            // RequiredDateDateTimePicker
            // 
            this.RequiredDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RequiredDateDateTimePicker.Location = new System.Drawing.Point(592, 96);
            this.RequiredDateDateTimePicker.Name = "RequiredDateDateTimePicker";
            this.RequiredDateDateTimePicker.Size = new System.Drawing.Size(88, 20);
            this.RequiredDateDateTimePicker.TabIndex = 54;
            this.RequiredDateDateTimePicker.Value = new System.DateTime(2008, 2, 16, 0, 0, 0, 0);
            this.RequiredDateDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredDateDateTimePicker_Validating);
            // 
            // CustomerCityTextBox
            // 
            this.CustomerCityTextBox.Enabled = false;
            this.CustomerCityTextBox.Location = new System.Drawing.Point(168, 120);
            this.CustomerCityTextBox.Name = "CustomerCityTextBox";
            this.CustomerCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerCityTextBox.TabIndex = 46;
            // 
            // ShipToAddressTextBox
            // 
            this.ShipToAddressTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ShipToAddressTextBox.Location = new System.Drawing.Point(168, 208);
            this.ShipToAddressTextBox.Name = "ShipToAddressTextBox";
            this.ShipToAddressTextBox.Size = new System.Drawing.Size(312, 20);
            this.ShipToAddressTextBox.TabIndex = 51;
            // 
            // DataSubmitMenuItem
            // 
            this.DataSubmitMenuItem.Enabled = false;
            this.DataSubmitMenuItem.Index = 1;
            this.DataSubmitMenuItem.Text = "&Submit Data";
            this.DataSubmitMenuItem.Click += new System.EventHandler(this.DataSubmitMenuItem_Click);
            // 
            // CustomerCityLabel
            // 
            this.CustomerCityLabel.Location = new System.Drawing.Point(72, 120);
            this.CustomerCityLabel.Name = "CustomerCityLabel";
            this.CustomerCityLabel.Size = new System.Drawing.Size(88, 20);
            this.CustomerCityLabel.TabIndex = 58;
            this.CustomerCityLabel.Text = "City";
            this.CustomerCityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilePrintMenuItem
            // 
            this.FilePrintMenuItem.Index = 2;
            this.FilePrintMenuItem.Text = "&Print...";
            this.FilePrintMenuItem.Click += new System.EventHandler(this.FilePrintMenuItem_Click);
            // 
            // ShipToCountryLabel
            // 
            this.ShipToCountryLabel.Location = new System.Drawing.Point(328, 256);
            this.ShipToCountryLabel.Name = "ShipToCountryLabel";
            this.ShipToCountryLabel.Size = new System.Drawing.Size(48, 20);
            this.ShipToCountryLabel.TabIndex = 66;
            this.ShipToCountryLabel.Text = "Country";
            this.ShipToCountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuFileSep1
            // 
            this.mnuFileSep1.Index = 3;
            this.mnuFileSep1.Text = "-";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.Location = new System.Drawing.Point(536, 296);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(64, 24);
            this.DiscountLabel.TabIndex = 43;
            this.DiscountLabel.Text = "Discount";
            this.DiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderDateDateTimePicker
            // 
            this.OrderDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OrderDateDateTimePicker.Location = new System.Drawing.Point(592, 72);
            this.OrderDateDateTimePicker.Name = "OrderDateDateTimePicker";
            this.OrderDateDateTimePicker.Size = new System.Drawing.Size(88, 20);
            this.OrderDateDateTimePicker.TabIndex = 53;
            this.OrderDateDateTimePicker.Value = new System.DateTime(2008, 2, 16, 0, 0, 0, 0);
            this.OrderDateDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.OrderDateDateTimePicker_Validating);
            // 
            // FilePrintPreviewMenuItem
            // 
            this.FilePrintPreviewMenuItem.Index = 1;
            this.FilePrintPreviewMenuItem.Text = "Print Pre&view";
            this.FilePrintPreviewMenuItem.Click += new System.EventHandler(this.FilePrintPreviewMenuItem_Click);
            // 
            // ShipToPostalCodeTextBox
            // 
            this.ShipToPostalCodeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ShipToPostalCodeTextBox.Location = new System.Drawing.Point(168, 256);
            this.ShipToPostalCodeTextBox.Name = "ShipToPostalCodeTextBox";
            this.ShipToPostalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipToPostalCodeTextBox.TabIndex = 71;
            // 
            // ShipToCityTextBox
            // 
            this.ShipToCityTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ShipToCityTextBox.Location = new System.Drawing.Point(168, 232);
            this.ShipToCityTextBox.Name = "ShipToCityTextBox";
            this.ShipToCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipToCityTextBox.TabIndex = 52;
            // 
            // ProductDescriptionLabel
            // 
            this.ProductDescriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDescriptionLabel.Location = new System.Drawing.Point(144, 296);
            this.ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            this.ProductDescriptionLabel.Size = new System.Drawing.Size(320, 24);
            this.ProductDescriptionLabel.TabIndex = 42;
            this.ProductDescriptionLabel.Text = "Product Description";
            this.ProductDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerPostalCodeLabel
            // 
            this.CustomerPostalCodeLabel.Location = new System.Drawing.Point(72, 144);
            this.CustomerPostalCodeLabel.Name = "CustomerPostalCodeLabel";
            this.CustomerPostalCodeLabel.Size = new System.Drawing.Size(88, 20);
            this.CustomerPostalCodeLabel.TabIndex = 62;
            this.CustomerPostalCodeLabel.Text = "Postal Code";
            this.CustomerPostalCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NWTradersLabel
            // 
            this.NWTradersLabel.AutoSize = true;
            this.NWTradersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NWTradersLabel.Location = new System.Drawing.Point(72, 40);
            this.NWTradersLabel.Name = "NWTradersLabel";
            this.NWTradersLabel.Size = new System.Drawing.Size(213, 26);
            this.NWTradersLabel.TabIndex = 44;
            this.NWTradersLabel.Text = "Northwind Traders ";
            this.NWTradersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomersComboBox
            // 
            this.CustomersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomersComboBox.DropDownWidth = 312;
            this.CustomersComboBox.ItemHeight = 13;
            this.CustomersComboBox.Location = new System.Drawing.Point(168, 72);
            this.CustomersComboBox.Name = "CustomersComboBox";
            this.CustomersComboBox.Size = new System.Drawing.Size(312, 21);
            this.CustomersComboBox.TabIndex = 37;
            this.CustomersComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomersComboBox_KeyPress);
            // 
            // POMainMenu
            // 
            this.POMainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenuItem,
            this.ViewMenuItem,
            this.DataMenuItem,
            this.ToolsMenuItem,
            this.HelpMenuItem});
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.Index = 0;
            this.FileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FilePageSetupMenuItem,
            this.FilePrintPreviewMenuItem,
            this.FilePrintMenuItem,
            this.mnuFileSep1,
            this.FileExitMenuItem});
            this.FileMenuItem.Text = "&File";
            // 
            // FilePageSetupMenuItem
            // 
            this.FilePageSetupMenuItem.Index = 0;
            this.FilePageSetupMenuItem.Text = "Page Set&up...";
            this.FilePageSetupMenuItem.Click += new System.EventHandler(this.FilePageSetupMenuItem_Click);
            // 
            // FileExitMenuItem
            // 
            this.FileExitMenuItem.Index = 4;
            this.FileExitMenuItem.Text = "E&xit";
            this.FileExitMenuItem.Click += new System.EventHandler(this.FileExitMenuItem_Click);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.Index = 1;
            this.ViewMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ViewSubmittedOrdersMenuItem,
            this.ViewUnsubmittedOrdersMenuItem});
            this.ViewMenuItem.Text = "&View";
            // 
            // ViewSubmittedOrdersMenuItem
            // 
            this.ViewSubmittedOrdersMenuItem.Enabled = false;
            this.ViewSubmittedOrdersMenuItem.Index = 0;
            this.ViewSubmittedOrdersMenuItem.Text = "View &Submitted Orders";
            this.ViewSubmittedOrdersMenuItem.Click += new System.EventHandler(this.ViewSubmittedOrdersMenuItem_Click);
            // 
            // ViewUnsubmittedOrdersMenuItem
            // 
            this.ViewUnsubmittedOrdersMenuItem.Enabled = false;
            this.ViewUnsubmittedOrdersMenuItem.Index = 1;
            this.ViewUnsubmittedOrdersMenuItem.Text = "View &Unsubmitted Orders";
            this.ViewUnsubmittedOrdersMenuItem.Click += new System.EventHandler(this.ViewUnsubmittedOrdersMenuItem_Click);
            // 
            // DataMenuItem
            // 
            this.DataMenuItem.Index = 2;
            this.DataMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.DataRefreshMenuItem,
            this.DataSubmitMenuItem});
            this.DataMenuItem.Text = "D&ata";
            // 
            // DataRefreshMenuItem
            // 
            this.DataRefreshMenuItem.Index = 0;
            this.DataRefreshMenuItem.Text = "&Refresh Data";
            this.DataRefreshMenuItem.Click += new System.EventHandler(this.DataRefreshMenuItem_Click);
            // 
            // ToolsMenuItem
            // 
            this.ToolsMenuItem.Index = 3;
            this.ToolsMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ToolsOptionMenuItem});
            this.ToolsMenuItem.Text = "&Tools";
            // 
            // ToolsOptionMenuItem
            // 
            this.ToolsOptionMenuItem.Index = 0;
            this.ToolsOptionMenuItem.Text = "&Options...";
            this.ToolsOptionMenuItem.Click += new System.EventHandler(this.ToolsOptionMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Index = 4;
            this.HelpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.HelpAboutMenu});
            this.HelpMenuItem.Text = "&Help";
            // 
            // ShipToCountryTextBox
            // 
            this.ShipToCountryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ShipToCountryTextBox.Location = new System.Drawing.Point(380, 256);
            this.ShipToCountryTextBox.Name = "ShipToCountryTextBox";
            this.ShipToCountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipToCountryTextBox.TabIndex = 72;
            // 
            // ShipToRegionLabel
            // 
            this.ShipToRegionLabel.Location = new System.Drawing.Point(296, 232);
            this.ShipToRegionLabel.Name = "ShipToRegionLabel";
            this.ShipToRegionLabel.Size = new System.Drawing.Size(80, 20);
            this.ShipToRegionLabel.TabIndex = 70;
            this.ShipToRegionLabel.Text = "Region/State";
            this.ShipToRegionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShipToLabel
            // 
            this.ShipToLabel.Location = new System.Drawing.Point(72, 184);
            this.ShipToLabel.Name = "ShipToLabel";
            this.ShipToLabel.Size = new System.Drawing.Size(88, 17);
            this.ShipToLabel.TabIndex = 60;
            this.ShipToLabel.Text = "Ship To";
            this.ShipToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerRegionLabel
            // 
            this.CustomerRegionLabel.Location = new System.Drawing.Point(296, 120);
            this.CustomerRegionLabel.Name = "CustomerRegionLabel";
            this.CustomerRegionLabel.Size = new System.Drawing.Size(80, 20);
            this.CustomerRegionLabel.TabIndex = 63;
            this.CustomerRegionLabel.Text = "Region/State";
            this.CustomerRegionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.QuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(72, 296);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(72, 24);
            this.QuantityLabel.TabIndex = 38;
            this.QuantityLabel.Text = "Quantity";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.Location = new System.Drawing.Point(72, 72);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(88, 20);
            this.CustomerLabel.TabIndex = 57;
            this.CustomerLabel.Text = "To";
            this.CustomerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NWTradersAddressLabel
            // 
            this.NWTradersAddressLabel.AutoSize = true;
            this.NWTradersAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NWTradersAddressLabel.Location = new System.Drawing.Point(272, 48);
            this.NWTradersAddressLabel.Name = "NWTradersAddressLabel";
            this.NWTradersAddressLabel.Size = new System.Drawing.Size(244, 13);
            this.NWTradersAddressLabel.TabIndex = 45;
            this.NWTradersAddressLabel.Text = " - 2001 Slater Blvd, Matthew,  WA  91201";
            this.NWTradersAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductOrderPanel
            // 
            this.ProductOrderPanel.AutoScroll = true;
            this.ProductOrderPanel.Location = new System.Drawing.Point(72, 320);
            this.ProductOrderPanel.Name = "ProductOrderPanel";
            this.ProductOrderPanel.Size = new System.Drawing.Size(624, 184);
            this.ProductOrderPanel.TabIndex = 73;
            // 
            // NewOrderItemButton
            // 
            this.NewOrderItemButton.Enabled = false;
            this.NewOrderItemButton.Location = new System.Drawing.Point(496, 512);
            this.NewOrderItemButton.Name = "NewOrderItemButton";
            this.NewOrderItemButton.Size = new System.Drawing.Size(96, 23);
            this.NewOrderItemButton.TabIndex = 74;
            this.NewOrderItemButton.Text = "New Order Item";
            this.NewOrderItemButton.Click += new System.EventHandler(this.CreateNewRow);
            // 
            // ShipToCityLabel
            // 
            this.ShipToCityLabel.Location = new System.Drawing.Point(72, 232);
            this.ShipToCityLabel.Name = "ShipToCityLabel";
            this.ShipToCityLabel.Size = new System.Drawing.Size(88, 20);
            this.ShipToCityLabel.TabIndex = 59;
            this.ShipToCityLabel.Text = "City";
            this.ShipToCityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerAddressTextBox
            // 
            this.CustomerAddressTextBox.Enabled = false;
            this.CustomerAddressTextBox.Location = new System.Drawing.Point(168, 96);
            this.CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            this.CustomerAddressTextBox.Size = new System.Drawing.Size(312, 20);
            this.CustomerAddressTextBox.TabIndex = 39;
            // 
            // CustomerCountryTextBox
            // 
            this.CustomerCountryTextBox.Enabled = false;
            this.CustomerCountryTextBox.Location = new System.Drawing.Point(380, 144);
            this.CustomerCountryTextBox.Name = "CustomerCountryTextBox";
            this.CustomerCountryTextBox.ReadOnly = true;
            this.CustomerCountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerCountryTextBox.TabIndex = 68;
            // 
            // ShipViaListBox
            // 
            this.ShipViaListBox.ColumnWidth = 24;
            this.ShipViaListBox.Items.AddRange(new object[] {
            "Overnight",
            "Second Day",
            "Standard"});
            this.ShipViaListBox.Location = new System.Drawing.Point(592, 128);
            this.ShipViaListBox.Name = "ShipViaListBox";
            this.ShipViaListBox.Size = new System.Drawing.Size(88, 17);
            this.ShipViaListBox.TabIndex = 75;
            // 
            // UnitSizeLabel
            // 
            this.UnitSizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UnitSizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitSizeLabel.Location = new System.Drawing.Point(600, 296);
            this.UnitSizeLabel.Name = "UnitSizeLabel";
            this.UnitSizeLabel.Size = new System.Drawing.Size(80, 24);
            this.UnitSizeLabel.TabIndex = 41;
            this.UnitSizeLabel.Text = "Unit Size";
            this.UnitSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShipToAddressLabel
            // 
            this.ShipToAddressLabel.Location = new System.Drawing.Point(72, 208);
            this.ShipToAddressLabel.Name = "ShipToAddressLabel";
            this.ShipToAddressLabel.Size = new System.Drawing.Size(88, 20);
            this.ShipToAddressLabel.TabIndex = 55;
            this.ShipToAddressLabel.Text = "Address";
            this.ShipToAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShipToNameTextBox
            // 
            this.ShipToNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ShipToNameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ShipToNameTextBox.Location = new System.Drawing.Point(168, 184);
            this.ShipToNameTextBox.Name = "ShipToNameTextBox";
            this.ShipToNameTextBox.Size = new System.Drawing.Size(312, 20);
            this.ShipToNameTextBox.TabIndex = 48;
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.Location = new System.Drawing.Point(488, 72);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(96, 20);
            this.OrderDateLabel.TabIndex = 47;
            this.OrderDateLabel.Text = "Order Date";
            this.OrderDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RequiredDateLabel
            // 
            this.RequiredDateLabel.Location = new System.Drawing.Point(488, 96);
            this.RequiredDateLabel.Name = "RequiredDateLabel";
            this.RequiredDateLabel.Size = new System.Drawing.Size(96, 20);
            this.RequiredDateLabel.TabIndex = 50;
            this.RequiredDateLabel.Text = "Required Date";
            this.RequiredDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PendingOrdersStatusBar
            // 
            this.PendingOrdersStatusBar.Location = new System.Drawing.Point(0, 558);
            this.PendingOrdersStatusBar.Name = "PendingOrdersStatusBar";
            this.PendingOrdersStatusBar.Size = new System.Drawing.Size(768, 20);
            this.PendingOrdersStatusBar.TabIndex = 77;
            // 
            // ShipToPostalCodeLabel
            // 
            this.ShipToPostalCodeLabel.Location = new System.Drawing.Point(72, 256);
            this.ShipToPostalCodeLabel.Name = "ShipToPostalCodeLabel";
            this.ShipToPostalCodeLabel.Size = new System.Drawing.Size(88, 20);
            this.ShipToPostalCodeLabel.TabIndex = 61;
            this.ShipToPostalCodeLabel.Text = "Postal Code";
            this.ShipToPostalCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerAddressLabel
            // 
            this.CustomerAddressLabel.Location = new System.Drawing.Point(72, 96);
            this.CustomerAddressLabel.Name = "CustomerAddressLabel";
            this.CustomerAddressLabel.Size = new System.Drawing.Size(88, 20);
            this.CustomerAddressLabel.TabIndex = 56;
            this.CustomerAddressLabel.Text = "Address";
            this.CustomerAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShipToRegionTextBox
            // 
            this.ShipToRegionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ShipToRegionTextBox.Location = new System.Drawing.Point(380, 232);
            this.ShipToRegionTextBox.Name = "ShipToRegionTextBox";
            this.ShipToRegionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipToRegionTextBox.TabIndex = 69;
            // 
            // ShippingMethodLabel
            // 
            this.ShippingMethodLabel.Location = new System.Drawing.Point(488, 128);
            this.ShippingMethodLabel.Name = "ShippingMethodLabel";
            this.ShippingMethodLabel.Size = new System.Drawing.Size(96, 17);
            this.ShippingMethodLabel.TabIndex = 49;
            this.ShippingMethodLabel.Text = "Shipping Method";
            this.ShippingMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerRegionTextBox
            // 
            this.CustomerRegionTextBox.Enabled = false;
            this.CustomerRegionTextBox.Location = new System.Drawing.Point(380, 120);
            this.CustomerRegionTextBox.Name = "CustomerRegionTextBox";
            this.CustomerRegionTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerRegionTextBox.TabIndex = 64;
            // 
            // CustomerPostalCodeTextBox
            // 
            this.CustomerPostalCodeTextBox.Enabled = false;
            this.CustomerPostalCodeTextBox.Location = new System.Drawing.Point(168, 144);
            this.CustomerPostalCodeTextBox.Name = "CustomerPostalCodeTextBox";
            this.CustomerPostalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerPostalCodeTextBox.TabIndex = 65;
            // 
            // POToolBar
            // 
            this.POToolBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.POToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.RefreshToolBarButton,
            this.AddOrderItemToolBarButton,
            this.SaveOrderToolbarButton,
            this.PrintPreviewToolBarButton,
            this.SubmitToolBarButton,
            this.ViewUnsubmittedToolBarButton,
            this.ViewSubmittedToolBarButton});
            this.POToolBar.ButtonSize = new System.Drawing.Size(24, 24);
            this.POToolBar.DropDownArrows = true;
            this.POToolBar.ImageList = this.POImageList;
            this.POToolBar.Location = new System.Drawing.Point(0, 0);
            this.POToolBar.Name = "POToolBar";
            this.POToolBar.ShowToolTips = true;
            this.POToolBar.Size = new System.Drawing.Size(768, 30);
            this.POToolBar.TabIndex = 78;
            this.POToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.POToolBar_ButtonClick);
            // 
            // RefreshToolBarButton
            // 
            this.RefreshToolBarButton.ImageIndex = 0;
            this.RefreshToolBarButton.Name = "RefreshToolBarButton";
            this.RefreshToolBarButton.Tag = "Refresh";
            this.RefreshToolBarButton.ToolTipText = "Refresh product and customer data";
            // 
            // AddOrderItemToolBarButton
            // 
            this.AddOrderItemToolBarButton.ImageIndex = 1;
            this.AddOrderItemToolBarButton.Name = "AddOrderItemToolBarButton";
            this.AddOrderItemToolBarButton.Tag = "Add";
            this.AddOrderItemToolBarButton.ToolTipText = "Add a new order item to the purchase order";
            // 
            // SaveOrderToolbarButton
            // 
            this.SaveOrderToolbarButton.ImageIndex = 2;
            this.SaveOrderToolbarButton.Name = "SaveOrderToolbarButton";
            this.SaveOrderToolbarButton.Tag = "Save";
            this.SaveOrderToolbarButton.ToolTipText = "Save the current purchase order";
            // 
            // PrintPreviewToolBarButton
            // 
            this.PrintPreviewToolBarButton.ImageIndex = 3;
            this.PrintPreviewToolBarButton.Name = "PrintPreviewToolBarButton";
            this.PrintPreviewToolBarButton.Tag = "PrintPreview";
            this.PrintPreviewToolBarButton.ToolTipText = "Print preview";
            // 
            // SubmitToolBarButton
            // 
            this.SubmitToolBarButton.ImageIndex = 4;
            this.SubmitToolBarButton.Name = "SubmitToolBarButton";
            this.SubmitToolBarButton.Tag = "Submit";
            this.SubmitToolBarButton.ToolTipText = "Submit purchase order data to the NWTraders database";
            // 
            // ViewUnsubmittedToolBarButton
            // 
            this.ViewUnsubmittedToolBarButton.ImageIndex = 5;
            this.ViewUnsubmittedToolBarButton.Name = "ViewUnsubmittedToolBarButton";
            this.ViewUnsubmittedToolBarButton.Tag = "Unsubmitted";
            this.ViewUnsubmittedToolBarButton.ToolTipText = "View the unsubmitted orders";
            // 
            // ViewSubmittedToolBarButton
            // 
            this.ViewSubmittedToolBarButton.ImageIndex = 6;
            this.ViewSubmittedToolBarButton.Name = "ViewSubmittedToolBarButton";
            this.ViewSubmittedToolBarButton.Tag = "Submitted";
            this.ViewSubmittedToolBarButton.ToolTipText = "View report of submitted orders";
            // 
            // POImageList
            // 
            this.POImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("POImageList.ImageStream")));
            this.POImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.POImageList.Images.SetKeyName(0, "");
            this.POImageList.Images.SetKeyName(1, "");
            this.POImageList.Images.SetKeyName(2, "");
            this.POImageList.Images.SetKeyName(3, "");
            this.POImageList.Images.SetKeyName(4, "");
            this.POImageList.Images.SetKeyName(5, "");
            this.POImageList.Images.SetKeyName(6, "");
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(768, 578);
            this.Controls.Add(this.POToolBar);
            this.Controls.Add(this.NWTradersLabel);
            this.Controls.Add(this.NWTradersAddressLabel);
            this.Controls.Add(this.ShipToCityLabel);
            this.Controls.Add(this.OrderDateDateTimePicker);
            this.Controls.Add(this.ShippingMethodLabel);
            this.Controls.Add(this.CustomerAddressTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.UnitPriceLabel);
            this.Controls.Add(this.ShipToCityTextBox);
            this.Controls.Add(this.RequiredDateDateTimePicker);
            this.Controls.Add(this.CustomerCityTextBox);
            this.Controls.Add(this.ShipToAddressTextBox);
            this.Controls.Add(this.CustomerCountryLabel);
            this.Controls.Add(this.CustomerRegionLabel);
            this.Controls.Add(this.ProductOrderPanel);
            this.Controls.Add(this.ShipToPostalCodeTextBox);
            this.Controls.Add(this.CustomerCountryTextBox);
            this.Controls.Add(this.ProductDescriptionLabel);
            this.Controls.Add(this.CustomerPostalCodeLabel);
            this.Controls.Add(this.UnitSizeLabel);
            this.Controls.Add(this.ShipToAddressLabel);
            this.Controls.Add(this.CustomerAddressLabel);
            this.Controls.Add(this.ShipToNameTextBox);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.RequiredDateLabel);
            this.Controls.Add(this.PendingOrdersStatusBar);
            this.Controls.Add(this.NewOrderItemButton);
            this.Controls.Add(this.ShipToCountryTextBox);
            this.Controls.Add(this.ShipToCountryLabel);
            this.Controls.Add(this.ShipToRegionLabel);
            this.Controls.Add(this.CustomerRegionTextBox);
            this.Controls.Add(this.CustomerPostalCodeTextBox);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.CustomerCityLabel);
            this.Controls.Add(this.ShipToLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.SaveOrderButton);
            this.Controls.Add(this.CustomersComboBox);
            this.Controls.Add(this.ShipViaListBox);
            this.Controls.Add(this.ShipToPostalCodeLabel);
            this.Controls.Add(this.ShipToRegionTextBox);
            this.Menu = this.POMainMenu;
            this.Name = "MainForm";
            this.Text = "Purchase Orders";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void FilePrintPreviewMenuItem_Click(object sender, System.EventArgs e)
		{
			PrintPreview();
		}
		private void PrintPreview()
		{
			PrintPreviewDialog form2555PreviewDialog = new PrintPreviewDialog();

			// reset the purchase item number before each print preview
			MainModule.purchaseItemNumber = 0;

			// get the number of purchase items on the form
			// since the HasMorePages property must be set manually, this value
			// must be compaired with the "line counter" within the print loop when
			// constructing the print document.
			MainModule.purchaseItemCount = MainModule.mainPOForm.ProductOrderPanel.Controls.Count;

			// read the Customer and Purchase Order information off MainForm
			CapturePurcaseOrderData(MainModule.purchaseItemCount);

			// pass MainForm content to the print class
			form2555Document.printingForm2555ReceiveContent(MainModule.purchaseItemNumber, MainModule.purchaseItemCount, MainModule.customerData, MainModule.purchaseData);

			form2555PreviewDialog.Document = form2555Document;
			form2555PreviewDialog.WindowState = FormWindowState.Maximized;
			form2555PreviewDialog.ShowDialog();
		}

		private void FilePageSetupMenuItem_Click(object sender, System.EventArgs e)
		{
			PageSetup();
		}
		private void PageSetup()
		{
			PageSetupDialog form2555SetupDialog = new PageSetupDialog();

			if(form2555PageSettings == null)
			{
				form2555PageSettings = new PageSettings();

				// apply initial margin settings based on page orientation
				if( form2555PageSettings.Landscape)
				{
					form2555PageSettings.Margins.Left = 160;
					form2555PageSettings.Margins.Right = 100;
					form2555PageSettings.Margins.Top = 85;
					form2555PageSettings.Margins.Bottom = 70;
				}
				else
				{
					form2555PageSettings.Margins.Left = 120;
					form2555PageSettings.Margins.Right = 80;
					form2555PageSettings.Margins.Top = 100;
					form2555PageSettings.Margins.Bottom = 100;
				}
			}
			form2555SetupDialog.PageSettings = form2555PageSettings;
			form2555SetupDialog.AllowPaper = false;
			form2555SetupDialog.AllowPrinter = false;
			form2555SetupDialog.AllowMargins = false;
			form2555SetupDialog.ShowDialog();

			// apply final margin settings based on page orientation
			if (form2555PageSettings.Landscape)
			{
				form2555PageSettings.Margins.Left = 160;
				form2555PageSettings.Margins.Right = 100;
				form2555PageSettings.Margins.Top = 85;
				form2555PageSettings.Margins.Bottom = 70;
			}
			else
			{

				form2555PageSettings.Margins.Left = 120;
				form2555PageSettings.Margins.Right = 80;
				form2555PageSettings.Margins.Top = 100;
				form2555PageSettings.Margins.Bottom = 100;
			}

			// store the current page settings with the print document
			if (form2555PageSettings != null)
			{
				form2555Document.DefaultPageSettings = form2555PageSettings;
			}

		}

		private void FilePrintMenuItem_Click(object sender, System.EventArgs e)
		{
			PrintDoc();
		}
		
		private void PrintDoc()
		{
			PrintDialog form2555PrintDialog = new PrintDialog();

			// set MainModule.purchaseItemNumber and MainModule.purchaseItemCount
			MainModule.purchaseItemNumber = 0;
			MainModule.purchaseItemCount = MainModule.mainPOForm.ProductOrderPanel.Controls.Count;

			// set the Document property of the dialog 
			form2555PrintDialog.Document = form2555Document;

			// disable printing to the printer, PrintToFile only
			form2555PrintDialog.AllowPrintToFile = true;
			form2555PrintDialog.PrintToFile = true;
			form2555PrintDialog.AllowPrintToFile = false;

			// read the Customer and Purchase Order information off MainForm
			CapturePurcaseOrderData(MainModule.purchaseItemCount);

			// pass MainForm content to the print class
			form2555Document.printingForm2555ReceiveContent(MainModule.purchaseItemNumber, MainModule.purchaseItemCount, MainModule.customerData, MainModule.purchaseData);

			try
			{
				// capture the user//s action closing the dialog
				DialogResult userResponse  = form2555PrintDialog.ShowDialog();

				if( userResponse == DialogResult.OK)
				{
					// use the Print method if the user selected to print
					form2555Document.Print();
				}

			}
			catch(Exception xcp )
			{
				MessageBox.Show(xcp.Message.ToString());
			}
		}


		private void CapturePurcaseOrderData(int purchaseItemsCount )
		{
			// This subroutine is called before each PrintPreview and PrintDoc operation.
			// The subroutine is used to record the contents of Controls on MainForm
			// into string arrays so that the data can be passed to the PrintingForm2555Class.
			int loopCounter;
			string printText;

			// read in the customer data
			MainModule.customerData[0] = MainModule.mainPOForm.CustomersComboBox.Text;
			MainModule.customerData[1] = MainModule.mainPOForm.CustomerAddressTextBox.Text;

			printText = MainModule.mainPOForm.CustomerCityTextBox.Text;
			if (MainModule.mainPOForm.CustomerRegionTextBox.Text != "")
			{
				printText = printText + ", " + MainModule.mainPOForm.CustomerRegionTextBox.Text;
			}

			MainModule.customerData[2] = printText + "  " + MainModule.mainPOForm.CustomerPostalCodeTextBox.Text + "  " + MainModule.mainPOForm.CustomerCountryTextBox.Text;

			MainModule.customerData[3] = MainModule.mainPOForm.ShipToNameTextBox.Text;
			MainModule.customerData[4] = MainModule.mainPOForm.ShipToAddressTextBox.Text;

			printText = MainModule.mainPOForm.ShipToCityTextBox.Text;
			if (MainModule.mainPOForm.ShipToRegionTextBox.Text != "")
			{
				printText = printText + ", " + MainModule.mainPOForm.ShipToRegionTextBox.Text;
			}

			MainModule.customerData[5] = printText + "  " + MainModule.mainPOForm.ShipToPostalCodeTextBox.Text + "  " + MainModule.mainPOForm.CustomerCountryTextBox.Text;

			MainModule.customerData[6] = MainModule.mainPOForm.OrderDateDateTimePicker.Value.ToLongDateString();
			MainModule.customerData[7] = MainModule.mainPOForm.RequiredDateDateTimePicker.Value.ToLongDateString();

			
			if (MainModule.mainPOForm.ShipViaListBox.SelectedIndex == -1)
			{
				MainModule.mainPOForm.ShipViaListBox.SelectedIndex = 2;
			}

			MainModule.customerData[8] = (string)MainModule.mainPOForm.ShipViaListBox.SelectedItem;


			// redimension the string array used to store the Purchase Order data
			MainModule.purchaseData = new string[purchaseItemsCount, 5];

			// create the object used to contain an instance of the control
			OrderItemControl tempControl;

			// read in the purchase order data
			for( loopCounter = 0;loopCounter < purchaseItemsCount;loopCounter ++)
			{
				tempControl = MainModule.mainPOForm.ProductOrderPanel.Controls[loopCounter] as OrderItemControl;
				MainModule.purchaseData[loopCounter, 0] = Convert.ToString(tempControl.OrderQuantity);
				MainModule.purchaseData[loopCounter, 1] = tempControl.OrderProductName;
				MainModule.purchaseData[loopCounter, 2] = string.Format("{0:C}",tempControl.OrderPrice.ToString());
				MainModule.purchaseData[loopCounter, 3] = string.Format("{0:P}",tempControl.OrderDiscount);
				MainModule.purchaseData[loopCounter, 4] = Convert.ToString(tempControl.OrderQuantityPerUnit);
			}

		}


		internal void BindControls()
		{
			try
			{
				//bind to the controls that display the Customer information
				CustomersComboBox.DataSource = MainModule.northwindData.Tables["Customers"];
				CustomersComboBox.DisplayMember = "CompanyName";
				CustomersComboBox.ValueMember = "CustomerID";
				CustomerAddressTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "Address");
				CustomerCityTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "City");
				CustomerRegionTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "Region");
				CustomerPostalCodeTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "PostalCode");
				CustomerCountryTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "Country");

				//bind to the controls that display the Order shipping information
				ShipToNameTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "CompanyName");
				ShipToAddressTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "Address");
				ShipToCityTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "City");
				ShipToRegionTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "Region");
				ShipToPostalCodeTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "PostalCode");
				ShipToCountryTextBox.DataBindings.Add("Text", MainModule.northwindData.Customers, "Country");
			}
			catch (Exception xcp)
			{
				MessageBox.Show(xcp.ToString());
			}
		}
		
		private void SaveOrders()
		{
			//create two orders tables to hold instances of Orders and Order Details
			System.Data.DataTable ordersDataTable  = MainModule.pendingOrdersData.Orders;
			System.Data.DataTable orderDetailsDataTable = MainModule.pendingOrdersData.OrderDetails;
			//create a new row in the Orders table
			System.Data.DataRow ordersRow  = ordersDataTable.NewRow();
			//clientOrderID holds the auto generated value of OrderID when a new order is created
			int clientOrderID;
			//discountValueString holds the string value of the Discount
			string discountValueString;
			//discountValueDouble holds the double value of the Discount
			double discountValueDouble;
			//percentSymbolPlaceHolder holds the location of the "%" sign within the Discount value
			int percentSymbolPlaceHolder;

			//set Order information
			ordersRow["CustomerID"] = CustomersComboBox.SelectedValue;
			ordersRow["EmployeeID"] = MainModule.employeeID;
			ordersRow["OrderDate"] = OrderDateDateTimePicker.Text;
			ordersRow["RequiredDate"] = RequiredDateDateTimePicker.Text;
			string shipMethod = "";
			if (ShipViaListBox.SelectedItem != null)
				shipMethod = ShipViaListBox.SelectedItem.ToString();
			switch(shipMethod)
			{
				case "Overnight":
					ordersRow["ShipVia"] = 1;
					break;
				case "Second Day":
					ordersRow["ShipVia"] = 2;
					break;
				case "Standard":
					ordersRow["ShipVia"] = 3;
					break;
				default: 
					MessageBox.Show("Please select a shipping method");
					return;
			}
			ordersRow["ShipName"] = ShipToNameTextBox.Text;
			ordersRow["ShipAddress"] = ShipToAddressTextBox.Text;
			ordersRow["ShipCity"] = ShipToCityTextBox.Text;
			ordersRow["ShipPostalCode"] = ShipToPostalCodeTextBox.Text;
			ordersRow["ShipRegion"] = ShipToRegionTextBox.Text;
			ordersRow["ShipRegion"] = ShipToCountryTextBox.Text;
			ordersRow["ShipCountry"] = ShipToCountryTextBox.Text;
			ordersDataTable.Rows.Add(ordersRow);
			clientOrderID = Convert.ToInt32(ordersRow["OrderID"]);

			//set the Order Detail information up
			OrderItemControl ctrl;
			//checkDuplicateProducts holds all of the ProductID values of Order Details and is used to
			//prevent prevent duplicate products within an Order
			int [] checkDuplicateProducts = new int[ProductOrderPanel.Controls.Count];
			int productID;
			int currentControlIndex = 0;
			foreach(Control obj in ProductOrderPanel.Controls)
			{
				ctrl = obj as OrderItemControl;


				productID = Convert.ToInt32(ctrl.OrderProductID);
				//test the checkDuplicateProducts array to see if an Order Item was  created
				//with the same ProductID. The BinarySerach methods returns the index of the array
				//item that contains the value searched on
				if (Array.BinarySearch(checkDuplicateProducts, productID) >= 0)
				{
					MessageBox.Show("You have entered multiple order items for the same product. Please consolidate product orders");
					//roll back your changes to the dataset and read the most recently saved PendingOrders.xmk file
					MainModule.pendingOrdersData.RejectChanges();
					try
					{
                        //MainModule.pendingOrdersData.ReadXml(Application.CommonAppDataPath + "\\PendingOrders.xml");
                        MainModule.pendingOrdersData.ReadXml(".\\PendingOrders.xml");
                    }
					catch
					{}
					return;
				}
            
				//add the productID to the array
				checkDuplicateProducts.SetValue(productID, currentControlIndex);
				currentControlIndex = currentControlIndex + 1;

				//add the order details for each order
				System.Data.DataRow orderDetailRow  = orderDetailsDataTable.NewRow();
				//set Order Detail information
				orderDetailRow["OrderID"] = clientOrderID;
				orderDetailRow["ProductID"] = productID;

				orderDetailRow["UnitPrice"] = decimal.Parse(ctrl.OrderPrice,System.Globalization.NumberStyles.Currency);
				orderDetailRow["Quantity"] = Convert.ToInt32(ctrl.OrderQuantity);

				//remove the % sign from the Discount value and convert it to a decimal value
				discountValueString = ctrl.OrderDiscount;
				percentSymbolPlaceHolder = discountValueString.IndexOf("%");
				discountValueString = discountValueString.Remove(percentSymbolPlaceHolder, 1);
				discountValueDouble = Convert.ToDouble(discountValueString);
				if (discountValueDouble > 0)
				{
					discountValueDouble = discountValueDouble / 100;
				}
				orderDetailRow["Discount"] = discountValueDouble;
				//add the Order Detail to the table
				orderDetailsDataTable.Rows.Add(orderDetailRow);
			}

			//MainModule.pendingOrdersData.WriteXml(Application.CommonAppDataPath + "\\PendingOrders.xml");
			MainModule.pendingOrdersData.WriteXml(".\\PendingOrders.xml");
			RemoveAllProductOrderControls();

			if(MainModule.soundOn)
			{
				Win32PlaySound.PlaySound("Save.wav", 0, 0);
			}
		}


		private void SaveOrderButton_Click(object sender, System.EventArgs e)
		{
			SaveOrders();
			UpdateStatusBar();
		}
		private void SubmitOrders()
		{
			try
			{
				MainModule.orderData.SubmitOrders();
				MainModule.orderData.RefreshLocalData();
				UpdateStatusBar();

				if (MainModule.soundOn)
				{
					Win32PlaySound.PlaySound("Submit.WAV", 0, 0);
				}
			}
			catch(Exception xcp)
			{
				MessageBox.Show(xcp.ToString());
			}
		}

		private void DataSubmitMenuItem_Click(object sender, System.EventArgs e)
		{
			SubmitOrders();
		}

		private void DataRefreshMenuItem_Click(object sender, System.EventArgs e)
		{
			MainModule.orderData.RefreshLocalData();
			//check to see if the controls are currently data bound. If not, then 
			//call the BindControls() function
			if (!this.BindingContext.Contains(MainModule.northwindData.Customers))
			{
				BindControls();
			}
			ViewSubmittedOrdersMenuItem.Enabled = true;
		}
		


		private void ViewUnsubmittedOrdersMenuItem_Click(object sender, System.EventArgs e)
		{
			ViewUnsubmittedOrders();
		}

		private void ViewUnsubmittedOrders()
		{
			PendingOrdersForm frm = new PendingOrdersForm();
			frm.Show();
		}

		private void RemoveAllProductOrderControls()
		{
			//remove all of the controls from the ProductOrderPanel. By removing the
			//controls from last to first you can prevent index errors from occurring
			//as controls are removed
			while (ProductOrderPanel.Controls.Count > 0)
			{
				ProductOrderPanel.Controls.RemoveAt(ProductOrderPanel.Controls.Count - 1);
			}
			//reset the yPosOrderItemControl variable so the next control drawn is placed
			//at the top of the ProductOrderPanel
			yPositionOrderItemControl = 0;
			SaveOrderButton.Enabled = false;
		}
		internal void UpdateStatusBar()
		{
			//create 2 StatusBarPanel objects
			StatusBarPanel panel1 = new StatusBarPanel();
			StatusBarPanel panel2 = new StatusBarPanel();
			try
			{
				if (MainModule.appSettingsData.AppSettings.Rows.Count == 0)
				{
					panel1.Text = "User: None";
				}
				else
				{
					panel1.Text = "User: " + MainModule.empName;
				}
			}
			catch (Exception xcp )
			{
				MessageBox.Show(xcp.ToString());
			}
			//determine how many pending orders exist
			try
			{
				switch(MainModule.pendingOrdersData.Tables["Orders"].Rows.Count)
				{
					case 0:
						panel2.Text = "You have no unsubmitted orders";
						ViewUnsubmittedOrdersMenuItem.Enabled = false;
						DataSubmitMenuItem.Enabled = false;
						break;
					case 1:
						panel2.Text = "You have 1 unsubmitted order";
						ViewUnsubmittedOrdersMenuItem.Enabled = true;
						DataSubmitMenuItem.Enabled = true;
						break;
					default:
						panel2.Text = "You have " + MainModule.pendingOrdersData.Tables["Orders"].Rows.Count + " unsubmitted orders";
						ViewUnsubmittedOrdersMenuItem.Enabled = true;
						DataSubmitMenuItem.Enabled = true;
						break;
				}
			}
			catch (Exception xcp)
			{
				MessageBox.Show(xcp.ToString());
			}

			panel1.AutoSize = StatusBarPanelAutoSize.Contents;
			panel2.AutoSize = StatusBarPanelAutoSize.Contents;
			//clear any existing panels as add panel1 and panel2
			PendingOrdersStatusBar.Panels.Clear();
			PendingOrdersStatusBar.Panels.Add(panel1);
			PendingOrdersStatusBar.Panels.Add(panel2);
			PendingOrdersStatusBar.ShowPanels = true;

		}
		private void ViewSubmittedOrders()
		{
			ReportHistoryForm frm = new ReportHistoryForm();
			frm.ShowDialog();
		}
		private void CreateNewRow(object sender, System.EventArgs e)
		{
			//Handles NewOrderItemButton.Click

			if(!SaveOrderButton.Enabled)
				SaveOrderButton.Enabled = true;
			tempProductOrder = new PurchaseOrder.OrderItemControl();

			tempProductOrder.Location = new System.Drawing.Point(0, yPositionOrderItemControl);
			tempProductOrder.Size = new System.Drawing.Size(608, 24);

			//set the ContextMenu of the OrderItem control to productContextMenu
			tempProductOrder.ContextMenu = this.ProductContextMenu;
			//by default, the TexBox control uses a default ContextMenu that
			//provides Undo, Cut, Copy, Paste, and Select All operations. The
			//ProductOrder control exposes the ContextMenu property of the 
			//DiscountTextBox and QuantityTextBox with the QuantityTextBox_ContextMenu 
			//and the DiscountTextBoxC_ontextMenu properties
			tempProductOrder.DiscountTextBox_ContextMenu = this.ProductContextMenu;
			tempProductOrder.QuantityTextBox_ContextMenu = this.ProductContextMenu;
			//set the default values of the order
			tempProductOrder.OrderQuantity = 1;
			tempProductOrder.OrderDiscount = "0.00%";
			//call the GetProductData method to populate the OrderItemControl
			tempProductOrder.GetProductData(MainModule.northwindData.Tables["Products"]);

			ProductOrderPanel.Controls.Add(tempProductOrder);
			//increment yPosOrderItemControl so the next control drawn appears below the current one
			yPositionOrderItemControl = yPositionOrderItemControl + 24;

		}
		private void DeleteOrderItem()
		{
			int controlCount;
			int currentControlIndex;
			int count;
			OrderItemControl tempProductOrder;
			//when deleting OrderItemControls you must reorder and redraw the existing ones
			controlCount = ProductOrderPanel.Controls.Count;
			currentControlIndex = ProductOrderPanel.Controls.IndexOf(ProductContextMenu.SourceControl);
			//if the control is not the last one and you need to reorder and redraw the existing ones
			//that are below it
			if (currentControlIndex + 1 < controlCount)
			{
				for(count = (currentControlIndex + 1);count < controlCount;count++)
				{
					tempProductOrder = ProductOrderPanel.Controls[count] as OrderItemControl;
					tempProductOrder.Location = new System.Drawing.Point(0, tempProductOrder.Location.Y - 24);
				}
				ProductOrderPanel.Controls.Remove(ProductContextMenu.SourceControl);
				//if it is the last control you can just delete it without any reordering logic
			}
			else
			{
				ProductOrderPanel.Controls.Remove(ProductContextMenu.SourceControl);
			}
			//decrement yPositionOrderItemControl so the next control drawn is placed in the correct
			//location 
			yPositionOrderItemControl = yPositionOrderItemControl - 24;
		}


		private void POToolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			
			switch(e.Button.Tag.ToString())
			{
				case "Add":
					NewOrderItemButton.PerformClick();
					break;
				case "PrintPreview":
					PrintPreview();
					break;
				case "Save":
					SaveOrderButton.PerformClick();
					break;
				case "Refresh":
					DataRefreshMenuItem.PerformClick();
					break;
				case "Submit":
					DataSubmitMenuItem.PerformClick();
					break;
				case "Unsubmitted":
					ViewUnsubmittedOrdersMenuItem.PerformClick();
					break;
				case "Submitted":
					ViewSubmittedOrdersMenuItem.PerformClick();
					break;
			}
		}

		private void ViewSubmittedOrdersMenuItem_Click(object sender, System.EventArgs e)
		{
			ViewSubmittedOrders();
		}

		private void CustomersComboBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			int index;
			//use the FindString method to select an item in the CustomersComboBox with a value
			//beginning the character typed by the user
			ComboBox cb = sender as ComboBox;
			index = cb.FindString(e.KeyChar.ToString());

			if (index >= 0)
			{
				cb.SelectedIndex = index;
			}
		}


		private void ToolsOptionMenuItem_Click(object sender, System.EventArgs e)
		{
			OptionsForm frm = new  OptionsForm();
			frm.ShowDialog();
		}

		private void RequiredDateDateTimePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (this.RequiredDateDateTimePicker.Value < this.OrderDateDateTimePicker.Value)
			{
				MessageBox.Show("Required date must be later than order date");
				e.Cancel = true;
			}
		}

		private void OrderDateDateTimePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (this.RequiredDateDateTimePicker.Value < this.OrderDateDateTimePicker.Value)
			{
				MessageBox.Show("Required date must be later than order date");
				e.Cancel = true;
			}
		}

		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			DialogResult response;
			//if there are any unsaved orders, prompt the user to save changes
			if( ProductOrderPanel.Controls.Count > 0)
			{
				response = MessageBox.Show("You have an unsaved order open. Do you want to save the order before closing?", 
					"Open order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (response == DialogResult.Yes)
				{
					e.Cancel = true;
				}
			}
		}

		
		private void DeleteOrderItemMenuItem_Click(object sender, System.EventArgs e)
		{
			DeleteOrderItem();
		}

		private void DeleteAllOrderItemsMenuItem_Click(object sender, System.EventArgs e)
		{
			RemoveAllProductOrderControls();
		}

		private void HelpAboutMenu_Click(object sender, System.EventArgs e)
		{
			BaseAboutForm frm = new BaseAboutForm();
			frm.ShowDialog();
		}

		private void FileExitMenuItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

	}
		
}
