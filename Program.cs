using System;
using MediaLibrary_A9.MediaType;
using MediaLibrary_A9;
using MediaLibrary_A9.Interfaces;

namespace MovieLibrary_A7_1
{
    class Program
    {
        static void Main(string[] args)
        {
                
            Menus menu = new Menus();
            Repository repo = new Repository();

            //declaring userInput so the scanner menu input works
            string userInput = "";

            do
            {
                // displays main menu
                menu.DisplayMainMenu();
                userInput = Console.ReadLine();

                //nested if-statements for users input
                if (userInput == "1") 
                {
                    //displays which MediaType they want to add
                    menu.DisplayMediaTypeMenu();
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            //movie menu
                            menu.AskUserForMovie();
                            break;
                        case "2":
                            //show menu
                            menu.AskUserForShow();
                            break;
                        case "3":
                            //video menu
                            menu.AskUserForVideo();
                            break;
                    }
                }
                else if (userInput == "2")
                {
                    //displays menu for reading the media from the file
                    menu.DisplayReadMediaMenu();
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            //movie menu
                            repo.DeserializeMovies();
                            break;
                        case "2":
                            //show menu
                            repo.DeserializeShows();
                            break;
                        case "3":
                            //video menu
                            repo.DeserializeVideos();
                            break;
                    }
                }
            } while (userInput != ".");

            Console.WriteLine("Program Ended");
        }
    }
}