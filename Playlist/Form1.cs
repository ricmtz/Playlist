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
using ScrapySharp.Network;

namespace Playlist
{
    public partial class Form1 : Form
    {
        private CtrlSong ctrlSong;
        public Form1()
        {
            ctrlSong = new CtrlSong();
            InitializeComponent();
            LoadDefaultSongs();
            Scraper();
        }

        private void Scraper() {
            ScrapingBrowser browser = new ScrapingBrowser();
            WebPage homePage = browser.NavigateToPage(new Uri("https://www.youtube.com/results?search_query=transistor+ost"));
            var divs = homePage.Html.SelectNodes("//*[@id=\"contents\"]/ytd-video-renderer");
            Console.WriteLine(divs);
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
            this.folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                var path = this.folderBrowserDialog1.SelectedPath;
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
    }
}
