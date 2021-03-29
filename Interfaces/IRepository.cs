using System.Collections.Generic;
using MovieLibrary_A9.MediaType;

namespace MediaLibrary_A9.Interfaces
{ 
    public interface IRepository
    {
        List<Movie> Movies { get; set; }
        void AddMovie(Movie movie);
        
        List<Show> Shows { get; set; }
        void AddShow(Show show);

        List<Video> Videos { get; set; }
        void AddVideo(Video video);
        
    }
}