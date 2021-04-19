using System;
using System.IO;
using System.Collections.Generic;
using MediaLibrary_A9;
using System.Linq;
using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9
{
    
    public class SearchMedia : MediaType.Media
    {      

        //new list of objects to hold all object types
        public static List<object> allMedia = new List<object>();
        public static List<object> userMediaQuery = new List<object>();

        static Media media = new SearchMedia();

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
                var result = from m in allMedia
                    where media.genres.Contains(genreInput) 
                    select m;           
                
                userMediaQuery.Add(result);
            }

            return userMediaQuery;
        }

        public static object SearchMediaByTitle(string titleInput) {
            
            List<object> userMediaQuery = new List<object>();
            GetAllMedia();
            
            for (int i = 0; i < allMedia.Count; i++)
            {
                var result = from m in allMedia
                    where media.title.Contains(titleInput) 
                    select m;   

                userMediaQuery.Add(result);
            } 
            return userMediaQuery;
        } 
    }
}