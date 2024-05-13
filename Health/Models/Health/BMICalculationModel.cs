using System.ComponentModel.DataAnnotations;

namespace Health.Models.Health
{
    public class BMICalculationModel
    {
        [Required]
        [Display(Name = "Височина(см.)")]
        public int Height { get; set; }
        [Required]
        [Display(Name = "Тегло(кг.)")]
        public int Weight { get; set; }
    }
}
