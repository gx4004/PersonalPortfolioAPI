namespace PersonalPortfolio.API.Models.DTOs;

public class ExperienceDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Company { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; } 
    public string Description { get; set; }
    
}