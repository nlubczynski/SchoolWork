using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTechAssignment5;

public partial class Reviewers : System.Web.UI.Page
{
    Reviewer[] reviewers;

    protected void Page_Load(object sender, EventArgs e)
    {
        add.Visible = true;
    }
    protected void Page_init(object sender, EventArgs e)
    {
        //On first page load, load the "bands"
        if (ViewState["reviewers"] == null)
        {

            XMLReaderWriter reader = new XMLReaderWriter("C:\\Users\\NikLubz\\SkyDrive\\Documents\\Third Year\\Web Technologies\\Assignment 5\\data.xml");
            reader.readXml();
            reviewers = reader.getReviewers();
            ViewState.Add("bands", reviewers);
        }
        else
        {
            reviewers = (Reviewer[])ViewState["bands"];
        }

        if (!IsPostBack)
        {
            //Create the Data for the gridviews
            var list = reviewers.Select(r => new 
            { 
                name = r.getName(),
                id = r.getId(),
                company = r.getCompany()
            }).ToList();

            //Bind the data
            reviewerGrid.DataSource = list;
            reviewerGrid.DataBind();
        }
    }
    protected void reviewerGrid_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "remove")
        {
            //Get index
            int index = Convert.ToInt32(e.CommandArgument);

            //Remove band
            Reviewer toRemove = reviewers[index];
            List<Reviewer> temp = reviewers.ToList();
            temp.Remove(toRemove);
            reviewers = temp.ToArray();

            //Save
            save();

            //Reload Page
            Response.Redirect("~/reviewers.aspx");
        }
    }
    protected void add_Click(object sender, EventArgs e)
    {
        //create reviewer
        Reviewer reviewer = new Reviewer("Enter ID");
        reviewer.setName("Enter Name");

        //Add to reviewers
        List<Reviewer> temp = reviewers.ToList();
        temp.Add(reviewer);
        reviewers = temp.ToArray();

        //Save
        save();

        //Reload page
        Response.Redirect("~/reviewers.aspx");
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        //save
        //Get all the data for band members
        int index = 0;
        foreach (GridViewRow row in reviewerGrid.Rows)
        {
            if (index < reviewers.Length)
            {
                if (uniqueId(((TextBox)row.Cells[1].Controls[1]).Text, index))
                {
                    reviewers[index].setName(((TextBox)row.Cells[0].Controls[1]).Text);
                    reviewers[index].setId(((TextBox)row.Cells[1].Controls[1]).Text);
                    reviewers[index].setCompany(((TextBox)row.Cells[2].Controls[1]).Text);
                }
                else
                {
                    ((TextBox)row.Cells[1].Controls[1]).Text = "ID MUST BE UNIQUE";
                    return;
                }
            }
            else
            {
                if (uniqueId(((TextBox)row.Cells[1].Controls[1]).Text, index))
                {
                    Reviewer temp = new Reviewer(((TextBox)row.Cells[1].Controls[1]).Text);
                    temp.setName(((TextBox)row.Cells[0].Controls[1]).Text);
                    temp.setCompany(((TextBox)row.Cells[2].Controls[1]).Text);
                    List<Reviewer> t = reviewers.ToList();
                    t.Add(temp);
                    reviewers = t.ToArray();
                }
                else
                {
                    ((TextBox)row.Cells[1].Controls[1]).Text = "ID MUST BE UNIQUE";
                    return;
                }
            }

            index++;
        }

        save();
    }
    internal void save()
    {
        //Save the xml.
        XMLReaderWriter reader = new XMLReaderWriter("C:\\Users\\NikLubz\\SkyDrive\\Documents\\Third Year\\Web Technologies\\Assignment 5\\data.xml");
        reader.readXml();
        reader.writeXML(reader.getBands(), reviewers);
    }
    internal bool uniqueId(string id, int index)
    {
        //skip the index of the row passed from
        int i = 0;
        foreach (GridViewRow row in reviewerGrid.Rows)
        {
            if (((TextBox)row.Cells[1].Controls[1]).Text == id && i != index)
                return false;
            i++;
        }
        return true;
    }
}