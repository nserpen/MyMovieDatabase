using System.Collections.Generic;
using MyMovieDatabase.ServiceModels.Types;
using ServiceStack;

namespace MyMovieDatabase.ServiceModels
{

    [Route("/movies", "GET")]
    public class GetMovies : IReturn<GetMoviesResponse>
    {
        public int PageSize { get; set; } = 20;
        public int Page { get; set; } = 1;
        public string SortKey { get; set; } = "tomatoes.viewer.numReviews";
        public int SortDirection { get; set; } = -1;
    }

    public class GetMoviesResponse : ResponseBase
    {
        public IReadOnlyList<Movie> Movies { get; set; }
    }


    [Route("/movies/{Id}", "GET")]
    public class GetMovie : IReturn<GetMovieResponse>
    {
        public string Id { get; set; }
    }

    public class GetMovieResponse : ResponseBase
    {
        public Movie Movie { get; set; }
    }

    /// <summary>
    /// Filters movie collection using pipeline
    /// </summary>
    [Route("/filter", "POST")]
    public class GetFilteredMovies : IReturn<GetFilteredMoviesResponse>
    {
        public MovieFilter Filter { get; set; }
    }

    public class GetFilteredMoviesResponse : ResponseBase
    {
        public IReadOnlyList<Movie> Movies { get; set; }
    }


    public class MovieFilter
    {
        public string[] CastFilter { get; set; } = null;        // comma delimited list or null
        // AND
        public string[] CountryFilter { get; set; } = null;     // comma delimited list or null
        // AND
        public string[] GenreFilter { get; set; } = null;       // comma delimited list or null
        // AND
        public string[] DirectorFilter { get; set; } = null;    // comma delimited list or null

        public int PageSize { get; set; } = 20;
        public int Page { get; set; } = 1;
        public string SortKey { get; set; } = "title";
        public int SortDirection { get; set; } = 1;
    }
}
