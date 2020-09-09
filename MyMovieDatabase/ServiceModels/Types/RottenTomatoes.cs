﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyMovieDatabase.ServiceModels.Types
{
    public class RottenTomatoes
    {
        [BsonElement("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        public Rating Viewer { get; set; }

        public int Fresh { get; set; }

        public int Rotten { get; set; }

        public string Production { get; set; }

        public DateTime Dvd { get; set; }

        public Rating Critic { get; set; }

        [BsonExtraElements]
        [BsonElement("other")]
        public BsonDocument OtherProperties { get; set; }
    }
}
