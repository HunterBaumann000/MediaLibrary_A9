using System.Collections.Generic;
using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9.Interfaces
{ 
    public interface IRepository
    {
        List<Movie> GetMovies { get; set; }
        void AddMovie(Movie movie);
        
        List<Show> GetShows { get; set; }
        void AddShow(Show show);

        List<Video> GetVideos { get; set; }
        void AddVideo(Video video);
        
    }
}