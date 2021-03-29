using System;
using System.IO;
using System.Collections.Generic;
using MovieLibrary_A9;
using System.Linq;

namespace MediaLibrary_A9
{
    
    public class SearchMedia
    {      

        //new list of objects to hold all object types
        public static List<object> allMedia = new List<object>();
        public static List<object> userMediaQuery = new List<object>();

        public static void GetAllMedia() {
            //reads all data from csv files
            ShowFile s = new ShowFile("shows.csv");
            MovieFile m = new MovieFile("movies.csv");
            VideoFile v = new VideoFile("videos.csv");

            //adding all obj lists into one list
            allMedia.Add(m.Movies);
            allMedia.Add(s.Shows);
            allMedia.Add(v.Videos); 
        }

        public static object SearchMediaByGenre(string genreInput) {

            List<object> userMediaQuery = new List<object>();
            GetAllMedia();

            for (int i = 0; i < allMedia.Count; i++)
            {
                var media = allMedia.Where(m => (m.Show.showGenres
                || m.Movie.movieGenres
                || m.Video.videoGenres).Contains(genreInput));
                userMediaQuery.Add(media);
            }

            return userMediaQuery;
        }

        public static object SearchMediaByTitle(string titleInput) {
            
            List<object> userMediaQuery = new List<object>();
            GetAllMedia();
            
            for (int i = 0; i < allMedia.Count; i++)
            {
                var media = allMedia.Where(m => (m.Show.showTitle
                || m.Movie.movieTitle
                || m.Video.videoTitle).Contains(titleInput));

                userMediaQuery.Add(media);
            } 
            return userMediaQuery;
        } 
    }
}