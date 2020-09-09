using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyMovieDatabase.ServiceModels.Types
{
    public class Rating
    {
        [BsonElement("rating")]
        public double RatingScore { get; set; }

        public int NumReviews { get; set; }

        public int Meter { get; set; }
    }
}
