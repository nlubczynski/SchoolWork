﻿using System;
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
                    newView.initialize(bands.ToArray());
                    // Run the new window
                    run();
                }
                else
                    showMessage(true, "Cannot create new view");
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
                }
            else if (members.Length == 0)
                {
                    showMessage(true, "Must add at least one member");
                }

            if (isEdit)
            {
                //get index and remove
                //int index = bands.IndexOf(bandHighlight);
                //bands.RemoveAt(index);

                //Change the band info
                bandHighlight.setName(name);

                //insert
               // bands.Insert(index, bandHighlight);    
            
                //remove all rows
                ((MainView)_current_view).removeAllRowsTab1();

                //Reintialize the window
                ((MainView)_current_view).initialize(bands.ToArray());
                //Close the add band view
                close(view);

                //disable edit / delete buttons
                ((MainView)_current_view).disableDelete();
                ((MainView)_current_view).disableEdit();
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
                ((MainView)_current_view).initialize(bands.ToArray());
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
                    showMessage(true, "Enter a name");
                else if (instrument.Length == 0)
                    showMessage(true, "Enter an instrument");
                else if (joinDate.Length == 0)
                    showMessage(true, "Enter a join date");
            
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
            foreach (BandRow r in ((MainView)_current_view).getRows())
                if (!r.Equals(row))
                    r.setNormal();

            //Set it to our "focus"
            bandHighlight = row.getModel();

            //Set up "Edit" and "Delete" Buttons
            ((MainView)_current_view).enableEdit();
            ((MainView)_current_view).enableDelete();
        }

        internal void removeBand()
        {
            //Remove the band from controller
            bands.Remove(bandHighlight);
            //Remove band from view
            ((MainView)_current_view).removeAllRowsTab1();
            ((MainView)_current_view).initialize(bands.ToArray());

            //We have no highighted band now
            bandHighlight = null;
            //Disable edit and delete buttons
            ((MainView)_current_view).disableEdit();
            ((MainView)_current_view).disableDelete();
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
            bandHighlight.removeMembers();
            foreach (Member m in addingMembers.ToArray())
                bandHighlight.addMember(m);
            //size
            bandHighlight.setSize(addingMembers.Count.ToString());

            //reset addingMembers
            addingMembers = new List<Member>();

            //re-add rows
            foreach (Member m in bandHighlight.getMembers())
            {
                addMemeberToAddBandView(m, parent);
            }

            //Close the form
            view.Close();

            //reinitiate the window
            //remove all rows
            ((MainView)_current_view).removeAllRowsTab1();

            //Reintialize the window
            ((MainView)_current_view).initialize(bands.ToArray());

            //disable edit / delete buttons
            ((MainView)_current_view).disableDelete();
            ((MainView)_current_view).disableEdit();
        }
    }
}
