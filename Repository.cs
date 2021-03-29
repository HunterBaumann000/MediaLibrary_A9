using System.Collections.Generic;
using System.Linq;
using MediaLibrary_A9.Interfaces;
using MovieLibrary_A9.MediaType;
using Newtonsoft.Json;

namespace MediaLibrary_A9
{
    public class Repository : IRepository
    {

        public List<Movie> Movies { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
            }
        public List<Show> Shows { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
            }
        public List<Video> Videos { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
            } 

        public void AddMovie(Movie movie)
        {
            Movie movie1 = new Movie();
            movie1.movieId = Movies.Max(s => s.movieId) + 1;
            movie1.movieTitle = this.movieTitle;
            movie1.movieGenres = this.genreList;

            string json = JsonConvert.SerializeObject(movie1);

            throw new System.NotImplementedException();
        }

        public void AddShow(Show show)
        {
            Movie show1 = new Movie();
            show1.showId = Shows.Max(s => s.showId) + 1;
            show1.showSeason = this.showSeason;
            show1.showEpisode = this.showEpisode;
            show1.showWriters = this.showWriters;

            string json = JsonConvert.SerializeObject(show1);
            
            throw new System.NotImplementedException();
        }

        public void AddVideo(Video video)
        {
            Movie video1 = new Movie();
            video1.videoId = Video.Max(s => s.videoId) + 1;
            video1.videoTitle = this.videoTitle;
            video1.videoFormat = this.videoFormat;
            video1.videoLength = this.videoLength;
            video1.videoRegions = this.videoRegions;

            string json = JsonConvert.SerializeObject(video1);

            throw new System.NotImplementedException();
        }
    }
}