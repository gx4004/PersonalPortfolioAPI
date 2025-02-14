namespace PersonalPortfolio.API.Models.DTOs;

public class AboutMeDto
{
    public int Id { get; set; }
    public string FullName { get; set; } 
    public string Introduction { get; set; } 
    public string Email { get; set; } 
    public string Phone { get; set; } 
    public string Location { get; set; } 
    public string ProfileImageUrl { get; set; }
    public string LinkedInUrl { get; set; } 
    public string GitHubUrl { get; set; } 
    public string PortfolioUrl { get; set; }
}