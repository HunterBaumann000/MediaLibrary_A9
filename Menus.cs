using System.Collections.Generic;
using MediaLibrary_A9;
using MediaLibrary_A9.Interfaces;
using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9
{
    public class Menus
    {

        public List<Movie> Movies 
        { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException();
        }
        public List<Show> Shows
         { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException();
        }
        public List<Video> Videos 
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }
        
        public void DisplayMainMenu() {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("What would you like to do?");
            System.Console.WriteLine("   1.) Add a Media.");
            System.Console.WriteLine("   2.) Display a list of media.");
            System.Console.WriteLine("   3.) Search for a Media.");
            System.Console.WriteLine("   4.) End Program.");
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

        public void DisplaySearchMenu() {
            System.Console.WriteLine("What would you like to search by?");
            System.Console.WriteLine("   1.) Media Title ");
            System.Console.WriteLine("   2.) Media Genre ");
        }

        public static void askUserToSearchByTitle() {

            System.Console.WriteLine("Enter a Title.");   
            string tempInput = System.Console.ReadLine();

            SearchMedia.SearchMediaByTitle(tempInput);
        }

        public static void askUserToSearchByGenre() {

            System.Console.WriteLine("Enter a Genre.");
            string tempInput = System.Console.ReadLine();
        
            SearchMedia.SearchMediaByGenre(tempInput);
        }

        public static void askUserForMovie(string userInput) {

            string movieFilePath = "movies.csv";
            MovieFile movieFile = new MovieFile(movieFilePath);

            // Add movie
            Movie movie = new Movie();
            string tempInput = "";

            // ask user to input movie title
            System.Console.WriteLine("What is the movie titled");
            movie.title = System.Console.ReadLine();

            // check if the title matches another title
            if (!movieFile.hasSameTitle(movie.title)){
                       
                do
                {
                    // ask user to enter genre
                    System.Console.WriteLine("Enter a genre. ('.' to stop) ");
                    tempInput = System.Console.ReadLine();
                    //adds to genrelist
                    movie.genres.Add(tempInput);
                } 
                while (tempInput != ".");

                //movie never gets created if the title matches another
                movieFile.AddMovie(movie);
            }
        }   


        public static void askUserForShow(string userInput) {

            string showFilePath = "shows.csv";
            ShowFile showFile = new ShowFile(showFilePath);

            // Add show
            Show show = new Show();
            string tempInput = "";

            // ask user to input show title
            System.Console.WriteLine("What is the show titled");
            show.title = System.Console.ReadLine();

            // check if the title matches another title
            if (!showFile.hasSameTitle(show.title)){
                       
                System.Console.WriteLine("What Season?");
                show.showSeason = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("What Episode?");
                show.showEpisode = int.Parse(System.Console.ReadLine());
            
                do
                {
                    // ask user to enter a writer
                    System.Console.WriteLine("Enter a Writer. ('.' to stop) ");
                    tempInput = System.Console.ReadLine();

                    show.showWriters.Add(tempInput);
                            
                } while (tempInput != ".");

                //reset loop 
                tempInput = "";  

                do
                {
                    // ask user to enter genre
                    System.Console.WriteLine("Enter a genre. ('.' to stop) ");
                    tempInput = System.Console.ReadLine();
                    //adds to genrelist
                    show.genres.Add(tempInput);
                } 
                while (tempInput != ".");

                //show never gets created if the title matches another
                showFile.AddShow(show);
            }   
        }

        public static void askUserForVideo(string userInput) {

            string videoFilePath = "video.csv";
            VideoFile videoFile = new VideoFile(videoFilePath);

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
            if (!videoFile.hasSameTitle(video.title)){
                       
                do 
                {
                    //ask user to enter region
                    System.Console.WriteLine("Enter a Region (type '.' to stop) ");
                    tempInput = System.Console.ReadLine();

                    video.videoRegions.Add(tempInput);
                            
                } while (tempInput != ".");

                //reset the loop
                tempInput = "";  

                do
                {
                    // ask user to enter genre
                    System.Console.WriteLine("Enter a genre. ('.' to stop) ");
                    tempInput = System.Console.ReadLine();
                    //adds to genrelist
                    video.genres.Add(tempInput);
                } 
                while (tempInput != ".");
           
                //video never gets created if the title matches another
                videoFile.AddVideo(video);
            }
        }
    }   
}
