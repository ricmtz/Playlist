using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class Song
    {
        public int Id { get; set; }
        public String SongName { get; set; }
        public String Duration { get; set; }
        public String Artist { get; set; }
        public String Album { get; set; }
        public int Year { get; set; }
        public String Gender { get; set; }
        public String Path { get; set; }

        public Song(int id, string songName, string duration,
                    string artist, string album, int year, string gender)
        {
            Id = id;
            SongName = songName;
            Duration = duration;
            Artist = artist;
            Album = album;
            Year = year;
            Gender = gender;
            Path = "";
        }

        public override string ToString()
        {
            return $"{this.SongName, -30} \t {this.Duration, 5}";
        }
    }
}
