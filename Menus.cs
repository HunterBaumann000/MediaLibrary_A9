using System.Collections.Generic;
using MediaLibrary_A9.Interfaces;

using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9
{
    public class Menus : MediaContext
    {
        public void DisplayMainMenu() {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("What would you like to do?");
            System.Console.WriteLine("   1.) Add a Media.");
            System.Console.WriteLine("   2.) Display a list of media.");
            System.Console.WriteLine("   3.) Query for media.");
            System.Console.WriteLine("   4.) End Program ('.') ");
            System.Console.Write("Choice: ");
        }

        public void DisplayMediaTypeMenu() {
            System.Console.WriteLine("What type of media would you like?");
            System.Console.WriteLine("   1.) A Movie. ");
            System.Console.WriteLine("   2.) A Show. ");
            System.Console.WriteLine("   3.) A Video. ");
        }

        public void DisplayReadMediaMenu() {
            System.Console.WriteLine("What File would you like to read?");
            System.Console.WriteLine("   1.) The Movie File. ");
            System.Console.WriteLine("   2.) The Show File. ");
            System.Console.WriteLine("   3.) The Video File. ");
        }

        public void userMediaQuery() {

            string tempInput = "";

            // ask user to input movie title
            System.Console.WriteLine("Do you want to search by ");
            System.Console.WriteLine("1.) Title ");
            System.Console.WriteLine("2.) Genre ");
            tempInput = System.Console.ReadLine();

            if (tempInput == "1") 
            {
                System.Console.WriteLine("Enter Title Name");
                tempInput = System.Console.ReadLine();

                foreach(Media m in SearchMediaByTitle(tempInput))
                {
                    System.Console.WriteLine(m.Display());
                }
            } 
            else if (tempInput == "2") 
            {
                System.Console.WriteLine("Enter Genre Name");
                tempInput = System.Console.ReadLine();

                foreach(Media m in SearchMediaByGenre(tempInput))
                {
                    System.Console.WriteLine(m.Display());
                }
            } 
            else 
            {
              System.Console.WriteLine("that input was invalid");  
            }
        }   

        public void AskUserForMovie() {
            List<string> tempGenres = new List<string>();

            // Add movie
            Movie movie = new Movie();
            string tempInput = "";

            // ask user to input movie title
            System.Console.WriteLine("What is the movie titled");
            movie.title = System.Console.ReadLine();

            // check if the title matches another title
            if (!(hasSameTitle(movie.title, "movie"))){
                       
                do
                {
                    // ask user to enter genre
                    System.Console.WriteLine("Enter a genre. ('.' to stop) ");
                    tempInput = System.Console.ReadLine();
                    //adds to genrelist
                    tempGenres.Add(tempInput);
                } 
                while (tempInput != ".");

                tempGenres = movie.genres;
                //movie never gets created if the title matches another
                AddMovie(movie);
                repo.SerializeMovie(movie);

                //sys out the media they added
                System.Console.WriteLine(movie.title + " has been added! ");
            }
        }   

        public void AskUserForShow() {
            List<string> tempWriters = new List<string>();

            Show show = new Show();  
            string tempInput = "";

            // ask user to input show title
            System.Console.WriteLine("What is the show titled");
            show.title = System.Console.ReadLine();

            // check if the title matches another title
            if (!hasSameTitle(show.title, "show")){
                       
                System.Console.WriteLine("What Season?");
                show.showSeason = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("What Episode?");
                show.showEpisode = int.Parse(System.Console.ReadLine());
            
                do
                {
                    // ask user to enter a writer
                    System.Console.WriteLine("Enter a Writer. ('.' to stop) ");
                    tempInput = System.Console.ReadLine();

                    tempWriters.Add(tempInput);
                            
                } while (tempInput != ".");

                tempWriters = show.showWriters;
                //show never gets created if the title matches another
                AddShow(show);
                repo.SerializeShow(show);
                //sys out the media they added
                System.Console.WriteLine(show.title + " has been added! ");
            }   
        }

        public void AskUserForVideo() {
            List<string> tempRegions = new List<string>();
            // Add video
            Video video = new Video();
            string tempInput = "";

            // ask user to input video title
            System.Console.WriteLine("What is the video titled");
            video.title = System.Console.ReadLine();

            System.Console.WriteLine("What is the video format?");
            video.videoFormat = System.Console.ReadLine();

            System.Console.WriteLine("How many minutes long is the video?");
            video.videoLength = int.Parse(System.Console.ReadLine());

            // check if the title matches another title
            if (!hasSameTitle(video.title, "video")){
                       
                do
                {
                    // ask user to enter region
                    System.Console.WriteLine("Enter a Region (type '.' to stop) ");
                    tempInput = System.Console.ReadLine();

                    tempRegions.Add(tempInput);
                            
                } while (tempInput != ".");
           
                tempRegions = video.videoRegions;
                //video never gets created if the title matches another
                AddVideo(video);
                repo.SerializeVideo(video);
                //sys out the media they added
                System.Console.WriteLine(video.title + " has been added! ");
            }
        }
    }   
}
