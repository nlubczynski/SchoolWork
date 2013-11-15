using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebTechAssignment3
{
    public class Controller
    {
        Stack _views;
        Form _current_view;
        XMLReaderWriter readerWriter;
        bool _ISSET;
        List<Band> bands;
        List<Reviewer> reviewers;
        List<Member> addingMembers;
        Band bandHighlight;
        Member memberHighlight;
        Reviewer reviewerHighlight;
        Show showHighlight;
        Album albumHighlight;
        Review reviewHighlight;
        Song songHighlight;
        ShowRow showRowHighlight;
        List<Song> addingSongs;

        public Controller()
        {
            _views = new Stack();
            _ISSET = false;
        }

        public bool addView(Form f)
        {
            try
            {
                _views.Push(f);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public void initialize(Band[] bands, Reviewer[] reviewers)
        {
            if(bands != null && reviewers != null)
            {
                this.bands = new List<Band>();
                foreach(Band b in bands)
                    this.bands.Add(b);

                this.reviewers = new List<Reviewer>();
                foreach(Reviewer r in reviewers)
                    this.reviewers.Add(r);

                this._ISSET = true;
            }
        }
        public void run()
        {
            if (_current_view == null)
            {
                _current_view = (Form)_views.Pop();
                Application.Run(_current_view);
            }
            else
            {
                //Get the top form
                Form _temp = (Form)_views.Pop();
                //Store our current form
                _views.Push(_current_view);
                //Hide current form
                _current_view.Hide();
                //Set the new current form
                _current_view = _temp;
                //Run the new current form
                _current_view.Show();
            }
        }
        public void openFile(string filePath, MainMenu view, bool createNew)
        {
            if (createNew) 
            {
                this.initialize(new Band[0], new Reviewer[0]);
            }
            else
            {
                //Create the reader
                readerWriter = new XMLReaderWriter(filePath);
                //Read the file
                readerWriter.readXml();
                //Get the variables
                this.initialize(readerWriter.getBands(), readerWriter.getReviewers());
            }

            MainView newView = new MainView(this);
            if (addView(newView))
            {
                if (_ISSET)
                {
                    //initialize the new main view
                    newView.initialize(bands.ToArray(), reviewers.ToArray());
                    // Run the new window
                    run();
                }
                else
                    showMessage(true, "Cannot run new view");
            }
            else
                showMessage(true, "Cannot create new view");
        }
        public void validate(string filePath, MainMenu view)
        {

            if (File.Exists(filePath))
            {
                if (XMLReaderWriter.validateXml(filePath))
                {
                    if (!view.get_open_state())
                        view.set_open_state(true);
                }
                else
                    showMessage(true, "Invalid XML File, it does not match the schema");
            }
            else
                showMessage(true, "File does not exist");
        }
        public void openClick(string filePath, MainMenu view)
        {
            if (File.Exists(filePath))
                openFile(filePath, view, false);
            else
                showMessage(true, "File does not exist");
        }
        public void mainMenuTextChange(MainMenu view)
        {
            if (view.get_open_state())
                view.set_open_state(false);
        }
        public void showMessage(bool isError, string message)
        {
            if(isError)
                MessageBox.Show( message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show( message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void close()
        {
            _current_view = (Form)_views.Pop();
            _current_view.Show();
        }

        internal void addBand()
        {
            AddBand addBandView = new AddBand(this);
            addingMembers = new List<Member>();
            addBandView.Show();
        }

        internal void addMember(Form parent)
        {
            AddMember addMemberView = new AddMember(this, parent);
            addMemberView.Show();
        }

        internal void saveBand(string name, Member[] members, AddBand view, bool isEdit)
        {
            if (name.Length == 0)
                {
                    showMessage(true, "Must enter a band name");
                    return;
                }
            else if (members.Length == 0)
                {
                    showMessage(true, "Must add at least one member");
                    return;
                }

            if (isEdit)
            {
                //get index and remove
                //int index = bands.IndexOf(bandHighlight);
                //bands.RemoveAt(index);

                //Change the band info
                bandHighlight.setName(name);

                //remove and re-add members
                bandHighlight.removeMembers();
                foreach (Member m in members)
                    bandHighlight.addMember(m);

                //remove all rows
                ((MainView)_current_view).removeAllRows();

                //Reintialize the window
                ((MainView)_current_view).initialize(bands.ToArray(), reviewers.ToArray());
                //Close the add band view
                close(view);

                //disable edit / delete buttons
                ((MainView)_current_view).disableDelete(MainView.BANDS_TAB);
                ((MainView)_current_view).disableEdit(MainView.BANDS_TAB);
            }
            else
            {
                //Create a temp band
                Band b = new Band(name, members.Length.ToString());
                //Add the member
                foreach (Member m in members)
                    b.addMember(m);
                //Add Band
                bands.Add(b);
                //Reintialize the window
                ((MainView)_current_view).initialize(bands.ToArray(), reviewers.ToArray());
                //Close the add band view
                close(view);
            }
        }

        internal void close(Form f)
        {
            f.Close();
        }

        internal void saveMemeber(string name, string instrument, string joinDate, Form addMember, Form parent, bool isEdit)
        {
            //checks
            if (name.Length == 0)
            {
                showMessage(true, "Enter a name");
                return;
            }
            else if (instrument.Length == 0)
            {
                showMessage(true, "Enter an instrument");
                return;
            }
            else if (joinDate.Length == 0)
            {
                showMessage(true, "Enter a join date");
                return;
            }
            
            if (isEdit)
            {
                memberHighlight.setJoinDate(joinDate);
                memberHighlight.setName(name);
                memberHighlight.setInstrument(instrument);
                close(addMember);
                close(parent);
                editBand();
            }
            else
            {
                //Make new member
                Member m = new Member(name, instrument);
                m.setJoinDate(joinDate);
                //Add to parent view
                addMemeberToAddBandView(m, (AddBand)parent);
                //Close current view
                close(addMember);
            }
        }
        internal void addMemeberToAddBandView(Member m, AddBand view)
        {
            MemberRow row = new MemberRow(m, this, view, true);
            addingMembers.Add(m);
            //Place row
            row.Top = view.getInsertHeight() + view.getNumberOfMembers() * row.Height;
            //Adjust height of window
            view.Height += row.Height;
            //Add row
            view.incrementMembers(row);
        }

        internal Member[] getMembers()
        {
            return addingMembers.ToArray();
        }

        internal void highlightBand(BandRow row)
        {
            //Set highlighted one green
            row.setGreen();
            //Set all others normal
            foreach (BandRow r in ((MainView)_current_view).getBandRows())
                if (!r.Equals(row))
                    r.setNormal();

            //Set it to our "focus"
            bandHighlight = row.getModel();

            //Set up "Edit" and "Delete" Buttons
            ((MainView)_current_view).enableEdit(MainView.BANDS_TAB);
            ((MainView)_current_view).enableDelete(MainView.BANDS_TAB);

            //Change the band tab name
            ((MainView)_current_view).setBandTabName(bandHighlight.getName());
        }

        internal void removeBand()
        {
            //Remove the band from controller
            bands.Remove(bandHighlight);
            //Remove band from view
            ((MainView)_current_view).removeAllRows();
            ((MainView)_current_view).initialize(bands.ToArray(), reviewers.ToArray());

            //We have no highighted band now
            bandHighlight = null;
            //Disable edit and delete buttons
            ((MainView)_current_view).disableEdit(MainView.BANDS_TAB);
            ((MainView)_current_view).disableDelete(MainView.BANDS_TAB);

            //Change the band tab name
            ((MainView)_current_view).setBandTabName("Select a band");

            saveXML();
        }

        internal void editBand()
        {
            AddBand addBandView = new AddBand(bandHighlight.getName(), this);
            addingMembers = new List<Member>();
            foreach(Member m in bandHighlight.getMembers())
            {
                addMemeberToAddBandView(m,addBandView);
            }
            addBandView.Show();
        }

        internal void editMember(Form parent)
        {
            AddMember addMemberView = new AddMember(memberHighlight.getName(), memberHighlight.getInstrument(), memberHighlight.getJoinDate(), this, parent);
            addMemberView.Show();
        }

        internal void highlightMember(MemberRow memberRow, Member m, Form parent)
        {
            if ( _views.Contains(parent) || _current_view.Equals(parent) )
            {
                //We don't want this to do anything on the mainview
            }
            else
            {
                //Set our highlighted one
                memberHighlight = m;

                // Make it green
                memberRow.setGreen();
                //Make the others not green
                foreach (MemberRow row in ((AddBand)parent).getRows())
                    if (!row.Equals(memberRow))
                        row.setNormal();

                //enable edit button
                ((AddBand)parent).enableEdit();
            }

        }

        internal void removeMember(AddBand parent, AddMember view)
        {
            //Remove from addingMembers
            addingMembers.Remove(memberHighlight);

            //Remove all member rows from addBand view
            parent.removeAllRows();

            //Change the real model
            //bandHighlight.removeMembers();
            //foreach (Member m in addingMembers.ToArray())
              //  bandHighlight.addMember(m);

            //size
            bandHighlight.setSize(addingMembers.Count.ToString());

            //reset addingMembers
            //addingMembers = new List<Member>();

            //re-add rows
            foreach (Member m in addingMembers.ToArray())
            {
                addingMembers.Remove(m);
                addMemeberToAddBandView(m, parent);
            }

            //Close the form
            view.Close();

            //reinitiate the window
            //remove all rows
            ((MainView)_current_view).removeAllRows();

            //Reintialize the window
            ((MainView)_current_view).initialize(bands.ToArray(), reviewers.ToArray());

            //disable edit / delete buttons
            ((MainView)_current_view).disableDelete(MainView.BANDS_TAB);
            ((MainView)_current_view).disableEdit(MainView.BANDS_TAB);
        }

        internal void addReviewer()
        {
            AddReviewer addReviewerView = new AddReviewer(this);
            addReviewerView.Show();
        }

        internal void editReviewer()
        {
            AddReviewer addReviewerView = new AddReviewer(this, reviewerHighlight.getName(),
                reviewerHighlight.getCompany(), reviewerHighlight.getId());
            addReviewerView.Show();
        }

        internal void removeReviewer()
        {
            //remove reviewer from list
            reviewers.Remove(reviewerHighlight);

            //remove all the rows
            ((MainView)_current_view).removeAllRows();

            // reinitiate
            ((MainView)_current_view).initialize(bands.ToArray(), reviewers.ToArray());

            //disable buttons
            ((MainView)_current_view).disableDelete(MainView.REVIEWER_TAB);
            ((MainView)_current_view).disableEdit(MainView.REVIEWER_TAB);
        }

        internal void selectReviewer(ReviewerRow reviewerRow, Reviewer _model)
        {
            //Set them all normal
            foreach (ReviewerRow row in ((MainView)reviewerRow.getParent()).getReviewerRows())
                row.setNormal();

            //Set ours green
            reviewerRow.setGreen();

            //Make it the highlighted one
            reviewerHighlight = _model;

            //enable the buttons
            ((MainView)reviewerRow.getParent()).enableDelete(MainView.REVIEWER_TAB);
            ((MainView)reviewerRow.getParent()).enableEdit(MainView.REVIEWER_TAB);

        }

        internal bool saveReviewer(string name, string company, string id, bool isEdit)
        {
            //id must be unique
            foreach(Reviewer r in reviewers)
                if(r.getId().Equals(id) && !r.Equals(reviewerHighlight) )
                {
                    showMessage(true, "ID must be unique");
                    return false;
                }

            if (isEdit)
            {
                reviewerHighlight.setName(name);
                reviewerHighlight.setCompany(company);
                reviewerHighlight.setId(id);
            }
            else
            {
                Reviewer r = new Reviewer(id);
                r.setName(name);
                r.setCompany(company);

                //Add new reviewer to list
                reviewers.Add(r);
            }

            //remove all rows
            ((MainView)_current_view).removeAllRows();

            //reinitate the window
            ((MainView)_current_view).initialize(bands.ToArray(), reviewers.ToArray());

            return true;
        }

        internal bool canBandtab()
        {
            if (bandHighlight != null)
            {
                ((MainView)_current_view).initializeBandTab(bandHighlight);
                return true;
            }
            else
            {
                showMessage(true, "You must select a band first");
                return false;
            }
        }

        internal Reviewer getReviewer(string p)
        {
            foreach (Reviewer r in reviewers)
                if (r.getId().Equals(p))
                    return r;

            return null;
        }
        public void albumClick(AlbumRow row, Album album)
        {
            foreach (AlbumRow ar in ((MainView)_current_view).getAlbumRows())
                ar.setNormal();
            row.setGreen();

            //set highlight
            albumHighlight = album;

            //enable album buttons
            ((MainView)_current_view).enableEdit(MainView.BAND_TAB_ALBUM);
            ((MainView)_current_view).enableDelete(MainView.BAND_TAB_ALBUM);
            ((MainView)_current_view).enableAddReview();

        }
        public void songClick(SongRow row, Song s, Album a, AddAlbum view)
        {

            foreach(SongRow srow in view.getSongRows())
                srow.setNormal();
            row.setGreen();

            songHighlight = s;

            view.enableEdit();
        }
        public void reviewClick(ReviewRow row, Review r, Album a, AlbumRow arow)
        {
            foreach (ReviewRow rrow in ((MainView)_current_view).getReviewRows())
                rrow.setNormal();

            reviewHighlight = r;

            row.setGreen();

            albumClick(arow, a);

            //enable review buttons
            ((MainView)_current_view).enableEdit(MainView.BAND_TAB_REVIEW);
            ((MainView)_current_view).enableDelete(MainView.BAND_TAB_REVIEW);
        }
        public void showClick(ShowRow row, Show s)
        {
            //Set them all normal
            foreach (ShowRow r in ((MainView)_current_view).getShowRows())
                r.setNormal();

            //set ours green
            row.setGreen();

            showRowHighlight = row;
            showHighlight = s;

            //enable show buttons
            ((MainView)_current_view).enableEdit(MainView.BAND_TAB_SHOW);
            ((MainView)_current_view).enableDelete(MainView.BAND_TAB_SHOW);
        }

        internal void addAlbum()
        {
            albumHighlight = new Album("No Name");
            AddAlbum addAlbumView = new AddAlbum(this, albumHighlight, null);
            addAlbumView.Show();      
        }

        internal bool saveAlbum(AddAlbum addAlbum, bool isEdit, string name)
        {
            albumHighlight.setName(name);
            if(addingSongs != null)
                foreach (Song s in addingSongs)
                    albumHighlight.addSong(s);

            if(!isEdit)
                bandHighlight.addAlbum(albumHighlight);

            //DISABLE album buttons
            ((MainView)_current_view).disableEdit(MainView.BAND_TAB_ALBUM);
            ((MainView)_current_view).disableDelete(MainView.BAND_TAB_ALBUM);
            ((MainView)_current_view).disableAddReview();

            ((MainView)_current_view).initializeBandTab(bandHighlight);

            saveXML();

            return true;
        }
        internal void editAlbum()
        {
            AddAlbum addAlbumView = new AddAlbum(this, albumHighlight, null);
            addAlbumView.Show();
        }
        internal void removeAlbum()
        {
            bandHighlight.removeAlbum(albumHighlight);
            ((MainView)_current_view).initializeBandTab(bandHighlight);
            //DISABLE album buttons
            ((MainView)_current_view).disableEdit(MainView.BAND_TAB_ALBUM);
            ((MainView)_current_view).disableDelete(MainView.BAND_TAB_ALBUM);
            ((MainView)_current_view).disableAddReview();

            saveXML();

        }
        internal void editSong(AddAlbum addAlbum)
        {
            AddSong addSongView = new AddSong(this, addAlbum, songHighlight.getName(), songHighlight.getlength());
            addSongView.Show();
        }

        internal void addSong(AddAlbum addAlbum)
        {
            AddSong addSongView = new AddSong(this, addAlbum);
            addSongView.Show();
            addingSongs = new List<Song>();
        }

        internal bool saveSong(AddSong addSong, string name, string length, bool isEdit, AddAlbum view)
        {
            if (name.Length == 0)
            {
                showMessage(true, "Song must have a name");
                return false;
            }
            else if (length.Length == 0)
            {
                showMessage(true, "Song must have a length");
                return false;
            }
            else if (!length.StartsWith("PT"))
            {
                showMessage(true, "Song length must be of format: PT##M##S");
                return false;
            }

            if (SongRow.parseTime(length).Equals("ERROR"))
            {
                showMessage(true, "Song length must be of format: PT##M##S");
                return false;
            }
            

            if (isEdit)
            {
                songHighlight.setName(name);
                songHighlight.setLength(length);
            }
            else
            {
                Song s = new Song();
                s.setName(name);
                s.setLength(length);
                addingSongs.Add(s);
                songHighlight = s;
            }

            List<Song> temp = new List<Song>();
            temp.AddRange(albumHighlight.getSongs());
            if(addingSongs != null)
                temp.AddRange(addingSongs);

            view.addSongRows(temp.ToArray());

            return true;
        }

        internal void cancelAddAlbum()
        {
            addingSongs = new List<Song>();
        }

        internal void removeSong(AddAlbum view)
        {
            if(addingSongs != null)
                addingSongs.Remove(songHighlight);
            albumHighlight.removeSong(songHighlight);

            List<Song> temp = new List<Song>();
            temp.AddRange(albumHighlight.getSongs());
            if(addingSongs != null)
                temp.AddRange(addingSongs);

            view.addSongRows(temp.ToArray());

            //Disable buttons
            view.disableEdit();
        }

        internal void addReview()
        {
            AddReview addReviewView = new AddReview(this, reviewers.ToArray(), false);
            addReviewView.Show();
        }

        internal void editReview()
        {
            AddReview addReviewView = new AddReview(this, reviewers.ToArray(), true,  reviewHighlight);
            addReviewView.Show();
        }

        internal void removeReview()
        {
            albumHighlight.removeReview(reviewHighlight);

            ((MainView)_current_view).initializeBandTab(bandHighlight);
            ((MainView)_current_view).disableEdit(MainView.BAND_TAB_REVIEW);
            ((MainView)_current_view).disableDelete(MainView.BAND_TAB_REVIEW);
            ((MainView)_current_view).disableEdit(MainView.BAND_TAB_ALBUM);
            ((MainView)_current_view).disableDelete(MainView.BAND_TAB_ALBUM);

            saveXML();
        }

        internal bool saveReviewer(Reviewer reviewer, string review, bool isEdit)
        {
            if (reviewer == null)
            {
                showMessage(true, "Must select a reviewer");
                return false;
            }
            if (review.Length == 0)
            {
                showMessage(true, "Must enter a review");
                return false;
            }

            if (isEdit)
            {
                reviewHighlight.setReviewerId(reviewer.getId());
                reviewHighlight.setReview(review);
            }
            else
            {
                Review r = new Review(reviewer.getId());
                r.setReview(review);
                albumHighlight.addReview(r);
            }

            ((MainView)_current_view).initializeBandTab(bandHighlight);
            ((MainView)_current_view).disableEdit(MainView.BAND_TAB_REVIEW);
            ((MainView)_current_view).disableDelete(MainView.BAND_TAB_REVIEW);
            ((MainView)_current_view).disableEdit(MainView.BAND_TAB_ALBUM);
            ((MainView)_current_view).disableDelete(MainView.BAND_TAB_ALBUM);

            saveXML();

            return true;
        }

        internal bool saveShow(string date, string venue, bool _isEdit, int index)
        {
            if (_isEdit)
            {
                showHighlight.setDate(index, date);
                showHighlight.setVenue(index, venue);
            }
            else
            {
                showHighlight.addDate(date);
                showHighlight.addVenue(venue);
            }

            ((MainView)_current_view).initializeBandTab(bandHighlight);
            ((MainView)_current_view).disableEdit(MainView.BAND_TAB_SHOW);
            ((MainView)_current_view).disableDelete(MainView.BAND_TAB_SHOW);

            saveXML();

            return true;
        }

        internal void addShow()
        {
            if (showHighlight == null)
            {
                if (bandHighlight.getShows().Length > 0)
                    showHighlight = bandHighlight.getShows()[0];
            }
            else if (!bandHighlight.getShows().Contains(showHighlight))
            {
                if (bandHighlight.getShows().Length > 0)
                    showHighlight = bandHighlight.getShows()[0];
            }
            else
            {
                bandHighlight.addShow(new Show());
                showHighlight = bandHighlight.getShows()[0];
            }
                   

            AddShow addShowView = new AddShow(this, false, 0);
            addShowView.Show();
        }

        internal void editShow()
        {
            int index = ((MainView)_current_view).getIndexOfShowRow(showRowHighlight);
            AddShow addShowView = new AddShow(this, true, index, showHighlight.getDates()[index], showHighlight.getVenues()[index]);
            addShowView.Show();
        }

        internal void removeShow()
        {
            int index = ((MainView)_current_view).getIndexOfShowRow(showRowHighlight);

            showHighlight.removeDate(index);
            showHighlight.removeVenue(index);

            ((MainView)_current_view).initializeBandTab(bandHighlight);
            ((MainView)_current_view).disableEdit(MainView.BAND_TAB_SHOW);
            ((MainView)_current_view).disableDelete(MainView.BAND_TAB_SHOW);

            saveXML();
        }
        private void saveXML()
        {
            readerWriter.writeXML(bands.ToArray(), reviewers.ToArray());
        }


        internal void openBand()
        {
            OpenBand openBandView = new OpenBand(this, bands.ToArray());
            openBandView.Show();
        }

        internal void openBandResult(object p)
        {
            bandHighlight = (Band)p;
            ((MainView)_current_view).setBandTabName(bandHighlight.getName());
            ((MainView)_current_view).switchToBandtab(bandHighlight);
        }
    }
}
