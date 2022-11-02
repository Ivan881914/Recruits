using System.ComponentModel.DataAnnotations;

namespace Recruits.Model;
public class Category
{
    [Key]
    public int Id { get; set; }
    //[Required]
    public string? RecruitName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? RecruitLink { get; set; }
    public string? RecruitJobTitle { get; set; }
    public string? FirstInterview { get; set; }
    public string? HRName { get; set; }
    public string? HRJobTitle { get; set; }
    public string? TestRealizationTime { get; set; }
    public string? TestСompletionTime { get; set; }
    public string? Comment { get; set; }


}

