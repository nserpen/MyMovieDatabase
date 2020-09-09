﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace MyMovieDatabase.ServiceModels.Types
{
    public class Imdb
    {
        [BsonElement("id")]
        [JsonProperty("id")]
        public object ImdbId { get; set; }

        public object Votes { get; set; }

        public object Rating { get; set; }
    }
}
