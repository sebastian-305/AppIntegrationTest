namespace AppIntegrationTest.Domain.Models;

public class Lecture :Repositories.IEntity
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? LecturerName { get; set; }
    public string? ExternalId { get; set; }
}
