using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WebTechAssignment3
{
    class XMLReaderWriter
    {
        private string filePath;
        private ArrayList bands;
        private ArrayList reviewers;

        public XMLReaderWriter(string filePath)
        {
            this.filePath = filePath;
            bands = new ArrayList();
            reviewers = new ArrayList();
        }

        public void readXml()
        {
            //Load the document
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);

            //Load the reader
             XmlNodeReader reader = new XmlNodeReader(xmlDocument);

             Band lastBand = null;

            //Parse the document
             while (reader.Read())
             {

                 if (reader.NodeType == XmlNodeType.Element)
                 {
                     if (reader.Name == "band") lastBand = bandParser(reader);
                     else if (reader.Name == "member")
                     {
                         lastBand.addMember(memberParser(reader));
                     }
                     else if (reader.Name == "album")
                     {
                         lastBand.addAlbum(albumParser(reader));
                     }
                     else if (reader.Name == "show")
                     {
                         lastBand.addShow(showParser(reader));
                     }
                     else if (reader.Name == "reviewer")
                     {
                         reviewers.Add(reviewerParser(reader));
                     }
                 }
                 else if (reader.NodeType == XmlNodeType.EndElement)
                     if (reader.Name == "band")
                         bands.Add(lastBand);
             }
        }
        public static bool validateXml(string filePath)
        {
            try
            {
                // Get the Schema
                string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\xsd\";
                string filter = "schema.xsd";
                string[] files = Directory.GetFiles(folder, filter);

                // Create a reader that uses the schema
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, files[0]);
                settings.ValidationType = ValidationType.Schema;
                settings.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(settings_ValidationEventHandler);

                // Create the xml document, using the schema settings
                XmlDocument document = new XmlDocument();
                document.Load(filePath);
                XmlReader reader = XmlReader.Create(new StringReader(document.InnerXml), settings);

                // Read the file - if it's not valid it will throw an exception
                while (reader.Read()) ;
            }
            catch(NotImplementedException e)
            {
                return false;
            }
            return true;
        }

        private static void settings_ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e)
        {
            throw new NotImplementedException();
        }

        public Band[] getBands()
        {
            if(bands.Count > 0)
                return (Band[])this.bands.ToArray(typeof(Band));
            else
                throw new Exception();
        }
        public Reviewer[] getReviewers()
        {
            if(reviewers.Count > 0)
                return (Reviewer[])this.reviewers.ToArray(typeof(Reviewer));
            else
                throw new Exception();
        }

        private Band bandParser(XmlNodeReader reader)
        {
            string name = reader.GetAttribute("name");
            string size = reader.GetAttribute("size");

            return new Band(name, size);

        }
        private Member memberParser(XmlNodeReader reader)
        {
            string name = reader.GetAttribute("name");
            string instrument = reader.GetAttribute("instrument");

            Member m = new Member(name, instrument);
            reader.Read();
            m.setJoinDate(reader.Value);

            return m;
        }
        private Album albumParser(XmlNodeReader reader)
        {
            string name = reader.GetAttribute("name");
            Album a = new Album(name);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "song")
                    {
                        Song s = new Song();
                        reader.Read();
                        s.setName(reader.Value);
                        reader.Read();
                        s.setLength(reader.Value);

                        a.addSong(s);
                    }
                    if (reader.Name == "reviewer")
                    {
                        Review r = new Review(reader.GetAttribute("ref"));
                        reader.Read();
                        r.setReview(reader.Value);

                        a.addReviewer(r);
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                    if (reader.Name == "album")
                        break;
            }

            return a;
        }
        private Show showParser(XmlNodeReader reader)
        {
            Show s = new Show();

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "date")
                    {
                        s.addDate(reader.Value);
                        reader.Read();
                        s.addVenue(reader.Value);
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                    if (reader.Name == "show")
                        break;
            }

            return s;
        }
        private Reviewer reviewerParser(XmlNodeReader reader)
        {
            Reviewer r = new Reviewer(reader.GetAttribute("id"));
            reader.Read();
            r.setName(reader.Value);
            reader.Read();
            r.setCompany(reader.Value);

            return r;
        }
    }
}
