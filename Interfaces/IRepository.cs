using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9.Interfaces
{
    public interface IRepository
    {
        void AddMovie(Movie movie);
        void AddShow(Show show);
        void AddVideo(Video video);
    }
}