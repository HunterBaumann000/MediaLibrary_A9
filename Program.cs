using System;
using System.IO;
using System.Collections.Generic;
using MediaLibrary_A9.MediaType;
using MediaLibrary_A9;
using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9
{
    class Program 
    {
        static void Main(string[] args)
        {
            //class with file-path parameter
            MovieFile movieFile = new MovieFile("movies.csv");
            ShowFile showFile = new ShowFile("shows.csv");
            VideoFile videoFile = new VideoFile("video.csv");

            //menu class
            var menu = new Menus();

            //declaring userInput so the scanner menu input works
            string userInput = "";

            do
            {
                // displays main menu
                menu.DisplayMainMenu();
                // scanner
                userInput = Console.ReadLine();

                //nested if-statements for users input
                if (userInput == "1") 
                {
                    //displays which MediaType they want to add
                    menu.DisplayMediaTypeMenu();
                    userInput = Console.ReadLine();

                    if(userInput == "1") 
                    {
                        //movie menu
                        Menus.askUserForMovie(userInput);
                    } 
                    else if (userInput == "2") 
                    {
                        //show menu
                        Menus.askUserForShow(userInput);
                    }
                    else if(userInput == "3")
                    {
                        //video menu
                        Menus.askUserForVideo(userInput);
                    } 
                }
                else if (userInput == "2")
                {
                    //displays menu for reading the media from the file
                    menu.DisplayReadMediaMenu();
                    userInput = Console.ReadLine();

                    if (userInput == "1") 
                    {
                        // Display All Movies
                        for (int i = 0; i < movieFile.Movies.Count; i++)
                        {
                            //Movie m = JsonConvert.DeserializeObject<Movie>(json);

                            Movie m = movieFile.Movies[i];
                            Console.WriteLine(m.Display());
                        }
                    } 
                    else if (userInput == "2") 
                    {
                        // Display All Shows
                        System.Collections.IList list = showFile.Shows;
                        for (int i = 0; i < list.Count; i++)
                        {
                            //Show s = JsonConvert.DeserializeObject<Show>(json);

                            Show s = (Show)list[i];
                            Console.WriteLine(s.Display());
                        }
                    } 
                    else if (userInput == "3") 
                    {
                        // Display All Videos
                        System.Collections.IList list = videoFile.Videos;
                        for (int i = 0; i < list.Count; i++)
                        {
                            //Video v = JsonConvert.DeserializeObject<Video>(json);

                            Video v = (Video)list[i];
                            Console.WriteLine(v.Display());
                        }
                    }
                }
                else if (userInput == "3") {
                    menu.DisplaySearchMenu();
                    userInput = Console.ReadLine();

                    if(userInput == "1")
                    {
                        Menus.askUserToSearchByTitle();

                        System.Collections.IList list = SearchMedia.userMediaQuery;
                        for (int i = 0; i < list.Count; i++)
                        {
                            Media m = (Media)list[i];
                            Console.WriteLine(m.Display());
                        }
                    } 
                    else if (userInput == "2") 
                    {
                        Menus.askUserToSearchByGenre();

                        System.Collections.IList list = SearchMedia.userMediaQuery;
                        for (int i = 0; i < list.Count; i++)
                        {
                            Media m = (Media)list[i];
                            Console.WriteLine(m.Display());
                        }
                    }

                }
            } while (userInput == "1" || userInput == "2" || userInput == "3");

            Console.WriteLine("Program Ended");
        }
    }
}