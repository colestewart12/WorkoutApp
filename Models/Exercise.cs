using System.ComponentModel.DataAnnotations;

namespace WorkoutApp.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string MuscleGroup { get; set; }

        [Required]
        [Range(1, 10)]
        public int Difficulty { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public string Equipment { get; set; }
    }
}
