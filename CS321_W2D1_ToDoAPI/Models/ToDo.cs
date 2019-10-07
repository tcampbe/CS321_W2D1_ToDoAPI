using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W2D1_ToDoAPI.Models
{
    public class ToDo
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "A Description must be provided") ]
        [MaxLength(80, ErrorMessage = "Description should be no more than 80 characters.")]
        [MinLength(3, ErrorMessage = "The Descripton must be 3 characters or longer")]
        public string Description { get; set; }

        public bool IsComplete { get; set; }

        public DateTime DueDate { get; set; }
    }
}
