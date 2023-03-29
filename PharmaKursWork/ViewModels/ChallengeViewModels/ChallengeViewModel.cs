using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PharmaKursWork.ViewModels.ChallengeViewModels
{
    public class ChallengeView
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        [Required(ErrorMessage = "Укажите название")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Начало испытания")]
        [Required(ErrorMessage = "Укажите начало испытания")]
        public DateTime ChallegesStart { get; set; }

        [DisplayName("Испытание курирует")]
        [Required(ErrorMessage = "Укажите Ученого")]
        public string ScientistName { get; set; } = string.Empty;

        [DisplayName("Название лекарства")]
        [Required(ErrorMessage = "Укажите название")]
        public string MedName { get; set; } = string.Empty;

        [DisplayName("Ответственный за работу приборов")]
        [Required(ErrorMessage = "Укажите тех персонал")]
        public string TechStaffName { get; set; } = string.Empty;
    }
    public class ChallengeViewModel
    {
        public SelectList MedSelectList { get; set; }
        public AddChallengeViewModel AddView { get; set; }
        public ChallengeView View { get; set; }
        public List<ChallengeView> List { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
    }

    public class FilterViewModel
    {

        [DisplayName("Минимальная дата")]
        public DateTime MinChallegesStart { get; set; }

        [DisplayName("Максимальная дата")]
        public DateTime MaxChallegesStart { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }
    }
}
