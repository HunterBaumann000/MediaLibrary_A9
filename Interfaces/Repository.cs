using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MediaLibrary_A9.Interfaces;
using MediaLibrary_A9.MediaType;
using Newtonsoft.Json;

namespace MediaLibrary_A9
{
    public class Repository : MediaContext
    {
        public void SerializeMovie(Movie movie)
        {
            //string json = JsonConvert.SerializeObject(GetAllMovies(), Formatting.Indented);

            foreach(Movie m in GetAllMovies()){
                m.mediaId = GetAllMovies().Max(s => s.mediaId) + 1;
                m.title = movie.title;
                m.genres = movie.genres;

                string jsonString = System.Text.Json.JsonSerializer.Serialize(movie);
                File.WriteAllText("FileOutputs/movies.json", jsonString);
                File.WriteAllText("FileOutputs/media.json", jsonString);
            }
           //var json = System.Text.Json.JsonSerializer.Serialize(GetAllMovies());

            // Movie movie1 = GetAllMovies().Last();

            // movie1.mediaId = GetAllMovies().Max(m => m.mediaId) + 1;
            // movie1.title = movie.title;
            // movie1.genres = movie.genres;

            // string jsonString = System.Text.Json.JsonSerializer.Serialize(movie1);
            // File.WriteAllText("FileOutputs/movies.json", jsonString);
        }

        public void SerializeShow(Show show)
        {
            foreach(Show s in GetAllShows()){
                s.mediaId = GetAllShows().Max(s => s.mediaId) + 1;
                s.showSeason = show.showSeason;
                s.title = show.title;
                s.showEpisode = show.showEpisode;
                s.showWriters = show.showWriters;

                string jsonString = System.Text.Json.JsonSerializer.Serialize(show);
                File.WriteAllText("FileOutputs/shows.json", jsonString);
                File.WriteAllText("FileOutputs/media.json", jsonString);
            }



            // Show show1 = GetAllShows().Last();

            // show1.mediaId = GetAllShows().Max(s => s.mediaId) + 1;
            // show1.showSeason = show.showSeason;
            // show1.title = show.title;
            // show1.showEpisode = show.showEpisode;
            // show1.showWriters = show.showWriters;

            //string jsonString = JsonSerializer.Serialize(show1);
            //File.WriteAllText("FileOutputs/shows.json", jsonString);
        }

        public void SerializeVideo(Video video)
        {

            foreach(Video v in GetAllVideos()){
                v.mediaId = GetAllVideos().Max(v => v.mediaId) + 1;
                v.title = video.title;
                v.videoFormat = video.videoFormat;
                v.videoLength = video.videoLength;
                v.videoRegions = video.videoRegions;

                string jsonString = System.Text.Json.JsonSerializer.Serialize(video);
                File.WriteAllText("FileOutputs/videos.json", jsonString);
                File.WriteAllText("FileOutputs/media.json", jsonString);
            }


            // Video video1 = GetAllVideos().Last() ;

            // video1.mediaId = GetAllVideos().Max(s => s.mediaId) + 1;
            // video1.title = video.title;
            // video1.videoFormat = video.videoFormat;
            // video1.videoLength = video.videoLength;
            // video1.videoRegions = video.videoRegions;

            //string jsonString = JsonSerializer.Serialize(video1);
            //File.WriteAllText("FileOutputs/videos.json", jsonString);
        }

        public void DeserializeMovies()
        {   
            //var json = System.Text.Json.JsonSerializer.Serialize(GetAllMovies());
            
            //"FileOutputs/movies.json"
            StreamReader r = new StreamReader("FileOutputs/movies.json");
            string jsonString = r.ReadToEnd();
            Movie m = JsonConvert.DeserializeObject<Movie>(jsonString);
            Console.WriteLine(m.mediaId + " | " + m.title + " | " + m.genres);
        }

        public void DeserializeShows()
        {   
           // var json = System.Text.Json.JsonSerializer.Serialize(GetAllShows());
            
            //"FileOutputs/movies.json"
            StreamReader r = new StreamReader("FileOutputs/shows.json");
            string jsonString = r.ReadToEnd();
            Show s = JsonConvert.DeserializeObject<Show>(jsonString);
            Console.WriteLine(s.mediaId + " | " + s.title + " | " + s.showWriters);
        }

        public List<Video> DeserializeVideos()
        {   
            //var json = System.Text.Json.JsonSerializer.Serialize(GetAllVideos());
            
            //"FileOutputs/movies.json"
            StreamReader r = new StreamReader("FileOutputs/videos.json");
            string jsonString = r.ReadToEnd();
            //Video v = JsonConvert.DeserializeObject<Video>(jsonString);
            //Console.WriteLine(v.mediaId + " | " + v.title + " | " + v.videoRegions);

            List<Video> ObjList = JsonConvert.DeserializeObject<List<Video>>(jsonString);

            return ObjList;
        }

        public List<Media> DeserializeMedia()
        {   
            //var json = System.Text.Json.JsonSerializer.Serialize(GetAllVideos());
            
            //"FileOutputs/movies.json"
            StreamReader r = new StreamReader("FileOutputs/media.json");
            string jsonString = r.ReadToEnd();
            //Video v = JsonConvert.DeserializeObject<Video>(jsonString);
            //Console.WriteLine(v.mediaId + " | " + v.title + " | " + v.genres);

            List<Media> ObjList = JsonConvert.DeserializeObject<List<Media>>(jsonString);
            return ObjList;
        }
        
    }
}