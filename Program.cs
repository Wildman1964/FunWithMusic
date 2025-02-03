/*====== CIT 195 ======== */
/*=== Michael J. Wildner Sr. ===*/
/*=== Spring 2025 - Northwestern Michigan College === */
/*=== Week 3 Programming Assignment === */
/*=== Fun With Music (Exercises 1 & 2) ===*/
/*=== Created: 2/2/2025 Last Modified: 2/3/2025 */


using System;
namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Blues,
            Country,
            Punk,
            Reggae,
            Rock
        }
        struct Music
        {
            private string _Title;
            private string _Artist;
            private string _Album;
            private string _Length;
            private Genre? _Genre;
            public Music(string title, string artist, string album, string length, Genre genre)
            {
                _Title = title;
                _Artist = artist;
                _Album = album;
                _Length = length;
                _Genre = genre;
            }
            public void setValues(string title, string artist, string album, string length, Genre genre)
            {
                _Title = title;
                _Artist = artist;
                _Album = album;
                _Length = length;
                _Genre = genre;
            }
            public void setTitle(string title)
            {
                _Title = title;
            }
            public void setTime(string length)
            {
                _Length = length;
            }
            public string Display()
            {
                return "Track Name: " + _Title + "\nArtist: " + _Artist +
                    "\nAlbum: " + _Album + "\nTime: " + _Length + "\nGenre: " + _Genre;
            }
        }
        static void Main(string[] args)
        {
            Music music = new Music();
            Console.WriteLine("Enter the Track/Song Title:");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Enter the Artist Name:");
            string tempName = Console.ReadLine();
            Console.WriteLine("Enter the Album Title: ");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("Enter the Length of the Track (mm:ss):");
            string tempTime = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("B - Blues\nC - Country\nP - Punk\nQ - Reggae\nR - Rock");
            Genre tempGenre = Genre.Blues;
            char g = char.Parse(Console.ReadLine());
            g = char.ToUpper(g);
            switch (g)
            {
                case 'B':
                    tempGenre = Genre.Blues;
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
                case 'P':
                    tempGenre = Genre.Punk;
                    break;
                case 'Q':
                    tempGenre = Genre.Reggae;
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
            }
            music.setValues(tempTitle, tempName, tempAlbum, tempTime, tempGenre);
            Music moreMusic = new Music();
            moreMusic = music;
            Console.WriteLine("Enter the Next Track/Song Title:");
            tempTitle = Console.ReadLine();
            Console.WriteLine("Enter the Length of the Track (mm:ss):");
            tempTime = Console.ReadLine();
            moreMusic.setTitle(tempTitle);
            Console.WriteLine("Enter the Length of the Track (mm:ss):");
            moreMusic.setTime(tempTime);

            Console.WriteLine($"{music.Display()}");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}
