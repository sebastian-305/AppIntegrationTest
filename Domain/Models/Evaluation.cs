using AppIntegrationTest.Domain.Repositories;

namespace AppIntegrationTest.Domain.Models
{
    public class Evaluation : IEntity
    {

        public int Id { get; set; }
        public string? PositiveText { get; set; }
        public string? ImprovementText { get; set; }

        public int LectureId { get; set; }

        public Lecture? Lecture { get; set; }
    }
}
