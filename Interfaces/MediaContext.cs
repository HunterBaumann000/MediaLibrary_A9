using System;
using System.Collections.Generic;
using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9.Interfaces
{
    public class MediaContext : IRepository, ILibrary
    {
        public static List<Movie> movieList = new List<Movie>();
        public static List<Show> showList = new List<Show>();
        public static List<Video> videoList = new List<Video>();

        public void AddMovie(Movie movie)
        {
            movieList.Add(movie);
        }
        public void AddShow(Show show)
        {
            showList.Add(show);
        }
        public void AddVideo(Video video)
        {
            videoList.Add(video);
        }
        public List<Movie> GetAllMovies()
        {
            return movieList;
            // var retList = new List<Movie>();
            // foreach(Movie m in movieList)
            // {
            //     Movie movie = m;
            //     retList.Add(movie);
            // }
            // return retList;
        }
        public List<Show> GetAllShows()
        {
            return showList;
            // var retList = new List<Show>();
            // foreach(Show s in showList)
            // {
            //     Show show = s;
            //     retList.Add(show);
            // }
            // return retList;
        }
        public List<Video> GetAllVideos()
        {
            return videoList;
            // var retList = new List<Video>();
            // foreach(Video v in videoList)
            // {
            //     Video video = v;
            //     retList.Add(video);
            // }
            // return retList;
        }
        public bool hasSameTitle(string title, string mediaType)
        {
            // bool match string
            if(mediaType.Equals(("movie"))) {
                //convert all movie objects to lowercase, and if that instance contains the title, return true
                if (GetAllMovies().ConvertAll(m => m.title.ToLower()).Contains(title.ToLower())){
                    Console.WriteLine("{Title} is a duplicate in the file", title);
                    return true;
                }
                return false;
            }
            else if(mediaType.Equals(("video"))) {
                //convert all video objects to lowercase, and if that instance contains the title, return true
                if (GetAllVideos().ConvertAll(v => v.title.ToLower()).Contains(title.ToLower()))
                {
                    Console.WriteLine("{Title} is a duplicate in the file", title);
                    return true;
                }
                return false;
            }
            else if(mediaType.Equals(("show"))){
                //convert all show objects to lowercase, and if that instance contains the title, return true
                if (GetAllShows().ConvertAll(s => s.title.ToLower()).Contains(title.ToLower()))
                {
                    Console.WriteLine("{Title} is a duplicate in the file", title);
                    return true;
                }
            }
            return false;
        }
    }
}