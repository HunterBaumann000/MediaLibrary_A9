using System.Collections.Generic;
using System.Linq;
using MediaLibrary_A9.MediaType;

namespace MediaLibrary_A9
{
    public class SearchMedia
    {
        public static Repository repo = new Repository();

        public static List<Media> SearchMediaByGenre(string genreInput) {
            List<Media> userMediaQuery = new List<Media>();

            for (int i = 0; i < repo.DeserializeMedia().Count; i++)
            {
                var result = from m in repo.DeserializeMedia()
                    where (m.genres).Contains(genreInput)
                    select m;           
                
                userMediaQuery.Add((Media)result);
            }
            return userMediaQuery;
        }

        public static List<Media> SearchMediaByTitle(string titleInput) {
            
            List<Media> userMediaQuery = new List<Media>();
            repo.DeserializeMedia();
            
            for (int i = 0; i < repo.DeserializeMedia().Count; i++)
            {
                var result = from m in repo.DeserializeMedia()
                    where (m.title).Contains(titleInput, System.StringComparison.CurrentCultureIgnoreCase) 
                    select m;   

                userMediaQuery.Add((Media)result);
            } 
            return userMediaQuery;
        } 
    }
}