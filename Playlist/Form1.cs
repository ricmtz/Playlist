using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using HtmlAgilityPack;
using System.Net.Http;
using OpenQA.Selenium.Chrome;


namespace Playlist
{
    public partial class Form1 : Form
    {
        private CtrlSong ctrlSong;
        private CtrlScraper ctrlScraper;

        public Form1()
        {
            ctrlSong = new CtrlSong();
            ctrlScraper = new CtrlScraper();
            InitializeComponent();
            LoadDefaultSongs();
        }

        private void LoadDefaultSongs() {
            this.lstSongs.DataSource = ctrlSong.GetDefautlSongs();
            SetMetada(ctrlSong.InfoCurrSong());
            this.lstSongs.SelectedIndex = ctrlSong.IndexSong;
        }

        private void SetMetada(Song song) {
            this.txtArtist.Text = song.Artist;
            this.txtAlbum.Text = song.Album;
            this.txtYear.Text = song.Year.ToString();
            this.txtGender.Text = song.Gender;
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            this.folderBrowser.ShowNewFolderButton = true;
            DialogResult result = this.folderBrowser.ShowDialog();
            if (result == DialogResult.OK) {
                var path = this.folderBrowser.SelectedPath;
                String[] songs = Directory.GetFiles(path, "*.mp3");
                if(songs.Length > 0) {
                    this.lstSongs.DataSource = null;
                    ctrlSong.LoadSongsFromFolder(songs);
                    this.lstSongs.DataSource = ctrlSong.GetSongs();
                    SetMetada(ctrlSong.InfoCurrSong());
                } else {
                    string message = "This folder do not cotaints mp3 files";
                    string caption = "No songs found";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult alert;
                    alert = MessageBox.Show(message, caption, buttons);
                }
            }
        }

        private void btnPrevItem_Click(object sender, EventArgs e)
        {
            SetMetada(ctrlSong.PrevSong());
            this.lstSongs.SelectedIndex = ctrlSong.IndexSong;
        }

        private void btnNextItem_Click(object sender, EventArgs e)
        {
            SetMetada(ctrlSong.NextSong());
            this.lstSongs.SelectedIndex = ctrlSong.IndexSong;
        }

        private void btnFirstItem_Click(object sender, EventArgs e)
        {
            SetMetada(ctrlSong.FirstSong());
            this.lstSongs.SelectedIndex = ctrlSong.IndexSong;
        }

        private void btnLastItem_Click(object sender, EventArgs e)
        {
            SetMetada(ctrlSong.LastSong());
            this.lstSongs.SelectedIndex = ctrlSong.IndexSong;
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstSongs.SelectedIndex >= 0) {
                SetMetada(ctrlSong.SetCurrSong(this.lstSongs.SelectedIndex));
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ctrlSong.PlaySong();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ctrlSong.StopSong();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            ctrlSong.PauseSong();
        }


        private bool PrintResults()
        {
            List<string> results;
            results = ctrlScraper.GetResulsts();
            for(int i=0; i<3; i++)
            {
                String item = "ptrBox" + (i + 1);
                ((PictureBox)this.Controls.Find(item, true)[0]).ImageLocation = results.ElementAtOrDefault(i);
                ((PictureBox)this.Controls.Find(item, true)[0]).SizeMode = PictureBoxSizeMode.StretchImage;
            }
            return true;
        }

        private void GetResultsOfSearch()
        {
            String search = this.txtSearch.Text;
            search = search.Replace(" ", "+");
            ctrlScraper.Search(search, PrintResults);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetResultsOfSearch();
        }

        private void UpdateFilterSongs(Func<bool> filter)
        {
            if (filter())
            {
                this.lstSongs.DataSource = null;
                this.lstSongs.DataSource = ctrlSong.GetSongs();
                SetMetada(ctrlSong.InfoCurrSong());
            } else {
                MessageBox.Show("There is no songs with that duration", "No songs found", MessageBoxButtons.OK);
            }
        }

        private void itemShort_Click(object sender, EventArgs e)
        {
            UpdateFilterSongs(ctrlSong.FilterShortDuration);
        }

        private void itemMedium_Click(object sender, EventArgs e)
        {
            UpdateFilterSongs(ctrlSong.FilterMediumDuration);
        }

        private void itemLong_Click(object sender, EventArgs e)
        {
            UpdateFilterSongs(ctrlSong.FilterLongDuration);
        }

        private void itemReset_Click(object sender, EventArgs e)
        {
            ctrlSong.ReseatSongs();
            this.lstSongs.DataSource = ctrlSong.GetSongs();
            SetMetada(ctrlSong.InfoCurrSong());
        }
    }
}
