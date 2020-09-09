using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using MyMovieDatabase.Repositories;
using NUnit.Framework;

namespace MyMovieDatabase.Tests.IntegrationTests
{
    public class CommentsRepositoryTests
    {
        private CommentsRepository _commentsRepository;
        private MongoClient _client;

        public CommentsRepositoryTests()
        {
            var camelCaseConvention = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);

            _client = new MongoClient(Constants.MongoDbConnectionUri());
            _commentsRepository = new CommentsRepository(_client);
        }

        [Test]
        public async Task TestReturnsOneComment()
        {
            var comment = await _commentsRepository.GetCommentAsync("5a9427648b0beebeb69579cf");
            Assert.AreEqual("greg_powell@fakegmail.com", comment.Email);
            Assert.AreEqual("573a1390f29313caabcd41b1", comment.MovieId.ToString());
        }
    }
}
