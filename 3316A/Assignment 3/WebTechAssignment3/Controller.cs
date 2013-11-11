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
        Band[] bands;
        Reviewer[] reviewers;

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
                this.bands = bands;
                this.reviewers = reviewers;
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
                // Run the new window
                run();
                
                // Add bands
                if (_ISSET)
                {
                    newView.initialize(bands);
                }
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
                    showMessage(false, "Valid XML file");
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
    }
}
