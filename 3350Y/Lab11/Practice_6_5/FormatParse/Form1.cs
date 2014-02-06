//Import the Globalization namespace which contains classes that 
//define culture-related information, such as the formatting of 
//currency and numbers
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using System.Diagnostics;

namespace FormatParse
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private FormatParse.TitlesDataSet titlesDataSet1;
		private System.Windows.Forms.TextBox PriceTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button WriteValueButton;
		private System.Data.SqlClient.SqlDataAdapter TitlesSQLDataAdapter;
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
		/// 
		private void BindControl()
		{
			//Creates the binding first. 
			Binding priceBinding = new Binding("Text",titlesDataSet1,"titles.price");

			priceBinding.Format += new ConvertEventHandler(this.FormatDecimalToString);
			//TODO 2: Create an event deleagte for the Parse event that references the 
			//ParseStringToDecimal procedure
			
			//Add the Binding to the DataBindings collection
			PriceTextBox.DataBindings.Add(priceBinding);
		}

		private void FormatDecimalToString(object sender, ConvertEventArgs convertArgs)
		{
			//Use the ToString method to format the value as currency ("c").
			convertArgs.Value = Convert.ToDecimal(convertArgs.Value).ToString("c");
		}
		//TODO 1: Create a procudure invoked by the Parse event that converts the Value
		//of ConvertEventArgs from a String with Currency formatting to a Decimal
		
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.titlesDataSet1 = new FormatParse.TitlesDataSet();
            this.TitlesSQLDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WriteValueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titlesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Titles";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.titlesDataSet1;
            this.comboBox1.DisplayMember = "titles.title";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(16, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // titlesDataSet1
            // 
            this.titlesDataSet1.DataSetName = "TitlesDataSet";
            this.titlesDataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.titlesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TitlesSQLDataAdapter
            // 
            this.TitlesSQLDataAdapter.SelectCommand = this.sqlSelectCommand1;
            this.TitlesSQLDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "titles", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("title_id", "title_id"),
                        new System.Data.Common.DataColumnMapping("title", "title"),
                        new System.Data.Common.DataColumnMapping("price", "price")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT title_id, title, price FROM titles";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=KADER-PC\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(368, 24);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(48, 20);
            this.PriceTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // WriteValueButton
            // 
            this.WriteValueButton.Location = new System.Drawing.Point(156, 64);
            this.WriteValueButton.Name = "WriteValueButton";
            this.WriteValueButton.Size = new System.Drawing.Size(112, 23);
            this.WriteValueButton.TabIndex = 4;
            this.WriteValueButton.Text = "Debug.Write Value";
            this.WriteValueButton.Click += new System.EventHandler(this.WriteValueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(424, 110);
            this.Controls.Add(this.WriteValueButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Title Prices";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlesDataSet1)).EndInit();
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
			BindControl();
			TitlesSQLDataAdapter.Fill(titlesDataSet1);
		}

		private void WriteValueButton_Click(object sender, System.EventArgs e)
		{
			int positionIndex;
			positionIndex = this.BindingContext[titlesDataSet1, "titles"].Position;
			Debug.Write("The formatted value display is : " + PriceTextBox.Text + "\n");

			Debug.Write("The value saved to the DatSet is : " + titlesDataSet1.titles.Rows[positionIndex]["price"] + "\n");
			

		}
	}
}
