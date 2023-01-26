using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PharmaKursWork.ViewModels.ChallengeViewModels
{
    public class EditChallengeViewModel
    {
        public EditChallengeModal EditChallengeModal { get; set; }
        public SelectList MedSelectList { get; set; }
        public SelectList ScientistSelectList { get; set; }
        public SelectList TechStaffSelectList { get; set; }
    }

    public class EditChallengeModal
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        [Required(ErrorMessage = "Укажите название")]
        public string Name { get; set; }

        [DisplayName("Начало испытания")]
        [Required(ErrorMessage = "Укажите начало испытания")]
        public DateTime ChallegesStart { get; set; }

        [DisplayName("Конец испытания")]
        [Required(ErrorMessage = "Укажите конец испытания")]
        public DateTime ChallegesEnd { get; }

        [DisplayName("Испытание курирует")]
        [Required(ErrorMessage = "Укажите Ученого")]
        public int ScientistId { get; set; }

        [DisplayName("Название лекарства")]
        [Required(ErrorMessage = "Укажите название")]
        public int MedId { get; set; }

        [DisplayName("Ответственный за работу приборов")]
        [Required(ErrorMessage = "Укажите тех персонал")]
        public int TechStaffId { get; set; }
    }
}
