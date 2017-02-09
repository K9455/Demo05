using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDlevyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CD data = new CD();
            data.Name = "Kakka";
            data.Artist = "Kakkiainen";
            Console.WriteLine("CD data: ");
            Console.WriteLine("Name: " + data.Name);
            Console.WriteLine("Artist: " + data.Artist);
            Console.WriteLine("Songs: ");

            Biisi song1 = new Biisi
            {
                Songname = "Kakkaa lumella",
                Songlength = "3:56"
            };

            Biisi song2 = new Biisi
            {
                Songname = "Kanin kakkaa lumella",
                Songlength = "3:12"
            };

            Biisi song3 = new Biisi
            {
                Songname = "Pissia lumella",
                Songlength = "3:36"
            };

            Biisi song4 = new Biisi
            {
                Songname = "Verta lumella",
                Songlength = "3:16"
            };

            Biisi song5 = new Biisi
            {
                Songname = "Vihreää verta lumella",
                Songlength = "3:56"
            };

            Biisi song6 = new Biisi
            {
                Songname = "Räkää lumella",
                Songlength = "3:36"
            };

            Biisi song7 = new Biisi
            {
                Songname = "Kuukautisverta lumella",
                Songlength = "3:36"
            };
            CD biisu = new CD();

            // add person objects to persons collection
            biisu.AddSong(song1);
            biisu.AddSong(song2);
            biisu.AddSong(song3);
            biisu.AddSong(song4);
            biisu.AddSong(song5);
            biisu.AddSong(song6);
            biisu.AddSong(song7);

            biisu.PrintCollection();
            
        }
    }
}
