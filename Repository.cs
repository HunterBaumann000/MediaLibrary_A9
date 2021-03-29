using System.Collections.Generic;
using System.Linq;
using MediaLibrary_A9.Interfaces;
using MovieLibrary_A9.MediaType;
using Newtonsoft.Json;

namespace MediaLibrary_A9
{
public class Repository : IRepository
    {
        List<Movie> IRepository.Movies { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        List<Show> IRepository.Shows { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        List<Video> IRepository.Videos { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void AddMovie(Movie movie)
        {
            Movie movie1 = new Movie();
            movie1.mediaId = IRepository.Movies.Max(s => s.mediaId) + 1;
            movie1.title = movie.title;
            movie1.genres = movie.genres;

            string json = JsonConvert.SerializeObject(movie1);

            throw new System.NotImplementedException();
        }

        public void AddShow(Show show)
        {
            Show show1 = new Show();
            show.mediaId = IRepository.Shows.Max(s => s.mediaId) + 1;
            show.showSeason = show.showSeason;
            show.title = show.title;
            show.showEpisode = show.showEpisode;
            show.showWriters = show.showWriters;

            string json = JsonConvert.SerializeObject(show1);
            
            throw new System.NotImplementedException();
        }

        public void AddVideo(Video video)
        {
            Video video1 = new Video();
            video1.mediaId = IRepository.Videos.Max(s => s.mediaId) + 1;
            video1.title = video.title;
            video1.videoFormat = video.videoFormat;
            video1.videoLength = video.videoLength;
            video1.videoRegions = video.videoRegions;

            string json = JsonConvert.SerializeObject(video1);

            throw new System.NotImplementedException();
        }
    }
}