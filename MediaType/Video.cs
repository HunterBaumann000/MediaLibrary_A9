using System;
using System.Collections.Generic;
using MediaLibrary_A9.MediaType;

namespace MovieLibrary_A9.MediaType
{ 
    public class Video : Media
    {
        public string videoFormat{get; set;}
        public int videoLength{get; set;}
        public List<string> videoRegions { get; set; }


        // constructor
        public Video()
        {
            videoRegions = new List<string>();
            genres = new List<string>();
        }

        public override string Display()
        {
            return $"Id: {mediaId}, Title: {title}, Format: {videoFormat}, Length: {videoLength} minutes, VideoRegions: {string.Join(", ", videoRegions)}, Genres: {string.Join(", ", genres)}";
        }

        internal static int Max(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}