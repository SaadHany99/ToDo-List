using System.ComponentModel.DataAnnotations;

namespace ToDo_List.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        public bool isDone { get; set; }

    }
}
