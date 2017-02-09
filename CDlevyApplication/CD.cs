using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDlevyApplication
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }

        private List<Biisi> songs;

        public CD()
        {
            songs = new List<Biisi>();
        }

        public void AddSong(Biisi song)
        {
            songs.Add(song);
        }

        public Biisi GetSong(int index)
        {
            if (index < songs.Count) return songs.ElementAt(index);
            else return null;
        }

        public void PrintCollection()
        {
            foreach (Biisi song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
   }     
}
