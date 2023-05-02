using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class TodoItem
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Description { get; set; } = string.Empty;
    }
}
