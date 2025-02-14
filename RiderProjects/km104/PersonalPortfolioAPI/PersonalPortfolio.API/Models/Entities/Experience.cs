using System.ComponentModel.DataAnnotations;

namespace PersonalPortfolio.API.Models.Entities;

public class Experience
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Company { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Description { get; set; }
}