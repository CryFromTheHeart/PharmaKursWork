using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PharmaKursWork.ViewModels.ChallengerViewModels
{
    public class ChallengerViewModel
    {
        public SelectList ChallengeSelectList { get; set; }

        public ChallengerModel ChallengerModel { get; set; }
    }

    public class ChallengerModel
    {
        public int Id { get; set; }

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Укажите имя")]
        public string FirstName { get; set; }

        [DisplayName("Фамилия")]
        [Required(ErrorMessage = "Укажите фамилию")]
        public string LastName { get; set; }

        [DisplayName("Противопоказания")]
        [Required(ErrorMessage = "Укажите противопоказания")]
        public string Contraindications { get; set; }

        [DisplayName("Испытание")]
        [Required(ErrorMessage = "Укажите испытание")]
        public int ChallengeId { get; set; }

    }
}
