using System.ComponentModel.DataAnnotations;
using Microsoft.OpenApi.MicrosoftExtensions;

namespace WebApplication1.Models
{
  public class TaskItem
  {
    public int Id {get;set;}

    [Required(ErrorMessage = "Title is required.")]
    public string Title {get;set;} = string.Empty;

    public string? Description { get; set; }

    [Required(ErrorMessage = "Status is required.")]
    public string Status { get; set; } = "Todo";

    [Required(ErrorMessage = "Priority is required.")]
    public string Priority { get; set; } = "Medium";

    public DateTime? DueDate { get; set; }
  }
}