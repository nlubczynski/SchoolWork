using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTechAssignment5;

public partial class _Default : Page
{
    Band[] bands;
    Album[] albums;
    Member[] members;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_init(object sender, EventArgs e)
    {
        //On first page load, load the "bands"
        if (ViewState["bands"] == null)
        {

            XMLReaderWriter reader = new XMLReaderWriter("C:\\Users\\NikLubz\\SkyDrive\\Documents\\Third Year\\Web Technologies\\Assignment 5\\data.xml");
            reader.readXml();

            //Get All bands
            bands = reader.getBands();

            //Get all albums
            List<Album> tempAlbum = new List<Album>();
            foreach (Band b in bands)
                tempAlbum.AddRange(b.getAlbums());
            albums = tempAlbum.ToArray();

            //Get All Members
            List<Member> tempMember = new List<Member>();
            foreach (Band b in bands)
                tempMember.AddRange(b.getMembers());
            members = tempMember.ToArray();

            //Save to viewstate
            ViewState.Add("bands", bands);
            ViewState.Add("albums", albums);
            ViewState.Add("members", members);
        }
        else
        {
            bands = (Band[])ViewState["bands"];
            albums = (Album[])ViewState["albums"];
            members = (Member[])ViewState["members"];
        }

        if (!IsPostBack)
        {
            //bands
            var list = bands.Select(b => new { name = b.getName() }).ToList();

            bandDropDown.DataSource = list;
            bandDropDown.DataValueField = "name";
            bandDropDown.DataBind();

            //albums
            list = albums.Select(a => new { name = a.getName() }).ToList();

            albumDropDown.DataSource = list;
            albumDropDown.DataValueField = "name";
            albumDropDown.DataBind();

            //members
            list = members.Select(m => new { name = m.getName() }).ToList();

            memberDropDown.DataSource = list;
            memberDropDown.DataValueField = "name";
            memberDropDown.DataBind();

        }
    }
    protected void begin_Click(object sender, EventArgs e)
    {
        Response.Redirect(String.Format("~/band.aspx?b={0}", bands[bandDropDown.SelectedIndex]));
    }
    protected void albumDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        Album album = albums[albumDropDown.SelectedIndex];
        int index = 0;
        foreach (Band b in bands)
            if (b.getAlbums().Contains(album))
                bandDropDown.SelectedIndex = index;
            else
                index++;
    }
    protected void memberDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        Member member = members[memberDropDown.SelectedIndex];
        int index = 0;
        foreach (Band b in bands)
            if (b.getMembers().Contains(member))
                bandDropDown.SelectedIndex = index;
            else
                index++;
    }
}