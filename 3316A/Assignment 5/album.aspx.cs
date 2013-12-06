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
    Band selectedBand;
    Song[] songs;
    Band[] bands;
    Review[] reviews;
    Reviewer[] reviewers;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Set the default page title
            albumPageLabel.Text = "Album Page";

            //Set the default page sub title
            albumPageSubLabel.Text = "Select an Album.";

        }

        
        string albumQuery = "";
        if (Request.QueryString["a"] != null)
            albumQuery = Request.QueryString["a"];

        string bandQuery = "";
        if (Request.QueryString["b"] != null)
            bandQuery = Request.QueryString["b"];

        if (albumQuery.Length > 0 && bandQuery.Length > 0)
            processQuery(bandQuery, albumQuery);

    }

    protected void Page_init(object sender, EventArgs e)
    {
        //On first page load, load the "bands"
        if (ViewState["bands"] == null)
        {

            XMLReaderWriter reader = new XMLReaderWriter("D:\\Users\\NiksDesktop\\SkyDrive\\Documents\\Third Year\\Web Technologies\\Assignment 5\\data.xml");
            reader.readXml();
            bands = reader.getBands();
            reviewers = reader.getReviewers();
            ViewState.Add("bands", bands);
            ViewState.Add("reviewers", reviewers);
        }
        else
        {
            bands = (Band[])ViewState["bands"];
            reviewers = (Reviewer[])ViewState["reviewers"];
        }

        if (!IsPostBack)
        {
            //Create the Data for the gridviews
            var list = bands.Select(b => new { name = b.getName() }).ToList();

            //Bind the data
            bandDropDown.DataSource = list;
            bandDropDown.DataValueField = "name";
            bandDropDown.DataBind();

            selectedBand = bands.Where(b => b.getName() == bandDropDown.SelectedItem.Text).ToList().First();
            if(selectedBand != null)
            {
                list = selectedBand.getAlbums().Select(a => new { name = a.getName() }).ToList();
                list.Add(new { name = "Create new Album" });
                albumDropDown.DataSource = list;
                albumDropDown.DataValueField = "name";
                albumDropDown.DataBind();
            }
        }
    }

    private void processQuery(string bandQuery, string albumQuery)
    {
        //Hide the selection tools
        bandDropDown.Visible = false;
        albumDropDown.Visible = false;
        selectAlbum.Visible = false;
        deleteAlbum.Visible = false;

        //Show the add  buttons
        add.Visible = true;
        addReview.Visible = true;
        reviewLabel.Visible = true;

        if (!IsPostBack)
        {
            //Change the title to the query strings
            albumPageLabel.Text = albumQuery;
            albumPageSubLabel.Text = bandQuery;
        }

        //Set the selected band and album
        selectedBand = bands.Where(b => b.getName() == bandQuery).ToList().First();
        selectedAlbum = selectedBand.getAlbums().Where(album => album.getName() == albumQuery).ToList().First();

        if (!IsPostBack)
        {
            //Set the song grid view
            songs = selectedAlbum.getSongs();
            songGridView.DataSource = songs.Select(s => new
            {
                name = s.getName(),
                length = s.getlength()
            }).ToList();
            songGridView.DataBind();
        }

        //Set the reviews
        if (!IsPostBack)
        {
            //Set the reviews grid view
            reviews = selectedAlbum.getReviews();
            reviewsGridView.DataSource = reviews.Select(r => new
            {
                review = r.getReview()
            }).ToList();
            reviewsGridView.DataBind();
        }
    }
    protected void add_Click(object sender, EventArgs e)
    {
        //Create a new song
        Song temp = new Song();
        temp.setName("New Song");

        //Add it to the album
        selectedAlbum.addSong(temp);

        //Save
        save();

        //Bind the grid view
        songGridView.DataSource = selectedAlbum.getSongs().Select(s => new
        {
            name = s.getName(),
            length = s.getlength()
        }).ToList();
        songGridView.DataBind();

        add.Visible = false;
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        //Get all the data for songs
        int index = 0;
        foreach (GridViewRow row in songGridView.Rows)
        {
            if (index < selectedAlbum.getSongs().Length)
            {
                selectedAlbum.getSongs()[index].setName(((TextBox)row.Cells[0].Controls[1]).Text);
                selectedAlbum.getSongs()[index].setLength(((TextBox)row.Cells[1].Controls[1]).Text);
            }
            else
            {
                Song temp = new Song();
                temp.setName(((TextBox)row.Cells[0].Controls[1]).Text);
                temp.setLength(((TextBox)row.Cells[1].Controls[1]).Text);
                selectedAlbum.addSong(temp);
            }

            index++;
        }

        //Get all the data for the reviews
        index = 0;
        foreach (GridViewRow row in reviewsGridView.Rows)
        {
            if (index < selectedAlbum.getReviews().Length)
            {
                selectedAlbum.getReviews()[index].setReviewerId(reviewers[((DropDownList)row.Cells[0].Controls[1]).SelectedIndex].getId());
                selectedAlbum.getReviews()[index].setReview(((TextBox)row.Cells[1].Controls[1]).Text);
            }
            else
            {
                Review temp = new Review(((DropDownList)row.Cells[0].Controls[1]).SelectedValue);
                temp.setReview(((TextBox)row.Cells[1].Controls[1]).Text);
                selectedAlbum.addReview(temp);
            }

            index++;
        }


        //If band name is difference
        if (albumPageLabel.Text != selectedAlbum.getName())
        {
            //Change the name
            selectedAlbum.setName(albumPageLabel.Text);

            //Save
            save();

            //Reload the page
            Response.Redirect(String.Format("~/album.aspx?b={0}&a={1}", selectedBand.getName(), selectedAlbum.getName()));
        }


        save();
    }
    internal void save()
    {
        //Save the xml.
        XMLReaderWriter reader = new XMLReaderWriter("D:\\Users\\NiksDesktop\\SkyDrive\\Documents\\Third Year\\Web Technologies\\Assignment 5\\data.xml");
        reader.readXml();
        reader.writeXML(bands, reader.getReviewers());
    }
    internal void addAlbum()
    {
        //Creat the album
        selectedAlbum = new Album("New Album");
        
        //Albums need at least one song
        Song newSong = new Song();
        newSong.setName("New Song");
        selectedAlbum.addSong(newSong);
        
        //Add album to band
        selectedBand.addAlbum(selectedAlbum);

        //Save
        save();
    }
    protected void bandDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedBand = bands.Where(b => b.getName() == bandDropDown.SelectedItem.Text).ToList().First();
        if (selectedBand != null)
        {
            var list = selectedBand.getAlbums().Select(a => new { name = a.getName() }).ToList();
            list.Add(new { name = "Create new Album" });
            albumDropDown.DataSource = list;
            albumDropDown.DataValueField = "name";
            albumDropDown.DataBind();
        }
    }
    protected void songGridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "remove")
        {
            //Get index
            int index = Convert.ToInt32(e.CommandArgument);

            //If it's the last song, you can't remove
            if (selectedAlbum.getSongs().Length == 1)
                return;

            //Remove band
            Song toRemove = selectedAlbum.getSongs()[index];
            selectedAlbum.removeSong(toRemove);

            //Save
            save();

            //Reload Page
            Response.Redirect(String.Format("~/album.aspx?b={0}&a={1}", selectedBand.getName(), selectedAlbum.getName()));
        }
    }
    protected void selectAlbum_Click(object sender, EventArgs e)
    {
        selectedBand = bands.Where(b => b.getName() == bandDropDown.SelectedItem.Text).ToList().First();
        if (albumDropDown.SelectedItem.Text == "Create new Album")
            addAlbum();
        else
            selectedAlbum = selectedBand.getAlbums().Where(album => album.getName() == albumDropDown.SelectedItem.Text).ToList().First();

        Response.Redirect(String.Format("~/album.aspx?b={0}&a={1}", selectedBand.getName(), selectedAlbum.getName()));
    }
    protected void deleteAlbum_Click(object sender, EventArgs e)
    {
        //get the selected band
        selectedBand = bands.Where(b => b.getName() == bandDropDown.SelectedItem.Text).ToList().First();
        if (albumDropDown.SelectedItem.Text == "Create new Album")
            return;
        else
            selectedAlbum = selectedBand.getAlbums().Where(album => album.getName() == albumDropDown.SelectedItem.Text).ToList().First();

        //Remove the album
        selectedBand.removeAlbum(selectedAlbum);

        //Save
        save();
        
        Response.Redirect(String.Format("~/album.aspx"));
    }

    protected void reviewsGridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "remove")
        {
            //Get index
            int index = Convert.ToInt32(e.CommandArgument);

            //Remove band
            Review toRemove = selectedAlbum.getReviews()[index];
            selectedAlbum.removeReview(toRemove);

            //Save
            save();

            //Reload Page
            Response.Redirect(String.Format("~/album.aspx?b={0}&a={1}", selectedBand.getName(), selectedAlbum.getName()));
        }
    }
    protected void addReview_Click(object sender, EventArgs e)
    {
        //Create a new review
        Review temp = new Review(reviewers[0].getId());

        //Add it to the album
        selectedAlbum.addReview(temp);

        //Save
        save();

        //Bind the grid view
        //Set the reviews grid view
        reviews = selectedAlbum.getReviews();
        reviewsGridView.DataSource = reviews.Select(r => new
        {
            review = r.getReview()
        }).ToList();
        reviewsGridView.DataBind();

        addReview.Visible = false;
    }

    protected void reviewsGridView_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            var dd = e.Row.Cells[2].FindControl("reviewerDropDown") as DropDownList;
            if (dd != null)
            {
                //Get index
                int index = e.Row.RowIndex;

                dd.DataSource = reviewers.Select(re => new { name = re.getName() });
                dd.DataBind();

                dd.SelectedIndex = index;
            }
        }
    }
}