using System;

namespace music
{
    class Program
    {
        enum Genre
        {
            Rock,
            Pop,
            Emo,
            Alternative,
            HeavyMetal,
        }

        struct Music
        {
            private string Artist;
            private string Album;
            private string Title;
            private string Length;
            private Genre? MusicGenre;

            public void setLength(string length)
            {
                Length = length;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setMusicGenre(string genre)
            {
                if (Enum.TryParse(genre, true, out Genre parsedGenre))
                {
                    MusicGenre = parsedGenre;
                }
                else
                {
                    Console.WriteLine("Invalid genre.");
                    MusicGenre = null;
                }
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                       "\nAlbum: " + Album + "\nLength: " + Length +
                       "\nGenre: " + MusicGenre;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];

            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Please enter the song's title:");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Please enter the artist's name:");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("Please enter the album's name:");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("Please enter the song's length:");
                    collection[i].setLength(Console.ReadLine());
                    Console.WriteLine("Please enter the song's genre:");
                    collection[i].setMusicGenre(Console.ReadLine());
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
            Console.Write(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(collection[i].Display());
                }
            }
        }
    }
}