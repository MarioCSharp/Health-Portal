using System.ComponentModel.DataAnnotations;

namespace Health.Models.Health
{
    public class BiorhythmsCalculationModel
    {
        [Required]
        [Display(Name = "Рожденна дата")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Display(Name = "Статус")]
        public string Status { get; set; } = null!;
    }
}
