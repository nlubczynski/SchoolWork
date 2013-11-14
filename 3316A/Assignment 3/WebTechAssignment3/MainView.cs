using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebTechAssignment3
{
    public partial class MainView : Form
    {
        private Controller _controller;
        private Band[] _b;
        private List<BandRow> bandRows;
        private List<ReviewerRow> reviewerRows;
        private List<AlbumRow> albumRows;
        private List<ShowRow> showRows;
        private List<ReviewRow> reviewRows;
        private List<SongRow> songRows;
        private Label showLabel;
        public const int BANDS_TAB = 0;
        public const int REVIEWER_TAB = 1;
        public const int BAND_TAB_ALBUM = 2;
        public const int BAND_TAB_REVIEW = 3;
        public const int BAND_TAB_SHOW = 4;

        public MainView(Controller c)
        {
            InitializeComponent();
            this._controller = c;
            this.UseWaitCursor = false;
            this.tabs.Cursor = this.Cursor;
            this.bandRows = new List<BandRow>();
            this.reviewerRows = new List<ReviewerRow>();
            this.albumRows = new List<AlbumRow>();
            this.showRows = new List<ShowRow>();
            this.reviewRows = new List<ReviewRow>();
            this.songRows = new List<SongRow>();
           
        }
        public void initialize(Band[] bandsSource, Reviewer[] reviewersSource)
        {
            //Bands Tab
            int i = 0;
            Control lastControl = null;
            foreach (Band band in bandsSource)
            {
                BandRow row = new BandRow(band, _controller, this, false);
                //match parent's width
                row.Width = bandsTab.Width;
                //add the row
                this.bandsTab.Controls.Add(row);
                //adjust the height
                row.initialize();
                //move it down
                if (lastControl != null)
                    row.Top = lastControl.Top + lastControl.Height;
                else
                    row.Top = 0;
                //Store the "last control"
                lastControl = row;
                //Add it to the row list
                bandRows.Add((BandRow)lastControl);
                //increment placement
                i++;
            }
           
            //Reviewer Tab
            i = 0;
            lastControl = null;
            foreach (Reviewer reviewer in reviewersSource)
            {
                ReviewerRow row = new ReviewerRow(reviewer, _controller, this);
                //match parent's width
                row.Width = bandsTab.Width;
                //add the row
                this.reviewersTab.Controls.Add(row);
                //adjust the height
                row.initialize();
                //move it down
                if (lastControl != null)
                    row.Top = lastControl.Top + lastControl.Height;
                else
                    row.Top = 0;
                //Store the "last control"
                lastControl = row;
                //Add it to the row list
                reviewerRows.Add((ReviewerRow)lastControl);
                //increment placement
                i++;
            }
        }
        public void initializeBandTab(Band b)
        {
            //remove exist rows
            foreach (AlbumRow row in albumRows)
                this.bandTab.Controls.Remove(row);
            foreach (ShowRow row in showRows)
                this.bandTab.Controls.Remove(row);
            if (this.showLabel != null)
                this.bandTab.Controls.Remove(showLabel);

            int i = 0;
            Control lastControl = null;
            foreach (Album a in b.getAlbums())
            {
                AlbumRow row = new AlbumRow(_controller, a);
                //match parent's width
                row.Width = bandsTab.Width;
                //add the row
                this.bandTab.Controls.Add(row);
                //adjust the height
                row.initialize();
                //move it down
                if (lastControl != null)
                    row.Top = lastControl.Top + lastControl.Height;
                else
                    row.Top = 0;
                //Store the "last control"
                lastControl = row;
                //Add it to the row list
                albumRows.Add((AlbumRow)lastControl);
                //increment placement
                i++;

                Control lastSongControl = null;
                int j = 0;
                //Add songs to it
                foreach (Song s in a.getSongs())
                {
                    SongRow srow = new SongRow(_controller, s, a, row);

                    srow.Width = bandsTab.Width;
                    lastControl.Controls.Add(srow);
                    srow.initialize();
                    if (lastSongControl != null)
                        srow.Top = lastSongControl.Top + lastSongControl.Height;
                    else { 
                        srow.Top = row.Top + row.Height + 5;
                        row.Height += 5;
                    }

                    lastSongControl = srow;
                    songRows.Add(srow);
                    row.Height += srow.Height;

                    j++;
                    
                }

                Control lastReviewControl = null;
                int k = 0;
                //Add songs to it
                foreach (Review r in a.getReviews())
                {
                    ReviewRow rrow = new ReviewRow(_controller, r, a, row);

                    rrow.Width = bandsTab.Width;
                    lastControl.Controls.Add(rrow);
                    rrow.initialize();
                    if (lastReviewControl != null)
                        rrow.Top = lastSongControl.Top + lastSongControl.Height;
                    else
                    {
                        rrow.Top = row.Top + row.Height + 5;
                        row.Height += 5;
                    }

                    lastReviewControl = rrow;
                    reviewRows.Add(rrow);
                    row.Height += rrow.Height;

                    k++;

                }
            }
            showLabel = new Label();
            showLabel.Text = "Shows";
            showLabel.Font = new Font(showLabel.Font.FontFamily, 15);
            showLabel.Top = lastControl.Top + lastControl.Height + 5;

            this.bandTab.Controls.Add(showLabel);

            Control lastShowControl = null;
            int l = 0;
            //Add songs to it
            foreach (Show s in b.getShows())
            {
                for (int m = 0; m < s.getDates().Length; m++)
                {
                    ShowRow srow = new ShowRow(_controller, s, s.getVenues()[m], s.getDates()[m]);
                    showRows.Add(srow);
                    srow.Width = bandsTab.Width;
                    this.bandTab.Controls.Add(srow);
                    srow.initialize();
                    if (lastShowControl != null)
                        srow.Top = lastShowControl.Top + lastShowControl.Height;
                    else
                    {
                        srow.Top = showLabel.Top + showLabel.Height + 5;
                    }

                    lastShowControl = srow;

                    l++;
                }

            }

        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabs.SelectedTab == this.bandTab)
                if (_controller.canBandtab())
                    this.tabs.SelectedTab = this.bandTab;
                else
                    this.tabs.SelectedTab = this.bandsTab;
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
        public void addBandElement(Panel p)
        {
            this.Controls.Add(p);
        }
        private void closed(object sender, EventArgs e)
        {
            _controller.close();
        }

        private void addBand_Click(object sender, EventArgs e)
        {
            _controller.addBand();
        }

        private void editBand_Click(object sender, EventArgs e)
        {
            _controller.editBand();
        }

        private void removeBand_Click(object sender, EventArgs e)
        {
            _controller.removeBand();
        }
        public BandRow[] getBandRows()
        {
            return this.bandRows.ToArray();
        }
        public ReviewerRow[] getReviewerRows()
        {
            return this.reviewerRows.ToArray();
        }

        internal void enableEdit(int tabId)
        {
            switch (tabId)
            {
                case BANDS_TAB:
                    this.editBand.Enabled = true;
                    break;
                case REVIEWER_TAB:
                    this.editReviewer.Enabled = true;
                    break;
                case BAND_TAB_ALBUM:
                    this.editAlbumButton.Enabled = true;
                    break;
                case BAND_TAB_REVIEW:
                    this.editReviewButton.Enabled = true;
                    break;
                case BAND_TAB_SHOW:
                    this.editShowButton.Enabled = true;
                    break;
            }
        }

        internal void enableDelete(int tabId)
        { 
            switch (tabId)
            {
                case BANDS_TAB:
                    this.removeBand.Enabled = true;
                    break;
                case REVIEWER_TAB:
                    this.removeReviewer.Enabled = true;
                    break;
                case BAND_TAB_ALBUM:
                    this.removeAlbumButton.Enabled = true;
                    break;
                case BAND_TAB_REVIEW:
                    this.removeReviewButton.Enabled = true;
                    break;
                case BAND_TAB_SHOW:
                    this.removeShowButton.Enabled = true;
                    break;
            }
        }
        public void disableEdit(int tabId)
        {
            switch (tabId)
            {
                case BANDS_TAB:
                    this.editBand.Enabled = false;
                    break;
                case REVIEWER_TAB:
                    this.editReviewer.Enabled = false;
                    break;
                case BAND_TAB_ALBUM:
                    this.editAlbumButton.Enabled = false;
                    break;
                case BAND_TAB_REVIEW:
                    this.editReviewButton.Enabled = false;
                    break;
                case BAND_TAB_SHOW:
                    this.editShowButton.Enabled = false;
                    break;
            }
        }
        public void disableDelete(int tabId)
        {
            switch (tabId)
            {
                case BANDS_TAB:
                    this.removeBand.Enabled = false;
                    break;
                case REVIEWER_TAB:
                    this.removeReviewer.Enabled = false;
                    break;
                case BAND_TAB_ALBUM:
                    this.removeAlbumButton.Enabled = false;
                    break;
                case BAND_TAB_REVIEW:
                    this.removeReviewButton.Enabled = false;
                    break;
                case BAND_TAB_SHOW:
                    this.removeShowButton.Enabled = false;
                    break;
            }
        }

        public void removeAllRows()
        {
            foreach (BandRow row in bandRows)
                this.bandsTab.Controls.Remove(row);

            foreach (ReviewerRow row in reviewerRows)
                this.reviewersTab.Controls.Remove(row);
        }

        private void addReviewer_Click(object sender, EventArgs e)
        {
            _controller.addReviewer();
        }

        private void editReviewer_Click(object sender, EventArgs e)
        {
            _controller.editReviewer();
        }

        private void removeReviewer_Click(object sender, EventArgs e)
        {
            _controller.removeReviewer();
        }

        internal void setBandTabName(string p)
        {
            this.bandTab.Text = p;
        }

        internal AlbumRow[] getAlbumRows()
        {
            return this.albumRows.ToArray();
        }
        internal ReviewRow[] getReviewRows()
        {
            return this.reviewRows.ToArray();
        }
        internal ShowRow[] getShowRows()
        {
            return this.showRows.ToArray();
        }
        internal SongRow[] getSongRows()
        {
            return this.songRows.ToArray();
        }
    }
}
