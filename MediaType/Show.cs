using System;
using System.Collections.Generic;
using MediaLibrary_A9.MediaType;
namespace MovieLibrary_A9.MediaType
{

    public class Show : Media
    {
        public int showSeason{get; set;}
        public int showEpisode{get; set;}
        public List<string> showWriters { get; set; }


        // constructor
        public Show()
        {
            showWriters = new List<string>();
            genres = new List<string>();
        }

        public override string Display()
        {
            
            return $"ID: {mediaId}, Title: {title}, Season {showSeason} Ep. {showEpisode}, Writers: {string.Join(", ", showWriters)}, Genres: {string.Join(", ", genres)}";
        }
        
    }
}