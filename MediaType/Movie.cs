using System.Collections.Generic;
using MediaLibrary_A9.MediaType;

namespace MovieLibrary_A9.MediaType
{ 

    public class Movie : Media
    {
        public Movie()
        {
            //list of movieGenres so other class can access
            genres = new List<string>();
        }

        public override string Display()
        {
            //formatted fields for console.writeLine 
            return $"Id: {mediaId}, Title: {title}, Genres: {string.Join(", ", genres)}";
        }
    }
}