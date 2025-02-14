using System.ComponentModel.DataAnnotations;

namespace PersonalPortfolio.API.Models.Entities;

public class Project
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string RepositoryUrl { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}