namespace PersonalPortfolio.API.Models.DTOs;

public class ProjectDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string RepositoryUrl { get; set; } 
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; } 
    public List<string> Technologies { get; set; } 
}