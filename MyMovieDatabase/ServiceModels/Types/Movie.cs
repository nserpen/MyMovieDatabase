﻿using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace MyMovieDatabase.ServiceModels.Types
{
    public class Movie
    {
        private List<Comment> comments;
        private string _id;

        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title { get; set; }

        public object Year { get; set; }

        public List<string> Cast { get; set; }

        public string Plot { get; set; }

        [BsonElement("fullplot")]
        public string FullPlot { get; set; }

        [BsonElement("lastupdated")]
        public object LastUpdated { get; set; }

        public DateTime Released { get; set; }

        public string Rated { get; set; }

        public string Type { get; set; }

        public string Poster { get; set; }

        public List<string> Directors { get; set; }

        public List<string> Writers { get; set; }

        public Imdb Imdb { get; set; }

        public List<string> Countries { get; set; }

        public List<string> Genres { get; set; }

        public int Runtime { get; set; }

        public RottenTomatoes Tomatoes { get; set; }

        public List<Comment> Comments
        {
            get { return comments != null ? comments.OrderByDescending(c => c.Date).ToList() : null; }
            set => comments = value;
        }

        // DO NOT FORGET TO REMOVE FROM COLLECTION:
        // db.movies.update({},{$unset: {num_mflix_comments:1}},{multi: true});
        //
        //[BsonElement("num_mflix_comments")]
        //public int NumberOfComments { get; set; }

        public Awards Awards { get; set; }

        public List<string> Languages { get; set; }

        [BsonElement("metacritic")]
        public int? MetacriticScore { get; set; }
    }
}
