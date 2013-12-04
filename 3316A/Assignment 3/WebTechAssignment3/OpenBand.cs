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
    public partial class OpenBand : Form
    {
        Controller _controller;
        Band[] _bands;
        List<Album> albums;
        List<Show> shows;

        public OpenBand(Controller c, Band[] bands)
        {
            _controller = c;
            _bands = bands;
            InitializeComponent();

            this.nameBox.Items.AddRange(bands);

            albums = new List<Album>();
            shows = new List<Show>();
            foreach (Band b in bands)
            {
                albums.AddRange(b.getAlbums());
                shows.AddRange(b.getShows());
            }

            this.albumBox.Items.AddRange(albums.ToArray());

            foreach (Show s in shows)
                this.showBox.Items.AddRange(s.getDates());

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _controller.close(this);
        }

        private void nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = this.showBox.Items.Count - 1; i >= 0 ; i--)
                this.showBox.Items.RemoveAt(i);
            for (int i = this.albumBox.Items.Count - 1; i >= 0; i--)
                this.albumBox.Items.RemoveAt(i);

            this.albumBox.Items.AddRange(albums.ToArray());

            foreach (Show s in shows)
                this.showBox.Items.AddRange(s.getDates());

            Band band = (Band)this.nameBox.SelectedItem;

            foreach(Band b in _bands)
                if (!b.Equals(band))
                {
                    foreach (Show s in b.getShows())
                        foreach(string date in s.getDates())
                        this.showBox.Items.Remove(date);
                    foreach (Album a in b.getAlbums())
                        this.albumBox.Items.Remove(a);
                }

            this.showBox.SelectedItem = null;
            this.albumBox.SelectedItem = null;

        }

        private void open_Click(object sender, EventArgs e)
        {
            if (this.nameBox.SelectedItem != null)
            {
                _controller.openBandResult(this.nameBox.SelectedItem);
                _controller.close(this);
            }
            else
                _controller.showMessage(true, "Select more data");
        }

        private void showBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string showDate = (string)this.showBox.SelectedItem;

            bool isSingle = true;
            Band b = null;

            foreach (Band ba in _bands)
                foreach (Show s in ba.getShows())
                    foreach (string date in s.getDates())
                        if (b == null && date.Equals(showDate))
                            b = ba;
                        else if (b != null && date.Equals(showDate))
                            isSingle = false;

            if (isSingle && b != null)
                this.nameBox.SelectedItem = b;

            this.showBox.SelectedItem = showDate;
        }

        private void albumBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album a = (Album)this.albumBox.SelectedItem;
            string albumName = a.getName();

            bool isSingle = true;
            Band b = null;

            foreach (Band ba in _bands)
                foreach (Album al in ba.getAlbums())
                        if (b == null && albumName.Equals(al.getName()))
                            b = ba;
                        else if (b != null && albumName.Equals(al.getName()))
                            isSingle = false;

            if (isSingle && b != null)
                this.nameBox.SelectedItem = b;

            this.albumBox.SelectedItem = a;
        }

    }
}
