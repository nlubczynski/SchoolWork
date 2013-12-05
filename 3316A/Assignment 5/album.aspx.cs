using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTechAssignment5;

public partial class album : System.Web.UI.Page
{
    Album selectedAlbum;
    Song[] songs;
    Band[] bands;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Set the default page title
            albumPageLabel.Text = "Album Page";

            //Set the default page sub title
            albumPageSubLabel.Text = "Select an Album.";

        }

        /*if (Request.QueryString["a"] != null)
            setAlbum(Request.QueryString["b"]);*/
    }

    protected void Page_init(object sender, EventArgs e)
    {
        //On first page load, load the "bands"
        if (ViewState["bands"] == null)
        {

            XMLReaderWriter reader = new XMLReaderWriter("D:\\Users\\NiksDesktop\\SkyDrive\\Documents\\Third Year\\Web Technologies\\Assignment 5\\data.xml");
            reader.readXml();
            bands = reader.getBands();
            ViewState.Add("bands", bands);
        }
        else
        {
            bands = (Band[])ViewState["bands"];
        }

        if (!IsPostBack)
        {
            //Create the Data for the gridviews
            var list = bands.Select(b => new { name = b.getName() }).ToList();

            //Bind the data
            bandDropDown.DataSource = list;
            bandDropDown.DataValueField = "name";
            bandDropDown.DataBind();
        }
    }
}