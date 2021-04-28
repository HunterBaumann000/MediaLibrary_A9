using System.Collections.Generic;
using System.Linq;

namespace MediaLibrary_A9
{
    public class SearchMedia
    {
        public static Repository repo = new Repository();

        public static object SearchMediaByGenre(string genreInput) {
            List<object> userMediaQuery = new List<object>();

            for (int i = 0; i < repo.DeserializeMedia().Count; i++)
            {
                var result = from m in repo.DeserializeMedia()
                    where (m.genres).Contains(genreInput) 
                    select m;           
                
                userMediaQuery.Add(result);
            }
            return userMediaQuery;
        }

        public static object SearchMediaByTitle(string titleInput) {
            
            List<object> userMediaQuery = new List<object>();
            repo.DeserializeMedia();
            
            for (int i = 0; i < repo.DeserializeMedia().Count; i++)
            {
                var result = from m in repo.DeserializeMedia()
                    where (m.title).Contains(titleInput) 
                    select m;   

                userMediaQuery.Add(result);
            } 
            return userMediaQuery;
        } 
    }
}