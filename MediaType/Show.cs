using System;
using System.Collections.Generic;
using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9.MediaType
{

    public class Show : Media
    {
        public int showSeason{get; set;}
        public int showEpisode{get; set;}
        public List<string> showWriters { get; set; }

        public override string Display()
        {
            return $"ID: {mediaId}, Title: {title}, Season {showSeason} Ep. {showEpisode}, Writers: {string.Join(", ", showWriters)}";
        }
    }
}