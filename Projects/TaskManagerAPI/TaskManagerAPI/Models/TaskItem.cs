using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerAPI.Models
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; } = string.Empty;
    }
}
