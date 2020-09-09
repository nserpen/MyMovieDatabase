using ServiceStack;

namespace MyMovieDatabase.ServiceModels
{
    public class ResponseBase
    {
        public ResponseStatus ResponseStatus { get; set; } = new ResponseStatus();
    }
}
