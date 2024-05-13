using Health.Models.Health;
using Microsoft.AspNetCore.Mvc;

namespace Health.Controllers
{
    public class HealthController : Controller
    {
        public IActionResult BMI()
        {
            ViewBag.BMI = -1;
            return View();
        }

        [HttpPost]
        public IActionResult BMI(BMICalculationModel model)
        {
            ViewBag.BMI = Math.Round(model.Weight / Math.Pow((double)model.Height / 100, 2), 1);
            return View(model);
        }

        public IActionResult Calories()
        {
            ViewBag.Calories = -1;
            return View();
        }

        [HttpPost]
        public IActionResult Calories(CaloriesCalculationModel model)
        {
            var h = (double)model.Minites / 60;

            var perHour = model.Sport switch
            {
                "Футбол" => 420,
                "Аеробика" => 500,
                "Боулинг" => 200,
                "Тенис на корт" => 540,
                "Волейбол" => 220
            };

            ViewBag.Calories = h * perHour;

            return View(model);
        }

        public IActionResult Biorhythms()
        {
            ViewBag.Bio = -1;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Biorhythms(BiorhythmsCalculationModel model)
        {
            var days = (DateTime.Now - model.BirthDate).TotalDays;

            var cycle = model.Status switch
            {
                "физическо" => 23,
                "емоционално" => 28,
                "интелектуално" => 33,
            };

            ViewBag.Bio = 100 * Math.Sin(360 * (days / cycle));
            ViewBag.BioStatus = model.Status;

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Illness()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> grubnachno_izkrivqvane()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> suvremenni_akcenti_na_zdravnoto_vuzpitanie_i_obrazovanie_v_bulgarskoto_uchilishte()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> lipsata_na_dvijenie_se_otrazqva_neblagopriqtno_na_zdraveto_na_podrastvashtite()
        {
            return View();
        }
    }
}
