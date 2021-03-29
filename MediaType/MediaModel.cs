using System.Collections.Generic;
using MovieLibrary_A9.MediaType;

namespace MediaLibrary_A9.MediaType
{  
    public abstract class Media
    {
        //shared by all objects
        public int mediaId { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }
        

        // constructor
         public Media()
        {
            genres = new List<string>();
        }

        // default display
        public virtual string Display()
        {
            return $"ID: {mediaId}, Title: {title}, Genres: {string.Join(", ", genres)}";
        }
    }
  
}