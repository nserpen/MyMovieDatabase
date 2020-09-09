using System.Collections.Generic;
using MyMovieDatabase.ServiceModels.Types;
using Newtonsoft.Json;
using ServiceStack;

namespace MyMovieDatabase.ServiceModels
{

    [Route("/comments/{Id}", "GET")]
    public class GetComment : IReturn<GetCommentResponse>
    {
        public string Id { get; set; }
    }

    public class GetCommentResponse : ResponseBase
    {
        public Comment Comment { get; set; }
    }


    [Route("/movies/{MovieId}/comments", "GET")]
    public class GetComments : IReturn<GetCommentsResponse>
    {
        public string MovieId { get; set; }
    }

    public class GetCommentsResponse : ResponseBase
    {
        public IReadOnlyList<Comment> Comments { get; set; }
    }


    [Route("/comments")]
    public class AddComment : IReturn<AddCommentResponse>
    {
        public AddMovieCommentInput Comment { get; set; }
    }

    public class AddCommentResponse : ResponseBase
    {
        public Comment Comment { get; set; }
    }

    [Route("/comments/{Id}", "PATCH")]
    public class UpdateComment : IReturn<UpdateCommentResponse>
    {
        public string Id { get; set; }
        public UpdateMovieCommentInput Comment { get; set; }
    }

    public class UpdateCommentResponse : ResponseBase
    {
        public Comment Comment { get; set; }
    }

    [Route("/comments/{Id}/delete", "DELETE")]
    public class DeleteComment : IReturn<DeleteCommentResponse>
    {
        public string Id { get; set; }
    }

    public class DeleteCommentResponse : ResponseBase
    {
    }

    /// <summary>
    ///     Helper class to define the expected JSON object passed in the
    ///     Request body.
    /// </summary>
    public class AddMovieCommentInput
    {
        public string MovieId { get; set; }

        public string Comment { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }

    public class UpdateMovieCommentInput
    {
        public string UpdatedComment { get; set; }

        public string Email { get; set; }
    }

    public class DeleteMovieCommentInput
    {
        public string MovieId { get; set; }

        public string Email { get; set; }
    }
}
