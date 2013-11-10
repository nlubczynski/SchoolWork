using System;
using System.Collections;
using System.Collections.Generic;
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

        public Controller()
        {
            _views = new Stack();
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
                //Set the new current form
                _current_view = _temp;
                //Run the new current form
                Application.Run(_current_view);
            }
        }
        public void openFile(string filePath)
        {
            readerWriter = new XMLReaderWriter(filePath);
        }
        public void validate(string filePath)
        {
            if(XMLReaderWriter.validateXml(filePath))
                Console.Out.Write("Valid");
            else
                Console.Out.Write("Not Valid");
        }
    }
}
