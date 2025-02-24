using AppIntegrationTest.Domain.Models;

namespace AppIntegrationTest.Domain.Repositories;

public interface IEvaluationRepository : IRepository<Evaluation>
{
    public Task<List<Evaluation>> FindByLectureAsync(int lectureId);
}