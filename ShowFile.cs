using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using MovieLibrary_A9.MediaType;

namespace MovieLibrary_A9
{
    public class ShowFile
    {

        public List<Show> Shows { get; set; }
        public string filePath { get; set; }
        public static int Count { get; internal set; }

        public void AddShow(Show show)
        {
            try
            {
                if (!File.Exists("shows.csv"))
                throw new FileNotFoundException();
            }
            catch(FileNotFoundException) { 
                System.Console.WriteLine("File was not found!");
                System.Console.WriteLine("Want to create the show.csv? y/n");
                string wantNewFile = Console.ReadLine();
                    
                //creates file for user if they want it
                if (wantNewFile.Equals("y")) {
                    filePath = "shows.csv";
                    StreamWriter sw = new StreamWriter(filePath, true);
                }
            } 
            try
            {
                // iterate through each show obj until theres no more greater, then add one to ID
                show.mediaId = Shows.Max(s => s.mediaId) + 1;
                StreamWriter sw = new StreamWriter(filePath, true);

                sw.WriteLine(show.Display());

                sw.Close();
                
                // add show details to Lists
                Shows.Add(show);
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public ShowFile(string showFilePath)
        {
            filePath = showFilePath;
            Shows = new List<Show>();

            // read show line
            try
            {
                StreamReader sr = new StreamReader(filePath);
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    // instance of Show
                    Show show = new Show();
                    string line = sr.ReadLine();

                    string[] showLine = line.Split(',');
                    show.mediaId = int.Parse(showLine[0]);
                    show.title = showLine[1];
                    show.showSeason = int.Parse(showLine[2]);
                    show.showEpisode = int.Parse(showLine[3]);
                    show.showWriters = showLine[4].Split('|').ToList();
                    
                    Console.WriteLine(showLine);
                }
                // close file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool hasSameTitle(string showTitle)
        {
            //convert all show objects to lowercase, and if that instance contains the title, return true
            if (Shows.ConvertAll(s => s.title.ToLower()).Contains(showTitle.ToLower()))
            {
                Console.WriteLine("{Title} is a duplicate in the file", showTitle);
                return true;
            }
            return false;
        }
    }
}