using System.ComponentModel.DataAnnotations;

namespace PersonalPortfolio.API.Models.Entities;

public class Education
{
    [Key]
    public int Id { get; set; }
    public string Degree { get; set; }
    public string University { get; set; }
    public string FieldOfStudy { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}