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
    public partial class AddAlbum : Form
    {
        private Controller _controller;
        private Album _album;
        private AlbumRow _row;
        private List<SongRow> songRows;
        private bool _isEdit;

        public AddAlbum(Controller c, Album a, AlbumRow r)
        {
            _controller = c;
            _album = a;
            _row = r;
            songRows = new List<SongRow>();

            InitializeComponent();

            this.nameBox.Text = a.getName();
            addSongRows(a.getSongs());
            if (a.getSongs().Length > 0)
                _isEdit = true;
            else
                _isEdit = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _controller.cancelAddAlbum();
            _controller.close(this);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (_controller.saveAlbum(this, _isEdit, this.nameBox.Text))
                _controller.close(this);
        }

        private void editSong_Click(object sender, EventArgs e)
        {
            _controller.editSong(this);
        }

        private void addSong_Click(object sender, EventArgs e)
        {
            _controller.addSong(this);
        }
        public void addSongRows(Song[] songs)
        {

            foreach (SongRow row in songRows)
            {
                this.Controls.Remove(row);
                this.Height -= row.Height;
            }

            SongRow lastRow = null;
            foreach (Song s in songs)
            {
                SongRow row = new SongRow(_controller, s, _album, this);
                this.Controls.Add(row);
                if (lastRow == null)
                    row.Top = this.songLabel.Top + this.songLabel.Height + 5;
                else
                    row.Top = lastRow.Top + lastRow.Height;

                lastRow = row;
                songRows.Add(row);

                this.Height += row.Height;
                row.Show();
            }
        }
        public void clearSongRows(SongRow[] rows)
        {
           // foreach (SongRow r in rows)
               // this.Controls.Remove(rows);
        }

        internal IEnumerable<SongRow> getSongRows()
        {
            return songRows.ToArray();
        }

        internal void enableEdit()
        {
            this.editSong.Enabled = true;
        }
        internal void disableEdit()
        {
            this.editSong.Enabled = false;
        }
    }
}
