using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MovieList;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Movie Data Base");

        Dictionary<string, Movie> movieDictionary = new Dictionary<string, Movie>();

        do
        {
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add Movie[A]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("List Movie[L]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Delete Data Base[D]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.A:

                    Console.ForegroundColor = ConsoleColor.White;
                    Movie newMovie = new Movie();
                    Console.WriteLine("Title:");
                    newMovie.Name = Console.ReadLine();
                    Console.WriteLine("Genre:");
                    newMovie.Genre = Console.ReadLine();
                    Console.WriteLine("Description:");
                    newMovie.Description = Console.ReadLine();
                    Console.WriteLine("Release Date:");
                    newMovie.ReleaseDate = Console.ReadLine();
                    Console.WriteLine("\n");

                    if(movieDictionary.ContainsKey(newMovie.Name))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This Title already exists!");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        movieDictionary.Add(newMovie.Name, newMovie);
                        Console.WriteLine("Movie added Successfully!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                
                break;


                case ConsoleKey.L:

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Movies in the Database:");
                    foreach(var movie in movieDictionary.Values)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Name: {movie.Name}\n"+
                        $"Genre: {movie.Genre}\n"+
                        $"Description: {movie.Description}\n"+
                        $"Release Date: {movie.ReleaseDate}");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                break;


                case ConsoleKey.D:

                    Console.ForegroundColor = ConsoleColor.Red;
                    movieDictionary.Clear();
                    Console.WriteLine("Data Base Successfully Deleted!");
                    Console.ForegroundColor = ConsoleColor.White;
                break;

                default:
                    Console.WriteLine("Invalid Option!");
                break;
            }
        }

        while(true);
    }
}