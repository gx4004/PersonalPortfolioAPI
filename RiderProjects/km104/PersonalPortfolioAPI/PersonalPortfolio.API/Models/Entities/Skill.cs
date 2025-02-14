using System.ComponentModel.DataAnnotations;

namespace PersonalPortfolio.API.Models.Entities;

public class Skill
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Proficiency { get; set; }
}