using NUnit.Framework;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using MyMovieDatabase.Repositories;
using System.Threading.Tasks;

namespace MyMovieDatabase.Tests.IntegrationTests
{
    public class MoviesRepositoryTests
    {
        private MoviesRepository _moviesRepository;
        private MongoClient _client;

        public MoviesRepositoryTests()
        {
            var camelCaseConvention = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);

            _client = new MongoClient(Constants.MongoDbConnectionUri());
            _moviesRepository = new MoviesRepository(_client);
        }

        [Test]
        public async Task TestReturnsOneMovie()
        {
            var movie = await _moviesRepository.GetMovieAsync("573a1398f29313caabcea974");
            Assert.AreEqual("The Princess Bride", movie.Title);
        }
    }
}