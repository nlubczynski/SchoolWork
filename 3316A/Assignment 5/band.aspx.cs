using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTechAssignment5;

public partial class band : System.Web.UI.Page
{
    Band[] bands;
    Band selectedBand;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Set the default page title
            bandPageLabel.Text = "Band Page";

            //Set the default page sub title
            bandPageSubLabel.Text = "Select a band.";
        }

        if (Request.QueryString["b"] != null)
                setBand(Request.QueryString["b"]);
        
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
            bandsTable.DataSource = list;
            bandsTable.DataBind();
        }
    }

    protected void bandsTable_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName.Equals("bandClick"))
        {
            //Get index
            int index = Convert.ToInt32(e.CommandArgument);

            //Reload page
            Response.Redirect(String.Format("~/band.aspx?b={0}",bands[index].getName()));
        }
        if (e.CommandName.Equals("bandRemove"))
        {
            //Get index
            int index = Convert.ToInt32(e.CommandArgument);

            //Remove band
            List<Band> temp = bands.ToList();
            temp.RemoveAt(index);
            bands = temp.ToArray();

            //Save
            save();

            //Reload Page
            Response.Redirect(String.Format("~/band.aspx"));
        }

        if (e.CommandName.Equals("remove"))
        {
            //Get index
            int index = Convert.ToInt32(e.CommandArgument);

            //Store all members who aren't being deleted
            List<Member> temp = new List<Member>();
            for (int i = 0; i < selectedBand.getMembers().Length; i++)
                if (i == index)
                    continue;
                else
                    temp.Add(selectedBand.getMembers()[i]);

            //Remove all members
            selectedBand.removeMembers();

            //Add back non-deleted members
            foreach (Member m in temp)
                selectedBand.addMember(m);

            //Save the xml
            save();

            //Reload the page
            Response.Redirect(String.Format("~/band.aspx?b={0}", selectedBand.getName()));
        }
    }

    private void setBand(string bandName)
    {
        //Get the selected band
        var bands_query = bands.Where(b => b.getName() == bandName).ToArray();
        if (bands_query.Length == 0)
        {
            //Set the page title
            bandPageLabel.Text = "Band doesn't exist";
            return;
        }

        //Get the selected band
        selectedBand = bands_query[0];

        //Make the add member button visible
        add.Visible = true;
                
        //If postback - we don't want to erase this data
        if (!IsPostBack)
        {
            //Set the page title
            bandPageLabel.Text = selectedBand.getName();

            //Add members beneath band
            bandPageSubLabel.Visible = false;
            //selectedBand.addMember(new Member("Enter name", "Enter Instrument"));
            memberGrid.DataSource = selectedBand.getMembers().Select(m => new
            {
                Name = m.getName(),
                Instrument = m.getInstrument(),
                Joined = m.getJoinDate()
            }).ToList();
            memberGrid.DataBind();
        }
    }
    protected void submit_Click(object sender, EventArgs e)
    {

        //Get all the data for band members
        int index = 0;
        foreach(GridViewRow row in memberGrid.Rows)
        {
            if (index < selectedBand.getMembers().Length)
            {
                selectedBand.getMembers()[index].setName(((TextBox)row.Cells[0].Controls[1]).Text);
                selectedBand.getMembers()[index].setInstrument(((TextBox)row.Cells[1].Controls[1]).Text);
                selectedBand.getMembers()[index].setJoinDate(((TextBox)row.Cells[2].Controls[1]).Text);
            }
            else
            {
                Member temp = new Member(((TextBox)row.Cells[0].Controls[1]).Text, ((TextBox)row.Cells[1].Controls[1]).Text);
                temp.setJoinDate(((TextBox)row.Cells[2].Controls[1]).Text);
                selectedBand.addMember(temp);
            }

            index++;
        }


        //If band name is difference
        if (bandPageLabel.Text != selectedBand.getName())
        {
            //Change the name
            selectedBand.setName(bandPageLabel.Text);

            //Save
            save();

            //Reload the page
            Response.Redirect(String.Format("~/band.aspx?b={0}", selectedBand.getName()));
        }


        save();
    }
    protected void add_Click(object sender, EventArgs e)
    {
        selectedBand.addMember(new Member("New member", ""));
        memberGrid.DataSource = selectedBand.getMembers().Select(m => new
        {
            Name = m.getName(),
            Instrument = m.getInstrument(),
            Joined = m.getJoinDate()
        }).ToList();
        memberGrid.DataBind();

        add.Visible = false;
    }
    internal void save()
    {
        //Save the xml.
        XMLReaderWriter reader = new XMLReaderWriter("D:\\Users\\NiksDesktop\\SkyDrive\\Documents\\Third Year\\Web Technologies\\Assignment 5\\data.xml");
        reader.readXml();
        reader.writeXML(bands, reader.getReviewers());
    }
    protected void addBand_Click(object sender, EventArgs e)
    {
        Band band = new Band("New Band", "0");
        List<Band> temp = bands.ToList();
        temp.Add(band);
        bands = temp.ToArray();

        //Create at least one member
        Member newMember = new Member("Enter name", "");

        //Set selected band
        selectedBand = band;

        //Add Member
        selectedBand.addMember(newMember);

        //Save
        save();

        //Reload the page
        Response.Redirect(String.Format("~/band.aspx?b={0}", selectedBand.getName()));
    }
} 