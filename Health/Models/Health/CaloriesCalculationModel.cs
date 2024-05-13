using System.ComponentModel.DataAnnotations;

namespace Health.Models.Health
{
    public class CaloriesCalculationModel
    {
        [Required]
        [Display(Name = "Минути тренировка")]
        public int Minites { get; set; }
        [Required]
        [Display(Name = "Спорт")]
        public string Sport { get; set; } = null!;
    }
}
