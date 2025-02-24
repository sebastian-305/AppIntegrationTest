using AppIntegrationTest.Domain.Models;
using AppIntegrationTest.Domain.Repositories;

namespace AppIntegrationTest.Infrastructure.MockRepositories;

public class MockLectureRepository : MockRepository<Lecture>, ILectureRepository
{ }

