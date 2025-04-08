using System.ComponentModel.DataAnnotations;

namespace CRUDWebAPI_Dave
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; } //1980
        public float Rating { get; set; } // 8.9
        public string SuggestedAudience { get; set; } //audience rating--R, PG-13
    }
}
