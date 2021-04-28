using System.Collections.Generic;
using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9.Interfaces
{
    public interface ILibrary
    {
        List<Movie> GetAllMovies();
        List<Show> GetAllShows();
        List<Video> GetAllVideos();
    }
}