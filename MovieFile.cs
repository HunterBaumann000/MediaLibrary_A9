using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MovieLibrary_A9.MediaType;

namespace MovieLibrary_A9
{
    public class MovieFile
    { 
        public string filePath { get; set; }
        public List<Movie> Movies { get; set; }
        
        public void AddMovie(Movie movie)
        {
            try
            {
                if (!File.Exists("movies.csv"))
                throw new FileNotFoundException();
            }
            catch(FileNotFoundException) { 
                System.Console.WriteLine("File was not found!");
                System.Console.WriteLine("Want to create a file? y/n");
                string wantNewFile = Console.ReadLine();
                    
                //creates file for user if they want it
                if (wantNewFile.Equals("y")) {
                    filePath = "movies.csv";
                    StreamWriter sw = new StreamWriter(filePath, true);
                }
            }
            
            try {
                // iterate through each movie obj until theres no more greater, then add one to ID
                movie.mediaId = Movies.Max(m => m.mediaId) + 1;
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.WriteLine(movie.Display());
                sw.Close();
                
                // add movie to list
                Movies.Add(movie);
            } 
            catch(Exception e)
            {
                //catches error
                Console.WriteLine(e.Message);
            }
        }

        public MovieFile(string movieFilePath)
        {
            filePath = movieFilePath;
            Movies = new List<Movie>();

            // read movie line
            try
            {
                StreamReader sr = new StreamReader(filePath);
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    // instance of Movie
                    Movie movie = new Movie();
                    string line = sr.ReadLine();

                    //gets input and converts to string
                    string[] movieLine = line.Split(',');

                    //fields that go into the string
                    movie.mediaId = int.Parse(movieLine[0]);
                    movie.title = movieLine[1];
                    movie.genres = movieLine[2].Split('|').ToList();
                    
                    //adds movie to file
                    Console.WriteLine(movieLine);
                }
                // close file when done
                sr.Close();
            }
            catch (Exception e)
            {
                //catch error
                Console.WriteLine(e.Message);
            }
        }
        public bool hasSameTitle(string movieTitle)
        {
            //convert all movie objects to lowercase, and if that instance contains the title, return true
            if (Movies.ConvertAll(m => m.title.ToLower()).Contains(movieTitle.ToLower())){
                Console.WriteLine("{Title} is a duplicate in the file", movieTitle);
                return true;
            }
            return false;
        }
    }
}