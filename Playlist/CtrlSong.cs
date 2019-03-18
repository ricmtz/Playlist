using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class CtrlSong
    {
        private List<Song> songs;
        private List<Song> songsTemp;
        public int IndexSong { get; set; }
        private AxWMPLib.AxWindowsMediaPlayer wmPlayer;

        public CtrlSong()
        {
            songs = new List<Song>();
            IndexSong = 0;
            wmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            wmPlayer.CreateControl();
        }

        public List<Song> GetSongs() {
            return this.songs;
        }

        public List<Song> GetDefautlSongs()
        {
            this.songs.Add(new Song(1, "Like stone", "03:45", "AudioSlave", "Audioslave", 2002, "Alternative Rock"));
            this.songs.Add(new Song(2, "through glass", "04:15", "Stone sour", "Come Wath(ever) May", 2006, "Hard rock"));
            this.songs.Add(new Song(3, "She's Out Of Her Mind ", "04:50", "Blink-182", "California", 2016, "Rock"));
            this.songs.Add(new Song(4, "I don't want to miss a thing", "05:35", "Aerosmith", "I Don’t Want to Miss a Thing", 1998, "Rock"));
            this.songs.Add(new Song(5, "November rain", "05:10", "Guns N' Roses", "Use Your Illusion I", 1991, "Hard Rock"));
            this.songs.Add(new Song(6, "Nothing else matters", "06:10", "Metallica", "Metallica", 1996, "Metal"));
            this.songs.Add(new Song(7, "The phantom of the opera", "04:19", "Nightwish", "Century Child", 2002, "Alternative Metal"));
            this.songs.Add(new Song(8, "Paid in full", "03:45", "sonata arctica", "Unia", 2007, "Progesive Metal"));
            this.songsTemp = this.songs;
            return this.songs;
        }

        public Song NextSong() {
            if (IndexSong >= 0 && IndexSong < this.songs.Count - 1) {
                IndexSong++;
                StartSong();
                return this.songs.ElementAt(IndexSong);
            } else {
                return this.songs.ElementAt(IndexSong);
            }
        }

        public Song PrevSong() {
            if (IndexSong > 0 && IndexSong < this.songs.Count) {
                IndexSong--;
                StartSong();
                return this.songs.ElementAt(IndexSong);
            } else {
                return this.songs.ElementAt(IndexSong);
            }
        }

        public Song LastSong() {
            IndexSong = this.songs.Count - 1;
            StartSong();
            return this.songs.ElementAt(IndexSong);
        }

        public Song FirstSong() {
            IndexSong = 0;
            StartSong();
            return this.songs.ElementAt(IndexSong);
        }

        public Song InfoCurrSong() {
            return this.songs.ElementAt(IndexSong);
        }

        public Song SetCurrSong(int index) {

            IndexSong = index;
            StartSong();
            return InfoCurrSong();
        }

        private Song ParseSong(String path) {
            TagLib.File song = TagLib.File.Create(path);
            String songName, duration, artist, album, gender;
            int year;
            Song aux;
            songName = song.Tag.Title ?? "Unknown";
            duration = song.Properties.Duration.ToString(@"mm\:ss") ?? "00:00";
            artist = song.Tag.Performers.Length > 0? 
                        song.Tag.Performers[0] : "Unknown";
            album = song.Tag.Album ?? "Unknown";
            gender = song.Tag.FirstGenre ?? "Unknown";
            year = (int)song.Tag.Year;
            aux = new Song(0, songName, duration, artist, album, year, gender);
            aux.Path = path;
            return aux;
        }

        public void LoadSongsFromFolder(String[] songs) {
            this.songs.Clear();
            IndexSong = 0;
            foreach (var s in songs) {
                this.songs.Add(ParseSong(s));
            }
            this.songsTemp = this.songs;
        }

        public void StartSong()
        {
            String path = this.songs.ElementAt(IndexSong).Path;
            if (path != "")
            {
                this.wmPlayer.URL = path;
                this.wmPlayer.Ctlcontrols.play();
            }
        }

        public void PlaySong() {
            this.wmPlayer.Ctlcontrols.play();
        }

        public void StopSong() {
            this.wmPlayer.Ctlcontrols.stop();
        }

        public void PauseSong() {
            this.wmPlayer.Ctlcontrols.pause();
        }

        public bool FilterDurationSongs(int min, int max)
        {
            this.songs = (from s in songsTemp
                          where int.Parse(s.Duration.Split(':')[0]) >= min && 
                          int.Parse(s.Duration.Split(':')[0]) < max
                          select s).ToList();
            if(this.songs.Count > 0)
            {
                this.IndexSong = 0;
                return true;
            }
            return false;
        }

        public bool FilterShortDuration()
        {
            return FilterDurationSongs(1, 3);
        }

        public bool FilterMediumDuration()
        {
            return FilterDurationSongs(3, 5);
        }

        public bool FilterLongDuration()
        {
            return FilterDurationSongs(5, int.MaxValue);
        }

        public void ReseatSongs()
        {
            this.songs = this.songsTemp;
            this.IndexSong = 0;
        }
    }
}
