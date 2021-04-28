using System;
using System.Collections.Generic;
using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9.MediaType
{
    public class Movie : Media
    {
        public override string Display()
        {
            //formatted fields for console.writeLine 
            return $"Id: {mediaId}, Title: {title}, Genres: {string.Join(", ", genres)}";
        }

        public Movie(){
            this.mediaId = mediaId;
            this.title = title;
            this.genres = genres;
        }
    }
}